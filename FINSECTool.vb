
' Required imports
Imports System.Data.OleDb
Imports System.Data
Imports System.Windows.Forms
Imports System
Imports System.IO
Imports System.Threading

' Change line 181 to your host 400 and target library
Public Class FINSECTool

    ' Public members of this class ( Left over from integration with AS400Command )
    Public UserID
    Public Password


    Public finseclist2
    Dim list As List(Of String) = New List(Of String)
    Public ListBox1ItemsBackup As ListBox.ObjectCollection

    ' Private members of this class
    Private Property userFlag As Integer
    Private setPRH As String
    Private setAPH As String
    Private Property setAP As Char
    Private Property setPR As Char
    Private MyOleDbConnection As OleDbConnection
    Private sqlCMD2 As OleDbCommand
    Private insmod As String
    Private as400Split() As String
    Private dataSet1 As New DataSet()
    Private adp2 As OleDb.OleDbDataAdapter
    Private dt As DataTable

    ' Function performs inital load of FINSECTool
    Private Sub FINSECTool_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        InitListBox()
        dataSet1.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        FunctionModify.Checked = True

    End Sub

    ' Function Closes the program
    Private Sub Close_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADVClose.Click, Close_Button.Click, MyBase.Click

        'Close any left open connections
        SQLConnectionClose()
        LoginForm1.Close()

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    ' Function performs multisystem processing from the simple modify tab
    Private Sub Execute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Execute.Click
        Dim userid As String
        Dim as400 As String

        userid = TextBox1.Text
        userid = Trim(userid)
        userid = userid.ToUpper


        ' Loop through the list of systems selected
        For Each as400 In ListBox2.Items

            ' Delete a user
            If userFlag = 1 Then

                SQLConnection(as400)
                SQLCommand(userid, 0)

                ' Issue the delete
                Try
                    sqlCMD2.ExecuteNonQuery()
                    TextBox2.AppendText("Delete command succeded on " & as400 & " For userid " & userid & vbCrLf)
                Catch
                    TextBox2.AppendText("Delete action failed on " & as400 & " For userid " & userid & " user may not exist on this system" & vbCrLf)
                    Application.DoEvents()
                End Try
                SQLConnectionClose()


                ' Modify a user
            ElseIf userFlag = -1 Then
                SQLConnection(as400)
                sqlCMD2 = New OleDbCommand("SELECT PRH, APH, PRFLAG, APFLAG FROM " & as400Split(1) & ".FINSECF WHERE USERID ='" & userid & "'", MyOleDbConnection)
                Dim tmpPRH As String
                Dim tmpAPH As String
                Dim tmpPR As String
                Dim tmpAP As String

                ' Read the users current data
                Dim reader As OleDbDataReader
                reader = sqlCMD2.ExecuteReader()

                If reader.Read() Then
                    tmpPRH = reader.GetValue(0).ToString()
                    tmpAPH = reader.GetValue(1).ToString()
                    tmpPR = reader.GetValue(2).ToString()
                    tmpAP = reader.GetValue(3).ToString()

                    SQLConnectionClose()

                    ' If ignore is selected for any field of interest use the retrieved information for the update
                    If setAP = "I" Then
                        setAP = tmpAP
                    End If

                    If setPR = "I" Then
                        setPR = tmpPR
                    End If

                    If setAPH = "I" Then
                        setAPH = tmpAPH
                    End If

                    If setPRH = "I" Then
                        setPRH = tmpPRH
                    End If

                    ' Sets up the command string for the update
                    insmod = New String("SET PRH ='" & setPRH & "', APH ='" & setAPH & "', PRFLAG='" & setPR & "', APFLAG='" & setAP & "'")

                End If

                SQLConnection(as400)
                SQLCommand(userid, 4)

                ' Issue the update
                Try
                    sqlCMD2.ExecuteNonQuery()

                    TextBox2.AppendText("Update command succeded on " & as400 & " For userid " & userid & vbCrLf)
                Catch
                    TextBox2.AppendText("update action failed on " & as400 & " For userid " & userid & ", user may not exist on this system" & vbCrLf)
                End Try

                SQLConnectionClose()

                ' Create a User
            ElseIf userFlag = 0 Then

                ' Set up the command string for the creation
                insmod = New String("'" & setPRH & "', ' ', '" & setAPH & "', 0, 0, '" & setPR & "', '" & setAP & "'")


                SQLConnection(as400)
                SQLCommand(userid, 3)

                ' Issue the create command
                Try
                    sqlCMD2.ExecuteNonQuery()
                    TextBox2.AppendText("Create action succeded on " & as400 & " For userid " & userid & vbCrLf)
                Catch
                    TextBox2.AppendText("Create action failed on " & as400 & " For userid " & userid & ", user may already exist on this system" & vbCrLf)
                End Try

                SQLConnectionClose()

            End If
        Next

        ResetBasic()

    End Sub

    ' Function populates the List boxes
    Private Sub InitListBox()
        ListBox2.Items.Clear()
        ListBox1.Items.Clear()
        UserID = LoginForm1.UserID
        Password = LoginForm1.Password

        Dim command1 As New OleDbCommand
        SQLConnection("srcHost srcLibrary")
        command1 = New OleDbCommand("SELECT HMSYSTM, HMFLELB FROM CHCFLE." & as400Split(1) & " WHERE hmhosp4 = hmentity4", MyOleDbConnection)
        'command1 = New OleDbCommand("SELECT HMSYSTM, HMFLELB FROM HOSPFSPM." & as400Split(1) & " WHERE hmhosp4 = hmentity4", MyOleDbConnection) ' Here for testing purposes

        Dim reader As OleDbDataReader
        reader = command1.ExecuteReader()
        Do While reader.Read()
            If reader.GetString(1) <> "" And reader.GetString(0) <> "MEDITECH" And reader.GetString(0) <> "LAWSON" Then
                ListBox1.Items.Add(reader.GetString(0) & " " & reader.GetString(1))
            End If
        Loop


        reader.Close()
        SQLConnectionClose()

        ListBox1.Sorted = True

    End Sub

    ' Function transfers the selected items from Listbox1 to Listbox2
    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        While ListBox1.SelectedItems.Count > 0

            ListBox2.Items.Add(ListBox1.SelectedItems(0))

            ListBox1.Items.Remove(ListBox1.SelectedItems(0))

        End While

    End Sub

    ' Function transfers the selected items from Listbox2 to Listbox1
    Private Sub RemoveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveButton.Click
        While ListBox2.SelectedItems.Count > 0

            ListBox1.Items.Add(ListBox2.SelectedItems(0))

            ListBox2.Items.Remove(ListBox2.SelectedItems(0))
        End While

        ListBox1.Sorted = True
    End Sub

    ' Function removes all by reseting the List boxes
    Private Sub RemoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveAll.Click

        InitListBox()

    End Sub

    ' Function adds all in listbox1 to listbox2
    Private Sub AddAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddAll.Click
        Dim item As String

        For Each item In ListBox1.Items
            ListBox2.Items.Add(item)
        Next

        ListBox1.Items.Clear()

    End Sub

    ' APLFlag add on simple modify tab
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles APFLAGAdd.CheckedChanged
        If APFLAGAdd.Checked Then
            setAP = "Y"

        End If

    End Sub

    ' APFlag remove on simple modify tab
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles APFLAGRemove.CheckedChanged
        If APFLAGRemove.Checked Then
            setAP = "N"

        End If

    End Sub

    ' APFlag ignore on simple modify tab
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles APFLAGIgnore.CheckedChanged
        If APFLAGIgnore.Checked Then
            setAP = "I"

        End If

    End Sub

    ' PRFlag add on simple modify tab
    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRFLAGAdd.CheckedChanged
        If PRFLAGAdd.Checked Then
            setPR = "Y"

        End If

    End Sub

    ' PRFlag remove on simple modify tab
    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRFLAGRemove.CheckedChanged
        If PRFLAGRemove.Checked Then
            setPR = "N"

        End If

    End Sub

    ' PRFlag ignore on simple modify tab
    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRFLAGIgnore.CheckedChanged
        If PRFLAGIgnore.Checked Then
            setPR = "I"
        End If

    End Sub

    'Function add on simple modify tab
    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FunctionAdd.CheckedChanged
        If FunctionAdd.Checked Then
            APFLAGRemove.Checked = True
            PRFLAGRemove.Checked = True
            PRHRemove.Checked = True
            APHRemove.Checked = True
            APFLAGAdd.Enabled = True
            APFLAGRemove.Enabled = True
            APFLAGIgnore.Enabled = False
            PRFLAGAdd.Enabled = True
            PRFLAGRemove.Enabled = True
            PRFLAGIgnore.Enabled = False
            PRHAdd.Enabled = True
            PRHRemove.Enabled = True
            PRHIgnore.Enabled = False
            APHAdd.Enabled = True
            APHRemove.Enabled = True
            APHIgnore.Enabled = False

            userFlag = 0
        End If

    End Sub

    ' Function remove on simple modify tab
    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FunctionRemove.CheckedChanged
        If FunctionRemove.Checked Then
            APFLAGIgnore.Checked = True
            PRFLAGIgnore.Checked = True
            APHIgnore.Checked = True
            PRHIgnore.Checked = True
            APFLAGAdd.Enabled = False
            APFLAGRemove.Enabled = False
            APFLAGIgnore.Enabled = True
            PRFLAGAdd.Enabled = False
            PRFLAGRemove.Enabled = False
            PRFLAGIgnore.Enabled = True
            PRHAdd.Enabled = False
            PRHRemove.Enabled = False
            PRHIgnore.Enabled = True
            APHAdd.Enabled = False
            APHRemove.Enabled = False
            APHIgnore.Enabled = True

            userFlag = 1
        End If

    End Sub

    ' Function modify on simple modify tab
    Private Sub RadioButton9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FunctionModify.CheckedChanged
        If FunctionModify.Checked Then
            APFLAGIgnore.Checked = True
            PRFLAGIgnore.Checked = True
            APHIgnore.Checked = True
            PRHIgnore.Checked = True
            APFLAGAdd.Enabled = True
            APFLAGRemove.Enabled = True
            APFLAGIgnore.Enabled = True
            PRFLAGAdd.Enabled = True
            PRFLAGRemove.Enabled = True
            PRFLAGIgnore.Enabled = True
            PRHAdd.Enabled = True
            PRHRemove.Enabled = True
            PRHIgnore.Enabled = True
            APHAdd.Enabled = True
            APHRemove.Enabled = True
            APHIgnore.Enabled = True

            userFlag = -1
        End If

    End Sub

    ' APH add on simple mode tab
    Private Sub RadioButton15_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles APHAdd.CheckedChanged
        If APHAdd.Checked Then
            setAPH = "ALL"
        End If

    End Sub

    'APH remove on simple mode tab
    Private Sub RadioButton14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles APHRemove.CheckedChanged
        If APHRemove.Checked Then
            setAPH = " "
        End If

    End Sub

    'APH ignore on simple mode tab
    Private Sub RadioButton13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles APHIgnore.CheckedChanged
        If APHIgnore.Checked Then
            setAPH = "I"
        End If

    End Sub

    ' PRH add on simple mode tab
    Private Sub RadioButton12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRHAdd.CheckedChanged
        If PRHAdd.Checked Then
            setPRH = "ALL"
        End If

    End Sub

    ' PRH remove on simple mode tab
    Private Sub RadioButton11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRHRemove.CheckedChanged
        If PRHRemove.Checked Then
            setPRH = " "
        End If

    End Sub

    ' PRH ignore on simple mode tab
    Private Sub RadioButton10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRHIgnore.CheckedChanged
        If PRHIgnore.Checked Then
            setPRH = "I"
        End If

    End Sub

    ' Function performes initial search from the advanced tab 'Search' 
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim mySystem As String

        mySystem = ListBox2.Items.Item(0)
        Label9.Text = mySystem
        GetFINSEC(mySystem)
        AddAll.Enabled = False
        RemoveAll.Enabled = False
        AddButton.Enabled = False
        RemoveButton.Enabled = False
        Button6.Enabled = False
        Button8.Enabled = True

    End Sub

    ' Function populates the data grid in the advanced tab
    Private Sub GetFINSEC(ByVal as400 As String)

        Dim userid As String

        dataSet1.Clear()

        userid = TextBox3.Text
        userid = Trim(userid)
        userid = userid.ToUpper()

        SQLConnection(as400)

        If userid = "" Then
            sqlCMD2 = New OleDbCommand("SELECT * FROM " & as400Split(1) & ".FINSECF", MyOleDbConnection)
        Else
            SQLCommand(userid, 2)
        End If

        adp2 = New OleDb.OleDbDataAdapter(sqlCMD2)

        Try
            adp2.Fill(dataSet1, "FINSEC")
            dataSet1.EnforceConstraints = False
            DataGridView1.DataSource = dataSet1
            DataGridView1.DataMember = "FINSEC"
            DataGridView1.ColumnHeadersVisible = True
            DataGridView1.Show()

        Catch
            TextBox2.AppendText("NO ENTRIES AVAILABLE ON THIS SYSTEM " & vbCrLf)

        End Try

        SQLConnectionClose()

    End Sub

    ' Function forces all updates in the advanced tab grid to be in uppercase 
    Private Sub dataGridView1_CellFormatting(ByVal sender As Object, _
    ByVal e As DataGridViewCellFormattingEventArgs) _
    Handles DataGridView1.CellFormatting
        If e.Value IsNot Nothing Then
            Try
                Dim stringValue As String = _
                CType(e.Value, String)
                stringValue = stringValue.ToUpper()
            Catch
            End Try

        End If
    End Sub

    ' Function forces all data entered into the grid in the advanced tab to be uppercase
    Private Sub DataGridView1_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
        If TypeOf e.Control Is TextBox Then
            DirectCast(e.Control, TextBox).CharacterCasing = CharacterCasing.Upper
        End If
    End Sub

    'Function updates the grid in advanced view
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        SQLConnection(ListBox2.Items.Item(0))

        Dim selectCommand As String = "SELECT * FROM " & as400Split(1)
        Dim adapter As OleDbDataAdapter = _
            New OleDbDataAdapter(selectCommand, MyOleDbConnection)

        adapter.InsertCommand = New OleDbCommand("INSERT INTO " & as400Split(1) & ".FINSECF (USERID, SS0003, PRH, GLH, APH, FRMBT1, TOBT1, PRFLAG, APFLAG, SS0004)" & _
                                                 " VALUES (COALESCE(?, ' '), COALESCE(?, ' '), COALESCE(?, ' '), COALESCE(?, ' '), COALESCE(?, ' '), COALESCE(?, ' '), COALESCE(?, ' '), COALESCE(?, ' '), COALESCE(?, ' '), COALESCE(?, ' '))", MyOleDbConnection)

        adapter.UpdateCommand = New OleDbCommand("UPDATE " & as400Split(1) & ".FINSECF SET SS0003 = ?, PRH = ?, GLH = ?, APH = ?, FRMBT1 = ?, TOBT1 = ?, PRFLAG = ?, APFLAG = ?, SS0004 = ? WHERE USERID = ?", MyOleDbConnection)

        adapter.DeleteCommand = New OleDbCommand("DELETE FROM " & as400Split(1) & ".FINSECF WHERE USERID = ?", MyOleDbConnection)

        ' Create the parameters.
        adapter.InsertCommand.Parameters.Add( _
            "@USERID", OleDbType.Char, 50, "USERID")
        adapter.InsertCommand.Parameters.Add( _
            "@SS0003", OleDbType.Char, 50, "SS0003")
        adapter.InsertCommand.Parameters.Add( _
            "@PRH", OleDbType.Char, 30, "PRH")
        adapter.InsertCommand.Parameters.Add( _
            "@GLH", OleDbType.Char, 30, "GLH")
        adapter.InsertCommand.Parameters.Add( _
            "@APH", OleDbType.Char, 30, "APH")
        adapter.InsertCommand.Parameters.Add( _
            "@FRMBT1", OleDbType.Integer, 4, "FRMBT1")
        adapter.InsertCommand.Parameters.Add( _
            "@TOBT1", OleDbType.Integer, 4, "TOBT1")
        adapter.InsertCommand.Parameters.Add( _
            "@PRFLAG", OleDbType.Char, 10, "PRFLAG")
        adapter.InsertCommand.Parameters.Add( _
            "@APFLAG", OleDbType.Char, 10, "APFLAG")
        adapter.InsertCommand.Parameters.Add( _
            "@SS0004", OleDbType.Char, 40, "SS0004")

        ' Update parameters
        adapter.UpdateCommand.Parameters.Add( _
            "@SS0003", OleDbType.Char, 20, "SS0003")
        adapter.UpdateCommand.Parameters.Add( _
            "@PRH", OleDbType.Char, 80, "PRH")
        adapter.UpdateCommand.Parameters.Add( _
            "@GLH", OleDbType.Char, 80, "GLH")
        adapter.UpdateCommand.Parameters.Add( _
            "@APH", OleDbType.Char, 80, "APH")
        adapter.UpdateCommand.Parameters.Add( _
            "@FRMBT1", OleDbType.Char, 20, "FRMBT1")
        adapter.UpdateCommand.Parameters.Add( _
            "@TOBT1", OleDbType.Char, 20, "TOBT1")
        adapter.UpdateCommand.Parameters.Add( _
            "@PRFLAG", OleDbType.Char, 10, "PRFLAG")
        adapter.UpdateCommand.Parameters.Add( _
            "@APFLAG", OleDbType.Char, 10, "APFLAG")
        adapter.UpdateCommand.Parameters.Add( _
            "@SS0004", OleDbType.Char, 20, "SS0004")
        adapter.UpdateCommand.Parameters.Add( _
            "@USERID", OleDbType.Char, 10, "USERID").SourceVersion = _
            DataRowVersion.Original

        adapter.DeleteCommand.Parameters.Add( _
            "@USERID", OleDbType.Char, 30, "USERID").SourceVersion = _
            DataRowVersion.Original

        Try
            adapter.Update(dataSet1, "FINSEC")
            TextBox2.AppendText("The Update/Next command completed successfully" & vbCrLf)

        Catch
            TextBox2.AppendText("The update operation failed, Maybe you tried to update a field that requires some content with nothing" & vbCrLf)
        End Try

        'Close the connection
        SQLConnectionClose()

        ListBox2.Items.RemoveAt(0)

        If ListBox2.Items.Count > 0 Then
            GetFINSEC(ListBox2.Items.Item(0))
            Label9.Text = ListBox2.Items.Item(0)
        Else
            ResetAdvanced()

        End If

    End Sub

    ' Function builds the OLEDB connection using provided variables
    Private Function SQLConnection(ByVal as400 As String)

        Try
            as400Split = as400.Split(" ")
        Catch
            TextBox2.AppendText("You must select a system to query" & vbCrLf)
        End Try

        Try
            MyOleDbConnection = New OleDbConnection("Provider=IBMDA400.DataSource.1;" & _
                                    "Data source=" & as400Split(0) & ";" & _
                                    "User Id=" & UserID & ";" & _
                                    "Password=" & Password)

            MyOleDbConnection.Open()

            Return True

        Catch
            TextBox2.AppendText("Connection failed creation" & vbCrLf)
            Return False

        End Try

        TextBox2.AppendText("General error has occured" & vbCrLf)

    End Function

    'Function builds the SQL command
    Private Function SQLCommand(ByVal username As String, ByVal mode As Integer)

        Dim sqlMode() As String = New String(4) {"DELETE FROM ", "SELECT USERID FROM ", "SELECT * FROM ", "INSERT INTO ", "UPDATE "}

        Try
            'Define the SQL statement to extract the data from the AS400 depending on the selected mode
            If mode < 3 Then

                sqlCMD2 = New OleDbCommand(sqlMode(mode) & as400Split(1) & ".FINSECF where USERID='" & username & "'", MyOleDbConnection)

            ElseIf mode = 3 Then
                sqlCMD2 = New OleDbCommand(sqlMode(mode) & as400Split(1) & ".FINSECF (USERID, PRH, GLH, APH, FRMBT1, TOBT1, PRFLAG, APFLAG) values( " & "'" & username & "'" & ", " & insmod & ")", MyOleDbConnection)

            ElseIf mode = 4 Then
                sqlCMD2 = New OleDbCommand(sqlMode(mode) & as400Split(1) & _
                                        ".FINSECF " & insmod & " where USERID='" & username & "'", MyOleDbConnection)

            End If
            'TextBox2.AppendText("Command creation succeeded" & vbCrLf)

        Catch
            TextBox2.AppendText("Command failed creation" & vbCrLf)

        End Try

        Return True

    End Function

    ' Function closes the SQL connections
    Private Sub SQLConnectionClose()
        ' Close the SQL Connection
        Try
            MyOleDbConnection.Close()
            MyOleDbConnection.Dispose()
        Catch
        End Try

    End Sub

    ' Help for the basic tab
    Private Sub BasicHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BasicHelp.Click
        TextBox2.AppendText("Functions:" & vbCrLf & _
                             "Add - Adds a new user to the selected systems and sets the access fields as selected" & vbCrLf & _
                             "Remove - Deletes the user from the selected systems" & vbCrLf & _
                             "Modify - Sets the PRH, APH fields to ALL or blank when the flag is set to add or remove respectively" & vbCrLf & _
                             "The flags will add + 'ALL' , remove + 'Blank', or ignore (make no changes) to the specified flag and access fields" & vbCrLf)

    End Sub

    ' Help for the advanced tab
    Private Sub ADVHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADVHelp.Click
        TextBox2.AppendText("Select the desired systems to modfiy, each selected system is displayed for mdification. " & _
                              "To advance to the next selected system click Upd/Next. If no changes were made then no " & _
                              "updates will be made to the system and the next system will be displayed" & vbCrLf)
    End Sub

    ' Function rereads the system list and display in the listbox
    Private Sub UpdateSystems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateSystems.Click

        InitListBox()

    End Sub

    ' Function clears and resets the tabs
    Private Sub Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear.Click, ADVClear.Click

        ResetBasic()
        ResetAdvanced()

    End Sub

    ' Function clears and resets the advanced tab
    Private Sub ResetAdvanced()
        TextBox3.Clear()
        dataSet1.Clear()
        Button8.Enabled = False
        AddAll.Enabled = True
        RemoveAll.Enabled = True
        AddButton.Enabled = True
        RemoveButton.Enabled = True
        Button6.Enabled = True
        Label9.Text = "None Processed"
        InitListBox()

    End Sub

    ' Function clears and resets the simple modify tab
    Private Sub ResetBasic()

        TextBox1.Clear()
        InitListBox()
        FunctionModify.Checked = True
        APFLAGIgnore.Checked = True
        PRFLAGIgnore.Checked = True
        APHIgnore.Checked = True
        PRHIgnore.Checked = True
        AddAll.Enabled = True
        RemoveAll.Enabled = True
        AddButton.Enabled = True
        RemoveButton.Enabled = True

    End Sub

    ' Function resets the advanced tab when the tab renders its contents
    Private Sub TabPage2_Layout(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LayoutEventArgs) Handles TabPage2.Layout

        ResetAdvanced()

    End Sub

    ' Function resets the basic tab when the tab renders its contents
    Private Sub TabPage1_Layout(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LayoutEventArgs) Handles TabPage1.Layout

        ResetBasic()

    End Sub

    ' Function shows the splash screen
    Private Sub About_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles About.Click
        FINSECToolSplashScreen.SplashClose.Visible = True
        FINSECToolSplashScreen.ShowDialog()
        FINSECToolSplashScreen.Focus()
        FINSECToolSplashScreen.Location = Cursor.Position
    End Sub

    ' Function opens login prompt to allow changing the entered credentials
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetCredentials.Click
        LoginForm1.Show()
        Me.Hide()
    End Sub

    Private Sub FINSECTool_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        LoginForm1.Close()
    End Sub
End Class

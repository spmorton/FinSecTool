Public Class LoginForm1

    Public UserID
    Public Password

    'Private user As String
    'Private password As String

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UserID = "" Then
            MsgBox("You must enter valid credentials to continue")
        ElseIf Password = "" Then
            MsgBox("You must enter valid credentials to continue")
        Else
            Me.Hide()

            Try
                FINSECTool.ShowDialog()
                FINSECTool.Focus()
                FINSECTool.Location = Cursor.Position
            Catch
                MsgBox("You must enter valid credentials to continue")
                Me.Show()
            End Try


        End If


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()

    End Sub

    Private Sub UsernameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameTextBox.TextChanged
        UserID = UsernameTextBox.Text

    End Sub

    Private Sub PasswordTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswordTextBox.TextChanged
        Password = PasswordTextBox.Text

    End Sub
End Class

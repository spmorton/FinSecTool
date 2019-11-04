<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FINSECTool
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.RemoveAll = New System.Windows.Forms.Button()
        Me.AddAll = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Close_Button = New System.Windows.Forms.Button()
        Me.Execute = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.APFLAGIgnore = New System.Windows.Forms.RadioButton()
        Me.APFLAGRemove = New System.Windows.Forms.RadioButton()
        Me.APFLAGAdd = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PRFLAGIgnore = New System.Windows.Forms.RadioButton()
        Me.PRFLAGRemove = New System.Windows.Forms.RadioButton()
        Me.PRFLAGAdd = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.FunctionModify = New System.Windows.Forms.RadioButton()
        Me.FunctionAdd = New System.Windows.Forms.RadioButton()
        Me.FunctionRemove = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.PRHIgnore = New System.Windows.Forms.RadioButton()
        Me.PRHRemove = New System.Windows.Forms.RadioButton()
        Me.PRHAdd = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.APHIgnore = New System.Windows.Forms.RadioButton()
        Me.APHRemove = New System.Windows.Forms.RadioButton()
        Me.APHAdd = New System.Windows.Forms.RadioButton()
        Me.Clear = New System.Windows.Forms.Button()
        Me.BasicHelp = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.ADVClear = New System.Windows.Forms.Button()
        Me.ADVHelp = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.ADVClose = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.SetCredentials = New System.Windows.Forms.Button()
        Me.About = New System.Windows.Forms.Button()
        Me.UpdateSystems = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(486, -20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Selected Systems:"
        '
        'ListBox2
        '
        Me.ListBox2.AllowDrop = True
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(306, 44)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.ScrollAlwaysVisible = True
        Me.ListBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox2.Size = New System.Drawing.Size(152, 160)
        Me.ListBox2.TabIndex = 27
        '
        'RemoveButton
        '
        Me.RemoveButton.Location = New System.Drawing.Point(193, 90)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(89, 23)
        Me.RemoveButton.TabIndex = 26
        Me.RemoveButton.Text = "<-- Remove"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(193, 60)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(89, 23)
        Me.AddButton.TabIndex = 25
        Me.AddButton.Text = "Add -->"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'RemoveAll
        '
        Me.RemoveAll.Location = New System.Drawing.Point(193, 166)
        Me.RemoveAll.Name = "RemoveAll"
        Me.RemoveAll.Size = New System.Drawing.Size(89, 23)
        Me.RemoveAll.TabIndex = 24
        Me.RemoveAll.Text = "<-- Remove All"
        Me.RemoveAll.UseVisualStyleBackColor = True
        '
        'AddAll
        '
        Me.AddAll.Location = New System.Drawing.Point(193, 136)
        Me.AddAll.Name = "AddAll"
        Me.AddAll.Size = New System.Drawing.Size(89, 23)
        Me.AddAll.TabIndex = 23
        Me.AddAll.Text = "Add All -->"
        Me.AddAll.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 44)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox1.Size = New System.Drawing.Size(152, 160)
        Me.ListBox1.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(226, -20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Available Systems:"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox2.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox2.Location = New System.Drawing.Point(0, 0)
        Me.TextBox2.MaxLength = 0
        Me.TextBox2.MinimumSize = New System.Drawing.Size(480, 200)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox2.Size = New System.Drawing.Size(545, 245)
        Me.TextBox2.TabIndex = 20
        Me.TextBox2.Text = "Process Messages"
        '
        'Close_Button
        '
        Me.Close_Button.Location = New System.Drawing.Point(847, 97)
        Me.Close_Button.Name = "Close_Button"
        Me.Close_Button.Size = New System.Drawing.Size(75, 23)
        Me.Close_Button.TabIndex = 0
        Me.Close_Button.Text = "Close"
        Me.Close_Button.UseVisualStyleBackColor = True
        '
        'Execute
        '
        Me.Execute.Location = New System.Drawing.Point(693, 97)
        Me.Execute.Name = "Execute"
        Me.Execute.Size = New System.Drawing.Size(67, 23)
        Me.Execute.TabIndex = 1
        Me.Execute.Text = "Execute"
        Me.Execute.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.APFLAGIgnore)
        Me.GroupBox1.Controls.Add(Me.APFLAGRemove)
        Me.GroupBox1.Controls.Add(Me.APFLAGAdd)
        Me.GroupBox1.Location = New System.Drawing.Point(587, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(76, 100)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "APFLAG"
        Me.ToolTip1.SetToolTip(Me.GroupBox1, "Accounts payable check signing flag")
        '
        'APFLAGIgnore
        '
        Me.APFLAGIgnore.AutoSize = True
        Me.APFLAGIgnore.Checked = True
        Me.APFLAGIgnore.Location = New System.Drawing.Point(7, 67)
        Me.APFLAGIgnore.Name = "APFLAGIgnore"
        Me.APFLAGIgnore.Size = New System.Drawing.Size(55, 17)
        Me.APFLAGIgnore.TabIndex = 2
        Me.APFLAGIgnore.TabStop = True
        Me.APFLAGIgnore.Text = "Ignore"
        Me.APFLAGIgnore.UseVisualStyleBackColor = True
        '
        'APFLAGRemove
        '
        Me.APFLAGRemove.AutoSize = True
        Me.APFLAGRemove.Location = New System.Drawing.Point(7, 44)
        Me.APFLAGRemove.Name = "APFLAGRemove"
        Me.APFLAGRemove.Size = New System.Drawing.Size(65, 17)
        Me.APFLAGRemove.TabIndex = 1
        Me.APFLAGRemove.Text = "Remove"
        Me.APFLAGRemove.UseVisualStyleBackColor = True
        '
        'APFLAGAdd
        '
        Me.APFLAGAdd.AutoSize = True
        Me.APFLAGAdd.Location = New System.Drawing.Point(7, 20)
        Me.APFLAGAdd.Name = "APFLAGAdd"
        Me.APFLAGAdd.Size = New System.Drawing.Size(44, 17)
        Me.APFLAGAdd.TabIndex = 0
        Me.APFLAGAdd.Text = "Add"
        Me.APFLAGAdd.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PRFLAGIgnore)
        Me.GroupBox2.Controls.Add(Me.PRFLAGRemove)
        Me.GroupBox2.Controls.Add(Me.PRFLAGAdd)
        Me.GroupBox2.Location = New System.Drawing.Point(486, 58)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(76, 100)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PRFLAG"
        Me.ToolTip1.SetToolTip(Me.GroupBox2, "Payroll check signing flag")
        '
        'PRFLAGIgnore
        '
        Me.PRFLAGIgnore.AutoSize = True
        Me.PRFLAGIgnore.Checked = True
        Me.PRFLAGIgnore.Location = New System.Drawing.Point(6, 67)
        Me.PRFLAGIgnore.Name = "PRFLAGIgnore"
        Me.PRFLAGIgnore.Size = New System.Drawing.Size(55, 17)
        Me.PRFLAGIgnore.TabIndex = 2
        Me.PRFLAGIgnore.TabStop = True
        Me.PRFLAGIgnore.Text = "Ignore"
        Me.PRFLAGIgnore.UseVisualStyleBackColor = True
        '
        'PRFLAGRemove
        '
        Me.PRFLAGRemove.AutoSize = True
        Me.PRFLAGRemove.Location = New System.Drawing.Point(7, 44)
        Me.PRFLAGRemove.Name = "PRFLAGRemove"
        Me.PRFLAGRemove.Size = New System.Drawing.Size(65, 17)
        Me.PRFLAGRemove.TabIndex = 1
        Me.PRFLAGRemove.Text = "Remove"
        Me.PRFLAGRemove.UseVisualStyleBackColor = True
        '
        'PRFLAGAdd
        '
        Me.PRFLAGAdd.AutoSize = True
        Me.PRFLAGAdd.Location = New System.Drawing.Point(7, 20)
        Me.PRFLAGAdd.Name = "PRFLAGAdd"
        Me.PRFLAGAdd.Size = New System.Drawing.Size(44, 17)
        Me.PRFLAGAdd.TabIndex = 0
        Me.PRFLAGAdd.Text = "Add"
        Me.PRFLAGAdd.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.FunctionModify)
        Me.GroupBox3.Controls.Add(Me.FunctionAdd)
        Me.GroupBox3.Controls.Add(Me.FunctionRemove)
        Me.GroupBox3.Location = New System.Drawing.Point(170, 58)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(76, 100)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Function"
        Me.ToolTip1.SetToolTip(Me.GroupBox3, "Select desired operation")
        '
        'FunctionModify
        '
        Me.FunctionModify.AutoSize = True
        Me.FunctionModify.Checked = True
        Me.FunctionModify.Location = New System.Drawing.Point(6, 67)
        Me.FunctionModify.Name = "FunctionModify"
        Me.FunctionModify.Size = New System.Drawing.Size(56, 17)
        Me.FunctionModify.TabIndex = 2
        Me.FunctionModify.TabStop = True
        Me.FunctionModify.Text = "Modify"
        Me.FunctionModify.UseVisualStyleBackColor = True
        '
        'FunctionAdd
        '
        Me.FunctionAdd.AutoSize = True
        Me.FunctionAdd.Location = New System.Drawing.Point(6, 19)
        Me.FunctionAdd.Name = "FunctionAdd"
        Me.FunctionAdd.Size = New System.Drawing.Size(44, 17)
        Me.FunctionAdd.TabIndex = 0
        Me.FunctionAdd.Text = "Add"
        Me.FunctionAdd.UseVisualStyleBackColor = True
        '
        'FunctionRemove
        '
        Me.FunctionRemove.AutoSize = True
        Me.FunctionRemove.Location = New System.Drawing.Point(6, 43)
        Me.FunctionRemove.Name = "FunctionRemove"
        Me.FunctionRemove.Size = New System.Drawing.Size(65, 17)
        Me.FunctionRemove.TabIndex = 1
        Me.FunctionRemove.Text = "Remove"
        Me.FunctionRemove.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.NullValue = " "
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Size = New System.Drawing.Size(1010, 276)
        Me.DataGridView1.TabIndex = 33
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(529, 16)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 34
        Me.Button6.Text = "Search"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(32, 98)
        Me.TextBox1.MaxLength = 10
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 35
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1024, 364)
        Me.TabControl1.TabIndex = 37
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.Clear)
        Me.TabPage1.Controls.Add(Me.BasicHelp)
        Me.TabPage1.Controls.Add(Me.Execute)
        Me.TabPage1.Controls.Add(Me.Close_Button)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1016, 338)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Simple Modify"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "User ID"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.PRHIgnore)
        Me.GroupBox4.Controls.Add(Me.PRHRemove)
        Me.GroupBox4.Controls.Add(Me.PRHAdd)
        Me.GroupBox4.Location = New System.Drawing.Point(284, 58)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(76, 100)
        Me.GroupBox4.TabIndex = 39
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "PRH"
        Me.ToolTip1.SetToolTip(Me.GroupBox4, "Payroll defaults to ALL, use advanced tab for detailed adjustments")
        '
        'PRHIgnore
        '
        Me.PRHIgnore.AutoSize = True
        Me.PRHIgnore.Checked = True
        Me.PRHIgnore.Location = New System.Drawing.Point(6, 67)
        Me.PRHIgnore.Name = "PRHIgnore"
        Me.PRHIgnore.Size = New System.Drawing.Size(55, 17)
        Me.PRHIgnore.TabIndex = 2
        Me.PRHIgnore.TabStop = True
        Me.PRHIgnore.Text = "Ignore"
        Me.PRHIgnore.UseVisualStyleBackColor = True
        '
        'PRHRemove
        '
        Me.PRHRemove.AutoSize = True
        Me.PRHRemove.Location = New System.Drawing.Point(7, 44)
        Me.PRHRemove.Name = "PRHRemove"
        Me.PRHRemove.Size = New System.Drawing.Size(65, 17)
        Me.PRHRemove.TabIndex = 1
        Me.PRHRemove.Text = "Remove"
        Me.PRHRemove.UseVisualStyleBackColor = True
        '
        'PRHAdd
        '
        Me.PRHAdd.AutoSize = True
        Me.PRHAdd.Location = New System.Drawing.Point(7, 20)
        Me.PRHAdd.Name = "PRHAdd"
        Me.PRHAdd.Size = New System.Drawing.Size(72, 17)
        Me.PRHAdd.TabIndex = 0
        Me.PRHAdd.Text = "Add (ALL)"
        Me.PRHAdd.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.APHIgnore)
        Me.GroupBox5.Controls.Add(Me.APHRemove)
        Me.GroupBox5.Controls.Add(Me.APHAdd)
        Me.GroupBox5.Location = New System.Drawing.Point(385, 58)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(76, 100)
        Me.GroupBox5.TabIndex = 38
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "APH"
        Me.ToolTip1.SetToolTip(Me.GroupBox5, "Accounts Payable defaults to ALL, use advanced tab for detailed adjustments")
        '
        'APHIgnore
        '
        Me.APHIgnore.AutoSize = True
        Me.APHIgnore.Checked = True
        Me.APHIgnore.Location = New System.Drawing.Point(7, 67)
        Me.APHIgnore.Name = "APHIgnore"
        Me.APHIgnore.Size = New System.Drawing.Size(55, 17)
        Me.APHIgnore.TabIndex = 2
        Me.APHIgnore.TabStop = True
        Me.APHIgnore.Text = "Ignore"
        Me.APHIgnore.UseVisualStyleBackColor = True
        '
        'APHRemove
        '
        Me.APHRemove.AutoSize = True
        Me.APHRemove.Location = New System.Drawing.Point(7, 44)
        Me.APHRemove.Name = "APHRemove"
        Me.APHRemove.Size = New System.Drawing.Size(65, 17)
        Me.APHRemove.TabIndex = 1
        Me.APHRemove.Text = "Remove"
        Me.APHRemove.UseVisualStyleBackColor = True
        '
        'APHAdd
        '
        Me.APHAdd.AutoSize = True
        Me.APHAdd.Location = New System.Drawing.Point(7, 20)
        Me.APHAdd.Name = "APHAdd"
        Me.APHAdd.Size = New System.Drawing.Size(72, 17)
        Me.APHAdd.TabIndex = 0
        Me.APHAdd.Text = "Add (ALL)"
        Me.APHAdd.UseVisualStyleBackColor = True
        '
        'Clear
        '
        Me.Clear.Location = New System.Drawing.Point(766, 97)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(75, 23)
        Me.Clear.TabIndex = 37
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'BasicHelp
        '
        Me.BasicHelp.Location = New System.Drawing.Point(928, 97)
        Me.BasicHelp.Name = "BasicHelp"
        Me.BasicHelp.Size = New System.Drawing.Size(75, 23)
        Me.BasicHelp.TabIndex = 36
        Me.BasicHelp.Text = "Help"
        Me.BasicHelp.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SplitContainer3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1016, 338)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Advanced Search / Modify"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SplitContainer3
        '
        Me.SplitContainer3.AccessibleDescription = "Bottom half of screen"
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.IsSplitterFixed = True
        Me.SplitContainer3.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.ADVClear)
        Me.SplitContainer3.Panel1.Controls.Add(Me.ADVHelp)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Button8)
        Me.SplitContainer3.Panel1.Controls.Add(Me.ADVClose)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Button6)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer3.Panel1.Controls.Add(Me.TextBox3)
        Me.SplitContainer3.Panel1MinSize = 52
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer3.Panel2MinSize = 270
        Me.SplitContainer3.Size = New System.Drawing.Size(1010, 332)
        Me.SplitContainer3.SplitterDistance = 52
        Me.SplitContainer3.TabIndex = 37
        '
        'ADVClear
        '
        Me.ADVClear.Location = New System.Drawing.Point(691, 16)
        Me.ADVClear.Name = "ADVClear"
        Me.ADVClear.Size = New System.Drawing.Size(75, 23)
        Me.ADVClear.TabIndex = 47
        Me.ADVClear.Text = "Clear"
        Me.ADVClear.UseVisualStyleBackColor = True
        '
        'ADVHelp
        '
        Me.ADVHelp.Location = New System.Drawing.Point(853, 16)
        Me.ADVHelp.Name = "ADVHelp"
        Me.ADVHelp.Size = New System.Drawing.Size(75, 23)
        Me.ADVHelp.TabIndex = 46
        Me.ADVHelp.Text = "Help"
        Me.ADVHelp.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(314, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 17)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "None Processed"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(183, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 13)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Current System / HOSPF"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(610, 16)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 38
        Me.Button8.Text = "Upd/Next"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'ADVClose
        '
        Me.ADVClose.Location = New System.Drawing.Point(772, 16)
        Me.ADVClose.Name = "ADVClose"
        Me.ADVClose.Size = New System.Drawing.Size(75, 23)
        Me.ADVClose.TabIndex = 37
        Me.ADVClose.Text = "Close"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "User ID (Blank for all)"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(25, 18)
        Me.TextBox3.MaxLength = 10
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(132, 20)
        Me.TextBox3.TabIndex = 35
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.SetCredentials)
        Me.TabPage3.Controls.Add(Me.About)
        Me.TabPage3.Controls.Add(Me.UpdateSystems)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1016, 338)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Configure"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'SetCredentials
        '
        Me.SetCredentials.Location = New System.Drawing.Point(9, 34)
        Me.SetCredentials.Name = "SetCredentials"
        Me.SetCredentials.Size = New System.Drawing.Size(123, 23)
        Me.SetCredentials.TabIndex = 3
        Me.SetCredentials.Text = "Set Credentials"
        Me.SetCredentials.UseVisualStyleBackColor = True
        '
        'About
        '
        Me.About.Location = New System.Drawing.Point(8, 64)
        Me.About.Name = "About"
        Me.About.Size = New System.Drawing.Size(123, 23)
        Me.About.TabIndex = 2
        Me.About.Text = "About"
        Me.About.UseVisualStyleBackColor = True
        '
        'UpdateSystems
        '
        Me.UpdateSystems.Location = New System.Drawing.Point(9, 6)
        Me.UpdateSystems.Name = "UpdateSystems"
        Me.UpdateSystems.Size = New System.Drawing.Size(123, 23)
        Me.UpdateSystems.TabIndex = 1
        Me.UpdateSystems.Text = "Update System List"
        Me.UpdateSystems.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Available Systems"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(306, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Selected Systems"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.AccessibleDescription = "Top half of screen"
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ListBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ListBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AddAll)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RemoveAll)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AddButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RemoveButton)
        Me.SplitContainer1.Panel1MinSize = 475
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1024, 245)
        Me.SplitContainer1.SplitterDistance = 475
        Me.SplitContainer1.TabIndex = 36
        '
        'SplitContainer2
        '
        Me.SplitContainer2.AccessibleDescription = "The Screen"
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer1)
        Me.SplitContainer2.Panel1MinSize = 245
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1024, 613)
        Me.SplitContainer2.SplitterDistance = 245
        Me.SplitContainer2.TabIndex = 38
        '
        'FINSECTool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 613)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.MinimumSize = New System.Drawing.Size(1040, 640)
        Me.Name = "FINSECTool"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FinSec Tool - Manage FINSEC Across Multiple Systems"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents RemoveButton As System.Windows.Forms.Button
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents RemoveAll As System.Windows.Forms.Button
    Friend WithEvents AddAll As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Close_Button As System.Windows.Forms.Button
    Friend WithEvents Execute As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents APFLAGIgnore As System.Windows.Forms.RadioButton
    Friend WithEvents APFLAGRemove As System.Windows.Forms.RadioButton
    Friend WithEvents APFLAGAdd As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PRFLAGIgnore As System.Windows.Forms.RadioButton
    Friend WithEvents PRFLAGRemove As System.Windows.Forms.RadioButton
    Friend WithEvents PRFLAGAdd As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents FunctionModify As System.Windows.Forms.RadioButton
    Friend WithEvents FunctionRemove As System.Windows.Forms.RadioButton
    Friend WithEvents FunctionAdd As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents ADVClose As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BasicHelp As System.Windows.Forms.Button
    Friend WithEvents ADVHelp As System.Windows.Forms.Button
    Friend WithEvents UpdateSystems As System.Windows.Forms.Button
    Friend WithEvents ADVClear As System.Windows.Forms.Button
    Friend WithEvents Clear As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents PRHIgnore As System.Windows.Forms.RadioButton
    Friend WithEvents PRHRemove As System.Windows.Forms.RadioButton
    Friend WithEvents PRHAdd As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents APHIgnore As System.Windows.Forms.RadioButton
    Friend WithEvents APHRemove As System.Windows.Forms.RadioButton
    Friend WithEvents APHAdd As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents About As System.Windows.Forms.Button
    Friend WithEvents SetCredentials As System.Windows.Forms.Button
End Class

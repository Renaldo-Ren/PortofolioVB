<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageDB = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mtxtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.cmbBlood = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.dtpDob = New System.Windows.Forms.DateTimePicker()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.dgvStudent = New System.Windows.Forms.DataGridView()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPageToDoList = New System.Windows.Forms.TabPage()
        Me.btnClearToDoList = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.nudList = New System.Windows.Forms.NumericUpDown()
        Me.btnInputNumberList = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cmbAss = New System.Windows.Forms.ComboBox()
        Me.btnInputAss = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.chlsbAss = New System.Windows.Forms.CheckedListBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lstOutputAss = New System.Windows.Forms.ListBox()
        Me.ToolTipButton = New System.Windows.Forms.ToolTip(Me.components)
        Me.imglFolder = New System.Windows.Forms.ImageList(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPageDB.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageToDoList.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.nudList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageDB)
        Me.TabControl1.Controls.Add(Me.TabPageToDoList)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(1, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(997, 503)
        Me.TabControl1.TabIndex = 2
        '
        'TabPageDB
        '
        Me.TabPageDB.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.TabPageDB.Controls.Add(Me.SplitContainer1)
        Me.TabPageDB.Controls.Add(Me.Label3)
        Me.TabPageDB.Location = New System.Drawing.Point(4, 29)
        Me.TabPageDB.Name = "TabPageDB"
        Me.TabPageDB.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDB.Size = New System.Drawing.Size(989, 470)
        Me.TabPageDB.TabIndex = 1
        Me.TabPageDB.Text = "Student Database"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 37)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtSearch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnDelete)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnSearch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnDisplay)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvStudent)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnUpdate)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnInsert)
        Me.SplitContainer1.Size = New System.Drawing.Size(983, 430)
        Me.SplitContainer1.SplitterDistance = 332
        Me.SplitContainer1.TabIndex = 25
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtLname)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtFname)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.mtxtPhone)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.radFemale)
        Me.GroupBox2.Controls.Add(Me.radMale)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.txtAddress)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.cmbBlood)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.dtpDob)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(381, 424)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Student Data"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ImageIndex = 10
        Me.Label6.ImageList = Me.imglFolder
        Me.Label6.Location = New System.Drawing.Point(3, 355)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 20)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "     "
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(138, 77)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(228, 26)
        Me.txtLname.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(40, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 20)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Last Name:"
        '
        'txtFname
        '
        Me.txtFname.Location = New System.Drawing.Point(138, 35)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(228, 26)
        Me.txtFname.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 355)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Phone: "
        '
        'mtxtPhone
        '
        Me.mtxtPhone.Location = New System.Drawing.Point(118, 354)
        Me.mtxtPhone.Mask = "(+62)000-0000-0000"
        Me.mtxtPhone.Name = "mtxtPhone"
        Me.mtxtPhone.Size = New System.Drawing.Size(248, 26)
        Me.mtxtPhone.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ImageIndex = 9
        Me.Label7.ImageList = Me.imglFolder
        Me.Label7.Location = New System.Drawing.Point(5, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 20)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "     "
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ImageIndex = 7
        Me.Label23.ImageList = Me.imglFolder
        Me.Label23.Location = New System.Drawing.Point(2, 310)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(34, 20)
        Me.Label23.TabIndex = 20
        Me.Label23.Text = "     "
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ImageIndex = 5
        Me.Label24.ImageList = Me.imglFolder
        Me.Label24.Location = New System.Drawing.Point(1, 221)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(34, 20)
        Me.Label24.TabIndex = 19
        Me.Label24.Text = "     "
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ImageIndex = 6
        Me.Label25.ImageList = Me.imglFolder
        Me.Label25.Location = New System.Drawing.Point(1, 178)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(34, 20)
        Me.Label25.TabIndex = 18
        Me.Label25.Text = "     "
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ImageIndex = 4
        Me.Label26.ImageList = Me.imglFolder
        Me.Label26.Location = New System.Drawing.Point(1, 132)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(34, 20)
        Me.Label26.TabIndex = 17
        Me.Label26.Text = "     "
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Location = New System.Drawing.Point(209, 310)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(85, 24)
        Me.radFemale.TabIndex = 9
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Location = New System.Drawing.Point(118, 311)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(66, 24)
        Me.radMale.TabIndex = 8
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(36, 312)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(69, 20)
        Me.Label28.TabIndex = 7
        Me.Label28.Text = "Gender:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(118, 221)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(248, 74)
        Me.txtAddress.TabIndex = 6
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(36, 221)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(76, 20)
        Me.Label29.TabIndex = 5
        Me.Label29.Text = "Address:"
        '
        'cmbBlood
        '
        Me.cmbBlood.AllowDrop = True
        Me.cmbBlood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBlood.FormattingEnabled = True
        Me.cmbBlood.Items.AddRange(New Object() {"A", "B", "AB", "O"})
        Me.cmbBlood.Location = New System.Drawing.Point(140, 175)
        Me.cmbBlood.Name = "cmbBlood"
        Me.cmbBlood.Size = New System.Drawing.Size(226, 28)
        Me.cmbBlood.TabIndex = 4
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(36, 178)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(98, 20)
        Me.Label30.TabIndex = 3
        Me.Label30.Text = "Blood Type:"
        '
        'dtpDob
        '
        Me.dtpDob.Location = New System.Drawing.Point(94, 128)
        Me.dtpDob.Name = "dtpDob"
        Me.dtpDob.Size = New System.Drawing.Size(272, 26)
        Me.dtpDob.TabIndex = 2
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(36, 133)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(52, 20)
        Me.Label31.TabIndex = 1
        Me.Label31.Text = "DOB:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Blue
        Me.Label32.Location = New System.Drawing.Point(40, 38)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(97, 20)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "First Name:"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(12, 13)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(489, 26)
        Me.txtSearch.TabIndex = 24
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Location = New System.Drawing.Point(507, 375)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(128, 35)
        Me.btnDelete.TabIndex = 22
        Me.btnDelete.Text = "&Delete"
        Me.ToolTipButton.SetToolTip(Me.btnDelete, "Click to Delete Data," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or Press alt + d to Delete Data" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.Info
        Me.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(507, 9)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(128, 35)
        Me.btnSearch.TabIndex = 23
        Me.btnSearch.Text = "&Search"
        Me.ToolTipButton.SetToolTip(Me.btnSearch, "Click to Search Data," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or Press alt + s to Search Data" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnDisplay
        '
        Me.btnDisplay.BackColor = System.Drawing.SystemColors.Info
        Me.btnDisplay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDisplay.Location = New System.Drawing.Point(338, 375)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(128, 35)
        Me.btnDisplay.TabIndex = 21
        Me.btnDisplay.Text = "Dis&play"
        Me.ToolTipButton.SetToolTip(Me.btnDisplay, "Click to Display Data," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or Press alt + p to Display all Data" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnDisplay.UseVisualStyleBackColor = False
        '
        'dgvStudent
        '
        Me.dgvStudent.AllowUserToOrderColumns = True
        Me.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudent.Location = New System.Drawing.Point(12, 53)
        Me.dgvStudent.Name = "dgvStudent"
        Me.dgvStudent.RowHeadersWidth = 51
        Me.dgvStudent.RowTemplate.Height = 24
        Me.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStudent.Size = New System.Drawing.Size(623, 305)
        Me.dgvStudent.TabIndex = 11
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.Info
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Location = New System.Drawing.Point(171, 375)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(128, 35)
        Me.btnUpdate.TabIndex = 20
        Me.btnUpdate.Text = "&Update"
        Me.ToolTipButton.SetToolTip(Me.btnUpdate, "Click to Update Data," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or Press alt + u to Update Data" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.SystemColors.Info
        Me.btnInsert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsert.Location = New System.Drawing.Point(12, 375)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(128, 35)
        Me.btnInsert.TabIndex = 19
        Me.btnInsert.Text = "&Insert"
        Me.ToolTipButton.SetToolTip(Me.btnInsert, "Click to Insert Data," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or Press alt + i to Insert Data" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.Font = New System.Drawing.Font("Stencil", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(330, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(340, 40)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Student Database"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TabPageToDoList
        '
        Me.TabPageToDoList.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.TabPageToDoList.Controls.Add(Me.btnClearToDoList)
        Me.TabPageToDoList.Controls.Add(Me.GroupBox7)
        Me.TabPageToDoList.Controls.Add(Me.GroupBox6)
        Me.TabPageToDoList.Controls.Add(Me.GroupBox5)
        Me.TabPageToDoList.Controls.Add(Me.Label15)
        Me.TabPageToDoList.Controls.Add(Me.lstOutputAss)
        Me.TabPageToDoList.Location = New System.Drawing.Point(4, 29)
        Me.TabPageToDoList.Name = "TabPageToDoList"
        Me.TabPageToDoList.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageToDoList.Size = New System.Drawing.Size(989, 470)
        Me.TabPageToDoList.TabIndex = 2
        Me.TabPageToDoList.Text = "To Do List"
        '
        'btnClearToDoList
        '
        Me.btnClearToDoList.BackColor = System.Drawing.SystemColors.Info
        Me.btnClearToDoList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClearToDoList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearToDoList.ForeColor = System.Drawing.Color.Black
        Me.btnClearToDoList.Location = New System.Drawing.Point(12, 424)
        Me.btnClearToDoList.Name = "btnClearToDoList"
        Me.btnClearToDoList.Size = New System.Drawing.Size(364, 36)
        Me.btnClearToDoList.TabIndex = 12
        Me.btnClearToDoList.Text = "C&lear"
        Me.btnClearToDoList.UseVisualStyleBackColor = False
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox7.Controls.Add(Me.nudList)
        Me.GroupBox7.Controls.Add(Me.btnInputNumberList)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox7.Location = New System.Drawing.Point(12, 274)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(179, 134)
        Me.GroupBox7.TabIndex = 11
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "How Many To Do List You Have?"
        '
        'nudList
        '
        Me.nudList.Location = New System.Drawing.Point(28, 49)
        Me.nudList.Name = "nudList"
        Me.nudList.Size = New System.Drawing.Size(120, 26)
        Me.nudList.TabIndex = 8
        '
        'btnInputNumberList
        '
        Me.btnInputNumberList.Location = New System.Drawing.Point(37, 81)
        Me.btnInputNumberList.Name = "btnInputNumberList"
        Me.btnInputNumberList.Size = New System.Drawing.Size(99, 36)
        Me.btnInputNumberList.TabIndex = 11
        Me.btnInputNumberList.Text = "Input"
        Me.btnInputNumberList.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox6.Controls.Add(Me.cmbAss)
        Me.GroupBox6.Controls.Add(Me.btnInputAss)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox6.Location = New System.Drawing.Point(197, 274)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(179, 134)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "To Do List No."
        '
        'cmbAss
        '
        Me.cmbAss.FormattingEnabled = True
        Me.cmbAss.Location = New System.Drawing.Point(29, 41)
        Me.cmbAss.Name = "cmbAss"
        Me.cmbAss.Size = New System.Drawing.Size(121, 28)
        Me.cmbAss.TabIndex = 9
        '
        'btnInputAss
        '
        Me.btnInputAss.Location = New System.Drawing.Point(40, 75)
        Me.btnInputAss.Name = "btnInputAss"
        Me.btnInputAss.Size = New System.Drawing.Size(99, 36)
        Me.btnInputAss.TabIndex = 10
        Me.btnInputAss.Text = "Input"
        Me.btnInputAss.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox5.Controls.Add(Me.chlsbAss)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox5.Location = New System.Drawing.Point(12, 46)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(364, 213)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Choose the Subject that Have Assignment"
        '
        'chlsbAss
        '
        Me.chlsbAss.BackColor = System.Drawing.Color.LightSkyBlue
        Me.chlsbAss.ForeColor = System.Drawing.Color.Blue
        Me.chlsbAss.FormattingEnabled = True
        Me.chlsbAss.Items.AddRange(New Object() {"Data Structure and Algorithm", "Database Management System", "Matrix and Vector", "Physics", "Server Side Internet Programming", "Visual Programming"})
        Me.chlsbAss.Location = New System.Drawing.Point(17, 49)
        Me.chlsbAss.Name = "chlsbAss"
        Me.chlsbAss.Size = New System.Drawing.Size(329, 151)
        Me.chlsbAss.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Stencil", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label15.Location = New System.Drawing.Point(371, 3)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(191, 40)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "TO DO LIST"
        '
        'lstOutputAss
        '
        Me.lstOutputAss.BackColor = System.Drawing.Color.LightSkyBlue
        Me.lstOutputAss.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOutputAss.ForeColor = System.Drawing.Color.Blue
        Me.lstOutputAss.FormattingEnabled = True
        Me.lstOutputAss.ItemHeight = 20
        Me.lstOutputAss.Location = New System.Drawing.Point(389, 46)
        Me.lstOutputAss.Name = "lstOutputAss"
        Me.lstOutputAss.Size = New System.Drawing.Size(592, 424)
        Me.lstOutputAss.TabIndex = 1
        '
        'imglFolder
        '
        Me.imglFolder.ImageStream = CType(resources.GetObject("imglFolder.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imglFolder.TransparentColor = System.Drawing.Color.Transparent
        Me.imglFolder.Images.SetKeyName(0, "Folder_Close.jpg")
        Me.imglFolder.Images.SetKeyName(1, "Folder_Open.jpg")
        Me.imglFolder.Images.SetKeyName(2, "Word.png")
        Me.imglFolder.Images.SetKeyName(3, "PPT.png")
        Me.imglFolder.Images.SetKeyName(4, "DOB.png")
        Me.imglFolder.Images.SetKeyName(5, "Address.png")
        Me.imglFolder.Images.SetKeyName(6, "blood-type.png")
        Me.imglFolder.Images.SetKeyName(7, "Gender.jpg")
        Me.imglFolder.Images.SetKeyName(8, "hobby.png")
        Me.imglFolder.Images.SetKeyName(9, "Person.png")
        Me.imglFolder.Images.SetKeyName(10, "Phone.png")
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 506)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmHome"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageDB.ResumeLayout(False)
        Me.TabPageDB.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageToDoList.ResumeLayout(False)
        Me.TabPageToDoList.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.nudList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPageDB As TabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtLname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents mtxtPhone As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents radMale As RadioButton
    Friend WithEvents Label28 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents cmbBlood As ComboBox
    Friend WithEvents Label30 As Label
    Friend WithEvents dtpDob As DateTimePicker
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents dgvStudent As DataGridView
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TabPageToDoList As TabPage
    Friend WithEvents btnClearToDoList As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents nudList As NumericUpDown
    Friend WithEvents btnInputNumberList As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents cmbAss As ComboBox
    Friend WithEvents btnInputAss As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents chlsbAss As CheckedListBox
    Friend WithEvents Label15 As Label
    Friend WithEvents lstOutputAss As ListBox
    Friend WithEvents ToolTipButton As ToolTip
    Friend WithEvents imglFolder As ImageList
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudentDatabase
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudentDatabase))
        Me.imglFolder = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTipButton = New System.Windows.Forms.ToolTip(Me.components)
        Me.imgChara = New System.Windows.Forms.ImageList(Me.components)
        Me.ctxtmenustripChara = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FemaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCharaText = New System.Windows.Forms.Label()
        Me.msFile = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileDirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.stsTime = New System.Windows.Forms.StatusStrip()
        Me.tsstDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsstTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnChara = New System.Windows.Forms.Button()
        Me.ctxtmenustripChara.SuspendLayout()
        Me.msFile.SuspendLayout()
        Me.stsTime.SuspendLayout()
        Me.SuspendLayout()
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
        'imgChara
        '
        Me.imgChara.ImageStream = CType(resources.GetObject("imgChara.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgChara.TransparentColor = System.Drawing.Color.Transparent
        Me.imgChara.Images.SetKeyName(0, "Man.png")
        Me.imgChara.Images.SetKeyName(1, "Man1.png")
        Me.imgChara.Images.SetKeyName(2, "Woman.png")
        Me.imgChara.Images.SetKeyName(3, "Woman1.png")
        '
        'ctxtmenustripChara
        '
        Me.ctxtmenustripChara.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ctxtmenustripChara.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem, Me.GenderToolStripMenuItem})
        Me.ctxtmenustripChara.Name = "ctxtmenustripChara"
        Me.ctxtmenustripChara.Size = New System.Drawing.Size(127, 52)
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(126, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'GenderToolStripMenuItem
        '
        Me.GenderToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaleToolStripMenuItem, Me.FemaleToolStripMenuItem})
        Me.GenderToolStripMenuItem.Name = "GenderToolStripMenuItem"
        Me.GenderToolStripMenuItem.Size = New System.Drawing.Size(126, 24)
        Me.GenderToolStripMenuItem.Text = "Gender"
        '
        'MaleToolStripMenuItem
        '
        Me.MaleToolStripMenuItem.Name = "MaleToolStripMenuItem"
        Me.MaleToolStripMenuItem.Size = New System.Drawing.Size(140, 26)
        Me.MaleToolStripMenuItem.Text = "Male"
        '
        'FemaleToolStripMenuItem
        '
        Me.FemaleToolStripMenuItem.Name = "FemaleToolStripMenuItem"
        Me.FemaleToolStripMenuItem.Size = New System.Drawing.Size(140, 26)
        Me.FemaleToolStripMenuItem.Text = "Female"
        '
        'lblCharaText
        '
        Me.lblCharaText.AutoSize = True
        Me.lblCharaText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCharaText.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharaText.Location = New System.Drawing.Point(132, 55)
        Me.lblCharaText.Name = "lblCharaText"
        Me.lblCharaText.Size = New System.Drawing.Size(61, 22)
        Me.lblCharaText.TabIndex = 5
        Me.lblCharaText.Text = "          "
        '
        'msFile
        '
        Me.msFile.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.msFile.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.msFile.Location = New System.Drawing.Point(0, 0)
        Me.msFile.Name = "msFile"
        Me.msFile.Size = New System.Drawing.Size(1006, 28)
        Me.msFile.TabIndex = 8
        Me.msFile.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoToToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'GoToToolStripMenuItem
        '
        Me.GoToToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentDatabaseToolStripMenuItem, Me.FileDirToolStripMenuItem, Me.CalculatorToolStripMenuItem})
        Me.GoToToolStripMenuItem.Name = "GoToToolStripMenuItem"
        Me.GoToToolStripMenuItem.Size = New System.Drawing.Size(131, 26)
        Me.GoToToolStripMenuItem.Text = "Go To"
        '
        'StudentDatabaseToolStripMenuItem
        '
        Me.StudentDatabaseToolStripMenuItem.Name = "StudentDatabaseToolStripMenuItem"
        Me.StudentDatabaseToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.StudentDatabaseToolStripMenuItem.Text = "Student Database"
        '
        'FileDirToolStripMenuItem
        '
        Me.FileDirToolStripMenuItem.Name = "FileDirToolStripMenuItem"
        Me.FileDirToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.FileDirToolStripMenuItem.Text = "File Directory"
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.CalculatorToolStripMenuItem.Text = "Calculator"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(131, 26)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'stsTime
        '
        Me.stsTime.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.stsTime.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsstDate, Me.tsstTime})
        Me.stsTime.Location = New System.Drawing.Point(0, 647)
        Me.stsTime.Name = "stsTime"
        Me.stsTime.Size = New System.Drawing.Size(1006, 26)
        Me.stsTime.TabIndex = 9
        Me.stsTime.Text = "StatusStrip1"
        '
        'tsstDate
        '
        Me.tsstDate.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tsstDate.Name = "tsstDate"
        Me.tsstDate.Size = New System.Drawing.Size(41, 20)
        Me.tsstDate.Text = "Date"
        '
        'tsstTime
        '
        Me.tsstTime.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tsstTime.Name = "tsstTime"
        Me.tsstTime.Size = New System.Drawing.Size(42, 20)
        Me.tsstTime.Text = "Time"
        '
        'btnChara
        '
        Me.btnChara.BackColor = System.Drawing.Color.PeachPuff
        Me.btnChara.ContextMenuStrip = Me.ctxtmenustripChara
        Me.btnChara.FlatAppearance.BorderSize = 0
        Me.btnChara.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChara.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChara.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.btnChara.ImageIndex = 0
        Me.btnChara.ImageList = Me.imgChara
        Me.btnChara.Location = New System.Drawing.Point(9, 39)
        Me.btnChara.Name = "btnChara"
        Me.btnChara.Size = New System.Drawing.Size(105, 90)
        Me.btnChara.TabIndex = 3
        Me.btnChara.UseVisualStyleBackColor = False
        '
        'frmStudentDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(1006, 673)
        Me.Controls.Add(Me.stsTime)
        Me.Controls.Add(Me.lblCharaText)
        Me.Controls.Add(Me.msFile)
        Me.Controls.Add(Me.btnChara)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.msFile
        Me.Name = "frmStudentDatabase"
        Me.Text = "StudentDatabase"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ctxtmenustripChara.ResumeLayout(False)
        Me.msFile.ResumeLayout(False)
        Me.msFile.PerformLayout()
        Me.stsTime.ResumeLayout(False)
        Me.stsTime.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imglFolder As ImageList
    Friend WithEvents ToolTipButton As ToolTip
    Friend WithEvents imgChara As ImageList
    Friend WithEvents btnChara As Button
    Friend WithEvents ctxtmenustripChara As ContextMenuStrip
    Friend WithEvents GenderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FemaleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblCharaText As Label
    Friend WithEvents msFile As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GoToToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileDirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents stsTime As StatusStrip
    Friend WithEvents tsstDate As ToolStripStatusLabel
    Friend WithEvents tsstTime As ToolStripStatusLabel
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentDatabaseToolStripMenuItem As ToolStripMenuItem
End Class

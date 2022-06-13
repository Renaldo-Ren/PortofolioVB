<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHelp))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbtnBack = New System.Windows.Forms.ToolStripButton()
        Me.lblCharaText = New System.Windows.Forms.Label()
        Me.imgChara = New System.Windows.Forms.ImageList(Me.components)
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.imgBtn = New System.Windows.Forms.ImageList(Me.components)
        Me.btnChara = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblHelpLogin2 = New System.Windows.Forms.Label()
        Me.lblHelpLogin1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lblHelpDB = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lblHelpToDoList2 = New System.Windows.Forms.Label()
        Me.lblHelpToDoList1 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.lblHelpFileDir = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.lblHelpCalcu = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.lblHelpRecArea = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnBack})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(874, 27)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbtnBack
        '
        Me.tsbtnBack.Image = CType(resources.GetObject("tsbtnBack.Image"), System.Drawing.Image)
        Me.tsbtnBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnBack.Name = "tsbtnBack"
        Me.tsbtnBack.Size = New System.Drawing.Size(64, 24)
        Me.tsbtnBack.Text = "Back"
        '
        'lblCharaText
        '
        Me.lblCharaText.AutoSize = True
        Me.lblCharaText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCharaText.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharaText.Location = New System.Drawing.Point(135, 57)
        Me.lblCharaText.Name = "lblCharaText"
        Me.lblCharaText.Size = New System.Drawing.Size(61, 22)
        Me.lblCharaText.TabIndex = 7
        Me.lblCharaText.Text = "          "
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
        'btnPrev
        '
        Me.btnPrev.ImageIndex = 1
        Me.btnPrev.ImageList = Me.imgBtn
        Me.btnPrev.Location = New System.Drawing.Point(135, 111)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(87, 32)
        Me.btnPrev.TabIndex = 8
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'imgBtn
        '
        Me.imgBtn.ImageStream = CType(resources.GetObject("imgBtn.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgBtn.TransparentColor = System.Drawing.Color.Transparent
        Me.imgBtn.Images.SetKeyName(0, "323-circle-right.png")
        Me.imgBtn.Images.SetKeyName(1, "325-circle-left.png")
        '
        'btnChara
        '
        Me.btnChara.BackColor = System.Drawing.Color.Aqua
        Me.btnChara.FlatAppearance.BorderSize = 0
        Me.btnChara.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChara.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChara.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.btnChara.ImageIndex = 0
        Me.btnChara.ImageList = Me.imgChara
        Me.btnChara.Location = New System.Drawing.Point(12, 39)
        Me.btnChara.Name = "btnChara"
        Me.btnChara.Size = New System.Drawing.Size(117, 104)
        Me.btnChara.TabIndex = 6
        Me.btnChara.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.ImageIndex = 0
        Me.btnNext.ImageList = Me.imgBtn
        Me.btnNext.Location = New System.Drawing.Point(239, 111)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(87, 32)
        Me.btnNext.TabIndex = 9
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 149)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(850, 440)
        Me.TabControl1.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.lblHelpLogin2)
        Me.TabPage1.Controls.Add(Me.lblHelpLogin1)
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(842, 409)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Login"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblHelpLogin2
        '
        Me.lblHelpLogin2.AutoSize = True
        Me.lblHelpLogin2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelpLogin2.Location = New System.Drawing.Point(385, 262)
        Me.lblHelpLogin2.Name = "lblHelpLogin2"
        Me.lblHelpLogin2.Size = New System.Drawing.Size(51, 18)
        Me.lblHelpLogin2.TabIndex = 3
        Me.lblHelpLogin2.Text = "Label1"
        '
        'lblHelpLogin1
        '
        Me.lblHelpLogin1.AutoSize = True
        Me.lblHelpLogin1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelpLogin1.Location = New System.Drawing.Point(385, 17)
        Me.lblHelpLogin1.Name = "lblHelpLogin1"
        Me.lblHelpLogin1.Size = New System.Drawing.Size(51, 18)
        Me.lblHelpLogin1.TabIndex = 2
        Me.lblHelpLogin1.Text = "Label1"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ExerciseProject.My.Resources.Resources.Help_Login2
        Me.PictureBox2.Location = New System.Drawing.Point(6, 245)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(367, 194)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ExerciseProject.My.Resources.Resources.Help_Login
        Me.PictureBox1.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(367, 194)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.lblHelpDB)
        Me.TabPage2.Controls.Add(Me.PictureBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(842, 409)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Student Database"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lblHelpDB
        '
        Me.lblHelpDB.AutoSize = True
        Me.lblHelpDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelpDB.Location = New System.Drawing.Point(15, 382)
        Me.lblHelpDB.Name = "lblHelpDB"
        Me.lblHelpDB.Size = New System.Drawing.Size(51, 18)
        Me.lblHelpDB.TabIndex = 1
        Me.lblHelpDB.Text = "Label1"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.ExerciseProject.My.Resources.Resources.Help_DB
        Me.PictureBox3.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(809, 368)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.lblHelpToDoList2)
        Me.TabPage3.Controls.Add(Me.lblHelpToDoList1)
        Me.TabPage3.Controls.Add(Me.PictureBox5)
        Me.TabPage3.Controls.Add(Me.PictureBox4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(842, 409)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "To Do List"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lblHelpToDoList2
        '
        Me.lblHelpToDoList2.AutoSize = True
        Me.lblHelpToDoList2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelpToDoList2.Location = New System.Drawing.Point(463, 348)
        Me.lblHelpToDoList2.Name = "lblHelpToDoList2"
        Me.lblHelpToDoList2.Size = New System.Drawing.Size(51, 18)
        Me.lblHelpToDoList2.TabIndex = 3
        Me.lblHelpToDoList2.Text = "Label1"
        '
        'lblHelpToDoList1
        '
        Me.lblHelpToDoList1.AutoSize = True
        Me.lblHelpToDoList1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelpToDoList1.Location = New System.Drawing.Point(463, 23)
        Me.lblHelpToDoList1.Name = "lblHelpToDoList1"
        Me.lblHelpToDoList1.Size = New System.Drawing.Size(51, 18)
        Me.lblHelpToDoList1.TabIndex = 2
        Me.lblHelpToDoList1.Text = "Label1"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.ExerciseProject.My.Resources.Resources.Help_ToDoList2
        Me.PictureBox5.Location = New System.Drawing.Point(6, 336)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(455, 300)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 1
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.ExerciseProject.My.Resources.Resources.Help_ToDoList
        Me.PictureBox4.Location = New System.Drawing.Point(6, 11)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(455, 300)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'TabPage4
        '
        Me.TabPage4.AutoScroll = True
        Me.TabPage4.Controls.Add(Me.lblHelpFileDir)
        Me.TabPage4.Controls.Add(Me.PictureBox6)
        Me.TabPage4.Location = New System.Drawing.Point(4, 27)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(842, 409)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "File Directory"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'lblHelpFileDir
        '
        Me.lblHelpFileDir.AutoSize = True
        Me.lblHelpFileDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelpFileDir.Location = New System.Drawing.Point(563, 17)
        Me.lblHelpFileDir.Name = "lblHelpFileDir"
        Me.lblHelpFileDir.Size = New System.Drawing.Size(51, 18)
        Me.lblHelpFileDir.TabIndex = 1
        Me.lblHelpFileDir.Text = "Label1"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.ExerciseProject.My.Resources.Resources.Help_FileDir
        Me.PictureBox6.Location = New System.Drawing.Point(4, 5)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(556, 384)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 0
        Me.PictureBox6.TabStop = False
        '
        'TabPage5
        '
        Me.TabPage5.AutoScroll = True
        Me.TabPage5.Controls.Add(Me.lblHelpCalcu)
        Me.TabPage5.Controls.Add(Me.PictureBox7)
        Me.TabPage5.Location = New System.Drawing.Point(4, 27)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(842, 409)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Standard Calculator"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'lblHelpCalcu
        '
        Me.lblHelpCalcu.AutoSize = True
        Me.lblHelpCalcu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelpCalcu.Location = New System.Drawing.Point(538, 24)
        Me.lblHelpCalcu.Name = "lblHelpCalcu"
        Me.lblHelpCalcu.Size = New System.Drawing.Size(51, 18)
        Me.lblHelpCalcu.TabIndex = 1
        Me.lblHelpCalcu.Text = "Label1"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.ExerciseProject.My.Resources.Resources.Help_Calculator
        Me.PictureBox7.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(530, 381)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 0
        Me.PictureBox7.TabStop = False
        '
        'TabPage6
        '
        Me.TabPage6.AutoScroll = True
        Me.TabPage6.Controls.Add(Me.lblHelpRecArea)
        Me.TabPage6.Controls.Add(Me.PictureBox8)
        Me.TabPage6.Location = New System.Drawing.Point(4, 27)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(842, 409)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Rectangle Area"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'lblHelpRecArea
        '
        Me.lblHelpRecArea.AutoSize = True
        Me.lblHelpRecArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelpRecArea.Location = New System.Drawing.Point(547, 23)
        Me.lblHelpRecArea.Name = "lblHelpRecArea"
        Me.lblHelpRecArea.Size = New System.Drawing.Size(51, 18)
        Me.lblHelpRecArea.TabIndex = 1
        Me.lblHelpRecArea.Text = "Label1"
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.ExerciseProject.My.Resources.Resources.Help_RecArea
        Me.PictureBox8.Location = New System.Drawing.Point(3, 6)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(543, 384)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 0
        Me.PictureBox8.TabStop = False
        '
        'frmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(874, 591)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.lblCharaText)
        Me.Controls.Add(Me.btnChara)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHelp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents lblCharaText As Label
    Friend WithEvents btnChara As Button
    Friend WithEvents imgChara As ImageList
    Friend WithEvents btnPrev As Button
    Friend WithEvents imgBtn As ImageList
    Friend WithEvents btnNext As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lblHelpLogin2 As Label
    Friend WithEvents lblHelpLogin1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblHelpDB As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lblHelpToDoList2 As Label
    Friend WithEvents lblHelpToDoList1 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents lblHelpFileDir As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents lblHelpCalcu As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents lblHelpRecArea As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents tsbtnBack As ToolStripButton
End Class

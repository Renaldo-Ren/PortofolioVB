<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculator))
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ToolTipButton = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblOperator = New System.Windows.Forms.Label()
        Me.btnExitCalcu = New System.Windows.Forms.Button()
        Me.btnClearCalcu = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOperand2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOperand1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAns = New System.Windows.Forms.Button()
        Me.btnLog = New System.Windows.Forms.Button()
        Me.btnExpo = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.btnPercent = New System.Windows.Forms.Button()
        Me.btnCbrt = New System.Windows.Forms.Button()
        Me.btnSqrt = New System.Windows.Forms.Button()
        Me.btnSquare = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnSubstract = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnExitRec = New System.Windows.Forms.Button()
        Me.btnClearRec = New System.Windows.Forms.Button()
        Me.btnRecArea = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.hscrlWidth = New System.Windows.Forms.HScrollBar()
        Me.vscrlHeight = New System.Windows.Forms.VScrollBar()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Stencil", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label15.Location = New System.Drawing.Point(250, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(224, 40)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "CALCULATOR"
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 52)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(729, 370)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 32)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(721, 334)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Standard"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox2.Controls.Add(Me.lblOperator)
        Me.GroupBox2.Controls.Add(Me.btnExitCalcu)
        Me.GroupBox2.Controls.Add(Me.btnClearCalcu)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtResult)
        Me.GroupBox2.Controls.Add(Me.btnCalculate)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtOperand2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtOperand1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(364, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(345, 322)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Input Operand"
        '
        'lblOperator
        '
        Me.lblOperator.AutoSize = True
        Me.lblOperator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOperator.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperator.Location = New System.Drawing.Point(141, 99)
        Me.lblOperator.Name = "lblOperator"
        Me.lblOperator.Size = New System.Drawing.Size(71, 22)
        Me.lblOperator.TabIndex = 9
        Me.lblOperator.Text = "          "
        Me.lblOperator.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnExitCalcu
        '
        Me.btnExitCalcu.BackColor = System.Drawing.SystemColors.Info
        Me.btnExitCalcu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExitCalcu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExitCalcu.Location = New System.Drawing.Point(232, 248)
        Me.btnExitCalcu.Name = "btnExitCalcu"
        Me.btnExitCalcu.Size = New System.Drawing.Size(107, 33)
        Me.btnExitCalcu.TabIndex = 8
        Me.btnExitCalcu.Text = "E&xit"
        Me.ToolTipButton.SetToolTip(Me.btnExitCalcu, "Click to Exit," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or Press alt + x  to Exit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnExitCalcu.UseVisualStyleBackColor = False
        '
        'btnClearCalcu
        '
        Me.btnClearCalcu.BackColor = System.Drawing.SystemColors.Info
        Me.btnClearCalcu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClearCalcu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearCalcu.Location = New System.Drawing.Point(119, 248)
        Me.btnClearCalcu.Name = "btnClearCalcu"
        Me.btnClearCalcu.Size = New System.Drawing.Size(107, 33)
        Me.btnClearCalcu.TabIndex = 7
        Me.btnClearCalcu.Text = "C&lear"
        Me.ToolTipButton.SetToolTip(Me.btnClearCalcu, "Click to Clear Output," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or Press alt + l to Clear Output")
        Me.btnClearCalcu.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Result:"
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(134, 193)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(144, 26)
        Me.txtResult.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.Info
        Me.btnCalculate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculate.Location = New System.Drawing.Point(6, 248)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(107, 33)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "&Calculate"
        Me.ToolTipButton.SetToolTip(Me.btnCalculate, "Click to Calculate," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or Press alt + c  to Calculate")
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Operand 2:"
        '
        'txtOperand2
        '
        Me.txtOperand2.Location = New System.Drawing.Point(134, 141)
        Me.txtOperand2.Name = "txtOperand2"
        Me.txtOperand2.Size = New System.Drawing.Size(144, 26)
        Me.txtOperand2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Operand 1:"
        '
        'txtOperand1
        '
        Me.txtOperand1.Location = New System.Drawing.Point(134, 58)
        Me.txtOperand1.Name = "txtOperand1"
        Me.txtOperand1.Size = New System.Drawing.Size(144, 26)
        Me.txtOperand1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox1.Controls.Add(Me.btnAns)
        Me.GroupBox1.Controls.Add(Me.btnLog)
        Me.GroupBox1.Controls.Add(Me.btnExpo)
        Me.GroupBox1.Controls.Add(Me.btnMod)
        Me.GroupBox1.Controls.Add(Me.btnPercent)
        Me.GroupBox1.Controls.Add(Me.btnCbrt)
        Me.GroupBox1.Controls.Add(Me.btnSqrt)
        Me.GroupBox1.Controls.Add(Me.btnSquare)
        Me.GroupBox1.Controls.Add(Me.btnDivide)
        Me.GroupBox1.Controls.Add(Me.btnMultiply)
        Me.GroupBox1.Controls.Add(Me.btnSubstract)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(13, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(345, 322)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose Operator"
        '
        'btnAns
        '
        Me.btnAns.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAns.Location = New System.Drawing.Point(251, 225)
        Me.btnAns.Name = "btnAns"
        Me.btnAns.Size = New System.Drawing.Size(74, 54)
        Me.btnAns.TabIndex = 11
        Me.btnAns.Text = "Ans"
        Me.btnAns.UseVisualStyleBackColor = True
        '
        'btnLog
        '
        Me.btnLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLog.Location = New System.Drawing.Point(251, 141)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(74, 54)
        Me.btnLog.TabIndex = 10
        Me.btnLog.Text = "Log"
        Me.btnLog.UseVisualStyleBackColor = True
        '
        'btnExpo
        '
        Me.btnExpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpo.Location = New System.Drawing.Point(251, 58)
        Me.btnExpo.Name = "btnExpo"
        Me.btnExpo.Size = New System.Drawing.Size(74, 54)
        Me.btnExpo.TabIndex = 9
        Me.btnExpo.Text = "^"
        Me.btnExpo.UseVisualStyleBackColor = True
        '
        'btnMod
        '
        Me.btnMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMod.Location = New System.Drawing.Point(171, 225)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(74, 54)
        Me.btnMod.TabIndex = 8
        Me.btnMod.Text = "Mod"
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'btnPercent
        '
        Me.btnPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPercent.Location = New System.Drawing.Point(91, 225)
        Me.btnPercent.Name = "btnPercent"
        Me.btnPercent.Size = New System.Drawing.Size(74, 54)
        Me.btnPercent.TabIndex = 7
        Me.btnPercent.Text = "%"
        Me.btnPercent.UseVisualStyleBackColor = True
        '
        'btnCbrt
        '
        Me.btnCbrt.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCbrt.Location = New System.Drawing.Point(11, 226)
        Me.btnCbrt.Name = "btnCbrt"
        Me.btnCbrt.Size = New System.Drawing.Size(74, 54)
        Me.btnCbrt.TabIndex = 6
        Me.btnCbrt.Text = "∛"
        Me.btnCbrt.UseVisualStyleBackColor = True
        '
        'btnSqrt
        '
        Me.btnSqrt.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSqrt.Location = New System.Drawing.Point(171, 142)
        Me.btnSqrt.Name = "btnSqrt"
        Me.btnSqrt.Size = New System.Drawing.Size(74, 54)
        Me.btnSqrt.TabIndex = 5
        Me.btnSqrt.Text = "√"
        Me.btnSqrt.UseVisualStyleBackColor = True
        '
        'btnSquare
        '
        Me.btnSquare.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSquare.Location = New System.Drawing.Point(171, 58)
        Me.btnSquare.Name = "btnSquare"
        Me.btnSquare.Size = New System.Drawing.Size(74, 54)
        Me.btnSquare.TabIndex = 4
        Me.btnSquare.Text = "^2"
        Me.btnSquare.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivide.Location = New System.Drawing.Point(91, 142)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(74, 54)
        Me.btnDivide.TabIndex = 3
        Me.btnDivide.Text = "÷"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiply.Location = New System.Drawing.Point(11, 142)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(74, 54)
        Me.btnMultiply.TabIndex = 2
        Me.btnMultiply.Text = "x"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'btnSubstract
        '
        Me.btnSubstract.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubstract.Location = New System.Drawing.Point(91, 58)
        Me.btnSubstract.Name = "btnSubstract"
        Me.btnSubstract.Size = New System.Drawing.Size(74, 54)
        Me.btnSubstract.TabIndex = 1
        Me.btnSubstract.Text = "-"
        Me.btnSubstract.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(11, 58)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(74, 54)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 32)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(721, 334)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Rectangle Area"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox4.Controls.Add(Me.btnExitRec)
        Me.GroupBox4.Controls.Add(Me.btnClearRec)
        Me.GroupBox4.Controls.Add(Me.btnRecArea)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtArea)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtWidth)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txtHeight)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox4.Location = New System.Drawing.Point(359, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(352, 315)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Rectangle Area"
        '
        'btnExitRec
        '
        Me.btnExitRec.BackColor = System.Drawing.SystemColors.Info
        Me.btnExitRec.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExitRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExitRec.Location = New System.Drawing.Point(234, 243)
        Me.btnExitRec.Name = "btnExitRec"
        Me.btnExitRec.Size = New System.Drawing.Size(107, 33)
        Me.btnExitRec.TabIndex = 8
        Me.btnExitRec.Text = "E&xit"
        Me.ToolTipButton.SetToolTip(Me.btnExitRec, "Click to Exit," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or Press alt + x  to Exit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnExitRec.UseVisualStyleBackColor = False
        '
        'btnClearRec
        '
        Me.btnClearRec.BackColor = System.Drawing.SystemColors.Info
        Me.btnClearRec.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClearRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearRec.Location = New System.Drawing.Point(123, 243)
        Me.btnClearRec.Name = "btnClearRec"
        Me.btnClearRec.Size = New System.Drawing.Size(107, 33)
        Me.btnClearRec.TabIndex = 7
        Me.btnClearRec.Text = "C&lear"
        Me.ToolTipButton.SetToolTip(Me.btnClearRec, "Click to Clear Output," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or Press alt + l  to Clear Output" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnClearRec.UseVisualStyleBackColor = False
        '
        'btnRecArea
        '
        Me.btnRecArea.BackColor = System.Drawing.SystemColors.Info
        Me.btnRecArea.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRecArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecArea.Location = New System.Drawing.Point(11, 243)
        Me.btnRecArea.Name = "btnRecArea"
        Me.btnRecArea.Size = New System.Drawing.Size(107, 33)
        Me.btnRecArea.TabIndex = 6
        Me.btnRecArea.Text = "&Calculate"
        Me.ToolTipButton.SetToolTip(Me.btnRecArea, "Click to Calculate," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or Press alt + c  to Calculate")
        Me.btnRecArea.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Area:"
        '
        'txtArea
        '
        Me.txtArea.Location = New System.Drawing.Point(118, 174)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.ReadOnly = True
        Me.txtArea.Size = New System.Drawing.Size(186, 26)
        Me.txtArea.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Width:"
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(118, 122)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.ReadOnly = True
        Me.txtWidth.Size = New System.Drawing.Size(186, 26)
        Me.txtWidth.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Height:"
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(118, 72)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.ReadOnly = True
        Me.txtHeight.Size = New System.Drawing.Size(186, 26)
        Me.txtHeight.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.Controls.Add(Me.hscrlWidth)
        Me.GroupBox3.Controls.Add(Me.vscrlHeight)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(10, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(343, 315)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rectangle"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ExerciseProject.My.Resources.Resources.Rectangle
        Me.PictureBox1.Location = New System.Drawing.Point(27, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(256, 157)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'hscrlWidth
        '
        Me.hscrlWidth.Location = New System.Drawing.Point(27, 282)
        Me.hscrlWidth.Maximum = 200
        Me.hscrlWidth.Name = "hscrlWidth"
        Me.hscrlWidth.Size = New System.Drawing.Size(256, 21)
        Me.hscrlWidth.TabIndex = 2
        '
        'vscrlHeight
        '
        Me.vscrlHeight.Location = New System.Drawing.Point(286, 34)
        Me.vscrlHeight.Maximum = 200
        Me.vscrlHeight.Name = "vscrlHeight"
        Me.vscrlHeight.Size = New System.Drawing.Size(21, 242)
        Me.vscrlHeight.TabIndex = 1
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Rectangle.png")
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(757, 434)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label15)
        Me.Name = "Calculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculator"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label15 As Label
    Friend WithEvents ToolTipButton As ToolTip
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtOperand2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtOperand1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnMod As Button
    Friend WithEvents btnPercent As Button
    Friend WithEvents btnCbrt As Button
    Friend WithEvents btnSqrt As Button
    Friend WithEvents btnSquare As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnSubstract As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnExitCalcu As Button
    Friend WithEvents btnClearCalcu As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtResult As TextBox
    Friend WithEvents lblOperator As Label
    Friend WithEvents btnAns As Button
    Friend WithEvents btnLog As Button
    Friend WithEvents btnExpo As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents hscrlWidth As HScrollBar
    Friend WithEvents vscrlHeight As VScrollBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnRecArea As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtArea As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents btnExitRec As Button
    Friend WithEvents btnClearRec As Button
End Class

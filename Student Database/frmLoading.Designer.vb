<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoading
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoading))
        Me.stssLoad = New System.Windows.Forms.StatusStrip()
        Me.tsProgress = New System.Windows.Forms.ToolStripProgressBar()
        Me.tmProgress = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.imgLoad = New System.Windows.Forms.ImageList(Me.components)
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.stssLoad.SuspendLayout()
        Me.SuspendLayout()
        '
        'stssLoad
        '
        Me.stssLoad.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.stssLoad.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsProgress})
        Me.stssLoad.Location = New System.Drawing.Point(0, 289)
        Me.stssLoad.Name = "stssLoad"
        Me.stssLoad.Size = New System.Drawing.Size(622, 26)
        Me.stssLoad.TabIndex = 8
        Me.stssLoad.Text = "StatusStrip1"
        '
        'tsProgress
        '
        Me.tsProgress.Name = "tsProgress"
        Me.tsProgress.Size = New System.Drawing.Size(600, 18)
        '
        'tmProgress
        '
        Me.tmProgress.Interval = 20
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(210, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 48)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Loading..."
        '
        'imgLoad
        '
        Me.imgLoad.ImageStream = CType(resources.GetObject("imgLoad.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgLoad.TransparentColor = System.Drawing.Color.Transparent
        Me.imgLoad.Images.SetKeyName(0, "123-spinner.png")
        Me.imgLoad.Images.SetKeyName(1, "128-spinner6.png")
        Me.imgLoad.Images.SetKeyName(2, "129-spinner7.png")
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnLoad.FlatAppearance.BorderSize = 0
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoad.ImageIndex = 0
        Me.btnLoad.ImageList = Me.imgLoad
        Me.btnLoad.Location = New System.Drawing.Point(230, 117)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(159, 140)
        Me.btnLoad.TabIndex = 11
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'frmLoading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(622, 315)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.stssLoad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLoading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLoading"
        Me.stssLoad.ResumeLayout(False)
        Me.stssLoad.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents stssLoad As StatusStrip
    Friend WithEvents tsProgress As ToolStripProgressBar
    Friend WithEvents tmProgress As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents imgLoad As ImageList
    Friend WithEvents btnLoad As Button
End Class

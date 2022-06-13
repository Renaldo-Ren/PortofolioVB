<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFileDir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFileDir))
        Me.tvFile = New System.Windows.Forms.TreeView()
        Me.imgFolder = New System.Windows.Forms.ImageList(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tsIcon = New System.Windows.Forms.ToolStrip()
        Me.tsbtnLargeIcon = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnSmallIcon = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnList = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnTile = New System.Windows.Forms.ToolStripButton()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.lstvOutput = New System.Windows.Forms.ListView()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tsIcon.SuspendLayout()
        Me.SuspendLayout()
        '
        'tvFile
        '
        Me.tvFile.BackColor = System.Drawing.Color.LightSkyBlue
        Me.tvFile.ImageIndex = 0
        Me.tvFile.ImageList = Me.imgFolder
        Me.tvFile.Location = New System.Drawing.Point(0, 0)
        Me.tvFile.Name = "tvFile"
        Me.tvFile.SelectedImageIndex = 0
        Me.tvFile.Size = New System.Drawing.Size(228, 436)
        Me.tvFile.TabIndex = 2
        '
        'imgFolder
        '
        Me.imgFolder.ImageStream = CType(resources.GetObject("imgFolder.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgFolder.TransparentColor = System.Drawing.Color.Transparent
        Me.imgFolder.Images.SetKeyName(0, "Folder_Close.jpg")
        Me.imgFolder.Images.SetKeyName(1, "Folder_Open.jpg")
        Me.imgFolder.Images.SetKeyName(2, "Word.png")
        Me.imgFolder.Images.SetKeyName(3, "PPT.png")
        Me.imgFolder.Images.SetKeyName(4, "DOB.png")
        Me.imgFolder.Images.SetKeyName(5, "Address.png")
        Me.imgFolder.Images.SetKeyName(6, "blood-type.png")
        Me.imgFolder.Images.SetKeyName(7, "Gender.jpg")
        Me.imgFolder.Images.SetKeyName(8, "hobby.png")
        Me.imgFolder.Images.SetKeyName(9, "Person.png")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.Font = New System.Drawing.Font("Stencil", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(198, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(281, 40)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "File Directory"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 62)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tvFile)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(684, 439)
        Me.SplitContainer1.SplitterDistance = 227
        Me.SplitContainer1.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox1.Controls.Add(Me.tsIcon)
        Me.GroupBox1.Controls.Add(Me.lblPath)
        Me.GroupBox1.Controls.Add(Me.lstvOutput)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(7, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(430, 436)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "File Information"
        '
        'tsIcon
        '
        Me.tsIcon.Dock = System.Windows.Forms.DockStyle.None
        Me.tsIcon.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.tsIcon.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnLargeIcon, Me.tsbtnSmallIcon, Me.tsbtnList, Me.tsbtnTile})
        Me.tsIcon.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsIcon.Location = New System.Drawing.Point(374, 46)
        Me.tsIcon.Name = "tsIcon"
        Me.tsIcon.Size = New System.Drawing.Size(30, 140)
        Me.tsIcon.TabIndex = 4
        Me.tsIcon.Text = "ToolStrip1"
        '
        'tsbtnLargeIcon
        '
        Me.tsbtnLargeIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnLargeIcon.Image = CType(resources.GetObject("tsbtnLargeIcon.Image"), System.Drawing.Image)
        Me.tsbtnLargeIcon.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnLargeIcon.Name = "tsbtnLargeIcon"
        Me.tsbtnLargeIcon.Size = New System.Drawing.Size(28, 29)
        Me.tsbtnLargeIcon.Text = "Large Icon"
        '
        'tsbtnSmallIcon
        '
        Me.tsbtnSmallIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnSmallIcon.Image = CType(resources.GetObject("tsbtnSmallIcon.Image"), System.Drawing.Image)
        Me.tsbtnSmallIcon.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSmallIcon.Name = "tsbtnSmallIcon"
        Me.tsbtnSmallIcon.Size = New System.Drawing.Size(28, 29)
        Me.tsbtnSmallIcon.Text = "Small Icon"
        '
        'tsbtnList
        '
        Me.tsbtnList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnList.Image = CType(resources.GetObject("tsbtnList.Image"), System.Drawing.Image)
        Me.tsbtnList.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnList.Name = "tsbtnList"
        Me.tsbtnList.Size = New System.Drawing.Size(28, 29)
        Me.tsbtnList.Text = "List"
        '
        'tsbtnTile
        '
        Me.tsbtnTile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnTile.Image = CType(resources.GetObject("tsbtnTile.Image"), System.Drawing.Image)
        Me.tsbtnTile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnTile.Name = "tsbtnTile"
        Me.tsbtnTile.Size = New System.Drawing.Size(28, 29)
        Me.tsbtnTile.Text = "Tile"
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPath.Location = New System.Drawing.Point(26, 21)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(47, 19)
        Me.lblPath.TabIndex = 3
        Me.lblPath.Text = "Path: "
        '
        'lstvOutput
        '
        Me.lstvOutput.HideSelection = False
        Me.lstvOutput.Location = New System.Drawing.Point(6, 46)
        Me.lstvOutput.Name = "lstvOutput"
        Me.lstvOutput.Size = New System.Drawing.Size(354, 381)
        Me.lstvOutput.TabIndex = 2
        Me.lstvOutput.UseCompatibleStateImageBehavior = False
        '
        'frmFileDir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(689, 504)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmFileDir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmFileDir"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tsIcon.ResumeLayout(False)
        Me.tsIcon.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tvFile As TreeView
    Friend WithEvents Label3 As Label
    Friend WithEvents imgFolder As ImageList
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents lstvOutput As ListView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblPath As Label
    Friend WithEvents tsIcon As ToolStrip
    Friend WithEvents tsbtnLargeIcon As ToolStripButton
    Friend WithEvents tsbtnSmallIcon As ToolStripButton
    Friend WithEvents tsbtnList As ToolStripButton
    Friend WithEvents tsbtnTile As ToolStripButton
End Class

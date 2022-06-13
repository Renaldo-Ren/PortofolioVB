Public Class frmLoading
    Private Sub frmLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmProgress.Enabled = True
    End Sub

    Private Sub tmProgress_Tick(sender As Object, e As EventArgs) Handles tmProgress.Tick
        tsProgress.Value += 1
        If (tsProgress.Value >= 100) Then
            tmProgress.Stop()
            Me.Hide()
            frmStudentDatabase.Show()
        ElseIf (tsProgress.Value > 10) And (tsProgress.Value <= 20) Then
            btnLoad.ImageList = imgLoad
            btnLoad.ImageIndex = 1
        ElseIf (tsProgress.Value > 20) And (tsProgress.Value <= 30) Then
            btnLoad.ImageList = imgLoad
            btnLoad.ImageIndex = 2
        ElseIf (tsProgress.Value > 30) And (tsProgress.Value <= 40) Then
            btnLoad.ImageList = imgLoad
            btnLoad.ImageIndex = 0
        ElseIf (tsProgress.Value > 40) And (tsProgress.Value <= 50) Then
            btnLoad.ImageList = imgLoad
            btnLoad.ImageIndex = 1
        ElseIf (tsProgress.Value > 50) And (tsProgress.Value <= 60) Then
            btnLoad.ImageList = imgLoad
            btnLoad.ImageIndex = 2
        ElseIf (tsProgress.Value > 60) And (tsProgress.Value <= 70) Then
            btnLoad.ImageList = imgLoad
            btnLoad.ImageIndex = 0
        ElseIf (tsProgress.Value > 70) And (tsProgress.Value <= 80) Then
            btnLoad.ImageList = imgLoad
            btnLoad.ImageIndex = 1
        ElseIf (tsProgress.Value > 80) And (tsProgress.Value <= 90) Then
            btnLoad.ImageList = imgLoad
            btnLoad.ImageIndex = 2
        ElseIf (tsProgress.Value > 90) And (tsProgress.Value <= 100) Then
            btnLoad.ImageList = imgLoad
            btnLoad.ImageIndex = 0
        End If
    End Sub
End Class
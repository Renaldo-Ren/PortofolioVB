Imports System.Data.SqlClient
Public Class frmStudentDatabase
    Private Sub frmStudentDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmHome.MdiParent = Me
        frmHome.Show()
        bgColor()
        tsstDate.Text = Today
        tsstTime.Text = TimeOfDay
        lblCharaText.Text = "Welcome User. I am as your guide here will help you. If you need help, you can right click me."
    End Sub

    Private Sub MaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaleToolStripMenuItem.Click
        btnChara.ImageList = imgChara
        btnChara.ImageIndex = 0
    End Sub

    Private Sub FemaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FemaleToolStripMenuItem.Click
        btnChara.ImageList = imgChara
        btnChara.ImageIndex = 2
    End Sub

    Private Sub bgColor()
        Dim child As Control
        For Each child In Me.Controls
            If TypeOf child Is MdiClient Then
                child.BackColor = Color.PeachPuff
                Exit For
            End If
        Next
        child = Nothing
    End Sub

    Private Sub FileDirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileDirToolStripMenuItem.Click
        frmFileDir.MdiParent = Me
        frmHome.Hide()
        Calculator.Hide()
        frmFileDir.Show()
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculatorToolStripMenuItem.Click
        Calculator.MdiParent = Me
        frmFileDir.Hide()
        frmHome.Hide()
        Calculator.Show()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Me.Hide()
        frmHelp.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub


    Private Sub StudentDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentDatabaseToolStripMenuItem.Click
        frmHome.MdiParent = Me
        frmFileDir.Hide()
        Calculator.Hide()
        frmHome.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.Show()
    End Sub
End Class

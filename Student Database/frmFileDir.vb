Public Class frmFileDir
    Private Sub frmFileDir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DSA = New TreeNode("Data structure & Algorithm", 0, 1)
        tvFile.Nodes.Add(DSA)
        tvFile.Nodes(0).Nodes.Add(New TreeNode("Assignment_DSA", 0, 1))
        tvFile.Nodes(0).Nodes(0).Nodes.Add(New TreeNode("AssInfix2Suffix", 2, 2))
        tvFile.Nodes(0).Nodes(0).Nodes.Add(New TreeNode("AssLinkedList", 2, 2))
        tvFile.Nodes(0).Nodes(0).Nodes.Add(New TreeNode("AssBinaryTree", 2, 2))
        tvFile.Nodes(0).Nodes.Add(New TreeNode("PPT_DSA", 0, 1))
        tvFile.Nodes(0).Nodes(1).Nodes.Add(New TreeNode("Infix2Suffix", 3, 3))
        tvFile.Nodes(0).Nodes(1).Nodes.Add(New TreeNode("Linked List", 3, 3))
        tvFile.Nodes(0).Nodes(1).Nodes.Add(New TreeNode("Queue", 3, 3))
        tvFile.Nodes(0).Nodes(1).Nodes.Add(New TreeNode("Binary Tree", 3, 3))
        Dim DBMS = New TreeNode("Database Management System", 0, 1)
        tvFile.Nodes.Add(DBMS)
        tvFile.Nodes(1).Nodes.Add(New TreeNode("Assignment_DBMS", 0, 1))
        tvFile.Nodes(1).Nodes(0).Nodes.Add(New TreeNode("AssDB1", 2, 2))
        tvFile.Nodes(1).Nodes.Add(New TreeNode("PPT_DBMS", 0, 1))
        tvFile.Nodes(1).Nodes(1).Nodes.Add(New TreeNode("ch10: DBMS", 3, 3))
        Dim Matrix = New TreeNode("Matrix & Vector", 0, 1)
        tvFile.Nodes.Add(Matrix)
        tvFile.Nodes(2).Nodes.Add(New TreeNode("Assignment_Matrix", 0, 1))
        tvFile.Nodes(2).Nodes(0).Nodes.Add(New TreeNode("AssMatrix1", 2, 2))
        tvFile.Nodes(2).Nodes(0).Nodes.Add(New TreeNode("AssMatrix2", 2, 2))
        tvFile.Nodes(2).Nodes.Add(New TreeNode("PPT_Matrix", 0, 1))
        tvFile.Nodes(2).Nodes(1).Nodes.Add(New TreeNode("Matrix1", 3, 3))
        tvFile.Nodes(2).Nodes(1).Nodes.Add(New TreeNode("Matrix2", 3, 3))
        Dim Physic = New TreeNode("Physics", 0, 1)
        tvFile.Nodes.Add(Physic)
        tvFile.Nodes(3).Nodes.Add(New TreeNode("Assignment_Physics", 0, 1))
        tvFile.Nodes(3).Nodes.Add(New TreeNode("PPT_Physics", 0, 1))
        tvFile.Nodes(3).Nodes(1).Nodes.Add(New TreeNode("1. Electrostatic Interaction", 3, 3))
        tvFile.Nodes(3).Nodes(1).Nodes.Add(New TreeNode("2. Electric Potential", 3, 3))
        Dim SSIP = New TreeNode("Server Side Internet Programming", 0, 1)
        tvFile.Nodes.Add(SSIP)
        tvFile.Nodes(4).Nodes.Add(New TreeNode("Assignment_SSIP", 0, 1))
        tvFile.Nodes(4).Nodes.Add(New TreeNode("PPT_SSIP", 0, 1))
        tvFile.Nodes(4).Nodes(1).Nodes.Add(New TreeNode("Python Intro", 3, 3))
        tvFile.Nodes(4).Nodes(1).Nodes.Add(New TreeNode("Django", 3, 3))
        tvFile.Nodes(4).Nodes(1).Nodes.Add(New TreeNode("Model", 3, 3))
        tvFile.Nodes(4).Nodes(1).Nodes.Add(New TreeNode("API", 3, 3))
        tvFile.Nodes(4).Nodes(1).Nodes.Add(New TreeNode("Auth_Session", 3, 3))
        Dim VP = New TreeNode("Visual Programming", 0, 1)
        tvFile.Nodes.Add(VP)
        tvFile.Nodes(5).Nodes.Add(New TreeNode("Assignment_VP", 0, 1))
        tvFile.Nodes(5).Nodes.Add(New TreeNode("PPT_VP", 0, 1))
        tvFile.Nodes(5).Nodes(1).Nodes.Add(New TreeNode("Variable, Constant", 3, 3))
        tvFile.Nodes(5).Nodes(1).Nodes.Add(New TreeNode("List, Loop", 3, 3))
    End Sub
    Sub LoadSubject()
        lstvOutput.LargeImageList = imgFolder
        lstvOutput.Items.Clear()
        lstvOutput.Items.Add("Assignment", 0)
        lstvOutput.Items.Add("PPT", 0)
    End Sub

    Private Sub btnExit2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub tvFile_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles tvFile.NodeMouseClick
        Dim FilePath As String = tvFile.SelectedNode.FullPath.ToString
        lblPath.Text = "Path: " + FilePath
        If tvFile.SelectedNode.Text = "Data structure & Algorithm" Or tvFile.SelectedNode.Text = "Database Management System" Or tvFile.SelectedNode.Text = "Matrix & Vector" Or tvFile.SelectedNode.Text = "Physics" Or tvFile.SelectedNode.Text = "Server Side Internet Programming" Or tvFile.SelectedNode.Text = "Visual Programming" Then
            LoadSubject()
        ElseIf tvFile.SelectedNode.Text = "Assignment_DSA" Then
            lstvOutput.LargeImageList = imgFolder
            lstvOutput.Items.Clear()
            lstvOutput.Items.Add("AssInfix2Suffix", 2)
            lstvOutput.Items.Add("AssLinkedList", 2)
            lstvOutput.Items.Add("AssBinaryTree", 2)
        ElseIf tvFile.SelectedNode.Text = "Assignment_DBMS" Then
            lstvOutput.LargeImageList = imgFolder
            lstvOutput.Items.Clear()
            lstvOutput.Items.Add("AssDB1", 2)
        ElseIf tvFile.SelectedNode.Text = "Assignment_Matrix" Then
            lstvOutput.LargeImageList = imgFolder
            lstvOutput.Items.Clear()
            lstvOutput.Items.Add("AssMatrix1", 2)
            lstvOutput.Items.Add("AssMatrix2", 2)
        ElseIf tvFile.SelectedNode.Text = "Assignment_Physics" Then
            lstvOutput.LargeImageList = imgFolder
            lstvOutput.Items.Clear()
            lstvOutput.Items.Add("1. Electrostatic Interaction", 3)
            lstvOutput.Items.Add("2. Electric Potential", 3)
        ElseIf tvFile.SelectedNode.Text = "Assignment_SSIP" Then
            lstvOutput.LargeImageList = imgFolder
            lstvOutput.Items.Clear()
            lstvOutput.Items.Add("")
        ElseIf tvFile.SelectedNode.Text = "Assignment_VP" Then
            lstvOutput.LargeImageList = imgFolder
            lstvOutput.Items.Clear()
            lstvOutput.Items.Add("")
        ElseIf tvFile.SelectedNode.Text = "PPT_DSA" Then
            lstvOutput.LargeImageList = imgFolder
            lstvOutput.Items.Clear()
            lstvOutput.Items.Add("Infix2Suffix", 3)
            lstvOutput.Items.Add("Linked List", 3)
            lstvOutput.Items.Add("Queue", 3)
            lstvOutput.Items.Add("Binary Tree", 3)
        ElseIf tvFile.SelectedNode.Text = "PPT_DBMS" Then
            lstvOutput.LargeImageList = imgFolder
            lstvOutput.Items.Clear()
            lstvOutput.Items.Add("ch10: DBMS", 3)
        ElseIf tvFile.SelectedNode.Text = "PPT_Matrix" Then
            lstvOutput.LargeImageList = imgFolder
            lstvOutput.Items.Clear()
            lstvOutput.Items.Add("Matrix1", 3)
            lstvOutput.Items.Add("Matrix2", 3)
        ElseIf tvFile.SelectedNode.Text = "PPT_Physics" Then
            lstvOutput.LargeImageList = imgFolder
            lstvOutput.Items.Clear()
            lstvOutput.Items.Add("1. Electrostatic Interaction", 3)
            lstvOutput.Items.Add("2. Electric Potential", 3)
        ElseIf tvFile.SelectedNode.Text = "PPT_SSIP" Then
            lstvOutput.LargeImageList = imgFolder
            lstvOutput.Items.Clear()
            lstvOutput.Items.Add("Python Intro", 3)
            lstvOutput.Items.Add("Django", 3)
            lstvOutput.Items.Add("Model", 3)
            lstvOutput.Items.Add("API", 3)
            lstvOutput.Items.Add("Auth_Session", 3)
        ElseIf tvFile.SelectedNode.Text = "PPT_VP" Then
            lstvOutput.LargeImageList = imgFolder
            lstvOutput.Items.Clear()
            lstvOutput.Items.Add("Variable, Constant", 3)
            lstvOutput.Items.Add("List, Loop", 3)
        End If
    End Sub

    Private Sub tsbtnLargeIcon_Click(sender As Object, e As EventArgs) Handles tsbtnLargeIcon.Click
        lstvOutput.View = View.LargeIcon
    End Sub

    Private Sub tsbtnSmallIcon_Click(sender As Object, e As EventArgs) Handles tsbtnSmallIcon.Click
        lstvOutput.View = View.SmallIcon
    End Sub

    Private Sub tsbtnList_Click(sender As Object, e As EventArgs) Handles tsbtnList.Click
        lstvOutput.View = View.List
    End Sub

    Private Sub tsbtnTile_Click(sender As Object, e As EventArgs) Handles tsbtnTile.Click
        lstvOutput.View = View.Tile
    End Sub
End Class
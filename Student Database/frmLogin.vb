Imports System.Data.SqlClient
Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim con As New SqlConnection("Server= LAPTOP-QRACHJ4J; Database = Student; Integrated Security = True")
        Dim cmd As New SqlCommand("SELECT * FROM Login WHERE Username = @Username and Password = @Password", con)
        cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = txtUsername.Text
        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = txtPassword.Text
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)

        If txtUsername.Text = "" Then
            MsgBox("Fill The Username!")
        ElseIf txtPassword.Text = "" Then
            MsgBox("Fill The Password")
        ElseIf dt.Rows.Count() <= 0 Then
            MsgBox("Wrong either username or password")
        Else
            MsgBox("Login Successful")
            Me.Hide()
            frmLoading.Show()
        End If
    End Sub

    Private Sub txtUsername_MouseHover(sender As Object, e As EventArgs) Handles txtUsername.MouseHover
        tsstLogin.Text = "Enter the Username"
    End Sub

    Private Sub txtUsername_MouseLeave(sender As Object, e As EventArgs) Handles txtUsername.MouseLeave
        tsstLogin.Text = ""
    End Sub

    Private Sub txtPassword_MouseHover(sender As Object, e As EventArgs) Handles txtPassword.MouseHover
        tsstLogin.Text = "Enter the Password"
    End Sub

    Private Sub txtPassword_MouseLeave(sender As Object, e As EventArgs) Handles txtPassword.MouseLeave
        tsstLogin.Text = ""
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub chbShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chbShowPass.CheckedChanged
        If chbShowPass.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class
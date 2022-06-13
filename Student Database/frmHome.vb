Imports System.Data.SqlClient
Public Class frmHome
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer
    Dim Assign() As String

    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\FX505GD\Documents\VP\Student Database\vbconnection.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        disp_data()
        Search("")

        Dim i As Integer
        ReDim Assign(0 To 4)
        For i = 1 To 5
            cmbAss.Items.Add(i)
        Next i
        cmbAss.SelectedIndex = 0
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim gender As String
        If radMale.Checked = True Then
            gender = radMale.Text
        Else
            gender = radFemale.Text
        End If
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into student values('" + txtFname.Text + "','" + txtLname.Text + "','" + (dtpDob.Value).ToString("yyyyMMdd") + "','" + cmbBlood.Text + "','" + txtAddress.Text + "', '" + gender.ToString + "','" + mtxtPhone.Text + "' )"
        cmd.ExecuteNonQuery()
        disp_data()
        MessageBox.Show("Record Inserted Successfully")
    End Sub
    Public Sub disp_data()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM student"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        dgvStudent.DataSource = dt
    End Sub
    Private Sub dgvStudent_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudent.CellClick
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            i = Convert.ToInt32(dgvStudent.SelectedCells.Item(0).Value.ToString())

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * FROM student WHERE id=" & i & ""
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While dr.Read
                txtFname.Text = dr.GetString(1).ToString()
                txtLname.Text = dr.GetString(2).ToString()

                cmbBlood.Text = dr.GetString(4).ToString()
                txtAddress.Text = dr.GetString(5).ToString()
                If dr.GetString(6).ToString() = "Female" Then
                    radFemale.Checked = True
                Else
                    radMale.Checked = True
                End If
                mtxtPhone.Text = dr.GetString(7).ToString()
            End While
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        Dim gender As String
        If radMale.Checked = True Then
            gender = radMale.Text
        Else
            gender = radFemale.Text
        End If
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "UPDATE [dbo].Student SET [First Name]='" + txtFname.Text + "',[Last Name]='" + txtLname.Text + "',[DOB]='" + (dtpDob.Value).ToString("yyyyMMdd") + "',[Blood Type]='" + cmbBlood.Text + "',[Address]='" + txtAddress.Text + "',[Gender]='" + gender.ToString + "',[Phone]='" + mtxtPhone.Text + "'  WHERE id=" & i & ""
        cmd.ExecuteNonQuery()
        disp_data()
        MessageBox.Show("Record Updated Successfully")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "DELETE FROM Student WHERE [First Name]='" + txtFname.Text + "'"
        cmd.ExecuteNonQuery()
        disp_data()
        MessageBox.Show("Record Deleted Successfully")
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        disp_data()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Search(txtSearch.Text)
    End Sub
    Private Sub Search(ValuetoSearch As String)
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM [dbo].Student WHERE CONCAT([First Name], [Last Name], [DOB], [Blood Type], [Address], [Gender], [Phone]) like '%" & ValuetoSearch & "%'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        dgvStudent.DataSource = dt
    End Sub

    Private Sub btnInputAss_Click(sender As Object, e As EventArgs) Handles btnInputAss.Click
        Dim no As Integer, i As Integer
        no = CInt(cmbAss.Text)
        Assign(no) = InputBox("Input To Do List Number : " & no, "Input To Do List")
        If Assign(no) <> "" Then
            lstOutputAss.Items.Clear()
            lstOutputAss.Items.Add("Assignment: ")
            For IntCount As Integer = 0 To chlsbAss.Items.Count - 1
                If chlsbAss.GetItemChecked(IntCount) Then
                    lstOutputAss.Items.Add(vbTab + "* " + chlsbAss.Items(IntCount))
                End If
            Next
            lstOutputAss.Items.Add("")
            For i = 1 To UBound(Assign)
                lstOutputAss.Items.Add("To Do List(" & i & ") = " & Assign(i))
            Next i
        End If
    End Sub

    Private Sub btnInputNumberList_Click(sender As Object, e As EventArgs) Handles btnInputNumberList.Click
        Dim num As Integer, i As Integer
        If Not IsNumeric(nudList.Text) Then Exit Sub
        num = CInt(nudList.Text)
        ReDim Assign(0 To num)
        cmbAss.Items.Clear()
        lstOutputAss.Items.Clear()
        lstOutputAss.Items.Add("Assignment: ")
        For IntCount As Integer = 0 To chlsbAss.Items.Count - 1
            If chlsbAss.GetItemChecked(IntCount) Then
                lstOutputAss.Items.Add(vbTab + "* " + chlsbAss.Items(IntCount))
            End If
        Next
        lstOutputAss.Items.Add("")
        For i = 1 To UBound(Assign)
            cmbAss.Items.Add(i)
            lstOutputAss.Items.Add("To Do List(" & i & ") = " & Assign(i))
        Next i
    End Sub

    Private Sub btnClearToDoList_Click(sender As Object, e As EventArgs) Handles btnClearToDoList.Click
        lstOutputAss.Items.Clear()
    End Sub
End Class
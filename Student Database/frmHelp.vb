Public Class frmHelp
    Dim Text(3) As String
    Dim count As Integer = 0

    Private Sub frmHelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmStudentDatabase.btnChara.ImageIndex = 0 Then
            btnChara.ImageIndex = 0
        ElseIf frmStudentDatabase.btnChara.ImageIndex = 2 Then
            btnChara.ImageIndex = 2
        End If
        Text(0) = "Welcome to the help page. I am as your guide will help you. 
If there is a question you can ask."
        Text(1) = "By click one of the tab, you can see the guide that you need."
        Text(2) = "So, Let's Start do it then."
        lblCharaText.Text = Text(0)
        lblHelpLogin1.Text = "  In the Login Form, you must input the username and 
password correctly. The red circle number 1 is the 
username and the second one is the password. When 
you hover it at username and password textbox the 
status bar in the left corner will show you what to input."
        lblHelpLogin2.Text = "  If you already input the right username and password 
you can see the message box tell you login success. 
Then it will continue to loading phase. And after that 
you can start"
        lblHelpDB.Text = "  In the Student Database, you can input, update, display, delete, and search a data with the button 
red circled mark:
    1. Number 1 is insert button 
        Of course you must input the data first then click or press alt + i to insert the data that you want to input.
    2. Number 2 is update button 
        So you can click one of the row that you want to update and then change the value in the left side and 
        then click or press alt + u to update the data.
    3. Number 3 is Display button
        This button is used to show all the data. So after we search a value of course the data will decrese and 
        just showing the data that we want to search. And to show all the data again you can use display 
        button by click or press alt + p to show all of the data.
    4. Number 4 is Delete button
        This button is used to delete the data by click one of the row that you want to delete and click or press 
        alt + d to delete the data.
    5. Number 5 is Search button
        This button is used to search the data that you want by type the value that you want to search in search 
        textbox number 6. you also can press alt + s to search the data."
        lblHelpToDoList1.Text = "   In To Do List you can input how many the
data and input the data value with the button 
red circled mark:
    1. Number 1 is insert how many to do list
        This button is used to insert how many 
        to do list that the student want to do.
    2. Number 2 is insert what to do list
        This button is used to input what 
        the student to do.
    3. Number 3 is clear button
        This button is used to clear the list 
        output"
        lblHelpToDoList2.Text = "   If you already input how many the to do list
and input what to do, you can see the result
like in the right side that in red circled mark."
        lblHelpFileDir.Text = "     In the File Directory, you can 
choose any folder or file to show 
their childs in list view box. After 
that you also can choose view 
that shown in the picture with 
red circled mark. There are 
large icon, small icon, list, and 
tile that will change the view. 
And you can see the choosen file 
path in the top of the list view box."
        lblHelpCalcu.Text = "   In the Calculator, you can calculate a number with the button that 
already served in this calculator. you can use addition(+), substraction(-),
divide(÷), multiply(x), square(^2), exponent(^), square root(√), logarithm(log), 
cubic root(∛), percent(%), modulus(mod), and answer(ans) to calculate in here.
   To know the what button that you just use, you can see it at label with red 
circled mark that you can see at the picture. After input the number that you 
want to calculate, just click the calculate button or press alt + c to calculate 
the result. You can see the result at the result textbox. The clear button is
used to clear the input and the result or press alt + l to use it. And the exit 
button is used to exit the app or press alt + x to exit the app."
        lblHelpRecArea.Text = "   In the Rectangle Area, you can calculate the area of the rectangle. 
You change the value of width and height by scroll the vscroll 
bar(Number 1) and hscroll bar(Number 2). After input the width 
and the height, you can start to calculate it to find the area 
of the rectangle. The Maximum of the size is 200 x 200."
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        count += 1
        If count > 2 Then
            count -= 1
        End If
        lblCharaText.Text = Text(count)
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        count -= 1
        If count < 0 Then
            count += 1
        End If
        lblCharaText.Text = Text(count)
    End Sub

    Private Sub tsbtnBack_Click(sender As Object, e As EventArgs) Handles tsbtnBack.Click
        Me.Close()
        frmStudentDatabase.Show()
    End Sub
End Class
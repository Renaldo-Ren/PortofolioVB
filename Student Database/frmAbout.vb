Public Class frmAbout
    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTextAbout.Text = "   This Windows Form Application was made with Visual Basic on Microsoft Visual Studio 2019. I Create this 
as my Final Project. My name is Renaldo Major IT 2019 in President University.  This is the first time i did this 
far for Visual Basic Programming. Of course, so far i have gain much knowledge from this Visual Programming. 
I hope that after this i can more learn something new again for this Microsoft Visual Basic knowledge."
    End Sub

    Private Sub btnUnderstand_Click(sender As Object, e As EventArgs) Handles btnUnderstand.Click
        Me.Close()
    End Sub
End Class
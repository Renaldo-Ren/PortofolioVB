Public Class Calculator
    Dim result As Double
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim IsNumbers1 As Boolean = IsNumeric(txtOperand1.Text)
        Dim IsNumbers2 As Boolean = IsNumeric(txtOperand2.Text)
        If IsNumbers1 = True Or IsNumbers2 = True Then
            lblOperator.Text = " "
            txtResult.Text = result
        ElseIf txtOperand1.Text = "" Or txtOperand2.Text = "" Then
            MessageBox.Show("Please Input the number")
        Else
            MessageBox.Show("What is entered in Number is not a number")
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        result = Add(txtOperand1.Text, txtOperand2.Text)
    End Sub
    Private Function Add(ByVal Operand1 As Double, ByVal Operand2 As Double) As Double
        lblOperator.Text = "+"
        Add = Operand1 + Operand2
    End Function

    Private Sub btnSubstract_Click(sender As Object, e As EventArgs) Handles btnSubstract.Click
        result = Substract(txtOperand1.Text, txtOperand2.Text)
    End Sub
    Private Function Substract(ByVal Operand1 As Double, ByVal Operand2 As Double) As Double
        lblOperator.Text = "-"
        Substract = Operand1 - Operand2
    End Function

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        result = Multiply(txtOperand1.Text, txtOperand2.Text)
    End Sub
    Private Function Multiply(ByVal Operand1 As Double, ByVal Operand2 As Double) As Double
        lblOperator.Text = "x"
        Multiply = Operand1 * Operand2
    End Function

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        result = Divide(txtOperand1.Text, txtOperand2.Text)
    End Sub
    Private Function Divide(ByVal Operand1 As Double, ByVal Operand2 As Double) As Double
        lblOperator.Text = "÷"
        Divide = Operand1 / Operand2
    End Function

    Private Sub btnSquare_Click(sender As Object, e As EventArgs) Handles btnSquare.Click
        txtOperand1.Text = Square(txtOperand1.Text)
        result = txtOperand1.Text
    End Sub
    Private Function Square(ByVal Operand1 As Double) As Double
        lblOperator.Text = "^2"
        Square = Operand1 ^ 2
    End Function

    Private Sub btnSqrt_Click(sender As Object, e As EventArgs) Handles btnSqrt.Click
        txtOperand1.Text = Sqrt(txtOperand1.Text)
        result = txtOperand1.Text
    End Sub
    Private Function Sqrt(ByVal Operand1 As Double) As Double
        lblOperator.Text = "√"
        Sqrt = Operand1 ^ 0.5
    End Function

    Private Sub btnCbrt_Click(sender As Object, e As EventArgs) Handles btnCbrt.Click
        txtOperand1.Text = Cbrt(txtOperand1.Text)
        result = txtOperand1.Text
    End Sub
    Private Function Cbrt(ByVal Operand1 As Double) As Double
        lblOperator.Text = "∛"
        Cbrt = Operand1 ^ 0.333333333333333
    End Function

    Private Sub btnPercent_Click(sender As Object, e As EventArgs) Handles btnPercent.Click
        txtOperand1.Text = Percent(txtOperand1.Text)
        result = txtOperand1.Text
    End Sub
    Private Function Percent(ByVal Operand1 As Double) As Double
        lblOperator.Text = "%"
        Percent = Operand1 / 100
    End Function

    Private Sub btnAns_Click(sender As Object, e As EventArgs) Handles btnAns.Click
        txtOperand1.Text = result
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        result = Modu(txtOperand1.Text, txtOperand2.Text)
    End Sub
    Private Function Modu(ByVal Operand1 As Double, ByVal Operand2 As Double) As Double
        lblOperator.Text = "Mod"
        Modu = Operand1 Mod Operand2
    End Function

    Private Sub btnExpo_Click(sender As Object, e As EventArgs) Handles btnExpo.Click
        result = Expo(txtOperand1.Text, txtOperand2.Text)
    End Sub
    Private Function Expo(ByVal Operand1 As Double, ByVal Operand2 As Double) As Double
        lblOperator.Text = "^"
        Expo = Operand1 ^ Operand2
    End Function

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        txtOperand1.Text = Loga(txtOperand1.Text)
        result = txtOperand1.Text
    End Sub
    Private Function Loga(ByVal Operand1 As Double) As Double
        lblOperator.Text = "Log"
        Loga = Math.Log(Operand1) / Math.Log(10)
    End Function

    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Height = 100
        PictureBox1.Width = 100
        vscrlHeight.Left = 220
        vscrlHeight.Minimum = 2
        vscrlHeight.Maximum = 209

        hscrlWidth.Left = 20
        hscrlWidth.Minimum = 2
        hscrlWidth.Maximum = 209
    End Sub

    Private Sub vscrlHeight_Scroll(sender As Object, e As ScrollEventArgs) Handles vscrlHeight.Scroll
        PictureBox1.Height = vscrlHeight.Value
        txtHeight.Text = vscrlHeight.Value
    End Sub

    Private Sub hscrlWidth_Scroll(sender As Object, e As ScrollEventArgs) Handles hscrlWidth.Scroll
        PictureBox1.Width = hscrlWidth.Value
        txtWidth.Text = hscrlWidth.Value
    End Sub

    Private Sub btnRecArea_Click(sender As Object, e As EventArgs) Handles btnRecArea.Click
        Dim height As Integer = txtHeight.Text
        Dim width As Integer = txtWidth.Text
        Dim area As Integer
        area = height * width
        txtArea.Text = area.ToString
    End Sub

    Private Sub btnClearCalcu_Click(sender As Object, e As EventArgs) Handles btnClearCalcu.Click
        txtOperand1.Text = ""
        txtOperand2.Text = ""
        lblOperator.Text = ""
        txtResult.Text = ""
    End Sub

    Private Sub btnExitCalcu_Click(sender As Object, e As EventArgs) Handles btnExitCalcu.Click
        Me.Close()
    End Sub

    Private Sub btnClearRec_Click(sender As Object, e As EventArgs) Handles btnClearRec.Click
        txtHeight.Text = ""
        txtWidth.Text = ""
        txtArea.Text = ""
    End Sub

    Private Sub btnExitRec_Click(sender As Object, e As EventArgs) Handles btnExitRec.Click
        Me.Close()
    End Sub
End Class
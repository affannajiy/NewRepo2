Public Class Activity2
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim num1, num2 As Double
        num1 = CDbl(txtNum1.Text)
        num2 = CDbl(txtNum2.Text)
        Call Add(num1, num2)
    End Sub

    Sub Add(ByVal num1 As Double, ByVal num2 As Double)
        txtResult.Text = num1 + num2
    End Sub
End Class
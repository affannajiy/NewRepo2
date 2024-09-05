Public Class Millionaire
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim balance As Double, years As Integer
        balance = CDbl(txtAmount.Text)
        Do While balance < 1000000
            balance = balance + (0.06 * balance)
            years += 1
        Loop
        txtDisplay.Text = "In " & years & " years you will have RM 1 million!"
    End Sub
End Class
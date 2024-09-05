Public Class Form1
    Dim height, weight, BMI As Double
    Dim category As String

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        height = CDbl(txtHeight.Text)
        weight = CDbl(txtWeight.Text)

        BMI = weight / (height ^ 2)

        If BMI <= 18.5 Then

        End If

    End Sub
End Class

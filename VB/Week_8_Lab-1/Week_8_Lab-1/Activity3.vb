Public Class Activity3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Hypo(CDbl(txtLength.Text), CDbl(txtWidth.Text))
        Call Area(CDbl(txtLength.Text), CDbl(txtWidth.Text))
    End Sub

    Sub Hypo(ByVal Length As Double, ByVal Width As Double)
        Dim result As Double
        result = Math.Sqrt(Length ^ 2 + Width ^ 2)
        lblHypo.Text = "Hypotenuse: " & result & " cm"
    End Sub

    Sub Area(ByVal Length As Double, ByVal Width As Double)
        Dim result As Double
        result = Length * Width / 2
        lblArea.Text = "Area: " & result & " cm^2"
    End Sub
End Class
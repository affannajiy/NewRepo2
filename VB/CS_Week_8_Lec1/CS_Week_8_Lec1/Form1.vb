Public Class Form1
    Private Sub btnColour_Click(sender As Object, e As EventArgs) Handles btnColour.Click
        ColorDialog1.ShowDialog()
        txtSentence.ForeColor = ColorDialog1.Color

    End Sub
End Class

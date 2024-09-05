Public Class Form1
    Dim datcurrent As Date
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datcurrent = Date.Now  'Capturing the Date Now'

        Label1.Text = datcurrent
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Text = TimeOfDay
        Button1.BackColor = Color.Black
        Button1.ForeColor = Color.White
        Button2.ForeColor = Color.Yellow
        Button2.BackColor = Color.Wheat

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = Today
        Button1.BackColor = Color.Cyan
        Button1.ForeColor = Color.White
        Button2.BackColor = Color.Pink
        Button2.ForeColor = Color.Black
    End Sub

End Class

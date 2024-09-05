Public Class Activity1
    Sub correct()
        MsgBox("WELCOME " & UCase(txtName.Text), MsgBoxStyle.Information, "CORRECT!")
    End Sub

    Sub wrong()
        Dim result As MsgBoxResult
        result = MsgBox("Are you sure bro?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "CONFIRMATION")
        If result = MsgBoxResult.Yes Then
            MsgBox("SORRY", MsgBoxStyle.Exclamation, "WRONG")
        Else
            MsgBox("TRY AGAIN", MsgBoxStyle.OkOnly, "TRY AGAIN")
        End If
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Call wrong()
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Call wrong()
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Call wrong()
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Call wrong()
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        Call wrong()
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        Call wrong()
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        Call wrong()
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        Call correct()
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        Call wrong()
    End Sub

    Private Sub btn10_Click(sender As Object, e As EventArgs) Handles btn10.Click
        Call wrong()
    End Sub

    Private Sub btn11_Click(sender As Object, e As EventArgs) Handles btn11.Click
        Call wrong()
    End Sub

    Private Sub btn12_Click(sender As Object, e As EventArgs) Handles btn12.Click
        Call wrong()
    End Sub

    Private Sub btn13_Click(sender As Object, e As EventArgs) Handles btn13.Click
        Call wrong()
    End Sub

    Private Sub btn14_Click(sender As Object, e As EventArgs) Handles btn14.Click
        Call wrong()
    End Sub

    Private Sub btn15_Click(sender As Object, e As EventArgs) Handles btn15.Click
        Call wrong()
    End Sub
End Class
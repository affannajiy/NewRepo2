Public Class Activity1
    'Invisible Message when form loads'
    Private Sub Activity1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblMsg.Visible = False
    End Sub

    'Message is Shown when PRESS is clicked'
    Private Sub btnPress_Click(sender As Object, e As EventArgs) Handles btnPress.Click
        lblMsg.Visible = True
    End Sub

    'Form is closed when EXIT is clicked'
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MsgBox("Thank You for Using Application!!!")
        Me.Close()
    End Sub
End Class

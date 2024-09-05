Public Class Activity2
    'Load the Profile all information Hidden'
    Private Sub Activity2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grpbxProfile.Visible = False
        pcbMyPic.Visible = False
    End Sub

    'Close Button'
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        MsgBox("Thank You for Using Application!!!")
        Me.Close()
    End Sub

    'Show Profile Information'
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        grpbxProfile.Visible = True
        pcbMyPic.Visible = True
        'Disabling Show Button'
        btnShow.Enabled = False
    End Sub

    'Hide Button Information'
    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        grpbxProfile.Visible = False
        pcbMyPic.Visible = False
        'Enabling Show Button'
        btnShow.Enabled = True
    End Sub
End Class

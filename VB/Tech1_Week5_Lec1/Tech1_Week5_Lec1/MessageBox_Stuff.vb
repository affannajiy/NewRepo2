Public Class MessageBox_Stuff
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Maximum allowable hours per week is 60.”, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Payroll Entry“)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Are sure you want to delete?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation“)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim response As String
        response = MsgBox("Are you sure you want to quit", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Confirmation")
        If response = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim response As String
        response = MsgBox("Are you sure you want to quit", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Confirmation")
        If response = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class

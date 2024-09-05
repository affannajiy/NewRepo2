Public Class ExamResult
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MsgBox("Thank you for using the apllication")
        Me.Close()
    End Sub
    'Load some info is hidden
    Private Sub ExamResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnl1.Visible = False
        pnl2.Visible = False
        pnl3.Visible = False
    End Sub

    Private Sub txtMark1_TextLeave(sender As Object, e As EventArgs) Handles txtMark1.Leave
        Dim grade As String
        Dim point As Integer
        Dim mark1, total_point As Double
        Const credit As Integer = 5

        mark1 = CDbl(txtMark1.Text)

        If mark1 < 40 Then
            pnl1.Visible = True
            point = 0
            grade = "F"
            total_point = point * credit
            lblGrade1.Text = grade
            lblPoint1.Text = point
            lblTPoint1.Text = total_point
        ElseIf mark1 >= 40 And mark1 <= 44.9 Then
            pnl1.Visible = True
            point = 1
            grade = "D"
            total_point = point * credit
            lblGrade1.Text = grade
            lblPoint1.Text = point
            lblTPoint1.Text = total_point
        ElseIf mark1 >= 45 And mark1 = 49.9 Then
            pnl1.Visible = True
            point = 1.5
            grade = "D+"
            total_point = point * credit
            lblGrade1.Text = grade
            lblPoint1.Text = point
            lblTPoint1.Text = total_point
        ElseIf mark1 >= 50 And mark1 = 54.9 Then
            pnl1.Visible = True
            point = 2
            grade = "C"
            total_point = point * credit
            lblGrade1.Text = grade
            lblPoint1.Text = point
            lblTPoint1.Text = total_point
        ElseIf mark1 >= 55 And mark1 = 64.9 Then
            pnl1.Visible = True
            point = 2.5
            grade = "C+"
            total_point = point * credit
            lblGrade1.Text = grade
            lblPoint1.Text = point
            lblTPoint1.Text = total_point
        ElseIf mark1 >= 65 And mark1 = 74.9 Then
            pnl1.Visible = True
            point = 3
            grade = "B"
            total_point = point * credit
            lblGrade1.Text = grade
            lblPoint1.Text = point
            lblTPoint1.Text = total_point
        ElseIf mark1 >= 75 And mark1 = 79.9 Then
            pnl1.Visible = True
            point = 3.5
            grade = "B+"
            total_point = point * credit
            lblGrade1.Text = grade
            lblPoint1.Text = point
            lblTPoint1.Text = total_point
        ElseIf mark1 >= 80 And mark1 = 84.9 Then
            pnl1.Visible = True
            point = 3.75
            grade = "A-"
            total_point = point * credit
            lblGrade1.Text = grade
            lblPoint1.Text = point
            lblTPoint1.Text = total_point
        ElseIf mark1 >= 85 Then
            pnl1.Visible = True
            point = 4.0
            grade = "A"
            total_point = point * credit
            lblGrade1.Text = grade
            lblPoint1.Text = point
            lblTPoint1.Text = total_point
        End If
    End Sub

End Class
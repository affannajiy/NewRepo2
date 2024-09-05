Public Class Form1
    Dim myname As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        myname = InputBox("Enter your name", "CS@VP", "Your name")

        MsgBox("Hi " & myname)
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        MsgBox("hi " & myname, 0, "MSGBOX")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("hi " & myname, 1, "MSGBOX")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("hi " & myname, 2, "MSGBOX")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("hi " & myname, 3, "MSGBOX")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox("hi " & myname, 4, "MSGBOX")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MsgBox("hi " & myname, 5, "MSGBOX")
    End Sub

    Private Sub Button_Click_1(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Declare varible and input'
        Dim strWeight As String = InputBox("Enter weight in KG.", "Weight", "0")
        Dim strHeight As String = InputBox("Enter height in M.", "Height", "0")

        'Coversion Process of CDbl(Convert Double'
        Dim dblWeight As Double = CDbl(InputBox("Enter weight in KG.", "Weight", "0"))
        Dim dblHeight As Double = CDbl(InputBox("Enter height in M.", "Height", "0"))
        Dim dblBMI As Double = dblWeight / (Math.Pow(dblHeight, 2.0))

        MessageBox.Show("Your BMI is " & Format(dblBMI, "0.01"), "BMI") 'Name, Pattern'
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        If chkagree.Checked = True Then
            MsgBox("GOOD JOB!!")
        ElseIf chkagree.Checked = False Then
            MsgBox("Jangan kawan DIA ⁽⁽(੭ꐦ •̀Д•́ )੭*⁾⁾")
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        pcbPhoto.Visible = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        pcbPhoto.Visible = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim mymonth As String

        mymonth = lstMonth.SelectedItem
        MsgBox("Your selected month is " & mymonth)
    End Sub

    Private Sub lstJunior_DoubleClick(sender As Object, e As EventArgs) Handles lstJunior.DoubleClick
        'Add 1st baru remove'
        lstSenior.Items.Add(lstJunior.SelectedItem)
        lstJunior.Items.Remove(lstJunior.SelectedItem)
    End Sub

    Private Sub lstSenior_DoubleClick(sender As Object, e As EventArgs) Handles lstSenior.DoubleClick
        lstSenior.Items.Add(lstSenior.SelectedItem)
        lstJunior.Items.Remove(lstSenior.SelectedItem)
    End Sub
End Class
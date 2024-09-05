Public Class PasswordCheck
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim strpassword As String

        strpassword = CStr(txtPassword1.Text)
        Do Until strpassword = "sayasayangutp.utpinme.2023.tolongisipasswordyangbetul"
            MsgBox("Invalid Password " + vbCrLf + "Try Again", 0, "Wrong Password")
            txtPassword1.Clear()
            strpassword = CStr(InputBox("Plase Enter Password"))
        Loop
        MsgBox("Good Job!")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim strpassword1 As String

        Do
            strpassword1 = CStr(InputBox("Plase Enter Password"))

        Loop Until (strpassword1) = "sayasayangutp.utpinme.2023.tolongisipasswordyangbetul"
    End Sub

    'Array Stuff
    Dim strName() As String
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim strTemp As String = ""
        Dim I As Integer = 0
        Do While UCase(strTemp) <> "X"   'X is the checkpoint to stop the loop
            strTemp = InputBox("Enter a name or X to quit:")
            ReDim Preserve strName(I)
            strName(I) = strTemp
            I += 1
        Loop

    End Sub
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim I As Integer
        For I = 0 To UBound(strName) - 1
            lstName.Items.Add(strName(I))
        Next
    End Sub
End Class
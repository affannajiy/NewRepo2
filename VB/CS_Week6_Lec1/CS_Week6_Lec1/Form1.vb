Public Class Form1
    Private Sub txtInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInput.KeyPress
        'know each character being press
        Dim intKeyAscii As Integer
        intKeyAscii = AscW(UCase(e.KeyChar)) ' returns the Integer value
        Select Case intKeyAscii
            Case Is < Keys.Space   'These are control keys; ignore
            Case Keys.D0 To Keys.D9   'These are numeric keys; ignore
            Case Keys.A To Keys.Z   'These are alphabet keys; ignore
            Case Else 'These are not numeric & Alphabet keys
                'display an error message
                MsgBox("Numeric & Alphabet keys only, Please")
                e.Handled = True 'Suppress the key
        End Select
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        If IsNumeric(Val(txtValue.Text)) = False Or Val(txtValue.Text) < 0 Or CStr(txtValue.Text) = String.Empty Then
            MsgBox(“Invalid Input”)
            txtValue.Clear()
        End If
    End Sub
End Class

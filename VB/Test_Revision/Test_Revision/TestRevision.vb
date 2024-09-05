Public Class TestRevision
    'Calc Button
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim cost, totalcost As Double

        'Destination choice
        If rdbtnSydney.Checked Then
            cost = 1499
        ElseIf rdbtnLondon.Checked Then
            cost = 1899
        ElseIf rdbtnPenang.Checked Then
            cost = 199
        ElseIf rdbtnDubai.Checked Then
            cost = 1299
        ElseIf rdbtnSeoul.Checked Then
            cost = 1499
        ElseIf rdbtnKuching.Checked Then
            cost = 399
        Else
            MsgBox("Please choose a destination!")
            Exit Sub 'Exit the sub if no destination is selected
        End If

        'Choosing Details
        If chkbxReturn.Checked Then
            cost *= 2
            totalcost = cost
        Else
            totalcost = cost
        End If

        If chkbxHoneymoon.Checked Then
            cost *= 2
            cost *= 0.7
            totalcost = cost
        Else
            totalcost = cost
        End If

        If chkbxGuide.Checked Then
            cost = cost + 500
            totalcost = cost
        Else
            totalcost = cost
        End If

        'Message box to display total cost
        MsgBox("Your Total Cost for the Ticket Flight : RM " & FormatNumber(totalcost), MsgBoxStyle.OkOnly, "Thank you For Your Purchase")
    End Sub

    'Closing Form
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MsgBox("Thank you for using the application", MsgBoxStyle.OkOnly, "Closing Application")
        Me.Close()
    End Sub

    'Clear Button
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        rdbtnDubai.Checked = False
        rdbtnKuching.Checked = False
        rdbtnLondon.Checked = False
        rdbtnPenang.Checked = False
        rdbtnSeoul.Checked = False
        rdbtnSydney.Checked = False
        chkbxGuide.Checked = False
        chkbxHoneymoon.Checked = False
        chkbxReturn.Checked = False
    End Sub
End Class
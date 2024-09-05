'Credit to Mahendra
Public Class AutoLoanCalc
    Dim NettPrice, BankInterest, MonthlyInstallment, BankMoney As Double

    'Calc Button
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        txtPrice.Text = Val(txtPrice.Text)
        txtRate.Text = Val(txtRate.Text)
        txtDownPay.Text = Val(txtDownPay.Text)
        txtPeriod.Text = Val(txtPeriod.Text)

        NettPrice = txtPrice.Text - txtDownPay.Text
        BankInterest = txtRate.Text / 100 * NettPrice * txtPeriod.Text
        BankMoney = NettPrice + BankInterest
        MonthlyInstallment = BankMoney / (txtPeriod.Text * 12)

        txtNettPrice.Text = "RM" & Format(NettPrice, "0,000.00")
        txtTotalInterest.Text = "RM" & Format(BankInterest, "0.00")
        txtInstallment.Text = "RM" & Format(MonthlyInstallment, "0.00")
        txtBankMoney.Text = "RM" & Format(BankMoney, "0.00")
    End Sub

    'Reset Button
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtPrice.Text = "0"
        txtRate.Text = "0"
        txtDownPay.Text = "0"
        txtPeriod.Text = "0"
        txtNettPrice.Text = "RM0"
        txtTotalInterest.Text = "RM0"
        txtInstallment.Text = "RM0"
        txtBankMoney.Text = "RM0"
    End Sub

    'Close Button
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim result As DialogResult
        result = MsgBox("Do you want to exit?", MessageBoxButtons.YesNo + MessageBoxIcon.Question, "Exiting Apllication")
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
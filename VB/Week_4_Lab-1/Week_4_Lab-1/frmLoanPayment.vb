Public Class frmLoanPayment
    'Declare Variable and Constant'
    Const conOrigFee As Short = 200
    Const conLoanPoint As Double = 0.005
    Dim sngPrinciple, sngRate As Single
    Dim intTerm As Integer
    Dim decMonthlyPayment, decLoanFees As Decimal

    Private Sub btnCalcInput_Click(sender As Object, e As EventArgs) Handles btnCalcInput.Click
        'Varibale declaration'

        Dim strPrinciple As String ' local variable 
        Dim strRate As String
        Dim strTerm As String

        strPrinciple = InputBox("Please suggest amount to borrow :", "RM")
        strRate = InputBox("Please enter the interes rate :", "Interest rate")
        strTerm = InputBox("Please enter a loan term :", "Loan Term")

        'Assign values to sngPrinciple, sngRate and intTerm varibale
        sngPrinciple = Val(txtPrinciple.Text)
        sngRate = Val(cboIntRate.Text) / 100
        sngRate = sngRate / 12

        intTerm = Val(cboLgth.Text) * 12

        'Calculate the monthly payment'
        decMonthlyPayment = sngPrinciple * (sngRate / (1 - (1 + sngRate) ^ -intTerm))

        'Calculate the orgination fees'
        decLoanFees = conOrigFee + (sngPrinciple * conLoanPoint)

        'Display the monthly payment and fees'
        lblPaymentResult.Text = Format(decMonthlyPayment, "Currency")
        lblFeesResult.Text = Format(decLoanFees, "Currency")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exiting Project'
        MsgBox("Thank you for using our apllication", 0, "Loan Payment Calculator")
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Assign values to sngPrinciple, sngRate and intTerm varibale
        sngPrinciple = Val(txtPrinciple.Text)
        sngRate = Val(cboIntRate.Text) / 100
        sngRate = sngRate / 12

        intTerm = Val(cboLgth.Text) * 12

        'Calculate the monthly payment'
        decMonthlyPayment = sngPrinciple * (sngRate / (1 - (1 + sngRate) ^ -intTerm))

        'Calculate the orgination fees'
        decLoanFees = conOrigFee + (sngPrinciple * conLoanPoint)

        'Display the monthly payment and fees'
        lblPaymentResult.Text = Format(decMonthlyPayment, "Currency")
        lblFeesResult.Text = Format(decLoanFees, "Currency")
    End Sub

End Class

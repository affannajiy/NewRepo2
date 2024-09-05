Public Class RetirementCalc
    'Load Form
    Private Sub RetirementCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Preparing to calculate your retirement plan...", "Calculator Load", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'Calculation Button
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Check if any of the required fields are empty
        If String.IsNullOrEmpty(txtAgeCurrent.Text) OrElse
           String.IsNullOrEmpty(txtAgeRetire.Text) OrElse
           String.IsNullOrEmpty(txtIncome.Text) OrElse
           String.IsNullOrEmpty(cmbxRate.Text) Then
            MessageBox.Show("Please fill in all the required fields.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim age_now, age_retire, age_diff As Integer
        Dim saving_rate, income, total_saving, monthly_saving As Double

        'Conversions for variables
        age_now = CInt(txtAgeCurrent.Text)
        age_retire = CInt(txtAgeRetire.Text)
        income = CDbl(txtIncome.Text)
        saving_rate = CInt(cmbxRate.Text)

        'Check if age difference is greater than zero
        If age_retire <= age_now Then
            MessageBox.Show("Please enter a valid age difference. Retirement age should be greater than the current age.", "Age Difference Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        'Age difference
        age_diff = age_retire - age_now

        'Total Savings Needed
        total_saving = (saving_rate / 100) * income

        'Savings for every month
        monthly_saving = total_saving / (12 * age_diff)

        'Formula
        txtSavingsMonthly.Text = monthly_saving
    End Sub

    'Clear Button
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAgeCurrent.Text = "0"
        txtAgeRetire.Text = "0"
        txtIncome.Text = "0"
        cmbxRate.Text = "0"
        txtSavingsMonthly.Text = "0"
    End Sub

    'Closing Button
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Display a message box
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit the application?", "Exit Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        'Check the user's choice
        If result = DialogResult.OK Then
            'Clicked OK to close application
            Me.Close()
            'Clicked cancel, return to application
        End If
    End Sub
End Class

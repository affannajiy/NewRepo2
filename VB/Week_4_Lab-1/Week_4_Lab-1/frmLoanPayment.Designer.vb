<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoanPayment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblAmountBorrow = New System.Windows.Forms.Label()
        Me.lblInterestRate = New System.Windows.Forms.Label()
        Me.lblLengthLoan = New System.Windows.Forms.Label()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.lblFees = New System.Windows.Forms.Label()
        Me.txtPrinciple = New System.Windows.Forms.TextBox()
        Me.cboIntRate = New System.Windows.Forms.ComboBox()
        Me.cboLgth = New System.Windows.Forms.ComboBox()
        Me.lblPaymentResult = New System.Windows.Forms.Label()
        Me.lblFeesResult = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnCalcInput = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDesc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(58, 64)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(406, 32)
        Me.lblDesc.TabIndex = 0
        Me.lblDesc.Text = "Enter the amount to borrow, and then select or enter a rate and a term. To" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "calcu" &
    "late the monthly payment and fees, click the calculation button." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblAmountBorrow
        '
        Me.lblAmountBorrow.AutoSize = True
        Me.lblAmountBorrow.Location = New System.Drawing.Point(62, 119)
        Me.lblAmountBorrow.Name = "lblAmountBorrow"
        Me.lblAmountBorrow.Size = New System.Drawing.Size(93, 13)
        Me.lblAmountBorrow.TabIndex = 1
        Me.lblAmountBorrow.Text = "Amount to borrow:"
        '
        'lblInterestRate
        '
        Me.lblInterestRate.AutoSize = True
        Me.lblInterestRate.Location = New System.Drawing.Point(62, 144)
        Me.lblInterestRate.Name = "lblInterestRate"
        Me.lblInterestRate.Size = New System.Drawing.Size(107, 13)
        Me.lblInterestRate.TabIndex = 2
        Me.lblInterestRate.Text = "Annual Interest Rate:"
        '
        'lblLengthLoan
        '
        Me.lblLengthLoan.AutoSize = True
        Me.lblLengthLoan.Location = New System.Drawing.Point(62, 173)
        Me.lblLengthLoan.Name = "lblLengthLoan"
        Me.lblLengthLoan.Size = New System.Drawing.Size(115, 13)
        Me.lblLengthLoan.TabIndex = 3
        Me.lblLengthLoan.Text = "Length of Loan(Years):"
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Location = New System.Drawing.Point(62, 205)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(91, 13)
        Me.lblPayment.TabIndex = 4
        Me.lblPayment.Text = "Monthly Payment:"
        '
        'lblFees
        '
        Me.lblFees.AutoSize = True
        Me.lblFees.Location = New System.Drawing.Point(62, 236)
        Me.lblFees.Name = "lblFees"
        Me.lblFees.Size = New System.Drawing.Size(86, 13)
        Me.lblFees.TabIndex = 5
        Me.lblFees.Text = "Origination Fees:"
        '
        'txtPrinciple
        '
        Me.txtPrinciple.Location = New System.Drawing.Point(206, 116)
        Me.txtPrinciple.Name = "txtPrinciple"
        Me.txtPrinciple.Size = New System.Drawing.Size(100, 20)
        Me.txtPrinciple.TabIndex = 6
        '
        'cboIntRate
        '
        Me.cboIntRate.FormattingEnabled = True
        Me.cboIntRate.Items.AddRange(New Object() {"2.50", "2.75", "3.00", "3.25", "3.50", "3.75", "4.00", "4.25", "4.50", "4.75", "5.00", "5.25", "5.50", "5.75", "6.00"})
        Me.cboIntRate.Location = New System.Drawing.Point(206, 141)
        Me.cboIntRate.Name = "cboIntRate"
        Me.cboIntRate.Size = New System.Drawing.Size(121, 21)
        Me.cboIntRate.TabIndex = 7
        '
        'cboLgth
        '
        Me.cboLgth.FormattingEnabled = True
        Me.cboLgth.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cboLgth.Location = New System.Drawing.Point(206, 170)
        Me.cboLgth.Name = "cboLgth"
        Me.cboLgth.Size = New System.Drawing.Size(121, 21)
        Me.cboLgth.TabIndex = 8
        '
        'lblPaymentResult
        '
        Me.lblPaymentResult.AutoSize = True
        Me.lblPaymentResult.Location = New System.Drawing.Point(203, 205)
        Me.lblPaymentResult.Name = "lblPaymentResult"
        Me.lblPaymentResult.Size = New System.Drawing.Size(34, 13)
        Me.lblPaymentResult.TabIndex = 9
        Me.lblPaymentResult.Text = "$0.00"
        '
        'lblFeesResult
        '
        Me.lblFeesResult.AutoSize = True
        Me.lblFeesResult.Location = New System.Drawing.Point(203, 236)
        Me.lblFeesResult.Name = "lblFeesResult"
        Me.lblFeesResult.Size = New System.Drawing.Size(34, 13)
        Me.lblFeesResult.TabIndex = 10
        Me.lblFeesResult.Text = "$0.00"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(219, 293)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(108, 23)
        Me.btnCalc.TabIndex = 11
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnCalcInput
        '
        Me.btnCalcInput.Location = New System.Drawing.Point(219, 322)
        Me.btnCalcInput.Name = "btnCalcInput"
        Me.btnCalcInput.Size = New System.Drawing.Size(108, 23)
        Me.btnCalcInput.TabIndex = 12
        Me.btnCalcInput.Text = "Calculate with Input"
        Me.btnCalcInput.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(384, 322)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(108, 23)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmLoanPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 417)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalcInput)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblFeesResult)
        Me.Controls.Add(Me.lblPaymentResult)
        Me.Controls.Add(Me.cboLgth)
        Me.Controls.Add(Me.cboIntRate)
        Me.Controls.Add(Me.txtPrinciple)
        Me.Controls.Add(Me.lblFees)
        Me.Controls.Add(Me.lblPayment)
        Me.Controls.Add(Me.lblLengthLoan)
        Me.Controls.Add(Me.lblInterestRate)
        Me.Controls.Add(Me.lblAmountBorrow)
        Me.Controls.Add(Me.lblDesc)
        Me.Name = "frmLoanPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan Payment Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDesc As Label
    Friend WithEvents lblAmountBorrow As Label
    Friend WithEvents lblInterestRate As Label
    Friend WithEvents lblLengthLoan As Label
    Friend WithEvents lblPayment As Label
    Friend WithEvents lblFees As Label
    Friend WithEvents txtPrinciple As TextBox
    Friend WithEvents cboIntRate As ComboBox
    Friend WithEvents cboLgth As ComboBox
    Friend WithEvents lblPaymentResult As Label
    Friend WithEvents lblFeesResult As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnCalcInput As Button
    Friend WithEvents btnExit As Button
End Class

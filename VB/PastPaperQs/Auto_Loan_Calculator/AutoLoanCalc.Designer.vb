<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AutoLoanCalc
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
        Me.lblVehiclePrice = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnStatement = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtNettPrice = New System.Windows.Forms.TextBox()
        Me.txtInstallment = New System.Windows.Forms.TextBox()
        Me.txtBankMoney = New System.Windows.Forms.TextBox()
        Me.txtTotalInterest = New System.Windows.Forms.TextBox()
        Me.txtPeriod = New System.Windows.Forms.TextBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtDownPay = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblVehiclePrice
        '
        Me.lblVehiclePrice.AutoSize = True
        Me.lblVehiclePrice.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVehiclePrice.Location = New System.Drawing.Point(48, 58)
        Me.lblVehiclePrice.Name = "lblVehiclePrice"
        Me.lblVehiclePrice.Size = New System.Drawing.Size(80, 17)
        Me.lblVehiclePrice.TabIndex = 0
        Me.lblVehiclePrice.Text = "Vehicle Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Downpayment"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(382, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total Interest Paid to Bank"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(382, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total Money Paid to Bank"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Monthly Installment"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(48, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nett Price of Vehicle"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(382, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Interest Rate (%)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(382, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Loan Period (Years)"
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(163, 287)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 32)
        Me.btnCalc.TabIndex = 8
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnStatement
        '
        Me.btnStatement.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatement.Location = New System.Drawing.Point(275, 287)
        Me.btnStatement.Name = "btnStatement"
        Me.btnStatement.Size = New System.Drawing.Size(75, 32)
        Me.btnStatement.TabIndex = 9
        Me.btnStatement.Text = "Statement"
        Me.btnStatement.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(385, 287)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 32)
        Me.btnReset.TabIndex = 10
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(495, 287)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 32)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(190, 55)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(128, 25)
        Me.txtPrice.TabIndex = 12
        Me.txtPrice.Text = "0"
        '
        'txtNettPrice
        '
        Me.txtNettPrice.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNettPrice.Location = New System.Drawing.Point(190, 154)
        Me.txtNettPrice.Name = "txtNettPrice"
        Me.txtNettPrice.ReadOnly = True
        Me.txtNettPrice.Size = New System.Drawing.Size(128, 25)
        Me.txtNettPrice.TabIndex = 13
        Me.txtNettPrice.Text = "RM0"
        '
        'txtInstallment
        '
        Me.txtInstallment.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstallment.Location = New System.Drawing.Point(190, 194)
        Me.txtInstallment.Name = "txtInstallment"
        Me.txtInstallment.ReadOnly = True
        Me.txtInstallment.Size = New System.Drawing.Size(128, 25)
        Me.txtInstallment.TabIndex = 14
        Me.txtInstallment.Text = "RM0"
        '
        'txtBankMoney
        '
        Me.txtBankMoney.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankMoney.Location = New System.Drawing.Point(554, 194)
        Me.txtBankMoney.Name = "txtBankMoney"
        Me.txtBankMoney.ReadOnly = True
        Me.txtBankMoney.Size = New System.Drawing.Size(128, 25)
        Me.txtBankMoney.TabIndex = 15
        Me.txtBankMoney.Text = "RM0"
        '
        'txtTotalInterest
        '
        Me.txtTotalInterest.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalInterest.Location = New System.Drawing.Point(554, 154)
        Me.txtTotalInterest.Name = "txtTotalInterest"
        Me.txtTotalInterest.ReadOnly = True
        Me.txtTotalInterest.Size = New System.Drawing.Size(128, 25)
        Me.txtTotalInterest.TabIndex = 16
        Me.txtTotalInterest.Text = "RM0"
        '
        'txtPeriod
        '
        Me.txtPeriod.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeriod.Location = New System.Drawing.Point(554, 92)
        Me.txtPeriod.Name = "txtPeriod"
        Me.txtPeriod.Size = New System.Drawing.Size(128, 25)
        Me.txtPeriod.TabIndex = 17
        Me.txtPeriod.Text = "0"
        '
        'txtRate
        '
        Me.txtRate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.Location = New System.Drawing.Point(554, 55)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(128, 25)
        Me.txtRate.TabIndex = 18
        Me.txtRate.Text = "0"
        '
        'txtDownPay
        '
        Me.txtDownPay.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDownPay.Location = New System.Drawing.Point(190, 92)
        Me.txtDownPay.Name = "txtDownPay"
        Me.txtDownPay.Size = New System.Drawing.Size(128, 25)
        Me.txtDownPay.TabIndex = 19
        Me.txtDownPay.Text = "0"
        '
        'AutoLoanCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 357)
        Me.Controls.Add(Me.txtDownPay)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.txtPeriod)
        Me.Controls.Add(Me.txtTotalInterest)
        Me.Controls.Add(Me.txtBankMoney)
        Me.Controls.Add(Me.txtInstallment)
        Me.Controls.Add(Me.txtNettPrice)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnStatement)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblVehiclePrice)
        Me.Name = "AutoLoanCalc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tree Automotive Sdn. Bhd."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblVehiclePrice As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnStatement As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtNettPrice As TextBox
    Friend WithEvents txtInstallment As TextBox
    Friend WithEvents txtBankMoney As TextBox
    Friend WithEvents txtTotalInterest As TextBox
    Friend WithEvents txtPeriod As TextBox
    Friend WithEvents txtRate As TextBox
    Friend WithEvents txtDownPay As TextBox

    Private Sub frmAutoLoanCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

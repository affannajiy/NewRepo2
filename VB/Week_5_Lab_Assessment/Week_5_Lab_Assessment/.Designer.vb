<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RetirementCalc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RetirementCalc))
        Me.lblCurrentAge = New System.Windows.Forms.Label()
        Me.lblRetirementAge = New System.Windows.Forms.Label()
        Me.lblIncome = New System.Windows.Forms.Label()
        Me.lblSavingsRate = New System.Windows.Forms.Label()
        Me.lblMonthlySaving = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.txtAgeCurrent = New System.Windows.Forms.TextBox()
        Me.txtAgeRetire = New System.Windows.Forms.TextBox()
        Me.txtIncome = New System.Windows.Forms.TextBox()
        Me.cmbxRate = New System.Windows.Forms.ComboBox()
        Me.txtSavingsMonthly = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCurrentAge
        '
        Me.lblCurrentAge.AutoSize = True
        Me.lblCurrentAge.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentAge.ForeColor = System.Drawing.Color.Black
        Me.lblCurrentAge.Location = New System.Drawing.Point(41, 76)
        Me.lblCurrentAge.Name = "lblCurrentAge"
        Me.lblCurrentAge.Size = New System.Drawing.Size(81, 17)
        Me.lblCurrentAge.TabIndex = 0
        Me.lblCurrentAge.Text = "Current Age:"
        '
        'lblRetirementAge
        '
        Me.lblRetirementAge.AutoSize = True
        Me.lblRetirementAge.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetirementAge.ForeColor = System.Drawing.Color.Black
        Me.lblRetirementAge.Location = New System.Drawing.Point(41, 116)
        Me.lblRetirementAge.Name = "lblRetirementAge"
        Me.lblRetirementAge.Size = New System.Drawing.Size(101, 17)
        Me.lblRetirementAge.TabIndex = 1
        Me.lblRetirementAge.Text = "Retirement Age:"
        '
        'lblIncome
        '
        Me.lblIncome.AutoSize = True
        Me.lblIncome.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncome.ForeColor = System.Drawing.Color.Black
        Me.lblIncome.Location = New System.Drawing.Point(41, 159)
        Me.lblIncome.Name = "lblIncome"
        Me.lblIncome.Size = New System.Drawing.Size(96, 17)
        Me.lblIncome.TabIndex = 2
        Me.lblIncome.Text = "Annual Income:"
        '
        'lblSavingsRate
        '
        Me.lblSavingsRate.AutoSize = True
        Me.lblSavingsRate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSavingsRate.ForeColor = System.Drawing.Color.Black
        Me.lblSavingsRate.Location = New System.Drawing.Point(41, 203)
        Me.lblSavingsRate.Name = "lblSavingsRate"
        Me.lblSavingsRate.Size = New System.Drawing.Size(108, 17)
        Me.lblSavingsRate.TabIndex = 3
        Me.lblSavingsRate.Text = "Savings Rate (%):"
        '
        'lblMonthlySaving
        '
        Me.lblMonthlySaving.AutoSize = True
        Me.lblMonthlySaving.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthlySaving.ForeColor = System.Drawing.Color.Black
        Me.lblMonthlySaving.Location = New System.Drawing.Point(41, 294)
        Me.lblMonthlySaving.Name = "lblMonthlySaving"
        Me.lblMonthlySaving.Size = New System.Drawing.Size(157, 17)
        Me.lblMonthlySaving.TabIndex = 4
        Me.lblMonthlySaving.Text = "Monthly Savings Needed:"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Yellow
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(62, 331)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 40)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(202, 331)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(86, 40)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.Lime
        Me.btnCalc.FlatAppearance.BorderSize = 0
        Me.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalc.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.ForeColor = System.Drawing.Color.Black
        Me.btnCalc.Location = New System.Drawing.Point(131, 231)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(87, 44)
        Me.btnCalc.TabIndex = 7
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'txtAgeCurrent
        '
        Me.txtAgeCurrent.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAgeCurrent.ForeColor = System.Drawing.Color.Black
        Me.txtAgeCurrent.Location = New System.Drawing.Point(146, 73)
        Me.txtAgeCurrent.Name = "txtAgeCurrent"
        Me.txtAgeCurrent.Size = New System.Drawing.Size(100, 25)
        Me.txtAgeCurrent.TabIndex = 8
        Me.txtAgeCurrent.Text = "0"
        '
        'txtAgeRetire
        '
        Me.txtAgeRetire.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAgeRetire.ForeColor = System.Drawing.Color.Black
        Me.txtAgeRetire.Location = New System.Drawing.Point(146, 113)
        Me.txtAgeRetire.Name = "txtAgeRetire"
        Me.txtAgeRetire.Size = New System.Drawing.Size(100, 25)
        Me.txtAgeRetire.TabIndex = 9
        Me.txtAgeRetire.Text = "0"
        '
        'txtIncome
        '
        Me.txtIncome.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncome.ForeColor = System.Drawing.Color.Black
        Me.txtIncome.Location = New System.Drawing.Point(146, 157)
        Me.txtIncome.Name = "txtIncome"
        Me.txtIncome.Size = New System.Drawing.Size(100, 25)
        Me.txtIncome.TabIndex = 10
        Me.txtIncome.Text = "0"
        '
        'cmbxRate
        '
        Me.cmbxRate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxRate.ForeColor = System.Drawing.Color.Black
        Me.cmbxRate.FormattingEnabled = True
        Me.cmbxRate.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100"})
        Me.cmbxRate.Location = New System.Drawing.Point(146, 200)
        Me.cmbxRate.Name = "cmbxRate"
        Me.cmbxRate.Size = New System.Drawing.Size(121, 25)
        Me.cmbxRate.TabIndex = 11
        Me.cmbxRate.Text = "0"
        '
        'txtSavingsMonthly
        '
        Me.txtSavingsMonthly.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSavingsMonthly.ForeColor = System.Drawing.Color.Black
        Me.txtSavingsMonthly.Location = New System.Drawing.Point(202, 291)
        Me.txtSavingsMonthly.Name = "txtSavingsMonthly"
        Me.txtSavingsMonthly.Size = New System.Drawing.Size(100, 25)
        Me.txtSavingsMonthly.TabIndex = 12
        Me.txtSavingsMonthly.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(39, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(249, 25)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Retirement Plan Calculator"
        '
        'RetirementCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(360, 387)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSavingsMonthly)
        Me.Controls.Add(Me.cmbxRate)
        Me.Controls.Add(Me.txtIncome)
        Me.Controls.Add(Me.txtAgeRetire)
        Me.Controls.Add(Me.txtAgeCurrent)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblMonthlySaving)
        Me.Controls.Add(Me.lblSavingsRate)
        Me.Controls.Add(Me.lblIncome)
        Me.Controls.Add(Me.lblRetirementAge)
        Me.Controls.Add(Me.lblCurrentAge)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RetirementCalc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retirement Plan Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCurrentAge As Label
    Friend WithEvents lblRetirementAge As Label
    Friend WithEvents lblIncome As Label
    Friend WithEvents lblSavingsRate As Label
    Friend WithEvents lblMonthlySaving As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents txtAgeCurrent As TextBox
    Friend WithEvents txtAgeRetire As TextBox
    Friend WithEvents txtIncome As TextBox
    Friend WithEvents cmbxRate As ComboBox
    Friend WithEvents txtSavingsMonthly As TextBox
    Friend WithEvents Label6 As Label
End Class

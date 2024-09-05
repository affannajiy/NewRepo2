<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Index
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnKopiSusu = New System.Windows.Forms.Button()
        Me.btnLoan = New System.Windows.Forms.Button()
        Me.btnSRC = New System.Windows.Forms.Button()
        Me.btnSalarySystem = New System.Windows.Forms.Button()
        Me.btnPowerPlant = New System.Windows.Forms.Button()
        Me.btnCGPA = New System.Windows.Forms.Button()
        Me.btnRainfall = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(109, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INDEX"
        '
        'btnKopiSusu
        '
        Me.btnKopiSusu.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKopiSusu.Location = New System.Drawing.Point(25, 142)
        Me.btnKopiSusu.Name = "btnKopiSusu"
        Me.btnKopiSusu.Size = New System.Drawing.Size(328, 59)
        Me.btnKopiSusu.TabIndex = 1
        Me.btnKopiSusu.Text = "Zess Coffee House"
        Me.btnKopiSusu.UseVisualStyleBackColor = True
        '
        'btnLoan
        '
        Me.btnLoan.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoan.Location = New System.Drawing.Point(25, 77)
        Me.btnLoan.Name = "btnLoan"
        Me.btnLoan.Size = New System.Drawing.Size(328, 59)
        Me.btnLoan.TabIndex = 2
        Me.btnLoan.Text = "Auto Loan Calculator"
        Me.btnLoan.UseVisualStyleBackColor = True
        '
        'btnSRC
        '
        Me.btnSRC.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSRC.Location = New System.Drawing.Point(25, 207)
        Me.btnSRC.Name = "btnSRC"
        Me.btnSRC.Size = New System.Drawing.Size(328, 59)
        Me.btnSRC.TabIndex = 3
        Me.btnSRC.Text = "SRC Election System"
        Me.btnSRC.UseVisualStyleBackColor = True
        '
        'btnSalarySystem
        '
        Me.btnSalarySystem.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalarySystem.Location = New System.Drawing.Point(25, 272)
        Me.btnSalarySystem.Name = "btnSalarySystem"
        Me.btnSalarySystem.Size = New System.Drawing.Size(328, 59)
        Me.btnSalarySystem.TabIndex = 4
        Me.btnSalarySystem.Text = "Staff Salary System"
        Me.btnSalarySystem.UseVisualStyleBackColor = True
        '
        'btnPowerPlant
        '
        Me.btnPowerPlant.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPowerPlant.Location = New System.Drawing.Point(25, 337)
        Me.btnPowerPlant.Name = "btnPowerPlant"
        Me.btnPowerPlant.Size = New System.Drawing.Size(328, 59)
        Me.btnPowerPlant.TabIndex = 5
        Me.btnPowerPlant.Text = "Pro Power Plant"
        Me.btnPowerPlant.UseVisualStyleBackColor = True
        '
        'btnCGPA
        '
        Me.btnCGPA.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCGPA.Location = New System.Drawing.Point(25, 402)
        Me.btnCGPA.Name = "btnCGPA"
        Me.btnCGPA.Size = New System.Drawing.Size(328, 59)
        Me.btnCGPA.TabIndex = 6
        Me.btnCGPA.Text = "CGPA Calculator"
        Me.btnCGPA.UseVisualStyleBackColor = True
        '
        'btnRainfall
        '
        Me.btnRainfall.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRainfall.Location = New System.Drawing.Point(25, 467)
        Me.btnRainfall.Name = "btnRainfall"
        Me.btnRainfall.Size = New System.Drawing.Size(328, 59)
        Me.btnRainfall.TabIndex = 7
        Me.btnRainfall.Text = "Rainfall Reading System"
        Me.btnRainfall.UseVisualStyleBackColor = True
        '
        'Index
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 538)
        Me.Controls.Add(Me.btnRainfall)
        Me.Controls.Add(Me.btnCGPA)
        Me.Controls.Add(Me.btnPowerPlant)
        Me.Controls.Add(Me.btnSalarySystem)
        Me.Controls.Add(Me.btnSRC)
        Me.Controls.Add(Me.btnLoan)
        Me.Controls.Add(Me.btnKopiSusu)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Index"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Index"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnKopiSusu As Button
    Friend WithEvents btnLoan As Button
    Friend WithEvents btnSRC As Button
    Friend WithEvents btnSalarySystem As Button
    Friend WithEvents btnPowerPlant As Button
    Friend WithEvents btnCGPA As Button
    Friend WithEvents btnRainfall As Button
End Class

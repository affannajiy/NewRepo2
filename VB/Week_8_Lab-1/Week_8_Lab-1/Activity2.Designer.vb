<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Activity2
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(121, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Let's Add"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(100, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "+"
        '
        'txtNum1
        '
        Me.txtNum1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum1.ForeColor = System.Drawing.Color.Black
        Me.txtNum1.Location = New System.Drawing.Point(34, 84)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(60, 35)
        Me.txtNum1.TabIndex = 2
        '
        'txtNum2
        '
        Me.txtNum2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum2.ForeColor = System.Drawing.Color.Black
        Me.txtNum2.Location = New System.Drawing.Point(133, 84)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(58, 35)
        Me.txtNum2.TabIndex = 3
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.ForeColor = System.Drawing.Color.Black
        Me.btnCalc.Location = New System.Drawing.Point(197, 80)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(55, 44)
        Me.btnCalc.TabIndex = 4
        Me.btnCalc.Text = "="
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult.ForeColor = System.Drawing.Color.Black
        Me.txtResult.Location = New System.Drawing.Point(258, 84)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(56, 35)
        Me.txtResult.TabIndex = 5
        '
        'Activity2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 136)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Activity2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activity2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents txtResult As TextBox
End Class

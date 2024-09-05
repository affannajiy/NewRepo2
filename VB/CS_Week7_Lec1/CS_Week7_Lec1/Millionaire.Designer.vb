<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Millionaire
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
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Amount Deposited (RM)"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(188, 32)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 1
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(39, 68)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(249, 23)
        Me.btnCalc.TabIndex = 2
        Me.btnCalc.Text = "Calculate years to become a millionaire"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(39, 106)
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(249, 20)
        Me.txtDisplay.TabIndex = 3
        '
        'Millionaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Millionaire"
        Me.Text = "Millionaire"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents txtDisplay As TextBox
End Class

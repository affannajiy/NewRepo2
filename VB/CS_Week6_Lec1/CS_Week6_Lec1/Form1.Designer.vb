<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(174, 110)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 20)
        Me.txtInput.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter a number or letter" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(641, 108)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(75, 23)
        Me.btnCompute.TabIndex = 2
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(433, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Please Insert Value"
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(537, 110)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(100, 20)
        Me.txtValue.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInput)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInput As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCompute As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtValue As TextBox
End Class

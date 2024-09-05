<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SRC_Election
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
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(593, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STUDENT REPRESENTATIVE COUNCIL'S"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(100, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(512, 45)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PRESIDENTIAL ELECTION SYSTEM"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnEnter
        '
        Me.btnEnter.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(108, 142)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(226, 59)
        Me.btnEnter.TabIndex = 2
        Me.btnEnter.Text = "Enter Data"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.Location = New System.Drawing.Point(370, 142)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(226, 59)
        Me.btnCheck.TabIndex = 3
        Me.btnCheck.Text = "Check Winner"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'SRC_Election
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 244)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SRC_Election"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SRC_Election"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnCheck As Button
End Class

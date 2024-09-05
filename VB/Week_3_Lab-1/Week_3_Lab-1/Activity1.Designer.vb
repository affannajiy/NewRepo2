<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Activity1
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
        Me.btnPress = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPress
        '
        Me.btnPress.Location = New System.Drawing.Point(56, 41)
        Me.btnPress.Name = "btnPress"
        Me.btnPress.Size = New System.Drawing.Size(126, 44)
        Me.btnPress.TabIndex = 0
        Me.btnPress.Text = "PRESS"
        Me.btnPress.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(258, 41)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(126, 44)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.Location = New System.Drawing.Point(106, 106)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(221, 20)
        Me.lblMsg.TabIndex = 2
        Me.lblMsg.Text = """Welcome to Programmer Life"""
        '
        'Activity1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 157)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPress)
        Me.Name = "Activity1"
        Me.Text = "Activity1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPress As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblMsg As Label
End Class

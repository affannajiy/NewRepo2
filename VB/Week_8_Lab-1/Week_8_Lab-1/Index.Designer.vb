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
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.lblIndex = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(39, 78)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(233, 72)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "Activity 1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(39, 176)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(233, 72)
        Me.btn2.TabIndex = 1
        Me.btn2.Text = "Activity 2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(39, 277)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(233, 72)
        Me.btn3.TabIndex = 2
        Me.btn3.Text = "Activity 3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'lblIndex
        '
        Me.lblIndex.AutoSize = True
        Me.lblIndex.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndex.Location = New System.Drawing.Point(91, 18)
        Me.lblIndex.Name = "lblIndex"
        Me.lblIndex.Size = New System.Drawing.Size(128, 47)
        Me.lblIndex.TabIndex = 3
        Me.lblIndex.Text = "INDEX"
        '
        'Index
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 380)
        Me.Controls.Add(Me.lblIndex)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Name = "Index"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Index"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents lblIndex As Label
End Class

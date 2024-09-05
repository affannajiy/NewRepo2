<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogDiolog
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
        Me.txtMemo = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtEditor = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'txtMemo
        '
        Me.txtMemo.Location = New System.Drawing.Point(89, 12)
        Me.txtMemo.Multiline = True
        Me.txtMemo.Name = "txtMemo"
        Me.txtMemo.Size = New System.Drawing.Size(264, 272)
        Me.txtMemo.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(185, 299)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 1
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(526, 299)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtEditor
        '
        Me.txtEditor.Location = New System.Drawing.Point(430, 12)
        Me.txtEditor.Multiline = True
        Me.txtEditor.Name = "txtEditor"
        Me.txtEditor.Size = New System.Drawing.Size(264, 272)
        Me.txtEditor.TabIndex = 2
        '
        'DialogDiolog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 363)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtEditor)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.txtMemo)
        Me.Name = "DialogDiolog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DialogDiolog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMemo As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnOpen As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtEditor As TextBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class

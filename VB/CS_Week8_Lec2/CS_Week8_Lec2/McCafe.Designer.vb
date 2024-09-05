<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class McCafe
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
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.lstKopiSusu = New System.Windows.Forms.ListBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(33, 306)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(242, 23)
        Me.btnUpload.TabIndex = 1
        Me.btnUpload.Text = "Upload Data"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(33, 335)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(242, 23)
        Me.btnTotal.TabIndex = 2
        Me.btnTotal.Text = "Total Share"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'lstKopiSusu
        '
        Me.lstKopiSusu.FormattingEnabled = True
        Me.lstKopiSusu.Location = New System.Drawing.Point(33, 20)
        Me.lstKopiSusu.Name = "lstKopiSusu"
        Me.lstKopiSusu.Size = New System.Drawing.Size(242, 277)
        Me.lstKopiSusu.TabIndex = 3
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(87, 372)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(122, 13)
        Me.lblResult.TabIndex = 4
        Me.lblResult.Text = "Total market share is 0%"
        '
        'McCafe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 405)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lstKopiSusu)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.btnUpload)
        Me.Name = "McCafe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "McCafe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUpload As Button
    Friend WithEvents btnTotal As Button
    Friend WithEvents lstKopiSusu As ListBox
    Friend WithEvents lblResult As Label
End Class

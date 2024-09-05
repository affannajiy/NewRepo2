<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtSentence = New System.Windows.Forms.TextBox()
        Me.btnColour = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.SuspendLayout()
        '
        'txtSentence
        '
        Me.txtSentence.Location = New System.Drawing.Point(247, 66)
        Me.txtSentence.Multiline = True
        Me.txtSentence.Name = "txtSentence"
        Me.txtSentence.Size = New System.Drawing.Size(234, 149)
        Me.txtSentence.TabIndex = 0
        Me.txtSentence.Text = "KOPI SUSU KURANG MANIS TAMBAH GULA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BADAN LESU KERANA HATI TERGODA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1 2 3 4 AKU B" &
    "ELANJA"
        '
        'btnColour
        '
        Me.btnColour.Location = New System.Drawing.Point(261, 24)
        Me.btnColour.Name = "btnColour"
        Me.btnColour.Size = New System.Drawing.Size(204, 26)
        Me.btnColour.TabIndex = 1
        Me.btnColour.Text = "EDIT FONT COLOUR"
        Me.btnColour.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnColour)
        Me.Controls.Add(Me.txtSentence)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSentence As TextBox
    Friend WithEvents btnColour As Button
    Friend WithEvents ColorDialog1 As ColorDialog
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Activity3
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblHypo = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(448, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "This application is able to calculate the area and hypotenuse of a rectangle." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pl" &
    "ease enter the length and width in cm:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Week_8_Lab_1.My.Resources.Resources.Rectangle_with_Diagonal
        Me.PictureBox1.Location = New System.Drawing.Point(110, 102)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(218, 115)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'txtLength
        '
        Me.txtLength.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLength.Location = New System.Drawing.Point(189, 66)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(56, 25)
        Me.txtLength.TabIndex = 2
        '
        'txtWidth
        '
        Me.txtWidth.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWidth.Location = New System.Drawing.Point(347, 146)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(56, 25)
        Me.txtWidth.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(179, 232)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblHypo
        '
        Me.lblHypo.AutoSize = True
        Me.lblHypo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHypo.Location = New System.Drawing.Point(168, 271)
        Me.lblHypo.Name = "lblHypo"
        Me.lblHypo.Size = New System.Drawing.Size(112, 17)
        Me.lblHypo.TabIndex = 5
        Me.lblHypo.Text = "Hypotenuse: 0 cm"
        Me.lblHypo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.Location = New System.Drawing.Point(168, 290)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(86, 17)
        Me.lblArea.TabIndex = 6
        Me.lblArea.Text = "Area: 0 cm^2"
        Me.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Activity3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 320)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.lblHypo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Activity3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activity3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtLength As TextBox
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblHypo As Label
    Friend WithEvents lblArea As Label
End Class

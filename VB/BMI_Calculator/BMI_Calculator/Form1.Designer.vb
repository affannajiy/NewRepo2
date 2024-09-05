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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBMI = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lstbxCategory = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(81, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Height (m) ="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(81, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Weight (kg) ="
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(155, 48)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtHeight.TabIndex = 2
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(155, 82)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtWeight.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(81, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Result"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(127, 120)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 5
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(106, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "BMI ="
        '
        'txtBMI
        '
        Me.txtBMI.Location = New System.Drawing.Point(163, 175)
        Me.txtBMI.Name = "txtBMI"
        Me.txtBMI.Size = New System.Drawing.Size(100, 20)
        Me.txtBMI.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(108, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Category"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(124, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "BMI CALCULATOR"
        '
        'lstbxCategory
        '
        Me.lstbxCategory.FormattingEnabled = True
        Me.lstbxCategory.Items.AddRange(New Object() {"Underweight", "Normal", "Overweight"})
        Me.lstbxCategory.Location = New System.Drawing.Point(163, 207)
        Me.lstbxCategory.Name = "lstbxCategory"
        Me.lstbxCategory.Size = New System.Drawing.Size(120, 56)
        Me.lstbxCategory.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstbxCategory)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBMI)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBMI As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lstbxCategory As ListBox
End Class

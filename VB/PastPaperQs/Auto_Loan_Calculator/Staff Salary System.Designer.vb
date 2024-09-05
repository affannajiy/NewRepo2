<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff_Salary_System
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCurrentSalary = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblNewSalary = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.lstInfo = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(145, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Staff Salary System"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Staff No. :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Current Salary (RM) :"
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(164, 68)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(212, 25)
        Me.txtID.TabIndex = 4
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(164, 98)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(212, 25)
        Me.txtName.TabIndex = 5
        '
        'txtCurrentSalary
        '
        Me.txtCurrentSalary.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentSalary.Location = New System.Drawing.Point(164, 127)
        Me.txtCurrentSalary.Name = "txtCurrentSalary"
        Me.txtCurrentSalary.Size = New System.Drawing.Size(212, 25)
        Me.txtCurrentSalary.TabIndex = 6
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(407, 71)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(78, 34)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(407, 113)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(78, 34)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblNewSalary
        '
        Me.lblNewSalary.AutoSize = True
        Me.lblNewSalary.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewSalary.Location = New System.Drawing.Point(160, 173)
        Me.lblNewSalary.Name = "lblNewSalary"
        Me.lblNewSalary.Size = New System.Drawing.Size(41, 21)
        Me.lblNewSalary.TabIndex = 9
        Me.lblNewSalary.Text = "0.00"
        '
        'btnShow
        '
        Me.btnShow.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.Location = New System.Drawing.Point(176, 222)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(149, 34)
        Me.btnShow.TabIndex = 10
        Me.btnShow.Text = "Show Salary Info"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'lstInfo
        '
        Me.lstInfo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstInfo.FormattingEnabled = True
        Me.lstInfo.ItemHeight = 17
        Me.lstInfo.Location = New System.Drawing.Point(24, 276)
        Me.lstInfo.Name = "lstInfo"
        Me.lstInfo.Size = New System.Drawing.Size(461, 191)
        Me.lstInfo.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 21)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "New Salary (RM) :"
        '
        'Staff_Salary_System
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 494)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lstInfo)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.lblNewSalary)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtCurrentSalary)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Staff_Salary_System"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff_Salary_System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtCurrentSalary As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents lblNewSalary As Label
    Friend WithEvents btnShow As Button
    Friend WithEvents lstInfo As ListBox
    Friend WithEvents Label5 As Label
End Class

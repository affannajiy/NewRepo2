<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentGrade
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
        Me.lblNumStudents = New System.Windows.Forms.Label()
        Me.txtStudentNumber = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnCalcAvg = New System.Windows.Forms.Button()
        Me.btnGradeHigh = New System.Windows.Forms.Button()
        Me.btnGradeLow = New System.Windows.Forms.Button()
        Me.lblGradeAvg = New System.Windows.Forms.Label()
        Me.lblGradeHigh = New System.Windows.Forms.Label()
        Me.lblGradeLow = New System.Windows.Forms.Label()
        Me.txtGradeAvg = New System.Windows.Forms.TextBox()
        Me.txtGradeHigh = New System.Windows.Forms.TextBox()
        Me.txtGradeLow = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblTcName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNumStudents
        '
        Me.lblNumStudents.AutoSize = True
        Me.lblNumStudents.BackColor = System.Drawing.Color.Transparent
        Me.lblNumStudents.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumStudents.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNumStudents.Location = New System.Drawing.Point(44, 102)
        Me.lblNumStudents.Name = "lblNumStudents"
        Me.lblNumStudents.Size = New System.Drawing.Size(135, 17)
        Me.lblNumStudents.TabIndex = 0
        Me.lblNumStudents.Text = "Number of Students:"
        '
        'txtStudentNumber
        '
        Me.txtStudentNumber.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentNumber.Location = New System.Drawing.Point(185, 99)
        Me.txtStudentNumber.Name = "txtStudentNumber"
        Me.txtStudentNumber.Size = New System.Drawing.Size(130, 25)
        Me.txtStudentNumber.TabIndex = 1
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.Orange
        Me.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnter.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(341, 94)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(112, 33)
        Me.btnEnter.TabIndex = 2
        Me.btnEnter.Text = "Enter Grades"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'btnCalcAvg
        '
        Me.btnCalcAvg.BackColor = System.Drawing.Color.Orange
        Me.btnCalcAvg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcAvg.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcAvg.Location = New System.Drawing.Point(34, 152)
        Me.btnCalcAvg.Name = "btnCalcAvg"
        Me.btnCalcAvg.Size = New System.Drawing.Size(144, 33)
        Me.btnCalcAvg.TabIndex = 3
        Me.btnCalcAvg.Text = "Calculate Average"
        Me.btnCalcAvg.UseVisualStyleBackColor = False
        '
        'btnGradeHigh
        '
        Me.btnGradeHigh.BackColor = System.Drawing.Color.Orange
        Me.btnGradeHigh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGradeHigh.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGradeHigh.Location = New System.Drawing.Point(34, 191)
        Me.btnGradeHigh.Name = "btnGradeHigh"
        Me.btnGradeHigh.Size = New System.Drawing.Size(144, 33)
        Me.btnGradeHigh.TabIndex = 4
        Me.btnGradeHigh.Text = "Find Highest Grade"
        Me.btnGradeHigh.UseVisualStyleBackColor = False
        '
        'btnGradeLow
        '
        Me.btnGradeLow.BackColor = System.Drawing.Color.Orange
        Me.btnGradeLow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGradeLow.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGradeLow.Location = New System.Drawing.Point(34, 230)
        Me.btnGradeLow.Name = "btnGradeLow"
        Me.btnGradeLow.Size = New System.Drawing.Size(144, 33)
        Me.btnGradeLow.TabIndex = 5
        Me.btnGradeLow.Text = "Find Lowest Grade"
        Me.btnGradeLow.UseVisualStyleBackColor = False
        '
        'lblGradeAvg
        '
        Me.lblGradeAvg.AutoSize = True
        Me.lblGradeAvg.BackColor = System.Drawing.Color.Transparent
        Me.lblGradeAvg.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradeAvg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblGradeAvg.Location = New System.Drawing.Point(198, 160)
        Me.lblGradeAvg.Name = "lblGradeAvg"
        Me.lblGradeAvg.Size = New System.Drawing.Size(101, 17)
        Me.lblGradeAvg.TabIndex = 6
        Me.lblGradeAvg.Text = "Average Grade:"
        '
        'lblGradeHigh
        '
        Me.lblGradeHigh.AutoSize = True
        Me.lblGradeHigh.BackColor = System.Drawing.Color.Transparent
        Me.lblGradeHigh.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradeHigh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblGradeHigh.Location = New System.Drawing.Point(198, 199)
        Me.lblGradeHigh.Name = "lblGradeHigh"
        Me.lblGradeHigh.Size = New System.Drawing.Size(98, 17)
        Me.lblGradeHigh.TabIndex = 7
        Me.lblGradeHigh.Text = "Highest Grade:"
        '
        'lblGradeLow
        '
        Me.lblGradeLow.AutoSize = True
        Me.lblGradeLow.BackColor = System.Drawing.Color.Transparent
        Me.lblGradeLow.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradeLow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblGradeLow.Location = New System.Drawing.Point(198, 238)
        Me.lblGradeLow.Name = "lblGradeLow"
        Me.lblGradeLow.Size = New System.Drawing.Size(93, 17)
        Me.lblGradeLow.TabIndex = 8
        Me.lblGradeLow.Text = "Lowest Grade:"
        '
        'txtGradeAvg
        '
        Me.txtGradeAvg.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGradeAvg.Location = New System.Drawing.Point(323, 157)
        Me.txtGradeAvg.Name = "txtGradeAvg"
        Me.txtGradeAvg.ReadOnly = True
        Me.txtGradeAvg.Size = New System.Drawing.Size(146, 25)
        Me.txtGradeAvg.TabIndex = 9
        '
        'txtGradeHigh
        '
        Me.txtGradeHigh.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGradeHigh.Location = New System.Drawing.Point(323, 196)
        Me.txtGradeHigh.Name = "txtGradeHigh"
        Me.txtGradeHigh.ReadOnly = True
        Me.txtGradeHigh.Size = New System.Drawing.Size(146, 25)
        Me.txtGradeHigh.TabIndex = 10
        '
        'txtGradeLow
        '
        Me.txtGradeLow.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGradeLow.Location = New System.Drawing.Point(323, 235)
        Me.txtGradeLow.Name = "txtGradeLow"
        Me.txtGradeLow.ReadOnly = True
        Me.txtGradeLow.Size = New System.Drawing.Size(146, 25)
        Me.txtGradeLow.TabIndex = 11
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Bauhaus 93", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(32, 18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(437, 28)
        Me.lblTitle.TabIndex = 12
        Me.lblTitle.Text = "Student Grade Management Application"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Orange
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(201, 287)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(76, 33)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "EXIT"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblTcName
        '
        Me.lblTcName.AutoSize = True
        Me.lblTcName.BackColor = System.Drawing.Color.Transparent
        Me.lblTcName.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTcName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTcName.Location = New System.Drawing.Point(44, 59)
        Me.lblTcName.Name = "lblTcName"
        Me.lblTcName.Size = New System.Drawing.Size(82, 28)
        Me.lblTcName.TabIndex = 14
        Me.lblTcName.Text = "Welcome"
        '
        'frmStudentGrade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(493, 343)
        Me.Controls.Add(Me.lblTcName)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtGradeLow)
        Me.Controls.Add(Me.txtGradeHigh)
        Me.Controls.Add(Me.txtGradeAvg)
        Me.Controls.Add(Me.lblGradeLow)
        Me.Controls.Add(Me.lblGradeHigh)
        Me.Controls.Add(Me.lblGradeAvg)
        Me.Controls.Add(Me.btnGradeLow)
        Me.Controls.Add(Me.btnGradeHigh)
        Me.Controls.Add(Me.btnCalcAvg)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtStudentNumber)
        Me.Controls.Add(Me.lblNumStudents)
        Me.Name = "frmStudentGrade"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Grades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumStudents As Label
    Friend WithEvents txtStudentNumber As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnCalcAvg As Button
    Friend WithEvents btnGradeHigh As Button
    Friend WithEvents btnGradeLow As Button
    Friend WithEvents lblGradeAvg As Label
    Friend WithEvents lblGradeHigh As Label
    Friend WithEvents lblGradeLow As Label
    Friend WithEvents txtGradeAvg As TextBox
    Friend WithEvents txtGradeHigh As TextBox
    Friend WithEvents txtGradeLow As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents lblTcName As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CGPA_Calculator
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstSubject = New System.Windows.Forms.ListBox()
        Me.lstSubjectTaken = New System.Windows.Forms.ListBox()
        Me.lstGrade = New System.Windows.Forms.ListBox()
        Me.lstCredit = New System.Windows.Forms.ListBox()
        Me.lstPoint = New System.Windows.Forms.ListBox()
        Me.btnAddList = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblCGPA = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "List of Subject"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(265, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Subject Taken"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(411, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Grade"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(505, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Credit Hour"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(618, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Point Earned"
        '
        'lstSubject
        '
        Me.lstSubject.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSubject.FormattingEnabled = True
        Me.lstSubject.ItemHeight = 17
        Me.lstSubject.Items.AddRange(New Object() {"ENGLISH 1", "ENGLISH 2", "CALCULUS", "PROGRAMMING 1", "PROGRAMMING 2"})
        Me.lstSubject.Location = New System.Drawing.Point(28, 63)
        Me.lstSubject.Name = "lstSubject"
        Me.lstSubject.Size = New System.Drawing.Size(172, 106)
        Me.lstSubject.TabIndex = 5
        '
        'lstSubjectTaken
        '
        Me.lstSubjectTaken.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSubjectTaken.FormattingEnabled = True
        Me.lstSubjectTaken.ItemHeight = 17
        Me.lstSubjectTaken.Location = New System.Drawing.Point(221, 63)
        Me.lstSubjectTaken.Name = "lstSubjectTaken"
        Me.lstSubjectTaken.Size = New System.Drawing.Size(172, 106)
        Me.lstSubjectTaken.TabIndex = 6
        '
        'lstGrade
        '
        Me.lstGrade.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstGrade.FormattingEnabled = True
        Me.lstGrade.ItemHeight = 17
        Me.lstGrade.Location = New System.Drawing.Point(392, 63)
        Me.lstGrade.Name = "lstGrade"
        Me.lstGrade.Size = New System.Drawing.Size(92, 106)
        Me.lstGrade.TabIndex = 7
        '
        'lstCredit
        '
        Me.lstCredit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCredit.FormattingEnabled = True
        Me.lstCredit.ItemHeight = 17
        Me.lstCredit.Location = New System.Drawing.Point(483, 63)
        Me.lstCredit.Name = "lstCredit"
        Me.lstCredit.Size = New System.Drawing.Size(92, 106)
        Me.lstCredit.TabIndex = 8
        '
        'lstPoint
        '
        Me.lstPoint.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPoint.FormattingEnabled = True
        Me.lstPoint.ItemHeight = 17
        Me.lstPoint.Location = New System.Drawing.Point(574, 63)
        Me.lstPoint.Name = "lstPoint"
        Me.lstPoint.Size = New System.Drawing.Size(147, 106)
        Me.lstPoint.TabIndex = 9
        '
        'btnAddList
        '
        Me.btnAddList.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddList.Location = New System.Drawing.Point(53, 186)
        Me.btnAddList.Name = "btnAddList"
        Me.btnAddList.Size = New System.Drawing.Size(117, 26)
        Me.btnAddList.TabIndex = 10
        Me.btnAddList.Text = "Add List of Subject"
        Me.btnAddList.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(257, 186)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(94, 26)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Add Subject"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(432, 186)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(111, 26)
        Me.btnCalc.TabIndex = 12
        Me.btnCalc.Text = "Calculate Result"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(603, 186)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 26)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Save Result"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(246, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Student Name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(363, 231)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Name"
        '
        'lblCGPA
        '
        Me.lblCGPA.AutoSize = True
        Me.lblCGPA.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCGPA.Location = New System.Drawing.Point(363, 264)
        Me.lblCGPA.Name = "lblCGPA"
        Me.lblCGPA.Size = New System.Drawing.Size(32, 17)
        Me.lblCGPA.TabIndex = 16
        Me.lblCGPA.Text = "0.00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(246, 264)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "CGPA:"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(335, 298)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 30)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'CGPA_Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 340)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblCGPA)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnAddList)
        Me.Controls.Add(Me.lstPoint)
        Me.Controls.Add(Me.lstCredit)
        Me.Controls.Add(Me.lstGrade)
        Me.Controls.Add(Me.lstSubjectTaken)
        Me.Controls.Add(Me.lstSubject)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CGPA_Calculator"
        Me.Text = "CGPA_Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lstSubject As ListBox
    Friend WithEvents lstSubjectTaken As ListBox
    Friend WithEvents lstGrade As ListBox
    Friend WithEvents lstCredit As ListBox
    Friend WithEvents lstPoint As ListBox
    Friend WithEvents btnAddList As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblCGPA As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnExit As Button
End Class

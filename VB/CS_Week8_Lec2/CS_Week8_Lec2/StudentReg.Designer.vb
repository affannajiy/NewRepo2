<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentReg
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.cmbxProgram = New System.Windows.Forms.ComboBox()
        Me.lstStudent = New System.Windows.Forms.ListBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STUDENT REGISTRATION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Student ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Program"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(107, 79)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 4
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(107, 115)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 5
        '
        'cmbxProgram
        '
        Me.cmbxProgram.FormattingEnabled = True
        Me.cmbxProgram.Items.AddRange(New Object() {"CS", "IT", "IS", "BM"})
        Me.cmbxProgram.Location = New System.Drawing.Point(107, 158)
        Me.cmbxProgram.Name = "cmbxProgram"
        Me.cmbxProgram.Size = New System.Drawing.Size(121, 21)
        Me.cmbxProgram.TabIndex = 6
        '
        'lstStudent
        '
        Me.lstStudent.FormattingEnabled = True
        Me.lstStudent.Location = New System.Drawing.Point(29, 265)
        Me.lstStudent.Name = "lstStudent"
        Me.lstStudent.Size = New System.Drawing.Size(199, 95)
        Me.lstStudent.TabIndex = 7
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(44, 217)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(135, 217)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(75, 23)
        Me.btnRead.TabIndex = 9
        Me.btnRead.Text = "Read"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'StudentReg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 388)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lstStudent)
        Me.Controls.Add(Me.cmbxProgram)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "StudentReg"
        Me.Text = "Student Registration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents cmbxProgram As ComboBox
    Friend WithEvents lstStudent As ListBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class

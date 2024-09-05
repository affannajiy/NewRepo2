<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GroupForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GroupForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGroupName = New System.Windows.Forms.TextBox()
        Me.lstbxStudentName = New System.Windows.Forms.ListBox()
        Me.lstbxGroupNameMember = New System.Windows.Forms.ListBox()
        Me.btnAddGroupName = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnAddGroupMember = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCLose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(36, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Group Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(36, 118)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 34)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "List of " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Student's Name:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(388, 34)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Member (Group Name):" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtGroupName
        '
        Me.txtGroupName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupName.ForeColor = System.Drawing.Color.Black
        Me.txtGroupName.Location = New System.Drawing.Point(175, 27)
        Me.txtGroupName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtGroupName.Name = "txtGroupName"
        Me.txtGroupName.Size = New System.Drawing.Size(139, 25)
        Me.txtGroupName.TabIndex = 3
        '
        'lstbxStudentName
        '
        Me.lstbxStudentName.BackColor = System.Drawing.Color.White
        Me.lstbxStudentName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstbxStudentName.ForeColor = System.Drawing.Color.Black
        Me.lstbxStudentName.FormattingEnabled = True
        Me.lstbxStudentName.ItemHeight = 17
        Me.lstbxStudentName.Items.AddRange(New Object() {"Adham", "'Affan", "Amirul", "Andrew", "Dashita", "Dhesigan", "Ekhwan", "Hannah", "Ikhwan", "Iman", "Luqman", "Luqman Null", "Mahendra", "Manas", "Marwan", "Nassharuddin", "Rasha", "Ria", "Safiqur", "Syahir", "Syahirah", "Syed"})
        Me.lstbxStudentName.Location = New System.Drawing.Point(175, 118)
        Me.lstbxStudentName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstbxStudentName.Name = "lstbxStudentName"
        Me.lstbxStudentName.Size = New System.Drawing.Size(139, 89)
        Me.lstbxStudentName.TabIndex = 4
        '
        'lstbxGroupNameMember
        '
        Me.lstbxGroupNameMember.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstbxGroupNameMember.ForeColor = System.Drawing.Color.Black
        Me.lstbxGroupNameMember.FormattingEnabled = True
        Me.lstbxGroupNameMember.ItemHeight = 17
        Me.lstbxGroupNameMember.Location = New System.Drawing.Point(392, 53)
        Me.lstbxGroupNameMember.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstbxGroupNameMember.Name = "lstbxGroupNameMember"
        Me.lstbxGroupNameMember.Size = New System.Drawing.Size(262, 157)
        Me.lstbxGroupNameMember.TabIndex = 5
        '
        'btnAddGroupName
        '
        Me.btnAddGroupName.BackColor = System.Drawing.Color.Blue
        Me.btnAddGroupName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddGroupName.ForeColor = System.Drawing.Color.Black
        Me.btnAddGroupName.Location = New System.Drawing.Point(97, 68)
        Me.btnAddGroupName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAddGroupName.Name = "btnAddGroupName"
        Me.btnAddGroupName.Size = New System.Drawing.Size(158, 33)
        Me.btnAddGroupName.TabIndex = 6
        Me.btnAddGroupName.Text = "Add Group Name"
        Me.btnAddGroupName.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Yellow
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Black
        Me.btnReset.Location = New System.Drawing.Point(261, 68)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(88, 33)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnAddGroupMember
        '
        Me.btnAddGroupMember.BackColor = System.Drawing.Color.Lime
        Me.btnAddGroupMember.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddGroupMember.ForeColor = System.Drawing.Color.Black
        Me.btnAddGroupMember.Location = New System.Drawing.Point(163, 230)
        Me.btnAddGroupMember.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAddGroupMember.Name = "btnAddGroupMember"
        Me.btnAddGroupMember.Size = New System.Drawing.Size(166, 33)
        Me.btnAddGroupMember.TabIndex = 8
        Me.btnAddGroupMember.Text = "Add Group Member"
        Me.btnAddGroupMember.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Yellow
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(421, 230)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(88, 33)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCLose
        '
        Me.btnCLose.BackColor = System.Drawing.Color.Red
        Me.btnCLose.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCLose.ForeColor = System.Drawing.Color.Black
        Me.btnCLose.Location = New System.Drawing.Point(534, 230)
        Me.btnCLose.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCLose.Name = "btnCLose"
        Me.btnCLose.Size = New System.Drawing.Size(88, 33)
        Me.btnCLose.TabIndex = 10
        Me.btnCLose.Text = "Close"
        Me.btnCLose.UseVisualStyleBackColor = False
        '
        'GroupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(712, 287)
        Me.Controls.Add(Me.btnCLose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAddGroupMember)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnAddGroupName)
        Me.Controls.Add(Me.lstbxGroupNameMember)
        Me.Controls.Add(Me.lstbxStudentName)
        Me.Controls.Add(Me.txtGroupName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "GroupForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Group Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGroupName As TextBox
    Friend WithEvents lstbxStudentName As ListBox
    Friend WithEvents lstbxGroupNameMember As ListBox
    Friend WithEvents btnAddGroupName As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnAddGroupMember As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCLose As Button
End Class

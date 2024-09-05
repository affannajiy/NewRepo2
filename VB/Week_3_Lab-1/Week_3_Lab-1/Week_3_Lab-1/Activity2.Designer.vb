<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Activity2
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblMajor = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pcbMyPic = New System.Windows.Forms.PictureBox()
        Me.grpbxProfile = New System.Windows.Forms.GroupBox()
        CType(Me.pcbMyPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbxProfile.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(6, 25)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(213, 20)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name: 'Affan Najiy bin Rusdi"
        '
        'lblMajor
        '
        Me.lblMajor.AutoSize = True
        Me.lblMajor.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMajor.Location = New System.Drawing.Point(6, 59)
        Me.lblMajor.Name = "lblMajor"
        Me.lblMajor.Size = New System.Drawing.Size(183, 20)
        Me.lblMajor.TabIndex = 1
        Me.lblMajor.Text = "Major: Computer Science"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(6, 93)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(259, 20)
        Me.lblEmail.TabIndex = 2
        Me.lblEmail.Text = "Email: affan_22010453@utp.edu.my"
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(75, 208)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(108, 45)
        Me.btnShow.TabIndex = 4
        Me.btnShow.Text = "SHOW"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnHide
        '
        Me.btnHide.Location = New System.Drawing.Point(274, 208)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(108, 45)
        Me.btnHide.TabIndex = 5
        Me.btnHide.Text = "HIDE"
        Me.btnHide.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(474, 208)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(108, 45)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'pcbMyPic
        '
        Me.pcbMyPic.Image = Global.Week_3_Lab_1.My.Resources.Resources.DSC03692
        Me.pcbMyPic.Location = New System.Drawing.Point(351, 32)
        Me.pcbMyPic.Name = "pcbMyPic"
        Me.pcbMyPic.Size = New System.Drawing.Size(246, 144)
        Me.pcbMyPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbMyPic.TabIndex = 7
        Me.pcbMyPic.TabStop = False
        '
        'grpbxProfile
        '
        Me.grpbxProfile.Controls.Add(Me.lblEmail)
        Me.grpbxProfile.Controls.Add(Me.lblMajor)
        Me.grpbxProfile.Controls.Add(Me.lblName)
        Me.grpbxProfile.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxProfile.Location = New System.Drawing.Point(36, 48)
        Me.grpbxProfile.Name = "grpbxProfile"
        Me.grpbxProfile.Size = New System.Drawing.Size(285, 116)
        Me.grpbxProfile.TabIndex = 8
        Me.grpbxProfile.TabStop = False
        Me.grpbxProfile.Text = "Profile"
        '
        'Activity2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 279)
        Me.Controls.Add(Me.grpbxProfile)
        Me.Controls.Add(Me.pcbMyPic)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.btnShow)
        Me.Name = "Activity2"
        Me.Text = "Activity2"
        CType(Me.pcbMyPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbxProfile.ResumeLayout(False)
        Me.grpbxProfile.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblMajor As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents btnShow As Button
    Friend WithEvents btnHide As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents pcbMyPic As PictureBox
    Friend WithEvents grpbxProfile As GroupBox
End Class

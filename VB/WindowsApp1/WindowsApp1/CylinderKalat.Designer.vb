<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CylinderKalat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CylinderKalat))
        Me.txtradius = New System.Windows.Forms.TextBox()
        Me.lblcylinder_radius = New System.Windows.Forms.Label()
        Me.lblcylinder_height = New System.Windows.Forms.Label()
        Me.txtheight = New System.Windows.Forms.TextBox()
        Me.btnPi1 = New System.Windows.Forms.Button()
        Me.btnPi2 = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblchoose = New System.Windows.Forms.Label()
        Me.lblFormula = New System.Windows.Forms.Label()
        Me.lblor = New System.Windows.Forms.Label()
        Me.lblVolume = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtradius
        '
        Me.txtradius.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtradius.Location = New System.Drawing.Point(239, 54)
        Me.txtradius.Name = "txtradius"
        Me.txtradius.Size = New System.Drawing.Size(107, 26)
        Me.txtradius.TabIndex = 0
        '
        'lblcylinder_radius
        '
        Me.lblcylinder_radius.AutoSize = True
        Me.lblcylinder_radius.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcylinder_radius.Location = New System.Drawing.Point(177, 57)
        Me.lblcylinder_radius.Name = "lblcylinder_radius"
        Me.lblcylinder_radius.Size = New System.Drawing.Size(59, 18)
        Me.lblcylinder_radius.TabIndex = 1
        Me.lblcylinder_radius.Text = "Radius ="
        '
        'lblcylinder_height
        '
        Me.lblcylinder_height.AutoSize = True
        Me.lblcylinder_height.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcylinder_height.Location = New System.Drawing.Point(177, 91)
        Me.lblcylinder_height.Name = "lblcylinder_height"
        Me.lblcylinder_height.Size = New System.Drawing.Size(59, 18)
        Me.lblcylinder_height.TabIndex = 2
        Me.lblcylinder_height.Text = "Height ="
        '
        'txtheight
        '
        Me.txtheight.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtheight.Location = New System.Drawing.Point(239, 88)
        Me.txtheight.Name = "txtheight"
        Me.txtheight.Size = New System.Drawing.Size(107, 26)
        Me.txtheight.TabIndex = 3
        '
        'btnPi1
        '
        Me.btnPi1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPi1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPi1.Location = New System.Drawing.Point(326, 119)
        Me.btnPi1.Name = "btnPi1"
        Me.btnPi1.Size = New System.Drawing.Size(81, 36)
        Me.btnPi1.TabIndex = 4
        Me.btnPi1.Text = "3.142"
        Me.btnPi1.UseVisualStyleBackColor = False
        '
        'btnPi2
        '
        Me.btnPi2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPi2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPi2.Location = New System.Drawing.Point(448, 119)
        Me.btnPi2.Name = "btnPi2"
        Me.btnPi2.Size = New System.Drawing.Size(81, 36)
        Me.btnPi2.TabIndex = 5
        Me.btnPi2.Text = "22/7"
        Me.btnPi2.UseVisualStyleBackColor = False
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCalc.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(209, 196)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(81, 36)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnReset.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(326, 196)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(81, 36)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(448, 196)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(81, 36)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblchoose
        '
        Me.lblchoose.AutoSize = True
        Me.lblchoose.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchoose.Location = New System.Drawing.Point(177, 131)
        Me.lblchoose.Name = "lblchoose"
        Me.lblchoose.Size = New System.Drawing.Size(138, 18)
        Me.lblchoose.TabIndex = 9
        Me.lblchoose.Text = "Choose the value of π"
        '
        'lblFormula
        '
        Me.lblFormula.AutoSize = True
        Me.lblFormula.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormula.Location = New System.Drawing.Point(176, 19)
        Me.lblFormula.Name = "lblFormula"
        Me.lblFormula.Size = New System.Drawing.Size(92, 23)
        Me.lblFormula.TabIndex = 10
        Me.lblFormula.Text = "V = πr^2h"
        '
        'lblor
        '
        Me.lblor.AutoSize = True
        Me.lblor.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblor.Location = New System.Drawing.Point(416, 131)
        Me.lblor.Name = "lblor"
        Me.lblor.Size = New System.Drawing.Size(21, 18)
        Me.lblor.TabIndex = 11
        Me.lblor.Text = "or"
        '
        'lblVolume
        '
        Me.lblVolume.AutoSize = True
        Me.lblVolume.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVolume.Location = New System.Drawing.Point(177, 164)
        Me.lblVolume.Name = "lblVolume"
        Me.lblVolume.Size = New System.Drawing.Size(73, 18)
        Me.lblVolume.TabIndex = 12
        Me.lblVolume.Text = "Volume = 0"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(18, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 167)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'CylinderKalat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(546, 244)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblVolume)
        Me.Controls.Add(Me.lblor)
        Me.Controls.Add(Me.lblFormula)
        Me.Controls.Add(Me.lblchoose)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnPi2)
        Me.Controls.Add(Me.btnPi1)
        Me.Controls.Add(Me.txtheight)
        Me.Controls.Add(Me.lblcylinder_height)
        Me.Controls.Add(Me.lblcylinder_radius)
        Me.Controls.Add(Me.txtradius)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CylinderKalat"
        Me.Text = "Cylinder Volume Calculator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtradius As TextBox
    Friend WithEvents lblcylinder_radius As Label
    Friend WithEvents lblcylinder_height As Label
    Friend WithEvents txtheight As TextBox
    Friend WithEvents btnPi1 As Button
    Friend WithEvents btnPi2 As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblchoose As Label
    Friend WithEvents lblFormula As Label
    Friend WithEvents lblor As Label
    Friend WithEvents lblVolume As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class

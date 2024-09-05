<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rainfall_Reading_System
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
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lstAverage = New System.Windows.Forms.ListBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(56, 30)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(139, 31)
        Me.btnEnter.TabIndex = 0
        Me.btnEnter.Text = "Enter Rainfall"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(260, 30)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(108, 31)
        Me.btnCalc.TabIndex = 1
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'lstAverage
        '
        Me.lstAverage.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAverage.FormattingEnabled = True
        Me.lstAverage.ItemHeight = 17
        Me.lstAverage.Location = New System.Drawing.Point(34, 78)
        Me.lstAverage.Name = "lstAverage"
        Me.lstAverage.Size = New System.Drawing.Size(360, 174)
        Me.lstAverage.TabIndex = 2
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(148, 274)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(132, 17)
        Me.lblResult.TabIndex = 3
        Me.lblResult.Text = "The Average Rain : 0"
        '
        'Rainfall_Reading_System
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 315)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lstAverage)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnEnter)
        Me.Name = "Rainfall_Reading_System"
        Me.Text = "Rainfall_Reading_System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnter As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents lstAverage As ListBox
    Friend WithEvents lblResult As Label
End Class

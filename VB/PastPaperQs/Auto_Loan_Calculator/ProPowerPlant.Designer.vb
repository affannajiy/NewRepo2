<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProPowerPlant
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lstProduction = New System.Windows.Forms.ListBox()
        Me.lstAverage = New System.Windows.Forms.ListBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstProduction
        '
        Me.lstProduction.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstProduction.FormattingEnabled = True
        Me.lstProduction.ItemHeight = 17
        Me.lstProduction.Location = New System.Drawing.Point(30, 53)
        Me.lstProduction.Name = "lstProduction"
        Me.lstProduction.Size = New System.Drawing.Size(274, 293)
        Me.lstProduction.TabIndex = 0
        '
        'lstAverage
        '
        Me.lstAverage.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAverage.FormattingEnabled = True
        Me.lstAverage.ItemHeight = 17
        Me.lstAverage.Location = New System.Drawing.Point(331, 53)
        Me.lstAverage.Name = "lstAverage"
        Me.lstAverage.Size = New System.Drawing.Size(274, 157)
        Me.lstAverage.TabIndex = 1
        '
        'btnEnter
        '
        Me.btnEnter.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(30, 12)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(274, 30)
        Me.btnEnter.TabIndex = 2
        Me.btnEnter.Text = "Enter Data Production"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(331, 12)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(274, 30)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "Calculate Average Production"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(327, 245)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(224, 42)
        Me.lblResult.TabIndex = 4
        Me.lblResult.Text = "The Final Average Production" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0.00 MEGAWATT(S)"
        '
        'ProPowerPlant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 361)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lstAverage)
        Me.Controls.Add(Me.lstProduction)
        Me.Name = "ProPowerPlant"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProPowerPlant"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstProduction As ListBox
    Friend WithEvents lstAverage As ListBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents lblResult As Label
End Class

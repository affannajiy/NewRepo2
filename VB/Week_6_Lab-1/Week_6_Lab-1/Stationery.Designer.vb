<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stationery
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
        Me.components = New System.ComponentModel.Container()
        Me.lstStore = New System.Windows.Forms.ListBox()
        Me.lstBuy = New System.Windows.Forms.ListBox()
        Me.lstPrice = New System.Windows.Forms.ListBox()
        Me.lstQuantity = New System.Windows.Forms.ListBox()
        Me.lblStore = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnBuy = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lstStore
        '
        Me.lstStore.FormattingEnabled = True
        Me.lstStore.Items.AddRange(New Object() {"3.00MYR BOOK", "0.80MYR ERASER"})
        Me.lstStore.Location = New System.Drawing.Point(47, 67)
        Me.lstStore.Name = "lstStore"
        Me.lstStore.Size = New System.Drawing.Size(190, 212)
        Me.lstStore.TabIndex = 0
        '
        'lstBuy
        '
        Me.lstBuy.FormattingEnabled = True
        Me.lstBuy.Location = New System.Drawing.Point(294, 67)
        Me.lstBuy.Name = "lstBuy"
        Me.lstBuy.Size = New System.Drawing.Size(145, 212)
        Me.lstBuy.TabIndex = 1
        '
        'lstPrice
        '
        Me.lstPrice.FormattingEnabled = True
        Me.lstPrice.Location = New System.Drawing.Point(439, 67)
        Me.lstPrice.Name = "lstPrice"
        Me.lstPrice.Size = New System.Drawing.Size(120, 212)
        Me.lstPrice.TabIndex = 2
        '
        'lstQuantity
        '
        Me.lstQuantity.FormattingEnabled = True
        Me.lstQuantity.Location = New System.Drawing.Point(560, 67)
        Me.lstQuantity.Name = "lstQuantity"
        Me.lstQuantity.Size = New System.Drawing.Size(120, 212)
        Me.lstQuantity.TabIndex = 3
        '
        'lblStore
        '
        Me.lblStore.AutoSize = True
        Me.lblStore.Location = New System.Drawing.Point(106, 51)
        Me.lblStore.Name = "lblStore"
        Me.lblStore.Size = New System.Drawing.Size(82, 13)
        Me.lblStore.TabIndex = 4
        Me.lblStore.Text = "Stationery Store"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(341, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Buy Item"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(482, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(594, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Quantity"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(57, 312)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(94, 31)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add Item"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnBuy
        '
        Me.btnBuy.Location = New System.Drawing.Point(182, 312)
        Me.btnBuy.Name = "btnBuy"
        Me.btnBuy.Size = New System.Drawing.Size(94, 31)
        Me.btnBuy.TabIndex = 9
        Me.btnBuy.Text = "Buy Item"
        Me.btnBuy.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(308, 312)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(94, 31)
        Me.btnCalc.TabIndex = 10
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(443, 312)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(94, 31)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(575, 312)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 31)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(106, 368)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblTotal.TabIndex = 13
        '
        'Timer1
        '
        '
        'Stationery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 400)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnBuy)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblStore)
        Me.Controls.Add(Me.lstQuantity)
        Me.Controls.Add(Me.lstPrice)
        Me.Controls.Add(Me.lstBuy)
        Me.Controls.Add(Me.lstStore)
        Me.Name = "Stationery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stationery"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstStore As ListBox
    Friend WithEvents lstBuy As ListBox
    Friend WithEvents lstPrice As ListBox
    Friend WithEvents lstQuantity As ListBox
    Friend WithEvents lblStore As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnBuy As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents Timer1 As Timer
End Class

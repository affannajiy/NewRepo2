<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ZessCoffeeHouse
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
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lstMenu = New System.Windows.Forms.ListBox()
        Me.lstOrder = New System.Windows.Forms.ListBox()
        Me.lstQuantity = New System.Windows.Forms.ListBox()
        Me.lstPrice = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.Location = New System.Drawing.Point(71, 35)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(64, 17)
        Me.lblMenu.TabIndex = 0
        Me.lblMenu.Text = "Menu List"
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrder.Location = New System.Drawing.Point(345, 35)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(66, 17)
        Me.lblOrder.TabIndex = 1
        Me.lblOrder.Text = "Order List"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(484, 35)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(56, 17)
        Me.lblQuantity.TabIndex = 2
        Me.lblQuantity.Text = "Quantity"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(597, 35)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(74, 17)
        Me.lblPrice.TabIndex = 3
        Me.lblPrice.Text = "Price in RM"
        '
        'lstMenu
        '
        Me.lstMenu.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMenu.FormattingEnabled = True
        Me.lstMenu.ItemHeight = 17
        Me.lstMenu.Items.AddRange(New Object() {"Kopi Susu", "Kopi Kurang", "Kopi Manis", "Kopi Tambah", "Kopi Gula"})
        Me.lstMenu.Location = New System.Drawing.Point(30, 55)
        Me.lstMenu.Name = "lstMenu"
        Me.lstMenu.Size = New System.Drawing.Size(156, 123)
        Me.lstMenu.TabIndex = 4
        '
        'lstOrder
        '
        Me.lstOrder.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOrder.FormattingEnabled = True
        Me.lstOrder.ItemHeight = 17
        Me.lstOrder.Location = New System.Drawing.Point(306, 55)
        Me.lstOrder.Name = "lstOrder"
        Me.lstOrder.Size = New System.Drawing.Size(156, 123)
        Me.lstOrder.TabIndex = 5
        '
        'lstQuantity
        '
        Me.lstQuantity.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstQuantity.FormattingEnabled = True
        Me.lstQuantity.ItemHeight = 17
        Me.lstQuantity.Location = New System.Drawing.Point(461, 55)
        Me.lstQuantity.Name = "lstQuantity"
        Me.lstQuantity.Size = New System.Drawing.Size(117, 123)
        Me.lstQuantity.TabIndex = 6
        '
        'lstPrice
        '
        Me.lstPrice.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPrice.FormattingEnabled = True
        Me.lstPrice.ItemHeight = 17
        Me.lstPrice.Location = New System.Drawing.Point(577, 55)
        Me.lstPrice.Name = "lstPrice"
        Me.lstPrice.Size = New System.Drawing.Size(117, 123)
        Me.lstPrice.TabIndex = 7
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(207, 87)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 29)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(207, 129)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 29)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(461, 219)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(99, 29)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save to File"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(594, 219)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(99, 29)
        Me.btnCalc.TabIndex = 11
        Me.btnCalc.Text = "Calculate Total"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(494, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Total Price (RM)"
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPrice.Location = New System.Drawing.Point(594, 276)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(100, 25)
        Me.txtTotalPrice.TabIndex = 13
        Me.txtTotalPrice.Text = "0"
        '
        'ZessCoffeeHouse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 341)
        Me.Controls.Add(Me.txtTotalPrice)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lstPrice)
        Me.Controls.Add(Me.lstQuantity)
        Me.Controls.Add(Me.lstOrder)
        Me.Controls.Add(Me.lstMenu)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.lblMenu)
        Me.Name = "ZessCoffeeHouse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ZessCoffeeHouse"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMenu As Label
    Friend WithEvents lblOrder As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lstMenu As ListBox
    Friend WithEvents lstOrder As ListBox
    Friend WithEvents lstQuantity As ListBox
    Friend WithEvents lstPrice As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTotalPrice As TextBox
End Class

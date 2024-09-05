<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BillApp))
        Me.lblTableNum = New System.Windows.Forms.Label()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.txtTableNum = New System.Windows.Forms.TextBox()
        Me.cmbxItemName = New System.Windows.Forms.ComboBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.numericQuantity = New System.Windows.Forms.NumericUpDown()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.lstbxOrder = New System.Windows.Forms.ListBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotalBill = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        CType(Me.numericQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTableNum
        '
        Me.lblTableNum.AutoSize = True
        Me.lblTableNum.BackColor = System.Drawing.Color.Transparent
        Me.lblTableNum.Font = New System.Drawing.Font("Berlin Sans FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTableNum.Location = New System.Drawing.Point(39, 56)
        Me.lblTableNum.Name = "lblTableNum"
        Me.lblTableNum.Size = New System.Drawing.Size(102, 17)
        Me.lblTableNum.TabIndex = 0
        Me.lblTableNum.Text = "Table Number:"
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.BackColor = System.Drawing.Color.Transparent
        Me.lblItemName.Font = New System.Drawing.Font("Berlin Sans FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.Location = New System.Drawing.Point(39, 86)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(83, 17)
        Me.lblItemName.TabIndex = 1
        Me.lblItemName.Text = "Item Name:"
        '
        'txtTableNum
        '
        Me.txtTableNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTableNum.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTableNum.Location = New System.Drawing.Point(139, 56)
        Me.txtTableNum.Name = "txtTableNum"
        Me.txtTableNum.Size = New System.Drawing.Size(61, 18)
        Me.txtTableNum.TabIndex = 2
        '
        'cmbxItemName
        '
        Me.cmbxItemName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbxItemName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxItemName.FormattingEnabled = True
        Me.cmbxItemName.Items.AddRange(New Object() {"Coffee RM2.50", "Tea RM2.00", "Sandwich RM5.00", "Salad RM6.50", "Burger RM8.00"})
        Me.cmbxItemName.Location = New System.Drawing.Point(139, 83)
        Me.cmbxItemName.Name = "cmbxItemName"
        Me.cmbxItemName.Size = New System.Drawing.Size(121, 25)
        Me.cmbxItemName.TabIndex = 3
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.BackColor = System.Drawing.Color.Transparent
        Me.lblQuantity.Font = New System.Drawing.Font("Berlin Sans FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(39, 122)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(67, 17)
        Me.lblQuantity.TabIndex = 4
        Me.lblQuantity.Text = "Quantity:"
        '
        'numericQuantity
        '
        Me.numericQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numericQuantity.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numericQuantity.Location = New System.Drawing.Point(139, 120)
        Me.numericQuantity.Name = "numericQuantity"
        Me.numericQuantity.Size = New System.Drawing.Size(73, 21)
        Me.numericQuantity.TabIndex = 5
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(139, 157)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 28)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add Item"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.BackColor = System.Drawing.Color.Transparent
        Me.lblOrder.Font = New System.Drawing.Font("Berlin Sans FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrder.Location = New System.Drawing.Point(39, 189)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(72, 17)
        Me.lblOrder.TabIndex = 7
        Me.lblOrder.Text = "Order List:"
        '
        'lstbxOrder
        '
        Me.lstbxOrder.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstbxOrder.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstbxOrder.FormattingEnabled = True
        Me.lstbxOrder.ItemHeight = 17
        Me.lstbxOrder.Location = New System.Drawing.Point(42, 214)
        Me.lstbxOrder.Name = "lstbxOrder"
        Me.lstbxOrder.Size = New System.Drawing.Size(265, 102)
        Me.lstbxOrder.TabIndex = 8
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnCalc.FlatAppearance.BorderSize = 0
        Me.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalc.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(109, 343)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(119, 28)
        Me.btnCalc.TabIndex = 9
        Me.btnCalc.Text = "Calculate Total"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Berlin Sans FB Demi", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(63, 384)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(74, 18)
        Me.lblTotal.TabIndex = 10
        Me.lblTotal.Text = "Total Bill:"
        '
        'txtTotalBill
        '
        Me.txtTotalBill.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalBill.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalBill.Location = New System.Drawing.Point(139, 384)
        Me.txtTotalBill.Name = "txtTotalBill"
        Me.txtTotalBill.ReadOnly = True
        Me.txtTotalBill.Size = New System.Drawing.Size(100, 18)
        Me.txtTotalBill.TabIndex = 11
        Me.txtTotalBill.Text = "RM0.00"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(66, 418)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 28)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(205, 418)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 28)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Baskerville Old Face", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(71, 18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(204, 22)
        Me.lblTitle.TabIndex = 14
        Me.lblTitle.Text = "BILL CALCULATOR"
        '
        'BillApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Week_7_Lab_Assessment.My.Resources.Resources.Bill_BG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(350, 464)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtTotalBill)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lstbxOrder)
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.numericQuantity)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.cmbxItemName)
        Me.Controls.Add(Me.txtTableNum)
        Me.Controls.Add(Me.lblItemName)
        Me.Controls.Add(Me.lblTableNum)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BillApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bill Calculator"
        CType(Me.numericQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTableNum As Label
    Friend WithEvents lblItemName As Label
    Friend WithEvents txtTableNum As TextBox
    Friend WithEvents cmbxItemName As ComboBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents numericQuantity As NumericUpDown
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblOrder As Label
    Friend WithEvents lstbxOrder As ListBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTotalBill As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTitle As Label
End Class

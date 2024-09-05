<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddressBook
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
        Me.pcbxUserPhoto = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblNickName = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblFB = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtNickName = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtFacebook = New System.Windows.Forms.TextBox()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.OpenFileDialogPic = New System.Windows.Forms.OpenFileDialog()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NickNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacebookDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ProfileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AddressBookDataSet = New Address_Book.AddressBookDataSet()
        Me.ProfileTableAdapter = New Address_Book.AddressBookDataSetTableAdapters.ProfileTableAdapter()
        CType(Me.pcbxUserPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ProfileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddressBookDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pcbxUserPhoto
        '
        Me.pcbxUserPhoto.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ProfileBindingSource, "Picture", True))
        Me.pcbxUserPhoto.Location = New System.Drawing.Point(137, 12)
        Me.pcbxUserPhoto.Name = "pcbxUserPhoto"
        Me.pcbxUserPhoto.Size = New System.Drawing.Size(110, 110)
        Me.pcbxUserPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbxUserPhoto.TabIndex = 0
        Me.pcbxUserPhoto.TabStop = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(9, 141)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(47, 17)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name:"
        '
        'lblNickName
        '
        Me.lblNickName.AutoSize = True
        Me.lblNickName.BackColor = System.Drawing.Color.Transparent
        Me.lblNickName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNickName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNickName.Location = New System.Drawing.Point(9, 174)
        Me.lblNickName.Name = "lblNickName"
        Me.lblNickName.Size = New System.Drawing.Size(77, 17)
        Me.lblNickName.TabIndex = 2
        Me.lblNickName.Text = "Nick Name:"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.BackColor = System.Drawing.Color.Transparent
        Me.lblPhone.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPhone.Location = New System.Drawing.Point(9, 209)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(50, 17)
        Me.lblPhone.TabIndex = 3
        Me.lblPhone.Text = "Phone:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblEmail.Location = New System.Drawing.Point(9, 243)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(43, 17)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "Email:"
        '
        'lblFB
        '
        Me.lblFB.AutoSize = True
        Me.lblFB.BackColor = System.Drawing.Color.Transparent
        Me.lblFB.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFB.Location = New System.Drawing.Point(9, 278)
        Me.lblFB.Name = "lblFB"
        Me.lblFB.Size = New System.Drawing.Size(70, 17)
        Me.lblFB.TabIndex = 5
        Me.lblFB.Text = "Facebook:"
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileBindingSource, "FullName", True))
        Me.txtName.Enabled = False
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.Location = New System.Drawing.Point(84, 138)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(279, 25)
        Me.txtName.TabIndex = 6
        '
        'txtNickName
        '
        Me.txtNickName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileBindingSource, "NickName", True))
        Me.txtNickName.Enabled = False
        Me.txtNickName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNickName.ForeColor = System.Drawing.Color.Black
        Me.txtNickName.Location = New System.Drawing.Point(84, 171)
        Me.txtNickName.Name = "txtNickName"
        Me.txtNickName.Size = New System.Drawing.Size(279, 25)
        Me.txtNickName.TabIndex = 7
        '
        'txtPhone
        '
        Me.txtPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileBindingSource, "Phone", True))
        Me.txtPhone.Enabled = False
        Me.txtPhone.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.ForeColor = System.Drawing.Color.Black
        Me.txtPhone.Location = New System.Drawing.Point(84, 206)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(279, 25)
        Me.txtPhone.TabIndex = 8
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileBindingSource, "Email", True))
        Me.txtEmail.Enabled = False
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Location = New System.Drawing.Point(84, 240)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(279, 25)
        Me.txtEmail.TabIndex = 9
        '
        'txtFacebook
        '
        Me.txtFacebook.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileBindingSource, "Facebook", True))
        Me.txtFacebook.Enabled = False
        Me.txtFacebook.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFacebook.ForeColor = System.Drawing.Color.Black
        Me.txtFacebook.Location = New System.Drawing.Point(84, 275)
        Me.txtFacebook.Name = "txtFacebook"
        Me.txtFacebook.Size = New System.Drawing.Size(279, 25)
        Me.txtFacebook.TabIndex = 10
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUpload.FlatAppearance.BorderSize = 0
        Me.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpload.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.ForeColor = System.Drawing.Color.Black
        Me.btnUpload.Location = New System.Drawing.Point(262, 91)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(101, 31)
        Me.btnUpload.TabIndex = 11
        Me.btnUpload.Text = "Upload Photo"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrevious.FlatAppearance.BorderSize = 0
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevious.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.ForeColor = System.Drawing.Color.Black
        Me.btnPrevious.Location = New System.Drawing.Point(47, 306)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(83, 31)
        Me.btnPrevious.TabIndex = 12
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(47, 343)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(83, 31)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnAddNew
        '
        Me.btnAddNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAddNew.FlatAppearance.BorderSize = 0
        Me.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNew.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.ForeColor = System.Drawing.Color.Black
        Me.btnAddNew.Location = New System.Drawing.Point(151, 306)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(83, 31)
        Me.btnAddNew.TabIndex = 18
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.Location = New System.Drawing.Point(151, 343)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(83, 31)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.Black
        Me.btnNext.Location = New System.Drawing.Point(259, 306)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(83, 31)
        Me.btnNext.TabIndex = 20
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(259, 343)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(83, 31)
        Me.btnClose.TabIndex = 21
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FullNameDataGridViewTextBoxColumn, Me.NickNameDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.FacebookDataGridViewTextBoxColumn, Me.PictureDataGridViewImageColumn})
        Me.DataGridView1.DataSource = Me.ProfileBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(9, 55)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(412, 319)
        Me.DataGridView1.TabIndex = 22
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(9, 24)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(311, 25)
        Me.txtSearch.TabIndex = 23
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(339, 20)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(82, 31)
        Me.btnSearch.TabIndex = 24
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnNext)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnAddNew)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.btnPrevious)
        Me.GroupBox1.Controls.Add(Me.btnUpload)
        Me.GroupBox1.Controls.Add(Me.txtFacebook)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtPhone)
        Me.GroupBox1.Controls.Add(Me.txtNickName)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.lblFB)
        Me.GroupBox1.Controls.Add(Me.lblEmail)
        Me.GroupBox1.Controls.Add(Me.lblPhone)
        Me.GroupBox1.Controls.Add(Me.lblNickName)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.pcbxUserPhoto)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 388)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Black
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Controls.Add(Me.txtSearch)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(399, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(431, 388)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'OpenFileDialogPic
        '
        Me.OpenFileDialogPic.FileName = "OpenFileDialog1"
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'FullNameDataGridViewTextBoxColumn
        '
        Me.FullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName"
        Me.FullNameDataGridViewTextBoxColumn.HeaderText = "FullName"
        Me.FullNameDataGridViewTextBoxColumn.Name = "FullNameDataGridViewTextBoxColumn"
        '
        'NickNameDataGridViewTextBoxColumn
        '
        Me.NickNameDataGridViewTextBoxColumn.DataPropertyName = "NickName"
        Me.NickNameDataGridViewTextBoxColumn.HeaderText = "NickName"
        Me.NickNameDataGridViewTextBoxColumn.Name = "NickNameDataGridViewTextBoxColumn"
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'FacebookDataGridViewTextBoxColumn
        '
        Me.FacebookDataGridViewTextBoxColumn.DataPropertyName = "Facebook"
        Me.FacebookDataGridViewTextBoxColumn.HeaderText = "Facebook"
        Me.FacebookDataGridViewTextBoxColumn.Name = "FacebookDataGridViewTextBoxColumn"
        '
        'PictureDataGridViewImageColumn
        '
        Me.PictureDataGridViewImageColumn.DataPropertyName = "Picture"
        Me.PictureDataGridViewImageColumn.HeaderText = "Picture"
        Me.PictureDataGridViewImageColumn.Name = "PictureDataGridViewImageColumn"
        '
        'ProfileBindingSource
        '
        Me.ProfileBindingSource.DataMember = "Profile"
        Me.ProfileBindingSource.DataSource = Me.AddressBookDataSet
        '
        'AddressBookDataSet
        '
        Me.AddressBookDataSet.DataSetName = "AddressBookDataSet"
        Me.AddressBookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProfileTableAdapter
        '
        Me.ProfileTableAdapter.ClearBeforeFill = True
        '
        'frmAddressBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(849, 416)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAddressBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Address Book"
        CType(Me.pcbxUserPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ProfileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddressBookDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pcbxUserPhoto As PictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblNickName As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblFB As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtNickName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtFacebook As TextBox
    Friend WithEvents btnUpload As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAddNew As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents AddressBookDataSet As AddressBookDataSet
    Friend WithEvents ProfileBindingSource As BindingSource
    Friend WithEvents ProfileTableAdapter As AddressBookDataSetTableAdapters.ProfileTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FullNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NickNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FacebookDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PictureDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents OpenFileDialogPic As OpenFileDialog
End Class

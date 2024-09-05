Public Class frmAddressBook
    Private Sub frmAddressBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AddressBookDataSet.Profile' table. You can move, or remove it, as needed.
        Me.ProfileTableAdapter.Fill(Me.AddressBookDataSet.Profile)
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Me.ProfileBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.ProfileBindingSource.MoveNext()
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        txtName.Enabled = True
        txtNickName.Enabled = True
        txtPhone.Enabled = True
        txtEmail.Enabled = True
        txtFacebook.Enabled = True

        Me.ProfileBindingSource.AddNew()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.ProfileBindingSource.EndEdit()
        Me.ProfileTableAdapter.Update(Me.AddressBookDataSet.Profile)
        Me.ProfileTableAdapter.Fill(Me.AddressBookDataSet.Profile)
        MsgBox("Data Saved!")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.ProfileBindingSource.RemoveCurrent()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim strFind As String
        strFind = txtSearch.Text.ToUpper

        'Me.ProfileTableAdapter.Search(Me.AddressBookDataSet.Profile, txtSearch.Text)

        'Dim find_record = From profile In AddressBookDataSet.Profile
        'Where profile.FullName.ToUpper = strFind
        'Select Case profile

        'ProfileBindingSource.DataSource = find_record.AsDataView

        Dim find_record = From profile In AddressBookDataSet.Profile
                          Where profile.FullName.ToUpper Like strFind & "*"
                          Select profile

        ProfileBindingSource.DataSource = find_record.AsDataView
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim openphoto As New OpenFileDialog

        openphoto.Filter = ("Picture File (*.jpg|*.jpg")

        openphoto.ShowDialog()

        pcbxUserPhoto.ImageLocation = openphoto.FileName
    End Sub
End Class

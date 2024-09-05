Public Class GroupForm
    'Add Buttons'
    Private Sub btnAddGroupMember_Click(sender As Object, e As EventArgs) Handles btnAddGroupMember.Click
        Dim selectedStudent As String = lstbxStudentName.SelectedItem
        Dim groupName As String = txtGroupName.Text

        'Name and Group Combined'
        If Not String.IsNullOrEmpty(selectedStudent) Then
            Dim memberWithGroupName As String = $"{selectedStudent} ({groupName})"
            lstbxGroupNameMember.Items.Add(memberWithGroupName)
        Else
            'Warning if name is not selected'
            MessageBox.Show("Please select a student from the student list.", "No Student Selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'Clearing Selected Name in List Box Group Name Member'
    Private Sub lstbxGroupNameMember_DoubleClick(sender As Object, e As EventArgs) Handles lstbxGroupNameMember.DoubleClick
        lstbxGroupNameMember.Items.Remove(lstbxGroupNameMember.SelectedItem)
    End Sub

    'Reset Button'
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtGroupName.Clear()
    End Sub

    'Clearing Button'
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstbxGroupNameMember.Items.Clear()
    End Sub

    'Closing Form'
    Private Sub btnCLose_Click(sender As Object, e As EventArgs) Handles btnCLose.Click
        Dim myname As String
        myname = "Noir"
        MsgBox("Thank you for using the apllication, " & myname, 0, "Closing Application")
        Me.Close()
    End Sub
End Class
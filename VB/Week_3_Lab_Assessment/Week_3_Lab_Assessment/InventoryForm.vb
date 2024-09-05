Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class InventoryForm
    'App Load Event'
    Private Sub InventoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("SUKA STORE APPLICATION Opening...")
    End Sub

    'Add Button'
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Get the Item Name and Item Quantity from Text box and combobox'
        Dim item_name As String = txtbxItemName.Text
        Dim item_quantity As String = cmbxItemQuantity.Text

        'Add the item name and quantity to their respective list box'
        lstbxItemName.Items.Add(item_name)
        lstbxItemQuantity.Items.Add(item_quantity)

        'Automatic clear for ItemName and Item Quantity'
        txtbxItemName.Clear()
        cmbxItemQuantity.Text = ""
    End Sub

    'Clearing Item'
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtbxItemName.Clear()
        cmbxItemQuantity.Text = ""
        lstbxItemName.Items.Clear()
        lstbxItemQuantity.Items.Clear()
    End Sub

    'Closing Form'
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        MsgBox("Thank you for using the SUKA STORE APPLICATION!")
        Me.Close()
    End Sub
End Class

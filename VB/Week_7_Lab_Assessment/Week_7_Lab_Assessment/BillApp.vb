Public Class BillApp
    'Load App
    Private Sub BillApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Application is starting...", MsgBoxStyle.OkOnly, "Loading Application")
    End Sub

    'Add Button
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cmbxItemName.SelectedIndex <> -1 Then
            If numericQuantity.Value <> 0 Then
                Dim itemprice As Double = 0
                Dim startprice As Integer = cmbxItemName.SelectedItem.ToString().IndexOf("RM") + 2 'Aquire position of RM

                If startprice <> -1 Then
                    Dim price As Double

                    'Trimming
                    Dim strprice As String = cmbxItemName.SelectedItem.ToString().Substring(startprice).Trim()

                    If Double.TryParse(strprice, price) Then
                        itemprice = numericQuantity.Value * price

                        'Adding item to listbox
                        lstbxOrder.Items.Add(cmbxItemName.SelectedItem & "(" & numericQuantity.Value & ")" & " = " & "RM" & Format(itemprice, "0.00"))

                        'Clearing selected item
                        numericQuantity.Value = numericQuantity.Minimum
                        cmbxItemName.SelectedIndex = -1
                    End If
                End If
            Else
                MsgBox("Please enter quantity", vbOKOnly + vbExclamation, "Quantity Not Selected")
            End If
        Else
            MsgBox("Please select Item.", vbOKOnly + vbExclamation, "Item Not Selected")
        End If
    End Sub

    'Calculate Button
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        If txtTableNum.Text <> "" Then
            Dim total As Double = 0

            For Each item As String In lstbxOrder.Items
                Dim startprice As Integer = item.IndexOf("RM") + 2 'Acquire position of RM

                If startprice <> -1 Then
                    Dim itemprice As Double

                    'Trimming
                    Dim itemclean As String = item.Substring(startprice).TrimStart(" "c, "•"c)

                    'Extract quantity from the cleaned item
                    Dim startquantity As Integer = itemclean.IndexOf("(") + 1
                    Dim endquantity As Integer = itemclean.IndexOf(")")

                    If startquantity <> -1 And endquantity <> -1 Then
                        Dim quantity As Integer
                        If Integer.TryParse(itemclean.Substring(startquantity, endquantity - startquantity), quantity) Then
                            'Extract the price
                            Dim priceString As String = itemclean.Substring(0, startquantity - 1).Trim()
                            If Double.TryParse(priceString, itemprice) Then
                                total += quantity * itemprice
                            End If
                        End If
                    End If
                End If
            Next
            'Display the total in a label or textbox
            txtTotalBill.Text = "RM" & Format(total, "0.00")
        Else
            MsgBox("Table number not entered", vbOKOnly + vbCritical, "Table Number Not Entered")
        End If
    End Sub

    'Clear Button
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTableNum.Text = ""
        numericQuantity.Value = numericQuantity.Minimum
        cmbxItemName.SelectedIndex = -1
        lstbxOrder.Items.Clear()
        txtTotalBill.Text = ""
    End Sub

    'Exit Button
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As MsgBoxResult = MsgBox("Do you want to exit the application?", vbYesNo + vbQuestion, "Exit Confirmation")
        If result = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
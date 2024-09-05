'Credit to Mahendra and Andrew
Public Class ZessCoffeeHouse
    'Add Button
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim quantity As Integer
        Dim price As Double
        Dim name As String = lstMenu.SelectedItem.ToString
        quantity = InputBox("Please enter quantity of coffee", "Quantity")
        Select Case lstMenu.SelectedIndex
            Case 0
                price = 8.5 * quantity
            Case 1
                price = 12 * quantity
            Case 2
                price = 8 * quantity
            Case 3
                price = 5.5 * quantity
            Case 4
                price = 8.5 * quantity
        End Select
        lstOrder.Items.Add(name)
        lstQuantity.Items.Add(quantity)
        lstPrice.Items.Add(Format(price, "0.00"))
    End Sub

    'Delete Button
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim I As Integer
        Do While I < lstOrder.Items.Count
            If lstOrder.Items(I) = lstMenu.SelectedItem.ToString Then
                lstOrder.Items.Remove(lstOrder.Items(I))
                lstQuantity.Items.Remove(lstQuantity.Items(I))
                lstPrice.Items.Remove(lstPrice.Items(I))
                Exit Do
            Else
                I += 1
            End If
        Loop
    End Sub

    'Save Button
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim File = New System.IO.StreamWriter("C:\Users\user\Desktop\Visual Studio\PastPaperQs\ZessCoffee.txt", True)
        File.WriteLine("Total Price:" + txtTotalPrice.Text)
        File.Close()
    End Sub

    'Calculate Button
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim I As Integer
        Dim total As Double
        Do While I < lstPrice.Items.Count
            total += Val(lstPrice.Items(I))
            I += 1
        Loop
        txtTotalPrice.Text = total
    End Sub
End Class
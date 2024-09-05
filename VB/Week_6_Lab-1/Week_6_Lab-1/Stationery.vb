Public Class Stationery
    'Load Form
    Private Sub Stationery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Stationery Form Starting...", MsgBoxStyle.OkOnly, "Form Load")
        MsgBox("Kejap eh..", MsgBoxStyle.OkOnly, "Jap..")
        MsgBox("1 more second do", MsgBoxStyle.OkOnly, "Nak Bukak Dah ni")
        Timer1.Start()
    End Sub

    'Exit Button
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'Add Button
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim strItem As String

        strItem = InputBox("Enter Stationery Item Using priceMYR Item Format", "Add Item")
        lstStore.Items.Add(UCase(strItem))
    End Sub

    'Clear Button
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstBuy.Items.Clear()
        lstPrice.Items.Clear()
        lstQuantity.Items.Clear()
        lblTotal.Text = ""
    End Sub

    'Calculate Button
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim sngTotalPrice As Double = 0
        Dim intIndex As Integer = 0
        Dim price As Double
        Dim intQuantity As Integer = 0

        Do Until intIndex = lstPrice.Items.Count
            price = CDbl(lstPrice.Items(intIndex))
            intQuantity = CDbl(lstQuantity.Items(intIndex))
            sngTotalPrice = sngTotalPrice + (price * intQuantity)
            intIndex = intIndex + 1
        Loop

        lblTotal.Text = "Your total stationery sales " & Format(sngTotalPrice, "currency")
    End Sub

    'Buy Button
    Private Sub btnBuy_Click(sender As Object, e As EventArgs) Handles btnBuy.Click
        Dim strItem, strQuantity As String
        Dim sngPrice As Single

        strQuantity = InputBox("Quantity", "Quantity")

        strItem = lstStore.SelectedItem.ToString
        sngPrice = Val(lstStore.SelectedItem)

        lstBuy.Items.Add(strItem)
        lstPrice.Items.Add(Format(sngPrice, "0.00"))
        lstQuantity.Items.Add(strQuantity)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Close()
    End Sub
End Class
Imports System.Reflection.Emit
'Credit to Ikhwan
Public Class ProPowerPlant
    Dim NoOfBranches As Integer = 3
    Dim NoOfMonths As Integer = 4

    Dim ProductionRecords(2, 3) As Double
    Dim AverageProduction(2) As Double
    Dim TotalAverage As Double
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim I As Integer = 0
        Dim J As Integer = 0
        Dim State As String

        For I = 0 To 2
            If I = 0 Then
                State = "Perak"
            ElseIf I = 1 Then
                State = "KL"
            ElseIf I = 2 Then
                State = "Johor"
            End If

            For J = 0 To 3
                ProductionRecords(I, J) = InputBox("What is the ProductionRecords of " & State & " for month " & J + 1 & "?", "TO THE USER")
            Next
        Next

        lstProduction.Items.Clear()

        Dim A As Integer = 0
        Dim B As Integer = 0

        For A = 0 To 2
            If A = 0 Then
                State = "Perak"
            ElseIf A = 1 Then
                State = "KL"
            ElseIf A = 2 Then
                State = "Johor"
            End If

            lstProduction.Items.Add("LOCATION : " & UCase(State))

            For B = 0 To 3
                lstProduction.Items.Add("MONTH " & B + 1 & ": " & ProductionRecords(A, B) & " Megawatt")
            Next
            lstProduction.Items.Add("")
        Next
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim I As Integer = 0

        For I = 0 To 3
            AverageProduction(0) = AverageProduction(0) + CDbl(ProductionRecords(0, I))
        Next

        AverageProduction(0) = AverageProduction(0) / 4

        Dim J As Integer = 0
        For J = 0 To 3
            AverageProduction(1) = AverageProduction(1) + CDbl(ProductionRecords(1, J))
        Next

        AverageProduction(1) = AverageProduction(1) / 4

        Dim K As Integer = 0
        For K = 0 To 3
            AverageProduction(2) = AverageProduction(2) + CDbl(ProductionRecords(2, K))
        Next

        AverageProduction(2) = AverageProduction(2) / 4

        lstAverage.Items.Clear()
        lstAverage.Items.Add("Perak: " & CStr(AverageProduction(0)) & " Megawatt")
        lstAverage.Items.Add("KL: " & CStr(AverageProduction(1)) & " Megawatt")
        lstAverage.Items.Add("Johor: " & CStr(AverageProduction(2)) & " Megawatt")

        TotalAverage = AverageProduction(0) + AverageProduction(1) + AverageProduction(2)

        lblResult.Text = FinalAverage(TotalAverage)
    End Sub

    Private Function FinalAverage(ByVal TotalAverage As Double) As String
        lblResult.Text = "THE FINAL AVERAGE PRODUCTION" & vbNewLine & CStr(FormatNumber(TotalAverage / 3)) & " MEGAWATT"
        Return lblResult.Text
    End Function
End Class
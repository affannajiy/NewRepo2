Imports System.Reflection.Emit
'Credit to IKhwan
Public Class Rainfall_Reading_System
    Dim NoOfLocation As Integer = 2
    Dim NoOfMonth As Integer = 12

    Dim RainfallReading(1, 11) As Double
    Dim AverageRainfall(1) As Double
    Dim FinalAverage As Double = 0

    'Enter Button
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim I As Integer = 0
        Dim J As Integer = 0
        Dim City As String

        For I = 0 To 1
            For J = 0 To 11
                If I = 0 Then
                    City = "SI"
                Else
                    City = "Ipoh"
                End If
                RainfallReading(I, J) = InputBox("What is the rainfallreding of " & City & " for " & J + 1 & " month?", "TO THE USER")
            Next
        Next
    End Sub

    'Calculate Button 
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim I As Integer = 0

        For I = 0 To 11
            AverageRainfall(0) = AverageRainfall(0) + CDbl(RainfallReading(0, I))
        Next
        AverageRainfall(0) = AverageRainfall(0) / 12

        Dim J As Integer = 0
        For J = 0 To 11
            AverageRainfall(1) = AverageRainfall(1) + CDbl(RainfallReading(1, J))
        Next
        AverageRainfall(1) = AverageRainfall(1) / 12

        lstAverage.Items.Clear()
        lstAverage.Items.Add("Location" & vbTab & "Average")
        lstAverage.Items.Add("SI" & vbTab & AverageRainfall(0))
        lstAverage.Items.Add("Ipoh" & vbTab & AverageRainfall(1))

        'Label1.Text = "SIUU" & vbNewLine & "SHEESH"

        lblResult.Text = FAverage(AverageRainfall(0), AverageRainfall(1))
    End Sub

    'Average Function Calling
    Public Function FAverage(ByVal AverageRainfall1 As Double, ByVal AverageRainfall2 As Double) As String

        FinalAverage = (AverageRainfall1 + AverageRainfall2) / 2

        lblResult.Text = "The Average Rain : " & CStr(FinalAverage)

        Return lblResult.Text

    End Function
End Class
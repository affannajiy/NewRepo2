Imports System.IO

Public Class McCafe
    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim File As System.IO.StreamReader
        File = New System.IO.StreamReader("C:\Users\user\source\repos\ItemMcCafe.txt")
        Do While File.Peek <> -1
            lstKopiSusu.Items.Add(File.ReadLine)
        Loop
        File.Close()
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        Dim Total As Double = 0
        For I As Integer = 0 To lstKopiSusu.Items.Count - 1
            Total = Total + Val(Microsoft.VisualBasic.Right(lstKopiSusu.Items(I), 4))
        Next
        lblResult.Text = "The total market share is " & Total & " %"
    End Sub
End Class
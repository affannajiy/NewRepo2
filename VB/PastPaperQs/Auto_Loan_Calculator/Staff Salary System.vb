'Credit to Mahendra
Public Class Staff_Salary_System
    'Calculate Button
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lblNewSalary.Text = "RM " & Format(txtCurrentSalary.Text * 1.04, "0.00")
    End Sub

    'Save Button
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim File = New System.IO.StreamWriter("C:\Users\user\Desktop\Visual Studio\PastPaperQs\salary.txt", True)
        File.WriteLine(txtID.Text & vbTab & txtName.Text & vbTab & lblNewSalary.Text)
        File.Close()
    End Sub

    'Show Button
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim File As System.IO.StreamReader
        Dim Data As String
        File = New System.IO.StreamReader("C:\Users\user\Desktop\Visual Studio\PastPaperQs\salary.txt")
        Do Until File.Peek = -1
            Data = File.ReadLine
            lstInfo.Items.Add(Data)
        Loop
    End Sub
End Class
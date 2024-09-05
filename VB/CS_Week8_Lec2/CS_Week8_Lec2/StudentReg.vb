Public Class StudentReg
    Dim inFile As System.IO.StreamWriter

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        inFile = New System.IO.StreamWriter("C:\Users\user\source\repos\Student.txt", True)

        inFile.WriteLine(txtName.Text & " , " & txtID.Text & " , " & cmbxProgram.Text)

        inFile.Close()
    End Sub

    Dim outFile As System.IO.StreamReader
    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        outFile = New System.IO.StreamReader("C:\Users\user\source\repos\Student.txt")

        lstStudent.Items.Clear()
        Do While outFile.Peek <> -1 'selagi dia tak -1 selagi tu dia running
            lstStudent.Items.Add(outFile.ReadLine)
        Loop

        outFile.Close()
    End Sub
End Class

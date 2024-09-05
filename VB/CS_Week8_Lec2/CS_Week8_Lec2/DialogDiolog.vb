Imports System.IO

Public Class DialogDiolog
    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dim MemoFile As System.IO.StreamReader

        OpenFileDialog1.Title = "Open"
        OpenFileDialog1.Filter = "Text File (*.txt)|*.txt"
        OpenFileDialog1.ShowDialog()
        MemoFile = New StreamReader(OpenFileDialog1.FileName)

        txtMemo.Text = MemoFile.ReadToEnd
        MemoFile.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim MemoFile As System.IO.StreamWriter
        SaveFileDialog1.Title = "Save As"
        SaveFileDialog1.Filter = "Text File (*.txt)|*.txt"
        SaveFileDialog1.FileName = "Text1"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            MemoFile = New StreamWriter(SaveFileDialog1.FileName, OpenMode.Output)
            MemoFile.Write(txtEditor.Text)
            MemoFile.Close()
            MsgBox("File Saved LOLS!")
        End If
    End Sub
End Class
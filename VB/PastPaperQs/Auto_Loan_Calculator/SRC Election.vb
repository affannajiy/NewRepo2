'Credit to Mahendra
Public Class SRC_Election
    Dim voteCount(2, 4) As Integer
    Dim totalvote(2) As Integer
    Dim candidateName(2) As String

    'Enter Data Button
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim row, column As Integer
        For row = 0 To 2
            For column = 0 To 4
                voteCount(row, column) = Val(InputBox("Enter votes for " & candidateName(row) & " for village " & column + 1, "SRC Selection System"))
            Next
        Next
    End Sub

    'Form Load
    Private Sub SRC_Election_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        candidateName(0) = "Bryan"
        candidateName(1) = "Rudy"
        candidateName(2) = "Jessica"
    End Sub

    'Check Button
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim row, column As Integer
        For row = 0 To 2
            For column = 0 To 4
                totalvote(row) += voteCount(row, column)
            Next
        Next

        Call funcWinner(totalvote)
    End Sub

    Private Sub funcWinner(totalVotes() As Integer)
        Dim winnerIndex As Integer = 0
        For i = 1 To UBound(totalVotes)
            If totalVotes(i) > totalVotes(winnerIndex) Then
                winnerIndex = i 'Update winner index if candidiate has more votes
            End If
        Next

        'Display or use the winner information
        Dim winnerName As String = candidateName(winnerIndex)
        MessageBox.Show("The winner is: " & winnerName & " with " & totalVotes(winnerIndex) & " votes.", "SRC Election System")
    End Sub
End Class
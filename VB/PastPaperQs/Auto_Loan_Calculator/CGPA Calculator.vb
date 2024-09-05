Imports System.Reflection.Emit
'Credit to Ikhwan
Public Class CGPA_Calculator
    Dim strGrade As String
    Dim dblGradePoint As Double
    Dim dblPointEarned As Double

    'Add List Button
    Private Sub btnAddList_Click(sender As Object, e As EventArgs) Handles btnAddList.Click
        Dim strSubjectName As String

        strSubjectName = UCase(InputBox("What Is The Name Of The Subject?", "TO THE USER"))
        lstSubject.Items.Add(strSubjectName)

    End Sub

    'Add Subject
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim strSubjectRegistered As String

        strSubjectRegistered = lstSubject.SelectedItem
        lstSubjectTaken.Items.Add(strSubjectRegistered)

        strGrade = InputBox("What is your grade for " & strSubjectRegistered & "?", "TO THE USER")
        lstGrade.Items.Add(strGrade)

        Dim intCreditHour As Integer
        intCreditHour = CInt(InputBox("What is the credit hour for " & strSubjectRegistered & " subject?", "TO THE USER"))
        lstCredit.Items.Add(CStr(intCreditHour))

        dblGradePoint = gradepoint(strGrade)
        dblPointEarned = dblGradePoint * intCreditHour
        lstPoint.Items.Add(dblPointEarned)
    End Sub

    'Grading Point Function Calling
    Private Function gradepoint(ByVal strGrade As String) As Double
        If strGrade = "A" Then
            dblGradePoint = 4.0
        ElseIf strGrade = "A-" Then
            dblGradePoint = 3.75
        ElseIf strGrade = "B+" Then
            dblGradePoint = 3.5
        ElseIf strGrade = "B" Then
            dblGradePoint = 3.0
        ElseIf strGrade = "C+" Then
            dblGradePoint = 2.5
        ElseIf strGrade = "C" Then
            dblGradePoint = 2.0
        ElseIf strGrade = "D+" Then
            dblGradePoint = 1.5
        ElseIf strGrade = "D" Then
            dblGradePoint = 1.0
        ElseIf strGrade = "F" Then
            dblGradePoint = 0.00
        End If
        Return dblGradePoint
    End Function

    'Calculate Button
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim I As Integer = 0
        Dim J As Integer = 0
        Dim CGPA, TotalPEarned, TotalCreditHour As Double

        CGPA = 0
        TotalPEarned = 0
        TotalCreditHour = 0

        Do While I < lstCredit.Items.Count
            TotalCreditHour = TotalCreditHour + CInt(lstCredit.Items(I))
            I = I + 1
        Loop

        Do While J < lstPoint.Items.Count
            TotalPEarned = TotalPEarned + CDbl(lstPoint.Items(J))
            J = J + 1
        Loop

        CGPA = TotalPEarned / TotalCreditHour
        lblCGPA.Text = CStr(FormatNumber(CGPA))
    End Sub

    'Exit Button
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
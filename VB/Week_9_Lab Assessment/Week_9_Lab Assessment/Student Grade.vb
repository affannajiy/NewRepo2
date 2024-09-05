Public Class frmStudentGrade
    Dim studentgrades() As Double

    'App Load
    Private Sub frmStudentGrade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TcName As String
        TcName = InputBox("Please input teacher's name")
        lblTcName.Text = "Welcome Sir/Madam/Miss " & TcName
    End Sub

    'Button Enter
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        txtStudentNumber.Text = Val(txtStudentNumber.Text)
        If txtStudentNumber.Text <> "" Then
            If txtStudentNumber.Text <> "0" Then
                Call InputGrade()
            Else
                Call Errors()
            End If
        Else
            Call Errors()
        End If
    End Sub

    'Input Sub
    Sub InputGrade()
        Dim student As Integer = CInt(txtStudentNumber.Text)
        ReDim Preserve studentgrades(student - 1)
        Dim Z As Integer = 0
        Do 'Looping
            studentgrades(Z) = InputBox("Please input student " & Z + 1 & "'s grade", "Student's Grade")
            Z += 1
        Loop Until Z = student
    End Sub

    'Error Sub
    Sub Errors()
        MsgBox("Please input a valid value!", MsgBoxStyle.Critical, "Error!")
    End Sub

    'Average Button
    Private Sub btnCalcAvg_Click(sender As Object, e As EventArgs) Handles btnCalcAvg.Click
        txtGradeAvg.Text = Average(CInt(txtStudentNumber.Text))
    End Sub

    'Average Function
    Private Function Average(ByVal student As Integer)
        Dim Sum, Avg As Double
        For Z = 0 To student - 1
            Sum += studentgrades(Z)
        Next
        Avg = Sum / student
        Return (Avg)
    End Function

    'High Button
    Private Sub btnGradeHigh_Click(sender As Object, e As EventArgs) Handles btnGradeHigh.Click
        txtGradeHigh.Text = HighGrade()
    End Sub

    'High Function
    Private Function HighGrade()
        Dim maximum As Double = studentgrades.Max
        Return (maximum)
    End Function

    'Low Button
    Private Sub btnGradeLow_Click(sender As Object, e As EventArgs) Handles btnGradeLow.Click
        txtGradeLow.Text = LowGrade()
    End Sub

    'Low Function
    Private Function LowGrade()
        Dim minimum As Double = studentgrades.Min
        Return (minimum)
    End Function

    'Exit Button
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim result As MsgBoxResult = MsgBox("Close application?", MsgBoxStyle.YesNo, "Closing")
        If result = MsgBoxResult.Yes Then
            Me.Close()
        Else
        End If
    End Sub
End Class
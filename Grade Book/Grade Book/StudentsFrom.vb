Public Class StudentsFrom

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        For i As Integer = 0 To 4
            studentNames(i) = InputBox("Enter Student Name:")
        Next
        For i As Integer = 0 To 4
            lstStudents.Items.Add(studentNames(i))
        Next
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim index As Integer
        If Not lstStudents.SelectedIndex < 0 Then
            index = lstStudents.SelectedIndex
            studentNames(index) = InputBox("Enter Student Name:")

            lstStudents.Items.Clear()

            For i As Integer = 0 To 4
                lstStudents.Items.Add(studentNames(i))
            Next
        Else
            MsgBox("You didn't select a student.")
        End If
    End Sub

    Private Sub btnScores_Click(sender As Object, e As EventArgs) Handles btnScores.Click
        If Not lstStudents.SelectedIndex < 0 Then
            Dim index As Integer
            index = lstStudents.SelectedIndex
            For i As Integer = 0 To 3
                testScores(index, i) = Val(InputBox("Enter Test Score:"))
            Next
        Else
            MsgBox("You didn't select a student.")
        End If
    End Sub

    Private Sub btnGrade_Click(sender As Object, e As EventArgs) Handles btnGrade.Click
        getAverage()
        assignLetterGrade()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim frmOutput As New OutPutForm
        frmOutput.Show()
        For i As Integer = 0 To 4
            frmOutput.RichTextBox1.AppendText(studentNames(i) & " Average: " & testAverages(i) & " Final Grade: " & testLetters(i) & vbNewLine)
        Next
    End Sub
End Class
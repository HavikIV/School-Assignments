Module Module1
    Public studentNames(4), testLetters(4) As String
    Public testScores(4, 3), testAverages(4) As Integer

    Sub dropLowestScore()
        Dim lowest As Integer
        Dim x, y As Integer
        For i As Integer = 0 To 4
            lowest = testScores(i, 0)
            x = i
            y = 0
            For j As Integer = 0 To 3
                If testScores(i, j) < lowest Then
                    lowest = testScores(i, j)
                    y = j
                End If
            Next
            testScores(x, y) = 0
        Next
    End Sub

    Sub getAverage()
        Dim average As Integer
        dropLowestScore()
        For i As Integer = 0 To 4
            average = 0
            For j As Integer = 0 To 3
                average += testScores(i, j)
                testAverages(i) = average / 3
            Next
        Next
    End Sub

    Sub assignLetterGrade()
        For i As Integer = 0 To 4
            If testAverages(i) >= 90 Then
                testLetters(i) = "A"
            ElseIf testAverages(i) >= 80 And testAverages(i) < 90 Then
                testLetters(i) = "B"
            ElseIf testAverages(i) >= 70 And testAverages(i) < 80 Then
                testLetters(i) = "C"
            ElseIf testAverages(i) >= 60 And testAverages(i) < 70 Then
                testLetters(i) = "D"
            Else
                testLetters(i) = "F"
            End If
        Next
    End Sub
End Module

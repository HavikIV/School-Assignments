Public Class Midterm

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstTestScores.Items.Clear()
        txtTestScore.Clear()
        txtTestScore.Focus()
        lblSum2.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        Dim Sum As Integer
        
        For Each item As String In lstTestScores.Items
            Sum += CInt(item)
        Next

        lblSum2.Text = Sum
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Score As String
        Score = txtTestScore.Text
        If IsNumeric(Score) Then
            If Score < 0 Then
                lstTestScores.Items.Add(0)
            ElseIf Score > 100 Then
                lstTestScores.Items.Add(100)
            Else
                lstTestScores.Items.Add(Score)
            End If
        Else
            lstTestScores.Items.Add(0)
        End If

        txtTestScore.Clear()
        txtTestScore.Focus()

    End Sub
End Class

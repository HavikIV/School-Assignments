Public Class MathTutor

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim x, y, Answer As Integer

        x = lblX.Text
        y = lblY.Text

        Answer = x + y

        lblAnswer.Text = Answer

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnRandomize_Click(sender As Object, e As EventArgs) Handles btnRandomize.Click
        Dim x, y As Integer

        x = (100 * Rnd())
        y = (100 * Rnd())

        lblX.Text = x
        lblY.Text = y

    End Sub
End Class

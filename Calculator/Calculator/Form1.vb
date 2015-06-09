Public Class Calculator
    Dim x As Double = 0
    Dim answer As Double = 0

    Private Sub btnAddition_Click(sender As Object, e As EventArgs) Handles btnAddition.Click
        x = Val(txtNumbers.Text)
        txtNumbers.Text = ""

        answer = answer + x

        lblAnswer.Text = answer
        txtNumbers.Focus()

    End Sub

    Private Sub btnSubtraction_Click(sender As Object, e As EventArgs) Handles btnSubtraction.Click
        x = Val(txtNumbers.Text)
        txtNumbers.Text = ""

        answer = answer - x

        lblAnswer.Text = answer
        txtNumbers.Focus()

    End Sub

    Private Sub btnMultiplication_Click(sender As Object, e As EventArgs) Handles btnMultiplication.Click
        x = Val(txtNumbers.Text)
        txtNumbers.Text = ""

        answer = answer * x

        lblAnswer.Text = answer
        txtNumbers.Focus()

    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        x = Val(txtNumbers.Text)
        txtNumbers.Text = ""

        answer = answer / x

        lblAnswer.Text = answer
        txtNumbers.Focus()

    End Sub
End Class

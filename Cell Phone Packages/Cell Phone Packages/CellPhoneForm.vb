Public Class CellPhoneForm

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnIndividual_Click(sender As Object, e As EventArgs) Handles btnIndividual.Click
        Dim frmIndividual As New IndividualForm
        frmIndividual.ShowDialog()
    End Sub

    Private Sub btnFamily_Click(sender As Object, e As EventArgs) Handles btnFamily.Click
        Dim frmFamily As New FamilyForm
        frmFamily.ShowDialog()
    End Sub
End Class

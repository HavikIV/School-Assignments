Public Class EnterForm

    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        storeString = txtString.Text
        Me.Close()
    End Sub
End Class
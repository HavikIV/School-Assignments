Public Class CarpetSize

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim Length, Width, Area As Double

        Length = txtLength.Text
        Width = txtWidth.Text

        Area = Length * Width

        lblArea.Text = Area & " Sq. Ft"

    End Sub
End Class

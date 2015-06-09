Public Class MetricConversion

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click

        Const poundsPerKilo As Single = 2.2
        Const centiPerInch As Single = 2.54

        Dim Kilos, Centi, Feet, Inches As Integer

        Kilos = txtKilos.Text
        Centi = txtCenti.Text

        Feet = ((Centi / centiPerInch) / 12)
        Inches = ((Centi / centiPerInch) Mod 12)

        lblPoundResult.Text = Kilos * poundsPerKilo
        lblFeetResult.Text = Feet
        lblInchesResults.Text = Inches

    End Sub
End Class

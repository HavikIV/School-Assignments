Option Explicit On
Option Strict On
Option Infer Off

Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim Fahren, Celsius As Double
        Double.TryParse(TextBox1.Text, Fahren)
        Celsius = ((Fahren - 32) * 5) / 9
        lblCelsius.Text = Celsius.ToString("N2") + " Celisus"
    End Sub
End Class
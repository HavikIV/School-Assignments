Public Class ChangeMaker

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim change As Integer = txtChange.Text
        Dim Dollars, Quarters, Dimes, Nickels, Pennies As Integer

        Dollars = change \ 100

        Quarters = (change Mod 100) \ 25
        Dimes = ((change Mod 100) Mod 25) \ 10
        Nickels = (((change Mod 100) Mod 25) Mod 10) \ 5
        Pennies = ((((change Mod 100) Mod 25) Mod 10) Mod 5)

        lblDollarChange.Text = Dollars
        lblQuartersChange.Text = Quarters
        lblDimesChange.Text = Dimes
        lblNickelsChange.Text = Nickels
        lblPenniesChange.Text = Pennies

    End Sub
End Class

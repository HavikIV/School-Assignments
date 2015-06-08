Public Class TheaterRevenue
    Const NetPercentage As Decimal = 0.2

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim Adult, Child As Decimal
        Dim NetAdult, NetChild As Decimal

        If Val(txtAdultPrice.Text) = 0 Then
            lblError.Text = "Error: Please enter the price of an adult ticket."
            txtAdultPrice.Focus()
        ElseIf Val(txtAdultSold.Text) = 0 Then
            lblError.Text = "Error: Please enter the amount of adult tickets sold."
            txtAdultSold.Focus()
        ElseIf Val(txtChildPrice.Text) = 0 Then
            lblError.Text = "Error: Please enter the price of an child ticket."
            txtChildPrice.Focus()
        ElseIf Val(txtChildSold.Text) = 0 Then
            lblError.Text = "Error: Please enter the amount of child tickets sold."
            txtChildSold.Focus()
        Else
            Adult = (Val(txtAdultPrice.Text) * Val(txtAdultSold.Text))
            Child = (Val(txtChildPrice.Text) * Val(txtChildSold.Text))

            lblAdultSales2.Text = "$" & FormatNumber(Adult)
            lblChildSales2.Text = "$" & FormatNumber(Child)
            lblTotalSales2.Text = "$" & FormatNumber((Adult + Child))

            NetAdult = Adult * NetPercentage
            NetChild = Child * NetPercentage

            lblNetAdult2.Text = "$" & FormatNumber(NetAdult)
            lblNetChild2.Text = "$" & FormatNumber(NetChild)
            lblNetTotal2.Text = "$" & FormatNumber((NetAdult + NetChild))
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAdultPrice.Clear()
        txtAdultSold.Clear()
        txtChildPrice.Clear()
        txtChildSold.Clear()
        lblAdultSales2.Text = ""
        lblChildSales2.Text = ""
        lblTotalSales2.Text = ""
        lblNetAdult2.Text = ""
        lblNetChild2.Text = ""
        lblNetTotal2.Text = ""
        lblError.Text = ""
        txtAdultPrice.Focus()
    End Sub
End Class

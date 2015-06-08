Public Class FamilyForm

    Sub phoneCharge()
        Dim noPhones As Integer
        noPhones = Val(txtPhones.Text)
        If rdbM100.Checked Then
            phone = 29.95
        ElseIf rdbM110.Checked Then
            phone = 49.95
        ElseIf rdb200.Checked Then
            phone = 99.95
        End If

        If Not noPhones = 0 Then
            phone = phone * noPhones
        End If
    End Sub

    Sub packageCharge()
        If rdb800Minutes.Checked Then
            package = 45.0
        ElseIf rdb1500Minutes.Checked Then
            package = 65.0
        ElseIf rdbUnlimted.Checked Then
            package = 99.0
        End If
    End Sub

    Sub optionCharge()
        options = 0
        If cbxEmail.Checked Then
            options += 25.0
        End If
        If cbxText.Checked Then
            options += 10.0
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        phoneCharge()
        packageCharge()
        optionCharge()
        phoneTax()
        monthlyCharge()
        lblSubtotal.Text = "$" & FormatNumber(phone)
        lblTax.Text = "$" & FormatNumber(tax)
        lblTotal.Text = "$" & FormatNumber((phone + tax))
        lblOptions.Text = "$" & FormatNumber(options)
        lblPackCharge.Text = "$" & FormatNumber(package)
        lblMonthlyCharge.Text = "$" & FormatNumber(total)
    End Sub
End Class
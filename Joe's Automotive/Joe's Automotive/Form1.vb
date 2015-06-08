Public Class Joe
    Sub clearOther()
        txtParts.Clear()
        txtLabor.Clear()
    End Sub

    Sub ClearFees()
        lblServicesTotal.Text = ""
        lblPartsTotal.Text = ""
        lblTaxTotal.Text = ""
        lblTotalFees.Text = ""
    End Sub

    Sub ClearMisc()
        cbxInspection.Checked = False
        cbxReplace.Checked = False
        cbxRotation.Checked = False
    End Sub

    Sub ClearFlushes()
        cbxRadiator.Checked = False
        cbxTransmission.Checked = False
    End Sub

    Sub ClearOilLube()
        cbxOil.Checked = False
        cbxLube.Checked = False
    End Sub

    Function OilLubeCharges() As Decimal
        Dim total As Decimal
        If cbxOil.Checked Then
            total += 26
        End If
        If cbxLube.Checked Then
            total += 18
        End If
        Return total
    End Function

    Function FlushCharges() As Decimal
        Dim total As Decimal
        If cbxRadiator.Checked Then
            total += 30
        End If
        If cbxTransmission.Checked Then
            total += 80
        End If
        Return total
    End Function

    Function MiscCharges() As Decimal
        Dim total As Decimal
        If cbxInspection.Checked Then
            total += 15
        End If
        If cbxReplace.Checked Then
            total += 100
        End If
        If cbxRotation.Checked Then
            total += 20
        End If
        Return total
    End Function

    Function OtherCharges() As Decimal
        Dim total, parts, labor As Decimal
        parts = Val(txtParts.Text)
        labor = Val(txtLabor.Text)
        If labor > 0 Then
            total += (labor * 20)
        End If
        total += parts
        Return total
    End Function

    Function TaxCharges() As Decimal
        Dim total, parts As Decimal
        parts = Val(txtParts.Text)
        If parts > 0 Then
            total = parts * 0.06
        End If
        Return total
    End Function

    Function TotalCharges() As Decimal
        Dim total As Decimal
        
        total = OilLubeCharges() + FlushCharges() + MiscCharges() + OtherCharges() + TaxCharges()

        Return total
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFees()
        ClearFlushes()
        ClearMisc()
        ClearOilLube()
        clearOther()
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        Dim services As Decimal
        If Val(txtParts.Text) < 0 Then
            MessageBox.Show("The amount has to be a number greater than or equal to 0")
            txtParts.Focus()
        ElseIf Val(txtLabor.Text) < 0 Then
            MessageBox.Show("The amount has to be a number greater than or equal to 0")
            txtLabor.Focus()
        Else
            services = OilLubeCharges() + FlushCharges() + MiscCharges() + (Val(txtLabor.Text) * 20)
            lblServicesTotal.Text = "$" & FormatNumber(services)
            lblPartsTotal.Text = "$" & FormatNumber(Val(txtParts.Text))
            lblTaxTotal.Text = "$" & FormatNumber(TaxCharges())
            lblTotalFees.Text = "$" & FormatNumber(TotalCharges())
        End If
    End Sub
End Class

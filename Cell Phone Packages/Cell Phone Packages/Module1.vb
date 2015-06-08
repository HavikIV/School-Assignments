Module Module1
    Public phone, package, options, tax, total As Decimal

    Sub phoneTax()
        tax = phone * 0.06
    End Sub

    Sub monthlyCharge()
        total = phone + tax + package + options
    End Sub
End Module

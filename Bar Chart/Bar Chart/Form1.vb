Public Class Sales

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnChart_Click(sender As Object, e As EventArgs) Handles btnChart.Click
        Dim Sales1, Sales2, Sales3, Sales4, Sales5 As Integer
        Dim Bar1, Bar2, Bar3, Bar4, Bar5 As Integer
        Sales1 = Val(txtStore1.Text)
        Sales2 = Val(txtStore2.Text)
        Sales3 = Val(txtStore3.Text)
        Sales4 = Val(txtStore4.Text)
        Sales5 = Val(txtStore5.Text)

        lbxChart.Visible = True

        Bar1 = Sales1 \ 100
        Bar2 = Sales2 \ 100
        Bar3 = Sales3 \ 100
        Bar4 = Sales4 \ 100
        Bar5 = Sales5 \ 100

        lbxChart.Items.Add("Store 1: " & New String("*", Bar1))
        lbxChart.Items.Add("Store 2: " & New String("*", Bar2))
        lbxChart.Items.Add("Store 3: " & New String("*", Bar3))
        lbxChart.Items.Add("Store 4: " & New String("*", Bar4))
        lbxChart.Items.Add("Store 5: " & New String("*", Bar5))
    End Sub
End Class

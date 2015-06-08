Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim fence As Rectangle
        Dim len, width, sod As Double

        Double.TryParse(txtLength.Text, len)
        Double.TryParse(txtWidth.Text, width)
        Double.TryParse(txtSod.Text, sod)

        fence = New Rectangle(len, width)
        lblTotal.Text = (fence.GetPerimeter * sod).ToString("C2")
    End Sub
End Class

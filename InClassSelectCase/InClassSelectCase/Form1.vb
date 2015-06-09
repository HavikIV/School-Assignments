Public Class Weather

    Private Sub btnReply_Click(sender As Object, e As EventArgs) Handles btnReply.Click
        Dim weather As Short

        weather = txtTemperture.Text

        Select Case weather
            Case Is <= 50
                lblReply.Text = "Freezing"
            Case 50 To 60
                lblReply.Text = "Cold"
            Case 61 To 70
                lblReply.Text = "Cool"
            Case 71 To 80
                lblReply.Text = "Warm"
            Case 81 To 90
                lblReply.Text = "Hot"
            Case 91 To 100
                lblReply.Text = "Blazing Hot!"
            Case Is >= 100
                lblReply.Text = "WHY GOD, WHY?!"
        End Select

    End Sub
End Class

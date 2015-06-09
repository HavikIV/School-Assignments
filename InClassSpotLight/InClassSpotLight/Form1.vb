Public Class Spotlight

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim Checked As Boolean

        Checked = cbPolice.Checked

        If rbRedLight.Checked Then
            lblAdviceResult.Text = "Stop the car."
        ElseIf rbYellowLight.Checked Then
            If Checked Then
                lblAdviceResult.Text = "Stop the car."
            Else
                lblAdviceResult.Text = "Speed up and go through the light."
            End If
        ElseIf rbGreenLight.Checked Then
            lblAdviceResult.Text = "Drive normally."
        End If

    End Sub
End Class

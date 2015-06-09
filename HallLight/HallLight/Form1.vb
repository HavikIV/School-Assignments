Public Class HallLights

    Private Sub btnSwitch1_Click(sender As Object, e As EventArgs) Handles btnSwitch1.Click
        If btnSwitch1.Text = "ON" Then
            btnSwitch1.Text = "OFF"
        Else
            btnSwitch1.Text = "ON"
        End If

        If btnSwitch1.Text <> btnSwitch2.Text Then
            pbOn.Visible = True
            pbOff.Visible = False
        Else
            pbOn.Visible = False
            pbOff.Visible = True
        End If

    End Sub

    Private Sub btnSwitch2_Click(sender As Object, e As EventArgs) Handles btnSwitch2.Click
        If btnSwitch2.Text = "ON" Then
            btnSwitch2.Text = "OFF"
        Else
            btnSwitch2.Text = "ON"
        End If

        If btnSwitch1.Text <> btnSwitch2.Text Then
            pbOn.Visible = True
            pbOff.Visible = False
        Else
            pbOn.Visible = False
            pbOff.Visible = True
        End If

    End Sub
End Class


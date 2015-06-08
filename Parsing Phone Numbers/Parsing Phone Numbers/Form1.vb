Public Class Phone

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim Number, Phone As String
        Number = txtNumber.Text

        If Number.Length < 10 Then
            MessageBox.Show("Number Too Short or Is not a Number")
            txtNumber.Clear()
            txtNumber.Focus()
        Else
            For count As Integer = 0 To Number.Length - 1

                If IsNumeric(Number(count)) Then
                    Phone += Number(count)

                End If
            Next count

            If Phone.Length < 10 Then
                MessageBox.Show("Number Too Short")
                txtNumber.Clear()
                txtNumber.Focus()
            ElseIf Phone.Length > 10 Then
                MessageBox.Show("Number to Big to be Phone Number")
                txtNumber.Clear()
                txtNumber.Focus()
            End If

            lblPhoneNumber.Text = "(" & Phone.Substring(0, 3) & ") " & Phone.Substring(3, 3) & "-" & Phone.Substring(6, 4)
        End If
    End Sub
End Class

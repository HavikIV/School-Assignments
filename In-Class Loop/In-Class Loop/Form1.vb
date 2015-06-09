Public Class Multi

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        rtbMulti.Clear()
        txtNumber.Clear()
        lblError.Text = ""
        txtNumber.Focus()
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim number, x, y As Integer
        'Dim Space As String
        If Val(txtNumber.Text) <= 0 Or Val(txtNumber.Text) > 12 Then
            lblError.Text = "Error: Please Enter A Valid Number Between 1-12."
            txtNumber.Focus()
        Else
            number = txtNumber.Text

            For x = 1 To number
                For y = 1 To number
                    rtbMulti.AppendText(x * y & " ")
                Next y
                rtbMulti.AppendText(vbNewLine)
            Next x
        End If

        'number = txtNumber.Text
        'x = 1
        'While x <= number
        '    For y = 1 To number
        '        If x * y < 10 Then
        '            Space = "   "
        '        ElseIf x * y >= 10 Then
        '            Space = "  "
        '        Else
        '            Space = " "
        '        End If
        '        rtbMulti.AppendText(x * y & Space)
        '    Next y
        '    rtbMulti.AppendText(vbNewLine)
        '    x += 1
        'End While

        txtNumber.Focus()

    End Sub
End Class

Public Class strings

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim inputString, outputString As String
        inputString = txtInput.Text

        For Each ch As Char In inputString
            If Not IsNumeric(ch) And Convert.ToInt64(ch) > 64 And Not Convert.ToInt64(ch) > 91 And Convert.ToInt64(ch) > 96 And Not Convert.ToInt64(ch) > 123 Then
                outputString += ch
            End If
        Next

        lblOutput.Text = outputString

    End Sub
End Class

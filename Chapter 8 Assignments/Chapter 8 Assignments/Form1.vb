Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strAddress As String = "1354 Jefferson Street City, State, ZIPCODE"
        Dim blnIsContained As Boolean
        If strAddress.ToUpper.Contains("Jefferson Street".ToUpper) Or strAddress.ToLower.Contains("Jefferson Street".ToLower) Then
            blnIsContained = True
            MessageBox.Show("strAddress contains Jefferson Street.", "Address Check")
        Else
            blnIsContained = False
            MessageBox.Show("strAddress does not contains Jefferson Street.", "Address Check")
        End If
    End Sub
End Class

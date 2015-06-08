Public Class Form1
    Private Structure MyFriend
        Public strLast As String
        Public strFirst As String
    End Structure

    Private Sub btnGO_Click(sender As Object, e As EventArgs) Handles btnGO.Click
        Dim school As New MyFriend
        school.strFirst = txtFirst.Text
        school.strLast = txtLast.Text

        lblFirst.Text = school.strFirst
        lblLast.Text = school.strLast

    End Sub
End Class

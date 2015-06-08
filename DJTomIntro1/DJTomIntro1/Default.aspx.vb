' Name:         DJTom-Preview
' Purpose:      Display a message
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' displays the user’s input in a message

        Dim strBride As String
        Dim strGroom As String
        Dim strWedDate As String
        Dim strEmail As String
        Dim strSong As String

        strBride = txtBride.Text.Trim
        strGroom = txtGroom.Text.Trim
        strWedDate = calWedding.SelectedDate.ToShortDateString
        strEmail = txtEmail.Text.Trim
        strSong = ddlSongs.SelectedItem.ToString

        lblMsg.Text = "Thank you " & strBride & " and " &
            strGroom & " for visiting my Web site. " &
            "<br /><br />Wedding date: " & strWedDate &
            "<br />E-mail address: " & strEmail &
            "<br />Song: " & strSong

    End Sub
End Class

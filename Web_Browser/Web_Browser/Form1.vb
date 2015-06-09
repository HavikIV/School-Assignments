Public Class Form1

    Private Sub btnGO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGO.Click
        WebBrowser1.Navigate(txtWebAddress.Text)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtWebAddress.Text = "www.google.com"
        WebBrowser1.Navigate(txtWebAddress.Text)
    End Sub

    Private Sub btnGoBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoBack.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub btnHomepage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHomepage.Click
        txtWebAddress.Text = "www.google.com"
        WebBrowser1.Navigate("google.com")
    End Sub

    Private Sub btnGoForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoForward.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        WebBrowser1.Refresh()
        txtWebAddress.Text = WebBrowser1.Url.OriginalString()
    End Sub
End Class

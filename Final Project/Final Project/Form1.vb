Public Class Form1

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frmEnter As New EnterForm
        frmEnter.ShowDialog()
    End Sub

    Private Sub btnFormat_Click(sender As Object, e As EventArgs) Handles btnFormat.Click
        stringFormat()
        ListBox1.Items.Add(storeString)
    End Sub

    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
        ListBox1.Items.Add(storeString)
    End Sub
End Class

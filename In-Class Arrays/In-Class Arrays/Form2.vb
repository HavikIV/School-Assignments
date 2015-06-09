Public Class Form2

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim item As Integer
        item = Val(txtEnter.Text)
        ListBox1.Items.Add(item)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        count = ListBox1.Items.Count
        For i As Integer = 0 To count - 1
            Data(i) = ListBox1.Items(i)
        Next
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        For i As Integer = 0 To count - 1
            ListBox1.Items.Add(Data(i))
        Next
    End Sub
End Class
Public Class Form1
    'Dim frmSecond As New Form2
    'Dim Data As Integer
    'Dim w As IO.StreamWriter
    'Dim r As IO.StreamReader

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim frmSecond As New Form2
        frmSecond.Show()
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
        'w = New IO.StreamWriter("C:\Users\HellRasier\Documents\Visual Studio 2012\Projects\In-Class Arrays\In-Class Arrays\test.txt")
        'For Data = 0 To ListBox1.Items.Count - 1
        'w.WriteLine(ListBox1.Items.Item(Data))
        'Next
        'w.Close()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        For i As Integer = 0 To count - 1
            ListBox1.Items.Add(Data(i))
        Next
        'r = New IO.StreamReader("C:\Users\HellRasier\Documents\Visual Studio 2012\Projects\In-Class Arrays\In-Class Arrays\test.txt")
        'While (r.Peek() > -1)
        'frmSecond.ListBox1.Items.Add(r.ReadLine)
        'End While
        'r.Close()
    End Sub
End Class

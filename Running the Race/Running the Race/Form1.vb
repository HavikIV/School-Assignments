Public Class Race

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName1.Clear()
        txtName2.Clear()
        txtName3.Clear()
        txtFinishTime1.Clear()
        txtFinishTime2.Clear()
        txtFinishTime3.Clear()
        lbl1stPlace.Text = ""
        lbl2ndPlace.Text = ""
        lbl3rdPlace.Text = ""
    End Sub

    Private Sub btnResults_Click(sender As Object, e As EventArgs) Handles btnResults.Click
        Dim Time1, Time2, Time3 As Integer
        Dim First, Second, Third As String

        Time1 = Val(txtFinishTime1.Text)
        Time2 = Val(txtFinishTime2.Text)
        Time3 = Val(txtFinishTime3.Text)

        If Time1 < Time2 And Time1 < Time3 Then
            First = txtName1.Text
            If Time2 < Time3 Then
                Second = txtName2.Text
                Third = txtName3.Text
            Else
                Second = txtName3.Text
                Third = txtName2.Text
            End If
        ElseIf Time2 < Time1 And Time2 < Time3 Then
            First = txtName2.Text
            If Time1 < Time3 Then
                Second = txtName1.Text
                Third = txtName3.Text
            Else
                Second = txtName3.Text
                Third = txtName1.Text
            End If
        ElseIf Time3 < Time1 And Time3 < Time2 Then
            First = txtName3.Text
            If Time1 < Time2 Then
                Second = txtName1.Text
                Third = txtName2.Text
            Else
                Second = txtName2.Text
                Third = txtName1.Text
            End If
        End If

        lbl1stPlace.Text = First
        lbl2ndPlace.Text = Second
        lbl3rdPlace.Text = Third

    End Sub
End Class

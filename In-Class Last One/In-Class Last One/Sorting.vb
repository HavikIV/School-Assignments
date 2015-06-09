Public Class Sorting

    Public Sub sort4(ByRef list() As Integer)
        Dim temp As Integer
        For index As Integer = 0 To 3
            For secondindex As Integer = index + 1 To 3
                If list(index) > list(secondindex) Then
                    temp = list(secondindex)
                    list(secondindex) = list(index)
                    list(index) = temp
                End If
            Next
        Next
    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        Dim list(0 To 3) As Integer

        list(0) = Val(txtNum1.Text)
        list(1) = Val(txtNum2.Text)
        list(2) = Val(txtNum3.Text)
        list(3) = Val(txtNum4.Text)

        sort4(list)
        lblSortedList.Text = list(0) & " " & " " & list(1) & " " & list(2) & " " & list(3)
    End Sub
End Class

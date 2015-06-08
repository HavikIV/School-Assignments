Public Class DuoLists

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lstLeft.Items.Add(txtItem.Text)
        txtItem.Clear()
        txtItem.Focus()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstLeft.Items.Clear()
        lstRight.Items.Clear()
        txtItem.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If lstLeft.SelectedIndex <> -1 Then
            lstLeft.Items.RemoveAt(lstLeft.SelectedIndex)
        End If
    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        If lstLeft.SelectedIndex <> -1 Then
            If lstRight.SelectedIndex = -1 Then
                lstRight.Items.Add(lstLeft.SelectedItem)
                lstLeft.Items.RemoveAt(lstLeft.SelectedIndex)
            Else
                lstRight.Items.Insert(lstRight.SelectedIndex, lstLeft.SelectedItem)
                lstLeft.Items.RemoveAt(lstLeft.SelectedIndex)
                lstRight.SelectedIndex = -1
            End If
        Else
            MessageBox.Show("No Item was selected.")
        End If
    End Sub

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        If lstRight.SelectedIndex <> -1 Then
            If lstLeft.SelectedIndex = -1 Then
                lstLeft.Items.Add(lstRight.SelectedItem)
                lstRight.Items.RemoveAt(lstRight.SelectedIndex)
            Else
                lstLeft.Items.Insert(lstLeft.SelectedIndex, lstRight.SelectedItem)
                lstRight.Items.RemoveAt(lstRight.SelectedIndex)
                lstLeft.SelectedIndex = -1
            End If
        Else
            MessageBox.Show("No Item was selected.")
        End If
    End Sub
End Class

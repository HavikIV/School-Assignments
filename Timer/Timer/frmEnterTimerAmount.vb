Public Class frmEnterTimerAmount

    Private Sub btnSetTime_Click(sender As Object, e As EventArgs) Handles btnSetTime.Click
        Dim mintues As Integer
        Dim user As New Users
        Dim check As Boolean = False 'will be used as an indicator if the user is in the list or not.

        'need to detremine if the entered text is apporiate or not, eg. if it's a number or not
        'code goes here-----------

        '-------------------------
        mintues = Val(TextBox1.Text)

        user.userName = selectedUserName
        user.allowedTime = mintues
        user.lastLoggedInDate = Date.Today

        If userList.Count = 1 Then 'if the list is empty beside the admin, the user will be automatcially added to the list.
            userList.Add(user)
        ElseIf userList.Count > 0 Then ' if the list is not empty, then will check to see if the user is in list so it can be modified instead of being directly added as another entry.
            For i As Integer = 0 To userList.Count - 1
                If userList(i).userName = user.userName Then
                    userList(i).allowedTime = user.allowedTime
                    userList(i).lastLoggedInDate = user.lastLoggedInDate
                    check = True 'indicates that the user was found in the list.
                    Exit For 'to exit the for loop when the user is found in the list.
                End If
            Next
            If Not check Then 'incase the user was not in the list, and the list is not empty, the user will be added to the list.
                userList.Add(user)
            End If
        End If

        saveUserSetting() 'saves the minutes for the sleceted user to the settings file
        Me.Hide() 'will remove the window form sight.
    End Sub
End Class
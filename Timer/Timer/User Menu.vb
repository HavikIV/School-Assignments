Public Class User_Menu

    'Function to get all of the usernames on the computer and adds them to the listbox
    Private Sub User_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ret As New List(Of String)
        ret = GetUsers() 'Calls the function GetUsers()
        'adds the UserNames to the listBox
        For i As Integer = 0 To ret.Count() - 1
            lstbxAllUsers.Items.Add(ret(i))
        Next
    End Sub

    Private Sub btnSetTimer_Click(sender As Object, e As EventArgs) Handles btnSetTimer.Click
        Dim setTimerWindow As New frmEnterTimerAmount

        'need to determine which user the time is being set for
        selectedUserName = lstbxAllUsers.SelectedItem

        If lstbxAllUsers.SelectedIndex > -1 Then
            If My.Settings.AdminUser = "" Then
                MessageBox.Show("Please first select a user to be an admin for the program.")
            Else
                setTimerWindow.Show()
            End If
        Else
            MessageBox.Show("Did not select a User.")
        End If
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Dim user As New Users
        If lstbxAllUsers.SelectedIndex > -1 Then
            user.userName = lstbxAllUsers.SelectedItem
            userList.Add(user)
            My.Settings.AdminUser = userList(0).userName
        Else
            MessageBox.Show("Did not select a User to be set as an Adminstrator.")
        End If
    End Sub

    Private Sub User_Menu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        LoadingScreen.Close()
    End Sub

    Private Sub User_Menu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If My.Settings.AdminUser = "" Then
            e.Cancel = True
            MessageBox.Show("Before closing please select an admin for the program.")
        End If
        My.Settings.Save()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(My.Settings.AdminUser)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.AdminUser = ""
        MessageBox.Show("Remove the admin user.")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim settingFiles As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\Settings"
        If System.IO.File.Exists(settingFiles) Then
            readUserSettings()
            MessageBox.Show(userList(0).ToString)
        Else
            MessageBox.Show("There's no file to read form at the path: " & settingFiles & ".")
        End If
    End Sub
End Class
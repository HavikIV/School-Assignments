Public Class frmRamainingTime
    Private seconds As Integer = 0
    Private minutes As Integer = 0
    Private hour As Integer = 0

    'code to disable the close button
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200 '&H200 = no close button
            Return param
        End Get
    End Property

    Private Sub savingRemainingTime() ' Sub Routine to save the remaining the user has left as long it's more than a minute
        Dim currentUser As String = GetUserName()
        If Not hour = 0 And Not minutes = 0 Then
            For i As Integer = 0 To userList.Count - 1
                If currentUser = userList(i).userName Then
                    userList(i).lastLoggedInDate = Date.Today
                    userList(i).remainingTime = (Val(lblHoursRemaining.Text) * 60) + Val(lblMintuesRemaining.Text)
                    Exit For
                End If
            Next
            saveUserSetting()
        End If
    End Sub

    Private Sub loadTime() ' Sub Routine to get the right time for the user
        'determine which User is logged in to get the right time amount
        Dim currentUser As String = GetUserName()
        For i As Integer = 0 To userList.Count - 1
            If currentUser = userList(i).userName Then
                If userList(i).lastLoggedInDate < Date.Today Then
                    hour = userList(i).allowedTime / 60
                    minutes = userList(i).allowedTime Mod 60
                Else
                    hour = userList(i).remainingTime / 60
                    minutes = userList(i).remainingTime Mod 60
                End If
                Exit For
            End If
        Next
    End Sub

    Private Sub timerseconds_Tick(sender As Object, e As EventArgs) Handles timerseconds.Tick 'the timer tick
        If seconds = 0 And minutes = 0 And hour > 0 Then
            seconds = 60
            minutes = 59
            hour -= 1
        End If
        If seconds = 0 And minutes > 0 Then
            seconds = 60
            minutes -= 1
        End If
        If seconds > 0 Then
            seconds -= 1
            lblSecondsRemaining.Text = seconds
            lblMintuesRemaining.Text = minutes
            lblHoursRemaining.Text = hour
        ElseIf hour = 0 And minutes = 5 Then
            MessageBox.Show("You only have 5 minutes left before the computer is shudown. Please save your work and be ready to be logged off.")
        ElseIf minutes = 0 And seconds = 0 Then
            timerseconds.Stop()
            System.Diagnostics.Process.Start("ShutDown", "/s") 'shuts down the computer when the timer runs out.
            'End
        End If

    End Sub

    Private Sub frmRamainingTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTime() 'gets the time for the user
        'set the time and dispaly in the labels
        lblSecondsRemaining.Text = seconds
        lblMintuesRemaining.Text = minutes
        lblHoursRemaining.Text = hour

        NotifyIcon1.Icon = Me.Icon 'set the NofifyIcon to the forms current Icon
        timerseconds.Start()
    End Sub

    'Function to bring the form to the front when the icon is clicked in the taskbar
    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Show()
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    'function to minimize the form to the taskbar
    Private Sub frmRamainingTime_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
        End If
    End Sub

    Private Sub frmRamainingTime_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        'checks to see what is the cause of closing down the program, cancelling any attempts form the user other than Windows shutting down
        If e.CloseReason = CloseReason.TaskManagerClosing Then
            e.Cancel = True 'cancels the close prompt form the task manager
        ElseIf e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True 'cancels all of the users attempts to close the program
        ElseIf e.CloseReason = CloseReason.WindowsShutDown Then  'runs whenever the program is being closed when Windows is shutting down
            savingRemainingTime()
            e.Cancel = False
        End If
    End Sub
End Class

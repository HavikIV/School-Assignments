Imports System
Imports System.IO
Imports Microsoft.Win32

Public Class LoadingScreen
    Dim count As Integer = 0

    Private Sub LoadingScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim settingFile As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\Settings"
        Dim check As Boolean = False
        Timer1.Start()
        readUserSettings()

        If My.Settings.AdminUser = "" And System.IO.File.Exists(settingFile) Then 'checks to see if the AdminUser is empty but there's a setting file, then it sets the admin user
            My.Settings.AdminUser = userList(0).userName
        ElseIf My.Settings.AdminUser = "" And Not System.IO.File.Exists(settingFile) Then 'checks to see if this is the first the program is run on the computer, it adds the program into the list programs that run at startup
            My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath)
        End If

        If Not CheckingAdmin() And System.IO.File.Exists(settingFile) Then ' determines which window to open depending on if the user is admin or not.
            Dim currentUser As String = GetUserName()
            For i As Integer = 1 To userList.Count - 1
                If userList(i).userName = currentUser Then
                    Dim timerWindow As New frmRamainingTime
                    timerWindow.Show()
                    check = True
                    Exit For
                End If
            Next
            If Not check Then
                End
            End If
        Else
            Dim userWindow As New User_Menu
            userWindow.Show()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        count += 1
        If count = 2 Then
            Timer1.Stop()
            Me.Hide()
        End If
    End Sub
End Class
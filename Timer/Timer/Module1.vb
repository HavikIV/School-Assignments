Imports System
Imports System.IO
Imports Microsoft.Win32
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Runtime.Serialization

Module Module1
    Public selectedUserName As String
    Friend userList As New List(Of Users)
    Dim settingFile As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\Settings"

    'Function to get all of the UserNames from the Rigistry and adds them to a list and returns the list
    Function GetUsers() As List(Of String)
        Dim ret As New List(Of String)
        Dim userskey As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\ProfileList")

        For Each keyname As String In userskey.GetSubKeyNames()
            Using key As RegistryKey = userskey.OpenSubKey(keyname)
                Dim userpath As String = DirectCast(key.GetValue("ProfileImagePath"), String)
                Dim username As String = System.IO.Path.GetFileNameWithoutExtension(userpath)
                'Console.WriteLine("{0}", username)
                ret.Add(username)
            End Using
        Next

        'adding Guest to the list even if there is no Guest account set up
        'If Not ret.Contains("Guest") Then ret.Add("Guest")

        ret.Sort()

        'remove the non-users from the list
        ret.Remove("LocalService")
        ret.Remove("NetworkService")
        ret.Remove("systemprofile")
        ret.Remove("UpdatusUser")
        ret.Remove("UpdatusUser")

        Return ret
    End Function

    Function GetUserName() As String 'Function to get the current User Name, it also checks to see if the program is running in windows or not
        If TypeOf My.User.CurrentPrincipal Is 
          Security.Principal.WindowsPrincipal Then
            ' The application is using Windows authentication.
            ' The name format is DOMAIN\USERNAME.
            Dim parts() As String = Split(My.User.Name, "\")
            Dim username As String = parts(1)
            Return username
        Else
            ' The application is using custom authentication.
            Return My.User.Name
        End If
    End Function

    Function CheckingAdmin() As Boolean ' function to check if the current user is registered as the admin for the program, if there is one.
        Dim currentUser As String
        currentUser = GetUserName()
        If Not currentUser = My.Settings.AdminUser And Not My.Settings.AdminUser = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub saveUserSetting() 'writes the userlist to the settings file using serialization
        If Not System.IO.File.Exists(settingFile) Then 'if the file doesn't exists, then file will be created when writing
            Using fs As New System.IO.FileStream(settingFile, FileMode.Create, FileAccess.Write)
                Dim bf As New BinaryFormatter
                bf.Serialize(fs, userList)
            End Using
        Else 'the file currently exists so the file will only be open to be written upon
            Using fs As New System.IO.FileStream(settingFile, FileMode.Open, FileAccess.Write)
                Dim bf As New BinaryFormatter
                bf.Serialize(fs, userList)
            End Using
        End If
    End Sub

    Public Sub readUserSettings() 'reads the settings form the file into the userlist by deserializing
        If System.IO.File.Exists(settingFile) Then
            Using fs As New System.IO.FileStream(settingFile, FileMode.Open, FileAccess.Read)
                Dim bf As New BinaryFormatter
                userList = bf.Deserialize(fs)
            End Using
        End If
    End Sub

    <Serializable>
    Class Users 'a serializable class with only just properties so that each user can declared as a class and be saved as a list of class objects with individual properites
        Public Property userName As String
        Public Property allowedTime As Integer
        Public Property lastLoggedInDate As String
        Public Property remainingTime As Integer

        Public Overrides Function ToString() As String
            Return String.Format("{0} ({1}, {2}, {3})", userName, allowedTime, lastLoggedInDate, remainingTime)
        End Function
    End Class
End Module

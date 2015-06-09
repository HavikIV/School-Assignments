Public Class HelloWorld

    Private Sub Hello_World_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hello_World.Click
        If Hello_World.Text = "Click Me!" Then
            Hello_World.Text = "Click Me Again!"
        ElseIf Hello_World.Text = "Click Me Again!" Then
            Hello_World.Text = "For the Love of all Things Clickable, CLICK ME AGAIN!"
        ElseIf Hello_World.Text = "For the Love of all Things Clickable, CLICK ME AGAIN!" Then
            lblOutput.Text = "Thanks for clicking me, my good man. Oh before I" & vbNewLine & "forget, Hello World!"
            Hello_World.Text = "Exit"
        ElseIf Hello_World.Text = "Exit" Then
            Close()
        End If
    End Sub

    Private Sub lblOutput_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblOutput.MouseEnter
        lblOutput.Text = "The mouse is over me."
    End Sub

    Private Sub lblOutput_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblOutput.MouseLeave
        lblOutput.Text = "The mouse has left me."
    End Sub

    Private Sub HelloWorld_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        lblOutput.Text = "The form was resized."
    End Sub

    Private Sub HelloWorld_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblOutput.Text = "Thanks for using Manjinder Singh's 1st program" & vbNewLine & "in Visual Basic. A quick note, try moving your mouse" & vbNewLine & "over the text."
    End Sub
End Class

Imports System
Imports System.Drawing
Imports System.Drawing.Graphics

Public Class Form1
    Dim graphic As Graphics = CreateGraphics()
    Dim x, y As Integer
    Dim pensize As Integer = 12
    Dim penColor As String = "Black"

    Sub changeSize()
        If rb12.Checked Then
            pensize = 12
        ElseIf rb16.Checked Then
            pensize = 16
        ElseIf rb18.Checked Then
            pensize = 18
        End If
    End Sub

    Sub changeColor()
        If rbBlack.Checked Then
            penColor = "Black"
        ElseIf rbRed.Checked Then
            penColor = "Red"
        Else
            penColor = "Yellow"
        End If
    End Sub

    Sub changeChecks()
        tsmi12.Checked = False
        tsmi16.Checked = False
        tsmi18.Checked = False
        mstBlack.Checked = False
        mstRed.Checked = False
        mstYellow.Checked = False

        If pensize = 12 Then
            tsmi12.Checked = True
        ElseIf pensize = 16 Then
            tsmi16.Checked = True
        ElseIf pensize = 18 Then
            tsmi18.Checked = True
        End If

        If penColor = "BlacK" Then
            rbBlack.Checked = True
            mstBlack.Checked = True
        ElseIf penColor = "Red" Then
            rbRed.Checked = True
            mstRed.Checked = True
        ElseIf penColor = "Yellow" Then
            rbYellow.Checked = True
            mstYellow.Checked = True
        End If
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        lblX.Text = e.X
        lblY.Text = e.Y
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        x = e.X
        y = e.Y
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        If penColor = "Black" Then
            Dim p As New Pen(Brushes.Black, pensize)
            graphic = Panel1.CreateGraphics
            graphic.DrawLine(p, e.X, e.Y, x, y)
            p.Dispose()
        ElseIf penColor = "Red" Then
            Dim p As New Pen(Brushes.Red, pensize)
            graphic = Panel1.CreateGraphics
            graphic.DrawLine(p, e.X, e.Y, x, y)
            p.Dispose()
        ElseIf penColor = "Yellow" Then
            Dim p As New Pen(Brushes.Yellow, pensize)
            graphic = Panel1.CreateGraphics
            graphic.DrawLine(p, e.X, e.Y, x, y)
            p.Dispose()
        End If
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        changeColor()
        changeSize()
        changeChecks()
    End Sub

    Private Sub tsmi12_Click(sender As Object, e As EventArgs) Handles tsmi12.Click
        pensize = 12
        changeChecks()
    End Sub

    Private Sub tsmi16_Click(sender As Object, e As EventArgs) Handles tsmi16.Click
        pensize = 16
        changeChecks()
    End Sub

    Private Sub tsmi18_Click(sender As Object, e As EventArgs) Handles tsmi18.Click
        pensize = 18
        changeChecks()
    End Sub

    Private Sub mstRed_Click(sender As Object, e As EventArgs) Handles mstRed.Click
        penColor = "Red"
        changeChecks()
    End Sub

    Private Sub mstBlack_Click(sender As Object, e As EventArgs) Handles mstBlack.Click
        penColor = "Black"
        changeChecks()
    End Sub

    Private Sub mstYellow_Click(sender As Object, e As EventArgs) Handles mstYellow.Click
        penColor = "Yellow"
        changeChecks()
    End Sub
End Class

Public Class frmLotteryTickets

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSuperLotto.Click
        'setting the upperLimit and megaLimit variables that will be passed to generate tickets.
        upperLimit = 47
        megaLimit = 27

        Dim super As New frmNumberOfTickets
        super.Show()
        super = Nothing 'frees up the memory it was taking

        'need to figure out how to destroy the current form after displaying the number of tickets form
        'should destroy the form after showing the frmNumberOfTickets form
        Me.Hide() 'hides the current form, it seems if I can't destroy this, if I do, it will cause the program to end
    End Sub

    Private Sub btnMegaMillions_Click(sender As Object, e As EventArgs) Handles btnMegaMillions.Click
        'setting the upperLimit and megaLimit variables that will be passed to generate tickets.
        upperLimit = 75
        megaLimit = 15

        Dim mega As New frmNumberOfTickets
        mega.Show()
        mega = Nothing 'frees up the memory it was taking

        'need to figure out how to destroy the current form after displaying the number of tickets form
        'should destroy the form after showing the frmNumberOfTickets form
        Me.Hide() 'hides the current form, it seems if I can't destroy this, if I do, it will cause the program to end
    End Sub

    Private Sub btnPowerball_Click(sender As Object, e As EventArgs) Handles btnPowerball.Click
        'setting the upperLimit and megaLimit variables that will be passed to generate tickets.
        upperLimit = 59
        megaLimit = 35

        Dim power As New frmNumberOfTickets
        power.Show()
        power = Nothing 'frees the memory it was taking

        'need to figure out how to destroy the current form after displaying the number of tickets form
        'should destroy the form after showing the frmNumberOfTickets form
        Me.Hide() 'hides the current form, it seems if I can't destroy this, if I do, it will cause the program to end
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'closes the form,  exits the application
        Me.Close()
    End Sub
End Class

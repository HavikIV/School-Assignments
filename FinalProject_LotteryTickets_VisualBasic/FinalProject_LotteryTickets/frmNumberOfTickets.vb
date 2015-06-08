Imports Lottey_Class_Project
Public Class frmNumberOfTickets

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        frmLotteryTickets.Show() 'brings the beginning form to the front
        Me.Close() 'this destroys the current instance of this form
    End Sub

    Private Sub btnOneTicket_Click(sender As Object, e As EventArgs) Handles btnOneTicket.Click
        Dim lotto As New Lottery
        ticketResults = lotto.generateTicket(upperLimit, megaLimit) 'generates a ticket

        Dim result As New frmResults 'gets ready to load a frmResults form
        result.Show() 'shows the results form
        result = Nothing 'frees the memory it was taking

        'need to destroy the current form
        Me.Close() 'destroys the form

    End Sub

    Private Sub btn5Tickets_Click(sender As Object, e As EventArgs) Handles btn5Tickets.Click
        Dim lotto As New Lottery
        Dim ticket As Byte()
        Dim ticketNumber As Byte 'counter to keep track the number of tickets generated

        For ticketNumber = 0 To 4
            ticket = lotto.generateTicket(upperLimit, megaLimit)
            Dim j As Byte = 0
            For i As Byte = ticketNumber * 6 To (i + 5)
                ticketResults(i) = ticket(j)
                j += 1
            Next
            ReDim ticket(6)
        Next

        Dim result As New frmResults 'gets ready to load a frmResults form
        result.Show() 'shows the results form
        result = Nothing 'frees the memory it was taking

        'need to destroy the current form
        Me.Close()
    End Sub
End Class
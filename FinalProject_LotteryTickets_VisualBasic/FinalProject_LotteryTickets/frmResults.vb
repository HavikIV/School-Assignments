Public Class frmResults

    Private Sub frmResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'if else statement to determine how to display the results from the ticketResult array
        If ticketResults(6) = 0 Then 'will display the first ticket, used if the user only wanted one ticket, or a "Lucky" ticket
            For i As Byte = 0 To 5
                If Not i Mod 5 = 0 Or i = 0 Then
                    RichTextBox1.Text = RichTextBox1.Text + ticketResults(i).ToString + ", "
                Else
                    RichTextBox1.Text = RichTextBox1.Text + "megaNumber " + ticketResults(i).ToString
                End If
            Next
        Else 'displays 5 tickets from ticketResults array, used if the user wanted 5 tickets
            For i As Integer = 0 To 29
                If Not i = 5 And Not i = 11 And Not i = 17 And Not i = 23 And Not i = 29 Then
                    RichTextBox1.Text = RichTextBox1.Text + ticketResults(i).ToString + ", "
                Else
                    RichTextBox1.Text = RichTextBox1.Text + "megaNumber " + ticketResults(i).ToString + vbNewLine
                End If
            Next
        End If

        'For i As Byte = 0 To 5
        '    If Not i Mod 5 = 0 Or i = 0 Then
        '        RichTextBox1.Text = RichTextBox1.Text + ticketResults(i).ToString + ", "
        '    Else
        '        RichTextBox1.Text = RichTextBox1.Text + "megaNumber " + ticketResults(i).ToString
        '    End If
        'Next

        'to print multiple tickets ;seems to not work when the form is first loaded, but it works fine if used by a button as displayed by the home button.
        'For i As Integer = 0 To 29
        '    If Not i = 5 And Not i = 11 And Not i = 17 And Not i = 23 And Not i = 29 Then
        '        RichTextBox1.Text = RichTextBox1.Text + ticketResults(i).ToString + ", "
        '    Else
        '        RichTextBox1.Text = RichTextBox1.Text + "megaNumber " + ticketResults(i).ToString + vbNewLine
        '    End If
        'Next
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        'when this event is called, suppose to return the user to the main form and also get rid of the results form
        'before closing the form, need to clear out the result array for the next run.
        Array.Clear(ticketResults, 0, ticketResults.Length - 1) 'sets all of he elements in the array to 0

        frmLotteryTickets.Show() 'brings the beginning form to the front
        Me.Close() 'this destroys the current instance of this form
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'when this event is called, suppose to return the user to the number of tickets form and also get rid of the results form
        'before closing the form, need to clear out the result array for the next run.
        Array.Clear(ticketResults, 0, ticketResults.Length - 1) 'sets all of he elements in the array to 0

        Dim number As New frmNumberOfTickets
        number.Show() 'brings the number of tickets form to the front
        number = Nothing 'frees the memory it was taking

        Me.Close() 'this destroys the current instance of this form
    End Sub
End Class
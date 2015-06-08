Public Class Lottery
    Public Function randomNumberGenerator(ByVal upperLimit) As Byte 'Generates a random number within the range of 1-upperLimit, also just uses the VB's supplied random generator.
        Dim randomNumber As Byte
        Randomize()
        randomNumber = CByte((upperLimit * Rnd()) + 1)
        Return randomNumber
    End Function

    'Generates a random number within the range of 1-upperLimit, but to the number more "lucky" the number is used calculated to a different number than the one the RNG gave.
    Public Function randomLuckyNumberGenerator(ByVal upperLimit) As Byte
        Dim luckyNumber As Integer
        Dim luckyNumber2 As Byte
        Randomize()

        'This is the arithmetic done to generate the random number. I had to use an Integer type Variable instead of the a Byte type Variable as the arithmetic would couldn't be
        'calculated due to triggering the OverFlow Flag, meaning it would go out range for a Byte integer
        luckyNumber = ((((upperLimit * Rnd()) + 1) * 42) + (5897 / upperLimit) + upperLimit) Mod 100

        Do 'in case the number returned by the mod happens to be bigger than the upperLimit, I subtract the upperLimit form it until it's less than the upperLimit
            If luckyNumber > upperLimit Then
                luckyNumber = luckyNumber - upperLimit
            End If
        Loop While luckyNumber > upperLimit

        'converting the number from Integer to Byte to save memory and adding one to make the number be in the range of 1-upperLimit, instead of 0-upperLimit, as 0 is a possible number from the MODULUS.
        luckyNumber2 = CByte(luckyNumber) + 1
        Return luckyNumber2
    End Function

    Sub sortFirst5NumbersofTheTicket(ByRef ticket)
        Dim temp As Byte
        'sorts the first 5 elements in the array from the smallest to the largest.
        For iteration As Integer = 1 To ticket.Length - 2
            For k As Integer = 0 To 3
                If ticket(k) > ticket(k + 1) Then
                    temp = ticket(k)
                    ticket(k) = ticket(k + 1)
                    ticket(k + 1) = temp
                End If
            Next
        Next
    End Sub

    Public Function generateTicket(ByVal upperLimit, ByVal megaNumberLimit) As Byte()
        Dim ticket(6) As Byte
        Dim checkPassed As Boolean

        'using a for loop to fill in the array with random numbers.
        For i As Integer = 0 To 4
            ticket(i) = randomNumberGenerator(upperLimit)
            checkPassed = False
            'the while loop is to make sure that the array doesn't end up with repeating numbers. 
            While Not checkPassed
                If i > 0 Then 'to make sure that there's at least 1 number already in the array
                    'this for loop compares all of the previous elements with most recently added element to make sure it's not repeating.
                    For j As Integer = 0 To i - 1
                        If ticket(j) = ticket(i) Then 'if the number is already in the array, it's replaced with a different number, and the while is to be repeated from the beginning again.
                            ticket(i) = randomNumberGenerator(upperLimit)
                            Exit For
                        ElseIf j = i - 1 And checkPassed = False Then 'checks to see if we can exit the while loop
                            checkPassed = True
                        End If
                    Next
                Else
                    checkPassed = True
                End If
            End While
        Next

        'sort out the first 5 elements of the ticket array
        sortFirst5NumbersofTheTicket(ticket)
        ticket(5) = randomNumberGenerator(megaNumberLimit) 'adds the megaNumber to the array
        Return ticket
    End Function

    Public Function generateLuckyNumberTicket(ByVal upperLimit, ByVal megaNumberLimit) As Byte()
        Dim ticket(6) As Byte
        Dim checkPassed As Boolean

        'using a for loop to fill in the array with random numbers.
        For i As Integer = 0 To 4
            ticket(i) = randomLuckyNumberGenerator(upperLimit)
            checkPassed = False
            'the while loop is to make sure that the array doesn't end up with repeating numbers.
            While Not checkPassed
                If i > 0 Then
                    'this for loop compares all of the previous elements with most recently added element to make sure it's not repeating.
                    For j As Integer = 0 To i - 1
                        If ticket(j) = ticket(i) Then 'if the number is already in the array, it's replaced with a different number, and the while is to be repeated from the beginning again.
                            ticket(i) = randomLuckyNumberGenerator(upperLimit)
                            Exit For
                        ElseIf j = i - 1 And checkPassed = False Then 'checks to see if we can exit the while loop
                            checkPassed = True
                        End If
                    Next
                Else
                    checkPassed = True
                End If
            End While
        Next

        'sort out the first 5 elements of the ticket array
        sortFirst5NumbersofTheTicket(ticket)
        ticket(5) = randomLuckyNumberGenerator(megaNumberLimit) 'adds the megaNumber to the array.
        Return ticket
    End Function
End Class

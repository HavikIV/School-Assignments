Public Class ClassTime
    Private numberOutput As Decimal = 0
    Private numb As String

    Public Function displayResult(ByVal num As String)
        numb = numb + num
        Return numb
    End Function

    Public Sub add(ByVal num As Integer)
        numberOutput = numberOutput + num
        numb = ""
    End Sub

    Public Sub setNumber(ByVal num As Integer)
        numberOutput = num
    End Sub

    Public Function Equal()
        Return numberOutput
    End Function

    Public Sub subtract(ByVal num As Integer)
        numberOutput = numberOutput - num
        numb = ""
    End Sub

    Public Sub multiply(ByVal num As Decimal)
        numberOutput = numberOutput * num
        numb = ""
    End Sub

    Public Sub divide(ByVal num As Decimal)
        numberOutput = numberOutput / num
        numb = ""
    End Sub
End Class

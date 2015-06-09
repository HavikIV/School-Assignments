Public Class Form1
    'Dim number As Integer
    Dim cal As New ClassTime

    Private Sub btnAddition_Click(sender As Object, e As EventArgs) Handles btnAddition.Click
        Dim number As Integer
        number = Val(Label2.Text)
        cal.add(number)
        Label1.Text = cal.Equal()
        Label2.Text = ""
        Label3.Text = "+"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'cal.setNumber(0)
        Label2.Text = cal.displayResult(0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'cal.setNumber(1)
        Label2.Text = cal.displayResult(1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'cal.setNumber(2)
        Label2.Text = cal.displayResult(2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'cal.setNumber(3)
        Label2.Text = cal.displayResult(3)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'cal.setNumber(4)
        Label2.Text = cal.displayResult(4)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'cal.setNumber(5)
        Label2.Text = cal.displayResult(5)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'cal.setNumber(6)
        Label2.Text = cal.displayResult(6)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'cal.setNumber(7)
        Label2.Text = cal.displayResult(7)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'cal.setNumber(8)
        Label2.Text = cal.displayResult(8)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'cal.setNumber(9)
        Label2.Text = cal.displayResult(9)
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        Dim int As Integer
        If Not Label2.Text = "" Then
            int = Val(Label2.Text)
            If Label3.Text = "+" Then
                cal.add(int)
            ElseIf Label3.Text = "-" Then
                cal.subtract(int)
            ElseIf Label3.Text = "*" Then
                cal.multiply(int)
            ElseIf Label3.Text = "/" Then
                If int = 0 Then
                    MessageBox.Show("Can't Divide By 0.")
                    Label1.Text = ""
                    Label2.Text = ""
                Else
                    cal.divide(int)
                End If
            End If
        End If
        Label1.Text = cal.Equal()
        Label2.Text = ""
        Label3.Text = ""
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        Dim number As Integer
        number = Val(Label2.Text)
        cal.subtract(number)
        Label1.Text = cal.Equal()
        Label2.Text = ""
        Label3.Text = "-"
    End Sub

    Private Sub btnMultply_Click(sender As Object, e As EventArgs) Handles btnMultply.Click
        Dim number As Decimal
        If Not Label2.Text = "" Then
            number = CDec(Val(Label2.Text))
            If Label1.Text = "" Then
                cal.add(number)
                Label1.Text = cal.Equal()
                Label2.Text = ""
                Label3.Text = "*"
            Else
                cal.multiply(number)
                Label1.Text = cal.Equal()
                Label2.Text = ""
                Label3.Text = "*"
            End If
        Else
            Label1.Text = cal.Equal()
            Label2.Text = ""
            Label3.Text = "*"
        End If
    End Sub

    Private Sub btnDivisor_Click(sender As Object, e As EventArgs) Handles btnDivisor.Click
        Dim number As Decimal
        If Not Label2.Text = "" Then
            number = CDec(Val(Label2.Text))
            If number = 0 Then
                MessageBox.Show("Can't divide by 0.")
                Label1.Text = ""
                Label2.Text = ""
            ElseIf Label1.Text = "" Then
                cal.add(number)
                Label1.Text = cal.Equal()
                Label2.Text = ""
                Label3.Text = "/"
            Else
                cal.divide(number)
                Label1.Text = cal.Equal()
                Label2.Text = ""
                Label3.Text = "/"
            End If
        Else
            Label1.Text = cal.Equal()
            Label2.Text = ""
            Label3.Text = "/"
        End If
    End Sub
End Class

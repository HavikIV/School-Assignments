Public Class Pizza
    Dim _size As String
    Dim _toppings As List(Of String)

    Public Property Size As String
        Get
            Return _size
        End Get
        Set(value As String)
            _size = value
        End Set
    End Property
    Public Property Toppings As String
        Get
            Return _toppings.ToString()
        End Get
        Set(value As String)
            _toppings.Add(value)
        End Set
    End Property
End Class

Public Class Order
    Inherits Pizza
    Dim _customerName, _Address, _phoneNumber, _orderTime As String
    Dim _pizzaAmount As Integer

    Public Property customerName As String
        Get
            Return _customerName
        End Get
        Set(value As String)
            _customerName = value
        End Set
    End Property
    Public Property Address As String
        Get
            Return _Address
        End Get
        Set(value As String)
            _Address = value
        End Set
    End Property
    Public Property phoneNumber As String
        Get
            Return _phoneNumber
        End Get
        Set(value As String)
            _phoneNumber = value
        End Set
    End Property
    Public Property orderTime As String
        Get
            Return _orderTime
        End Get
        Set(value As String)
            _orderTime = value
        End Set
    End Property
    Public Property pizzaAmount As Integer
        Get
            Return _pizzaAmount
        End Get
        Set(value As Integer)
            _pizzaAmount = value
        End Set
    End Property

    Sub New()
        _customerName = ""
        _Address = ""
        _phoneNumber = ""
        _orderTime = ""
        _pizzaAmount = 0
    End Sub
End Class
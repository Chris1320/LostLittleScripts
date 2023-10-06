' This class represents a tour type of a location.
Public Class Tour
    Public type As String  ' e.g. "Deep Sea Fishing"
    Public length As Integer  ' e.g. 8 hours
    Public price As Double  ' e.g. $199

    Public Sub New(type As String, length As Integer, price As Double)
        Me.type = type
        Me.length = length
        Me.price = price
    End Sub
End Class

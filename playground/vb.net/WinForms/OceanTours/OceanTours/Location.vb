' This class represents a location available in
' the reservation form.
Public Class Location
    Public name As String  ' e.g. "Hawaii"
    Public tours() As Tour

    Public Sub New(name As String, tours() As Tour)
        Me.name = name
        Me.tours = tours
    End Sub
End Class

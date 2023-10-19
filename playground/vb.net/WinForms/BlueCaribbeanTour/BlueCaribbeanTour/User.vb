' This is a class that represents a user in the system.
Public Class User
    Public ReadOnly user_id As Integer?
    Public username As String
    Public password As String
    Public userlevel As Integer
    Public name(3) As String
    Public address As String
    Public phone_number As String

    Sub New(
        user_id As Integer?,  ' Allow optional for non-registered users
        username As String,
        password As String,
        userlevel As Integer,
        name() As String,
        address As String,
        phone_number As String
    )
        Me.user_id = user_id
        Me.username = username
        Me.password = password
        Me.userlevel = userlevel
        Me.name = name
        Me.address = address
        Me.phone_number = phone_number
    End Sub
End Class

Public Class Reservation
    Public ReadOnly id As Integer?
    Public ReadOnly user_id As Integer
    Public tour_location As String
    Public people_count As Integer
    Public departure_date As Date
    Public visit_days As Integer
    Public mode_of_payment As String
    Public total_cost As Double
    Public is_cancelled As Boolean = False

    Sub New(
        id As Integer?,
        user_id As Integer,
        tour_location As String,
        people_count As Integer,
        departure_date As Date,
        visit_days As Integer,
        mode_of_payment As String,
        total_cost As Double,
        Optional is_cancelled As Boolean = False,
    )
        Me.id = id
        Me.user_id = user_id
        Me.tour_location = tour_location
        Me.people_count = people_count
        Me.departure_date = departure_date
        Me.visit_days = visit_days
        Me.mode_of_payment = mode_of_payment
        Me.total_cost = total_cost
        Me.is_cancelled = is_cancelled
    End Sub
End Class

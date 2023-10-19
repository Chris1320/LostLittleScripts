Public Class Reservations
    Private user_info As User

    Sub New(user_info As User)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user_info = user_info
    End Sub

    Private Sub Reservations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim reservation_manager = New ReservationManager()
        Dim reservations = reservation_manager.getReservations(user_info.user_id)

        For Each reservation As Reservation In reservations
            Dim row = New String() {
                reservation.id,
                reservation.user_id,
                reservation.tour_location,
                reservation.people_count,
                reservation.departure_date.ToShortDateString(),
                reservation.visit_days,
                reservation.mode_of_payment,
                reservation.total_cost.ToString("C")
            }
            dgvReservations.Rows.Add(row)
        Next
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Throw New Exception("LoginRequired")
    End Sub
End Class
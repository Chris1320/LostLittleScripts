Public Class Reservations
    Private signal_to_parent As String
    Private user_info As User

    Sub New(user_info As User, Optional admin_use As Boolean = False)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user_info = user_info
        If admin_use Then : Me.MenuStrip1.Visible = False
        End If
    End Sub

    Public Function start() As String
        Me.ShowDialog()
        Return Me.signal_to_parent
    End Function

    Private Sub updateReservations()
        Dim reservations_datasource = New DataTable()
        Dim reservation_manager = New ReservationManager()
        Dim reservations = reservation_manager.getReservations(user_info.user_id)

        ' copy columns of the datatable
        For Each column As DataGridViewColumn In dgvReservations.Columns
            reservations_datasource.Columns.Add(column.Name)
        Next

        For Each reservation As Reservation In reservations
            Dim reservations_datasource_row = reservations_datasource.NewRow()
            reservations_datasource_row("id") = reservation.id
            reservations_datasource_row("client") = reservation.user_id
            reservations_datasource_row("tour_location") = reservation.tour_location
            reservations_datasource_row("ppl_quantity") = reservation.people_count
            reservations_datasource_row("departure_date") = reservation.departure_date.ToShortDateString()
            reservations_datasource_row("visit_days") = reservation.visit_days
            reservations_datasource_row("mode_of_payment") = reservation.mode_of_payment
            reservations_datasource_row("total_cost") = reservation.total_cost.ToString("C")
            reservations_datasource_row("is_cancelled") = reservation.is_cancelled

            bsrcReservations.Add(reservation)
            reservations_datasource.Rows.Add(reservations_datasource_row)
        Next

        Dim reservations_binding_source As New BindingSource With {
            .DataSource = reservations_datasource
        }
        bnavReservations.BindingSource = reservations_binding_source
        dgvReservations.DataSource = reservations_binding_source
        If dgvReservations.Rows.Count < 1 Then : btnCancelReservation.Enabled = False
        Else : btnCancelReservation.Enabled = True
        End If
    End Sub

    Private Sub Reservations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateReservations()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.signal_to_parent = "LoginRequired"
        Me.Close()
    End Sub

    Private Sub ProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfileToolStripMenuItem.Click
        Dim user_profile = New UserProfile(user_info)
        user_profile.ShowDialog()
    End Sub

    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click
        Me.signal_to_parent = "ReturnToDashboard"
        Me.Close()
    End Sub

    Private Sub btnCancelReservation_Click(sender As Object, e As EventArgs) Handles btnCancelReservation.Click
        Dim reservation_manager = New ReservationManager()
        Dim reservation_id = dgvReservations.CurrentRow.Cells("id").Value

        If reservation_manager.cancelReservation(reservation_id) Then
            MessageBox.Show(
                "Reservation cancelled successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )
            Me.Reservations_Load(sender, e)
        End If
    End Sub
End Class
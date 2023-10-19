Imports System.Data.OleDb

Public Class ReservationManager
    Private db_manager = New DatabaseManager()

    Public Function addReservation(reservation As Reservation) As Boolean
        Try
            Dim db_connection = Me.db_manager.getConnection()
            Dim db_command_str_fields = "(
                [client],
                [tour_location], [ppl_quantity],
                [departure_date], [visit_days],
                [mode_of_payment], [total_cost]
                )"
            Dim db_command_str_values = $"(
                {reservation.user_id},
                '{reservation.tour_location}',
                {reservation.people_count},
                '{reservation.departure_date.ToShortDateString()}',
                {reservation.visit_days},
                '{reservation.mode_of_payment}',
                {reservation.total_cost}
                )"
            Dim db_command = New OleDbCommand(
                $"INSERT INTO reservations {db_command_str_fields} VALUES {db_command_str_values}",
                db_connection
            )

            db_connection.Open()
            db_command.ExecuteNonQuery()
            db_connection.Close()
            Return True

        Catch ex As Exception
            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
            Return False
        End Try
    End Function
End Class

Imports System.Data.OleDb

Public Class ReservationManager
    Private db_manager = New DatabaseManager()

    Public Function addReservation(
        user_id As Integer,
        tour_location As String,
        people_count As Integer,
        departure_date As Date,
        visit_days As Integer,
        mode_of_payment As String,
        total_cost As Double
    ) As Boolean
        Try
            Dim db_connection = Me.db_manager.getConnection()
            Dim db_command_str_fields = "(
                [client],
                [tour_location], [ppl_quantity],
                [departure_date], [visit_days],
                [mode_of_payment], [total_cost]
                )"
            Dim db_command_str_values = $"(
                {user_id},
                '{tour_location}', {people_count},
                '{departure_date.ToShortDateString()}', {visit_days},
                '{mode_of_payment}', {total_cost}
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

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
                [mode_of_payment], [total_cost],
                [is_cancelled]
                )"
            Dim db_command_str_values = $"(
                {reservation.user_id},
                '{reservation.tour_location}',
                {reservation.people_count},
                '{reservation.departure_date.ToShortDateString()}',
                {reservation.visit_days},
                '{reservation.mode_of_payment}',
                {reservation.total_cost},
                {reservation.is_cancelled}
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
            If Not Info.CATCH_EXCEPTIONS Then : Throw ex
            Else
                MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
                Return False
            End If
        End Try
    End Function

    Public Function getReservations(
        user_id As Integer,
        Optional ByVal include_cancelled As Boolean = False
    ) As List(Of Reservation)
        Dim reservations = New List(Of Reservation)()

        Try
            Dim db_connection = Me.db_manager.getConnection()
            Dim db_command = New OleDbCommand(
                String.Format(
                    "{0}{1}",
                    "SELECT * FROM reservations WHERE [client] = @user_id",
                    If(
                        include_cancelled,
                        "",
                        " AND [is_cancelled] = 0"
                    )
                ),
                db_connection
            )
            db_command.Parameters.AddWithValue("@user_id", user_id)

            db_connection.Open()
            Dim db_reader = db_command.ExecuteReader()
            While db_reader.Read()
                Dim reservation = New Reservation(
                    db_reader("id"),
                    db_reader("client"),
                    db_reader("tour_location"),
                    db_reader("ppl_quantity"),
                    db_reader("departure_date"),
                    db_reader("visit_days"),
                    db_reader("mode_of_payment"),
                    db_reader("total_cost"),
                    db_reader("is_cancelled")
                )
                reservations.Add(reservation)
            End While

            db_connection.Close()

        Catch ex As Exception
            If Not Info.CATCH_EXCEPTIONS Then : Throw ex
            Else
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )
            End If
        End Try

        Return reservations
    End Function

    Public Function cancelReservation(reservation_id As Integer)
        Try
            Dim db_connection = Me.db_manager.getConnection()
            Dim db_command = New OleDbCommand(
                "UPDATE reservations SET [is_cancelled] = 1 WHERE [id] = @reservation_id",
                db_connection
            )
            db_command.Parameters.AddWithValue("@reservation_id", reservation_id)

            db_connection.Open()
            db_command.ExecuteNonQuery()
            db_connection.Close()
            Return True

        Catch ex As Exception
            If Not Info.CATCH_EXCEPTIONS Then : Throw ex
            Else
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )
                Return False
            End If
        End Try
    End Function
End Class

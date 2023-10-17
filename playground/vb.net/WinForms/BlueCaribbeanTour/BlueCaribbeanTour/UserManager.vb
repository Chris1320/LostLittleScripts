﻿Imports System.Data.OleDb

Public Class UserManager
    Private db_manager = New DatabaseManager()

    ' Check for invalid username.
    '
    ' Usernames must be 3 to 32 characters long.
    '
    ' @param username The username to check.
    Public Function validateUsername(username As String) As Boolean
        If username.Length < 3 Or username.Length > 32 Then : Return False
        Else : Return True
        End If
    End Function

    ' Check for invalid password.
    '
    ' Passwords must be 8 to 60 characters long.
    '
    ' @param password The password to check.
    Public Function validatePassword(password As String) As Boolean
        If password.Length < 8 Or password.Length > 60 Then : Return False
        Else : Return True
        End If
    End Function

    ' Add a new user to the database.
    ' Returns true if the user was added successfully.
    '
    ' @param username The username of the user.
    ' @param password The password of the user.
    ' @param userlevel The userlevel of the user.
    Public Function registerUser(
        username As String,
        password As String,
        userlevel As Integer,
        name_first As String,
        name_middle As String,
        name_last As String,
        address As String,
        phone_number As String
    )
        If Not Me.validateUsername(username) Then : Return False
        ElseIf Not Me.validatePassword(password) Then : Return False
        End If

        ' Check if username is already taken.
        Try
            Dim db_connection = Me.db_manager.getConnection()
            Dim db_command = New OleDbCommand(
                "SELECT COUNT(*) FROM users WHERE [username] = @username",
                db_connection
            )

            db_command.Parameters.AddWithValue("@username", username)
            db_connection.Open()
            Dim db_reader = db_command.ExecuteReader()
            db_reader.Read()
            Dim user_count = db_reader.GetInt32(0)
            db_connection.Close()

            If user_count > 0 Then : Return False
            End If
        Catch ex As Exception
            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
            Return False
        End Try

        Try
            Dim db_connection = Me.db_manager.getConnection()
            Dim db_command = New OleDbCommand(
                "INSERT INTO users ([username], [password], [userlevel]) VALUES (@username, @password, @userlevel)",
                db_connection
            )

            db_command.Parameters.AddWithValue("@username", username)
            db_command.Parameters.AddWithValue("@password", password)
            db_command.Parameters.AddWithValue("@userlevel", userlevel)

            db_connection.Open()
            db_command.ExecuteNonQuery()

            ' Get the user ID of the user that was just added.
            db_command = New OleDbCommand(
                "SELECT [id] FROM users WHERE [username] = @username",
                db_connection
            )
            db_command.Parameters.AddWithValue("@username", username)
            Dim db_reader = db_command.ExecuteReader()
            db_reader.Read()
            Dim user_id = db_reader.GetInt32(0)

            ' Add the user's information to user_info table.
            Dim db_command_userinfo_str = "([id], [name_first], [name_middle], [name_last], [address], [phone_number])"
            Dim db_command_userinfo_str_val = "(@id, @name_first, @name_middle, @name_last, @address, @phone_number)"
            db_command = New OleDbCommand(
                $"INSERT INTO user_info {db_command_userinfo_str} VALUES {db_command_userinfo_str_val}",
                db_connection
            )

            db_command.Parameters.AddWithValue("@id", user_id)
            db_command.Parameters.AddWithValue("@name_first", name_first)
            db_command.Parameters.AddWithValue("@name_middle", name_middle)
            db_command.Parameters.AddWithValue("@name_last", name_last)
            db_command.Parameters.AddWithValue("@address", address)
            db_command.Parameters.AddWithValue("@phone_number", phone_number)

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

    Public Function loginUser(username As String, password As String) As Boolean
        Try
            Dim db_connection = Me.db_manager.getConnection()
            Dim db_command = New OleDbCommand(
                "SELECT COUNT(*) FROM users WHERE [username] = @username AND [password] = @password",
                db_connection
            )

            db_command.Parameters.AddWithValue("@username", username)
            db_command.Parameters.AddWithValue("@password", password)

            db_connection.Open()
            Dim db_reader = db_command.ExecuteReader()
            db_reader.Read()
            Dim user_count = db_reader.GetInt32(0)
            db_connection.Close()
            Return user_count = 1

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

    Public Function usernameToID(username As String) As String
        Try
            Dim db_connection = Me.db_manager.getConnection()
            Dim db_command = New OleDbCommand(
                "SELECT [id] FROM users WHERE [username] = @username",
                db_connection
            )

            db_command.Parameters.AddWithValue("@username", username)

            db_connection.Open()
            Dim db_reader = db_command.ExecuteReader()
            db_reader.Read()
            Dim user_id = db_reader.GetInt32(0)
            db_connection.Close()
            Return user_id

        Catch ex As Exception
            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
            Return Nothing
        End Try
    End Function

    Public Function getUserLevel(user_id As Integer) As Integer
        Try
            Dim db_connection = Me.db_manager.getConnection()
            Dim db_command = New OleDbCommand(
                "SELECT [userlevel] FROM users WHERE [id] = @user_id",
                db_connection
            )

            db_command.Parameters.AddWithValue("@user_id", user_id)

            db_connection.Open()
            Dim db_reader = db_command.ExecuteReader()
            db_reader.Read()
            Dim userlevel = db_reader.GetInt32(0)
            db_connection.Close()
            Return userlevel

        Catch ex As Exception
            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
            Return Nothing
        End Try
    End Function
End Class

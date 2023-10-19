Imports System.Data.OleDb

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
    Public Function registerUser(user_info As User)
        If Not Me.validateUsername(user_info.username) Then : Return False
        ElseIf Not Me.validatePassword(user_info.password) Then : Return False
        End If

        ' Check if username is already taken.
        Try
            Dim db_connection = Me.db_manager.getConnection()
            Dim db_command = New OleDbCommand(
                "SELECT COUNT(*) FROM users WHERE [username] = @username",
                db_connection
            )

            db_command.Parameters.AddWithValue("@username", user_info.username)
            db_connection.Open()
            Dim db_reader = db_command.ExecuteReader()
            db_reader.Read()
            Dim user_count = db_reader.GetInt32(0)
            db_connection.Close()

            If user_count > 0 Then : Return False
            End If
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

        Try
            Dim db_connection = Me.db_manager.getConnection()
            Dim db_command = New OleDbCommand(
                "INSERT INTO users ([username], [password], [userlevel], [disabled]) VALUES (@username, @password, @userlevel, 0)",
                db_connection
            )

            db_command.Parameters.AddWithValue("@username", user_info.username)
            db_command.Parameters.AddWithValue("@password", user_info.password)
            db_command.Parameters.AddWithValue("@userlevel", user_info.userlevel)

            db_connection.Open()
            db_command.ExecuteNonQuery()

            ' Get the user ID of the user that was just added.
            db_command = New OleDbCommand(
                "SELECT [id] FROM users WHERE [username] = @username",
                db_connection
            )
            db_command.Parameters.AddWithValue("@username", user_info.username)
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
            db_command.Parameters.AddWithValue("@name_first", user_info.name(0))
            db_command.Parameters.AddWithValue("@name_middle", user_info.name(1))
            db_command.Parameters.AddWithValue("@name_last", user_info.name(2))
            db_command.Parameters.AddWithValue("@address", user_info.address)
            db_command.Parameters.AddWithValue("@phone_number", user_info.phone_number)

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

    Public Function loginUser(username As String, password As String) As Boolean
        Try
            Dim db_connection = Me.db_manager.getConnection()
            Dim db_command = New OleDbCommand(
                "SELECT COUNT(*) FROM users WHERE [username] = @username AND [password] = @password AND [disabled] = 0",
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
            If Not Info.CATCH_EXCEPTIONS Then : Throw ex
            Else
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )
                Return Nothing
            End If
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
            If Not Info.CATCH_EXCEPTIONS Then : Throw ex
            Else
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )
                Return Nothing
            End If
        End Try
    End Function

    Public Function getUserInformation(user_id As Integer) As User
        Dim db_connection = Me.db_manager.getConnection()
        Dim db_command_useracc = New OleDbCommand(
            "SELECT * FROM users WHERE [id] = @user_id", db_connection
        )
        Dim db_command_userinfo = New OleDbCommand(
            "SELECT * FROM user_info WHERE [id] = @user_id", db_connection
        )

        db_command_useracc.Parameters.AddWithValue("@user_id", user_id)
        db_command_userinfo.Parameters.AddWithValue("@user_id", user_id)

        db_connection.Open()

        Dim db_reader_useracc = db_command_useracc.ExecuteReader()
        Dim db_reader_userinfo = db_command_userinfo.ExecuteReader()
        db_reader_useracc.Read()
        db_reader_userinfo.Read()

        Dim user = New User(
            user_id,
            db_reader_useracc.GetString(1),
            db_reader_useracc.GetString(2),
            db_reader_useracc.GetInt32(3),
            New String() {
                db_reader_userinfo.GetString(1),
                db_reader_userinfo.GetString(2),
                db_reader_userinfo.GetString(3)
            },
            db_reader_userinfo.GetString(4),
            db_reader_userinfo.GetString(5),
            db_reader_useracc.GetBoolean(4)
        )
        db_connection.Close()
        Return user
    End Function

    Public Function updateUser(user_info As User) As Boolean
        If Not validateUsername(user_info.username) Then : Return False
        ElseIf Not validatePassword(user_info.password) Then : Return False
        End If

        Try
            Dim db_connection = Me.db_manager.getConnection()
            Dim db_command = New OleDbCommand(
                "UPDATE users SET [username] = @username, [password] = @password, [userlevel] = @userlevel WHERE [id] = @id",
                db_connection
            )

            db_command.Parameters.AddWithValue("@username", user_info.username)
            db_command.Parameters.AddWithValue("@password", user_info.password)
            db_command.Parameters.AddWithValue("@userlevel", user_info.userlevel)
            db_command.Parameters.AddWithValue("@id", user_info.user_id)

            db_connection.Open()
            db_command.ExecuteNonQuery()

            ' Update user_info table.
            Dim db_command_userinfo_str = "SET [name_first] = @name_first, [name_middle] = @name_middle, [name_last] = @name_last, [address] = @address, [phone_number] = @phone_number"
            db_command = New OleDbCommand(
                $"UPDATE user_info {db_command_userinfo_str} WHERE [id] = @id",
                db_connection
            )

            db_command.Parameters.AddWithValue("@name_first", user_info.name(0))
            db_command.Parameters.AddWithValue("@name_middle", user_info.name(1))
            db_command.Parameters.AddWithValue("@name_last", user_info.name(2))
            db_command.Parameters.AddWithValue("@address", user_info.address)
            db_command.Parameters.AddWithValue("@phone_number", user_info.phone_number)
            db_command.Parameters.AddWithValue("@id", user_info.user_id)

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

    Public Function getAllUsers(Optional ByVal include_disabled As Boolean = False) As List(Of User)
        Dim db_connection = Me.db_manager.getConnection()
        Dim db_command_acc = New OleDbCommand(
            "SELECT * FROM users" & If(
                include_disabled,
                "",
                " WHERE [disabled] = 0"
            ),
            db_connection
        )
        db_connection.Open()
        Dim db_reader_acc = db_command_acc.ExecuteReader()
        Dim users As New List(Of User)

        While db_reader_acc.Read()
            Dim db_command_info = New OleDbCommand(
                "SELECT * FROM user_info WHERE [id] = @user_id",
                db_connection
            )
            db_command_info.Parameters.AddWithValue("@user_id", db_reader_acc.GetInt32(0))
            Dim db_reader_info = db_command_info.ExecuteReader()
            db_reader_info.Read()

            Dim user = New User(
                db_reader_acc.GetInt32(0),
                db_reader_acc.GetString(1),
                db_reader_acc.GetString(2),
                db_reader_acc.GetInt32(3),
                New String() {
                    db_reader_info.GetString(1),
                    db_reader_info.GetString(2),
                    db_reader_info.GetString(3)
                },
                db_reader_info.GetString(4),
                db_reader_info.GetString(5),
                db_reader_acc.GetBoolean(4)
            )
            users.Add(user)
        End While

        db_connection.Close()
        Return users
    End Function

    Public Function kickUser(user_id As Integer) As Boolean
        Try
            Dim db_connection = Me.db_manager.getConnection()
            Dim db_command = New OleDbCommand(
                "UPDATE users SET [disabled] = -1 WHERE [id] = @user_id",
                db_connection
            )

            db_command.Parameters.AddWithValue("@user_id", user_id)

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

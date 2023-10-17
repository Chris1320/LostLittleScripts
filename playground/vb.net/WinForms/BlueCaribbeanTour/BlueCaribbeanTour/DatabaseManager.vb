Imports System.Data.OleDb

Public Class DatabaseManager
    Private db_provider As String = "Microsoft.ACE.OLEDB.12.0;"
    Private db_filename As String = $"{Environment.CurrentDirectory}\BlueCaribbeanTour.accdb"
    Private db_template_filename As String = $"{Environment.CurrentDirectory}\Data\schema.accdb"

    ' Create a connection to the database
    Public Function getConnection() As OleDbConnection
        ' Build connection string
        Dim db_provider_str = $"Provider={Me.db_provider};"
        Dim db_filepath_str = $"Data Source={Me.db_filename};"
        Dim db_connection_str = $"{db_provider_str}{db_filepath_str}"

        ' Return new connection
        Return New OleDbConnection(db_connection_str)
    End Function

    ' Check if the database file exists
    Public Function databaseExists(Optional ByVal check_template As Boolean = False) As Boolean
        If check_template Then : Return My.Computer.FileSystem.FileExists(Me.db_template_filename)
        Else : Return My.Computer.FileSystem.FileExists(Me.db_filename)
        End If
    End Function

    ' Copy the database template to the database filepath.
    Public Sub createDatabase()
        If My.Computer.FileSystem.FileExists(Me.db_filename) Then
            My.Computer.FileSystem.DeleteFile(Me.db_filename)
        End If

        My.Computer.FileSystem.CopyFile(
            Me.db_template_filename,
            Me.db_filename
        )
    End Sub

    ' Check if the database is empty.
    Public Function databaseIsEmpty() As Boolean
        Dim db_connection = Me.getConnection()
        Dim db_command = New OleDbCommand(
            "SELECT COUNT(*) FROM users",
            db_connection
        )

        db_connection.Open()
        Dim db_reader = db_command.ExecuteReader()
        db_reader.Read()
        Dim user_count = db_reader.GetInt32(0)
        db_connection.Close()

        Return user_count = 0
    End Function
End Class

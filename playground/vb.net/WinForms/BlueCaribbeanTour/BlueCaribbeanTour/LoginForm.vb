Public Class LoginForm
    Public Sub cleanUp()
        txtUsername.Text = String.Empty
        txtPassword.Text = String.Empty
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db_manager = New DatabaseManager()

        ' Create database if it does not exist or is empty.
        If Not db_manager.databaseExists() OrElse db_manager.databaseIsEmpty() Then
            db_manager.createDatabase()
            Dim register_form = New RegisterForm With {
                .create_as_admin = True
            }
            register_form.ShowDialog()
        End If
    End Sub

    Private Sub login()
        Dim user_manager = New UserManager()
        If user_manager.loginUser(txtUsername.Text, txtPassword.Text) Then
            MessageBox.Show(
                "Login successful!",
                "Login Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )
            Me.Hide()
            Dim dashboard = New Dashboard()
            dashboard.setUsername(txtUsername.Text)
            dashboard.ShowDialog()
        Else
            MessageBox.Show(
                "Invalid username or password.",
                "Login Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End If
    End Sub

    Private Sub btnTogglePassword_Click(sender As Object, e As EventArgs) Handles btnTogglePassword.Click
        txtPassword.UseSystemPasswordChar = Not txtPassword.UseSystemPasswordChar
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then : login()
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then : login()
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        login()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MessageBox.Show(
            "Do you want to exit the application?",
            "Exit",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        ) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub lnkToRegistration_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkToRegistration.LinkClicked
        Dim register_form = New RegisterForm()
        register_form.ShowDialog()
    End Sub
End Class

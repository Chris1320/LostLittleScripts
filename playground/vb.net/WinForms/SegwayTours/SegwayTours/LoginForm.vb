Public Class LoginForm
    ' NOTE: The maximum length for the username and password is 22.
    Const USERNAME As String = "chris"
    Const PASSWORD As String = "hunter1"
    ' Yeah I know, it's not secure. But this is just a demo.
    ' I won't implement a PBKDF2/SHA1 hashing algorithm for this.

    Private Sub login()
        If txtUsername.Text = USERNAME AndAlso txtPassword.Text = PASSWORD Then
            MessageBox.Show(
                "Log-In Successful",
                "Log-In Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )
            Me.Hide()
            TourForm.Show()

        Else
            MessageBox.Show(
                "Incorrect Username or Password",
                "Log-In Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
        End If
    End Sub

    Private Sub btnTogglePasswordView_Click(sender As Object, e As EventArgs) Handles btnTogglePasswordView.Click
        txtPassword.UseSystemPasswordChar = Not txtPassword.UseSystemPasswordChar
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MessageBox.Show(
            "Are you sure you want to close the program?",
            "Close Program",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        ) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        login()
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then : login()
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then : login()
        End If
    End Sub
End Class

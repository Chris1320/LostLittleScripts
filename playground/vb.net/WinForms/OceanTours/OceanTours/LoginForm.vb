Public Class LoginForm
    Const USERNAME As String = "oceantours"
    Const PASSWORD As String = "hunter2"  ' https://knowyourmeme.com/memes/hunter2

    Private Sub login()
        If txtUsername.Text = USERNAME AndAlso txtPassword.Text = PASSWORD Then
            Me.Hide()
            LandingPage.ShowDialog()

        Else
            MessageBox.Show(
                "Invalid username or password",
                "Login Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

            txtPassword.Text = String.Empty
            txtUsername.Focus()

        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MessageBox.Show(
            "Are you sure you want to close the program?",
            "Close Program",
            MessageBoxButtons.YesNo
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

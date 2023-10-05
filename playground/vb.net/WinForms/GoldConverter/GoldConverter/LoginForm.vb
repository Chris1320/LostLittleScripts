Public Class LoginForm
    ' Store in plaintext because this is just a demo.
    Const USERNAME As String = "admin"
    Const PASSWORD As String = "admin"

    Private Sub login()
        If txtUsername.Text = USERNAME AndAlso txtPassword.Text = PASSWORD Then
            MessageBox.Show(
                "Login Successful!",
                "Successful Login",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            CashForGold.Show()

        Else : MessageBox.Show(
            "Username or password is incorrect! Please try again.",
            "Login Failed",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )
        End If
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        login()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MessageBox.Show(
            "Do you really want to close the program?",
            "Cancel Login",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        ) = DialogResult.No Then : Return
        Else : Me.Close()  ' Close the program
        End If
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then login()
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then login()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the default mode to 0 (no mode selected)
        CashForGold.comboMode.SelectedIndex = 0
    End Sub
End Class

Public Class RegisterForm
    Public create_as_admin As Boolean = False

    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db_manager = New DatabaseManager()
        lblAdminAccountNotice.Visible = create_as_admin
        lnkToLogin.Visible = db_manager.databaseExists() _
                                AndAlso Not db_manager.databaseIsEmpty()
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        lblPasswordMismatch.Visible = txtPassword.Text <> txtPasswordConfirm.Text
    End Sub

    Private Sub txtPasswordConfirm_TextChanged(sender As Object, e As EventArgs) Handles txtPasswordConfirm.TextChanged
        lblPasswordMismatch.Visible = txtPassword.Text <> txtPasswordConfirm.Text
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtUsername.Text = String.Empty
        txtPassword.Text = String.Empty
        txtPasswordConfirm.Text = String.Empty

        txtFirstName.Text = String.Empty
        txtMiddleInitial.Text = String.Empty
        txtLastName.Text = String.Empty

        txtAddress.Text = String.Empty
        txtPhoneNumber.Text = "09"
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim user_manager = New UserManager()
        If Not user_manager.validateUsername(txtUsername.Text) Then
            MessageBox.Show(
                "Username must be 3 to 32 characters long and consist of alphanumeric characters.",
                "Registration Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
            Return

        ElseIf txtPassword.Text <> txtPasswordConfirm.Text Then
            MessageBox.Show(
                "Passwords do not match.",
                "Registration Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
            Return

        ElseIf Not user_manager.validatePassword(txtPassword.Text) Then
            MessageBox.Show(
                "Password must be at least 8 characters long.",
                "Registration Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
            Return
        End If

        Dim user_manger = New UserManager()
        If Not user_manger.registerUser(
            txtUsername.Text,
            txtPassword.Text,
            If(create_as_admin, 0, 1),  ' 0 = admin, 1 = user
            txtFirstName.Text,
            txtMiddleInitial.Text,
            txtLastName.Text,
            txtAddress.Text,
            txtPhoneNumber.Text
            ) Then : MessageBox.Show(
                "Failed to register user.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End If
        MessageBox.Show(
        "User registered successfully.",
        "Success",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
    )
        Me.Dispose()
    End Sub

    Private Sub lnkToLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkToLogin.LinkClicked
        Me.Dispose()
    End Sub

    Private Sub txtMiddleInitial_TextChanged(sender As Object, e As EventArgs) Handles txtMiddleInitial.TextChanged
        txtMiddleInitial.Text = txtMiddleInitial.Text.Replace(".", "")
    End Sub
End Class
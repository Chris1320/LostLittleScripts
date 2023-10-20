Public Class UserProfile
    Private signal_to_parent As String
    Private user_info As User
    Private edit_mode As Boolean = False
    Private new_userlevel As Integer

    Sub New(user_info As User)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user_info = user_info
        Me.new_userlevel = user_info.userlevel
    End Sub

    Public Function start() As String
        Me.ShowDialog()
        Return Me.signal_to_parent
    End Function

    Private Sub loadFromUserInformation()
        txtUserID.Text = user_info.user_id
        txtUsername.Text = user_info.username
        txtPassword.Text = user_info.password
        updateUserLevelDisplay()
        txtNameFirst.Text = user_info.name(0)
        txtNameMiddle.Text = user_info.name(1)
        txtNameLast.Text = user_info.name(2)
        txtAddress.Text = user_info.address
        txtPhoneNumber.Text = user_info.phone_number
    End Sub

    Private Sub updateUserLevelDisplay()
        txtUserLevel.Text = If(
            new_userlevel = 0,
            "Administrator",
            "Customer"
        )
    End Sub

    Private Sub toggleEditMode(Optional ByVal save_changes As Boolean = True)
        If edit_mode And save_changes Then
            Dim user_manager = New UserManager()
            Dim new_user_info = New User(
                txtUserID.Text,
                txtUsername.Text,
                txtPassword.Text,
                new_userlevel,
                {
                    txtNameFirst.Text,
                    txtNameMiddle.Text,
                    txtNameLast.Text
                },
                txtAddress.Text,
                txtPhoneNumber.Text
            )
            If user_manager.updateUser(new_user_info) Then
                MessageBox.Show(
                    "Account details updated successfully!",
                    "Update Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )
                If new_user_info.userlevel <> user_info.userlevel Then
                    MessageBox.Show(
                        "You have been demoted to a customer. Please log in again.",
                        "Demotion",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    )
                    Me.signal_to_parent = "LoginRequired"
                    Me.Close()
                End If
            Else
                MessageBox.Show(
                    "Failed to update account details.",
                    "Update Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )
                Return
            End If
        End If

        edit_mode = Not edit_mode
        btnEditAccount.Text = If(edit_mode, "Save Changes", "Edit Account Details")
        btnDiscard.Enabled = edit_mode
        btnDemoteUser.Enabled = new_userlevel = 0 And edit_mode

        txtUsername.ReadOnly = Not edit_mode
        txtPassword.ReadOnly = Not edit_mode
        txtNameFirst.ReadOnly = Not edit_mode
        txtNameMiddle.ReadOnly = Not edit_mode
        txtNameLast.ReadOnly = Not edit_mode
        txtAddress.ReadOnly = Not edit_mode
        txtPhoneNumber.ReadOnly = Not edit_mode
    End Sub

    Private Sub UserProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadFromUserInformation()
    End Sub

    Private Sub btnPasswordHide_Click(sender As Object, e As EventArgs) Handles btnPasswordHide.Click
        txtPassword.UseSystemPasswordChar = Not txtPassword.UseSystemPasswordChar
    End Sub

    Private Sub btnEditAccount_Click(sender As Object, e As EventArgs) Handles btnEditAccount.Click
        toggleEditMode()
    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        new_userlevel = user_info.userlevel
        loadFromUserInformation()
        toggleEditMode(False)
    End Sub

    Private Sub btnDemoteUser_Click(sender As Object, e As EventArgs) Handles btnDemoteUser.Click
        new_userlevel = 1
        updateUserLevelDisplay()
    End Sub
End Class
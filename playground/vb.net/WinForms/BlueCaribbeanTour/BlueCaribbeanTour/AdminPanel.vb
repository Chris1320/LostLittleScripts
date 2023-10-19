Public Class AdminPanel
    Private user_info As User

    Sub New(user_info As User)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user_info = user_info
    End Sub

    Private Sub AdminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim users_datasource = New DataTable()
        Dim user_manager = New UserManager()
        Dim users = user_manager.getAllUsers()

        ' copy columns of the datatable
        For Each column As DataGridViewColumn In dgvUsers.Columns
            users_datasource.Columns.Add(column.Name)
        Next

        For Each user As User In users
            Dim users_datasource_row = users_datasource.NewRow()
            users_datasource_row("id") = user.user_id
            users_datasource_row("username") = user.username
            users_datasource_row("password") = user.password
            users_datasource_row("userlevel") = If(
                user.userlevel = 0,
                "Administrator",
                "Customer"
            )

            bsrcUsers.Add(users_datasource_row)
            users_datasource.Rows.Add(users_datasource_row)
        Next

        Dim users_binding_source As New BindingSource With {
            .DataSource = users_datasource
        }
        bnavUsers.BindingSource = users_binding_source
        dgvUsers.DataSource = users_binding_source
    End Sub

    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click
        Throw New Exception("ReturnToDashboard")
    End Sub

    Private Sub ProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfileToolStripMenuItem.Click
        Dim user_profile = New UserProfile(user_info)
        user_profile.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Throw New Exception("LoginRequired")
    End Sub
End Class
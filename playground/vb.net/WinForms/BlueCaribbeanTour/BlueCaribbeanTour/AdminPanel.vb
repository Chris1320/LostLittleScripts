﻿Imports System.Net

Public Class AdminPanel
    Private user_info As User

    Sub New(user_info As User)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user_info = user_info
    End Sub

    Public Sub updateUsers()
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

    Private Sub AdminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateUsers()
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

    Private Sub dgvUsers_SelectionChanged(sender As Object, e As EventArgs) Handles dgvUsers.SelectionChanged
        txtSelectedUser.Text = dgvUsers.CurrentRow.Cells("username").Value
        btnPromoteOrDemoteUser.Text = If(
            dgvUsers.CurrentRow.Cells("userlevel").Value = "Administrator",
            "Demote User",
            "Promote User"
        )
    End Sub

    Private Sub btnKickUser_Click(sender As Object, e As EventArgs) Handles btnKickUser.Click
        If user_info.user_id = dgvUsers.CurrentRow.Cells("id").Value Then
            MessageBox.Show(
                "You cannot kick yourself!",
                "Kick User",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
            Return
        End If

        If MessageBox.Show(
            "Are you sure you want to kick this user?",
            "Kick User",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        ) = DialogResult.Yes Then
            Dim user_manager = New UserManager()
            Dim user_id = dgvUsers.CurrentRow.Cells("id").Value
            If user_manager.kickUser(user_id) Then
                MessageBox.Show(
                    "User has been kicked",
                    "Kick User",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )
            End If
            updateUsers()
        End If
    End Sub

    Private Sub btnPromoteOrDemoteUser_Click(sender As Object, e As EventArgs) Handles btnPromoteOrDemoteUser.Click
        If dgvUsers.CurrentRow.Cells("userlevel").Value = "Administrator" Then
            If user_info.user_id = dgvUsers.CurrentRow.Cells("id").Value Then
                MessageBox.Show(
                    "You cannot demote yourself here! Use the demote button in the Profile page instead.",
                    "Demote User",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )
                Return
            End If

            If MessageBox.Show(
                "Are you sure you want to demote this user?",
                "Demote User",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            ) = DialogResult.Yes Then
                Dim user_manager = New UserManager()
                Dim target_user_id = dgvUsers.CurrentRow.Cells("id").Value
                If user_manager.setUserLevel(target_user_id, 1) Then
                    MessageBox.Show(
                        "User has been demoted",
                        "Demote User",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    )
                End If
            End If
        Else
            If MessageBox.Show(
                "Are you sure you want to promote this user?",
                "Promote User",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            ) = DialogResult.Yes Then
                Dim user_manager = New UserManager()
                Dim target_user_id = dgvUsers.CurrentRow.Cells("id").Value
                If user_manager.setUserLevel(target_user_id, 0) Then
                    MessageBox.Show(
                    "User has been promoted",
                    "Promote User",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )
                End If
            End If
        End If
        updateUsers()
    End Sub
End Class
﻿Public Class Dashboard
    Private kill_parent As Boolean = True
    Private selected_tour_length As Integer?
    Private total_cost As Double = 0

    Public Sub resetForm()
        listTours.SelectedItems.Clear()
        rbtnDays7.Checked = False
        rbtnDays14.Checked = False
        numPeople.Value = 1
        dateDeparture.Value = DateTime.Now.AddDays(Info.minimum_preregistration)
        comboModeOfPayment.SelectedIndex = -1
        lblTotalCost.Text = "N/A"
    End Sub

    Private Sub computeTotalCost()
        If listTours.SelectedIndex = -1 Then : Return
        ElseIf Not rbtnDays7.Checked And Not rbtnDays14.Checked Then : Return
        End If

        Me.total_cost = Info.tour_prices(listTours.SelectedItem)(Me.selected_tour_length) * numPeople.Value
        lblTotalCost.Text = Me.total_cost.ToString("C")
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim user_manager = New UserManager()
        AdminToolStripMenuItem.Visible = user_manager.getUserLevel(
            user_manager.usernameToID(lblUsername.Text)
        ) = 0

        ' Update the list of tours
        listTours.Items.Clear()
        For Each tour As String In Info.tour_prices.Keys
            listTours.Items.Add(tour)
        Next

        ' Update the list of modes of payment
        comboModeOfPayment.Items.Clear()
        For Each mode As String In Info.modes_of_payment
            comboModeOfPayment.Items.Add(mode)
        Next

        dateDeparture.MinDate = DateTime.Now.AddDays(Info.minimum_preregistration)
    End Sub

    Public Sub setUsername(username As String)
        lblUsername.Text = If(
            username.Length > 10,
            $"{username.Substring(0, 10)}...",
            username
        )
    End Sub

    Private Sub Dashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.kill_parent Then : LoginForm.Close()
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.kill_parent = False
        Me.Dispose()
        LoginForm.cleanUp()
        LoginForm.Show()
    End Sub

    Private Sub rbtnDays7_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnDays7.CheckedChanged
        Me.selected_tour_length = 0
        Me.computeTotalCost()
    End Sub

    Private Sub rbtnDays14_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnDays14.CheckedChanged
        Me.selected_tour_length = 1
        Me.computeTotalCost()
    End Sub

    Private Sub btnReserve_Click(sender As Object, e As EventArgs) Handles btnReserve.Click
        ' Check if all fields are filled.
        If listTours.SelectedIndex = -1 Then
            MessageBox.Show(
                "Please select a tour location.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
            Return

        ElseIf Not rbtnDays7.Checked And Not rbtnDays14.Checked Then
            MessageBox.Show(
                "Please select a tour length.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
            Return

        ElseIf comboModeOfPayment.SelectedIndex = -1 Then
            MessageBox.Show(
                "Please select a mode of payment.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
            Return
        End If

        Dim reservation_manager = New ReservationManager()
        Dim user_manager = New UserManager()
        If reservation_manager.addReservation(
            user_manager.usernameToID(lblUsername.Text),
            listTours.SelectedItem,
            numPeople.Value,
            dateDeparture.Value,
            If(Me.selected_tour_length = 1, 14, 7),
            comboModeOfPayment.SelectedItem,
            Me.total_cost
        ) Then
            MessageBox.Show(
                "Reservation successful!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )
            Me.resetForm()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Me.resetForm()
    End Sub

    Private Sub listTours_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listTours.SelectedIndexChanged
        Me.computeTotalCost()
    End Sub

    Private Sub numPeople_ValueChanged(sender As Object, e As EventArgs) Handles numPeople.ValueChanged
        Me.computeTotalCost()
    End Sub

    Private Sub dateDeparture_ValueChanged(sender As Object, e As EventArgs) Handles dateDeparture.ValueChanged
        Me.computeTotalCost()
    End Sub
End Class
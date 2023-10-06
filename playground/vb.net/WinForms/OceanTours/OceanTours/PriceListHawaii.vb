Public Class PriceListHawaii
    Private Sub PriceListHawaii_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        LandingPage.Show()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Hide()
        LandingPage.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        LandingPage.Close()
    End Sub

    Private Sub btnReserve_Click(sender As Object, e As EventArgs) Handles btnReserve.Click
        Me.Hide()
        SlotReservationForm.resetForm("Hawaii")
        SlotReservationForm.ShowDialog()
    End Sub
End Class
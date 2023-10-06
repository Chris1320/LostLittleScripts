Public Class PriceListJamaica
    Private Sub PriceListJamaica_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        SlotReservationForm.resetForm("Jamaica")
        SlotReservationForm.ShowDialog()
    End Sub
End Class
Public Class LandingPage
    Private Sub LandingPage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        LoginForm.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If MessageBox.Show(
            "Are you sure you want to close the program?",
            "Close Program",
            MessageBoxButtons.YesNo
        ) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.ShowDialog()
    End Sub

    Private Sub HawaiiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HawaiiToolStripMenuItem.Click
        Me.Hide()
        PriceListHawaii.ShowDialog()
    End Sub

    Private Sub JamaicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JamaicaToolStripMenuItem.Click
        Me.Hide()
        PriceListJamaica.ShowDialog()
    End Sub

    Private Sub MaldivesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaldivesToolStripMenuItem.Click
        Me.Hide()
        PriceListMaldives.ShowDialog()
    End Sub
End Class
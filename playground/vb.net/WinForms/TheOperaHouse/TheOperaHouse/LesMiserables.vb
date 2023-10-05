Public Class LesMiserables
    Private Sub LesMiserables_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        PlaySelection.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
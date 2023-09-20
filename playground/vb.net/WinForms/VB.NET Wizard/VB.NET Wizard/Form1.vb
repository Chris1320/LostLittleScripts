Public Class Form1
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        ' You can use the Show and Hide methods to show and hide controls.
        pboxWizard.Show()
        lblMissingWizard.Hide()
    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        ' You can also set the Visible property to a boolean value.
        pboxWizard.Visible = False
        lblMissingWizard.Visible = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Show a message dialog saying that the program is exiting.
        MessageBox.Show("Goodbye!")
        Me.Close()  ' Close the window. Me is equivalent to this in other languages.
    End Sub
End Class

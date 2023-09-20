Public Class Form1
    Private Sub txtHours_TextChanged(sender As Object, e As EventArgs) Handles txtHours.TextChanged
        txtTotalMinutes.Text = Val(txtHours.Text) * 60 + Val(txtMinutes.Text)
    End Sub

    Private Sub txtMinutes_TextChanged(sender As Object, e As EventArgs) Handles txtMinutes.TextChanged
        txtTotalMinutes.Text = Val(txtHours.Text) * 60 + Val(txtMinutes.Text)
    End Sub
End Class

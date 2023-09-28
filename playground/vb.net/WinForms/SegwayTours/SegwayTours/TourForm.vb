Public Class TourForm
    Dim tour_prices As Double() = {79.99, 69.99}
    Dim discount_type As Double() = {0.0, 0.1, 0.2, 0.25}

    Private Sub TourForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Close the application when the form is closed.
        Application.Exit()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstDiscountType.SelectedIndex = -1
        comboTourType.SelectedIndex = -1
        txtNumberOfTickets.Clear()
        txtResult.Clear()
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Try
            Dim total_prices = tour_prices(comboTourType.SelectedIndex) * Val(txtNumberOfTickets.Text)
            Dim discount = total_prices * discount_type(lstDiscountType.SelectedIndex)
            txtResult.Text = (total_prices - discount).ToString("C2")
        Catch ex As Exception
            MessageBox.Show("Please enter valid information.")
        End Try
    End Sub
End Class

Public Class BillSummary
    Public total_price As Double
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Me.Dispose()
    End Sub

    Private Sub txtPayment_TextChanged(sender As Object, e As EventArgs) Handles txtPayment.TextChanged
        lblChange.Text = $"PHP {Val(txtPayment.Text) - total_price}"
    End Sub
End Class
Public Class TollCharge
    Private charge_per_km As Integer?
    Private kilometers As Integer?

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Check if charge_per_km and kilometers are set
        If charge_per_km Is Nothing Or kilometers Is Nothing Then
            MessageBox.Show("Please select a vehicle type and a road type.")
            Return
        End If

        ' Calculate the toll charge
        txtResult.Text = String.Format("PHP {0}", charge_per_km * kilometers)
    End Sub

    Private Sub rbtnCar_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnCar.CheckedChanged
        charge_per_km = 10.0
    End Sub

    Private Sub rbtnLightTruck_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnLightTruck.CheckedChanged
        charge_per_km = 15.0
    End Sub

    Private Sub rbtnHeavyTruck_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnHeavyTruck.CheckedChanged
        charge_per_km = 25.0
    End Sub

    Private Sub rbtnYellow_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnYellow.CheckedChanged
        kilometers = 20.0
    End Sub

    Private Sub rbtnBlue_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnBlue.CheckedChanged
        kilometers = 25.0
    End Sub

    Private Sub rbtnRed_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnRed.CheckedChanged
        kilometers = 30.0
    End Sub
End Class

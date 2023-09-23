Public Class NumToMonth
    ' Create an array of a list of months.
    Private months() As String = {
        "N/A",  ' Add this to the array as the default value.
        "January", "February", "March",
        "April", "May", "June",
        "July", "August", "September",
        "October", "November", "December"
    }

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        txtResult.Text = months(numToCheck.Value)
    End Sub
End Class

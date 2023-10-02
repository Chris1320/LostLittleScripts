Public Class MultiplicationTables
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim number As Integer

        If Integer.TryParse(txtInput.Text, number) Then
            If number < 1 Or number > 12 Then
                MessageBox.Show("Please enter a number between 1 and 12.")
                Return
            End If

            listResult.Items.Clear()
            For i As Integer = 1 To 12 : listResult.Items.Add($"{number} x {i} = {number * i}")
            Next
        Else : MessageBox.Show("Please enter a valid number.")
        End If
    End Sub
End Class

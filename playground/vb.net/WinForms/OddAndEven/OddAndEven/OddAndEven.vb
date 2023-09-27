Public Class OddAndEven
    ' Clear the form. If resultsOnly is true, only clear the results.
    Private Sub clearForm(Optional resultsOnly As Boolean = False)
        If Not resultsOnly Then
            numFirstNumber.Value = 0
            numSecondNumber.Value = 0
        End If
        listEvenNumbers.Items.Clear()
        listOddNumbers.Items.Clear()
        barComputationProgress.Maximum = 2147483647  ' Max value of a 32-bit integer.
        barComputationProgress.Minimum = 0
        barComputationProgress.Value = 0
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        clearForm(True)  ' Clear the results only.
        barComputationProgress.Maximum = numSecondNumber.Value
        barComputationProgress.Minimum = numFirstNumber.Value
        barComputationProgress.Value = numFirstNumber.Value

        For i As Integer = numFirstNumber.Value To numSecondNumber.Value
            barComputationProgress.Value = i
            If i Mod 2 = 0 Then : listEvenNumbers.Items.Add(i)
            Else : listOddNumbers.Items.Add(i)
            End If
        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearForm()
    End Sub
End Class

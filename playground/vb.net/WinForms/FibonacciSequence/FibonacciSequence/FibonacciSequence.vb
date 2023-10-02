Public Class FibonacciSequence
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim limit As Integer
        Integer.TryParse(txtLimit.Text, limit)
        If limit <= 0 Then : MessageBox.Show("Please enter a positive integer.")
        End If
        ' Print the Fibonacci sequence that are less than or equal to the limit.
        listResult.Items.Clear()
        listResult.Items.Add(0)
        listResult.Items.Add(1)
        listResult.Items.Add(1)
        While listResult.Items(listResult.Items.Count - 1) + listResult.Items(listResult.Items.Count - 2) <= limit
            listResult.Items.Add(listResult.Items(listResult.Items.Count - 1) + listResult.Items(listResult.Items.Count - 2))
        End While
    End Sub
End Class

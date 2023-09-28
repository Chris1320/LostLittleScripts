Public Class Form1
    Private Sub numRepeat_ValueChanged(sender As Object, e As EventArgs) Handles numRepeat.ValueChanged
        listResult.Items.Clear()
        For i As Integer = 1 To numRepeat.Value
            progress.Value = i / numRepeat.Value * 100
            listResult.Items.Add(txtName.Text)
        Next
    End Sub
End Class

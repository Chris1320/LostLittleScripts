Public Class Triangles
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim layers As Integer
        Integer.TryParse(txtLayers.Text, layers)
        If layers > 0 Then
            Dim triangle As String = ""
            ' vbCrLf is the same as Environment.NewLine
            For i As Integer = 1 To layers : triangle &= New String("*", i) & vbCrLf
            Next
            txtResult.Text = triangle
        Else : txtResult.Text = "Invalid input"
        End If
    End Sub
End Class

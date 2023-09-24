Public Class SalesCommission
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim percentage As Double? = Nothing  ' Set it to null

        Select Case Val(txtInput.Text)
            Case 0 To 30000 : percentage = 0.02
            Case 30001 To 60000 : percentage = 0.03
            Case 60001 To 90000 : percentage = 0.04
            Case 90001 To 120000 : percentage = 0.06
            Case 120001 To 150000 : percentage = 0.08
            Case Is > 150000 : percentage = 0.1
            Case Else : MsgBox("Please enter a valid total sale.")
        End Select

        If percentage IsNot Nothing Then
            txtResult.Text = Format(Val(txtInput.Text) * percentage, "Currency")
        End If
    End Sub
End Class

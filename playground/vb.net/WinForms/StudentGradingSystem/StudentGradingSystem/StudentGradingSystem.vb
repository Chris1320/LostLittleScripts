Public Class StudentGradingSystem
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case numStudentGrade.Value
            Case 0 To 59
                lblResult.Text = "5.00"
            Case 60 To 69
                lblResult.Text = "4.00"
            Case 70 To 79
                lblResult.Text = "3.00"
            Case 80 To 89
                lblResult.Text = "2.00"
            Case 90 To 100
                lblResult.Text = "1.00"
                ' We don't need to add a default case because
                ' because the possible value is thin 0 to 100.
        End Select
    End Sub
End Class

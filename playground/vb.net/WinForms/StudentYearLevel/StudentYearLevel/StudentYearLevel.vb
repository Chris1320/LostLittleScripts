Public Class StudentYearLevel
    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Select Case Val(txtInput.Text)
            Case 1 : lblResult.Text = "Freshman"
            Case 2 : lblResult.Text = "Sophomore"
            Case 3 : lblResult.Text = "Junior2"
            Case 4 : lblResult.Text = "Senior"
            Case Else : lblResult.Text = "Invalid Entry"
        End Select
    End Sub
End Class

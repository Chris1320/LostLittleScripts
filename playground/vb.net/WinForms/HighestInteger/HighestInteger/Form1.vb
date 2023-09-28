Public Class Form1
    Dim highest As Double = Nothing
    Dim free As Integer = 10

    Private Sub add()
        Dim value As Double
        ' Only allow up to 10 items in the listbox.
        If free < 1 Then : MessageBox.Show("The list is full.")
        End If

        ' Check if the input is a number.
        If IsNumeric(txtNum.Text) Then : value = CDbl(txtNum.Text)
        Else
            MessageBox.Show("Please enter a number.")
            Return
        End If

        If highest = Nothing Or highest < value Then
            highest = value
            lblHighest.Text = String.Format("The highest number is {0}.", highest)
        End If

        ' Add the number to the listbox.
        listNums.Items.Add(value)
        txtNum.Clear()
        free -= 1
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        add()
    End Sub

    Private Sub txtNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNum.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            add()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        free = 10
        highest = Nothing
        txtNum.Clear()
        listNums.Items.Clear()
        lblHighest.Text = "There are no numbers in the list."
    End Sub
End Class

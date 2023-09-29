Imports Microsoft.VisualBasic.Devices

Public Class Form1
    Private Sub compute()
        Dim unitPrice As Double = Val(txtUnitPrice.Text)
        Dim unitQuantity As Double = Val(txtUnitQuantity.Text)
        Dim discount As Double

        ' Disallow negative values in unitPrice and unitQuantity.
        If unitPrice < 0 Then
            MessageBox.Show(
                "Unit price cannot be negative.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End If

        Select Case unitQuantity
            Case 1 To 10 : discount = 0.01
            Case 11 To 100 : discount = 0.08
            Case Is > 100 : discount = 0.1
        End Select

        txtFullCost.Text = unitPrice * unitQuantity
        txtTotalDiscount.Text = txtFullCost.Text * discount
        ' You can perform arithmetic operations on strings???
        ' WHAT?!?
        txtFinalPrice.Text = txtFullCost.Text - txtTotalDiscount.Text
    End Sub

    Private Sub txtUnitPrice_TextChanged(sender As Object, e As EventArgs) Handles txtUnitPrice.TextChanged
        compute()
    End Sub

    Private Sub txtUnitQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtUnitQuantity.TextChanged
        compute()
    End Sub
End Class

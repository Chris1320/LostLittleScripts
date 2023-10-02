Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        numDeposit.Maximum = Decimal.MaxValue
        numInterest.Maximum = Decimal.MaxValue
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        numDeposit.Value = 0
        numInterest.Value = 0
        txtResultTotal.Text = String.Empty
        txtResultInterest.Text = String.Empty
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim principal As Decimal = numDeposit.Value
        Dim rate As Decimal = numInterest.Value

        ' Formula: A = P(1 + r/n) ^ nt
        Dim total_amount = principal * ((1 + (rate / 100)) ^ 3)
        Dim interest_earned = total_amount - principal

        txtResultTotal.Text = total_amount.ToString("C")
        txtResultInterest.Text = interest_earned.ToString("C")
    End Sub
End Class

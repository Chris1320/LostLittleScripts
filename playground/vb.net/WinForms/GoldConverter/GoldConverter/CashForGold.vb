Public Class CashForGold
    ' This is the price per ounce of gold found using the
    ' example in the image. ($4669.95 / 3oz)
    Const PRICE_PER_OUNCE As Double = 1556.583333333333

    Private Sub comboMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboMode.SelectedIndexChanged
        ' Update the elements depending on
        ' the user's selected mode.
        Select Case comboMode.SelectedIndex
            Case 0  ' No mode selected
                lblInput.Visible = False
                txtInput.Visible = False
                btnProcess.Visible = False
                btnClearForm.Visible = False
                txtResult.Visible = False

            Case 1  ' Calculate the amount earned based on gold collected.
                lblInput.Text = "Ounces Collected:"
                btnProcess.Text = "Find Amount Earned"
                txtInput.Text = String.Empty
                txtResult.Text = String.Empty

                lblInput.Visible = True
                txtInput.Visible = True
                btnProcess.Visible = True
                btnClearForm.Visible = True
                txtResult.Visible = True

            Case 2  ' Calculate amount of gold needed to make target goal
                lblInput.Text = "Target Goal Amount:"
                btnProcess.Text = "Find Target Amount of Gold"
                txtInput.Text = String.Empty
                txtResult.Text = String.Empty

                lblInput.Visible = True
                txtInput.Visible = True
                btnProcess.Visible = True
                btnClearForm.Visible = True
                txtResult.Visible = True

            Case Else
                MessageBox.Show(
                    "Please select a mode.",
                    "No Mode Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )
        End Select
    End Sub

    Private Sub btnClearForm_Click(sender As Object, e As EventArgs) Handles btnClearForm.Click
        comboMode.SelectedIndex = 0
    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        Select Case comboMode.SelectedIndex
            ' Do not add a case for 0 because
            ' it is not a valid mode.
            Case 1
                Dim result As Double = Val(txtInput.Text) * PRICE_PER_OUNCE
                txtResult.Text = $"${result:F2} will be earned by selling the gold."

            Case 2
                Dim result As Double = Val(txtInput.Text) / PRICE_PER_OUNCE
                txtResult.Text = $"{result:F3} ounces of gold are needed to reach your goal."

            Case Else
                MessageBox.Show(
                    "Please select a mode.",
                    "No Mode Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )
        End Select
    End Sub
End Class
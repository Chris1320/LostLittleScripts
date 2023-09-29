Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim answer = MessageBox.Show(
            "Are you sure you want to exit?",
            "Exit",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )
        If answer = DialogResult.Yes Then : Application.Exit()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFeet.Clear()
        txtYards.Clear()
        txtInches.Clear()
        txtCentimeters.Clear()
        txtMeters.Clear()
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        txtYards.Text = (Val(txtFeet.Text) / 3.0)
        txtInches.Text = (Val(txtFeet.Text) * 12.0)
        txtCentimeters.Text = (Val(txtFeet.Text) * 30.48)
        txtMeters.Text = (Val(txtFeet.Text) * 0.3048)
    End Sub
End Class

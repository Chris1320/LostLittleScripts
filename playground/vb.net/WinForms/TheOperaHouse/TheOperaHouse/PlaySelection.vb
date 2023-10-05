Public Class PlaySelection
    Const TAX_RATE As Double = 0.12

    ' Arrangement: Lion King, Les Miserables, Phantom of the Opera
    Dim prices(,) As Double = {
        {135, 149, 128},  ' Orchestra
        {92, 98, 82}  ' Mezzanine
    }

    Private Sub PlaySelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboSelectPlay.SelectedIndex = 0
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()  ' Close the form
    End Sub

    Private Sub LionKingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LionKingToolStripMenuItem.Click
        Me.Hide()
        LionKing.ShowDialog()
    End Sub

    Private Sub LesMiserablesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LesMiserablesToolStripMenuItem.Click
        Me.Hide()
        LesMiserables.ShowDialog()
    End Sub

    Private Sub PhantomOfTheOperaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhantomOfTheOperaToolStripMenuItem.Click
        Me.Hide()
        PhantomOfTheOpera.ShowDialog()
    End Sub

    Private Sub comboSelectPlay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboSelectPlay.SelectedIndexChanged
        Select Case comboSelectPlay.SelectedIndex
            Case 0
                lblPax.Visible = False
                txtPax.Visible = False
                rbtnOrchestra.Visible = False
                rbtnMezzanine.Visible = False
                btnCompute.Visible = False
                btnClear.Visible = False

                lblTotalKey.Visible = False
                lblTaxKey.Visible = False
                lblSubtotalKey.Visible = False
                lblTotal.Visible = False
                lblTax.Visible = False
                lblSubtotal.Visible = False

            Case 1, 2, 3
                ' Clear the form
                txtPax.Text = String.Empty
                rbtnOrchestra.Checked = False
                rbtnMezzanine.Checked = False

                ' Show the form if it is hidden
                lblPax.Visible = True
                txtPax.Visible = True
                rbtnOrchestra.Visible = True
                rbtnMezzanine.Visible = True
                btnCompute.Visible = True
                btnClear.Visible = True
        End Select
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        comboSelectPlay.SelectedIndex = 0
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim selected_play As Integer = comboSelectPlay.SelectedIndex - 1
        Dim pax As Integer = Val(txtPax.Text)

        Dim selected_seat As Integer
        If rbtnOrchestra.Checked Then : selected_seat = 0
        ElseIf rbtnMezzanine.Checked Then : selected_seat = 1
        Else
            MessageBox.Show(
                "Please select a seat type.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
            Return
        End If

        Dim subtotal As Double = prices(selected_seat, selected_play) * pax
        Dim tax As Double = subtotal * TAX_RATE
        Dim total As Double = subtotal + tax

        lblTotal.Text = $"PHP {total:F2}"
        lblTax.Text = $"PHP {tax:F2}"
        lblSubtotal.Text = $"PHP {subtotal:F2}"

        lblTotalKey.Visible = True
        lblTaxKey.Visible = True
        lblSubtotalKey.Visible = True
        lblTotal.Visible = True
        lblTax.Visible = True
        lblSubtotal.Visible = True
    End Sub
End Class

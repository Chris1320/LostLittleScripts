Public Class SlotReservationForm
    Dim locations() As Location = {
        New Location(
            "Hawaii",
            {
                New Tour("Deep Sea Fishing", 8, 199),
                New Tour("Kayaking", 2, 89),
                New Tour("Scuba Diving", 3, 119),
                New Tour("Snorkeling", 4, 89)
            }
        ),
        New Location(
            "Jamaica",
            {
                New Tour("Glass Bottom Boat", 2, 39),
                New Tour("Parasailing", 2, 119),
                New Tour("Snorkeling", 2, 59)
            }
        ),
        New Location(
            "Maldives",
            {
                New Tour("Deep Sea Fishing", 4, 89),
                New Tour("Glass Bottom Boat", 2, 29),
                New Tour("Scuba Diving", 3, 119),
                New Tour("Snorkeling", 3, 591)
            }
        )
    }

    ' Reset the form to its default state, with optional default selection.
    Public Sub resetForm(Optional ByVal default_selection As String = Nothing)
        comboLocation.Items.Clear()
        comboLocation.Items.Add("Select Tour")
        numPersonQuantity.Value = 1

        ' Add all locations to the combo box.
        For Each location As Location In locations : comboLocation.Items.Add(location.name)
        Next

        If default_selection IsNot Nothing Then : setSelectedLocation(default_selection)
        Else : comboLocation.SelectedIndex = 0
        End If

        refreshFormElements()
    End Sub

    ' Refresh the elements of the form based on the selected location.
    Public Sub refreshFormElements()
        lblPax.Visible = Not comboLocation.SelectedIndex < 1
        lblPaxUnit.Visible = Not comboLocation.SelectedIndex < 1
        numPersonQuantity.Visible = Not comboLocation.SelectedIndex < 1
        picPaxBorder.Visible = Not comboLocation.SelectedIndex < 1

        lblTour.Visible = Not comboLocation.SelectedIndex < 1
        listTours.Visible = Not comboLocation.SelectedIndex < 1
        picToursList.Visible = Not comboLocation.SelectedIndex < 1

        btnFindCost.Visible = Not comboLocation.SelectedIndex < 1
        btnClear.Visible = Not comboLocation.SelectedIndex < 1

        lblResultTour.Visible = False
        lblResultCost.Visible = False
        lblResultLength.Visible = False
        lblResultTourValue.Visible = False
        lblResultCostValue.Visible = False
        lblResultLengthValue.Visible = False

        If comboLocation.SelectedIndex < 1 Then : Return
        End If
        Dim location_index As Integer = comboLocation.SelectedIndex - 1

        listTours.Items.Clear()
        For Each tour As Tour In locations(location_index).tours
            listTours.Items.Add(tour.type)
        Next
    End Sub

    Public Sub setSelectedLocation(desired_location As String)
        ' Set the selected location in the combo box.
        comboLocation.SelectedIndex = comboLocation.FindString(desired_location)
        comboLocation.Text = desired_location
    End Sub

    Private Sub SlotReservationForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        LandingPage.Show()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Hide()
        LandingPage.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        LandingPage.Close()
    End Sub

    Private Sub SlotReservationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshFormElements()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        resetForm()
    End Sub

    Private Sub comboLocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboLocation.SelectedIndexChanged
        refreshFormElements()
    End Sub

    Private Sub btnFindCost_Click(sender As Object, e As EventArgs) Handles btnFindCost.Click
        If listTours.SelectedIndex < 0 Then
            MessageBox.Show(
                "Please select a tour.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
            Return
        End If

        Dim location As Location = locations(comboLocation.SelectedIndex - 1)
        Dim selected_tour As Tour = location.tours(listTours.SelectedIndex)
        lblResultTourValue.Text = selected_tour.type
        lblResultCostValue.Text = $"${selected_tour.price * numPersonQuantity.Value}"
        lblResultLengthValue.Text = $"{selected_tour.length} hours"

        lblResultTour.Visible = True
        lblResultCost.Visible = True
        lblResultLength.Visible = True
        lblResultTourValue.Visible = True
        lblResultCostValue.Visible = True
        lblResultLengthValue.Visible = True
    End Sub
End Class
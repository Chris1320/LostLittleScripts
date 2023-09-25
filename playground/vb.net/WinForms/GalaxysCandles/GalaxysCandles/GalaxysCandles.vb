Public Class GalaxysCandles
    Const TAX As Double = 0.08  ' 8%
    Const SHIPPING_FEE As Double = 0.03  ' 3%
    ' Arrangement: Tea Light, Votive, Pillar
    Dim base_prices() As Double = {5.75, 7.5, 12.25}
    Dim scented_prices() As Double = {0.75, 1.25, 1.75}

    Dim candle_style As String = Nothing
    Dim candle_color As String = Nothing

    Private Sub updateDisplayImage()
        Select Case candle_style
            Case "Tea Light"
                Select Case listCandleColor.SelectedIndex
                    Case 0 : picCandlePreview.Image = My.Resources.candle_tea_light_federal_blue
                    Case 1 : picCandlePreview.Image = My.Resources.candle_tea_light_sunflower_yellow
                    Case 2 : picCandlePreview.Image = My.Resources.candle_tea_light_christmas_red
                    Case 3 : picCandlePreview.Image = My.Resources.candle_tea_light_lily_white
                    Case Else : picCandlePreview.Image = My.Resources.candle_tea_light_clear
                End Select
            Case "Votive"
                Select Case listCandleColor.SelectedIndex
                    Case 0 : picCandlePreview.Image = My.Resources.candle_votive_federal_blue
                    Case 1 : picCandlePreview.Image = My.Resources.candle_votive_sunflower_yellow
                    Case 2 : picCandlePreview.Image = My.Resources.candle_votive_christmas_red
                    Case 3 : picCandlePreview.Image = My.Resources.candle_votive_lily_white
                    Case Else : picCandlePreview.Image = My.Resources.candle_votive_clear
                End Select
            Case "Pillar"
                Select Case listCandleColor.SelectedIndex
                    Case 0 : picCandlePreview.Image = My.Resources.candle_pillar_federal_blue
                    Case 1 : picCandlePreview.Image = My.Resources.candle_pillar_sunflower_yellow
                    Case 2 : picCandlePreview.Image = My.Resources.candle_pillar_christmas_red
                    Case 3 : picCandlePreview.Image = My.Resources.candle_pillar_lily_white
                    Case Else : picCandlePreview.Image = My.Resources.candle_pillar_clear
                End Select
            Case Else
                picCandlePreview.Image = Nothing
        End Select
    End Sub

    Private Sub btnShowItemPrices_Click(sender As Object, e As EventArgs) Handles btnShowItemPrices.Click
        ShowItemPrices.ShowDialog()
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Dim base_price As Double
        Dim scented_price As Double
        Dim subtotal As Double
        Dim order_shipping_fee As Double
        Dim order_tax As Double
        Dim total_due As Double
        Dim quantity As Double = Val(txtQuantity.Text)

        ' Check if full name isn't provided.
        If txtFullName.Text = Nothing Then
            MessageBox.Show("Please enter your full name.")
            Return
        End If

        ' Check if address isn't provided.
        If txtAddress.Text = Nothing Then
            MessageBox.Show("Please enter your address.")
            Return
        End If

        ' Check if contact number isn't provided.
        If txtContactNumber.Text = Nothing Then
            MessageBox.Show("Please enter your contact number.")
            Return
        End If

        ' Check if candle style is selected
        Select Case candle_style
            Case "Tea Light"
                base_price = base_prices(0)
                scented_price = If(checkScented.Checked, scented_prices(0), 0)

            Case "Votive"
                base_price = base_prices(1)
                scented_price = If(checkScented.Checked, scented_prices(1), 0)

            Case "Pillar"
                base_price = base_prices(2)
                scented_price = If(checkScented.Checked, scented_prices(2), 0)

            Case Else
                MessageBox.Show("Please select a candle style.")
                Return
        End Select

        ' Check which candle color is selected in the listCandleColor listbox
        If listCandleColor.SelectedIndex = 0 Then : candle_color = "Federal Blue"
        ElseIf listCandleColor.SelectedIndex = 1 Then : candle_color = "Sunflower Yellow"
        ElseIf listCandleColor.SelectedIndex = 2 Then : candle_color = "Christmas Red"
        ElseIf listCandleColor.SelectedIndex = 3 Then : candle_color = "Lily White"
        Else
            MessageBox.Show("Please select a candle color.")
            Return
        End If

        ' Check if quantity is provided
        If txtQuantity.Text = Nothing Or quantity <= 0 Then
            MessageBox.Show("Please enter how many candles you want to order.")
            Return
        End If

        ' Calculate for the prices.
        subtotal = (base_price + scented_price) * quantity
        order_shipping_fee = subtotal * SHIPPING_FEE
        order_tax = subtotal * TAX
        total_due = subtotal + order_shipping_fee + order_tax

        ' Show the order summary
        Summary.txtCustomerName.Text = txtFullName.Text
        Summary.txtAddress.Text = txtAddress.Text
        Summary.txtContactNumber.Text = txtContactNumber.Text

        Summary.txtCandleStyle.Text = candle_style
        Summary.txtCandleColor.Text = candle_color
        Summary.txtQuantity.Text = txtQuantity.Text
        Summary.txtScented.Text = If(checkScented.Checked, "Yes", "No")

        Summary.txtShippingFee.Text = order_shipping_fee.ToString("C")
        Summary.txtTax.Text = order_tax.ToString("C")
        Summary.txtScentedPrice.Text = scented_price.ToString("C")
        Summary.txtSubtotal.Text = subtotal.ToString("C")
        Summary.txtTotalDue.Text = total_due.ToString("C")
        Summary.ShowDialog()

        ' Ask the user if they want to order again
        Dim result As DialogResult = MessageBox.Show(
            "Do you want to order again?",
            "Galaxy's Candles",
            MessageBoxButtons.YesNo,  ' Show Yes and No buttons
            MessageBoxIcon.Question  ' Show a question mark icon
        )
        If result = DialogResult.Yes Then
            ' Clear all the fields
            txtFullName.Text = Nothing
            txtAddress.Text = Nothing
            txtContactNumber.Text = Nothing
            listCandleColor.SelectedIndex = -1
            txtQuantity.Text = Nothing
            btnTeaLight.Checked = False
            btnVotive.Checked = False
            btnPillar.Checked = False
            candle_style = Nothing
            candle_color = Nothing

        Else
            ' Close the application
            Me.Close()

        End If
    End Sub

    Private Sub btnTeaLight_CheckedChanged(sender As Object, e As EventArgs) Handles btnTeaLight.CheckedChanged
        candle_style = "Tea Light"
        updateDisplayImage()
    End Sub

    Private Sub btnVotive_CheckedChanged(sender As Object, e As EventArgs) Handles btnVotive.CheckedChanged
        candle_style = "Votive"
        updateDisplayImage()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles btnPillar.CheckedChanged
        candle_style = "Pillar"
        updateDisplayImage()
    End Sub

    Private Sub GalaxysCandles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picScented.Visible = checkScented.Checked
    End Sub

    Private Sub checkScented_CheckedChanged(sender As Object, e As EventArgs) Handles checkScented.CheckedChanged
        picScented.Visible = checkScented.Checked
    End Sub

    Private Sub listCandleColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listCandleColor.SelectedIndexChanged
        updateDisplayImage()
    End Sub
End Class

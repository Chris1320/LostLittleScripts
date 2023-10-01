Public Class VirtualBrewCafe
    Const TAX As Double = 0.12
    Dim total_price As Double = 0
    Dim items(,) As String = {
            {"Pancake ", "Hotdog", "Bread", "Cake", "Egg"},
            {"Chicken", "Beef and Mushroom", "Pork Steak", "Spaghetti", "Rice"},
            {"Chicken", "Beef and Mushroom", "Pork Adobo", "Rice", "Chocolate"}
        }
    Dim item_prices(,) As Double = {
            {110.0, 40.0, 45.0, 75.0, 20.0},
            {150.0, 170.0, 120.0, 90.0, 30.0},
            {150.0, 170.0, 130.0, 30.0, 250.0}
    }

    Private Sub updateTotalPrice()
        ' Update the total price.
        total_price = 0
        For Each row As DataGridViewRow In dgOrderList.Rows : total_price += row.Cells(2).Value
        Next

        ' Display the total price.
        txtTotal.Text = $"PHP {total_price:F2}"
    End Sub

    Private Sub addOrUpdateOrder(ByVal item As String, ByVal index As Integer, ByVal quantity As Integer)
        ' Do not add the order if the quantity is 0.
        If quantity = 0 Then : Return
        End If

        ' Add the order to item_quantities, total_prices, & dgOrderList datagridview.
        Dim additional_price As Double = quantity * item_prices(comboMenuType.SelectedIndex, index)

        ' Check if the item is already in the datagridview.
        Dim item_found As Boolean = False
        For Each row As DataGridViewRow In dgOrderList.Rows
            If row.Cells(0).Value = item Then
                item_found = True
                ' Update the quantity and total price.
                row.Cells(1).Value += quantity
                row.Cells(2).Value += additional_price
            End If
        Next

        ' Add the item to the datagridview
        ' if it is not yet in the datagridview.
        If Not item_found Then : dgOrderList.Rows.Add(item, quantity, additional_price)
        End If

        updateTotalPrice()
    End Sub

    Private Sub VirtualBrewCafe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the default menu type.
        comboMenuType.SelectedIndex = 0
        comboMenuType.Text = comboMenuType.SelectedItem.ToString()
    End Sub

    Private Sub comboMenuType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboMenuType.SelectedIndexChanged
        btnOrderButton1.Text = items(comboMenuType.SelectedIndex, 0)
        btnOrderButton2.Text = items(comboMenuType.SelectedIndex, 1)
        btnOrderButton3.Text = items(comboMenuType.SelectedIndex, 2)
        btnOrderButton4.Text = items(comboMenuType.SelectedIndex, 3)
        btnOrderButton5.Text = items(comboMenuType.SelectedIndex, 4)

        lblPrice1.Text = String.Format("PHP {0}", item_prices(comboMenuType.SelectedIndex, 0).ToString("F2"))
        lblPrice2.Text = String.Format("PHP {0}", item_prices(comboMenuType.SelectedIndex, 1).ToString("F2"))
        lblPrice3.Text = String.Format("PHP {0}", item_prices(comboMenuType.SelectedIndex, 2).ToString("F2"))
        lblPrice4.Text = String.Format("PHP {0}", item_prices(comboMenuType.SelectedIndex, 3).ToString("F2"))
        lblPrice5.Text = String.Format("PHP {0}", item_prices(comboMenuType.SelectedIndex, 4).ToString("F2"))

        NumOrderButton1.Value = 0
        NumOrderButton2.Value = 0
        NumOrderButton3.Value = 0
        NumOrderButton4.Value = 0
        NumOrderButton5.Value = 0
    End Sub

    Private Sub btnOrderButton1_Click(sender As Object, e As EventArgs) Handles btnOrderButton1.Click
        addOrUpdateOrder(btnOrderButton1.Text, 0, NumOrderButton1.Value)
    End Sub

    Private Sub btnOrderButton2_Click(sender As Object, e As EventArgs) Handles btnOrderButton2.Click
        addOrUpdateOrder(btnOrderButton2.Text, 1, NumOrderButton2.Value)
    End Sub

    Private Sub btnOrderButton3_Click(sender As Object, e As EventArgs) Handles btnOrderButton3.Click
        addOrUpdateOrder(btnOrderButton3.Text, 2, NumOrderButton3.Value)
    End Sub

    Private Sub btnOrderButton4_Click(sender As Object, e As EventArgs) Handles btnOrderButton4.Click
        addOrUpdateOrder(btnOrderButton4.Text, 3, NumOrderButton4.Value)
    End Sub

    Private Sub btnOrderButton5_Click(sender As Object, e As EventArgs) Handles btnOrderButton5.Click
        addOrUpdateOrder(btnOrderButton5.Text, 4, NumOrderButton5.Value)
    End Sub

    Private Sub btnVoid_Click(sender As Object, e As EventArgs) Handles btnVoid.Click
        ' Remove the currently-active row.
        dgOrderList.Rows.RemoveAt(dgOrderList.CurrentRow.Index)

        updateTotalPrice()
    End Sub

    Private Sub btnVoidAll_Click(sender As Object, e As EventArgs) Handles btnVoidAll.Click
        comboMenuType.SelectedIndex = 0
        comboMenuType.Text = comboMenuType.SelectedItem.ToString()

        NumOrderButton1.Value = 0
        NumOrderButton2.Value = 0
        NumOrderButton3.Value = 0
        NumOrderButton4.Value = 0
        NumOrderButton5.Value = 0

        dgOrderList.Rows.Clear()
        updateTotalPrice()
        txtTotal.Text = String.Empty
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        Dim total_tax As Double = total_price * TAX
        Dim subtotal As Double = total_price - total_tax
        BillSummary.total_price = total_price

        Dim item_quantity As Integer = 0
        ' Add all dgOrderList rows to BillSummary.dgOrderList.
        For Each row As DataGridViewRow In dgOrderList.Rows
            item_quantity += row.Cells(1).Value
            BillSummary.dgOrderList.Rows.Add(
                row.Cells(0).Value,  ' Order
                row.Cells(1).Value,  ' Quantity
                row.Cells(2).Value   ' Total Order Price
            )
        Next

        BillSummary.lblTotalItems.Text = item_quantity.ToString()
        BillSummary.lblBill.Text = $"PHP {subtotal:F2}"
        BillSummary.lblTax.Text = $"PHP {total_tax:F2}"
        BillSummary.lblTotalBill.Text = $"PHP {total_price:F2}"

        BillSummary.ShowDialog()
    End Sub
End Class

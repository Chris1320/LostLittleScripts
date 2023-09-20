Public Class Form1
    Dim total_weight As Double = 0.00
    Dim total_bill As Double = 0.00
    ' Candy prices per kilogram.
    Dim candy_price_per_kg_a As Double = 42.25
    Dim candy_price_per_kg_b As Double = 36.75
    Dim candy_price_per_kg_c As Double = 48.0
    Dim candy_price_per_kg_d As Double = 29.5

    ' This method is called when any of the numeric updowns are changed.
    Private Sub computeTotalWeight()
        total_weight = numCandyAWeight.Value + numCandyBWeight.Value + numCandyCWeight.Value + numCandyDWeight.Value
        txtTotalWeight.Text = String.Format("{0} kg", total_weight.ToString())

        Select Case total_weight
            Case Is <= 0
                picCandyAmountHigh.Visible = False
                picCandyAmountMid.Visible = False
                picCandyAmountLow.Visible = False
                picCandyAmountNone.Visible = True

            Case Is < 5
                picCandyAmountHigh.Visible = False
                picCandyAmountMid.Visible = False
                picCandyAmountLow.Visible = True
                picCandyAmountNone.Visible = False

            Case Is < 10
                picCandyAmountHigh.Visible = False
                picCandyAmountMid.Visible = True
                picCandyAmountLow.Visible = False
                picCandyAmountNone.Visible = False

            Case Is >= 10
                picCandyAmountHigh.Visible = True
                picCandyAmountMid.Visible = False
                picCandyAmountLow.Visible = False
                picCandyAmountNone.Visible = False

        End Select
    End Sub

    Private Sub numCandyAWeight_ValueChanged(sender As Object, e As EventArgs) Handles numCandyAWeight.ValueChanged
        computeTotalWeight()
    End Sub

    Private Sub numCandyBWeight_ValueChanged(sender As Object, e As EventArgs) Handles numCandyBWeight.ValueChanged
        computeTotalWeight()
    End Sub

    Private Sub numCandyCWeight_ValueChanged(sender As Object, e As EventArgs) Handles numCandyCWeight.ValueChanged
        computeTotalWeight()
    End Sub

    Private Sub numCandyDWeight_ValueChanged(sender As Object, e As EventArgs) Handles numCandyDWeight.ValueChanged
        computeTotalWeight()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Update the prices of the candies on load.
        lblCandyADesc.Text = String.Format("PHP {0}/kg", candy_price_per_kg_a)
        lblCandyBDesc.Text = String.Format("PHP {0}/kg", candy_price_per_kg_b)
        lblCandyCDesc.Text = String.Format("PHP {0}/kg", candy_price_per_kg_c)
        lblCandyDDesc.Text = String.Format("PHP {0}/kg", candy_price_per_kg_d)
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim candy_a_price As Double = candy_price_per_kg_a * numCandyAWeight.Value
        Dim candy_b_price As Double = candy_price_per_kg_b * numCandyBWeight.Value
        Dim candy_c_price As Double = candy_price_per_kg_c * numCandyCWeight.Value
        Dim candy_d_price As Double = candy_price_per_kg_d * numCandyDWeight.Value
        Dim total_candy_price As Double = candy_a_price + candy_b_price + candy_c_price + candy_d_price

        txtCandyAPrice.Text = String.Format("₱ {0}", candy_a_price.ToString())
        txtCandyBPrice.Text = String.Format("₱ {0}", candy_b_price.ToString())
        txtCandyCPrice.Text = String.Format("₱ {0}", candy_c_price.ToString())
        txtCandyDPrice.Text = String.Format("₱ {0}", candy_d_price.ToString())
        txtTotalPrice.Text = String.Format("₱ {0}", total_candy_price)
    End Sub
End Class

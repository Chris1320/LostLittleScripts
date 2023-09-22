' BMI Calculator
'
' Liza would like to know if she has a proportional weight based on his height which she can know by her
' Body Mass Index (BMI) and to know if she is underweight, healthy, overweight or obese. Help Liza to know
' her BMI by creating a BMI Calculator. Formula for getting the BMI is
'
' BMI = kg / m^2
'
' BMI 	Remarks
' Underweight 	less than 18.5
' Healthy     18.5 - 24.9
' Overweight  25.0 - 29.9
' Obese 	greater than 30 

Public Class BMICalculator
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' convert user height to meters
        Dim user_height As Double = ((numHeightFeet.Value * 12) + numHeightInches.Value) * 0.0254
        Dim user_bmi As Double = numWeightKilograms.Value / Math.Pow(user_height, 2)
        txtBMI.Text = user_bmi.ToString("F2")  ' Round-off the BMI result.

        ' Set the progress bar
        If user_bmi < 0 Then
            barStatus.Value = 0
        ElseIf user_bmi > 30 Then
            barStatus.Value = 30
        Else
            barStatus.Value = user_bmi
        End If

        ' Set the remarks and icons
        Select Case user_bmi
            Case Is < 18.5
                txtRemarks.Text = "Underweight"
                picWarning.Visible = True
                picGood.Visible = False

            Case Is < 25
                txtRemarks.Text = "Healthy"
                picWarning.Visible = False
                picGood.Visible = True

            Case Is < 30
                txtRemarks.Text = "Overweight"
                picWarning.Visible = True
                picGood.Visible = False

            Case Else
                txtRemarks.Text = "Obese"
                picWarning.Visible = True
                picGood.Visible = False

        End Select
    End Sub
End Class

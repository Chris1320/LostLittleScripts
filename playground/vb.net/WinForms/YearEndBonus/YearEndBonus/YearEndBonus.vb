' Year-End Bonus
'
' The XYZ Manufacturing Company plans to give a year-end bonus to each of its employees.
' Compute for the bonus of an employee considering the following criteria. If the employee’s
' monthly salary is less than Php5, 000.00, the bonus is 50% of the salary; for the employees
' with salaries greater than Php5, 000.00, the bonus is Php15, 000.00.

Public Class YearEndBonus
    Private Sub numSalary_ValueChanged(sender As Object, e As EventArgs) Handles numSalary.ValueChanged
        Dim LOW_BONUS_PERCENT As Double = 50
        Dim HIGH_BONUS As Double = 15000
        Dim bonus As Double = 0
        If numSalary.Value <= 5000 Then
            bonus = numSalary.Value * (LOW_BONUS_PERCENT / 100)
        Else
            bonus = HIGH_BONUS
        End If
        txtTotalBonus.Text = String.Format("PHP {0}", bonus)
    End Sub
End Class

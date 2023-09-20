' Employee Salary Calculator
'
' An employee working at a small company earns 100 pesos on his
' first day. However, for every day that passes, their base amount
' doubles, so they earn 200 on the second day and 400 on the third
' day (for a total of 700 pesos). Given a number of days, compute
' how much will he earn.

Public Class Form1
    ' Compute the total salary of an employee.
    ' num_days: number of days worked
    ' base_salary: base salary of the employee
    ' return: total salary of the employee
    Private Function GetTotalSalary(num_days As Integer, base_salary As Double) As Double
        Dim total_salary As Double = 0
        For i As Integer = 1 To num_days
            total_salary += base_salary
            base_salary *= 2
        Next

        Return total_salary
    End Function

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles numDays.ValueChanged
        Dim day_grammar As String = If(numDays.Value = 1, "day", "days")
        lblDesc.Text = String.Format("For the {0} {1} you've worked, you earned a total of", numDays.Value, day_grammar)
        Dim total As Double = GetTotalSalary(numDays.Value, 100)
        lblTotal.Text = String.Format("PHP {0}", total.ToString("N2"))
    End Sub
End Class

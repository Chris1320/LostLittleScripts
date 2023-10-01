Public Class Form1
    Const COURSE_COST As Double = 4000  ' per day
    Const PRE_CONFERENCE_COST As Double = 5000

    Dim total_cost As Double = 0
    Dim selected_course As Integer = -1
    Dim pre_conference As Integer = -1

    Private Sub updateTotal()
        If selected_course = -1 Then : Return
        End If

        total_cost = COURSE_COST * Val(txtNumOfDays.Text)
        If pre_conference <> -1 Then : total_cost += PRE_CONFERENCE_COST
        End If

        txtTotalCost.Text = total_cost.ToString("C2")
        Form2.txtTotalCost.Text = total_cost.ToString("C2")
    End Sub

    Private Sub btnClearForm_Click(sender As Object, e As EventArgs) Handles btnClearForm.Click
        txtCorpID.Clear()
        txtNameLast.Clear()
        txtNameFirst.Clear()
        txtNumOfDays.Clear()

        radioMobileSecurity.Checked = False
        radioMobileDatabase.Checked = False
        radioMobileApplication.Checked = False
        selected_course = -1

        radioAndroid.Checked = False
        radioIos.Checked = False
        pre_conference = -1

        txtTotalCost.Clear()

        Form2.txtCorpID.Text = String.Empty
        Form2.txtLastName.Text = String.Empty
        Form2.txtFirstName.Text = String.Empty
        Form2.txtNoOfDays.Text = String.Empty
        Form2.txtCourse.Text = String.Empty
        Form2.txtPreConference.Text = String.Empty
        Form2.txtTotalCost.Text = String.Empty
    End Sub

    ' This function returns True if the corpID is valid.
    ' Otherwise, it returns False.
    Private Function validateCorpID()
        ' Check if the content of txtCorpID is a string of 5 numbers.
        If Not IsNumeric(txtCorpID.Text) OrElse txtCorpID.Text.Length <> 5 Then
            MessageBox.Show(
                "Please enter a valid Corporate ID. (5-digit number)",
                "Invalid Corporate ID",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
            Return False
        End If
        Return True
    End Function

    ' This function returns True if the numOfDays is valid.
    ' Otherwise, it returns False.
    Private Function validateNumOfDays()
        'Check if the content of txtNumOfDays is a number from 1 to 4.
        If Not IsNumeric(txtNumOfDays.Text) OrElse txtNumOfDays.Text < 1 OrElse txtNumOfDays.Text > 4 Then
            MessageBox.Show(
                "Please enter a valid number of days. (1-4 days only)",
                "Invalid Number of Days",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
            Return False
        End If
        Return True
    End Function

    Private Sub btnComputeCost_Click(sender As Object, e As EventArgs) Handles btnComputeCost.Click
        If Not validateCorpID() Then
            Return
        End If

        If Not validateNumOfDays() Then
            Return
        End If

        If selected_course = -1 Then
            MessageBox.Show(
                "Please select a course.",
                "No Course Selected",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
            Return
        End If

        Form2.txtCorpID.Text = txtCorpID.Text
        Form2.txtLastName.Text = txtNameLast.Text
        Form2.txtFirstName.Text = txtNameFirst.Text
        Form2.txtNoOfDays.Text = txtNumOfDays.Text

        Select Case selected_course
            Case 0 : Form2.txtCourse.Text = "You chose Mobile Security"
            Case 1 : Form2.txtCourse.Text = "You chose Mobile Database"
            Case 2 : Form2.txtCourse.Text = "You chose Mobile Application"
        End Select

        Select Case pre_conference
            Case 0 : Form2.txtPreConference.Text = "with Android Pre-Conference course"
            Case 1 : Form2.txtPreConference.Text = "with iOS Pre-Conference course"
            Case Else : Form2.txtPreConference.Text = "without any Pre-Conference courses"
        End Select

        Form2.ShowDialog()
    End Sub

    Private Sub radioMobileSecurity_CheckedChanged(sender As Object, e As EventArgs) Handles radioMobileSecurity.CheckedChanged
        selected_course = 0
        updateTotal()
    End Sub

    Private Sub radioMobileDatabase_CheckedChanged(sender As Object, e As EventArgs) Handles radioMobileDatabase.CheckedChanged
        selected_course = 1
        updateTotal()
    End Sub

    Private Sub radioMobileApplication_CheckedChanged(sender As Object, e As EventArgs) Handles radioMobileApplication.CheckedChanged
        selected_course = 2
        updateTotal()
    End Sub

    Private Sub radioAndroid_CheckedChanged(sender As Object, e As EventArgs) Handles radioAndroid.CheckedChanged
        pre_conference = 0
        updateTotal()
    End Sub

    Private Sub radioIos_CheckedChanged(sender As Object, e As EventArgs) Handles radioIos.CheckedChanged
        pre_conference = 1
        updateTotal()
    End Sub

    Private Sub txtNumOfDays_TextChanged(sender As Object, e As EventArgs) Handles txtNumOfDays.TextChanged
        updateTotal()
    End Sub

    Private Sub txtCorpID_Leave(sender As Object, e As EventArgs) Handles txtCorpID.Leave
        If Not validateCorpID() Then : txtCorpID.Text = String.Empty
        End If
    End Sub

    Private Sub txtNumOfDays_Leave(sender As Object, e As EventArgs) Handles txtNumOfDays.Leave
        If Not validateNumOfDays() Then : txtNumOfDays.Text = String.Empty
        End If
    End Sub
End Class

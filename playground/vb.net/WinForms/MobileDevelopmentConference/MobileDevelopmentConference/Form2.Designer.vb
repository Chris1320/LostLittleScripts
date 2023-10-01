<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        txtPreConference = New Label()
        Label13 = New Label()
        txtCourse = New Label()
        Label11 = New Label()
        txtNoOfDays = New Label()
        Label9 = New Label()
        txtFirstName = New Label()
        Label7 = New Label()
        txtLastName = New Label()
        Label5 = New Label()
        txtCorpID = New Label()
        Label3 = New Label()
        picClose = New PictureBox()
        Label4 = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        txtTotalCost = New Label()
        TableLayoutPanel1.SuspendLayout()
        CType(picClose, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(70, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(204, 47)
        Label1.TabIndex = 0
        Label1.Text = "Thank you!"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(63, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(211, 45)
        Label2.TabIndex = 1
        Label2.Text = "You have successfully registered to our" & vbCrLf & "Mobile Development Conference." & vbCrLf & "See you there!"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 31.7365265F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 68.26347F))
        TableLayoutPanel1.Controls.Add(txtPreConference, 1, 5)
        TableLayoutPanel1.Controls.Add(Label13, 0, 5)
        TableLayoutPanel1.Controls.Add(txtCourse, 1, 4)
        TableLayoutPanel1.Controls.Add(Label11, 0, 4)
        TableLayoutPanel1.Controls.Add(txtNoOfDays, 1, 3)
        TableLayoutPanel1.Controls.Add(Label9, 0, 3)
        TableLayoutPanel1.Controls.Add(txtFirstName, 1, 2)
        TableLayoutPanel1.Controls.Add(Label7, 0, 2)
        TableLayoutPanel1.Controls.Add(txtLastName, 1, 1)
        TableLayoutPanel1.Controls.Add(Label5, 0, 1)
        TableLayoutPanel1.Controls.Add(txtCorpID, 1, 0)
        TableLayoutPanel1.Controls.Add(Label3, 0, 0)
        TableLayoutPanel1.Location = New Point(12, 139)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 6
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666679F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666679F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666679F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666679F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666679F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666679F))
        TableLayoutPanel1.Size = New Size(334, 136)
        TableLayoutPanel1.TabIndex = 2
        ' 
        ' txtPreConference
        ' 
        txtPreConference.Anchor = AnchorStyles.Left
        txtPreConference.AutoSize = True
        txtPreConference.Location = New Point(109, 115)
        txtPreConference.Name = "txtPreConference"
        txtPreConference.Size = New Size(47, 15)
        txtPreConference.TabIndex = 14
        txtPreConference.Text = "Label14"
        txtPreConference.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.Right
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(4, 115)
        Label13.Name = "Label13"
        Label13.Size = New Size(99, 15)
        Label13.TabIndex = 13
        Label13.Text = "Pre-Conference:"
        Label13.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtCourse
        ' 
        txtCourse.Anchor = AnchorStyles.Left
        txtCourse.AutoSize = True
        txtCourse.Location = New Point(109, 91)
        txtCourse.Name = "txtCourse"
        txtCourse.Size = New Size(47, 15)
        txtCourse.TabIndex = 12
        txtCourse.Text = "Label12"
        txtCourse.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Right
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(55, 91)
        Label11.Name = "Label11"
        Label11.Size = New Size(48, 15)
        Label11.TabIndex = 11
        Label11.Text = "Course:"
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtNoOfDays
        ' 
        txtNoOfDays.Anchor = AnchorStyles.Left
        txtNoOfDays.AutoSize = True
        txtNoOfDays.Location = New Point(109, 69)
        txtNoOfDays.Name = "txtNoOfDays"
        txtNoOfDays.Size = New Size(47, 15)
        txtNoOfDays.TabIndex = 10
        txtNoOfDays.Text = "Label10"
        txtNoOfDays.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(30, 69)
        Label9.Name = "Label9"
        Label9.Size = New Size(73, 15)
        Label9.TabIndex = 9
        Label9.Text = "No. of Days:"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Anchor = AnchorStyles.Left
        txtFirstName.AutoSize = True
        txtFirstName.Location = New Point(109, 47)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(41, 15)
        txtFirstName.TabIndex = 8
        txtFirstName.Text = "Label8"
        txtFirstName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(33, 47)
        Label7.Name = "Label7"
        Label7.Size = New Size(70, 15)
        Label7.TabIndex = 7
        Label7.Text = "First Name:"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtLastName
        ' 
        txtLastName.Anchor = AnchorStyles.Left
        txtLastName.AutoSize = True
        txtLastName.Location = New Point(109, 25)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(41, 15)
        txtLastName.TabIndex = 6
        txtLastName.Text = "Label6"
        txtLastName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(35, 25)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 15)
        Label5.TabIndex = 5
        Label5.Text = "Last Name:"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtCorpID
        ' 
        txtCorpID.Anchor = AnchorStyles.Left
        txtCorpID.AutoSize = True
        txtCorpID.Location = New Point(109, 3)
        txtCorpID.Name = "txtCorpID"
        txtCorpID.Size = New Size(41, 15)
        txtCorpID.TabIndex = 4
        txtCorpID.Text = "Label4"
        txtCorpID.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(51, 3)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 15)
        Label3.TabIndex = 3
        Label3.Text = "Corp ID:"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' picClose
        ' 
        picClose.Image = My.Resources.Resources.close
        picClose.Location = New Point(12, 12)
        picClose.Name = "picClose"
        picClose.Size = New Size(25, 25)
        picClose.SizeMode = PictureBoxSizeMode.Zoom
        picClose.TabIndex = 3
        picClose.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(30, 5)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 30)
        Label4.TabIndex = 4
        Label4.Text = "Total:"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(txtTotalCost, 1, 0)
        TableLayoutPanel2.Controls.Add(Label4, 0, 0)
        TableLayoutPanel2.Location = New Point(70, 291)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(200, 41)
        TableLayoutPanel2.TabIndex = 5
        ' 
        ' txtTotalCost
        ' 
        txtTotalCost.Anchor = AnchorStyles.Left
        txtTotalCost.AutoSize = True
        txtTotalCost.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtTotalCost.Location = New Point(103, 5)
        txtTotalCost.Name = "txtTotalCost"
        txtTotalCost.Size = New Size(51, 30)
        txtTotalCost.TabIndex = 5
        txtTotalCost.Text = "N/A"
        txtTotalCost.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGreen
        ClientSize = New Size(358, 344)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(picClose)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form2"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mobile Development Conference Registration Successful"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(picClose, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPreConference As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtCourse As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtNoOfDays As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtFirstName As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtLastName As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCorpID As Label
    Friend WithEvents picClose As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents txtTotalCost As Label
End Class

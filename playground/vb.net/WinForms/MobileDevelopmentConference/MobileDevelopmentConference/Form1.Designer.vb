<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtCorpID = New TextBox()
        txtNameLast = New TextBox()
        txtNameFirst = New TextBox()
        txtNumOfDays = New TextBox()
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        radioMobileApplication = New RadioButton()
        radioMobileDatabase = New RadioButton()
        radioMobileSecurity = New RadioButton()
        GroupBox2 = New GroupBox()
        radioIos = New RadioButton()
        radioAndroid = New RadioButton()
        Label6 = New Label()
        txtTotalCost = New TextBox()
        btnComputeCost = New Button()
        btnClearForm = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Alfa Slab One", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(477, 30)
        Label1.TabIndex = 0
        Label1.Text = "Mobile Development Conference Registration"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(28, 113)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 15)
        Label2.TabIndex = 1
        Label2.Text = "Corp ID:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 142)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 15)
        Label3.TabIndex = 2
        Label3.Text = "Last Name:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(11, 171)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 15)
        Label4.TabIndex = 3
        Label4.Text = "First Name:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(19, 200)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 15)
        Label5.TabIndex = 4
        Label5.Text = "# of Days:"
        ' 
        ' txtCorpID
        ' 
        txtCorpID.Location = New Point(84, 110)
        txtCorpID.Name = "txtCorpID"
        txtCorpID.Size = New Size(100, 23)
        txtCorpID.TabIndex = 5
        ' 
        ' txtNameLast
        ' 
        txtNameLast.Location = New Point(84, 139)
        txtNameLast.Name = "txtNameLast"
        txtNameLast.Size = New Size(100, 23)
        txtNameLast.TabIndex = 6
        ' 
        ' txtNameFirst
        ' 
        txtNameFirst.Location = New Point(84, 168)
        txtNameFirst.Name = "txtNameFirst"
        txtNameFirst.Size = New Size(100, 23)
        txtNameFirst.TabIndex = 7
        ' 
        ' txtNumOfDays
        ' 
        txtNumOfDays.Location = New Point(84, 197)
        txtNumOfDays.Name = "txtNumOfDays"
        txtNumOfDays.Size = New Size(100, 23)
        txtNumOfDays.TabIndex = 8
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.mobile_development
        PictureBox1.Location = New Point(214, 97)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(258, 149)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(radioMobileApplication)
        GroupBox1.Controls.Add(radioMobileDatabase)
        GroupBox1.Controls.Add(radioMobileSecurity)
        GroupBox1.Location = New Point(12, 274)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(134, 100)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        GroupBox1.Text = "Courses"
        ' 
        ' radioMobileApplication
        ' 
        radioMobileApplication.AutoSize = True
        radioMobileApplication.Location = New Point(7, 72)
        radioMobileApplication.Name = "radioMobileApplication"
        radioMobileApplication.Size = New Size(126, 19)
        radioMobileApplication.TabIndex = 2
        radioMobileApplication.TabStop = True
        radioMobileApplication.Text = "Mobile Application"
        radioMobileApplication.UseVisualStyleBackColor = True
        ' 
        ' radioMobileDatabase
        ' 
        radioMobileDatabase.AutoSize = True
        radioMobileDatabase.Location = New Point(7, 47)
        radioMobileDatabase.Name = "radioMobileDatabase"
        radioMobileDatabase.Size = New Size(113, 19)
        radioMobileDatabase.TabIndex = 1
        radioMobileDatabase.TabStop = True
        radioMobileDatabase.Text = "Mobile Database"
        radioMobileDatabase.UseVisualStyleBackColor = True
        ' 
        ' radioMobileSecurity
        ' 
        radioMobileSecurity.AutoSize = True
        radioMobileSecurity.Location = New Point(7, 22)
        radioMobileSecurity.Name = "radioMobileSecurity"
        radioMobileSecurity.Size = New Size(107, 19)
        radioMobileSecurity.TabIndex = 0
        radioMobileSecurity.TabStop = True
        radioMobileSecurity.Text = "Mobile Security"
        radioMobileSecurity.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(radioIos)
        GroupBox2.Controls.Add(radioAndroid)
        GroupBox2.Location = New Point(152, 274)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(106, 100)
        GroupBox2.TabIndex = 11
        GroupBox2.TabStop = False
        GroupBox2.Text = "Pre-Conference"
        ' 
        ' radioIos
        ' 
        radioIos.AutoSize = True
        radioIos.Location = New Point(6, 47)
        radioIos.Name = "radioIos"
        radioIos.Size = New Size(43, 19)
        radioIos.TabIndex = 1
        radioIos.TabStop = True
        radioIos.Text = "iOS"
        radioIos.UseVisualStyleBackColor = True
        ' 
        ' radioAndroid
        ' 
        radioAndroid.AutoSize = True
        radioAndroid.Location = New Point(6, 22)
        radioAndroid.Name = "radioAndroid"
        radioAndroid.Size = New Size(68, 19)
        radioAndroid.TabIndex = 0
        radioAndroid.TabStop = True
        radioAndroid.Text = "Android"
        radioAndroid.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point)
        Label6.Location = New Point(348, 265)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 15)
        Label6.TabIndex = 12
        Label6.Text = "Total Cost"
        ' 
        ' txtTotalCost
        ' 
        txtTotalCost.Anchor = AnchorStyles.None
        txtTotalCost.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtTotalCost.Location = New Point(312, 283)
        txtTotalCost.Name = "txtTotalCost"
        txtTotalCost.ReadOnly = True
        txtTotalCost.Size = New Size(127, 29)
        txtTotalCost.TabIndex = 13
        txtTotalCost.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnComputeCost
        ' 
        btnComputeCost.Location = New Point(280, 335)
        btnComputeCost.Name = "btnComputeCost"
        btnComputeCost.Size = New Size(75, 41)
        btnComputeCost.TabIndex = 14
        btnComputeCost.Text = "Compute Cost"
        btnComputeCost.UseVisualStyleBackColor = True
        ' 
        ' btnClearForm
        ' 
        btnClearForm.Location = New Point(397, 335)
        btnClearForm.Name = "btnClearForm"
        btnClearForm.Size = New Size(75, 41)
        btnClearForm.TabIndex = 15
        btnClearForm.Text = "Clear Form"
        btnClearForm.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(494, 402)
        Controls.Add(btnClearForm)
        Controls.Add(btnComputeCost)
        Controls.Add(txtTotalCost)
        Controls.Add(Label6)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox1)
        Controls.Add(txtNumOfDays)
        Controls.Add(txtNameFirst)
        Controls.Add(txtNameLast)
        Controls.Add(txtCorpID)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mobile Development Conference Registration"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCorpID As TextBox
    Friend WithEvents txtNameLast As TextBox
    Friend WithEvents txtNameFirst As TextBox
    Friend WithEvents txtNumOfDays As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radioMobileApplication As RadioButton
    Friend WithEvents radioMobileDatabase As RadioButton
    Friend WithEvents radioMobileSecurity As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radioIos As RadioButton
    Friend WithEvents radioAndroid As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTotalCost As TextBox
    Friend WithEvents btnComputeCost As Button
    Friend WithEvents btnClearForm As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblAdminAccountNotice = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtMiddleInitial = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtPasswordConfirm = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblPasswordMismatch = New System.Windows.Forms.Label()
        Me.lnkToLogin = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BlueCaribbeanTour.My.Resources.Resources.logo_v
        Me.PictureBox1.Location = New System.Drawing.Point(12, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(214, 250)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblAdminAccountNotice
        '
        Me.lblAdminAccountNotice.AutoSize = True
        Me.lblAdminAccountNotice.Location = New System.Drawing.Point(331, 14)
        Me.lblAdminAccountNotice.Name = "lblAdminAccountNotice"
        Me.lblAdminAccountNotice.Size = New System.Drawing.Size(250, 13)
        Me.lblAdminAccountNotice.TabIndex = 1
        Me.lblAdminAccountNotice.Text = "You are currently creating an administrator account."
        Me.lblAdminAccountNotice.Visible = False
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(292, 99)
        Me.txtFirstName.MaxLength = 50
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(144, 20)
        Me.txtFirstName.TabIndex = 4
        '
        'txtMiddleInitial
        '
        Me.txtMiddleInitial.Location = New System.Drawing.Point(442, 99)
        Me.txtMiddleInitial.MaxLength = 3
        Me.txtMiddleInitial.Name = "txtMiddleInitial"
        Me.txtMiddleInitial.Size = New System.Drawing.Size(33, 20)
        Me.txtMiddleInitial.TabIndex = 5
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(481, 99)
        Me.txtLastName.MaxLength = 50
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(232, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Full Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(290, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 9)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(440, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 9)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "M.I."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(479, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 9)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Last Name"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(292, 45)
        Me.txtUsername.MaxLength = 30
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(100, 20)
        Me.txtUsername.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(231, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Username"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(481, 45)
        Me.txtPassword.MaxLength = 60
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtPasswordConfirm
        '
        Me.txtPasswordConfirm.Location = New System.Drawing.Point(481, 71)
        Me.txtPasswordConfirm.MaxLength = 60
        Me.txtPasswordConfirm.Name = "txtPasswordConfirm"
        Me.txtPasswordConfirm.Size = New System.Drawing.Size(100, 20)
        Me.txtPasswordConfirm.TabIndex = 3
        Me.txtPasswordConfirm.UseSystemPasswordChar = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(422, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Password"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(378, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Password (Confirm)"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(292, 134)
        Me.txtAddress.MaxLength = 100
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(289, 20)
        Me.txtAddress.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(241, 137)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Address"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(325, 172)
        Me.txtPhoneNumber.MaxLength = 11
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(144, 20)
        Me.txtPhoneNumber.TabIndex = 8
        Me.txtPhoneNumber.Text = "09"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(241, 175)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Phone Number"
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(480, 215)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(101, 34)
        Me.btnRegister.TabIndex = 10
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(244, 224)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(64, 25)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblPasswordMismatch
        '
        Me.lblPasswordMismatch.AutoSize = True
        Me.lblPasswordMismatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasswordMismatch.Location = New System.Drawing.Point(479, 33)
        Me.lblPasswordMismatch.Name = "lblPasswordMismatch"
        Me.lblPasswordMismatch.Size = New System.Drawing.Size(74, 9)
        Me.lblPasswordMismatch.TabIndex = 19
        Me.lblPasswordMismatch.Text = "password mismatch"
        Me.lblPasswordMismatch.Visible = False
        '
        'lnkToLogin
        '
        Me.lnkToLogin.AutoSize = True
        Me.lnkToLogin.Location = New System.Drawing.Point(326, 230)
        Me.lnkToLogin.Name = "lnkToLogin"
        Me.lnkToLogin.Size = New System.Drawing.Size(132, 13)
        Me.lnkToLogin.TabIndex = 20
        Me.lnkToLogin.TabStop = True
        Me.lnkToLogin.Text = "Already have an account?"
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 276)
        Me.Controls.Add(Me.lnkToLogin)
        Me.Controls.Add(Me.lblPasswordMismatch)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPasswordConfirm)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtMiddleInitial)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblAdminAccountNotice)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RegisterForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegisterForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblAdminAccountNotice As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtMiddleInitial As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtPasswordConfirm As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblPasswordMismatch As Label
    Friend WithEvents lnkToLogin As LinkLabel
End Class

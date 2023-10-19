<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserProfile))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtNameLast = New System.Windows.Forms.TextBox()
        Me.txtNameMiddle = New System.Windows.Forms.TextBox()
        Me.txtNameFirst = New System.Windows.Forms.TextBox()
        Me.txtUserLevel = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnEditAccount = New System.Windows.Forms.Button()
        Me.btnDiscard = New System.Windows.Forms.Button()
        Me.btnDemoteUser = New System.Windows.Forms.Button()
        Me.btnPasswordHide = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.17647!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.82353!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtPhoneNumber, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.txtAddress, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNameLast, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNameMiddle, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNameFirst, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtUserLevel, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPassword, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtUsername, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtUserID, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label15, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label17, 0, 6)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(193, 57)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 9
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(323, 268)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPhoneNumber.Location = New System.Drawing.Point(139, 240)
        Me.txtPhoneNumber.MaxLength = 11
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.ReadOnly = True
        Me.txtPhoneNumber.Size = New System.Drawing.Size(178, 20)
        Me.txtPhoneNumber.TabIndex = 11
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtAddress.Location = New System.Drawing.Point(139, 207)
        Me.txtAddress.MaxLength = 100
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(178, 20)
        Me.txtAddress.TabIndex = 10
        '
        'txtNameLast
        '
        Me.txtNameLast.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNameLast.Location = New System.Drawing.Point(139, 178)
        Me.txtNameLast.MaxLength = 50
        Me.txtNameLast.Name = "txtNameLast"
        Me.txtNameLast.ReadOnly = True
        Me.txtNameLast.Size = New System.Drawing.Size(178, 20)
        Me.txtNameLast.TabIndex = 9
        '
        'txtNameMiddle
        '
        Me.txtNameMiddle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNameMiddle.Location = New System.Drawing.Point(139, 149)
        Me.txtNameMiddle.MaxLength = 3
        Me.txtNameMiddle.Name = "txtNameMiddle"
        Me.txtNameMiddle.ReadOnly = True
        Me.txtNameMiddle.Size = New System.Drawing.Size(178, 20)
        Me.txtNameMiddle.TabIndex = 8
        '
        'txtNameFirst
        '
        Me.txtNameFirst.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNameFirst.Location = New System.Drawing.Point(139, 120)
        Me.txtNameFirst.MaxLength = 50
        Me.txtNameFirst.Name = "txtNameFirst"
        Me.txtNameFirst.ReadOnly = True
        Me.txtNameFirst.Size = New System.Drawing.Size(178, 20)
        Me.txtNameFirst.TabIndex = 7
        '
        'txtUserLevel
        '
        Me.txtUserLevel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUserLevel.Location = New System.Drawing.Point(139, 91)
        Me.txtUserLevel.Name = "txtUserLevel"
        Me.txtUserLevel.ReadOnly = True
        Me.txtUserLevel.Size = New System.Drawing.Size(178, 20)
        Me.txtUserLevel.TabIndex = 5
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPassword.Location = New System.Drawing.Point(139, 62)
        Me.txtPassword.MaxLength = 60
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.ReadOnly = True
        Me.txtPassword.Size = New System.Drawing.Size(178, 20)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUsername.Location = New System.Drawing.Point(139, 33)
        Me.txtUsername.MaxLength = 30
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.ReadOnly = True
        Me.txtUsername.Size = New System.Drawing.Size(178, 20)
        Me.txtUsername.TabIndex = 2
        '
        'txtUserID
        '
        Me.txtUserID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUserID.Location = New System.Drawing.Point(137, 4)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.ReadOnly = True
        Me.txtUserID.Size = New System.Drawing.Size(181, 20)
        Me.txtUserID.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(29, 149)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 20)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Middle Name"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(44, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 20)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "First Name"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(46, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "User Level"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(52, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Password"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Username"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(66, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "User ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Contact Number"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(62, 207)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 20)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Address"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(44, 178)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(86, 20)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Last Name"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(253, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "User Account"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.BlueCaribbeanTour.My.Resources.Resources.logo_v
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'btnEditAccount
        '
        Me.btnEditAccount.Location = New System.Drawing.Point(12, 210)
        Me.btnEditAccount.Name = "btnEditAccount"
        Me.btnEditAccount.Size = New System.Drawing.Size(150, 45)
        Me.btnEditAccount.TabIndex = 12
        Me.btnEditAccount.Text = "Edit Account Details"
        Me.btnEditAccount.UseVisualStyleBackColor = True
        '
        'btnDiscard
        '
        Me.btnDiscard.Enabled = False
        Me.btnDiscard.Location = New System.Drawing.Point(12, 280)
        Me.btnDiscard.Name = "btnDiscard"
        Me.btnDiscard.Size = New System.Drawing.Size(150, 45)
        Me.btnDiscard.TabIndex = 13
        Me.btnDiscard.Text = "Discard Changes"
        Me.btnDiscard.UseVisualStyleBackColor = True
        '
        'btnDemoteUser
        '
        Me.btnDemoteUser.Enabled = False
        Me.btnDemoteUser.Location = New System.Drawing.Point(522, 148)
        Me.btnDemoteUser.Name = "btnDemoteUser"
        Me.btnDemoteUser.Size = New System.Drawing.Size(54, 23)
        Me.btnDemoteUser.TabIndex = 6
        Me.btnDemoteUser.Text = "Demote"
        Me.btnDemoteUser.UseVisualStyleBackColor = True
        '
        'btnPasswordHide
        '
        Me.btnPasswordHide.Location = New System.Drawing.Point(522, 119)
        Me.btnPasswordHide.Name = "btnPasswordHide"
        Me.btnPasswordHide.Size = New System.Drawing.Size(54, 23)
        Me.btnPasswordHide.TabIndex = 4
        Me.btnPasswordHide.Text = "View"
        Me.btnPasswordHide.UseVisualStyleBackColor = True
        '
        'UserProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 366)
        Me.Controls.Add(Me.btnPasswordHide)
        Me.Controls.Add(Me.btnDemoteUser)
        Me.Controls.Add(Me.btnDiscard)
        Me.Controls.Add(Me.btnEditAccount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserProfile"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserProfile"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnEditAccount As Button
    Friend WithEvents btnDiscard As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtNameLast As TextBox
    Friend WithEvents txtNameMiddle As TextBox
    Friend WithEvents txtNameFirst As TextBox
    Friend WithEvents txtUserLevel As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents btnDemoteUser As Button
    Friend WithEvents btnPasswordHide As Button
End Class

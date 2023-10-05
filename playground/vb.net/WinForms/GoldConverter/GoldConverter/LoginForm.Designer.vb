<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        btnLogin = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe MDL2 Assets", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(192, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 22)
        Label1.TabIndex = 0
        Label1.Text = "Welcome to"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe Script", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(84, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(332, 40)
        Label2.TabIndex = 1
        Label2.Text = "Cash for Gold Converter"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(135, 137)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Enter username here"
        txtUsername.Size = New Size(204, 23)
        txtUsername.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(135, 176)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "Enter password here"
        txtPassword.Size = New Size(204, 23)
        txtPassword.TabIndex = 3
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Location = New Point(69, 140)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 15)
        Label3.TabIndex = 4
        Label3.Text = "Username"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Location = New Point(72, 179)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 15)
        Label4.TabIndex = 5
        Label4.Text = "Password"
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(389, 137)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(75, 23)
        btnLogin.TabIndex = 6
        btnLogin.Text = "Log In"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(389, 176)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 23)
        btnCancel.TabIndex = 7
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.katie_harp_Em96eDRJPD8_unsplash
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(508, 235)
        Controls.Add(btnCancel)
        Controls.Add(btnLogin)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "LoginForm"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Gold Converter"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnCancel As Button
End Class

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
        Label3 = New Label()
        txtUsername = New TextBox()
        btnLogin = New Button()
        btnCancel = New Button()
        btnTogglePasswordView = New Button()
        txtPassword = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(146, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(231, 47)
        Label1.TabIndex = 0
        Label1.Text = "Segway Tours"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(108, 141)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 30)
        Label2.TabIndex = 1
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(115, 188)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 30)
        Label3.TabIndex = 2
        Label3.Text = "Password"
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        txtUsername.BorderStyle = BorderStyle.None
        txtUsername.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtUsername.Location = New Point(220, 138)
        txtUsername.MaxLength = 22
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(157, 28)
        txtUsername.TabIndex = 1
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(334, 255)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(82, 35)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(422, 255)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(82, 35)
        btnCancel.TabIndex = 5
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnTogglePasswordView
        ' 
        btnTogglePasswordView.BackgroundImage = My.Resources.Resources.pass_view
        btnTogglePasswordView.BackgroundImageLayout = ImageLayout.Zoom
        btnTogglePasswordView.Image = My.Resources.Resources.pass_view
        btnTogglePasswordView.Location = New Point(383, 193)
        btnTogglePasswordView.Name = "btnTogglePasswordView"
        btnTogglePasswordView.Size = New Size(25, 25)
        btnTogglePasswordView.TabIndex = 3
        btnTogglePasswordView.UseVisualStyleBackColor = True
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        txtPassword.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword.Location = New Point(220, 185)
        txtPassword.MaxLength = 22
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(157, 35)
        txtPassword.TabIndex = 2
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(547, 319)
        Controls.Add(txtPassword)
        Controls.Add(btnTogglePasswordView)
        Controls.Add(btnCancel)
        Controls.Add(btnLogin)
        Controls.Add(txtUsername)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "LoginForm"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Segway Tours"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnTogglePasswordView As Button
    Friend WithEvents txtPassword As TextBox
End Class

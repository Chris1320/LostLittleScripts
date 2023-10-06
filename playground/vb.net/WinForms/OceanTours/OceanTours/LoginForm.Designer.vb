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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Label1 = New Label()
        Label2 = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        btnCancel = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(82, 111)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 25)
        Label1.TabIndex = 0
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(88, 149)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 25)
        Label2.TabIndex = 1
        Label2.Text = "Password:"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        txtUsername.Location = New Point(189, 108)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(191, 32)
        txtUsername.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword.Location = New Point(189, 146)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(191, 32)
        txtPassword.TabIndex = 3
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(305, 201)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(75, 23)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(386, 201)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 23)
        btnCancel.TabIndex = 5
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.logo_h
        PictureBox1.Location = New Point(82, -49)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(379, 227)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.pexels_connor_mcmanus_17366637
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(526, 281)
        Controls.Add(btnCancel)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "LoginForm"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Ocean Tours Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class

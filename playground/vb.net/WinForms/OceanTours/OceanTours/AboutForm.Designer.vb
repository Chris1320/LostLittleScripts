<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(AboutForm))
        PictureBox1 = New PictureBox()
        RichTextBox1 = New RichTextBox()
        Label1 = New Label()
        RichTextBox2 = New RichTextBox()
        Label2 = New Label()
        Label3 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.logo_h
        PictureBox1.Location = New Point(81, -84)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(524, 291)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Anchor = AnchorStyles.None
        RichTextBox1.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Location = New Point(12, 194)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ReadOnly = True
        RichTextBox1.Size = New Size(333, 232)
        RichTextBox1.TabIndex = 1
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Gill Sans MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(56, 161)
        Label1.Name = "Label1"
        Label1.Size = New Size(205, 30)
        Label1.TabIndex = 2
        Label1.Text = "Ocean Tours Guide"
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.Anchor = AnchorStyles.None
        RichTextBox2.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        RichTextBox2.BorderStyle = BorderStyle.None
        RichTextBox2.Location = New Point(351, 194)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.ReadOnly = True
        RichTextBox2.Size = New Size(333, 232)
        RichTextBox2.TabIndex = 3
        RichTextBox2.Text = resources.GetString("RichTextBox2.Text")
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Gill Sans MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(403, 161)
        Label2.Name = "Label2"
        Label2.Size = New Size(246, 30)
        Label2.TabIndex = 4
        Label2.Text = "Why Use Ocean Tours?"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Gill Sans MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(403, 396)
        Label3.Name = "Label3"
        Label3.Size = New Size(199, 30)
        Label3.TabIndex = 5
        Label3.Text = """We work for you"""
        ' 
        ' AboutForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        ClientSize = New Size(693, 438)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(RichTextBox2)
        Controls.Add(Label1)
        Controls.Add(RichTextBox1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "AboutForm"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "About Ocean Tours"
        TopMost = True
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class

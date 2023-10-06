<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LandingPage
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(LandingPage))
        PictureBox1 = New PictureBox()
        MenuStrip1 = New MenuStrip()
        HomeToolStripMenuItem = New ToolStripMenuItem()
        TourDestinationsToolStripMenuItem = New ToolStripMenuItem()
        HawaiiToolStripMenuItem = New ToolStripMenuItem()
        JamaicaToolStripMenuItem = New ToolStripMenuItem()
        MaldivesToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.logo_v
        PictureBox1.Location = New Point(67, 66)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(250, 250)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {HomeToolStripMenuItem, TourDestinationsToolStripMenuItem, AboutToolStripMenuItem, ExitToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(612, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' HomeToolStripMenuItem
        ' 
        HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        HomeToolStripMenuItem.Size = New Size(52, 20)
        HomeToolStripMenuItem.Text = "Home"
        ' 
        ' TourDestinationsToolStripMenuItem
        ' 
        TourDestinationsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {HawaiiToolStripMenuItem, JamaicaToolStripMenuItem, MaldivesToolStripMenuItem})
        TourDestinationsToolStripMenuItem.Name = "TourDestinationsToolStripMenuItem"
        TourDestinationsToolStripMenuItem.Size = New Size(110, 20)
        TourDestinationsToolStripMenuItem.Text = "Tour Destinations"
        ' 
        ' HawaiiToolStripMenuItem
        ' 
        HawaiiToolStripMenuItem.Name = "HawaiiToolStripMenuItem"
        HawaiiToolStripMenuItem.Size = New Size(180, 22)
        HawaiiToolStripMenuItem.Text = "Hawaii"
        ' 
        ' JamaicaToolStripMenuItem
        ' 
        JamaicaToolStripMenuItem.Name = "JamaicaToolStripMenuItem"
        JamaicaToolStripMenuItem.Size = New Size(180, 22)
        JamaicaToolStripMenuItem.Text = "Jamaica"
        ' 
        ' MaldivesToolStripMenuItem
        ' 
        MaldivesToolStripMenuItem.Name = "MaldivesToolStripMenuItem"
        MaldivesToolStripMenuItem.Size = New Size(180, 22)
        MaldivesToolStripMenuItem.Text = "Maldives"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(52, 20)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(38, 20)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' LandingPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.pexels_jess_loiterton_4602279
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(612, 345)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "LandingPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Ocean Tours"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TourDestinationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HawaiiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JamaicaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaldivesToolStripMenuItem As ToolStripMenuItem
End Class

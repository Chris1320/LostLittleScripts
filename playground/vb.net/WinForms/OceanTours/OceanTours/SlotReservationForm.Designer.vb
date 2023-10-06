<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SlotReservationForm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(SlotReservationForm))
        MenuStrip1 = New MenuStrip()
        HomeToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        comboLocation = New ComboBox()
        PictureBox1 = New PictureBox()
        numPersonQuantity = New NumericUpDown()
        lblPax = New Label()
        lblPaxUnit = New Label()
        picPaxBorder = New PictureBox()
        listTours = New ListBox()
        picToursList = New PictureBox()
        btnFindCost = New Button()
        btnClear = New Button()
        lblTour = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        lblResultLengthValue = New Label()
        lblResultCostValue = New Label()
        lblResultTourValue = New Label()
        lblResultCost = New Label()
        lblResultTour = New Label()
        lblResultLength = New Label()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(numPersonQuantity, ComponentModel.ISupportInitialize).BeginInit()
        CType(picPaxBorder, ComponentModel.ISupportInitialize).BeginInit()
        CType(picToursList, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {HomeToolStripMenuItem, ExitToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(617, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' HomeToolStripMenuItem
        ' 
        HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        HomeToolStripMenuItem.Size = New Size(52, 20)
        HomeToolStripMenuItem.Text = "Home"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(38, 20)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' comboLocation
        ' 
        comboLocation.FormattingEnabled = True
        comboLocation.Location = New Point(197, 69)
        comboLocation.Name = "comboLocation"
        comboLocation.Size = New Size(230, 23)
        comboLocation.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.logo_v
        PictureBox1.Location = New Point(12, 27)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 100)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' numPersonQuantity
        ' 
        numPersonQuantity.Location = New Point(95, 186)
        numPersonQuantity.Name = "numPersonQuantity"
        numPersonQuantity.Size = New Size(120, 23)
        numPersonQuantity.TabIndex = 3
        ' 
        ' lblPax
        ' 
        lblPax.AutoSize = True
        lblPax.BackColor = Color.FromArgb(CByte(130), CByte(202), CByte(156))
        lblPax.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        lblPax.Location = New Point(95, 145)
        lblPax.Name = "lblPax"
        lblPax.Size = New Size(165, 25)
        lblPax.TabIndex = 4
        lblPax.Text = "Number of People"
        ' 
        ' lblPaxUnit
        ' 
        lblPaxUnit.AutoSize = True
        lblPaxUnit.BackColor = Color.FromArgb(CByte(130), CByte(202), CByte(156))
        lblPaxUnit.Location = New Point(221, 188)
        lblPaxUnit.Name = "lblPaxUnit"
        lblPaxUnit.Size = New Size(29, 15)
        lblPaxUnit.TabIndex = 5
        lblPaxUnit.Text = "pax."
        ' 
        ' picPaxBorder
        ' 
        picPaxBorder.Image = My.Resources.Resources.border
        picPaxBorder.Location = New Point(64, 128)
        picPaxBorder.Name = "picPaxBorder"
        picPaxBorder.Size = New Size(219, 93)
        picPaxBorder.SizeMode = PictureBoxSizeMode.StretchImage
        picPaxBorder.TabIndex = 6
        picPaxBorder.TabStop = False
        ' 
        ' listTours
        ' 
        listTours.BackColor = Color.FromArgb(CByte(130), CByte(202), CByte(156))
        listTours.BorderStyle = BorderStyle.None
        listTours.FormattingEnabled = True
        listTours.ItemHeight = 15
        listTours.Location = New Point(347, 151)
        listTours.Name = "listTours"
        listTours.Size = New Size(228, 120)
        listTours.TabIndex = 7
        ' 
        ' picToursList
        ' 
        picToursList.Image = My.Resources.Resources.border
        picToursList.Location = New Point(335, 106)
        picToursList.Name = "picToursList"
        picToursList.Size = New Size(250, 180)
        picToursList.SizeMode = PictureBoxSizeMode.StretchImage
        picToursList.TabIndex = 8
        picToursList.TabStop = False
        ' 
        ' btnFindCost
        ' 
        btnFindCost.Location = New Point(69, 263)
        btnFindCost.Name = "btnFindCost"
        btnFindCost.Size = New Size(75, 23)
        btnFindCost.TabIndex = 9
        btnFindCost.Text = "Find Cost"
        btnFindCost.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(208, 263)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 10
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' lblTour
        ' 
        lblTour.AutoSize = True
        lblTour.BackColor = Color.FromArgb(CByte(130), CByte(202), CByte(156))
        lblTour.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        lblTour.Location = New Point(392, 123)
        lblTour.Name = "lblTour"
        lblTour.Size = New Size(137, 25)
        lblTour.TabIndex = 11
        lblTour.Text = "Select Itinerary"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.Transparent
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 31.50685F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 68.49315F))
        TableLayoutPanel1.Controls.Add(lblResultLengthValue, 1, 2)
        TableLayoutPanel1.Controls.Add(lblResultCostValue, 1, 1)
        TableLayoutPanel1.Controls.Add(lblResultTourValue, 1, 0)
        TableLayoutPanel1.Controls.Add(lblResultCost, 0, 1)
        TableLayoutPanel1.Controls.Add(lblResultTour, 0, 0)
        TableLayoutPanel1.Controls.Add(lblResultLength, 0, 2)
        TableLayoutPanel1.Location = New Point(64, 309)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Size = New Size(273, 58)
        TableLayoutPanel1.TabIndex = 12
        ' 
        ' lblResultLengthValue
        ' 
        lblResultLengthValue.Anchor = AnchorStyles.Left
        lblResultLengthValue.AutoSize = True
        lblResultLengthValue.BackColor = Color.Transparent
        lblResultLengthValue.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblResultLengthValue.Location = New Point(89, 38)
        lblResultLengthValue.Name = "lblResultLengthValue"
        lblResultLengthValue.Size = New Size(36, 20)
        lblResultLengthValue.TabIndex = 18
        lblResultLengthValue.Text = "N/A"
        lblResultLengthValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblResultCostValue
        ' 
        lblResultCostValue.Anchor = AnchorStyles.Left
        lblResultCostValue.AutoSize = True
        lblResultCostValue.BackColor = Color.Transparent
        lblResultCostValue.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblResultCostValue.Location = New Point(89, 19)
        lblResultCostValue.Name = "lblResultCostValue"
        lblResultCostValue.Size = New Size(36, 19)
        lblResultCostValue.TabIndex = 17
        lblResultCostValue.Text = "N/A"
        lblResultCostValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblResultTourValue
        ' 
        lblResultTourValue.Anchor = AnchorStyles.Left
        lblResultTourValue.AutoSize = True
        lblResultTourValue.BackColor = Color.Transparent
        lblResultTourValue.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblResultTourValue.Location = New Point(89, 0)
        lblResultTourValue.Name = "lblResultTourValue"
        lblResultTourValue.Size = New Size(36, 19)
        lblResultTourValue.TabIndex = 16
        lblResultTourValue.Text = "N/A"
        lblResultTourValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblResultCost
        ' 
        lblResultCost.Anchor = AnchorStyles.Right
        lblResultCost.AutoSize = True
        lblResultCost.BackColor = Color.Transparent
        lblResultCost.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblResultCost.Location = New Point(39, 19)
        lblResultCost.Name = "lblResultCost"
        lblResultCost.Size = New Size(44, 19)
        lblResultCost.TabIndex = 15
        lblResultCost.Text = "Cost:"
        lblResultCost.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblResultTour
        ' 
        lblResultTour.Anchor = AnchorStyles.Right
        lblResultTour.AutoSize = True
        lblResultTour.BackColor = Color.Transparent
        lblResultTour.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblResultTour.Location = New Point(37, 0)
        lblResultTour.Name = "lblResultTour"
        lblResultTour.Size = New Size(46, 19)
        lblResultTour.TabIndex = 13
        lblResultTour.Text = "Tour:"
        lblResultTour.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblResultLength
        ' 
        lblResultLength.Anchor = AnchorStyles.Right
        lblResultLength.AutoSize = True
        lblResultLength.BackColor = Color.Transparent
        lblResultLength.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblResultLength.Location = New Point(21, 38)
        lblResultLength.Name = "lblResultLength"
        lblResultLength.Size = New Size(62, 20)
        lblResultLength.TabIndex = 14
        lblResultLength.Text = "Length:"
        lblResultLength.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' SlotReservationForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.pexels_jess_loiterton_4602279
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(617, 379)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(lblTour)
        Controls.Add(btnClear)
        Controls.Add(btnFindCost)
        Controls.Add(listTours)
        Controls.Add(lblPaxUnit)
        Controls.Add(lblPax)
        Controls.Add(numPersonQuantity)
        Controls.Add(PictureBox1)
        Controls.Add(comboLocation)
        Controls.Add(MenuStrip1)
        Controls.Add(picPaxBorder)
        Controls.Add(picToursList)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "SlotReservationForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SlotReservationForm"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(numPersonQuantity, ComponentModel.ISupportInitialize).EndInit()
        CType(picPaxBorder, ComponentModel.ISupportInitialize).EndInit()
        CType(picToursList, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents comboLocation As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents numPersonQuantity As NumericUpDown
    Friend WithEvents lblPax As Label
    Friend WithEvents lblPaxUnit As Label
    Friend WithEvents picPaxBorder As PictureBox
    Friend WithEvents listTours As ListBox
    Friend WithEvents picToursList As PictureBox
    Friend WithEvents btnFindCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblTour As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblResultCost As Label
    Friend WithEvents lblResultTour As Label
    Friend WithEvents lblResultLength As Label
    Friend WithEvents lblResultLengthValue As Label
    Friend WithEvents lblResultCostValue As Label
    Friend WithEvents lblResultTourValue As Label
End Class

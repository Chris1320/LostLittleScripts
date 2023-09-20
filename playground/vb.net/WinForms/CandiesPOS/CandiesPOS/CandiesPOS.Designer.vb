<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CandiesPOS
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(CandiesPOS))
        lblTitle = New Label()
        lblCandyA = New Label()
        numCandyAWeight = New NumericUpDown()
        lblCandyADesc = New Label()
        lblCandyAKg = New Label()
        lblCandyBKg = New Label()
        lblCandyBDesc = New Label()
        numCandyBWeight = New NumericUpDown()
        lblCandyB = New Label()
        lblCandyDKg = New Label()
        lblCandyDDesc = New Label()
        numCandyDWeight = New NumericUpDown()
        lblCandyD = New Label()
        lblCandyCKg = New Label()
        lblCandyCDesc = New Label()
        numCandyCWeight = New NumericUpDown()
        lblCandyC = New Label()
        btnCompute = New Button()
        txtTotalWeight = New TextBox()
        lblTotalWeight = New Label()
        txtCandyAPrice = New TextBox()
        txtCandyBPrice = New TextBox()
        txtCandyCPrice = New TextBox()
        txtCandyDPrice = New TextBox()
        txtTotalPrice = New TextBox()
        picTitleLogo = New PictureBox()
        picCandyAmountLow = New PictureBox()
        picCandyAmountMid = New PictureBox()
        picCandyAmountHigh = New PictureBox()
        picCandyAmountNone = New PictureBox()
        CType(numCandyAWeight, ComponentModel.ISupportInitialize).BeginInit()
        CType(numCandyBWeight, ComponentModel.ISupportInitialize).BeginInit()
        CType(numCandyDWeight, ComponentModel.ISupportInitialize).BeginInit()
        CType(numCandyCWeight, ComponentModel.ISupportInitialize).BeginInit()
        CType(picTitleLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(picCandyAmountLow, ComponentModel.ISupportInitialize).BeginInit()
        CType(picCandyAmountMid, ComponentModel.ISupportInitialize).BeginInit()
        CType(picCandyAmountHigh, ComponentModel.ISupportInitialize).BeginInit()
        CType(picCandyAmountNone, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.Anchor = AnchorStyles.Top
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Noto Sans", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitle.Location = New Point(137, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(322, 39)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Candies Point-of-Sale"
        lblTitle.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblCandyA
        ' 
        lblCandyA.AutoSize = True
        lblCandyA.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblCandyA.Location = New Point(39, 96)
        lblCandyA.Name = "lblCandyA"
        lblCandyA.Size = New Size(95, 30)
        lblCandyA.TabIndex = 1
        lblCandyA.Text = "Candy A"
        ' 
        ' numCandyAWeight
        ' 
        numCandyAWeight.DecimalPlaces = 2
        numCandyAWeight.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        numCandyAWeight.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        numCandyAWeight.Location = New Point(213, 94)
        numCandyAWeight.Name = "numCandyAWeight"
        numCandyAWeight.Size = New Size(81, 35)
        numCandyAWeight.TabIndex = 2
        numCandyAWeight.ThousandsSeparator = True
        ' 
        ' lblCandyADesc
        ' 
        lblCandyADesc.AutoSize = True
        lblCandyADesc.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point)
        lblCandyADesc.Location = New Point(56, 126)
        lblCandyADesc.Name = "lblCandyADesc"
        lblCandyADesc.Size = New Size(78, 15)
        lblCandyADesc.TabIndex = 3
        lblCandyADesc.Text = "PHP 42.25/kg"
        ' 
        ' lblCandyAKg
        ' 
        lblCandyAKg.AutoSize = True
        lblCandyAKg.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblCandyAKg.Location = New Point(300, 96)
        lblCandyAKg.Name = "lblCandyAKg"
        lblCandyAKg.Size = New Size(35, 30)
        lblCandyAKg.TabIndex = 4
        lblCandyAKg.Text = "kg"
        ' 
        ' lblCandyBKg
        ' 
        lblCandyBKg.AutoSize = True
        lblCandyBKg.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblCandyBKg.Location = New Point(300, 149)
        lblCandyBKg.Name = "lblCandyBKg"
        lblCandyBKg.Size = New Size(35, 30)
        lblCandyBKg.TabIndex = 8
        lblCandyBKg.Text = "kg"
        ' 
        ' lblCandyBDesc
        ' 
        lblCandyBDesc.AutoSize = True
        lblCandyBDesc.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point)
        lblCandyBDesc.Location = New Point(56, 179)
        lblCandyBDesc.Name = "lblCandyBDesc"
        lblCandyBDesc.Size = New Size(78, 15)
        lblCandyBDesc.TabIndex = 7
        lblCandyBDesc.Text = "PHP 36.75/kg"
        ' 
        ' numCandyBWeight
        ' 
        numCandyBWeight.DecimalPlaces = 2
        numCandyBWeight.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        numCandyBWeight.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        numCandyBWeight.Location = New Point(213, 147)
        numCandyBWeight.Name = "numCandyBWeight"
        numCandyBWeight.Size = New Size(81, 35)
        numCandyBWeight.TabIndex = 6
        numCandyBWeight.ThousandsSeparator = True
        ' 
        ' lblCandyB
        ' 
        lblCandyB.AutoSize = True
        lblCandyB.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblCandyB.Location = New Point(39, 149)
        lblCandyB.Name = "lblCandyB"
        lblCandyB.Size = New Size(93, 30)
        lblCandyB.TabIndex = 5
        lblCandyB.Text = "Candy B"
        ' 
        ' lblCandyDKg
        ' 
        lblCandyDKg.AutoSize = True
        lblCandyDKg.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblCandyDKg.Location = New Point(300, 259)
        lblCandyDKg.Name = "lblCandyDKg"
        lblCandyDKg.Size = New Size(35, 30)
        lblCandyDKg.TabIndex = 16
        lblCandyDKg.Text = "kg"
        ' 
        ' lblCandyDDesc
        ' 
        lblCandyDDesc.AutoSize = True
        lblCandyDDesc.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point)
        lblCandyDDesc.Location = New Point(56, 289)
        lblCandyDDesc.Name = "lblCandyDDesc"
        lblCandyDDesc.Size = New Size(78, 15)
        lblCandyDDesc.TabIndex = 15
        lblCandyDDesc.Text = "PHP 29.50/kg"
        ' 
        ' numCandyDWeight
        ' 
        numCandyDWeight.DecimalPlaces = 2
        numCandyDWeight.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        numCandyDWeight.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        numCandyDWeight.Location = New Point(213, 257)
        numCandyDWeight.Name = "numCandyDWeight"
        numCandyDWeight.Size = New Size(81, 35)
        numCandyDWeight.TabIndex = 14
        numCandyDWeight.ThousandsSeparator = True
        ' 
        ' lblCandyD
        ' 
        lblCandyD.AutoSize = True
        lblCandyD.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblCandyD.Location = New Point(39, 259)
        lblCandyD.Name = "lblCandyD"
        lblCandyD.Size = New Size(95, 30)
        lblCandyD.TabIndex = 13
        lblCandyD.Text = "Candy D"
        ' 
        ' lblCandyCKg
        ' 
        lblCandyCKg.AutoSize = True
        lblCandyCKg.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblCandyCKg.Location = New Point(300, 206)
        lblCandyCKg.Name = "lblCandyCKg"
        lblCandyCKg.Size = New Size(35, 30)
        lblCandyCKg.TabIndex = 12
        lblCandyCKg.Text = "kg"
        ' 
        ' lblCandyCDesc
        ' 
        lblCandyCDesc.AutoSize = True
        lblCandyCDesc.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point)
        lblCandyCDesc.Location = New Point(56, 236)
        lblCandyCDesc.Name = "lblCandyCDesc"
        lblCandyCDesc.Size = New Size(78, 15)
        lblCandyCDesc.TabIndex = 11
        lblCandyCDesc.Text = "PHP 48.00/kg"
        ' 
        ' numCandyCWeight
        ' 
        numCandyCWeight.DecimalPlaces = 2
        numCandyCWeight.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        numCandyCWeight.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        numCandyCWeight.Location = New Point(213, 204)
        numCandyCWeight.Name = "numCandyCWeight"
        numCandyCWeight.Size = New Size(81, 35)
        numCandyCWeight.TabIndex = 10
        numCandyCWeight.ThousandsSeparator = True
        ' 
        ' lblCandyC
        ' 
        lblCandyC.AutoSize = True
        lblCandyC.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblCandyC.Location = New Point(39, 206)
        lblCandyC.Name = "lblCandyC"
        lblCandyC.Size = New Size(93, 30)
        lblCandyC.TabIndex = 9
        lblCandyC.Text = "Candy C"
        ' 
        ' btnCompute
        ' 
        btnCompute.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnCompute.Location = New Point(395, 386)
        btnCompute.Name = "btnCompute"
        btnCompute.Size = New Size(116, 41)
        btnCompute.TabIndex = 17
        btnCompute.Text = "Compute"
        btnCompute.UseVisualStyleBackColor = True
        ' 
        ' txtTotalWeight
        ' 
        txtTotalWeight.BackColor = SystemColors.Window
        txtTotalWeight.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtTotalWeight.Location = New Point(147, 327)
        txtTotalWeight.Name = "txtTotalWeight"
        txtTotalWeight.ReadOnly = True
        txtTotalWeight.Size = New Size(100, 27)
        txtTotalWeight.TabIndex = 18
        ' 
        ' lblTotalWeight
        ' 
        lblTotalWeight.AutoSize = True
        lblTotalWeight.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblTotalWeight.Location = New Point(39, 330)
        lblTotalWeight.Name = "lblTotalWeight"
        lblTotalWeight.Size = New Size(93, 20)
        lblTotalWeight.TabIndex = 19
        lblTotalWeight.Text = "Total Weight"
        ' 
        ' txtCandyAPrice
        ' 
        txtCandyAPrice.BackColor = SystemColors.Window
        txtCandyAPrice.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtCandyAPrice.Location = New Point(395, 94)
        txtCandyAPrice.Name = "txtCandyAPrice"
        txtCandyAPrice.ReadOnly = True
        txtCandyAPrice.Size = New Size(116, 35)
        txtCandyAPrice.TabIndex = 20
        ' 
        ' txtCandyBPrice
        ' 
        txtCandyBPrice.BackColor = SystemColors.Window
        txtCandyBPrice.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtCandyBPrice.Location = New Point(395, 147)
        txtCandyBPrice.Name = "txtCandyBPrice"
        txtCandyBPrice.ReadOnly = True
        txtCandyBPrice.Size = New Size(116, 35)
        txtCandyBPrice.TabIndex = 21
        ' 
        ' txtCandyCPrice
        ' 
        txtCandyCPrice.BackColor = SystemColors.Window
        txtCandyCPrice.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtCandyCPrice.Location = New Point(395, 204)
        txtCandyCPrice.Name = "txtCandyCPrice"
        txtCandyCPrice.ReadOnly = True
        txtCandyCPrice.Size = New Size(116, 35)
        txtCandyCPrice.TabIndex = 22
        ' 
        ' txtCandyDPrice
        ' 
        txtCandyDPrice.BackColor = SystemColors.Window
        txtCandyDPrice.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtCandyDPrice.Location = New Point(395, 257)
        txtCandyDPrice.Name = "txtCandyDPrice"
        txtCandyDPrice.ReadOnly = True
        txtCandyDPrice.Size = New Size(116, 35)
        txtCandyDPrice.TabIndex = 23
        ' 
        ' txtTotalPrice
        ' 
        txtTotalPrice.BackColor = SystemColors.Window
        txtTotalPrice.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtTotalPrice.Location = New Point(395, 327)
        txtTotalPrice.Name = "txtTotalPrice"
        txtTotalPrice.PlaceholderText = "Total"
        txtTotalPrice.ReadOnly = True
        txtTotalPrice.Size = New Size(116, 35)
        txtTotalPrice.TabIndex = 24
        ' 
        ' picTitleLogo
        ' 
        picTitleLogo.Image = My.Resources.Resources.logo
        picTitleLogo.Location = New Point(81, 9)
        picTitleLogo.Name = "picTitleLogo"
        picTitleLogo.Size = New Size(50, 50)
        picTitleLogo.SizeMode = PictureBoxSizeMode.Zoom
        picTitleLogo.TabIndex = 25
        picTitleLogo.TabStop = False
        ' 
        ' picCandyAmountLow
        ' 
        picCandyAmountLow.Image = My.Resources.Resources.candy_low_circled
        picCandyAmountLow.Location = New Point(272, 327)
        picCandyAmountLow.Name = "picCandyAmountLow"
        picCandyAmountLow.Size = New Size(100, 100)
        picCandyAmountLow.SizeMode = PictureBoxSizeMode.Zoom
        picCandyAmountLow.TabIndex = 26
        picCandyAmountLow.TabStop = False
        picCandyAmountLow.Visible = False
        ' 
        ' picCandyAmountMid
        ' 
        picCandyAmountMid.Image = My.Resources.Resources.candy_mid_circled
        picCandyAmountMid.Location = New Point(272, 327)
        picCandyAmountMid.Name = "picCandyAmountMid"
        picCandyAmountMid.Size = New Size(100, 100)
        picCandyAmountMid.SizeMode = PictureBoxSizeMode.Zoom
        picCandyAmountMid.TabIndex = 27
        picCandyAmountMid.TabStop = False
        picCandyAmountMid.Visible = False
        ' 
        ' picCandyAmountHigh
        ' 
        picCandyAmountHigh.Image = My.Resources.Resources.candy_high_circled
        picCandyAmountHigh.Location = New Point(272, 327)
        picCandyAmountHigh.Name = "picCandyAmountHigh"
        picCandyAmountHigh.Size = New Size(100, 100)
        picCandyAmountHigh.SizeMode = PictureBoxSizeMode.Zoom
        picCandyAmountHigh.TabIndex = 28
        picCandyAmountHigh.TabStop = False
        picCandyAmountHigh.Visible = False
        ' 
        ' picCandyAmountNone
        ' 
        picCandyAmountNone.Image = My.Resources.Resources.circle
        picCandyAmountNone.Location = New Point(272, 327)
        picCandyAmountNone.Name = "picCandyAmountNone"
        picCandyAmountNone.Size = New Size(100, 100)
        picCandyAmountNone.SizeMode = PictureBoxSizeMode.Zoom
        picCandyAmountNone.TabIndex = 29
        picCandyAmountNone.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(549, 450)
        Controls.Add(picCandyAmountNone)
        Controls.Add(picTitleLogo)
        Controls.Add(txtTotalPrice)
        Controls.Add(txtCandyDPrice)
        Controls.Add(txtCandyCPrice)
        Controls.Add(txtCandyBPrice)
        Controls.Add(txtCandyAPrice)
        Controls.Add(lblTotalWeight)
        Controls.Add(txtTotalWeight)
        Controls.Add(btnCompute)
        Controls.Add(lblCandyDKg)
        Controls.Add(lblCandyDDesc)
        Controls.Add(numCandyDWeight)
        Controls.Add(lblCandyD)
        Controls.Add(lblCandyCKg)
        Controls.Add(lblCandyCDesc)
        Controls.Add(numCandyCWeight)
        Controls.Add(lblCandyC)
        Controls.Add(lblCandyBKg)
        Controls.Add(lblCandyBDesc)
        Controls.Add(numCandyBWeight)
        Controls.Add(lblCandyB)
        Controls.Add(lblCandyAKg)
        Controls.Add(lblCandyADesc)
        Controls.Add(numCandyAWeight)
        Controls.Add(lblCandyA)
        Controls.Add(lblTitle)
        Controls.Add(picCandyAmountHigh)
        Controls.Add(picCandyAmountMid)
        Controls.Add(picCandyAmountLow)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = "Candies Point-of-Sale"
        CType(numCandyAWeight, ComponentModel.ISupportInitialize).EndInit()
        CType(numCandyBWeight, ComponentModel.ISupportInitialize).EndInit()
        CType(numCandyDWeight, ComponentModel.ISupportInitialize).EndInit()
        CType(numCandyCWeight, ComponentModel.ISupportInitialize).EndInit()
        CType(picTitleLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(picCandyAmountLow, ComponentModel.ISupportInitialize).EndInit()
        CType(picCandyAmountMid, ComponentModel.ISupportInitialize).EndInit()
        CType(picCandyAmountHigh, ComponentModel.ISupportInitialize).EndInit()
        CType(picCandyAmountNone, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblCandyA As Label
    Friend WithEvents numCandyAWeight As NumericUpDown
    Friend WithEvents lblCandyADesc As Label
    Friend WithEvents lblCandyAKg As Label
    Friend WithEvents lblCandyBKg As Label
    Friend WithEvents lblCandyBDesc As Label
    Friend WithEvents numCandyBWeight As NumericUpDown
    Friend WithEvents lblCandyB As Label
    Friend WithEvents lblCandyDKg As Label
    Friend WithEvents lblCandyDDesc As Label
    Friend WithEvents numCandyDWeight As NumericUpDown
    Friend WithEvents lblCandyD As Label
    Friend WithEvents lblCandyCKg As Label
    Friend WithEvents lblCandyCDesc As Label
    Friend WithEvents numCandyCWeight As NumericUpDown
    Friend WithEvents lblCandyC As Label
    Friend WithEvents btnCompute As Button
    Friend WithEvents txtTotalWeight As TextBox
    Friend WithEvents lblTotalWeight As Label
    Friend WithEvents txtCandyAPrice As TextBox
    Friend WithEvents txtCandyBPrice As TextBox
    Friend WithEvents txtCandyCPrice As TextBox
    Friend WithEvents txtCandyDPrice As TextBox
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents picTitleLogo As PictureBox
    Friend WithEvents picCandyAmountLow As PictureBox
    Friend WithEvents picCandyAmountMid As PictureBox
    Friend WithEvents picCandyAmountHigh As PictureBox
    Friend WithEvents picCandyAmountNone As PictureBox
End Class

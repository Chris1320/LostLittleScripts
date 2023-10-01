<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VirtualBrewCafe
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(VirtualBrewCafe))
        comboMenuType = New ComboBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        btnOrderButton1 = New Button()
        btnOrderButton2 = New Button()
        btnOrderButton3 = New Button()
        btnOrderButton4 = New Button()
        btnOrderButton5 = New Button()
        NumOrderButton1 = New NumericUpDown()
        NumOrderButton2 = New NumericUpDown()
        NumOrderButton3 = New NumericUpDown()
        NumOrderButton4 = New NumericUpDown()
        NumOrderButton5 = New NumericUpDown()
        PictureBox3 = New PictureBox()
        dgOrderList = New DataGridView()
        lblPrice1 = New Label()
        btnVoid = New Button()
        btnCheckout = New Button()
        Label3 = New Label()
        txtTotal = New TextBox()
        lblPrice2 = New Label()
        lblPrice3 = New Label()
        lblPrice4 = New Label()
        lblPrice5 = New Label()
        btnVoidAll = New Button()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        Order = New DataGridViewTextBoxColumn()
        Quantity = New DataGridViewTextBoxColumn()
        TotalPrice = New DataGridViewTextBoxColumn()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumOrderButton1, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumOrderButton2, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumOrderButton3, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumOrderButton4, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumOrderButton5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgOrderList, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' comboMenuType
        ' 
        comboMenuType.FormattingEnabled = True
        comboMenuType.Items.AddRange(New Object() {"Breakfast", "Lunch", "Dinner"})
        comboMenuType.Location = New Point(45, 88)
        comboMenuType.Name = "comboMenuType"
        comboMenuType.Size = New Size(176, 23)
        comboMenuType.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.virtual_brew_cafe
        PictureBox1.Location = New Point(253, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(535, 130)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.border
        PictureBox2.Location = New Point(25, 36)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(222, 92)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(253), CByte(198), CByte(137))
        Label1.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(73, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 30)
        Label1.TabIndex = 0
        Label1.Text = "Menu Type"
        ' 
        ' btnOrderButton1
        ' 
        btnOrderButton1.Cursor = Cursors.Hand
        btnOrderButton1.Location = New Point(187, 160)
        btnOrderButton1.Name = "btnOrderButton1"
        btnOrderButton1.Size = New Size(121, 48)
        btnOrderButton1.TabIndex = 3
        btnOrderButton1.Text = "N/A"
        btnOrderButton1.UseVisualStyleBackColor = True
        ' 
        ' btnOrderButton2
        ' 
        btnOrderButton2.Cursor = Cursors.Hand
        btnOrderButton2.Location = New Point(187, 214)
        btnOrderButton2.Name = "btnOrderButton2"
        btnOrderButton2.Size = New Size(121, 48)
        btnOrderButton2.TabIndex = 5
        btnOrderButton2.Text = "N/A"
        btnOrderButton2.UseVisualStyleBackColor = True
        ' 
        ' btnOrderButton3
        ' 
        btnOrderButton3.Cursor = Cursors.Hand
        btnOrderButton3.Location = New Point(187, 268)
        btnOrderButton3.Name = "btnOrderButton3"
        btnOrderButton3.Size = New Size(121, 48)
        btnOrderButton3.TabIndex = 7
        btnOrderButton3.Text = "N/A"
        btnOrderButton3.UseVisualStyleBackColor = True
        ' 
        ' btnOrderButton4
        ' 
        btnOrderButton4.Cursor = Cursors.Hand
        btnOrderButton4.Location = New Point(187, 322)
        btnOrderButton4.Name = "btnOrderButton4"
        btnOrderButton4.Size = New Size(121, 48)
        btnOrderButton4.TabIndex = 9
        btnOrderButton4.Text = "N/A"
        btnOrderButton4.UseVisualStyleBackColor = True
        ' 
        ' btnOrderButton5
        ' 
        btnOrderButton5.Cursor = Cursors.Hand
        btnOrderButton5.Location = New Point(187, 376)
        btnOrderButton5.Name = "btnOrderButton5"
        btnOrderButton5.Size = New Size(121, 48)
        btnOrderButton5.TabIndex = 11
        btnOrderButton5.Text = "N/A"
        btnOrderButton5.UseVisualStyleBackColor = True
        ' 
        ' NumOrderButton1
        ' 
        NumOrderButton1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        NumOrderButton1.Location = New Point(45, 163)
        NumOrderButton1.Name = "NumOrderButton1"
        NumOrderButton1.Size = New Size(120, 35)
        NumOrderButton1.TabIndex = 2
        ' 
        ' NumOrderButton2
        ' 
        NumOrderButton2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        NumOrderButton2.Location = New Point(45, 217)
        NumOrderButton2.Name = "NumOrderButton2"
        NumOrderButton2.Size = New Size(120, 35)
        NumOrderButton2.TabIndex = 4
        ' 
        ' NumOrderButton3
        ' 
        NumOrderButton3.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        NumOrderButton3.Location = New Point(45, 271)
        NumOrderButton3.Name = "NumOrderButton3"
        NumOrderButton3.Size = New Size(120, 35)
        NumOrderButton3.TabIndex = 6
        ' 
        ' NumOrderButton4
        ' 
        NumOrderButton4.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        NumOrderButton4.Location = New Point(45, 325)
        NumOrderButton4.Name = "NumOrderButton4"
        NumOrderButton4.Size = New Size(120, 35)
        NumOrderButton4.TabIndex = 8
        ' 
        ' NumOrderButton5
        ' 
        NumOrderButton5.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        NumOrderButton5.Location = New Point(45, 379)
        NumOrderButton5.Name = "NumOrderButton5"
        NumOrderButton5.Size = New Size(120, 35)
        NumOrderButton5.TabIndex = 10
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.chalkboard
        PictureBox3.Location = New Point(442, 148)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(346, 222)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 12
        PictureBox3.TabStop = False
        ' 
        ' dgOrderList
        ' 
        dgOrderList.AllowUserToAddRows = False
        dgOrderList.AllowUserToDeleteRows = False
        dgOrderList.AllowUserToOrderColumns = True
        dgOrderList.BackgroundColor = SystemColors.ActiveCaptionText
        dgOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgOrderList.Columns.AddRange(New DataGridViewColumn() {Order, Quantity, TotalPrice})
        dgOrderList.Location = New Point(458, 160)
        dgOrderList.Name = "dgOrderList"
        dgOrderList.ReadOnly = True
        dgOrderList.RowTemplate.Height = 25
        dgOrderList.Size = New Size(314, 195)
        dgOrderList.TabIndex = 13
        ' 
        ' lblPrice1
        ' 
        lblPrice1.AutoSize = True
        lblPrice1.BackColor = Color.FromArgb(CByte(253), CByte(198), CByte(137))
        lblPrice1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblPrice1.ForeColor = Color.LightYellow
        lblPrice1.Location = New Point(323, 172)
        lblPrice1.Name = "lblPrice1"
        lblPrice1.Size = New Size(80, 21)
        lblPrice1.TabIndex = 14
        lblPrice1.Text = "PHP ---.--"
        ' 
        ' btnVoid
        ' 
        btnVoid.BackColor = Color.IndianRed
        btnVoid.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnVoid.ForeColor = Color.White
        btnVoid.Location = New Point(441, 376)
        btnVoid.Name = "btnVoid"
        btnVoid.Size = New Size(90, 33)
        btnVoid.TabIndex = 15
        btnVoid.Text = "Void"
        btnVoid.UseVisualStyleBackColor = False
        ' 
        ' btnCheckout
        ' 
        btnCheckout.BackColor = Color.Green
        btnCheckout.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnCheckout.ForeColor = Color.Snow
        btnCheckout.Location = New Point(533, 376)
        btnCheckout.Name = "btnCheckout"
        btnCheckout.Size = New Size(115, 72)
        btnCheckout.TabIndex = 16
        btnCheckout.Text = "Bill Checkout"
        btnCheckout.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.WhiteSmoke
        Label3.Location = New Point(694, 379)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 21)
        Label3.TabIndex = 17
        Label3.Text = "Total"
        ' 
        ' txtTotal
        ' 
        txtTotal.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtTotal.Location = New Point(654, 403)
        txtTotal.Name = "txtTotal"
        txtTotal.ReadOnly = True
        txtTotal.Size = New Size(134, 35)
        txtTotal.TabIndex = 18
        ' 
        ' lblPrice2
        ' 
        lblPrice2.AutoSize = True
        lblPrice2.BackColor = Color.FromArgb(CByte(253), CByte(198), CByte(137))
        lblPrice2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblPrice2.ForeColor = Color.LightYellow
        lblPrice2.Location = New Point(323, 226)
        lblPrice2.Name = "lblPrice2"
        lblPrice2.Size = New Size(80, 21)
        lblPrice2.TabIndex = 19
        lblPrice2.Text = "PHP ---.--"
        ' 
        ' lblPrice3
        ' 
        lblPrice3.AutoSize = True
        lblPrice3.BackColor = Color.FromArgb(CByte(253), CByte(198), CByte(137))
        lblPrice3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblPrice3.ForeColor = Color.LightYellow
        lblPrice3.Location = New Point(323, 280)
        lblPrice3.Name = "lblPrice3"
        lblPrice3.Size = New Size(80, 21)
        lblPrice3.TabIndex = 20
        lblPrice3.Text = "PHP ---.--"
        ' 
        ' lblPrice4
        ' 
        lblPrice4.AutoSize = True
        lblPrice4.BackColor = Color.FromArgb(CByte(253), CByte(198), CByte(137))
        lblPrice4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblPrice4.ForeColor = Color.LightYellow
        lblPrice4.Location = New Point(323, 334)
        lblPrice4.Name = "lblPrice4"
        lblPrice4.Size = New Size(80, 21)
        lblPrice4.TabIndex = 21
        lblPrice4.Text = "PHP ---.--"
        ' 
        ' lblPrice5
        ' 
        lblPrice5.AutoSize = True
        lblPrice5.BackColor = Color.FromArgb(CByte(253), CByte(198), CByte(137))
        lblPrice5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblPrice5.ForeColor = Color.LightYellow
        lblPrice5.Location = New Point(323, 388)
        lblPrice5.Name = "lblPrice5"
        lblPrice5.Size = New Size(80, 21)
        lblPrice5.TabIndex = 22
        lblPrice5.Text = "PHP ---.--"
        ' 
        ' btnVoidAll
        ' 
        btnVoidAll.BackColor = Color.IndianRed
        btnVoidAll.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnVoidAll.ForeColor = Color.White
        btnVoidAll.Location = New Point(441, 415)
        btnVoidAll.Name = "btnVoidAll"
        btnVoidAll.Size = New Size(90, 33)
        btnVoidAll.TabIndex = 23
        btnVoidAll.Text = "Void All"
        btnVoidAll.UseVisualStyleBackColor = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = My.Resources.Resources.border
        PictureBox4.Location = New Point(314, 165)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(122, 35)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 24
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.Image = My.Resources.Resources.border
        PictureBox5.Location = New Point(313, 219)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(122, 35)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 25
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.Transparent
        PictureBox6.Image = My.Resources.Resources.border
        PictureBox6.Location = New Point(313, 274)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(122, 35)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 26
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.Transparent
        PictureBox7.Image = My.Resources.Resources.border
        PictureBox7.Location = New Point(313, 328)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(122, 35)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 27
        PictureBox7.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = Color.Transparent
        PictureBox8.Image = My.Resources.Resources.border
        PictureBox8.Location = New Point(313, 382)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(122, 35)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 28
        PictureBox8.TabStop = False
        ' 
        ' Order
        ' 
        Order.HeaderText = "Order"
        Order.Name = "Order"
        Order.ReadOnly = True
        ' 
        ' Quantity
        ' 
        Quantity.HeaderText = "Quantity"
        Quantity.Name = "Quantity"
        Quantity.ReadOnly = True
        ' 
        ' TotalPrice
        ' 
        TotalPrice.HeaderText = "Total Price"
        TotalPrice.Name = "TotalPrice"
        TotalPrice.ReadOnly = True
        ' 
        ' VirtualBrewCafe
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Cafe_by_Badriel_on_DeviantArt
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 460)
        Controls.Add(btnVoidAll)
        Controls.Add(lblPrice5)
        Controls.Add(lblPrice4)
        Controls.Add(lblPrice3)
        Controls.Add(lblPrice2)
        Controls.Add(txtTotal)
        Controls.Add(Label3)
        Controls.Add(btnCheckout)
        Controls.Add(btnVoid)
        Controls.Add(lblPrice1)
        Controls.Add(dgOrderList)
        Controls.Add(PictureBox3)
        Controls.Add(NumOrderButton5)
        Controls.Add(NumOrderButton4)
        Controls.Add(NumOrderButton3)
        Controls.Add(NumOrderButton2)
        Controls.Add(NumOrderButton1)
        Controls.Add(btnOrderButton5)
        Controls.Add(btnOrderButton4)
        Controls.Add(btnOrderButton3)
        Controls.Add(btnOrderButton2)
        Controls.Add(btnOrderButton1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(comboMenuType)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox8)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "VirtualBrewCafe"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Virtual Brew Café"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(NumOrderButton1, ComponentModel.ISupportInitialize).EndInit()
        CType(NumOrderButton2, ComponentModel.ISupportInitialize).EndInit()
        CType(NumOrderButton3, ComponentModel.ISupportInitialize).EndInit()
        CType(NumOrderButton4, ComponentModel.ISupportInitialize).EndInit()
        CType(NumOrderButton5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(dgOrderList, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents comboMenuType As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnOrderButton1 As Button
    Friend WithEvents btnOrderButton2 As Button
    Friend WithEvents btnOrderButton3 As Button
    Friend WithEvents btnOrderButton4 As Button
    Friend WithEvents btnOrderButton5 As Button
    Friend WithEvents NumOrderButton1 As NumericUpDown
    Friend WithEvents NumOrderButton2 As NumericUpDown
    Friend WithEvents NumOrderButton3 As NumericUpDown
    Friend WithEvents NumOrderButton4 As NumericUpDown
    Friend WithEvents NumOrderButton5 As NumericUpDown
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents dgOrderList As DataGridView
    Friend WithEvents lblPrice1 As Label
    Friend WithEvents btnVoid As Button
    Friend WithEvents btnCheckout As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblPrice2 As Label
    Friend WithEvents lblPrice3 As Label
    Friend WithEvents lblPrice4 As Label
    Friend WithEvents lblPrice5 As Label
    Friend WithEvents btnVoidAll As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Order As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents TotalPrice As DataGridViewTextBoxColumn
End Class

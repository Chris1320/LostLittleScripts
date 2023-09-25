<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GalaxysCandles
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
        txtFullName = New TextBox()
        txtAddress = New TextBox()
        txtContactNumber = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label1 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtQuantity = New TextBox()
        Label7 = New Label()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        btnPillar = New RadioButton()
        btnVotive = New RadioButton()
        btnTeaLight = New RadioButton()
        listCandleColor = New ListBox()
        Label8 = New Label()
        checkScented = New CheckBox()
        btnOrder = New Button()
        btnShowItemPrices = New Button()
        PictureBox1 = New PictureBox()
        picScented = New PictureBox()
        picCandlePreview = New PictureBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(picScented, ComponentModel.ISupportInitialize).BeginInit()
        CType(picCandlePreview, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtFullName
        ' 
        txtFullName.Location = New Point(6, 38)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(185, 23)
        txtFullName.TabIndex = 0
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(197, 38)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(215, 23)
        txtAddress.TabIndex = 1
        ' 
        ' txtContactNumber
        ' 
        txtContactNumber.Location = New Point(418, 38)
        txtContactNumber.Name = "txtContactNumber"
        txtContactNumber.Size = New Size(154, 23)
        txtContactNumber.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 6F, FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(197, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(31, 11)
        Label2.TabIndex = 5
        Label2.Text = "Address"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 6F, FontStyle.Italic, GraphicsUnit.Point)
        Label3.Location = New Point(6, 24)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 11)
        Label3.TabIndex = 6
        Label3.Text = "Full Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 6F, FontStyle.Italic, GraphicsUnit.Point)
        Label4.Location = New Point(418, 24)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 11)
        Label4.TabIndex = 7
        Label4.Text = "Contact Number"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(144, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(293, 47)
        Label1.TabIndex = 8
        Label1.Text = "Galaxy's Candles"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label5.Location = New Point(226, 56)
        Label5.Name = "Label5"
        Label5.Size = New Size(111, 25)
        Label5.TabIndex = 9
        Label5.Text = "Order Form"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 6F, FontStyle.Italic, GraphicsUnit.Point)
        Label6.Location = New Point(372, 191)
        Label6.Name = "Label6"
        Label6.Size = New Size(36, 11)
        Label6.TabIndex = 11
        Label6.Text = "Quantity"
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(372, 205)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(69, 23)
        txtQuantity.TabIndex = 10
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point)
        Label7.Location = New Point(447, 208)
        Label7.Name = "Label7"
        Label7.Size = New Size(32, 15)
        Label7.TabIndex = 12
        Label7.Text = "pc/s."
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtFullName)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txtAddress)
        GroupBox1.Controls.Add(txtContactNumber)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Location = New Point(12, 94)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(578, 75)
        GroupBox1.TabIndex = 13
        GroupBox1.TabStop = False
        GroupBox1.Text = "Customer Information"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnPillar)
        GroupBox2.Controls.Add(btnVotive)
        GroupBox2.Controls.Add(btnTeaLight)
        GroupBox2.Location = New Point(40, 201)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(163, 107)
        GroupBox2.TabIndex = 14
        GroupBox2.TabStop = False
        GroupBox2.Text = "Candle Style"
        ' 
        ' btnPillar
        ' 
        btnPillar.AutoSize = True
        btnPillar.Location = New Point(6, 77)
        btnPillar.Name = "btnPillar"
        btnPillar.Size = New Size(51, 19)
        btnPillar.TabIndex = 2
        btnPillar.TabStop = True
        btnPillar.Text = "Pillar"
        btnPillar.UseVisualStyleBackColor = True
        ' 
        ' btnVotive
        ' 
        btnVotive.AutoSize = True
        btnVotive.Location = New Point(6, 52)
        btnVotive.Name = "btnVotive"
        btnVotive.Size = New Size(57, 19)
        btnVotive.TabIndex = 1
        btnVotive.TabStop = True
        btnVotive.Text = "Votive"
        btnVotive.UseVisualStyleBackColor = True
        ' 
        ' btnTeaLight
        ' 
        btnTeaLight.AutoSize = True
        btnTeaLight.Location = New Point(6, 27)
        btnTeaLight.Name = "btnTeaLight"
        btnTeaLight.Size = New Size(72, 19)
        btnTeaLight.TabIndex = 0
        btnTeaLight.TabStop = True
        btnTeaLight.Text = "Tea Light"
        btnTeaLight.UseVisualStyleBackColor = True
        ' 
        ' listCandleColor
        ' 
        listCandleColor.FormattingEnabled = True
        listCandleColor.ItemHeight = 15
        listCandleColor.Items.AddRange(New Object() {"Federal Blue", "Sunflower Yellow", "Christmas Red", "Lily White"})
        listCandleColor.Location = New Point(217, 218)
        listCandleColor.Name = "listCandleColor"
        listCandleColor.Size = New Size(120, 79)
        listCandleColor.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(237, 200)
        Label8.Name = "Label8"
        Label8.Size = New Size(76, 15)
        Label8.TabIndex = 16
        Label8.Text = "Candle Color"
        ' 
        ' checkScented
        ' 
        checkScented.AutoSize = True
        checkScented.Location = New Point(496, 204)
        checkScented.Name = "checkScented"
        checkScented.Size = New Size(68, 19)
        checkScented.TabIndex = 17
        checkScented.Text = "Scented"
        checkScented.UseVisualStyleBackColor = True
        ' 
        ' btnOrder
        ' 
        btnOrder.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnOrder.Location = New Point(369, 278)
        btnOrder.Name = "btnOrder"
        btnOrder.Size = New Size(123, 51)
        btnOrder.TabIndex = 18
        btnOrder.Text = "Order Now"
        btnOrder.UseVisualStyleBackColor = True
        ' 
        ' btnShowItemPrices
        ' 
        btnShowItemPrices.Location = New Point(496, 28)
        btnShowItemPrices.Name = "btnShowItemPrices"
        btnShowItemPrices.Size = New Size(75, 53)
        btnShowItemPrices.TabIndex = 19
        btnShowItemPrices.Text = "Show Item Prices"
        btnShowItemPrices.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo
        PictureBox1.Location = New Point(53, 16)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(65, 65)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 20
        PictureBox1.TabStop = False
        ' 
        ' picScented
        ' 
        picScented.Image = My.Resources.Resources.scented
        picScented.Location = New Point(530, 253)
        picScented.Name = "picScented"
        picScented.Size = New Size(25, 25)
        picScented.SizeMode = PictureBoxSizeMode.Zoom
        picScented.TabIndex = 21
        picScented.TabStop = False
        ' 
        ' picCandlePreview
        ' 
        picCandlePreview.Location = New Point(517, 279)
        picCandlePreview.Name = "picCandlePreview"
        picCandlePreview.Size = New Size(50, 50)
        picCandlePreview.SizeMode = PictureBoxSizeMode.Zoom
        picCandlePreview.TabIndex = 22
        picCandlePreview.TabStop = False
        ' 
        ' GalaxysCandles
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(602, 360)
        Controls.Add(picCandlePreview)
        Controls.Add(picScented)
        Controls.Add(PictureBox1)
        Controls.Add(btnShowItemPrices)
        Controls.Add(btnOrder)
        Controls.Add(checkScented)
        Controls.Add(Label8)
        Controls.Add(listCandleColor)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(txtQuantity)
        Controls.Add(Label5)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "GalaxysCandles"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Galaxy's Candles"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(picScented, ComponentModel.ISupportInitialize).EndInit()
        CType(picCandlePreview, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnPillar As RadioButton
    Friend WithEvents btnVotive As RadioButton
    Friend WithEvents btnTeaLight As RadioButton
    Friend WithEvents listCandleColor As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents checkScented As CheckBox
    Friend WithEvents btnOrder As Button
    Friend WithEvents btnShowItemPrices As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents picScented As PictureBox
    Friend WithEvents picCandlePreview As PictureBox
End Class

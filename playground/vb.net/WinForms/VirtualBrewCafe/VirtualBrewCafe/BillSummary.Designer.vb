<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillSummary
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(BillSummary))
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        dgOrderList = New DataGridView()
        lblTotalItems = New Label()
        lblBill = New Label()
        lblTax = New Label()
        lblTotalBill = New Label()
        lblChange = New Label()
        btnDone = New Button()
        txtPayment = New TextBox()
        Order = New DataGridViewTextBoxColumn()
        Quantity = New DataGridViewTextBoxColumn()
        TotalPrice = New DataGridViewTextBoxColumn()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgOrderList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.total_bill
        PictureBox1.Location = New Point(199, 56)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(213, 50)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.coffee
        PictureBox2.Location = New Point(118, 31)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(75, 75)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = My.Resources.Resources.total_items
        PictureBox3.Location = New Point(69, 360)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(124, 31)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = My.Resources.Resources.bills
        PictureBox4.Location = New Point(359, 360)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(100, 75)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 3
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.Image = My.Resources.Resources.payment
        PictureBox5.Location = New Point(347, 441)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(123, 72)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 4
        PictureBox5.TabStop = False
        ' 
        ' dgOrderList
        ' 
        dgOrderList.AllowUserToAddRows = False
        dgOrderList.AllowUserToDeleteRows = False
        dgOrderList.AllowUserToOrderColumns = True
        dgOrderList.BackgroundColor = SystemColors.ActiveCaptionText
        dgOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgOrderList.Columns.AddRange(New DataGridViewColumn() {Order, Quantity, TotalPrice})
        dgOrderList.Location = New Point(38, 112)
        dgOrderList.Name = "dgOrderList"
        dgOrderList.RowTemplate.Height = 25
        dgOrderList.Size = New Size(541, 232)
        dgOrderList.TabIndex = 5
        ' 
        ' lblTotalItems
        ' 
        lblTotalItems.AutoSize = True
        lblTotalItems.BackColor = Color.Transparent
        lblTotalItems.Font = New Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point)
        lblTotalItems.ForeColor = SystemColors.ControlLightLight
        lblTotalItems.Location = New Point(199, 360)
        lblTotalItems.Name = "lblTotalItems"
        lblTotalItems.Size = New Size(50, 30)
        lblTotalItems.TabIndex = 6
        lblTotalItems.Text = "N/A"
        ' 
        ' lblBill
        ' 
        lblBill.AutoSize = True
        lblBill.BackColor = Color.Transparent
        lblBill.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point)
        lblBill.ForeColor = SystemColors.ControlLightLight
        lblBill.Location = New Point(478, 358)
        lblBill.Name = "lblBill"
        lblBill.Size = New Size(38, 21)
        lblBill.TabIndex = 7
        lblBill.Text = "N/A"
        ' 
        ' lblTax
        ' 
        lblTax.AutoSize = True
        lblTax.BackColor = Color.Transparent
        lblTax.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point)
        lblTax.ForeColor = SystemColors.ControlLightLight
        lblTax.Location = New Point(478, 385)
        lblTax.Name = "lblTax"
        lblTax.Size = New Size(38, 21)
        lblTax.TabIndex = 8
        lblTax.Text = "N/A"
        ' 
        ' lblTotalBill
        ' 
        lblTotalBill.AutoSize = True
        lblTotalBill.BackColor = Color.Transparent
        lblTotalBill.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point)
        lblTotalBill.ForeColor = SystemColors.ControlLightLight
        lblTotalBill.Location = New Point(478, 412)
        lblTotalBill.Name = "lblTotalBill"
        lblTotalBill.Size = New Size(38, 21)
        lblTotalBill.TabIndex = 9
        lblTotalBill.Text = "N/A"
        ' 
        ' lblChange
        ' 
        lblChange.AutoSize = True
        lblChange.BackColor = Color.Transparent
        lblChange.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point)
        lblChange.ForeColor = SystemColors.ControlLightLight
        lblChange.Location = New Point(476, 477)
        lblChange.Name = "lblChange"
        lblChange.Size = New Size(38, 21)
        lblChange.TabIndex = 11
        lblChange.Text = "N/A"
        ' 
        ' btnDone
        ' 
        btnDone.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnDone.Location = New Point(38, 441)
        btnDone.Name = "btnDone"
        btnDone.Size = New Size(123, 60)
        btnDone.TabIndex = 12
        btnDone.Text = "Done"
        btnDone.UseVisualStyleBackColor = True
        ' 
        ' txtPayment
        ' 
        txtPayment.Location = New Point(478, 451)
        txtPayment.Name = "txtPayment"
        txtPayment.Size = New Size(88, 23)
        txtPayment.TabIndex = 13
        ' 
        ' Order
        ' 
        Order.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Order.HeaderText = "Order"
        Order.Name = "Order"
        Order.ReadOnly = True
        ' 
        ' Quantity
        ' 
        Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Quantity.HeaderText = "Quantity"
        Quantity.Name = "Quantity"
        Quantity.ReadOnly = True
        ' 
        ' TotalPrice
        ' 
        TotalPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        TotalPrice.HeaderText = "Total Price"
        TotalPrice.Name = "TotalPrice"
        TotalPrice.ReadOnly = True
        ' 
        ' BillSummary
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.chalkboard
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(611, 551)
        Controls.Add(txtPayment)
        Controls.Add(btnDone)
        Controls.Add(lblChange)
        Controls.Add(lblTotalBill)
        Controls.Add(lblTax)
        Controls.Add(lblBill)
        Controls.Add(lblTotalItems)
        Controls.Add(dgOrderList)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "BillSummary"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Bill Summary"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(dgOrderList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents dgOrderList As DataGridView
    Friend WithEvents lblTotalItems As Label
    Friend WithEvents lblBill As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblTotalBill As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents btnDone As Button
    Friend WithEvents txtPayment As TextBox
    Friend WithEvents Order As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents TotalPrice As DataGridViewTextBoxColumn
End Class

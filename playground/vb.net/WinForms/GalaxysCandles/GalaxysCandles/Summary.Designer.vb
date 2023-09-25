<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Summary
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
        btnClose = New Button()
        GroupBox3 = New GroupBox()
        Label13 = New Label()
        txtSubtotal = New TextBox()
        Label12 = New Label()
        txtScentedPrice = New TextBox()
        Label11 = New Label()
        txtTotalDue = New TextBox()
        Label10 = New Label()
        txtTax = New TextBox()
        Label9 = New Label()
        txtShippingFee = New TextBox()
        GroupBox2 = New GroupBox()
        Label7 = New Label()
        txtScented = New TextBox()
        Label8 = New Label()
        txtQuantity = New TextBox()
        Label6 = New Label()
        txtCandleColor = New TextBox()
        Label5 = New Label()
        txtCandleStyle = New TextBox()
        GroupBox1 = New GroupBox()
        Label4 = New Label()
        txtContactNumber = New TextBox()
        Label3 = New Label()
        txtAddress = New TextBox()
        Label2 = New Label()
        txtCustomerName = New TextBox()
        Label1 = New Label()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(12, 418)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(290, 23)
        btnClose.TabIndex = 11
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Label13)
        GroupBox3.Controls.Add(txtSubtotal)
        GroupBox3.Controls.Add(Label12)
        GroupBox3.Controls.Add(txtScentedPrice)
        GroupBox3.Controls.Add(Label11)
        GroupBox3.Controls.Add(txtTotalDue)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Controls.Add(txtTax)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Controls.Add(txtShippingFee)
        GroupBox3.Location = New Point(12, 298)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(290, 114)
        GroupBox3.TabIndex = 10
        GroupBox3.TabStop = False
        GroupBox3.Text = "Total Cost"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point)
        Label13.Location = New Point(25, 81)
        Label13.Name = "Label13"
        Label13.Size = New Size(47, 13)
        Label13.TabIndex = 23
        Label13.Text = "Subtotal"
        ' 
        ' txtSubtotal
        ' 
        txtSubtotal.Location = New Point(78, 80)
        txtSubtotal.Name = "txtSubtotal"
        txtSubtotal.ReadOnly = True
        txtSubtotal.Size = New Size(63, 23)
        txtSubtotal.TabIndex = 24
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point)
        Label12.Location = New Point(6, 55)
        Label12.Name = "Label12"
        Label12.Size = New Size(69, 13)
        Label12.TabIndex = 21
        Label12.Text = "Scented Price"
        ' 
        ' txtScentedPrice
        ' 
        txtScentedPrice.Location = New Point(78, 51)
        txtScentedPrice.Name = "txtScentedPrice"
        txtScentedPrice.ReadOnly = True
        txtScentedPrice.Size = New Size(63, 23)
        txtScentedPrice.TabIndex = 22
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 8.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label11.Location = New Point(147, 73)
        Label11.Name = "Label11"
        Label11.Size = New Size(55, 13)
        Label11.TabIndex = 19
        Label11.Text = "Total Due"
        ' 
        ' txtTotalDue
        ' 
        txtTotalDue.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtTotalDue.Location = New Point(207, 61)
        txtTotalDue.Name = "txtTotalDue"
        txtTotalDue.ReadOnly = True
        txtTotalDue.Size = New Size(77, 33)
        txtTotalDue.TabIndex = 20
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point)
        Label10.Location = New Point(165, 26)
        Label10.Name = "Label10"
        Label10.Size = New Size(24, 13)
        Label10.TabIndex = 17
        Label10.Text = "Tax"
        ' 
        ' txtTax
        ' 
        txtTax.Location = New Point(195, 22)
        txtTax.Name = "txtTax"
        txtTax.ReadOnly = True
        txtTax.Size = New Size(89, 23)
        txtTax.TabIndex = 18
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point)
        Label9.Location = New Point(9, 26)
        Label9.Name = "Label9"
        Label9.Size = New Size(66, 13)
        Label9.TabIndex = 15
        Label9.Text = "Shipping Fee"
        ' 
        ' txtShippingFee
        ' 
        txtShippingFee.Location = New Point(78, 22)
        txtShippingFee.Name = "txtShippingFee"
        txtShippingFee.ReadOnly = True
        txtShippingFee.Size = New Size(77, 23)
        txtShippingFee.TabIndex = 16
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(txtScented)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(txtQuantity)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(txtCandleColor)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(txtCandleStyle)
        GroupBox2.Location = New Point(12, 189)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(290, 103)
        GroupBox2.TabIndex = 9
        GroupBox2.TabStop = False
        GroupBox2.Text = "Candle Information"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point)
        Label7.Location = New Point(156, 55)
        Label7.Name = "Label7"
        Label7.Size = New Size(48, 13)
        Label7.TabIndex = 13
        Label7.Text = "Scented?"
        ' 
        ' txtScented
        ' 
        txtScented.Location = New Point(210, 51)
        txtScented.Name = "txtScented"
        txtScented.ReadOnly = True
        txtScented.Size = New Size(74, 23)
        txtScented.TabIndex = 14
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point)
        Label8.Location = New Point(6, 55)
        Label8.Name = "Label8"
        Label8.Size = New Size(49, 13)
        Label8.TabIndex = 11
        Label8.Text = "Quantity"
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(61, 51)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.ReadOnly = True
        txtQuantity.Size = New Size(89, 23)
        txtQuantity.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point)
        Label6.Location = New Point(156, 26)
        Label6.Name = "Label6"
        Label6.Size = New Size(33, 13)
        Label6.TabIndex = 9
        Label6.Text = "Color"
        ' 
        ' txtCandleColor
        ' 
        txtCandleColor.Location = New Point(210, 22)
        txtCandleColor.Name = "txtCandleColor"
        txtCandleColor.ReadOnly = True
        txtCandleColor.Size = New Size(74, 23)
        txtCandleColor.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point)
        Label5.Location = New Point(6, 26)
        Label5.Name = "Label5"
        Label5.Size = New Size(29, 13)
        Label5.TabIndex = 7
        Label5.Text = "Style"
        ' 
        ' txtCandleStyle
        ' 
        txtCandleStyle.Location = New Point(61, 22)
        txtCandleStyle.Name = "txtCandleStyle"
        txtCandleStyle.ReadOnly = True
        txtCandleStyle.Size = New Size(89, 23)
        txtCandleStyle.TabIndex = 8
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(txtContactNumber)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txtAddress)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtCustomerName)
        GroupBox1.Location = New Point(12, 59)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(290, 124)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        GroupBox1.Text = "Customer Information"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point)
        Label4.Location = New Point(6, 88)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 13)
        Label4.TabIndex = 5
        Label4.Text = "Contact Number"
        ' 
        ' txtContactNumber
        ' 
        txtContactNumber.Location = New Point(98, 84)
        txtContactNumber.Name = "txtContactNumber"
        txtContactNumber.ReadOnly = True
        txtContactNumber.Size = New Size(186, 23)
        txtContactNumber.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point)
        Label3.Location = New Point(6, 59)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 13)
        Label3.TabIndex = 3
        Label3.Text = "Address"
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(98, 55)
        txtAddress.Name = "txtAddress"
        txtAddress.ReadOnly = True
        txtAddress.Size = New Size(186, 23)
        txtAddress.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(6, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 13)
        Label2.TabIndex = 1
        Label2.Text = "Full Name"
        ' 
        ' txtCustomerName
        ' 
        txtCustomerName.Location = New Point(98, 26)
        txtCustomerName.Name = "txtCustomerName"
        txtCustomerName.ReadOnly = True
        txtCustomerName.Size = New Size(186, 23)
        txtCustomerName.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(293, 47)
        Label1.TabIndex = 7
        Label1.Text = "Galaxy's Candles"
        ' 
        ' Summary
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(318, 451)
        Controls.Add(btnClose)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "Summary"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Summary"
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtScentedPrice As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtTotalDue As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTax As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtShippingFee As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtScented As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCandleColor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCandleStyle As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents Label1 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        txtUnitPrice = New TextBox()
        txtUnitQuantity = New TextBox()
        txtFullCost = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        txtTotalDiscount = New TextBox()
        Label5 = New Label()
        txtFinalPrice = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(169, 15)
        Label1.TabIndex = 0
        Label1.Text = "How many units were bought?"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(52, 33)
        Label2.Name = "Label2"
        Label2.Size = New Size(129, 15)
        Label2.TabIndex = 1
        Label2.Text = "How much is one unit?"
        ' 
        ' txtUnitPrice
        ' 
        txtUnitPrice.Location = New Point(194, 30)
        txtUnitPrice.Name = "txtUnitPrice"
        txtUnitPrice.PlaceholderText = "Unit Price"
        txtUnitPrice.Size = New Size(202, 23)
        txtUnitPrice.TabIndex = 0
        ' 
        ' txtUnitQuantity
        ' 
        txtUnitQuantity.Location = New Point(194, 61)
        txtUnitQuantity.Name = "txtUnitQuantity"
        txtUnitQuantity.PlaceholderText = "Unit Quantity"
        txtUnitQuantity.Size = New Size(202, 23)
        txtUnitQuantity.TabIndex = 1
        ' 
        ' txtFullCost
        ' 
        txtFullCost.Location = New Point(194, 129)
        txtFullCost.Name = "txtFullCost"
        txtFullCost.ReadOnly = True
        txtFullCost.Size = New Size(144, 23)
        txtFullCost.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(47, 132)
        Label3.Name = "Label3"
        Label3.Size = New Size(134, 15)
        Label3.TabIndex = 3
        Label3.Text = "Full Cost (w/o discount)"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(99, 161)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 15)
        Label4.TabIndex = 5
        Label4.Text = "Total Discount"
        ' 
        ' txtTotalDiscount
        ' 
        txtTotalDiscount.Location = New Point(194, 158)
        txtTotalDiscount.Name = "txtTotalDiscount"
        txtTotalDiscount.ReadOnly = True
        txtTotalDiscount.Size = New Size(144, 23)
        txtTotalDiscount.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(99, 190)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 15)
        Label5.TabIndex = 7
        Label5.Text = "Final Price"
        ' 
        ' txtFinalPrice
        ' 
        txtFinalPrice.Location = New Point(194, 187)
        txtFinalPrice.Name = "txtFinalPrice"
        txtFinalPrice.ReadOnly = True
        txtFinalPrice.Size = New Size(144, 23)
        txtFinalPrice.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(408, 224)
        Controls.Add(Label5)
        Controls.Add(txtFinalPrice)
        Controls.Add(Label4)
        Controls.Add(txtTotalDiscount)
        Controls.Add(Label3)
        Controls.Add(txtFullCost)
        Controls.Add(txtUnitQuantity)
        Controls.Add(txtUnitPrice)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Company Discount"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUnitPrice As TextBox
    Friend WithEvents txtUnitQuantity As TextBox
    Friend WithEvents txtFullCost As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotalDiscount As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFinalPrice As TextBox
End Class

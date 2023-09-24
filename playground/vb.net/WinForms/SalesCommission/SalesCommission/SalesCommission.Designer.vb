<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SalesCommission
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
        TableLayoutPanel1 = New TableLayoutPanel()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        txtInput = New TextBox()
        txtResult = New TextBox()
        btnCompute = New Button()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 64.6090546F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35.3909454F))
        TableLayoutPanel1.Controls.Add(Label15, 1, 6)
        TableLayoutPanel1.Controls.Add(Label14, 0, 6)
        TableLayoutPanel1.Controls.Add(Label13, 1, 5)
        TableLayoutPanel1.Controls.Add(Label12, 0, 5)
        TableLayoutPanel1.Controls.Add(Label11, 1, 4)
        TableLayoutPanel1.Controls.Add(Label10, 0, 4)
        TableLayoutPanel1.Controls.Add(Label9, 1, 3)
        TableLayoutPanel1.Controls.Add(Label8, 0, 3)
        TableLayoutPanel1.Controls.Add(Label7, 1, 2)
        TableLayoutPanel1.Controls.Add(Label6, 0, 2)
        TableLayoutPanel1.Controls.Add(Label5, 1, 1)
        TableLayoutPanel1.Controls.Add(Label2, 1, 0)
        TableLayoutPanel1.Controls.Add(Label4, 0, 1)
        TableLayoutPanel1.Controls.Add(Label3, 0, 0)
        TableLayoutPanel1.Location = New Point(12, 12)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 7
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 28F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12F))
        TableLayoutPanel1.Size = New Size(263, 162)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.None
        Label15.AutoSize = True
        Label15.Location = New Point(201, 143)
        Label15.Name = "Label15"
        Label15.Size = New Size(29, 15)
        Label15.TabIndex = 13
        Label15.Text = "10%"
        Label15.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.None
        Label14.AutoSize = True
        Label14.Location = New Point(32, 143)
        Label14.Name = "Label14"
        Label14.Size = New Size(105, 15)
        Label14.TabIndex = 12
        Label14.Text = "Above ₱150,000.00"
        Label14.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.None
        Label13.AutoSize = True
        Label13.Location = New Point(204, 123)
        Label13.Name = "Label13"
        Label13.Size = New Size(23, 15)
        Label13.TabIndex = 11
        Label13.Text = "8%"
        Label13.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.None
        Label12.AutoSize = True
        Label12.Location = New Point(14, 123)
        Label12.Name = "Label12"
        Label12.Size = New Size(140, 15)
        Label12.TabIndex = 10
        Label12.Text = "₱120,001.00 - ₱150,000.00"
        Label12.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.None
        Label11.AutoSize = True
        Label11.Location = New Point(204, 104)
        Label11.Name = "Label11"
        Label11.Size = New Size(23, 15)
        Label11.TabIndex = 9
        Label11.Text = "6%"
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.None
        Label10.AutoSize = True
        Label10.Location = New Point(17, 104)
        Label10.Name = "Label10"
        Label10.Size = New Size(134, 15)
        Label10.TabIndex = 8
        Label10.Text = "₱90,001.00 - ₱120,000.00"
        Label10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.None
        Label9.AutoSize = True
        Label9.Location = New Point(204, 85)
        Label9.Name = "Label9"
        Label9.Size = New Size(23, 15)
        Label9.TabIndex = 7
        Label9.Text = "4%"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.None
        Label8.AutoSize = True
        Label8.Location = New Point(20, 85)
        Label8.Name = "Label8"
        Label8.Size = New Size(128, 15)
        Label8.TabIndex = 6
        Label8.Text = "₱60,001.00 - ₱90,000.00"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.Location = New Point(204, 66)
        Label7.Name = "Label7"
        Label7.Size = New Size(23, 15)
        Label7.TabIndex = 5
        Label7.Text = "3%"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.Location = New Point(20, 66)
        Label6.Name = "Label6"
        Label6.Size = New Size(128, 15)
        Label6.TabIndex = 4
        Label6.Text = "₱30,001.00 - ₱60,000.00"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.Location = New Point(204, 47)
        Label5.Name = "Label5"
        Label5.Size = New Size(23, 15)
        Label5.TabIndex = 3
        Label5.Text = "2%"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(172, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 20)
        Label2.TabIndex = 0
        Label2.Text = "Percentage"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Location = New Point(41, 47)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 15)
        Label4.TabIndex = 2
        Label4.Text = "₱0 - ₱30,000.00"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(62, 12)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 20)
        Label3.TabIndex = 1
        Label3.Text = "Sales"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(316, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 21)
        Label1.TabIndex = 1
        Label1.Text = "Total Sales:"
        ' 
        ' txtInput
        ' 
        txtInput.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtInput.Location = New Point(281, 44)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(152, 29)
        txtInput.TabIndex = 2
        ' 
        ' txtResult
        ' 
        txtResult.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtResult.Location = New Point(281, 135)
        txtResult.Name = "txtResult"
        txtResult.PlaceholderText = "Total Commission"
        txtResult.ReadOnly = True
        txtResult.Size = New Size(152, 33)
        txtResult.TabIndex = 3
        txtResult.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnCompute
        ' 
        btnCompute.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnCompute.Location = New Point(293, 96)
        btnCompute.Name = "btnCompute"
        btnCompute.Size = New Size(124, 33)
        btnCompute.TabIndex = 4
        btnCompute.Text = "Compute"
        btnCompute.UseVisualStyleBackColor = True
        ' 
        ' SalesCommission
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(446, 184)
        Controls.Add(btnCompute)
        Controls.Add(txtResult)
        Controls.Add(txtInput)
        Controls.Add(Label1)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "SalesCommission"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sales Commission"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents btnCompute As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class

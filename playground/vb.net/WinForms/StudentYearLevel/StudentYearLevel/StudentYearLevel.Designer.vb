<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentYearLevel
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
        TableLayoutPanel1 = New TableLayoutPanel()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        lblResult = New Label()
        txtInput = New TextBox()
        btnTest = New Button()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(230, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 21)
        Label1.TabIndex = 0
        Label1.Text = "Year Level:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(230, 114)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 30)
        Label2.TabIndex = 1
        Label2.Text = "Category:"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Controls.Add(Label14, 1, 5)
        TableLayoutPanel1.Controls.Add(Label13, 0, 5)
        TableLayoutPanel1.Controls.Add(Label12, 1, 4)
        TableLayoutPanel1.Controls.Add(Label11, 0, 4)
        TableLayoutPanel1.Controls.Add(Label10, 1, 3)
        TableLayoutPanel1.Controls.Add(Label9, 0, 3)
        TableLayoutPanel1.Controls.Add(Label8, 1, 2)
        TableLayoutPanel1.Controls.Add(Label7, 0, 2)
        TableLayoutPanel1.Controls.Add(Label6, 1, 1)
        TableLayoutPanel1.Controls.Add(Label4, 1, 0)
        TableLayoutPanel1.Controls.Add(Label3, 0, 0)
        TableLayoutPanel1.Controls.Add(Label5, 0, 1)
        TableLayoutPanel1.Location = New Point(31, 23)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 6
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        TableLayoutPanel1.Size = New Size(171, 140)
        TableLayoutPanel1.TabIndex = 2
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.None
        Label14.AutoSize = True
        Label14.Location = New Point(92, 122)
        Label14.Name = "Label14"
        Label14.Size = New Size(72, 15)
        Label14.TabIndex = 11
        Label14.Text = "Invalid Entry"
        Label14.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.None
        Label13.AutoSize = True
        Label13.Location = New Point(9, 122)
        Label13.Name = "Label13"
        Label13.Size = New Size(67, 15)
        Label13.TabIndex = 10
        Label13.Text = "Other Entry"
        Label13.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.None
        Label12.AutoSize = True
        Label12.Location = New Point(108, 101)
        Label12.Name = "Label12"
        Label12.Size = New Size(40, 15)
        Label12.TabIndex = 9
        Label12.Text = "Senior"
        Label12.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.None
        Label11.AutoSize = True
        Label11.Location = New Point(36, 101)
        Label11.Name = "Label11"
        Label11.Size = New Size(13, 15)
        Label11.TabIndex = 8
        Label11.Text = "4"
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.None
        Label10.AutoSize = True
        Label10.Location = New Point(105, 80)
        Label10.Name = "Label10"
        Label10.Size = New Size(45, 15)
        Label10.TabIndex = 7
        Label10.Text = "Junior2"
        Label10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.None
        Label9.AutoSize = True
        Label9.Location = New Point(36, 80)
        Label9.Name = "Label9"
        Label9.Size = New Size(13, 15)
        Label9.TabIndex = 6
        Label9.Text = "3"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.None
        Label8.AutoSize = True
        Label8.Location = New Point(93, 59)
        Label8.Name = "Label8"
        Label8.Size = New Size(69, 15)
        Label8.TabIndex = 5
        Label8.Text = "Sophomore"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.Location = New Point(36, 59)
        Label7.Name = "Label7"
        Label7.Size = New Size(13, 15)
        Label7.TabIndex = 4
        Label7.Text = "2"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.Location = New Point(98, 38)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 15)
        Label6.TabIndex = 3
        Label6.Text = "Freshman"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(91, 7)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 20)
        Label4.TabIndex = 1
        Label4.Text = "Category"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(3, 7)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 20)
        Label3.TabIndex = 0
        Label3.Text = "Year Level"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.Location = New Point(36, 38)
        Label5.Name = "Label5"
        Label5.Size = New Size(13, 15)
        Label5.TabIndex = 2
        Label5.Text = "1"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        lblResult.Location = New Point(337, 118)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(0, 25)
        lblResult.TabIndex = 3
        ' 
        ' txtInput
        ' 
        txtInput.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtInput.Location = New Point(319, 52)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(100, 27)
        txtInput.TabIndex = 4
        ' 
        ' btnTest
        ' 
        btnTest.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnTest.Location = New Point(230, 163)
        btnTest.Name = "btnTest"
        btnTest.Size = New Size(189, 38)
        btnTest.TabIndex = 5
        btnTest.Text = "Test"
        btnTest.UseVisualStyleBackColor = True
        ' 
        ' StudentYearLevel
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(484, 222)
        Controls.Add(btnTest)
        Controls.Add(txtInput)
        Controls.Add(lblResult)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "StudentYearLevel"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Year Level"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
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
    Friend WithEvents lblResult As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnTest As Button
End Class

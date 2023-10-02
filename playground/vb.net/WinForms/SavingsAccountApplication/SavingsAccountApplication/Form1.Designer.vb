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
        numDeposit = New NumericUpDown()
        numInterest = New NumericUpDown()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtResultInterest = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        txtResultTotal = New TextBox()
        btnClear = New Button()
        btnCalculate = New Button()
        CType(numDeposit, ComponentModel.ISupportInitialize).BeginInit()
        CType(numInterest, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 15)
        Label1.TabIndex = 0
        Label1.Text = "Amount Deposited:"
        ' 
        ' numDeposit
        ' 
        numDeposit.DecimalPlaces = 2
        numDeposit.Location = New Point(164, 37)
        numDeposit.Name = "numDeposit"
        numDeposit.Size = New Size(113, 23)
        numDeposit.TabIndex = 1
        ' 
        ' numInterest
        ' 
        numInterest.DecimalPlaces = 2
        numInterest.Location = New Point(128, 66)
        numInterest.Name = "numInterest"
        numInterest.Size = New Size(120, 23)
        numInterest.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(47, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 15)
        Label2.TabIndex = 3
        Label2.Text = "Interest Rate:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(128, 39)
        Label3.Name = "Label3"
        Label3.Size = New Size(30, 15)
        Label3.TabIndex = 4
        Label3.Text = "PHP"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(254, 68)
        Label4.Name = "Label4"
        Label4.Size = New Size(17, 15)
        Label4.TabIndex = 5
        Label4.Text = "%"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point)
        Label5.Location = New Point(47, 181)
        Label5.Name = "Label5"
        Label5.Size = New Size(156, 13)
        Label5.TabIndex = 6
        Label5.Text = "(3 years; compounded annually)"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(25, 156)
        Label6.Name = "Label6"
        Label6.Size = New Size(223, 25)
        Label6.TabIndex = 7
        Label6.Text = "Future Account Balance"
        ' 
        ' txtResultInterest
        ' 
        txtResultInterest.Location = New Point(102, 210)
        txtResultInterest.Name = "txtResultInterest"
        txtResultInterest.ReadOnly = True
        txtResultInterest.Size = New Size(146, 23)
        txtResultInterest.TabIndex = 8
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(47, 213)
        Label7.Name = "Label7"
        Label7.Size = New Size(49, 15)
        Label7.TabIndex = 9
        Label7.Text = "Interest:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(61, 242)
        Label8.Name = "Label8"
        Label8.Size = New Size(35, 15)
        Label8.TabIndex = 11
        Label8.Text = "Total:"
        ' 
        ' txtResultTotal
        ' 
        txtResultTotal.Location = New Point(102, 239)
        txtResultTotal.Name = "txtResultTotal"
        txtResultTotal.ReadOnly = True
        txtResultTotal.Size = New Size(146, 23)
        txtResultTotal.TabIndex = 10
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(92, 284)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 12
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(173, 284)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(75, 23)
        btnCalculate.TabIndex = 13
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(289, 319)
        Controls.Add(btnCalculate)
        Controls.Add(btnClear)
        Controls.Add(Label8)
        Controls.Add(txtResultTotal)
        Controls.Add(Label7)
        Controls.Add(txtResultInterest)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(numInterest)
        Controls.Add(numDeposit)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Savings Account Application"
        CType(numDeposit, ComponentModel.ISupportInitialize).EndInit()
        CType(numInterest, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents numDeposit As NumericUpDown
    Friend WithEvents numInterest As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtResultInterest As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtResultTotal As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalculate As Button
End Class

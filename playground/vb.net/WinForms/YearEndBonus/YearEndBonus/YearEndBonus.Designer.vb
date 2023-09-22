<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class YearEndBonus
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
        lblSalary = New Label()
        txtTotalBonus = New TextBox()
        numSalary = New NumericUpDown()
        Label1 = New Label()
        Label2 = New Label()
        CType(numSalary, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblSalary
        ' 
        lblSalary.AutoSize = True
        lblSalary.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblSalary.Location = New Point(71, 34)
        lblSalary.Name = "lblSalary"
        lblSalary.Size = New Size(247, 17)
        lblSalary.TabIndex = 0
        lblSalary.Text = "How much is the salary of the employee?"
        ' 
        ' txtTotalBonus
        ' 
        txtTotalBonus.Location = New Point(155, 126)
        txtTotalBonus.Name = "txtTotalBonus"
        txtTotalBonus.PlaceholderText = "Total Bonus"
        txtTotalBonus.ReadOnly = True
        txtTotalBonus.Size = New Size(90, 23)
        txtTotalBonus.TabIndex = 1
        ' 
        ' numSalary
        ' 
        numSalary.DecimalPlaces = 2
        numSalary.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        numSalary.Location = New Point(155, 65)
        numSalary.Maximum = New Decimal(New Integer() {1569325055, 23283064, 0, 0})
        numSalary.Name = "numSalary"
        numSalary.Size = New Size(90, 25)
        numSalary.TabIndex = 2
        numSalary.ThousandsSeparator = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(118, 69)
        Label1.Name = "Label1"
        Label1.Size = New Size(31, 17)
        Label1.TabIndex = 3
        Label1.Text = "PHP"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(118, 127)
        Label2.Name = "Label2"
        Label2.Size = New Size(31, 17)
        Label2.TabIndex = 4
        Label2.Text = "PHP"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(374, 185)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(numSalary)
        Controls.Add(txtTotalBonus)
        Controls.Add(lblSalary)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = "Year-End Bonus Calculator"
        CType(numSalary, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblSalary As Label
    Friend WithEvents txtTotalBonus As TextBox
    Friend WithEvents numSalary As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class

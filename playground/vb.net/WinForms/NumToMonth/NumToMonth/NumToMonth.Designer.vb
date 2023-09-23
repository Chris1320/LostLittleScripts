<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NumToMonth
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
        lblTitle = New Label()
        numToCheck = New NumericUpDown()
        txtResult = New TextBox()
        btnCheck = New Button()
        CType(numToCheck, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitle.Location = New Point(111, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(137, 25)
        lblTitle.TabIndex = 0
        lblTitle.Text = "NumToMonth"
        lblTitle.TextAlign = ContentAlignment.TopCenter
        ' 
        ' numToCheck
        ' 
        numToCheck.Location = New Point(111, 79)
        numToCheck.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        numToCheck.Name = "numToCheck"
        numToCheck.Size = New Size(56, 23)
        numToCheck.TabIndex = 1
        ' 
        ' txtResult
        ' 
        txtResult.Location = New Point(111, 148)
        txtResult.Name = "txtResult"
        txtResult.PlaceholderText = "Result will be shown here"
        txtResult.ReadOnly = True
        txtResult.Size = New Size(137, 23)
        txtResult.TabIndex = 2
        txtResult.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnCheck
        ' 
        btnCheck.Location = New Point(173, 79)
        btnCheck.Name = "btnCheck"
        btnCheck.Size = New Size(75, 23)
        btnCheck.TabIndex = 3
        btnCheck.Text = "Check"
        btnCheck.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(368, 206)
        Controls.Add(btnCheck)
        Controls.Add(txtResult)
        Controls.Add(numToCheck)
        Controls.Add(lblTitle)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        ShowIcon = False
        Text = "NumToMonth"
        CType(numToCheck, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents numToCheck As NumericUpDown
    Friend WithEvents txtResult As TextBox
    Friend WithEvents btnCheck As Button
End Class

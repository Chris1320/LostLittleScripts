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
        lblTitle = New Label()
        Label1 = New Label()
        numDays = New NumericUpDown()
        lblTotal = New Label()
        lblDesc = New Label()
        CType(numDays, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        lblTitle.Location = New Point(99, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(402, 45)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Employee Salary Calculator"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(143, 112)
        Label1.Name = "Label1"
        Label1.Size = New Size(188, 15)
        Label1.TabIndex = 1
        Label1.Text = "Enter how many days you worked:"
        ' 
        ' numDays
        ' 
        numDays.Location = New Point(337, 110)
        numDays.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        numDays.Name = "numDays"
        numDays.Size = New Size(60, 23)
        numDays.TabIndex = 2
        ' 
        ' lblTotal
        ' 
        lblTotal.Anchor = AnchorStyles.None
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point)
        lblTotal.Location = New Point(99, 233)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(155, 65)
        lblTotal.TabIndex = 3
        lblTotal.Text = "PHP 0"
        lblTotal.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblDesc
        ' 
        lblDesc.AutoSize = True
        lblDesc.Location = New Point(158, 218)
        lblDesc.Name = "lblDesc"
        lblDesc.Size = New Size(275, 15)
        lblDesc.TabIndex = 4
        lblDesc.Text = "For the 0 days you've worked, you earned a total of"
        lblDesc.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(598, 337)
        Controls.Add(lblDesc)
        Controls.Add(lblTotal)
        Controls.Add(numDays)
        Controls.Add(Label1)
        Controls.Add(lblTitle)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = "Employee Salary Calculator"
        CType(numDays, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents numDays As NumericUpDown
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblDesc As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashForGold
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
        Label1 = New Label()
        Label2 = New Label()
        comboMode = New ComboBox()
        PictureBox1 = New PictureBox()
        lblInput = New Label()
        txtInput = New TextBox()
        btnProcess = New Button()
        btnClearForm = New Button()
        txtResult = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(43, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(229, 37)
        Label1.TabIndex = 0
        Label1.Text = "Cash for Gold"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(12, 258)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 15)
        Label2.TabIndex = 1
        Label2.Text = "Select Gold Option:"
        ' 
        ' comboMode
        ' 
        comboMode.FormattingEnabled = True
        comboMode.Items.AddRange(New Object() {"Select Option", "Calculate the Amount earned Based on Gold collected", "Calculate Amount of  Gold Needed to Make Target Goal"})
        comboMode.Location = New Point(43, 276)
        comboMode.Name = "comboMode"
        comboMode.Size = New Size(229, 23)
        comboMode.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.ingots
        PictureBox1.Location = New Point(77, 76)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(150, 150)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' lblInput
        ' 
        lblInput.AutoSize = True
        lblInput.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblInput.Location = New Point(12, 320)
        lblInput.Name = "lblInput"
        lblInput.Size = New Size(133, 21)
        lblInput.TabIndex = 4
        lblInput.Text = "Ounces Collected:"
        ' 
        ' txtInput
        ' 
        txtInput.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtInput.Location = New Point(178, 317)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(131, 29)
        txtInput.TabIndex = 5
        ' 
        ' btnProcess
        ' 
        btnProcess.Location = New Point(12, 363)
        btnProcess.Name = "btnProcess"
        btnProcess.Size = New Size(137, 44)
        btnProcess.TabIndex = 6
        btnProcess.Text = "Find Amount Earned"
        btnProcess.UseVisualStyleBackColor = True
        ' 
        ' btnClearForm
        ' 
        btnClearForm.Location = New Point(172, 363)
        btnClearForm.Name = "btnClearForm"
        btnClearForm.Size = New Size(137, 44)
        btnClearForm.TabIndex = 7
        btnClearForm.Text = "Clear Form"
        btnClearForm.UseVisualStyleBackColor = True
        ' 
        ' txtResult
        ' 
        txtResult.Location = New Point(12, 422)
        txtResult.Multiline = True
        txtResult.Name = "txtResult"
        txtResult.ReadOnly = True
        txtResult.Size = New Size(297, 56)
        txtResult.TabIndex = 8
        txtResult.TextAlign = HorizontalAlignment.Center
        ' 
        ' CashForGold
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PaleGreen
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(321, 490)
        Controls.Add(txtResult)
        Controls.Add(btnClearForm)
        Controls.Add(btnProcess)
        Controls.Add(txtInput)
        Controls.Add(lblInput)
        Controls.Add(PictureBox1)
        Controls.Add(comboMode)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "CashForGold"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cash For Gold"
        TopMost = True
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents comboMode As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblInput As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnProcess As Button
    Friend WithEvents btnClearForm As Button
    Friend WithEvents txtResult As TextBox
End Class

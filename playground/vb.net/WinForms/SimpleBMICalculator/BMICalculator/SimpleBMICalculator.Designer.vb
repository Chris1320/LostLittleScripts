<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BMICalculator
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(BMICalculator))
        Label1 = New Label()
        numHeightFeet = New NumericUpDown()
        numHeightInches = New NumericUpDown()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        numWeightKilograms = New NumericUpDown()
        Label5 = New Label()
        btnCalculate = New Button()
        barStatus = New ProgressBar()
        txtRemarks = New TextBox()
        txtBMI = New TextBox()
        lblBMI = New Label()
        Label6 = New Label()
        picWarning = New PictureBox()
        picGood = New PictureBox()
        CType(numHeightFeet, ComponentModel.ISupportInitialize).BeginInit()
        CType(numHeightInches, ComponentModel.ISupportInitialize).BeginInit()
        CType(numWeightKilograms, ComponentModel.ISupportInitialize).BeginInit()
        CType(picWarning, ComponentModel.ISupportInitialize).BeginInit()
        CType(picGood, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 30)
        Label1.TabIndex = 0
        Label1.Text = "Height"
        ' 
        ' numHeightFeet
        ' 
        numHeightFeet.DecimalPlaces = 2
        numHeightFeet.Location = New Point(81, 55)
        numHeightFeet.Name = "numHeightFeet"
        numHeightFeet.Size = New Size(73, 23)
        numHeightFeet.TabIndex = 1
        ' 
        ' numHeightInches
        ' 
        numHeightInches.DecimalPlaces = 2
        numHeightInches.Location = New Point(186, 55)
        numHeightInches.Name = "numHeightInches"
        numHeightInches.Size = New Size(73, 23)
        numHeightInches.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(160, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(20, 21)
        Label2.TabIndex = 3
        Label2.Text = "ft"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(265, 57)
        Label3.Name = "Label3"
        Label3.Size = New Size(23, 21)
        Label3.TabIndex = 4
        Label3.Text = "in"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(12, 95)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 30)
        Label4.TabIndex = 5
        Label4.Text = "Weight"
        ' 
        ' numWeightKilograms
        ' 
        numWeightKilograms.DecimalPlaces = 2
        numWeightKilograms.Location = New Point(81, 139)
        numWeightKilograms.Name = "numWeightKilograms"
        numWeightKilograms.Size = New Size(73, 23)
        numWeightKilograms.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(160, 139)
        Label5.Name = "Label5"
        Label5.Size = New Size(27, 21)
        Label5.TabIndex = 7
        Label5.Text = "kg"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnCalculate.ImageAlign = ContentAlignment.MiddleLeft
        btnCalculate.Location = New Point(12, 182)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(168, 53)
        btnCalculate.TabIndex = 8
        btnCalculate.Text = "Calculate BMI!"
        btnCalculate.TextImageRelation = TextImageRelation.ImageBeforeText
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' barStatus
        ' 
        barStatus.Location = New Point(200, 193)
        barStatus.Maximum = 30
        barStatus.Name = "barStatus"
        barStatus.Size = New Size(191, 23)
        barStatus.TabIndex = 9
        ' 
        ' txtRemarks
        ' 
        txtRemarks.Location = New Point(265, 153)
        txtRemarks.Name = "txtRemarks"
        txtRemarks.ReadOnly = True
        txtRemarks.Size = New Size(126, 23)
        txtRemarks.TabIndex = 10
        ' 
        ' txtBMI
        ' 
        txtBMI.Location = New Point(265, 124)
        txtBMI.Name = "txtBMI"
        txtBMI.ReadOnly = True
        txtBMI.Size = New Size(126, 23)
        txtBMI.TabIndex = 11
        ' 
        ' lblBMI
        ' 
        lblBMI.AutoSize = True
        lblBMI.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblBMI.Location = New Point(231, 127)
        lblBMI.Name = "lblBMI"
        lblBMI.Size = New Size(30, 15)
        lblBMI.TabIndex = 12
        lblBMI.Text = "BMI"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(205, 156)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 15)
        Label6.TabIndex = 13
        Label6.Text = "Remarks"
        ' 
        ' picWarning
        ' 
        picWarning.Image = My.Resources.Resources.warning
        picWarning.Location = New Point(291, 12)
        picWarning.Name = "picWarning"
        picWarning.Size = New Size(100, 100)
        picWarning.SizeMode = PictureBoxSizeMode.Zoom
        picWarning.TabIndex = 14
        picWarning.TabStop = False
        picWarning.Visible = False
        ' 
        ' picGood
        ' 
        picGood.Image = My.Resources.Resources.good
        picGood.Location = New Point(291, 12)
        picGood.Name = "picGood"
        picGood.Size = New Size(100, 100)
        picGood.SizeMode = PictureBoxSizeMode.Zoom
        picGood.TabIndex = 15
        picGood.TabStop = False
        picGood.Visible = False
        ' 
        ' BMICalculator
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(403, 256)
        Controls.Add(picGood)
        Controls.Add(picWarning)
        Controls.Add(Label6)
        Controls.Add(lblBMI)
        Controls.Add(txtBMI)
        Controls.Add(txtRemarks)
        Controls.Add(barStatus)
        Controls.Add(btnCalculate)
        Controls.Add(Label5)
        Controls.Add(numWeightKilograms)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(numHeightInches)
        Controls.Add(numHeightFeet)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "BMICalculator"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BMI Calculator"
        CType(numHeightFeet, ComponentModel.ISupportInitialize).EndInit()
        CType(numHeightInches, ComponentModel.ISupportInitialize).EndInit()
        CType(numWeightKilograms, ComponentModel.ISupportInitialize).EndInit()
        CType(picWarning, ComponentModel.ISupportInitialize).EndInit()
        CType(picGood, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents numHeightFeet As NumericUpDown
    Friend WithEvents numHeightInches As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents numWeightKilograms As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents barStatus As ProgressBar
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents txtBMI As TextBox
    Friend WithEvents lblBMI As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents picWarning As PictureBox
    Friend WithEvents picGood As PictureBox
End Class

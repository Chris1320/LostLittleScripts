<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TollCharge
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(TollCharge))
        lblTitle = New Label()
        picTitleIcon = New PictureBox()
        groupVehicleType = New GroupBox()
        rbtnHeavyTruck = New RadioButton()
        rbtnLightTruck = New RadioButton()
        rbtnCar = New RadioButton()
        groupTicketType = New GroupBox()
        rbtnRed = New RadioButton()
        rbtnBlue = New RadioButton()
        rbtnYellow = New RadioButton()
        txtResult = New TextBox()
        lblResult = New Label()
        btnCalculate = New Button()
        CType(picTitleIcon, ComponentModel.ISupportInitialize).BeginInit()
        groupVehicleType.SuspendLayout()
        groupTicketType.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Alfa Slab One", 21.7499981F, FontStyle.Regular, GraphicsUnit.Point)
        lblTitle.Location = New Point(77, 12)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(366, 45)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Toll Charge Calculator"
        ' 
        ' picTitleIcon
        ' 
        picTitleIcon.Image = My.Resources.Resources.toll
        picTitleIcon.Location = New Point(12, 12)
        picTitleIcon.Name = "picTitleIcon"
        picTitleIcon.Size = New Size(59, 50)
        picTitleIcon.SizeMode = PictureBoxSizeMode.Zoom
        picTitleIcon.TabIndex = 1
        picTitleIcon.TabStop = False
        ' 
        ' groupVehicleType
        ' 
        groupVehicleType.Controls.Add(rbtnHeavyTruck)
        groupVehicleType.Controls.Add(rbtnLightTruck)
        groupVehicleType.Controls.Add(rbtnCar)
        groupVehicleType.Location = New Point(12, 104)
        groupVehicleType.Name = "groupVehicleType"
        groupVehicleType.Size = New Size(186, 97)
        groupVehicleType.TabIndex = 2
        groupVehicleType.TabStop = False
        groupVehicleType.Text = "Vehicle Type"
        ' 
        ' rbtnHeavyTruck
        ' 
        rbtnHeavyTruck.AutoSize = True
        rbtnHeavyTruck.Location = New Point(6, 72)
        rbtnHeavyTruck.Name = "rbtnHeavyTruck"
        rbtnHeavyTruck.Size = New Size(180, 19)
        rbtnHeavyTruck.TabIndex = 2
        rbtnHeavyTruck.TabStop = True
        rbtnHeavyTruck.Text = "Bus/Heavy Truck [₱25.00/km]"
        rbtnHeavyTruck.UseVisualStyleBackColor = True
        ' 
        ' rbtnLightTruck
        ' 
        rbtnLightTruck.AutoSize = True
        rbtnLightTruck.Location = New Point(6, 47)
        rbtnLightTruck.Name = "rbtnLightTruck"
        rbtnLightTruck.Size = New Size(150, 19)
        rbtnLightTruck.TabIndex = 1
        rbtnLightTruck.TabStop = True
        rbtnLightTruck.Text = "Light Truck [₱15.00/km]"
        rbtnLightTruck.UseVisualStyleBackColor = True
        ' 
        ' rbtnCar
        ' 
        rbtnCar.AutoSize = True
        rbtnCar.Location = New Point(6, 22)
        rbtnCar.Name = "rbtnCar"
        rbtnCar.Size = New Size(110, 19)
        rbtnCar.TabIndex = 0
        rbtnCar.TabStop = True
        rbtnCar.Text = "Car [₱10.00/km]"
        rbtnCar.UseVisualStyleBackColor = True
        ' 
        ' groupTicketType
        ' 
        groupTicketType.Controls.Add(rbtnRed)
        groupTicketType.Controls.Add(rbtnBlue)
        groupTicketType.Controls.Add(rbtnYellow)
        groupTicketType.Location = New Point(204, 104)
        groupTicketType.Name = "groupTicketType"
        groupTicketType.Size = New Size(143, 97)
        groupTicketType.TabIndex = 3
        groupTicketType.TabStop = False
        groupTicketType.Text = "Ticket Type"
        ' 
        ' rbtnRed
        ' 
        rbtnRed.AutoSize = True
        rbtnRed.Location = New Point(6, 72)
        rbtnRed.Name = "rbtnRed"
        rbtnRed.Size = New Size(88, 19)
        rbtnRed.TabIndex = 2
        rbtnRed.TabStop = True
        rbtnRed.Text = "Red [30 km]"
        rbtnRed.UseVisualStyleBackColor = True
        ' 
        ' rbtnBlue
        ' 
        rbtnBlue.AutoSize = True
        rbtnBlue.Location = New Point(6, 47)
        rbtnBlue.Name = "rbtnBlue"
        rbtnBlue.Size = New Size(91, 19)
        rbtnBlue.TabIndex = 1
        rbtnBlue.TabStop = True
        rbtnBlue.Text = "Blue [25 km]"
        rbtnBlue.UseVisualStyleBackColor = True
        ' 
        ' rbtnYellow
        ' 
        rbtnYellow.AutoSize = True
        rbtnYellow.Location = New Point(6, 22)
        rbtnYellow.Name = "rbtnYellow"
        rbtnYellow.Size = New Size(102, 19)
        rbtnYellow.TabIndex = 0
        rbtnYellow.TabStop = True
        rbtnYellow.Text = "Yellow [20 km]"
        rbtnYellow.UseVisualStyleBackColor = True
        ' 
        ' txtResult
        ' 
        txtResult.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtResult.Location = New Point(353, 172)
        txtResult.Name = "txtResult"
        txtResult.PlaceholderText = "PHP ---.--"
        txtResult.ReadOnly = True
        txtResult.Size = New Size(90, 29)
        txtResult.TabIndex = 4
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point)
        lblResult.Location = New Point(353, 151)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(90, 21)
        lblResult.TabIndex = 5
        lblResult.Text = "Toll Charge"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnCalculate.Location = New Point(353, 104)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(90, 41)
        btnCalculate.TabIndex = 6
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' TollCharge
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(466, 260)
        Controls.Add(btnCalculate)
        Controls.Add(lblResult)
        Controls.Add(txtResult)
        Controls.Add(groupTicketType)
        Controls.Add(groupVehicleType)
        Controls.Add(picTitleIcon)
        Controls.Add(lblTitle)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "TollCharge"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Toll Charge Calculator"
        CType(picTitleIcon, ComponentModel.ISupportInitialize).EndInit()
        groupVehicleType.ResumeLayout(False)
        groupVehicleType.PerformLayout()
        groupTicketType.ResumeLayout(False)
        groupTicketType.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents picTitleIcon As PictureBox
    Friend WithEvents groupVehicleType As GroupBox
    Friend WithEvents rbtnHeavyTruck As RadioButton
    Friend WithEvents rbtnLightTruck As RadioButton
    Friend WithEvents rbtnCar As RadioButton
    Friend WithEvents groupTicketType As GroupBox
    Friend WithEvents rbtnRed As RadioButton
    Friend WithEvents rbtnBlue As RadioButton
    Friend WithEvents rbtnYellow As RadioButton
    Friend WithEvents txtResult As TextBox
    Friend WithEvents lblResult As Label
    Friend WithEvents btnCalculate As Button
End Class

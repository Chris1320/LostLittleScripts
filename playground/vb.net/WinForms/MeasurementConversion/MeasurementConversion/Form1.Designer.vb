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
        txtFeet = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtYards = New TextBox()
        txtInches = New TextBox()
        txtCentimeters = New TextBox()
        txtMeters = New TextBox()
        btnConvert = New Button()
        btnClear = New Button()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(57, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(35, 15)
        Label1.TabIndex = 0
        Label1.Text = "Input"
        ' 
        ' txtFeet
        ' 
        txtFeet.Location = New Point(98, 36)
        txtFeet.Name = "txtFeet"
        txtFeet.PlaceholderText = "Distance in feet"
        txtFeet.Size = New Size(100, 23)
        txtFeet.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(66, 158)
        Label2.Name = "Label2"
        Label2.Size = New Size(35, 15)
        Label2.TabIndex = 2
        Label2.Text = "Yards"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(60, 187)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 3
        Label3.Text = "Inches"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(30, 216)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 15)
        Label4.TabIndex = 4
        Label4.Text = "Centimeters"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(58, 245)
        Label5.Name = "Label5"
        Label5.Size = New Size(43, 15)
        Label5.TabIndex = 5
        Label5.Text = "Meters"
        ' 
        ' txtYards
        ' 
        txtYards.Location = New Point(107, 155)
        txtYards.Name = "txtYards"
        txtYards.ReadOnly = True
        txtYards.Size = New Size(119, 23)
        txtYards.TabIndex = 6
        ' 
        ' txtInches
        ' 
        txtInches.Location = New Point(107, 184)
        txtInches.Name = "txtInches"
        txtInches.ReadOnly = True
        txtInches.Size = New Size(119, 23)
        txtInches.TabIndex = 7
        ' 
        ' txtCentimeters
        ' 
        txtCentimeters.Location = New Point(107, 213)
        txtCentimeters.Name = "txtCentimeters"
        txtCentimeters.ReadOnly = True
        txtCentimeters.Size = New Size(119, 23)
        txtCentimeters.TabIndex = 8
        ' 
        ' txtMeters
        ' 
        txtMeters.Location = New Point(107, 242)
        txtMeters.Name = "txtMeters"
        txtMeters.ReadOnly = True
        txtMeters.Size = New Size(119, 23)
        txtMeters.TabIndex = 9
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(26, 79)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(75, 23)
        btnConvert.TabIndex = 10
        btnConvert.Text = "Convert"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(107, 79)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 11
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(188, 78)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 23)
        btnExit.TabIndex = 12
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(294, 307)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnConvert)
        Controls.Add(txtMeters)
        Controls.Add(txtCentimeters)
        Controls.Add(txtInches)
        Controls.Add(txtYards)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtFeet)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Measurement Conversion"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFeet As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtYards As TextBox
    Friend WithEvents txtInches As TextBox
    Friend WithEvents txtCentimeters As TextBox
    Friend WithEvents txtMeters As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class

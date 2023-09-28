<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TourForm
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
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        comboTourType = New ComboBox()
        Label3 = New Label()
        txtNumberOfTickets = New TextBox()
        Label4 = New Label()
        lstDiscountType = New ListBox()
        Label5 = New Label()
        btnCompute = New Button()
        btnClear = New Button()
        txtResult = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.image
        PictureBox1.Location = New Point(39, 29)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(261, 190)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(306, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(294, 29)
        Label1.TabIndex = 1
        Label1.Text = "Segway Tour Tickets"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(312, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 15)
        Label2.TabIndex = 2
        Label2.Text = "Select Type of Tour:"
        ' 
        ' comboTourType
        ' 
        comboTourType.BackColor = Color.Aquamarine
        comboTourType.FormattingEnabled = True
        comboTourType.Items.AddRange(New Object() {"Golden Gate Tour ($79.99)", "Waterfront Tour ($69.99)"})
        comboTourType.Location = New Point(361, 139)
        comboTourType.Name = "comboTourType"
        comboTourType.Size = New Size(203, 23)
        comboTourType.TabIndex = 3
        comboTourType.Text = "Select Tour"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(110, 246)
        Label3.Name = "Label3"
        Label3.Size = New Size(107, 15)
        Label3.TabIndex = 4
        Label3.Text = "Number of Tickets:"
        ' 
        ' txtNumberOfTickets
        ' 
        txtNumberOfTickets.BackColor = Color.Aquamarine
        txtNumberOfTickets.Location = New Point(223, 243)
        txtNumberOfTickets.Name = "txtNumberOfTickets"
        txtNumberOfTickets.Size = New Size(100, 23)
        txtNumberOfTickets.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(133, 297)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 15)
        Label4.TabIndex = 6
        Label4.Text = "Discount Type:"
        ' 
        ' lstDiscountType
        ' 
        lstDiscountType.BackColor = Color.Aquamarine
        lstDiscountType.FormattingEnabled = True
        lstDiscountType.ItemHeight = 15
        lstDiscountType.Items.AddRange(New Object() {"None", "Military Discount (10%)", "Student Discount (20%)", "Senior Citizen Discount (25%)"})
        lstDiscountType.Location = New Point(223, 297)
        lstDiscountType.Name = "lstDiscountType"
        lstDiscountType.Size = New Size(228, 64)
        lstDiscountType.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(235, 383)
        Label5.Name = "Label5"
        Label5.Size = New Size(123, 15)
        Label5.TabIndex = 8
        Label5.Text = "Your final tour cost is"
        ' 
        ' btnCompute
        ' 
        btnCompute.Location = New Point(110, 430)
        btnCompute.Name = "btnCompute"
        btnCompute.Size = New Size(121, 32)
        btnCompute.TabIndex = 9
        btnCompute.Text = "Compute Cost"
        btnCompute.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(361, 430)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(121, 32)
        btnClear.TabIndex = 10
        btnClear.Text = "Clear Form"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' txtResult
        ' 
        txtResult.BackColor = Color.Aquamarine
        txtResult.Location = New Point(223, 401)
        txtResult.Name = "txtResult"
        txtResult.ReadOnly = True
        txtResult.Size = New Size(145, 23)
        txtResult.TabIndex = 11
        txtResult.TextAlign = HorizontalAlignment.Center
        ' 
        ' TourForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumAquamarine
        ClientSize = New Size(612, 474)
        Controls.Add(txtResult)
        Controls.Add(btnClear)
        Controls.Add(btnCompute)
        Controls.Add(Label5)
        Controls.Add(lstDiscountType)
        Controls.Add(Label4)
        Controls.Add(txtNumberOfTickets)
        Controls.Add(Label3)
        Controls.Add(comboTourType)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "TourForm"
        Text = "Segway Tours"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents comboTourType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNumberOfTickets As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lstDiscountType As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCompute As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtResult As TextBox
End Class

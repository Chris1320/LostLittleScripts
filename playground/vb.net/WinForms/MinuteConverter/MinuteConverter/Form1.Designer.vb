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
        lblHours = New Label()
        lblMinutes = New Label()
        txtHours = New TextBox()
        txtMinutes = New TextBox()
        txtTotalMinutes = New TextBox()
        lblTotalMinutes = New Label()
        SuspendLayout()
        ' 
        ' lblHours
        ' 
        lblHours.AutoSize = True
        lblHours.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblHours.Location = New Point(86, 52)
        lblHours.Name = "lblHours"
        lblHours.Size = New Size(68, 30)
        lblHours.TabIndex = 0
        lblHours.Text = "Hours"
        ' 
        ' lblMinutes
        ' 
        lblMinutes.AutoSize = True
        lblMinutes.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblMinutes.Location = New Point(66, 94)
        lblMinutes.Name = "lblMinutes"
        lblMinutes.Size = New Size(88, 30)
        lblMinutes.TabIndex = 1
        lblMinutes.Text = "Minutes"
        ' 
        ' txtHours
        ' 
        txtHours.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtHours.Location = New Point(160, 49)
        txtHours.Name = "txtHours"
        txtHours.Size = New Size(100, 35)
        txtHours.TabIndex = 2
        ' 
        ' txtMinutes
        ' 
        txtMinutes.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtMinutes.Location = New Point(160, 91)
        txtMinutes.Name = "txtMinutes"
        txtMinutes.Size = New Size(100, 35)
        txtMinutes.TabIndex = 3
        ' 
        ' txtTotalMinutes
        ' 
        txtTotalMinutes.Location = New Point(334, 91)
        txtTotalMinutes.Name = "txtTotalMinutes"
        txtTotalMinutes.ReadOnly = True
        txtTotalMinutes.Size = New Size(100, 23)
        txtTotalMinutes.TabIndex = 4
        txtTotalMinutes.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblTotalMinutes
        ' 
        lblTotalMinutes.AutoSize = True
        lblTotalMinutes.Location = New Point(346, 73)
        lblTotalMinutes.Name = "lblTotalMinutes"
        lblTotalMinutes.Size = New Size(78, 15)
        lblTotalMinutes.TabIndex = 5
        lblTotalMinutes.Text = "Total Minutes"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(478, 209)
        Controls.Add(lblTotalMinutes)
        Controls.Add(txtTotalMinutes)
        Controls.Add(txtMinutes)
        Controls.Add(txtHours)
        Controls.Add(lblMinutes)
        Controls.Add(lblHours)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = "Minute Converter"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHours As Label
    Friend WithEvents lblMinutes As Label
    Friend WithEvents txtHours As TextBox
    Friend WithEvents txtMinutes As TextBox
    Friend WithEvents txtTotalMinutes As TextBox
    Friend WithEvents lblTotalMinutes As Label
End Class

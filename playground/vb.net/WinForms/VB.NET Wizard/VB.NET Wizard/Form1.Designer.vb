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
        btnShow = New Button()
        btnHide = New Button()
        btnExit = New Button()
        pboxWizard = New PictureBox()
        lblMissingWizard = New Label()
        CType(pboxWizard, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitle.Location = New Point(141, 29)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(122, 45)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Wizard"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnShow
        ' 
        btnShow.Location = New Point(71, 282)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(75, 23)
        btnShow.TabIndex = 1
        btnShow.Text = "Show"
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' btnHide
        ' 
        btnHide.Location = New Point(164, 282)
        btnHide.Name = "btnHide"
        btnHide.Size = New Size(75, 23)
        btnHide.TabIndex = 2
        btnHide.Text = "Hide"
        btnHide.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(254, 282)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 23)
        btnExit.TabIndex = 3
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' pboxWizard
        ' 
        pboxWizard.Image = My.Resources.Resources.wizard
        pboxWizard.Location = New Point(126, 95)
        pboxWizard.Name = "pboxWizard"
        pboxWizard.Size = New Size(150, 150)
        pboxWizard.SizeMode = PictureBoxSizeMode.StretchImage
        pboxWizard.TabIndex = 4
        pboxWizard.TabStop = False
        pboxWizard.Visible = False
        ' 
        ' lblMissingWizard
        ' 
        lblMissingWizard.AutoSize = True
        lblMissingWizard.Font = New Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point)
        lblMissingWizard.Location = New Point(153, 106)
        lblMissingWizard.Name = "lblMissingWizard"
        lblMissingWizard.Size = New Size(96, 128)
        lblMissingWizard.TabIndex = 5
        lblMissingWizard.Text = "?"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(404, 350)
        Controls.Add(lblMissingWizard)
        Controls.Add(pboxWizard)
        Controls.Add(btnExit)
        Controls.Add(btnHide)
        Controls.Add(btnShow)
        Controls.Add(lblTitle)
        Name = "Form1"
        Text = "VB.NET Wizard"
        CType(pboxWizard, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnShow As Button
    Friend WithEvents btnHide As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents pboxWizard As PictureBox
    Friend WithEvents lblMissingWizard As Label
End Class

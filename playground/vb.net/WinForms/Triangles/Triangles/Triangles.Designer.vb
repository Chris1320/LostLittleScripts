<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Triangles
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
        txtResult = New TextBox()
        Label1 = New Label()
        txtLayers = New TextBox()
        btnPrint = New Button()
        SuspendLayout()
        ' 
        ' txtResult
        ' 
        txtResult.Location = New Point(12, 54)
        txtResult.Multiline = True
        txtResult.Name = "txtResult"
        txtResult.ReadOnly = True
        txtResult.Size = New Size(776, 384)
        txtResult.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(155, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 15)
        Label1.TabIndex = 1
        Label1.Text = "Enter number of layers:"
        ' 
        ' txtLayers
        ' 
        txtLayers.Location = New Point(290, 21)
        txtLayers.Name = "txtLayers"
        txtLayers.Size = New Size(100, 23)
        txtLayers.TabIndex = 2
        ' 
        ' btnPrint
        ' 
        btnPrint.Location = New Point(432, 21)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(75, 23)
        btnPrint.TabIndex = 3
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' Triangles
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnPrint)
        Controls.Add(txtLayers)
        Controls.Add(Label1)
        Controls.Add(txtResult)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Triangles"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Triangles"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtResult As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLayers As TextBox
    Friend WithEvents btnPrint As Button
End Class

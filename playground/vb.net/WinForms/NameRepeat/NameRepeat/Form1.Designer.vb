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
        txtName = New TextBox()
        numRepeat = New NumericUpDown()
        Label2 = New Label()
        listResult = New ListBox()
        progress = New ProgressBar()
        CType(numRepeat, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(104, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 15)
        Label1.TabIndex = 0
        Label1.Text = "Enter name"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(177, 30)
        txtName.Name = "txtName"
        txtName.Size = New Size(120, 23)
        txtName.TabIndex = 1
        ' 
        ' numRepeat
        ' 
        numRepeat.Location = New Point(177, 58)
        numRepeat.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        numRepeat.Name = "numRepeat"
        numRepeat.Size = New Size(120, 23)
        numRepeat.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(46, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(125, 15)
        Label2.TabIndex = 3
        Label2.Text = "Enter how many times"
        ' 
        ' listResult
        ' 
        listResult.FormattingEnabled = True
        listResult.ItemHeight = 15
        listResult.Location = New Point(12, 98)
        listResult.Name = "listResult"
        listResult.Size = New Size(376, 124)
        listResult.TabIndex = 4
        ' 
        ' progress
        ' 
        progress.Location = New Point(12, 229)
        progress.Name = "progress"
        progress.Size = New Size(376, 23)
        progress.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(400, 264)
        Controls.Add(progress)
        Controls.Add(listResult)
        Controls.Add(Label2)
        Controls.Add(numRepeat)
        Controls.Add(txtName)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(numRepeat, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents numRepeat As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents listResult As ListBox
    Friend WithEvents progress As ProgressBar
End Class

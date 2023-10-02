<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MultiplicationTables
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
        listResult = New ListBox()
        txtInput = New TextBox()
        btnCompute = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(244, 15)
        Label1.TabIndex = 0
        Label1.Text = "Enter the times table you want to learn (1-12)"
        ' 
        ' listResult
        ' 
        listResult.FormattingEnabled = True
        listResult.ItemHeight = 15
        listResult.Location = New Point(12, 56)
        listResult.Name = "listResult"
        listResult.Size = New Size(243, 184)
        listResult.TabIndex = 1
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(12, 27)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(244, 23)
        txtInput.TabIndex = 2
        ' 
        ' btnCompute
        ' 
        btnCompute.Location = New Point(30, 246)
        btnCompute.Name = "btnCompute"
        btnCompute.Size = New Size(203, 23)
        btnCompute.TabIndex = 3
        btnCompute.Text = "Tell me my times table"
        btnCompute.UseVisualStyleBackColor = True
        ' 
        ' MultiplicationTables
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(267, 280)
        Controls.Add(btnCompute)
        Controls.Add(txtInput)
        Controls.Add(listResult)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "MultiplicationTables"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Multiplication Tables"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents listResult As ListBox
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnCompute As Button
End Class

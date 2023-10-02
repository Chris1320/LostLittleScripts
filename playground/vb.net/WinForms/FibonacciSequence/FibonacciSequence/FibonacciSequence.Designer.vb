<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FibonacciSequence
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
        txtLimit = New TextBox()
        btnPrint = New Button()
        listResult = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(25, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 15)
        Label1.TabIndex = 0
        Label1.Text = "Enter Limit:"
        ' 
        ' txtLimit
        ' 
        txtLimit.Location = New Point(98, 27)
        txtLimit.Name = "txtLimit"
        txtLimit.Size = New Size(100, 23)
        txtLimit.TabIndex = 1
        ' 
        ' btnPrint
        ' 
        btnPrint.Location = New Point(204, 27)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(75, 23)
        btnPrint.TabIndex = 2
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' listResult
        ' 
        listResult.FormattingEnabled = True
        listResult.ItemHeight = 15
        listResult.Location = New Point(25, 66)
        listResult.Name = "listResult"
        listResult.Size = New Size(254, 274)
        listResult.TabIndex = 3
        ' 
        ' FibonacciSequence
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(305, 356)
        Controls.Add(listResult)
        Controls.Add(btnPrint)
        Controls.Add(txtLimit)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FibonacciSequence"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Fibonacci Sequence"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtLimit As TextBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents listResult As ListBox
End Class

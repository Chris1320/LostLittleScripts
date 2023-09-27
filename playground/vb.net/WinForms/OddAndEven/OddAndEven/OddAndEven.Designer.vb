<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OddAndEven
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
        numFirstNumber = New NumericUpDown()
        numSecondNumber = New NumericUpDown()
        Label1 = New Label()
        Label2 = New Label()
        btnFind = New Button()
        btnClear = New Button()
        listOddNumbers = New ListBox()
        listEvenNumbers = New ListBox()
        Label3 = New Label()
        Label4 = New Label()
        barComputationProgress = New ProgressBar()
        CType(numFirstNumber, ComponentModel.ISupportInitialize).BeginInit()
        CType(numSecondNumber, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' numFirstNumber
        ' 
        numFirstNumber.Location = New Point(111, 31)
        numFirstNumber.Maximum = New Decimal(New Integer() {Integer.MaxValue, 0, 0, 0})
        numFirstNumber.Name = "numFirstNumber"
        numFirstNumber.Size = New Size(120, 23)
        numFirstNumber.TabIndex = 0
        ' 
        ' numSecondNumber
        ' 
        numSecondNumber.Location = New Point(111, 60)
        numSecondNumber.Maximum = New Decimal(New Integer() {Integer.MaxValue, 0, 0, 0})
        numSecondNumber.Name = "numSecondNumber"
        numSecondNumber.Size = New Size(120, 23)
        numSecondNumber.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 15)
        Label1.TabIndex = 2
        Label1.Text = "First Number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 62)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 15)
        Label2.TabIndex = 3
        Label2.Text = "Second Number"
        ' 
        ' btnFind
        ' 
        btnFind.Location = New Point(312, 31)
        btnFind.Name = "btnFind"
        btnFind.Size = New Size(97, 52)
        btnFind.TabIndex = 4
        btnFind.Text = "Find"
        btnFind.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(415, 31)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(97, 52)
        btnClear.TabIndex = 5
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' listOddNumbers
        ' 
        listOddNumbers.FormattingEnabled = True
        listOddNumbers.ItemHeight = 15
        listOddNumbers.Location = New Point(12, 119)
        listOddNumbers.Name = "listOddNumbers"
        listOddNumbers.SelectionMode = SelectionMode.None
        listOddNumbers.Size = New Size(219, 94)
        listOddNumbers.TabIndex = 8
        ' 
        ' listEvenNumbers
        ' 
        listEvenNumbers.FormattingEnabled = True
        listEvenNumbers.ItemHeight = 15
        listEvenNumbers.Location = New Point(293, 119)
        listEvenNumbers.Name = "listEvenNumbers"
        listEvenNumbers.SelectionMode = SelectionMode.None
        listEvenNumbers.Size = New Size(219, 94)
        listEvenNumbers.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(75, 101)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 15)
        Label3.TabIndex = 10
        Label3.Text = "Odd Numbers"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(359, 101)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 15)
        Label4.TabIndex = 11
        Label4.Text = "Even Numbers"
        ' 
        ' barComputationProgress
        ' 
        barComputationProgress.Location = New Point(12, 219)
        barComputationProgress.Maximum = Integer.MaxValue
        barComputationProgress.Name = "barComputationProgress"
        barComputationProgress.Size = New Size(500, 21)
        barComputationProgress.TabIndex = 12
        ' 
        ' OddAndEven
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(524, 252)
        Controls.Add(barComputationProgress)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(listEvenNumbers)
        Controls.Add(listOddNumbers)
        Controls.Add(btnClear)
        Controls.Add(btnFind)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(numSecondNumber)
        Controls.Add(numFirstNumber)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "OddAndEven"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Odd and Even"
        CType(numFirstNumber, ComponentModel.ISupportInitialize).EndInit()
        CType(numSecondNumber, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents numFirstNumber As NumericUpDown
    Friend WithEvents numSecondNumber As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnFind As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents listOddNumbers As ListBox
    Friend WithEvents listEvenNumbers As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents barComputationProgress As ProgressBar
End Class

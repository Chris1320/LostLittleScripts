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
        listNums = New ListBox()
        txtNum = New TextBox()
        btnAdd = New Button()
        lblHighest = New Label()
        btnClear = New Button()
        SuspendLayout()
        ' 
        ' listNums
        ' 
        listNums.FormattingEnabled = True
        listNums.ItemHeight = 15
        listNums.Location = New Point(12, 75)
        listNums.Name = "listNums"
        listNums.Size = New Size(270, 154)
        listNums.TabIndex = 3
        ' 
        ' txtNum
        ' 
        txtNum.Location = New Point(12, 12)
        txtNum.Name = "txtNum"
        txtNum.Size = New Size(189, 23)
        txtNum.TabIndex = 0
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(207, 12)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(24, 23)
        btnAdd.TabIndex = 1
        btnAdd.Text = "+"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' lblHighest
        ' 
        lblHighest.Anchor = AnchorStyles.None
        lblHighest.AutoSize = True
        lblHighest.Location = New Point(55, 48)
        lblHighest.Name = "lblHighest"
        lblHighest.Size = New Size(176, 15)
        lblHighest.TabIndex = 3
        lblHighest.Text = "There are no numbers in the list."
        lblHighest.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(237, 12)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(45, 23)
        btnClear.TabIndex = 2
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(294, 236)
        Controls.Add(btnClear)
        Controls.Add(lblHighest)
        Controls.Add(btnAdd)
        Controls.Add(txtNum)
        Controls.Add(listNums)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Highest Number"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents listNums As ListBox
    Friend WithEvents txtNum As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblHighest As Label
    Friend WithEvents btnClear As Button
End Class

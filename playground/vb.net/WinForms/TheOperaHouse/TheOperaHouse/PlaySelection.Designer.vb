<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PlaySelection
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
        comboSelectPlay = New ComboBox()
        MenuStrip1 = New MenuStrip()
        FeaturedPlaysToolStripMenuItem = New ToolStripMenuItem()
        LionKingToolStripMenuItem = New ToolStripMenuItem()
        LesMiserablesToolStripMenuItem = New ToolStripMenuItem()
        PhantomOfTheOperaToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        lblPax = New Label()
        txtPax = New TextBox()
        rbtnOrchestra = New RadioButton()
        rbtnMezzanine = New RadioButton()
        btnCompute = New Button()
        btnClear = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        lblSubtotal = New Label()
        lblTotalKey = New Label()
        lblSubtotalKey = New Label()
        lblTaxKey = New Label()
        lblTotal = New Label()
        lblTax = New Label()
        MenuStrip1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Bradley Hand ITC", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.WhiteSmoke
        Label1.Location = New Point(114, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(384, 46)
        Label1.TabIndex = 0
        Label1.Text = "Broadway Ticket Play"
        ' 
        ' comboSelectPlay
        ' 
        comboSelectPlay.ForeColor = SystemColors.ControlText
        comboSelectPlay.FormattingEnabled = True
        comboSelectPlay.Items.AddRange(New Object() {"Select Play", "Lion King", "Les Miserables", "Phantom of the Opera"})
        comboSelectPlay.Location = New Point(211, 108)
        comboSelectPlay.Name = "comboSelectPlay"
        comboSelectPlay.Size = New Size(179, 23)
        comboSelectPlay.TabIndex = 1
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FeaturedPlaysToolStripMenuItem, ExitToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(612, 24)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FeaturedPlaysToolStripMenuItem
        ' 
        FeaturedPlaysToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LionKingToolStripMenuItem, LesMiserablesToolStripMenuItem, PhantomOfTheOperaToolStripMenuItem})
        FeaturedPlaysToolStripMenuItem.Name = "FeaturedPlaysToolStripMenuItem"
        FeaturedPlaysToolStripMenuItem.Size = New Size(95, 20)
        FeaturedPlaysToolStripMenuItem.Text = "Featured Plays"
        ' 
        ' LionKingToolStripMenuItem
        ' 
        LionKingToolStripMenuItem.Name = "LionKingToolStripMenuItem"
        LionKingToolStripMenuItem.Size = New Size(192, 22)
        LionKingToolStripMenuItem.Text = "Lion King"
        ' 
        ' LesMiserablesToolStripMenuItem
        ' 
        LesMiserablesToolStripMenuItem.Name = "LesMiserablesToolStripMenuItem"
        LesMiserablesToolStripMenuItem.Size = New Size(192, 22)
        LesMiserablesToolStripMenuItem.Text = "Les Miserables"
        ' 
        ' PhantomOfTheOperaToolStripMenuItem
        ' 
        PhantomOfTheOperaToolStripMenuItem.Name = "PhantomOfTheOperaToolStripMenuItem"
        PhantomOfTheOperaToolStripMenuItem.Size = New Size(192, 22)
        PhantomOfTheOperaToolStripMenuItem.Text = "Phantom of the Opera"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(38, 20)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' lblPax
        ' 
        lblPax.AutoSize = True
        lblPax.BackColor = Color.Transparent
        lblPax.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lblPax.ForeColor = SystemColors.ControlText
        lblPax.Location = New Point(211, 166)
        lblPax.Name = "lblPax"
        lblPax.Size = New Size(54, 32)
        lblPax.TabIndex = 3
        lblPax.Text = "Pax"
        ' 
        ' txtPax
        ' 
        txtPax.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        txtPax.ForeColor = SystemColors.ControlText
        txtPax.Location = New Point(290, 169)
        txtPax.Name = "txtPax"
        txtPax.Size = New Size(100, 32)
        txtPax.TabIndex = 4
        ' 
        ' rbtnOrchestra
        ' 
        rbtnOrchestra.AutoSize = True
        rbtnOrchestra.BackColor = Color.Transparent
        rbtnOrchestra.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbtnOrchestra.ForeColor = SystemColors.ControlText
        rbtnOrchestra.Location = New Point(144, 238)
        rbtnOrchestra.Name = "rbtnOrchestra"
        rbtnOrchestra.Size = New Size(101, 25)
        rbtnOrchestra.TabIndex = 5
        rbtnOrchestra.TabStop = True
        rbtnOrchestra.Text = "Orchestra"
        rbtnOrchestra.UseVisualStyleBackColor = False
        ' 
        ' rbtnMezzanine
        ' 
        rbtnMezzanine.AutoSize = True
        rbtnMezzanine.BackColor = Color.Transparent
        rbtnMezzanine.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rbtnMezzanine.ForeColor = SystemColors.ControlText
        rbtnMezzanine.Location = New Point(144, 269)
        rbtnMezzanine.Name = "rbtnMezzanine"
        rbtnMezzanine.Size = New Size(111, 25)
        rbtnMezzanine.TabIndex = 6
        rbtnMezzanine.TabStop = True
        rbtnMezzanine.Text = "Mezzanine"
        rbtnMezzanine.UseVisualStyleBackColor = False
        ' 
        ' btnCompute
        ' 
        btnCompute.ForeColor = SystemColors.ControlText
        btnCompute.Location = New Point(332, 257)
        btnCompute.Name = "btnCompute"
        btnCompute.Size = New Size(80, 41)
        btnCompute.TabIndex = 7
        btnCompute.Text = "Compute"
        btnCompute.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.ForeColor = SystemColors.ControlText
        btnClear.Location = New Point(418, 257)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(80, 41)
        btnClear.TabIndex = 8
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.Transparent
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 42.02128F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 57.97872F))
        TableLayoutPanel1.Controls.Add(lblSubtotal, 1, 2)
        TableLayoutPanel1.Controls.Add(lblTotalKey, 0, 0)
        TableLayoutPanel1.Controls.Add(lblSubtotalKey, 0, 2)
        TableLayoutPanel1.Controls.Add(lblTaxKey, 0, 1)
        TableLayoutPanel1.Controls.Add(lblTotal, 1, 0)
        TableLayoutPanel1.Controls.Add(lblTax, 1, 1)
        TableLayoutPanel1.Location = New Point(412, 108)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel1.Size = New Size(188, 65)
        TableLayoutPanel1.TabIndex = 10
        ' 
        ' lblSubtotal
        ' 
        lblSubtotal.Anchor = AnchorStyles.Left
        lblSubtotal.AutoSize = True
        lblSubtotal.BackColor = Color.Transparent
        lblSubtotal.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblSubtotal.Location = New Point(82, 45)
        lblSubtotal.Name = "lblSubtotal"
        lblSubtotal.Size = New Size(33, 17)
        lblSubtotal.TabIndex = 14
        lblSubtotal.Text = "N/A"
        lblSubtotal.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblTotalKey
        ' 
        lblTotalKey.Anchor = AnchorStyles.Right
        lblTotalKey.AutoSize = True
        lblTotalKey.BackColor = Color.Transparent
        lblTotalKey.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblTotalKey.Location = New Point(28, 0)
        lblTotalKey.Name = "lblTotalKey"
        lblTotalKey.Size = New Size(48, 20)
        lblTotalKey.TabIndex = 9
        lblTotalKey.Text = "Total:"
        lblTotalKey.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblSubtotalKey
        ' 
        lblSubtotalKey.Anchor = AnchorStyles.Right
        lblSubtotalKey.AutoSize = True
        lblSubtotalKey.BackColor = Color.Transparent
        lblSubtotalKey.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblSubtotalKey.Location = New Point(4, 43)
        lblSubtotalKey.Name = "lblSubtotalKey"
        lblSubtotalKey.Size = New Size(72, 20)
        lblSubtotalKey.TabIndex = 10
        lblSubtotalKey.Text = "Subtotal:"
        lblSubtotalKey.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblTaxKey
        ' 
        lblTaxKey.Anchor = AnchorStyles.Right
        lblTaxKey.AutoSize = True
        lblTaxKey.BackColor = Color.Transparent
        lblTaxKey.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblTaxKey.Location = New Point(39, 21)
        lblTaxKey.Name = "lblTaxKey"
        lblTaxKey.Size = New Size(37, 20)
        lblTaxKey.TabIndex = 11
        lblTaxKey.Text = "Tax:"
        lblTaxKey.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblTotal
        ' 
        lblTotal.Anchor = AnchorStyles.Left
        lblTotal.AutoSize = True
        lblTotal.BackColor = Color.Transparent
        lblTotal.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblTotal.Location = New Point(82, 2)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(33, 17)
        lblTotal.TabIndex = 12
        lblTotal.Text = "N/A"
        lblTotal.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblTax
        ' 
        lblTax.Anchor = AnchorStyles.Left
        lblTax.AutoSize = True
        lblTax.BackColor = Color.Transparent
        lblTax.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblTax.Location = New Point(82, 23)
        lblTax.Name = "lblTax"
        lblTax.Size = New Size(33, 17)
        lblTax.TabIndex = 13
        lblTax.Text = "N/A"
        lblTax.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' PlaySelection
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.pexels_tuur_tisseghem_391535
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(612, 357)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(btnClear)
        Controls.Add(btnCompute)
        Controls.Add(rbtnMezzanine)
        Controls.Add(rbtnOrchestra)
        Controls.Add(txtPax)
        Controls.Add(lblPax)
        Controls.Add(comboSelectPlay)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        ForeColor = Color.WhiteSmoke
        FormBorderStyle = FormBorderStyle.FixedSingle
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "PlaySelection"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "The Opera House"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents comboSelectPlay As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FeaturedPlaysToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LionKingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LesMiserablesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PhantomOfTheOperaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblPax As Label
    Friend WithEvents txtPax As TextBox
    Friend WithEvents rbtnOrchestra As RadioButton
    Friend WithEvents rbtnMezzanine As RadioButton
    Friend WithEvents btnCompute As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblSubtotalKey As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblTotalKey As Label
    Friend WithEvents lblTaxKey As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTax As Label
End Class

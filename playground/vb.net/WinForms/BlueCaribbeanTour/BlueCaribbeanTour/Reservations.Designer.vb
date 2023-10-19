<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservations
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reservations))
        Me.dgvReservations = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.client = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tour_location = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ppl_quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.departure_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.visit_days = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mode_of_payment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.is_cancelled = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsrcReservations = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bnavReservations = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCancelReservation = New System.Windows.Forms.Button()
        CType(Me.dgvReservations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsrcReservations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.bnavReservations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnavReservations.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvReservations
        '
        Me.dgvReservations.AllowUserToAddRows = False
        Me.dgvReservations.AllowUserToDeleteRows = False
        Me.dgvReservations.AutoGenerateColumns = False
        Me.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReservations.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.client, Me.tour_location, Me.ppl_quantity, Me.departure_date, Me.visit_days, Me.mode_of_payment, Me.total_cost, Me.is_cancelled})
        Me.dgvReservations.DataSource = Me.bsrcReservations
        Me.dgvReservations.Location = New System.Drawing.Point(15, 69)
        Me.dgvReservations.Name = "dgvReservations"
        Me.dgvReservations.ReadOnly = True
        Me.dgvReservations.Size = New System.Drawing.Size(694, 295)
        Me.dgvReservations.TabIndex = 0
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'client
        '
        Me.client.DataPropertyName = "client"
        Me.client.HeaderText = "client"
        Me.client.Name = "client"
        Me.client.ReadOnly = True
        Me.client.Visible = False
        '
        'tour_location
        '
        Me.tour_location.DataPropertyName = "tour_location"
        Me.tour_location.HeaderText = "Tour Location"
        Me.tour_location.Name = "tour_location"
        Me.tour_location.ReadOnly = True
        '
        'ppl_quantity
        '
        Me.ppl_quantity.DataPropertyName = "ppl_quantity"
        Me.ppl_quantity.HeaderText = "Number of People"
        Me.ppl_quantity.Name = "ppl_quantity"
        Me.ppl_quantity.ReadOnly = True
        '
        'departure_date
        '
        Me.departure_date.DataPropertyName = "departure_date"
        Me.departure_date.HeaderText = "Departure Date"
        Me.departure_date.Name = "departure_date"
        Me.departure_date.ReadOnly = True
        Me.departure_date.Width = 150
        '
        'visit_days
        '
        Me.visit_days.DataPropertyName = "visit_days"
        Me.visit_days.HeaderText = "Visit Days"
        Me.visit_days.Name = "visit_days"
        Me.visit_days.ReadOnly = True
        '
        'mode_of_payment
        '
        Me.mode_of_payment.DataPropertyName = "mode_of_payment"
        Me.mode_of_payment.HeaderText = "Mode of Payment"
        Me.mode_of_payment.Name = "mode_of_payment"
        Me.mode_of_payment.ReadOnly = True
        '
        'total_cost
        '
        Me.total_cost.DataPropertyName = "total_cost"
        Me.total_cost.HeaderText = "Total Cost"
        Me.total_cost.Name = "total_cost"
        Me.total_cost.ReadOnly = True
        '
        'is_cancelled
        '
        Me.is_cancelled.DataPropertyName = "is_cancelled"
        Me.is_cancelled.HeaderText = "is_cancelled"
        Me.is_cancelled.Name = "is_cancelled"
        Me.is_cancelled.ReadOnly = True
        Me.is_cancelled.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DashboardToolStripMenuItem, Me.ProfileToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(721, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DashboardToolStripMenuItem
        '
        Me.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.DashboardToolStripMenuItem.Text = "Dashboard"
        '
        'ProfileToolStripMenuItem
        '
        Me.ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        Me.ProfileToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ProfileToolStripMenuItem.Text = "Profile"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'bnavReservations
        '
        Me.bnavReservations.AddNewItem = Nothing
        Me.bnavReservations.BindingSource = Me.bsrcReservations
        Me.bnavReservations.CountItem = Me.BindingNavigatorCountItem
        Me.bnavReservations.DeleteItem = Nothing
        Me.bnavReservations.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.bnavReservations.Location = New System.Drawing.Point(0, 24)
        Me.bnavReservations.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bnavReservations.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bnavReservations.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bnavReservations.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bnavReservations.Name = "bnavReservations"
        Me.bnavReservations.PositionItem = Me.BindingNavigatorPositionItem
        Me.bnavReservations.Size = New System.Drawing.Size(721, 25)
        Me.bnavReservations.TabIndex = 14
        Me.bnavReservations.Text = "bnavReservations"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnCancelReservation
        '
        Me.btnCancelReservation.Location = New System.Drawing.Point(15, 389)
        Me.btnCancelReservation.Name = "btnCancelReservation"
        Me.btnCancelReservation.Size = New System.Drawing.Size(143, 49)
        Me.btnCancelReservation.TabIndex = 15
        Me.btnCancelReservation.Text = "Cancel Reservation"
        Me.btnCancelReservation.UseVisualStyleBackColor = True
        '
        'Reservations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 450)
        Me.Controls.Add(Me.btnCancelReservation)
        Me.Controls.Add(Me.bnavReservations)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dgvReservations)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Reservations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservations"
        CType(Me.dgvReservations, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsrcReservations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.bnavReservations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnavReservations.ResumeLayout(False)
        Me.bnavReservations.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvReservations As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents bnavReservations As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents DashboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents bsrcReservations As BindingSource
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents client As DataGridViewTextBoxColumn
    Friend WithEvents tour_location As DataGridViewTextBoxColumn
    Friend WithEvents ppl_quantity As DataGridViewTextBoxColumn
    Friend WithEvents departure_date As DataGridViewTextBoxColumn
    Friend WithEvents visit_days As DataGridViewTextBoxColumn
    Friend WithEvents mode_of_payment As DataGridViewTextBoxColumn
    Friend WithEvents total_cost As DataGridViewTextBoxColumn
    Friend WithEvents is_cancelled As DataGridViewTextBoxColumn
    Friend WithEvents btnCancelReservation As Button
End Class

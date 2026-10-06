<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        mnuExit = New ToolStripMenuItem()
        TaskToolStripMenuItem = New ToolStripMenuItem()
        mnuAdd = New ToolStripMenuItem()
        mnuEdit = New ToolStripMenuItem()
        mnuDelete = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        mnuRefresh = New ToolStripMenuItem()
        ViewToolStripMenuItem = New ToolStripMenuItem()
        mnuStats = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        mnuAbout = New ToolStripMenuItem()
        ToolStrip1 = New ToolStrip()
        btnAdd = New ToolStripButton()
        btnEdit = New ToolStripButton()
        btnDelete = New ToolStripButton()
        btnRefresh = New ToolStripButton()
        StatusStrip1 = New StatusStrip()
        lblStatus = New ToolStripStatusLabel()
        prgStatus = New ToolStripProgressBar()
        SplitContainer1 = New SplitContainer()
        treeCategory = New TreeView()
        GroupBox1 = New GroupBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label2 = New Label()
        dtpFilterDate = New DateTimePicker()
        cboPriority = New ComboBox()
        cboFilter = New ComboBox()
        Label1 = New Label()
        chkUseDateFilter = New CheckBox()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        txtSearch = New TextBox()
        btnSearch = New Button()
        dgvTasks = New DataGridView()
        TableLayoutPanel4 = New TableLayoutPanel()
        chkShowCompleted = New CheckBox()
        numLimit = New NumericUpDown()
        MenuStrip1.SuspendLayout()
        ToolStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        GroupBox1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        CType(dgvTasks, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel4.SuspendLayout()
        CType(numLimit, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, TaskToolStripMenuItem, ViewToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuExit})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' mnuExit
        ' 
        mnuExit.Name = "mnuExit"
        mnuExit.Size = New Size(93, 22)
        mnuExit.Text = "Exit"
        ' 
        ' TaskToolStripMenuItem
        ' 
        TaskToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuAdd, mnuEdit, mnuDelete, ToolStripSeparator1, mnuRefresh})
        TaskToolStripMenuItem.Name = "TaskToolStripMenuItem"
        TaskToolStripMenuItem.Size = New Size(41, 20)
        TaskToolStripMenuItem.Text = "Task"
        ' 
        ' mnuAdd
        ' 
        mnuAdd.Name = "mnuAdd"
        mnuAdd.Size = New Size(113, 22)
        mnuAdd.Text = "Add"
        ' 
        ' mnuEdit
        ' 
        mnuEdit.Name = "mnuEdit"
        mnuEdit.Size = New Size(113, 22)
        mnuEdit.Text = "Edit"
        ' 
        ' mnuDelete
        ' 
        mnuDelete.Name = "mnuDelete"
        mnuDelete.Size = New Size(113, 22)
        mnuDelete.Text = "Delete"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(110, 6)
        ' 
        ' mnuRefresh
        ' 
        mnuRefresh.Name = "mnuRefresh"
        mnuRefresh.Size = New Size(113, 22)
        mnuRefresh.Text = "Refresh"
        ' 
        ' ViewToolStripMenuItem
        ' 
        ViewToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuStats})
        ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        ViewToolStripMenuItem.Size = New Size(44, 20)
        ViewToolStripMenuItem.Text = "View"
        ' 
        ' mnuStats
        ' 
        mnuStats.Name = "mnuStats"
        mnuStats.Size = New Size(180, 22)
        mnuStats.Text = "Statistic"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuAbout})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(44, 20)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' mnuAbout
        ' 
        mnuAbout.Name = "mnuAbout"
        mnuAbout.Size = New Size(107, 22)
        mnuAbout.Text = "About"
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Items.AddRange(New ToolStripItem() {btnAdd, btnEdit, btnDelete, btnRefresh})
        ToolStrip1.Location = New Point(0, 24)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(800, 25)
        ToolStrip1.TabIndex = 1
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' btnAdd
        ' 
        btnAdd.DisplayStyle = ToolStripItemDisplayStyle.Text
        btnAdd.ImageTransparentColor = Color.Magenta
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(33, 22)
        btnAdd.Text = "Add"
        ' 
        ' btnEdit
        ' 
        btnEdit.DisplayStyle = ToolStripItemDisplayStyle.Text
        btnEdit.ImageTransparentColor = Color.Magenta
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(31, 22)
        btnEdit.Text = "Edit"
        ' 
        ' btnDelete
        ' 
        btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Text
        btnDelete.ImageTransparentColor = Color.Magenta
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(44, 22)
        btnDelete.Text = "Delete"
        ' 
        ' btnRefresh
        ' 
        btnRefresh.DisplayStyle = ToolStripItemDisplayStyle.Text
        btnRefresh.ImageTransparentColor = Color.Magenta
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(50, 22)
        btnRefresh.Text = "Refresh"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {lblStatus, prgStatus})
        StatusStrip1.Location = New Point(0, 466)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 22)
        StatusStrip1.TabIndex = 2
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' lblStatus
        ' 
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(77, 17)
        lblStatus.Text = "Jumlah tugas"
        ' 
        ' prgStatus
        ' 
        prgStatus.Margin = New Padding(10, 3, 1, 3)
        prgStatus.Name = "prgStatus"
        prgStatus.Size = New Size(200, 16)
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 49)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(treeCategory)
        SplitContainer1.Panel1.Controls.Add(GroupBox1)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(TableLayoutPanel2)
        SplitContainer1.Size = New Size(800, 417)
        SplitContainer1.SplitterDistance = 173
        SplitContainer1.TabIndex = 3
        ' 
        ' treeCategory
        ' 
        treeCategory.Dock = DockStyle.Fill
        treeCategory.Location = New Point(0, 211)
        treeCategory.Name = "treeCategory"
        treeCategory.Size = New Size(173, 206)
        treeCategory.TabIndex = 1
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TableLayoutPanel1)
        GroupBox1.Dock = DockStyle.Top
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(173, 211)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Filter"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(Label2, 0, 2)
        TableLayoutPanel1.Controls.Add(dtpFilterDate, 0, 5)
        TableLayoutPanel1.Controls.Add(cboPriority, 0, 3)
        TableLayoutPanel1.Controls.Add(cboFilter, 0, 1)
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Controls.Add(chkUseDateFilter, 0, 4)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(3, 19)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 6
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.Size = New Size(167, 189)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Left
        Label2.AutoSize = True
        Label2.Location = New Point(3, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 15)
        Label2.TabIndex = 4
        Label2.Text = "Priority:"
        ' 
        ' dtpFilterDate
        ' 
        dtpFilterDate.Location = New Point(3, 158)
        dtpFilterDate.Name = "dtpFilterDate"
        dtpFilterDate.Size = New Size(161, 23)
        dtpFilterDate.TabIndex = 2
        ' 
        ' cboPriority
        ' 
        cboPriority.DropDownStyle = ComboBoxStyle.DropDownList
        cboPriority.FormattingEnabled = True
        cboPriority.Location = New Point(3, 96)
        cboPriority.Name = "cboPriority"
        cboPriority.Size = New Size(121, 23)
        cboPriority.TabIndex = 1
        ' 
        ' cboFilter
        ' 
        cboFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cboFilter.FormattingEnabled = True
        cboFilter.Location = New Point(3, 34)
        cboFilter.Name = "cboFilter"
        cboFilter.Size = New Size(121, 23)
        cboFilter.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Location = New Point(3, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 15)
        Label1.TabIndex = 3
        Label1.Text = "Status:"
        ' 
        ' chkUseDateFilter
        ' 
        chkUseDateFilter.Anchor = AnchorStyles.Left
        chkUseDateFilter.AutoSize = True
        chkUseDateFilter.CheckAlign = ContentAlignment.MiddleRight
        chkUseDateFilter.Location = New Point(3, 130)
        chkUseDateFilter.Name = "chkUseDateFilter"
        chkUseDateFilter.Size = New Size(82, 19)
        chkUseDateFilter.TabIndex = 5
        chkUseDateFilter.Text = "Due Date ?"
        chkUseDateFilter.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(TableLayoutPanel3, 0, 0)
        TableLayoutPanel2.Controls.Add(dgvTasks, 0, 1)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel4, 0, 2)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 3
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 67F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 13F))
        TableLayoutPanel2.Size = New Size(623, 417)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 5
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 8F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 22F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel3.Controls.Add(txtSearch, 1, 1)
        TableLayoutPanel3.Controls.Add(btnSearch, 3, 1)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(3, 3)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 3
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel3.Size = New Size(617, 77)
        TableLayoutPanel3.TabIndex = 0
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Right
        txtSearch.Location = New Point(114, 26)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(252, 23)
        txtSearch.TabIndex = 0
        ' 
        ' btnSearch
        ' 
        btnSearch.Anchor = AnchorStyles.Left
        btnSearch.Location = New Point(421, 26)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(75, 23)
        btnSearch.TabIndex = 1
        btnSearch.Text = "Cari"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' dgvTasks
        ' 
        dgvTasks.AllowUserToAddRows = False
        dgvTasks.AllowUserToDeleteRows = False
        dgvTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTasks.BackgroundColor = SystemColors.Control
        dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTasks.Dock = DockStyle.Fill
        dgvTasks.Location = New Point(3, 86)
        dgvTasks.MultiSelect = False
        dgvTasks.Name = "dgvTasks"
        dgvTasks.ReadOnly = True
        dgvTasks.RowHeadersVisible = False
        dgvTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTasks.Size = New Size(617, 273)
        dgvTasks.TabIndex = 1
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 5
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel4.Controls.Add(chkShowCompleted, 1, 1)
        TableLayoutPanel4.Controls.Add(numLimit, 3, 1)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(3, 365)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 3
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 70F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        TableLayoutPanel4.Size = New Size(617, 49)
        TableLayoutPanel4.TabIndex = 2
        ' 
        ' chkShowCompleted
        ' 
        chkShowCompleted.Anchor = AnchorStyles.Left
        chkShowCompleted.AutoSize = True
        chkShowCompleted.CheckAlign = ContentAlignment.MiddleRight
        chkShowCompleted.Location = New Point(64, 14)
        chkShowCompleted.Name = "chkShowCompleted"
        chkShowCompleted.Size = New Size(117, 19)
        chkShowCompleted.TabIndex = 0
        chkShowCompleted.Text = "Show Completed"
        chkShowCompleted.UseVisualStyleBackColor = True
        ' 
        ' numLimit
        ' 
        numLimit.Anchor = AnchorStyles.Left
        numLimit.Location = New Point(310, 12)
        numLimit.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        numLimit.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        numLimit.Name = "numLimit"
        numLimit.Size = New Size(120, 23)
        numLimit.TabIndex = 1
        numLimit.Value = New Decimal(New Integer() {50, 0, 0, 0})
        ' 
        ' FormMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 488)
        Controls.Add(SplitContainer1)
        Controls.Add(StatusStrip1)
        Controls.Add(ToolStrip1)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "FormMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ToDoList App"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        CType(dgvTasks, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        CType(numLimit, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents TaskToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAdd As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuDelete As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuRefresh As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuStats As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnAdd As ToolStripButton
    Friend WithEvents btnEdit As ToolStripButton
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents btnRefresh As ToolStripButton
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents prgStatus As ToolStripProgressBar
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents treeCategory As TreeView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents cboFilter As ComboBox
    Friend WithEvents cboPriority As ComboBox
    Friend WithEvents dtpFilterDate As DateTimePicker
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents dgvTasks As DataGridView
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents chkShowCompleted As CheckBox
    Friend WithEvents numLimit As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents chkUseDateFilter As CheckBox

End Class
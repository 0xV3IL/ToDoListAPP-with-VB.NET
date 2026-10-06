<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormStats
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
        grpProgress = New GroupBox()
        lblTotal = New Label()
        lblDone = New Label()
        prgDone = New ProgressBar()
        grpPriority = New GroupBox()
        lvPriority = New ListView()
        colPriority = New ColumnHeader()
        colJumlah = New ColumnHeader()
        colSelesai = New ColumnHeader()
        grpDate = New GroupBox()
        lblStartDate = New Label()
        dtpStart = New DateTimePicker()
        lblEndDate = New Label()
        dtpEnd = New DateTimePicker()
        btnFilterDate = New Button()
        btnClose = New Button()
        grpProgress.SuspendLayout()
        grpPriority.SuspendLayout()
        grpDate.SuspendLayout()
        SuspendLayout()
        ' 
        ' grpProgress
        ' 
        grpProgress.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        grpProgress.Controls.Add(lblTotal)
        grpProgress.Controls.Add(lblDone)
        grpProgress.Controls.Add(prgDone)
        grpProgress.Location = New Point(12, 12)
        grpProgress.Name = "grpProgress"
        grpProgress.Size = New Size(536, 108)
        grpProgress.TabIndex = 0
        grpProgress.TabStop = False
        grpProgress.Text = "Progress Keseluruhan"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblTotal.Location = New Point(16, 28)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(98, 19)
        lblTotal.TabIndex = 0
        lblTotal.Text = "Total Tugas: 0"
        ' 
        ' lblDone
        ' 
        lblDone.AutoSize = True
        lblDone.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblDone.Location = New Point(220, 28)
        lblDone.Name = "lblDone"
        lblDone.Size = New Size(72, 19)
        lblDone.TabIndex = 1
        lblDone.Text = "Selesai: 0"
        ' 
        ' prgDone
        ' 
        prgDone.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        prgDone.Location = New Point(16, 64)
        prgDone.Name = "prgDone"
        prgDone.Size = New Size(504, 26)
        prgDone.TabIndex = 2
        ' 
        ' grpPriority
        ' 
        grpPriority.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        grpPriority.Controls.Add(lvPriority)
        grpPriority.Location = New Point(12, 130)
        grpPriority.Name = "grpPriority"
        grpPriority.Size = New Size(270, 220)
        grpPriority.TabIndex = 1
        grpPriority.TabStop = False
        grpPriority.Text = "Breakdown per Prioritas"
        ' 
        ' lvPriority
        ' 
        lvPriority.Columns.AddRange(New ColumnHeader() {colPriority, colJumlah, colSelesai})
        lvPriority.Dock = DockStyle.Fill
        lvPriority.FullRowSelect = True
        lvPriority.GridLines = True
        lvPriority.Location = New Point(3, 19)
        lvPriority.MultiSelect = False
        lvPriority.Name = "lvPriority"
        lvPriority.Size = New Size(264, 198)
        lvPriority.TabIndex = 0
        lvPriority.UseCompatibleStateImageBehavior = False
        lvPriority.View = View.Details
        ' 
        ' colPriority
        ' 
        colPriority.Text = "Prioritas"
        colPriority.Width = 100
        ' 
        ' colJumlah
        ' 
        colJumlah.Text = "Jumlah"
        colJumlah.Width = 75
        ' 
        ' colSelesai
        ' 
        colSelesai.Text = "Selesai"
        colSelesai.Width = 75
        ' 
        ' grpDate
        ' 
        grpDate.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        grpDate.Controls.Add(lblStartDate)
        grpDate.Controls.Add(dtpStart)
        grpDate.Controls.Add(lblEndDate)
        grpDate.Controls.Add(dtpEnd)
        grpDate.Controls.Add(btnFilterDate)
        grpDate.Location = New Point(294, 130)
        grpDate.Name = "grpDate"
        grpDate.Size = New Size(254, 220)
        grpDate.TabIndex = 2
        grpDate.TabStop = False
        grpDate.Text = "Filter Rentang Tanggal"
        ' 
        ' lblStartDate
        ' 
        lblStartDate.AutoSize = True
        lblStartDate.Location = New Point(15, 30)
        lblStartDate.Name = "lblStartDate"
        lblStartDate.Size = New Size(88, 15)
        lblStartDate.TabIndex = 0
        lblStartDate.Text = "Tanggal Mulai:"
        ' 
        ' dtpStart
        ' 
        dtpStart.Format = DateTimePickerFormat.Short
        dtpStart.Location = New Point(15, 50)
        dtpStart.Name = "dtpStart"
        dtpStart.Size = New Size(220, 23)
        dtpStart.TabIndex = 1
        ' 
        ' lblEndDate
        ' 
        lblEndDate.AutoSize = True
        lblEndDate.Location = New Point(15, 85)
        lblEndDate.Name = "lblEndDate"
        lblEndDate.Size = New Size(94, 15)
        lblEndDate.TabIndex = 2
        lblEndDate.Text = "Tanggal Selesai:"
        ' 
        ' dtpEnd
        ' 
        dtpEnd.Format = DateTimePickerFormat.Short
        dtpEnd.Location = New Point(15, 105)
        dtpEnd.Name = "dtpEnd"
        dtpEnd.Size = New Size(220, 23)
        dtpEnd.TabIndex = 3
        ' 
        ' btnFilterDate
        ' 
        btnFilterDate.Location = New Point(15, 145)
        btnFilterDate.Name = "btnFilterDate"
        btnFilterDate.Size = New Size(220, 30)
        btnFilterDate.TabIndex = 4
        btnFilterDate.Text = "Terapkan Filter"
        btnFilterDate.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnClose.Location = New Point(473, 362)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 26)
        btnClose.TabIndex = 3
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' FormStats
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(560, 400)
        Controls.Add(btnClose)
        Controls.Add(grpDate)
        Controls.Add(grpPriority)
        Controls.Add(grpProgress)
        Name = "FormStats"
        Text = "Statistik Tugas"
        grpProgress.ResumeLayout(False)
        grpProgress.PerformLayout()
        grpPriority.ResumeLayout(False)
        grpDate.ResumeLayout(False)
        grpDate.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents grpProgress As GroupBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblDone As Label
    Friend WithEvents prgDone As ProgressBar
    Friend WithEvents grpPriority As GroupBox
    Friend WithEvents lvPriority As ListView
    Friend WithEvents colPriority As ColumnHeader
    Friend WithEvents colJumlah As ColumnHeader
    Friend WithEvents colSelesai As ColumnHeader
    Friend WithEvents grpDate As GroupBox
    Friend WithEvents lblStartDate As Label
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents lblEndDate As Label
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents btnFilterDate As Button
    Friend WithEvents btnClose As Button
End Class
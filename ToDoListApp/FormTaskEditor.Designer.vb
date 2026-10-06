<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTaskEditor
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
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel9 = New TableLayoutPanel()
        TableLayoutPanel8 = New TableLayoutPanel()
        Label6 = New Label()
        chkCompleted = New CheckBox()
        TableLayoutPanel7 = New TableLayoutPanel()
        Label5 = New Label()
        dtpDue = New DateTimePicker()
        TableLayoutPanel6 = New TableLayoutPanel()
        Label4 = New Label()
        cboCategory = New ComboBox()
        TableLayoutPanel5 = New TableLayoutPanel()
        Label3 = New Label()
        cboPriority = New ComboBox()
        TableLayoutPanel4 = New TableLayoutPanel()
        Label2 = New Label()
        rtbDesc = New RichTextBox()
        TableLayoutPanel2 = New TableLayoutPanel()
        btnSave = New Button()
        btnCancel = New Button()
        TableLayoutPanel3 = New TableLayoutPanel()
        Label1 = New Label()
        txtTitle = New TextBox()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel8.SuspendLayout()
        TableLayoutPanel7.SuspendLayout()
        TableLayoutPanel6.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel1.Controls.Add(TableLayoutPanel9, 0, 6)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel8, 0, 5)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel7, 0, 4)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel6, 0, 3)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel5, 0, 2)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel4, 0, 1)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 0, 7)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel3, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 8
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 11.4548836F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 11.4548845F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 11.4548845F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 11.4548845F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 11.4548845F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 11.4548845F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.36092F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 22.90977F))
        TableLayoutPanel1.Size = New Size(800, 488)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' TableLayoutPanel9
        ' 
        TableLayoutPanel9.ColumnCount = 4
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15.0F))
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 45.0F))
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        TableLayoutPanel9.Dock = DockStyle.Fill
        TableLayoutPanel9.Location = New Point(3, 333)
        TableLayoutPanel9.Name = "TableLayoutPanel9"
        TableLayoutPanel9.RowCount = 1
        TableLayoutPanel9.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel9.Size = New Size(794, 34)
        TableLayoutPanel9.TabIndex = 7
        ' 
        ' TableLayoutPanel8
        ' 
        TableLayoutPanel8.ColumnCount = 4
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15.0F))
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 45.0F))
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        TableLayoutPanel8.Controls.Add(Label6, 1, 0)
        TableLayoutPanel8.Controls.Add(chkCompleted, 2, 0)
        TableLayoutPanel8.Dock = DockStyle.Fill
        TableLayoutPanel8.Location = New Point(3, 278)
        TableLayoutPanel8.Name = "TableLayoutPanel8"
        TableLayoutPanel8.RowCount = 1
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel8.Size = New Size(794, 49)
        TableLayoutPanel8.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label6.AutoSize = True
        Label6.Location = New Point(161, 34)
        Label6.Name = "Label6"
        Label6.Size = New Size(69, 15)
        Label6.TabIndex = 0
        Label6.Text = "Completed:"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' chkCompleted
        ' 
        chkCompleted.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        chkCompleted.CheckAlign = ContentAlignment.MiddleCenter
        chkCompleted.Cursor = Cursors.Hand
        chkCompleted.Location = New Point(280, 26)
        chkCompleted.Name = "chkCompleted"
        chkCompleted.Size = New Size(20, 20)
        chkCompleted.TabIndex = 1
        chkCompleted.TextAlign = ContentAlignment.MiddleCenter
        chkCompleted.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel7
        ' 
        TableLayoutPanel7.ColumnCount = 4
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15.0F))
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 45.0F))
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        TableLayoutPanel7.Controls.Add(Label5, 1, 0)
        TableLayoutPanel7.Controls.Add(dtpDue, 2, 0)
        TableLayoutPanel7.Dock = DockStyle.Fill
        TableLayoutPanel7.Location = New Point(3, 223)
        TableLayoutPanel7.Name = "TableLayoutPanel7"
        TableLayoutPanel7.RowCount = 1
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel7.Size = New Size(794, 49)
        TableLayoutPanel7.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label5.AutoSize = True
        Label5.Location = New Point(161, 34)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 15)
        Label5.TabIndex = 0
        Label5.Text = "Due Date:"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dtpDue
        ' 
        dtpDue.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        dtpDue.Format = DateTimePickerFormat.Short
        dtpDue.Location = New Point(280, 23)
        dtpDue.Name = "dtpDue"
        dtpDue.Size = New Size(150, 23)
        dtpDue.TabIndex = 1
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.ColumnCount = 4
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15.0F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 45.0F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        TableLayoutPanel6.Controls.Add(Label4, 1, 0)
        TableLayoutPanel6.Controls.Add(cboCategory, 2, 0)
        TableLayoutPanel6.Dock = DockStyle.Fill
        TableLayoutPanel6.Location = New Point(3, 168)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 1
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel6.Size = New Size(794, 49)
        TableLayoutPanel6.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label4.AutoSize = True
        Label4.Location = New Point(161, 34)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 15)
        Label4.TabIndex = 0
        Label4.Text = "Category:"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cboCategory
        ' 
        cboCategory.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        cboCategory.FormattingEnabled = True
        cboCategory.Location = New Point(280, 23)
        cboCategory.Name = "cboCategory"
        cboCategory.Size = New Size(121, 23)
        cboCategory.TabIndex = 1
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.ColumnCount = 4
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15.0F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 45.0F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        TableLayoutPanel5.Controls.Add(Label3, 1, 0)
        TableLayoutPanel5.Controls.Add(cboPriority, 2, 0)
        TableLayoutPanel5.Dock = DockStyle.Fill
        TableLayoutPanel5.Location = New Point(3, 113)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 1
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel5.Size = New Size(794, 49)
        TableLayoutPanel5.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label3.AutoSize = True
        Label3.Location = New Point(161, 34)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 15)
        Label3.TabIndex = 0
        Label3.Text = "Priority:"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cboPriority
        ' 
        cboPriority.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        cboPriority.DropDownStyle = ComboBoxStyle.DropDownList
        cboPriority.FormattingEnabled = True
        cboPriority.Location = New Point(280, 23)
        cboPriority.Name = "cboPriority"
        cboPriority.Size = New Size(121, 23)
        cboPriority.TabIndex = 1
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 4
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15.0F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 45.0F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        TableLayoutPanel4.Controls.Add(Label2, 1, 0)
        TableLayoutPanel4.Controls.Add(rtbDesc, 2, 0)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(3, 58)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 1
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel4.Size = New Size(794, 49)
        TableLayoutPanel4.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label2.AutoSize = True
        Label2.Location = New Point(161, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 15)
        Label2.TabIndex = 0
        Label2.Text = "Description:"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' rtbDesc
        ' 
        rtbDesc.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        rtbDesc.Location = New Point(280, 10)
        rtbDesc.Name = "rtbDesc"
        rtbDesc.Size = New Size(250, 36)
        rtbDesc.TabIndex = 1
        rtbDesc.Text = ""
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 4
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10.0F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40.0F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40.0F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10.0F))
        TableLayoutPanel2.Controls.Add(btnSave, 1, 0)
        TableLayoutPanel2.Controls.Add(btnCancel, 2, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(3, 373)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel2.Size = New Size(794, 112)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' btnSave
        ' 
        btnSave.Anchor = AnchorStyles.None
        btnSave.Location = New Point(200, 16)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 0
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Anchor = AnchorStyles.None
        btnCancel.Location = New Point(517, 16)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 23)
        btnCancel.TabIndex = 1
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 4
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15.0F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 45.0F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        TableLayoutPanel3.Controls.Add(Label1, 1, 0)
        TableLayoutPanel3.Controls.Add(txtTitle, 2, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(3, 3)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel3.Size = New Size(794, 49)
        TableLayoutPanel3.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Location = New Point(161, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(32, 15)
        Label1.TabIndex = 0
        Label1.Text = "Title:"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtTitle
        ' 
        txtTitle.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        txtTitle.Location = New Point(280, 23)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(250, 23)
        txtTitle.TabIndex = 1
        ' 
        ' FormTaskEditor
        ' 
        AcceptButton = btnSave
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnCancel
        ClientSize = New Size(800, 488)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormTaskEditor"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Tambah Tugas"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel8.ResumeLayout(False)
        TableLayoutPanel8.PerformLayout()
        TableLayoutPanel7.ResumeLayout(False)
        TableLayoutPanel7.PerformLayout()
        TableLayoutPanel6.ResumeLayout(False)
        TableLayoutPanel6.PerformLayout()
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel5.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents chkCompleted As CheckBox
    Friend WithEvents dtpDue As DateTimePicker
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents cboPriority As ComboBox
    Friend WithEvents rtbDesc As RichTextBox
    Friend WithEvents txtTitle As TextBox
End Class
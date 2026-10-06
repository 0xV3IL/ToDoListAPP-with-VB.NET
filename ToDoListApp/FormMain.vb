Imports MySql.Data.MySqlClient

Public Class FormMain
    Private currentFilter As String = "All"
    Private selectedId As Integer = -1
    Private selectedCategory As String = ""
    Private showCompleted As Boolean = True
    Private useDateFilter As Boolean = False

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboFilter.Items.AddRange({"All", "Active", "Completed"})
        cboFilter.SelectedIndex = 0
        cboPriority.Items.AddRange({"All", "Low", "Medium", "High"})
        cboPriority.SelectedIndex = 0

        chkShowCompleted.Checked = True
        chkUseDateFilter.Checked = False
        dtpFilterDate.Value = DateTime.Today
        dtpFilterDate.Enabled = False

        LoadTree()
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim sql As String = "SELECT id, title, description, priority, due_date, is_completed, category FROM tasks WHERE 1=1"
        Dim p As New Dictionary(Of String, Object)

        If currentFilter = "Active" Then sql &= " AND is_completed=0"
        If currentFilter = "Completed" Then sql &= " AND is_completed=1"

        If Not showCompleted AndAlso currentFilter <> "Completed" Then
            sql &= " AND is_completed=0"
        End If

        If cboPriority.Text <> "All" Then
            sql &= " AND priority=@pri"
            p.Add("@pri", cboPriority.Text)
        End If

        If Not String.IsNullOrEmpty(selectedCategory) Then
            sql &= " AND category=@cat"
            p.Add("@cat", selectedCategory)
        End If

        If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
            sql &= " AND title LIKE @kw"
            p.Add("@kw", "%" & txtSearch.Text & "%")
        End If

        If useDateFilter Then
            sql &= " AND due_date=@due"
            p.Add("@due", dtpFilterDate.Value.ToString("yyyy-MM-dd"))
        End If

        sql &= " ORDER BY is_completed ASC, due_date ASC LIMIT " & numLimit.Value

        Dim dt = ExecuteQuery(sql, p)

        Dim dtView As DataTable = dt.Copy()
        dtView.Columns.Add("No", GetType(Integer)).SetOrdinal(0)
        For i As Integer = 0 To dtView.Rows.Count - 1
            dtView.Rows(i)("No") = i + 1
        Next

        dgvTasks.DataSource = dtView

        With dgvTasks
            If .Columns.Contains("id") Then .Columns("id").Visible = False
            If .Columns.Contains("description") Then .Columns("description").Visible = False

            If .Columns.Contains("No") Then .Columns("No").HeaderText = "No"
            If .Columns.Contains("title") Then .Columns("title").HeaderText = "Judul"
            If .Columns.Contains("priority") Then .Columns("priority").HeaderText = "Prioritas"
            If .Columns.Contains("due_date") Then .Columns("due_date").HeaderText = "Tenggat"
            If .Columns.Contains("is_completed") Then .Columns("is_completed").HeaderText = "Selesai"
            If .Columns.Contains("category") Then .Columns("category").HeaderText = "Kategori"

            If .Columns.Contains("No") Then .Columns("No").Width = 40
            If .Columns.Contains("title") Then .Columns("title").Width = 220
            If .Columns.Contains("priority") Then .Columns("priority").Width = 80
            If .Columns.Contains("due_date") Then .Columns("due_date").Width = 100
            If .Columns.Contains("is_completed") Then .Columns("is_completed").Width = 70
            If .Columns.Contains("category") Then .Columns("category").Width = 100
        End With

        UpdateStatus(dt)
    End Sub

    Private Sub UpdateStatus(dt As DataTable)
        Dim total As Integer = dt.Rows.Count
        Dim done As Integer = dt.Select("is_completed=1").Length
        Dim dateInfo As String = If(useDateFilter, dtpFilterDate.Value.ToString("dd/MM/yyyy"), "-")
        lblStatus.Text = $"Total: {total} | Selesai: {done} | Filter: {currentFilter} | Kategori: {If(String.IsNullOrEmpty(selectedCategory), "Semua", selectedCategory)} | Tanggal: {dateInfo}"
        If total > 0 Then
            prgStatus.Value = CInt(done / total * 100)
        Else
            prgStatus.Value = 0
        End If
    End Sub

    Private Sub LoadTree()
        treeCategory.Nodes.Clear()
        Dim dt = ExecuteQuery("SELECT DISTINCT category FROM tasks WHERE category IS NOT NULL ORDER BY category", Nothing)
        Dim root As New TreeNode("Semua Kategori")
        For Each r As DataRow In dt.Rows
            root.Nodes.Add(r("category").ToString())
        Next
        treeCategory.Nodes.Add(root)
        root.Expand()
        treeCategory.SelectedNode = root
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click, mnuAdd.Click
        Dim f As New FormTaskEditor()
        f.TaskId = -1
        If f.ShowDialog() = DialogResult.OK Then
            LoadData()
            LoadTree()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click, mnuEdit.Click
        If selectedId <= 0 Then
            MessageBox.Show("Pilih tugas dulu.")
            Return
        End If
        Dim f As New FormTaskEditor()
        f.TaskId = selectedId
        If f.ShowDialog() = DialogResult.OK Then
            LoadData()
            LoadTree()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click, mnuDelete.Click
        If selectedId <= 0 Then
            MessageBox.Show("Pilih tugas dulu.")
            Return
        End If
        If MessageBox.Show("Yakin hapus tugas ini?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ExecuteNonQuery("DELETE FROM tasks WHERE id=@id", New Dictionary(Of String, Object) From {{"@id", selectedId}})
            selectedId = -1
            LoadData()
            LoadTree()
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click, mnuRefresh.Click
        LoadData()
        LoadTree()
    End Sub

    Private Sub dgvTasks_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTasks.CellClick
        If e.RowIndex >= 0 Then
            selectedId = CInt(dgvTasks.Rows(e.RowIndex).Cells("id").Value)
        End If
    End Sub

    Private Sub dgvTasks_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTasks.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim id As Integer = CInt(dgvTasks.Rows(e.RowIndex).Cells("id").Value)
            Dim cur As Integer = CInt(dgvTasks.Rows(e.RowIndex).Cells("is_completed").Value)
            ExecuteNonQuery("UPDATE tasks SET is_completed=@s WHERE id=@id",
                New Dictionary(Of String, Object) From {{"@s", If(cur = 1, 0, 1)}, {"@id", id}})
            LoadData()
        End If
    End Sub

    Private Sub cboFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilter.SelectedIndexChanged
        currentFilter = cboFilter.Text
        LoadData()
    End Sub

    Private Sub cboPriority_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPriority.SelectedIndexChanged
        LoadData()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadData()
    End Sub

    Private Sub numLimit_ValueChanged(sender As Object, e As EventArgs) Handles numLimit.ValueChanged
        LoadData()
    End Sub

    Private Sub treeCategory_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles treeCategory.AfterSelect
        If e.Node Is Nothing Then Return
        If e.Node.Level = 0 Then
            selectedCategory = ""
        Else
            selectedCategory = e.Node.Text
        End If
        LoadData()
    End Sub

    Private Sub chkShowCompleted_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowCompleted.CheckedChanged
        showCompleted = chkShowCompleted.Checked
        LoadData()
    End Sub

    Private Sub chkUseDateFilter_CheckedChanged(sender As Object, e As EventArgs) Handles chkUseDateFilter.CheckedChanged
        useDateFilter = chkUseDateFilter.Checked
        dtpFilterDate.Enabled = useDateFilter
        LoadData()
    End Sub

    Private Sub dtpFilterDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpFilterDate.ValueChanged
        If useDateFilter Then LoadData()
    End Sub

    Private Sub mnuStats_Click(sender As Object, e As EventArgs) Handles mnuStats.Click
        Dim f As New FormStats()
        f.Show()
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        Dim f As New FormAbout()
        f.ShowDialog()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Close()
    End Sub
End Class
Public Class FormTaskEditor
    Public Property TaskId As Integer = -1

    Private Sub FormTaskEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboPriority.Items.AddRange({"Low", "Medium", "High"})
        cboPriority.SelectedIndex = 1
        cboCategory.Items.AddRange({"General", "Work", "Personal", "Study", "Shopping"})

        If TaskId > 0 Then
            Me.Text = "Edit Tugas"
            Dim dt = ExecuteQuery("SELECT * FROM tasks WHERE id=@id",
                New Dictionary(Of String, Object) From {{"@id", TaskId}})
            If dt.Rows.Count > 0 Then
                Dim r = dt.Rows(0)
                txtTitle.Text = r("title").ToString()
                rtbDesc.Text = r("description").ToString()
                cboPriority.Text = r("priority").ToString()
                cboCategory.Text = r("category").ToString()
                If Not IsDBNull(r("due_date")) Then dtpDue.Value = CDate(r("due_date"))
                chkCompleted.Checked = CBool(r("is_completed"))
            End If
        Else
            Me.Text = "Tambah Tugas"
            cboCategory.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtTitle.Text) Then
            MessageBox.Show("Judul tidak boleh kosong.")
            Return
        End If

        Dim p As New Dictionary(Of String, Object) From {
            {"@title", txtTitle.Text},
            {"@desc", rtbDesc.Text},
            {"@pri", cboPriority.Text},
            {"@cat", cboCategory.Text},
            {"@due", dtpDue.Value.Date},
            {"@done", If(chkCompleted.Checked, 1, 0)}
        }

        If TaskId > 0 Then
            p.Add("@id", TaskId)
            ExecuteNonQuery("UPDATE tasks SET title=@title, description=@desc, priority=@pri, category=@cat, due_date=@due, is_completed=@done WHERE id=@id", p)
        Else
            ExecuteNonQuery("INSERT INTO tasks (title, description, priority, category, due_date, is_completed) VALUES (@title, @desc, @pri, @cat, @due, @done)", p)
        End If

        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub
End Class
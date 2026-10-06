Public Class FormStats
    Private Sub FormStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpStart.Value = DateTime.Today.AddDays(-30)
        dtpEnd.Value = DateTime.Today.AddDays(30)

        LoadStatistics()
    End Sub

    Private Sub LoadStatistics()
        Try
            Dim startDate As String = dtpStart.Value.ToString("yyyy-MM-dd 00:00:00")
            Dim endDate As String = dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59")

            Dim params As New Dictionary(Of String, Object) From {
                {"@start", startDate},
                {"@end", endDate}
            }

            Dim queryTotal As String = "SELECT COUNT(*) AS total, IFNULL(SUM(is_completed),0) AS done " &
                                     "FROM tasks WHERE due_date BETWEEN @start AND @end"
            Dim dt = ExecuteQuery(queryTotal, params)

            Dim total As Integer = CInt(dt.Rows(0)("total"))
            Dim done As Integer = CInt(dt.Rows(0)("done"))

            lblTotal.Text = $"Total Tugas: {total}"
            lblDone.Text = $"Selesai: {done}"
            If total > 0 Then
                prgDone.Value = CInt(done / total * 100)
            Else
                prgDone.Value = 0
            End If

            lvPriority.Items.Clear()
            Dim queryPriority As String = "SELECT priority, COUNT(*) AS jml, IFNULL(SUM(is_completed),0) AS done " &
                                        "FROM tasks WHERE due_date BETWEEN @start AND @end " &
                                        "GROUP BY priority"
            Dim dtP = ExecuteQuery(queryPriority, params)

            For Each r As DataRow In dtP.Rows
                Dim it As New ListViewItem(r("priority").ToString())
                it.SubItems.Add(r("jml").ToString())
                it.SubItems.Add(r("done").ToString())
                lvPriority.Items.Add(it)
            Next

        Catch ex As Exception
            MessageBox.Show("Error LoadStatistics: " & ex.Message & vbCrLf & vbCrLf & ex.StackTrace, "DEBUG")
        End Try
    End Sub

    Private Sub btnFilterDate_Click(sender As Object, e As EventArgs) Handles btnFilterDate.Click
        LoadStatistics()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class
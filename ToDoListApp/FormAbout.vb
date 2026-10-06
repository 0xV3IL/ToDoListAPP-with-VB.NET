Public Class FormAbout
    Private Sub FormAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblApp.Text = "ToDoList App v1.0"
        lblDesc.Text = "Aplikasi manajemen tugas dengan VB.NET + MySQL"
        lnkGithub.Text = "https://github.com/0xV3IL/ToDoListAPP-with-VB.NET"
    End Sub

    Private Sub lnkGithub_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkGithub.LinkClicked
        Try
            Dim psi As New ProcessStartInfo() With {
                .FileName = lnkGithub.Text,
                .UseShellExecute = True
            }
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show("Gagal membuka link: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Close()
    End Sub
End Class
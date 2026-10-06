Imports MySql.Data.MySqlClient

Module Module1
    Public Const ConnStr As String = "server=localhost;user=root;password=;database=tododb"

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(ConnStr)
    End Function

    Public Function ExecuteNonQuery(sql As String, params As Dictionary(Of String, Object)) As Integer
        Using conn = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand(sql, conn)
                If params IsNot Nothing Then
                    For Each kv In params
                        cmd.Parameters.AddWithValue(kv.Key, kv.Value)
                    Next
                End If
                Return cmd.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Public Function ExecuteQuery(sql As String, params As Dictionary(Of String, Object)) As DataTable
        Using conn = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand(sql, conn)
                If params IsNot Nothing Then
                    For Each kv In params
                        cmd.Parameters.AddWithValue(kv.Key, kv.Value)
                    Next
                End If
                Using adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function
End Module
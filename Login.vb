Imports MySql.Data.MySqlClient

Public Class Login
    Dim conn As MySqlConnection
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connectionnString As String = "server=localhost;port=3306;user=root;password='qwerty';database=mover"
        conn = New MySqlConnection(connectionnString)

        Try
            conn.Open()
            MessageBox.Show("Connection Successful")
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

    End Sub
End Class
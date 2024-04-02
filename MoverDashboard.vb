Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class MoverDashboard
    Private connectionString As String = "Data Source=localhost;Initial Catalog=sys;Integrated Security=True"
    Dim connection As MySqlConnection
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Connect to the database

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' Retrieve specific columns from database
            Dim query As String = "SELECT FirstName, PhoneNumber, email FROM users"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            ' Bind DataGridView to DataTable
            DataGridView1.DataSource = dataTable
        End Using
    End Sub

End Class
Module HelperFunctions
    Public Function GetConnection()
        Dim ConnectionString As String = "server=localhost;port=3306;user=root;password='qwerty';database=mover;"
        Return ConnectionString
    End Function
End Module

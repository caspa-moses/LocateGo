Module HelperFunctions
    Public Function GetConnection()
        Dim ConnectionString As String = "server=localhost;port=3306;user=root;password='qwerty';database=Locate_and_Go;"
        Return ConnectionString
    End Function
End Module

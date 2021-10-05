Imports System.Data.SqlClient
Public MustInherit Class ConnectionToSql
    Private connectionString As String
    Protected Sub New()

        'connectionString = "Data Source=MAT-COS-DB-10Z2\SQLEXPRESS;Initial Catalog=Usuarios;integrated security=true" 'Miguel
        connectionString = "Data Source=tcp:COS-F37HWK2\SQLEXPRESS,49500;Initial Catalog=Usuarios; User Id=simpro; Password=Trpo25MgL452" 'Choi

    End Sub
    Protected Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function
End Class

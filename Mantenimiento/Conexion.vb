Module Conexion

    Public formularios As New List(Of Form) 'Crea una lista fe formularios para cerrar


    ' Public conexion As String = "Data Source=192.168.18.52\SQLEXPRESS;Initial Catalog=Inventario; User Id=migue; Password=1234" 'Miguel CASA
    'miguel Public conexion As String = "Data Source=MAT-COS-DB-10Z2\SQLEXPRESS;Initial Catalog=Inventario;integrated security=true" 'Miguel
    ' Public conexion As String = "Data Source=MAT-COS-DB-10Z2\SQLEXPRESS;Initial Catalog=Inventario; User Id=test; Password=test" 'Miguel Compuatadora
    Public conexion As String = "Data Source=tcp:COS-F4Z1XQ2\SQLEXPRESS,49500;Initial Catalog=Inventario; User Id=malvarado; Password=1234Admin" 'Choi



    Public cn As New SqlClient.SqlConnection(conexion)

        Sub conectar()

        Try
            If cn.State = ConnectionState.Open Then
            Else

                cn.Open()


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

        Sub desconectar()

        cn.Close()

    End Sub
    End Module




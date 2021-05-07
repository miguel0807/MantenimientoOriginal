Imports System.Data.SqlClient
Module Conexion

    Public formularios As New List(Of Form) 'Crea una lista fe formularios para cerrar


    ' Public conexion As String = "Data Source=192.168.18.52\SQLEXPRESS;Initial Catalog=Inventario; User Id=migue; Password=1234" 'Miguel CASA
    'miguel Public conexion As String = "Data Source=MAT-COS-DB-10Z2\SQLEXPRESS;Initial Catalog=Inventario;integrated security=true" 'Miguel
    'Public conexion As String = "Data Source=MAT-COS-DB-10Z2\SQLEXPRESS;Initial Catalog=Inventario; User Id=test; Password=test" 'Miguel Compuatadora
    Public conexion As String = "Data Source=tcp:COS-F4Z1XQ2\SQLEXPRESS,49500;Initial Catalog=Inventario; User Id=malvarado; Password=1234Admin" 'Choi



    Public cn As New SqlClient.SqlConnection(conexion)
    Public CerrarSubs As Boolean = False


    Sub conectar()

        Try
            If PrConexion() = True Then
                ' MessageBox.Show("Conexion correcta", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If cn.State = ConnectionState.Open Then
                Else

                    cn.Open()
                    CerrarSubs = False

                End If
            Else
                If CerrarSubs = False Then
                    MessageBox.Show("No hay conexión al servidor principal, vuelva a intentar mas tarde", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    CerrarSubs = True

                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub desconectar()

        cn.Close()

    End Sub


    Public Function PrConexion() As Boolean
        Try
            Using ProbarConexion As New SqlConnection(conexion)
                ProbarConexion.Open()
            End Using
        Catch Exp As Exception
            ' MessageBox.Show(Exp.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End Try
        Return True
    End Function

    Sub VerificarConexion()
        If PrConexion() = True Then
            MessageBox.Show("Conexion correcta", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Conexion fallida", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub




End Module




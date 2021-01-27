Imports System.Data.SqlClient
Module MO_Tareas
    Public codigoTarea As Integer
    Public txtTarea As String
    Public txtMateriales As String
    Public intTiempo As Integer

    Sub CrearTarea()

#Region "Insertar en la lista de equipos la informacion del nuevo equipo"
        Dim adaptador1 As New SqlCommand("insert into Caracteristicas_Tareas values(" & codigoTarea & ",'" & txtTarea & "','" & txtMateriales & "'," & intTiempo & "))", cn)
        conectar()
        adaptador1.ExecuteNonQuery()
        desconectar()
        MsgBox("Tarea agregada correctamente")


#End Region
    End Sub
End Module

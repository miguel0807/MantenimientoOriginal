Imports System.Data.SqlClient

Public Class Indicadores_Editable
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim adaptador As New SqlCommand("insert into Indicadores values ('" & Nombre.Text & "','" & Ubicacion.Text & "','" & Clasificacion.Text & "','" & Descripcion.Text & "','" & Fecha.Text & "','" & fecha_final.Text & "'," & 0 & ")", cn)
        conectar()
        adaptador.ExecuteNonQuery()
        MsgBox("Se registro correctamente")
        desconectar()
        Me.Close()

    End Sub
End Class
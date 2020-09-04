Imports System.Data.SqlClient

Public Class Indicadores_Nuevo



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click




        Dim adaptador As New SqlCommand("insert into Indicadores values ('" & Nombre.Text & "','" & Ubicacion.Text & "','" & Clasificacion.Text & "','" & Descripcion.Text & "','" & Fecha.Text & "','" & fecha_final.Text & "'," & 1 & ")", cn)
        conectar()
        adaptador.ExecuteNonQuery()
        MsgBox("Se registro correctamente")
        desconectar()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
#Region "Colocacion de fecha cuando se genera la licencia"


        Fecha.Text = DateTime.Now
        Dim fechacreacion As Date
        fechacreacion = Fecha.Text
        Fecha.Text = Format(fechacreacion, "yyyy/MM/dd HH:mm")
#End Region
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        Dim adaptador As New SqlCommand("insert into Indicadores values ('" & Nombre.Text & "','" & Ubicacion.Text & "','" & Clasificacion.Text & "','" & Descripcion.Text & "','" & Fecha.Text & "','" & fecha_final.Text & "'," & 0 & ")", cn)
        conectar()
        adaptador.ExecuteNonQuery()
        MsgBox("Se registro correctamente")
        desconectar()
        Me.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
#Region "Colocacion de fecha cuando se genera la licencia"


        fecha_final.Text = DateTime.Now
        Dim fechacreacion As Date
        fechacreacion = fecha_final.Text
        fecha_final.Text = Format(fechacreacion, "yyyy/MM/dd HH:mm")
#End Region
    End Sub
End Class
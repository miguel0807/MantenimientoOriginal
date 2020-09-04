Imports System.Data.SqlClient

Public Class Indicadores_Editable
    Public Caso As Integer
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        conectar()
        Dim actualizarnombre As New SqlCommand("Update Indicadores SET Nombre =('" & Nombre.Text & "'  ), Ubicacion =('" & Ubicacion.Text & "'), Clasificacion =('" & Clasificacion.Text & "') , Descripcion =('" & Descripcion.Text & "'), [Fecha Inicial] =('" & Fecha.Text & "'), [Fecha Final] =('" & fecha_final.Text & "'), [Estado] =(" & 0 & ")  where [Caso] = ('" & Caso & "')", cn)

        actualizarnombre.ExecuteNonQuery()
        cn.Close()
        MsgBox("Completado")

        ' MsgBox(actualizarnombre.CommandText)
        Me.Close()
    End Sub

    Private Sub Indicadores_Editable_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
#Region "Colocacion de fecha cuando se genera la licencia"


        Fecha.Text = DateTime.Now
        Dim fechacreacion As Date
        fechacreacion = Fecha.Text
        Fecha.Text = Format(fechacreacion, "yyyy/MM/dd HH:mm")
#End Region
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
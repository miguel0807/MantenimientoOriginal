Imports System.Data.SqlClient

Public Class Indicadores_Editable
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        conectar()
        Dim actualizarnombre As New SqlCommand("Update Indicadores SET Nombre =('" & Nombre.Text & "'  ) where [Fecha Inicial] = ('" & Fecha.Text & "')", cn)

        actualizarnombre.ExecuteNonQuery()
        cn.Close()
        MsgBox(actualizarnombre.CommandText)
        Me.Close()
    End Sub

    Private Sub Indicadores_Editable_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
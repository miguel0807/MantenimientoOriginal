Imports System.Data.SqlClient
Public Class MaterialNuevo
    Dim count As Integer
    Private Sub Ingresar_Click(sender As Object, e As EventArgs) Handles Ingresar.Click


        Dim adaptador As New SqlCommand("insert into Bodega values (" & count & ",'" & Material.Text & "'," & Cantidad.Text & ",'" & Unidad.Text & "','" & Marca.Text & "','" & Modelo.Text & "','" & Serie.Text & "','" & Ubicacion.Text & "','" & Descripcion.Text & "','" & Clasificacion.Text & "')", cn)
        conectar()
        adaptador.ExecuteNonQuery()
        MsgBox("Se registro correctamente")

        'Material.Text = ""
        'Cantidad.Text = ""
        'Unidad.Text = ""
        'Marca.Text = ""
        'Modelo.Text = ""
        'Serie.Text = ""
        'Ubicacion.Text = ""
        'Descripcion.Text = ""
        'Clasificacion.Text = ""
        desconectar()
    End Sub

    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles Borrar.Click
        Material.Text = ""
        Cantidad.Text = ""
        Unidad.Text = ""
        Marca.Text = ""
        Modelo.Text = ""
        Serie.Text = ""
        Ubicacion.Text = ""
        Descripcion.Text = ""
        Clasificacion.Text = ""
    End Sub

    Private Sub MaterialNuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()

        Dim Query As String
        Query = ("select COUNT (Codigo) from Bodega")
        Dim cmd As New SqlCommand(Query, cn)
        count = cmd.ExecuteScalar

        'Coloca la cantidad de filas que hay en la tabla temporal
        desconectar()

    End Sub
End Class

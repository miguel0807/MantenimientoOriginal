Imports System.Data.SqlClient
Public Class MaterialNuevo
    Dim count As Integer
    Dim codigo1 As String
    Private Sub Ingresar_Click(sender As Object, e As EventArgs) Handles Ingresar.Click


        Dim adaptador As New SqlCommand("insert into Bodega values (" & count & ",'" & Material.Text & "'," & Cantidad.Text & ",'" & Unidad.Text & "','" & Marca.Text & "','" & Modelo.Text & "','" & Serie.Text & "','" & Ubicacion.Text & "','" & Descripcion.Text & "','" & Clasificacion.Text & "','" & Codigo.Text & "','" & Empresa.Text & "','" & Parte.Text & "','" & Equipo.Text & "')", cn)
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
        CenterToScreen()

        conectar()

        Dim Query As String
        Query = ("select COUNT (Conteo) from Bodega")
        Dim cmd As New SqlCommand(Query, cn)
        count = cmd.ExecuteScalar
        Codigo.Text = "MATCR-" & count
        'Coloca la cantidad de filas que hay en la tabla temporal
        desconectar()
        Codigo.Enabled = False
    End Sub

    Private Sub Serie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Serie.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Parte.TextChanged

    End Sub
End Class

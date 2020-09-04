Imports System.Data.SqlClient
Public Class MaterialNuevo
    Private Sub Ingresar_Click(sender As Object, e As EventArgs) Handles Ingresar.Click
        Dim conexion As String
        conexion = "Data Source=MAT-COS-DB-10Z2\SQLEXPRESS;Initial Catalog=Inventario;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion


        Dim adaptador As New SqlCommand("insert into Bodega values ('" & Material.Text & "'," & Cantidad.Text & ",'" & Unidad.Text & "','" & Marca.Text & "','" & Modelo.Text & "','" & Serie.Text & "','" & Ubicacion.Text & "','" & Descripcion.Text & "','" & Clasificacion.Text & "')", cn)
        cn.Open()
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

    End Sub
End Class

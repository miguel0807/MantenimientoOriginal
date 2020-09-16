Imports System.Data.SqlClient

Public Class Busqueda_Material
    Private Sub Busqueda_Material_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        conectar()

        Dim conteo As String
        conteo = 1



        Dim tabla As DataGridView = DataGridView1
        Dim adaptador As New SqlDataAdapter("select*from Bodega where convert(char,[" & Tipo.Text & "]) like '%" & busqueda.Text & "%'", cn)
        Dim dataS As New DataSet
        'busqueda.Text = adaptador.SelectCommand.CommandText
        adaptador.Fill(dataS, "Indicadores")

        tabla.DataSource = dataS.Tables("Indicadores")

        tabla.Columns.Item(0).Visible = False

        tabla.RowHeadersVisible = False

        tabla.Columns(1).Width = 150
        tabla.Columns(2).Width = 80
        tabla.Columns(3).Width = 80
        tabla.Columns(4).Width = 80

        tabla.Columns(5).Width = 80
        tabla.Columns(6).Width = 80
        tabla.Columns(7).Width = 80
        tabla.Columns(8).Width = 200

        tabla.Columns(9).Width = 80
        tabla.Columns(10).Width = 80
        tabla.Columns(11).Width = 80
        tabla.Columns(12).Width = 80

        tabla.Columns(13).Width = 80


        Label1.Visible = True

        Label1.Text = "Cantidad: " & tabla.RowCount
        desconectar()

    End Sub
End Class
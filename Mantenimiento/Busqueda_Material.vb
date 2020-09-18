Imports System.Data.SqlClient

Public Class Busqueda_Material
    Private Sub Busqueda_Material_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()
        Tipo.SelectedIndex = 0




    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
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

        tabla.Columns(1).Width = 200
        tabla.Columns(2).Width = 80
        tabla.Columns(3).Width = 80
        tabla.Columns(4).Width = 100



        tabla.Columns(5).Width = 100
        tabla.Columns(6).Width = 100
        tabla.Columns(7).Width = 120
        tabla.Columns(8).Width = 250

        tabla.Columns(9).Width = 100
        tabla.Columns(10).Width = 100

        tabla.Columns(11).Width = 80
        tabla.Columns(12).Width = 80
        tabla.Columns(13).Width = 150




        Label1.Visible = True

        Label1.Text = "Cantidad: " & tabla.RowCount
        desconectar()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Modificar_Material.Show()


        Me.DataGridView1.Select() 'Seleccionar primera fila del datagridview



        'Almacena informacion para ser impresa

        Modificar_Material.conteo = Me.DataGridView1.CurrentRow.Cells.Item(0).Value.ToString

        Modificar_Material.Material.Text = Me.DataGridView1.CurrentRow.Cells.Item(1).Value.ToString
        Modificar_Material.Cantidad.Text = Me.DataGridView1.CurrentRow.Cells.Item(2).Value.ToString
        Modificar_Material.Unidad.Text = Me.DataGridView1.CurrentRow.Cells.Item(3).Value.ToString




        Modificar_Material.Marca.Text = Me.DataGridView1.CurrentRow.Cells.Item(4).Value.ToString
        Modificar_Material.Modelo.Text = Me.DataGridView1.CurrentRow.Cells.Item(5).Value.ToString
        Modificar_Material.Serie.Text = Me.DataGridView1.CurrentRow.Cells.Item(6).Value.ToString
        Modificar_Material.Ubicacion.Text = Me.DataGridView1.CurrentRow.Cells.Item(7).Value.ToString
        Modificar_Material.Descripcion.Text = Me.DataGridView1.CurrentRow.Cells.Item(8).Value.ToString
        Modificar_Material.Clasificacion.Text = Me.DataGridView1.CurrentRow.Cells.Item(9).Value.ToString

        Modificar_Material.Codigo.Text = Me.DataGridView1.CurrentRow.Cells.Item(10).Value.ToString

        Modificar_Material.Empresa.Text = Me.DataGridView1.CurrentRow.Cells.Item(11).Value.ToString
        Modificar_Material.Parte.Text = Me.DataGridView1.CurrentRow.Cells.Item(12).Value.ToString
        Modificar_Material.Equipo.Text = Me.DataGridView1.CurrentRow.Cells.Item(13).Value.ToString


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class
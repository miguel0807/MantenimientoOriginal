Imports System.Data.SqlClient

Public Class Busqueda_Material
    Private Sub Busqueda_Material_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not formularios.Contains(Me) Then formularios.Add(Me) 'Agrega a la lista los formularios para luego cerrarlos


        CenterToScreen()
        Tipo.SelectedIndex = 0




    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        materiales_busqueda()
    End Sub

    Private Sub busqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles busqueda.KeyDown
        If e.KeyCode = Keys.Enter Then
            materiales_busqueda()
        End If
    End Sub
#Region "Materiales busqueda"
    Sub materiales_busqueda()
        Try
            conectar()

            Dim conteo As String
            conteo = 1



            Dim tabla As DataGridView = Me.DataGridView1
            Dim adaptador As New SqlDataAdapter("select*from Bodega where convert(char,[" & Me.Tipo.Text & "]) like '%" & Me.busqueda.Text & "%' order by Convert(char,Ubicacion) asc  ", cn)
            Dim dataS As New DataSet
            'busqueda.Text = adaptador.SelectCommand.CommandText
            adaptador.Fill(dataS, "Indicadores")

            tabla.DataSource = dataS.Tables("Indicadores")

            tabla.Columns.Item(0).Visible = False

            tabla.RowHeadersVisible = False

            tabla.Columns(1).Width = 400
            tabla.Columns(2).Width = 110
            tabla.Columns(3).Width = 80
            tabla.Columns(4).Width = 150



            tabla.Columns(5).Width = 170
            tabla.Columns(6).Width = 150
            tabla.Columns(7).Width = 150
            tabla.Columns(8).Width = 400

            tabla.Columns(9).Width = 150
            tabla.Columns(10).Width = 150

            tabla.Columns(11).Width = 150
            tabla.Columns(12).Width = 150
            tabla.Columns(13).Width = 350



#Region "Formato de letra"
            Me.DataGridView1.DefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)
            Me.DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)

#End Region
            '  DataGridView1.RowTemplate.Height = 50
#Region "Cambios de color celdas y alternadas"
            Me.DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
            Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control)

#End Region
#Region "Personalizacion header"
            Me.DataGridView1.EnableHeadersVisualStyles = False
            Me.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51)
            Me.DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            Me.DataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(218, 218, 218)
            Me.DataGridView1.RowsDefaultCellStyle.SelectionForeColor = Color.Black

            Me.DataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 51, 51)

            'formulario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

#End Region
#Region "Alineacion de titulos"
            Me.DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
#End Region

            Me.Label1.Visible = True

            Me.Label1.Text = "Cantidad: " & tabla.RowCount
            desconectar()



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
End Class
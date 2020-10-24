Imports System.Data.SqlClient
Public Class MaterialNuevo
    Dim count As Integer
    Dim codigo1 As String
    Private Sub Ingresar_Click(sender As Object, e As EventArgs) Handles Ingresar.Click

        Try


            If Material.Text = "" Or Cantidad.Text = "" Or Unidad.Text = "" Or Empresa.Text = "" Or Parte.Text = "" Or Equipo.Text = "" Or Marca.Text = "" Or Modelo.Text = "" Or Serie.Text = "" Or Ubicacion.Text = "" Or Clasificacion.Text = "" Or Descripcion.Text = "" Then
                MsgBox("Complete todos los campos para agregar material nuevo")
                Exit Sub

            End If

            Dim adaptador As New SqlCommand("insert into Bodega values (" & count & ",'" & Material.Text & "'," & Cantidad.Text & ",'" & Unidad.Text & "','" & Marca.Text & "','" & Modelo.Text & "','" & Serie.Text & "','" & Ubicacion.Text & "','" & Descripcion.Text & "','" & Clasificacion.Text & "','" & Codigo.Text & "','" & Empresa.Text & "','" & Parte.Text & "','" & Equipo.Text & "')", cn)
            conectar()
            adaptador.ExecuteNonQuery()
            MsgBox("Se registro correctamente")
            Me.Close()
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

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Borrar_Click(sender As Object, e As EventArgs)
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
        If Not formularios.Contains(Me) Then formularios.Add(Me) 'Agrega a la lista los formularios para luego cerrarlos
        Try
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

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Serie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Serie.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Parte.TextChanged

    End Sub

    Sub materiales_busqueda()
        Try
            conectar()

            Dim conteo As String
            conteo = 1



            Dim tabla As DataGridView = Busqueda_Material.DataGridView1
            Dim adaptador As New SqlDataAdapter("select*from Bodega where convert(char,[" & Busqueda_Material.Tipo.Text & "]) like '%" & Busqueda_Material.busqueda.Text & "%' order by Convert(char,Ubicacion) asc  ", cn)
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
            Busqueda_Material.DataGridView1.DefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)
            Busqueda_Material.DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)


#End Region
            '  DataGridView1.RowTemplate.Height = 50
#Region "Color de los titulos"
            Busqueda_Material.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.SlateGray
            Busqueda_Material.DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
#End Region
#Region "Cambios de color celdas y alternadas"
            Busqueda_Material.DataGridView1.RowsDefaultCellStyle.BackColor = Color.LightGray
            Busqueda_Material.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray

#End Region
#Region "Alineacion de titulos"
            Busqueda_Material.DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
#End Region

            Busqueda_Material.Label1.Visible = True

            Busqueda_Material.Label1.Text = "Cantidad: " & tabla.RowCount
            desconectar()



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class

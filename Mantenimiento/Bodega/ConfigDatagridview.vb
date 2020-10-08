Imports System.Data.SqlClient


Module ConfigDatagridview
    Sub datag()


#Region "Configuracion datagridview1"
        conectar()

        Dim conteo As String
        conteo = 1
#Region "Formato de letra"
        Indicadores_Proceso.DataGridView1.DefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)
        Indicadores_Proceso.DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)

#End Region
        ' Indicadores_Proceso.DataGridView1.RowTemplate.Height = 25
#Region "Color de los titulos"
        Indicadores_Proceso.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.SlateGray
        Indicadores_Proceso.DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
#End Region
#Region "Cambios de color celdas y alternadas"
        Indicadores_Proceso.DataGridView1.RowsDefaultCellStyle.BackColor = Color.LightGray
        Indicadores_Proceso.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray

#End Region
#Region "Alineacion de titulos"
        Indicadores_Proceso.DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
#End Region
#Region "Buscar casos abiertos"

        Dim tabla As DataGridView = Indicadores_Proceso.DataGridView1
        Dim adaptador As New SqlDataAdapter("select*from Indicadores where Estado=" & conteo & "", cn)
        Dim dataS As New DataSet
        adaptador.Fill(dataS, "Indicadores")

        tabla.DataSource = dataS.Tables("Indicadores")

#End Region


#Region "Configuracion tabla"



        tabla.RowHeadersVisible = False
        tabla.Columns.Item(6).Visible = False
        tabla.Columns.Item(7).Visible = False
        tabla.Columns.Item(0).Visible = False
        tabla.Columns.Item(11).Visible = False


        tabla.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        tabla.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        tabla.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        tabla.Columns(1).Width = 380
        tabla.Columns(2).Width = 240
        tabla.Columns(3).Width = 170
        tabla.Columns(4).Width = 450
        tabla.Columns(5).DefaultCellStyle.Format = "MM/dd/yyyy"
        tabla.Columns(5).Width = 140


        For Each r As DataGridViewRow In Indicadores_Proceso.DataGridView1.Rows
            If r.Cells("Seleccion").Value = "1" Then
                r.DefaultCellStyle.BackColor = Color.Green

            End If
        Next
#End Region
#End Region



#Region "Conteo de casos abiertos"

        Indicadores_Proceso.Label1.Visible = True
        Indicadores_Proceso.Label1.Text = "Casos pendientes: " & tabla.RowCount
        Indicadores_Proceso.conteo_total = tabla.RowCount
#End Region
    End Sub

    Sub prue()
#Region "Configuracion datagridview1"

        Dim conteo As String
        conteo = 1
#Region "Formato de letra"
        Indicadores_Proceso.DataGridView1.DefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)
        Indicadores_Proceso.DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)

#End Region
        '  DataGridView1.RowTemplate.Height = 50
#Region "Color de los titulos"
        Indicadores_Proceso.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.SlateGray
        Indicadores_Proceso.DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
#End Region
#Region "Cambios de color celdas y alternadas"
        Indicadores_Proceso.DataGridView1.RowsDefaultCellStyle.BackColor = Color.LightGray
        Indicadores_Proceso.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray

#End Region
#Region "Alineacion de titulos"
        Indicadores_Proceso.DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
#End Region


        Dim tabla As DataGridView = Indicadores_Proceso.DataGridView1



#Region "Configuracion tabla"



        tabla.RowHeadersVisible = False
        tabla.Columns.Item(6).Visible = False
        tabla.Columns.Item(7).Visible = False
        tabla.Columns.Item(0).Visible = False
        tabla.Columns.Item(11).Visible = False


        tabla.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        tabla.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        tabla.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        tabla.Columns(1).Width = 380
        tabla.Columns(2).Width = 240
        tabla.Columns(3).Width = 170
        tabla.Columns(4).Width = 450
        tabla.Columns(5).DefaultCellStyle.Format = "MM/dd/yyyy"
        tabla.Columns(5).Width = 140


        For Each r As DataGridViewRow In Indicadores_Proceso.DataGridView1.Rows
            If r.Cells("Seleccion").Value = "1" Then
                r.DefaultCellStyle.BackColor = Color.Green

            End If
        Next
#End Region
#End Region



#Region "Conteo de casos abiertos"

        Indicadores_Proceso.Label1.Visible = True
        Indicadores_Proceso.Label1.Text = "Casos pendientes: " & tabla.RowCount
        Indicadores_Proceso.conteo_total = tabla.RowCount
#End Region
    End Sub


    Sub materiales_busqueda()
        Try
            conectar()

            Dim conteo As String
            conteo = 1



            Dim tabla As DataGridView = Busqueda_Material.DataGridView1
            Dim adaptador As New SqlDataAdapter("select*from Bodega where convert(char,[" & Busqueda_Material.Tipo.Text & "]) like '%" & Busqueda_Material.busqueda.Text & "%'", cn)
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
End Module

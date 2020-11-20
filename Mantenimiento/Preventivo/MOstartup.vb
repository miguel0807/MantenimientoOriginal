Imports System.Data.SqlClient


Public Module MOstartup
    Public datagr As DataGridView
    Public labe1 As Label
    Sub generalaño()



#Region "Configuracion datagridview1"
        conectar()

        Dim conteo As String
        conteo = 1

#Region "Formato de letra"

        datagr.DefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)
        datagr.ColumnHeadersDefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)

#End Region
        '        datagr.RowTemplate.Height = 30
        '#Region "Color de los titulos"
        '        datagr.ColumnHeadersDefaultCellStyle.BackColor = Color.SlateGray
        '        datagr.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        '#End Region
        '#Region "Cambios de color celdas y alternadas"
        '        datagr.RowsDefaultCellStyle.BackColor = Color.LightGray
        '        datagr.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray

        '#End Region
#Region "Alineacion de titulos"
        datagr.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
#End Region
#End Region

#Region "Buscar la planificacion"




        Dim adaptador As New SqlDataAdapter("Select*from Startup", cn)
        Dim dataS As New DataSet
        adaptador.Fill(dataS, "ConteoPlanificacion_Equipos")

        datagr.DataSource = dataS.Tables("ConteoPlanificacion_Equipos")
        Dim columncheck As New DataGridViewCheckBoxColumn
        columncheck.HeaderText = "Realizado"
        columncheck.Name = "cerrar"
        datagr.Columns.Add(columncheck)
#End Region


        '#Region "Configuracion tabla"
        datagr.Columns(0).Visible = False
        datagr.Columns(3).Visible = False
        datagr.Columns(4).Visible = False
        datagr.RowHeadersVisible = False


        datagr.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        datagr.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        datagr.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        datagr.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '        datagr.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '        datagr.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '        datagr.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '        datagr.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '        datagr.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '        datagr.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '        datagr.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '        datagr.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '        datagr.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '        datagr.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter



        '        datagr.Columns(1).Width = 225


        '        datagr.Columns(2).Width = 110
        '        datagr.Columns(3).Width = 110
        '        datagr.Columns(4).Width = 110
        '        datagr.Columns(5).Width = 110
        '        datagr.Columns(6).Width = 110
        '        datagr.Columns(7).Width = 110
        '        datagr.Columns(8).Width = 110
        '        datagr.Columns(9).Width = 110
        '        datagr.Columns(10).Width = 110
        '        datagr.Columns(11).Width = 110
        '        datagr.Columns(12).Width = 110
        '        datagr.Columns(13).Width = 110




        '#End Region


#Region "Conteo de cantidad de equipos"

        labe1.Visible = True
        labe1.Text = "Cantidad: " & datagr.RowCount
        conteo = datagr.RowCount
#End Region



    End Sub

    Sub shutdown()



#Region "Configuracion datagridview1"
        conectar()

        Dim conteo As String
        conteo = 1

#Region "Formato de letra"

        datagr.DefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)
        datagr.ColumnHeadersDefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)

#End Region
        '        datagr.RowTemplate.Height = 30
        '#Region "Color de los titulos"
        '        datagr.ColumnHeadersDefaultCellStyle.BackColor = Color.SlateGray
        '        datagr.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        '#End Region
        '#Region "Cambios de color celdas y alternadas"
        '        datagr.RowsDefaultCellStyle.BackColor = Color.LightGray
        '        datagr.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray

        '#End Region
#Region "Alineacion de titulos"
        datagr.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
#End Region
#End Region

#Region "Buscar la planificacion"




        Dim adaptador As New SqlDataAdapter("Select*from Shutdowns", cn)
        Dim dataS As New DataSet
        adaptador.Fill(dataS, "ConteoPlanificacion_Equipos")

        datagr.DataSource = dataS.Tables("ConteoPlanificacion_Equipos")
        Dim columncheck As New DataGridViewCheckBoxColumn
        columncheck.HeaderText = "Realizado"
        columncheck.Name = "cerrar"
        datagr.Columns.Add(columncheck)
#End Region


        '#Region "Configuracion tabla"
        datagr.Columns(0).Visible = False
        datagr.Columns(3).Visible = False
        datagr.Columns(4).Visible = False
        datagr.RowHeadersVisible = False


        datagr.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        datagr.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        datagr.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        datagr.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '        datagr.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '        datagr.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '        datagr.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '        datagr.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '        datagr.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '        datagr.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '        datagr.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '        datagr.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '        datagr.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '        datagr.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter



        '        datagr.Columns(1).Width = 225


        '        datagr.Columns(2).Width = 110
        '        datagr.Columns(3).Width = 110
        '        datagr.Columns(4).Width = 110
        '        datagr.Columns(5).Width = 110
        '        datagr.Columns(6).Width = 110
        '        datagr.Columns(7).Width = 110
        '        datagr.Columns(8).Width = 110
        '        datagr.Columns(9).Width = 110
        '        datagr.Columns(10).Width = 110
        '        datagr.Columns(11).Width = 110
        '        datagr.Columns(12).Width = 110
        '        datagr.Columns(13).Width = 110




        '#End Region


#Region "Conteo de cantidad de equipos"

        labe1.Visible = True
        labe1.Text = "Cantidad: " & datagr.RowCount
        conteo = datagr.RowCount
#End Region



    End Sub
End Module

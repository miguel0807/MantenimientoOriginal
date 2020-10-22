Imports System.Data.SqlClient
Imports System.Windows.Forms
Module ConfigPreventivo
#Region "Lista Equipos"
    Sub busqueda_equipos()





        Dim formulario As String = "Lista_Equipos"






#Region "Configuracion datagridview1"
        conectar()

        Dim conteo As String
        conteo = 1

#Region "Formato de letra"

        formulario.DataGridView1.DefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)
        formulario.DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)

#End Region
        formulario.DataGridView1.RowTemplate.Height = 25
#Region "Color de los titulos"
        formulario.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.SlateGray
        formulario.DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
#End Region
#Region "Cambios de color celdas y alternadas"
        formulario.DataGridView1.RowsDefaultCellStyle.BackColor = Color.LightGray
        formulario.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray

#End Region
#Region "Alineacion de titulos"
        formulario.DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
#End Region
#Region "Buscar todos los equipos"

        Dim tabla As DataGridView = formulario.DataGridView1
        Dim adaptador As New SqlDataAdapter("select*from Lista_Equipos", cn)
        Dim dataS As New DataSet
        adaptador.Fill(dataS, "Lista_Equipos")

        tabla.DataSource = dataS.Tables("Lista_Equipos")

#End Region


#Region "Configuracion tabla"



        tabla.RowHeadersVisible = False
        tabla.Columns.Item(0).Visible = False



        tabla.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        tabla.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


        tabla.Columns(1).Width = 380
        tabla.Columns(2).Width = 240
        tabla.Columns(3).Width = 170



#End Region
#End Region



#Region "Conteo de equipos"

        formulario.Label1.Visible = True
        formulario.Label1.Text = "Codigo: " & tabla.RowCount
        formulario.conteo = tabla.RowCount
#End Region
    End Sub

#End Region
End Module

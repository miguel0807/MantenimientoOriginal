Imports System.Data.SqlClient
Public Class HistShutdownStartup
    Dim presionar As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        historial = "Hist_Startup"
#Region "Configuracion datagridview1"
        conectar()
        Dim formulario As DataGridView = Me.DataGridView1
        Dim conteo As String
        conteo = 1

        '#Region "Formato de letra"

        '        formulario.DefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)
        '        formulario.ColumnHeadersDefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)

        '#End Region
        formulario.RowTemplate.Height = 25
#Region "Color de los titulos"
        formulario.ColumnHeadersDefaultCellStyle.BackColor = Color.SlateGray
        formulario.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
#End Region
        '#Region "Cambios de color celdas y alternadas"
        '        formulario.RowsDefaultCellStyle.BackColor = Color.LightGray
        '        formulario.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray

        '#End Region
#Region "Alineacion de titulos"
        formulario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
#End Region
#Region "Buscar todos los equipos"

        Dim tabla As DataGridView = Me.DataGridView1
        Dim adaptador As New SqlDataAdapter("select distinct (Fecha)from Hist_Startup;", cn)
        Dim dataS As New DataSet
        adaptador.Fill(dataS, "Hist_Startup")

        tabla.DataSource = dataS.Tables("Hist_Startup")

#End Region


#Region "Configuracion tabla"



        tabla.RowHeadersVisible = False
        'tabla.AutoResizeColumn(DataGridViewAutoSizeColumnMode.Fill)



        'tabla.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'tabla.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        'tabla.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


        ' tabla.Columns(0).Width = 200%
        'tabla.Columns(2).Width = 240
        'tabla.Columns(3).Width = 170



#End Region
#End Region
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
#Region "Configuracion datagridview1"
        conectar()
        Dim formulario As DataGridView = Me.DataGridView1
        Dim conteo As String
        conteo = 1

        '#Region "Formato de letra"

        '        formulario.DefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)
        '        formulario.ColumnHeadersDefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)

        '#End Region
        formulario.RowTemplate.Height = 25
#Region "Color de los titulos"
        formulario.ColumnHeadersDefaultCellStyle.BackColor = Color.SlateGray
        formulario.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
#End Region
        '#Region "Cambios de color celdas y alternadas"
        '        formulario.RowsDefaultCellStyle.BackColor = Color.LightGray
        '        formulario.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray

        '#End Region
#Region "Alineacion de titulos"
        formulario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
#End Region
#Region "Buscar todos los equipos"

        Dim tabla As DataGridView = Me.DataGridView2
        Dim adaptador As New SqlDataAdapter("select hist.Conteo,list.Tarea,list.Equipo,hist.Estado,hist.Fecha,hist.Responsable  from " & historial & " hist,List_Startup_Shutdown list where hist.Codigo=list.Codigo and fecha='" & presionar & "' ", cn)
        Dim dataS As New DataSet
        adaptador.Fill(dataS, "Hist_Startup")

        tabla.DataSource = dataS.Tables("Hist_Startup")

#End Region


#Region "Configuracion tabla"



        tabla.RowHeadersVisible = False

        tabla.Columns(0).Visible = False
        tabla.Columns(3).Visible = False


        tabla.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        tabla.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


        tabla.Columns(1).Width = 380
        tabla.Columns(2).Width = 240
        tabla.Columns(3).Width = 170



#End Region
#End Region
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        presionar = Me.DataGridView1.CurrentCell.Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox(DataGridView1.CurrentCell.Value)
    End Sub



    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        presionar = MonthCalendar1.SelectionRange.Start.ToString
    End Sub
End Class
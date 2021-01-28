Imports System.Data.SqlClient
Module MO_Tareas

    Public txtTarea As TextBox
    Public txtMateriales As TextBox
    Public intTiempo As TextBox



    Public SQLCodTarea As Integer
    Public SQLCodigo As Integer
    Public SQLEtiqueta As String
    Public SQLAño As Integer
    Public SQLMes As String



    Sub CrearTarea()


#Region "Calcular numero de registros en list_Startup"
        Dim codig As Integer = 0

        conectar()
        Dim count As Integer

        Dim Query As String
        Query = ("select*from Conteo_Tareas ")
        Dim cmd As New SqlCommand(Query, cn)
        count = cmd.ExecuteScalar
        codig = count + 1
        desconectar()

#End Region
#Region "Actualizar el conteo de registros de las tareas"
        conectar()
        Dim actualizarnombre As New SqlCommand("Update Conteo_Tareas SET ConteoCodigoTarea =(" & codig & ")", cn)
        'TextBox1.Text = actualizarnombre.CommandText
        actualizarnombre.ExecuteNonQuery()
        cn.Close()
#End Region





#Region "Insertar en la lista de equipos la informacion del nuevo equipo"
        Dim adaptador1 As New SqlCommand("insert into Caracteristicas_Tareas values(" & codig & ",'" & txtTarea.Text & "','" & txtMateriales.Text & "'," & intTiempo.Text & ")", cn)
        conectar()
        'MsgBox(adaptador1.CommandText)

        adaptador1.ExecuteNonQuery()
        desconectar()
        MsgBox("Tarea agregada correctamente")


#End Region
    End Sub

    Sub RevisarTareas()



#Region "Configuracion datagridview1"
        conectar()

        Dim conteo As String
        conteo = 1

#Region "Formato de letra"

        datagr.DefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)
        datagr.ColumnHeadersDefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)

#End Region
        datagr.RowTemplate.Height = 30
#Region "Color de los titulos"
        datagr.ColumnHeadersDefaultCellStyle.BackColor = Color.Green
        datagr.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
#End Region
#Region "Cambios de color celdas y alternadas"
        datagr.RowsDefaultCellStyle.BackColor = Color.White
        datagr.AlternatingRowsDefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control)

#End Region
#Region "Alineacion de titulos"
        datagr.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
#End Region
#End Region

#Region "Buscar la planificacion"




        Dim adaptador As New SqlDataAdapter("select*from Caracteristicas_Tareas ", cn)
        Dim dataS As New DataSet
        adaptador.Fill(dataS, "Shutdowns")

        datagr.DataSource = dataS.Tables("Shutdowns")

#End Region

#Region "prueba check"


#End Region


        datagr.RowHeadersVisible = False


        datagr.EnableHeadersVisualStyles = False
        datagr.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51)
        datagr.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        datagr.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(218, 218, 218)
        datagr.RowsDefaultCellStyle.SelectionForeColor = Color.Black




        datagr.RowHeadersVisible = False
        datagr.Columns(0).Visible = False
        datagr.Columns(3).Visible = False




        datagr.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        datagr.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter




        '  datagr.Columns(1).Width = 500

        '  datagr.Columns(2).Width = 500

#Region "Conteo de cantidad de equipos"

        labe1.Visible = True
        labe1.Text = "Cantidad: " & datagr.RowCount
        conteo = datagr.RowCount
#End Region
        'Desactiva el autofiltro
        Dim col As Integer

        For col = 0 To datagr.Columns.Count - 1

            datagr.Columns(col).SortMode = DataGridViewColumnSortMode.NotSortable

        Next
        'Desactiva el autofiltro

    End Sub
    Sub CargarPendientesTareas()



#Region "Configuracion datagridview1"
        conectar()

        Dim conteo As String
        conteo = 1

#Region "Formato de letra"

        datagr.DefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)
        datagr.ColumnHeadersDefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)

#End Region
        datagr.RowTemplate.Height = 30
#Region "Color de los titulos"
        datagr.ColumnHeadersDefaultCellStyle.BackColor = Color.Green
        datagr.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
#End Region
#Region "Cambios de color celdas y alternadas"
        datagr.RowsDefaultCellStyle.BackColor = Color.White
        datagr.AlternatingRowsDefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control)

#End Region
#Region "Alineacion de titulos"
        datagr.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
#End Region
#End Region

#Region "Buscar la planificacion"




        Dim adaptador As New SqlDataAdapter("Select carac.Tarea from Historial_Tareas hist, Caracteristicas_Tareas carac where carac.CodTarea=hist.CodTarea and hist.Codigo=" & SQLCodigo & " and CONVERT(CHAR,hist.Etiqueta)='" & SQLEtiqueta & "' and hist.Año=" & SQLAño & " and convert(CHAR,hist.MES)='" & SQLMes & "' ", cn)
        Dim dataS As New DataSet
        adaptador.Fill(dataS, "Shutdowns")

        datagr.DataSource = dataS.Tables("Shutdowns")

#End Region

#Region "prueba check"


#End Region


        datagr.RowHeadersVisible = False


        datagr.EnableHeadersVisualStyles = False
        datagr.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51)
        datagr.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        datagr.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(218, 218, 218)
        datagr.RowsDefaultCellStyle.SelectionForeColor = Color.Black




        datagr.RowHeadersVisible = False
        'datagr.Columns(0).Visible = False
        'datagr.Columns(3).Visible = False




        ' datagr.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'datagr.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter




        '  datagr.Columns(1).Width = 500

        '  datagr.Columns(2).Width = 500

#Region "Conteo de cantidad de equipos"

        labe1.Visible = True
        labe1.Text = "Cantidad: " & datagr.RowCount
        conteo = datagr.RowCount
#End Region
        'Desactiva el autofiltro
        Dim col As Integer

        For col = 0 To datagr.Columns.Count - 1

            datagr.Columns(col).SortMode = DataGridViewColumnSortMode.NotSortable

        Next
        'Desactiva el autofiltro

    End Sub
    Sub eliminacionTarea()

        Dim msgvalue As Integer

        msgvalue = MsgBox("Está seguro de eliminar la tarea?", vbInformation + vbYesNo, "Mensaje de Alerta")

        Select Case msgvalue

            Case 6 'Yes


                conectar()

                Dim comando As New SqlCommand("delete from Caracteristicas_Tareas where CodTarea =" & datagr.CurrentRow.Cells.Item(0).Value.ToString() & " ", cn)
                comando.ExecuteNonQuery()
                desconectar()
                MsgBox("Se elimino correctamente")




            Case 7 'No



        End Select


    End Sub
End Module

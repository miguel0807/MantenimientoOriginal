Imports System.Data.SqlClient
Module MO_Tareas

    Public txtTarea As TextBox
    Public txtMateriales As ComboBox
    Public intTiempo As TextBox
    Public cbo1Clase As ComboBox

    Public clasecodigo As Integer

    Public SQLCodTarea As Integer
    Public SQLCodigo As Integer
    Public SQLEtiqueta As String
    Public SQLAño As Integer
    Public SQLMes As String
    Public SQLSumar As Integer

    Public CboClase As ComboBox
    Public CboAño As ComboBox
    Public CboEtiqueta As ComboBox
    Public CboMes As ComboBox
    Public SQLComentario As TextBox
    Public SQLResponsable As ComboBox
    Public prueba0 As TextBox

    Public btnFinalizado As Button
    Public btnContinuar As Button

    Public calendario As MonthCalendar





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




        Dim adaptador As New SqlDataAdapter("select*from Caracteristicas_Tareas where convert(char,Equipo)='" & CboClase.Text & "' ", cn)
        Dim dataS As New DataSet
        adaptador.Fill(dataS, "Shutdowns")

        datagr.DataSource = dataS.Tables("Shutdowns")

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




        Dim adaptador As New SqlDataAdapter("Select carac.Tarea , hist.ConteoSuma, hist.Estado from Historial_Tareas hist, Caracteristicas_Tareas carac where carac.CodTarea=hist.CodTarea and hist.Codigo=" & SQLCodigo & " and CONVERT(CHAR,hist.Etiqueta)='" & SQLEtiqueta & "' and hist.Año=" & SQLAño & " and convert(CHAR,hist.MES)='" & SQLMes & "'and Estado=0 ", cn)
        Dim dataS As New DataSet
        ' MsgBox(adaptador.SelectCommand.CommandText)
        adaptador.Fill(dataS, "Shutdowns")

        datagr.DataSource = dataS.Tables("Shutdowns")

#End Region
        If dataS.Tables("Shutdowns").Rows.Count > 0 Then
            btnFinalizado.Visible = False

            btnContinuar.Visible = False

        Else

        End If



        datagr.RowHeadersVisible = False


        datagr.EnableHeadersVisualStyles = False
        datagr.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51)
        datagr.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        datagr.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(218, 218, 218)
        datagr.RowsDefaultCellStyle.SelectionForeColor = Color.Black




        datagr.RowHeadersVisible = False
        datagr.Columns(1).Visible = False
        'datagr.Columns(3).Visible = False




        datagr.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'datagr.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter




        '  datagr.Columns(1).Width = 500

        datagr.Columns(2).Width = 100

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
    Sub CargarPendientesTareasPlanificacion()



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




        Dim adaptador As New SqlDataAdapter("Select carac.Tarea , hist.ConteoSuma, hist.Estado from Historial_Tareas hist, Caracteristicas_Tareas carac where carac.CodTarea=hist.CodTarea and hist.Codigo=" & SQLCodigo & " and CONVERT(CHAR,hist.Etiqueta)='" & SQLEtiqueta & "' and hist.Año=" & SQLAño & " and convert(CHAR,hist.MES)='" & SQLMes & "'and Estado=0 ", cn)
        Dim dataS As New DataSet
        ' MsgBox(adaptador.SelectCommand.CommandText)
        adaptador.Fill(dataS, "Shutdowns")

        datagr.DataSource = dataS.Tables("Shutdowns")

#End Region
        If dataS.Tables("Shutdowns").Rows.Count > 0 Then


        Else

        End If



        datagr.RowHeadersVisible = False


        datagr.EnableHeadersVisualStyles = False
        datagr.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51)
        datagr.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        datagr.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(218, 218, 218)
        datagr.RowsDefaultCellStyle.SelectionForeColor = Color.Black




        datagr.RowHeadersVisible = False
        datagr.Columns(1).Visible = False
        'datagr.Columns(3).Visible = False




        datagr.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'datagr.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter




        '  datagr.Columns(1).Width = 500

        datagr.Columns(2).Width = 100

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
    Sub CargarPendientesTareasPlanificacionRealizadas()



#Region "Configuracion datagridview3"
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




        Dim adaptador As New SqlDataAdapter("Select carac.Tarea , hist.ConteoSuma, hist.Estado from Historial_Tareas hist, Caracteristicas_Tareas carac where carac.CodTarea=hist.CodTarea and hist.Codigo=" & SQLCodigo & " and CONVERT(CHAR,hist.Etiqueta)='" & SQLEtiqueta & "' and hist.Año=" & SQLAño & " and convert(CHAR,hist.MES)='" & SQLMes & "'and Estado=1 ", cn)
        Dim dataS As New DataSet
        ' MsgBox(adaptador.SelectCommand.CommandText)
        adaptador.Fill(dataS, "Shutdowns")

        datagr.DataSource = dataS.Tables("Shutdowns")

#End Region
        If dataS.Tables("Shutdowns").Rows.Count > 0 Then


        Else

        End If



        datagr.RowHeadersVisible = False


        datagr.EnableHeadersVisualStyles = False
        datagr.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51)
        datagr.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        datagr.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(218, 218, 218)
        datagr.RowsDefaultCellStyle.SelectionForeColor = Color.Black




        datagr.RowHeadersVisible = False
        datagr.Columns(1).Visible = False
        'datagr.Columns(3).Visible = False




        datagr.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'datagr.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter




        '  datagr.Columns(1).Width = 500

        ' datagr.Columns(2).Width = 100

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
        ' desconectar()
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

    Sub BorrarTarea()

        Dim msgvalue As Integer

        msgvalue = MsgBox("Está seguro de eliminar la tarea?", vbInformation + vbYesNo, "Mensaje de Alerta")

        Select Case msgvalue

            Case 6 'Yes


                conectar()

                Dim comando As New SqlCommand("delete from Historial_Tareas where ConteoSuma =" & SQLSumar & " ", cn)
                comando.ExecuteNonQuery()
                desconectar()
                MsgBox("Se elimino correctamente")




            Case 7 'No



        End Select


    End Sub

    Sub TareaClase()

#Region "Cargar en comboBox las clases"

        Try
            Dim cmd As String = "select*from Caracteristicas_Equipo"
            Dim da As New SqlDataAdapter(cmd, cn)
            Dim ds As New DataSet
            da.Fill(ds)
            With CboClase
                CboClase.DataSource = ds.Tables(0)
                CboClase.DisplayMember = "Clase"
            End With

            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
#End Region
    End Sub

    Sub TareaAño()
#Region "Cargar comboBox con los años"
        Try
            Dim cmd As String = "select*from Año_Datos"
            Dim da As New SqlDataAdapter(cmd, cn)
            Dim ds As New DataSet
            da.Fill(ds)
            With CboAño
                CboAño.DataSource = ds.Tables(0)
                CboAño.DisplayMember = "Año"
            End With

            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
#End Region

    End Sub

    Sub TareaMes()

#Region "Cargar MES"
        Try
            Dim cmd As String = "select*from Meses_Datos"
            Dim da As New SqlDataAdapter(cmd, cn)
            Dim ds As New DataSet
            da.Fill(ds)
            With CboMes
                CboMes.DataSource = ds.Tables(0)
                CboMes.DisplayMember = "Meses"
            End With

            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
#End Region
    End Sub

    Sub TareaEtiqueta()
#Region "Verificar etiquetas"
        'En el parentesis entre & & se coloca cual valor se usara para la busqueda
        Dim adaptador As New SqlDataAdapter("select*from Caracteristicas_Equipo where CONVERT(char,Clase)='" & CboClase.Text & "'", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "Codigo")

        'El item selecciona de cual columna de la base de datos se conectara y row es la fila
        If ds.Tables("Codigo").Rows.Count > 0 Then

            clasecodigo = ds.Tables("Codigo").Rows(0).Item(0).ToString
            SQLCodigo = clasecodigo

        End If
#End Region

#Region "Cargar datos en combobox de Etiqueta"

        Dim cmd1 As String = "select*from Lista_Equipos where Codigo=" & clasecodigo & ""
        Dim da1 As New SqlDataAdapter(cmd1, cn)
        Dim ds1 As New DataSet
        da1.Fill(ds1)
        With CboEtiqueta
            CboEtiqueta.DataSource = ds1.Tables(0)
            CboEtiqueta.DisplayMember = "Etiqueta"
        End With
        cn.Close()

#End Region
        CboEtiqueta.Visible = True


    End Sub

    Sub TareaRegistrada()

        Dim msgvalue As Integer



        msgvalue = MsgBox("Está seguro de confirmar la tarea?", vbInformation + vbYesNo, "Mensaje de Alerta")

        Select Case msgvalue

            Case 6 'Yes
                conectar()
                Dim actualizarcantidadconteo As New SqlCommand("update Historial_Tareas set Estado=1 , Comentario='" & SQLComentario.Text & "' , Responsable='" & SQLResponsable.Text & "' , Fecha='" & calendario.SelectionStart.ToShortDateString.ToString & "' where ConteoSuma=" & SQLSumar & "  ", cn)
                ' prueba0.Text = actualizarcantidadconteo.CommandText
                actualizarcantidadconteo.ExecuteNonQuery()
                cn.Close()
                desconectar()
                MsgBox("Se registro correctamente")

                CargarPendientesTareas()




            Case 7 'No



        End Select

    End Sub

    Sub verficarEstado()

#Region "Buscar la planificacion"




        Dim adaptador As New SqlDataAdapter("Select carac.Tarea , hist.ConteoSuma, hist.Estado from Historial_Tareas hist, Caracteristicas_Tareas carac where carac.CodTarea=hist.CodTarea and hist.Codigo=" & SQLCodigo & " and CONVERT(CHAR,hist.Etiqueta)='" & SQLEtiqueta & "' and hist.Año=" & SQLAño & " and convert(CHAR,hist.MES)='" & SQLMes & "' and Estado=0 ", cn)
        Dim dataS As New DataSet
        ' MsgBox(adaptador.SelectCommand.CommandText)
        adaptador.Fill(dataS, "Shutdowns")

        ' datagr.DataSource = dataS.Tables("Shutdowns")

#End Region

#Region "prueba check"

        'El item selecciona de cual columna de la base de datos se conectara y row es la fila
        If dataS.Tables("Shutdowns").Rows.Count > 0 Then


        Else
            btnFinalizado.Visible = True

            btnContinuar.Visible = True
        End If
#End Region
    End Sub
    Sub CargaClase()


#Region "Cargar datos en combobox de Clase"
        Try
            Dim cmd As String = "select*from Caracteristicas_Equipo"
            Dim da As New SqlDataAdapter(cmd, cn)
            Dim ds As New DataSet
            da.Fill(ds)
            With cbo1Clase
                cbo1Clase.DataSource = ds.Tables(0)
                cbo1Clase.DisplayMember = "Clase"
            End With
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
#End Region
    End Sub


End Module

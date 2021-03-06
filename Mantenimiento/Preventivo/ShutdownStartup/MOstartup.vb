Imports System.Data.SqlClient


Public Module MOstartup
    Public datagr As DataGridView
    Public datagr2 As DataGridView
    Public labe1 As Label
    Public columncheck As New DataGridViewColumn
    Public usuario As ComboBox
    Public ntarea As String
    Public nequipo As String
    Public st_sh As Integer
    Public startupCheck As Integer
    Public nombre As ComboBox
    Public bCargar As Button
    Public label5 As Label
    Public label6 As Label
    Public combo1 As ComboBox
    Public historial As String ' Selecciona el historial donde guardar la informacion
    Public hisInteger As Integer ' Habilita la creacion de tarean en shutdown o startup
    Public presionar As String
    Dim hoy As Date
    Dim day1 As String


    Dim mont1 As String

    Public labelFecha As Label




    Sub CheckColumna()
        'Crea una nueva columna tipo checkbox
        datagr.Columns.Clear()
        Dim Obj As New DataGridViewColumn
        Dim Col As New DataGridViewCheckBoxColumn
        Obj = Col
        Obj.HeaderText = "Realizado" ' el texto que ira en la cabecera
        Obj.Name = "Realizado" ' Nombre de la Columna del checkbox
        Obj.Width = 50
        datagr.Columns.Add(Obj)

        datagr.Columns(datagr.Columns.Count - 1).DisplayIndex = 0 ' Es para que la columna sea la primera en la grilla

        ' Luego esta propiedad para la grilla

        datagr.ReadOnly = False ' Esto para que toda la grilla sea editable
        datagr.DataSource = Nothing ' al inicio no va ningun enlaze de datos
        'Crea una nueva columna tipo checkbox
    End Sub

    Sub startupDatagridview()



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
        ' datagr.ColumnHeadersDefaultCellStyle.BackColor = Color.Green
        '   datagr.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
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




        Dim adaptador As New SqlDataAdapter("select hist.Conteo,list.Tarea,list.Equipo,hist.Estado,hist.Fecha,hist.Responsable,hist.Comentarios  from " & historial & " hist,List_Startup_Shutdown list where hist.Codigo=list.Codigo and fecha='" & hoy & "' ", cn)
        Dim dataS As New DataSet
        adaptador.Fill(dataS, "" & historial & "")

        datagr.DataSource = dataS.Tables("" & historial & "")





#End Region

#Region "Personalizacion header"
        datagr.EnableHeadersVisualStyles = False
        datagr.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51)
        datagr.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        datagr.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(218, 218, 218)
        datagr.RowsDefaultCellStyle.SelectionForeColor = Color.Black
#End Region
        datagr.RowHeadersVisible = False
        datagr.Columns(1).Visible = False
        datagr.Columns(4).Visible = False
        datagr.Columns(5).Visible = False

        datagr.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'datagr.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Tarea
        datagr.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        datagr.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Responsable
        datagr.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Comentarios





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

    Sub CheckSoloEditable()
        'Desabilita todo el datagridview contra escritura excepto con el checkbox
        For cole As Integer = 0 To datagr.Columns.Count - 1
            If Not cole = 7 Then
                'datagr.Columns(cole).ReadOnly = True 'Desactivado temporalmente para pruebas
            End If
        Next
        'Desabilita todo el datagridview contra escritura excepto con el checkbox
    End Sub


    Sub marcarCheck()
        'Selecciona el checkbox dependiente de la columna estado
#Region "Marcar checkbox con informacion de SQL"
        For Each Row As DataGridViewRow In datagr.Rows

            If Row.Cells(4).Value = 1 Then  ' suponiendo que sea la ultima columna
                Row.Cells(0).Value = True ' suponiendo que sea la columna del check
            Else
                Row.Cells(0).Value = False
            End If
        Next
#End Region
    End Sub

    Sub marcarEstado()

        'Cambia el valor de estado en datagridview
        If datagr.CurrentCell.Value = True Then

            datagr.CurrentRow.Cells.Item(4).Value = 1
        Else
            datagr.CurrentRow.Cells.Item(4).Value = 0
        End If
        'Cambia el valor de estado en datagridview

    End Sub

    Sub cheackActualizarSql()

        Dim celda As String = datagr.CurrentRow.Cells.Item(1).Value
        Dim estado As String = datagr.CurrentRow.Cells.Item(4).Value
        Dim actualizarRealizado As New SqlCommand("update " & historial & " set Estado=" & estado & " where Conteo=" & celda & " ", cn)
        'TextBox1.Text = actualizarnombre.CommandText
        conectar()
        actualizarRealizado.ExecuteNonQuery()
        desconectar()

    End Sub
    Sub cheackActualizarSQLComentarios()

        If datagr.CurrentCell.Selected Then
            Dim celda As String = datagr.CurrentRow.Cells.Item(1).Value

            Dim comen As String = datagr.CurrentRow.Cells.Item(7).Value.ToString
            Dim actualizarRealizado As New SqlCommand("update " & historial & " set Comentarios='" & comen & "' where Conteo=" & celda & " ", cn)
                'TextBox1.Text = actualizarnombre.CommandText
                conectar()
                actualizarRealizado.ExecuteNonQuery()
                desconectar()
            End If


    End Sub
    Sub cheackActualizarSQLusuario()

        If datagr.CurrentCell.Selected Then
            Dim celda As String = datagr.CurrentRow.Cells.Item(1).Value

            Dim usua As String = datagr.CurrentRow.Cells.Item(6).Value.ToString
            Dim actualizarRealizado As New SqlCommand("update " & historial & " set Responsable='" & usua & "' where Conteo=" & celda & " ", cn)
            'TextBox1.Text = actualizarnombre.CommandText
            conectar()
            actualizarRealizado.ExecuteNonQuery()
            desconectar()
        End If


    End Sub

    Sub usuarios()

#Region "Cargar datos en combobox de Responsable"
        Try

            Dim cmd3 As String = "select*from Usuarios"
            Dim da3 As New SqlDataAdapter(cmd3, cn)
            Dim ds3 As New DataSet

            da3.Fill(ds3)
            With usuario
                usuario.DataSource = ds3.Tables(0)
                usuario.DisplayMember = "Nombre"
            End With
            cn.Close()
            usuario.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
#End Region

    End Sub

    Sub nuevaTarea()
        Dim codig As Integer = 0




#Region "Calcular numero de registros en list_Startup"

        conectar()
        Dim count As Integer

        Dim Query As String
        Query = ("select*from NuevaTareaConteo ")
        Dim cmd As New SqlCommand(Query, cn)
        count = cmd.ExecuteScalar
        codig = count + 1
        desconectar()

#End Region

        conectar()
        Dim actualizarnombre As New SqlCommand("Update NuevaTareaConteo SET ConteoCodigo =(" & codig & ")", cn)
        'TextBox1.Text = actualizarnombre.CommandText
        actualizarnombre.ExecuteNonQuery()
        cn.Close()







#Region "Insertar en la lista de equipos la informacion del nuevo equipo"
        Dim adaptador1 As New SqlCommand("insert into List_Startup_Shutdown values (" & codig & " , '" & ntarea & "','" & nequipo & "' , " & st_sh & ")", cn)
        conectar()
        adaptador1.ExecuteNonQuery()
        desconectar()
        MsgBox("Tarea agregada correctamente")


#End Region



    End Sub

    Sub nuevaTareaDatagridview()



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




        Dim adaptador As New SqlDataAdapter("select*from List_Startup_Shutdown where [St-SH] = " & startupCheck & " ", cn)
        Dim dataS As New DataSet
        adaptador.Fill(dataS, "Shutdowns")

        datagr.DataSource = dataS.Tables("Shutdowns")



#Region "prueba check"
#End Region

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




        datagr.Columns(1).Width = 500

        datagr.Columns(2).Width = 500

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

    Sub tareaElimar()




        Dim msgvalue As Integer

        msgvalue = MsgBox("Está seguro de eliminar la tarea?", vbInformation + vbYesNo, "Mensaje de Alerta")

        Select Case msgvalue

            Case 6 'Yes


                conectar()

                Dim comando As New SqlCommand("delete from List_Startup_Shutdown where Codigo =" & datagr.CurrentRow.Cells.Item(0).Value.ToString() & " ", cn)
                comando.ExecuteNonQuery()
                desconectar()
                MsgBox("Se elimino correctamente")




            Case 7 'No



        End Select




    End Sub


    Sub LoadFechaEscrita()
        hoy = Date.Today
        labelFecha.Text = hoy


        day1 = hoy.DayOfWeek.ToString
        Select Case day1
            Case "Sunday"
                day1 = "Domingo"
            Case "Monday"
                day1 = "Lunes"
            Case "Tuesday"
                day1 = "Martes"
            Case "Wednesday"
                day1 = "Miercoles"
            Case "Thursday"
                day1 = "Jueves"
            Case "Friday"
                day1 = "Viernes"
            Case "Saturday"
                day1 = "Sabado"

        End Select

        mont1 = hoy.Month.ToString

        Select Case mont1
            Case 1
                mont1 = "Enero"
            Case 2
                mont1 = "Febrero"

            Case 3
                mont1 = "Marzo"

            Case 4
                mont1 = "Abril"

            Case 5
                mont1 = "Mayo"

            Case 6
                mont1 = "Junio"

            Case 7
                mont1 = "Julio"

            Case 8
                mont1 = "Agosto"

            Case 9
                mont1 = "Septiembre"

            Case 10
                mont1 = "Octubre"

            Case 11
                mont1 = "Noviembre"

            Case 12
                mont1 = "Diciembre"


        End Select


        labelFecha.Text = day1 & " " & hoy.Day.ToString & " de " & mont1
    End Sub

    Sub DerechaFecha()
        hoy = hoy.AddDays(1)
        labelFecha.Text = hoy


        day1 = hoy.DayOfWeek.ToString
        Select Case day1
            Case "Sunday"
                day1 = "Domingo"
            Case "Monday"
                day1 = "Lunes"
            Case "Tuesday"
                day1 = "Martes"
            Case "Wednesday"
                day1 = "Miercoles"
            Case "Thursday"
                day1 = "Jueves"
            Case "Friday"
                day1 = "Viernes"
            Case "Saturday"
                day1 = "Sabado"

        End Select
        mont1 = hoy.Month.ToString

        Select Case mont1
            Case 1
                mont1 = "Enero"
            Case 2
                mont1 = "Febrero"

            Case 3
                mont1 = "Marzo"

            Case 4
                mont1 = "Abril"

            Case 5
                mont1 = "Mayo"

            Case 6
                mont1 = "Junio"

            Case 7
                mont1 = "Julio"

            Case 8
                mont1 = "Agosto"

            Case 9
                mont1 = "Septiembre"

            Case 10
                mont1 = "Octubre"

            Case 11
                mont1 = "Noviembre"

            Case 12
                mont1 = "Diciembre"


        End Select


        labelFecha.Text = day1 & " " & hoy.Day.ToString & " de " & mont1

    End Sub
    Sub IzquierdaFecha()
        hoy = hoy.AddDays(-1)
        labelFecha.Text = hoy


        day1 = hoy.DayOfWeek.ToString
        Select Case day1
            Case "Sunday"
                day1 = "Domingo"
            Case "Monday"
                day1 = "Lunes"
            Case "Tuesday"
                day1 = "Martes"
            Case "Wednesday"
                day1 = "Miercoles"
            Case "Thursday"
                day1 = "Jueves"
            Case "Friday"
                day1 = "Viernes"
            Case "Saturday"
                day1 = "Sabado"

        End Select

        mont1 = hoy.Month.ToString

        Select Case mont1
            Case 1
                mont1 = "Enero"
            Case 2
                mont1 = "Febrero"

            Case 3
                mont1 = "Marzo"

            Case 4
                mont1 = "Abril"

            Case 5
                mont1 = "Mayo"

            Case 6
                mont1 = "Junio"

            Case 7
                mont1 = "Julio"

            Case 8
                mont1 = "Agosto"

            Case 9
                mont1 = "Septiembre"

            Case 10
                mont1 = "Octubre"

            Case 11
                mont1 = "Noviembre"

            Case 12
                mont1 = "Diciembre"


        End Select


        labelFecha.Text = day1 & " " & hoy.Day.ToString & " de " & mont1
    End Sub

    Sub hoyFecha()
        hoy = Date.Today
        labelFecha.Text = hoy


        day1 = hoy.DayOfWeek.ToString
        Select Case day1
            Case "Sunday"
                day1 = "Domingo"
            Case "Monday"
                day1 = "Lunes"
            Case "Tuesday"
                day1 = "Martes"
            Case "Wednesday"
                day1 = "Miercoles"
            Case "Thursday"
                day1 = "Jueves"
            Case "Friday"
                day1 = "Viernes"
            Case "Saturday"
                day1 = "Sabado"

        End Select
        mont1 = hoy.Month.ToString

        Select Case mont1
            Case 1
                mont1 = "Enero"
            Case 2
                mont1 = "Febrero"

            Case 3
                mont1 = "Marzo"

            Case 4
                mont1 = "Abril"

            Case 5
                mont1 = "Mayo"

            Case 6
                mont1 = "Junio"

            Case 7
                mont1 = "Julio"

            Case 8
                mont1 = "Agosto"

            Case 9
                mont1 = "Septiembre"

            Case 10
                mont1 = "Octubre"

            Case 11
                mont1 = "Noviembre"

            Case 12
                mont1 = "Diciembre"


        End Select


        labelFecha.Text = day1 & " " & hoy.Day.ToString & " de " & mont1
    End Sub


    Sub crearHistorial()
#Region "Verifica si hay algo creado"

        'Almacena en variable contar la cantidad de registros en el historial
        conectar()
        Dim contar7 As Integer

        Dim consulta7 As String
        consulta7 = ("select count (" & historial & ".Fecha)from " & historial & " where Fecha='" & hoy & "'  ")
        Dim cmd7 As New SqlCommand(consulta7, cn)
        contar7 = cmd7.ExecuteScalar

        desconectar()

        If contar7 > 0 Then
            Exit Sub
        End If
#End Region
#Region "Contar tareas de startup"
        'Almacena en variable count la cantidad de tareas que hay vigentes
        conectar()
        Dim count As Integer

        Dim Query As String
        Query = ("select count (List_Startup_Shutdown.Codigo)  from List_Startup_Shutdown where List_Startup_Shutdown.[St-SH]=1  ")
        Dim cmd As New SqlCommand(Query, cn)
        count = cmd.ExecuteScalar

        desconectar()

#End Region

#Region "Contar registros de historial"
        'Almacena en variable contar la cantidad de registros en el historial
        conectar()
        Dim contar As Integer

        Dim consulta As String
        consulta = ("select count (" & historial & ".Conteo)  from " & historial & " ")
        Dim cmd1 As New SqlCommand(consulta, cn)
        contar = cmd1.ExecuteScalar

        desconectar()

#End Region


#Region "Crea tabla para almacenar tareas"
        Try

            Dim cmd3 As String = "select codigo from List_Startup_Shutdown where [St-SH]=" & hisInteger & " order by Codigo asc"
            Dim da3 As New SqlDataAdapter(cmd3, cn)
            Dim ds3 As New DataSet

            da3.Fill(ds3)


            cn.Close()

            '  MsgBox("contar " & count)
            For Each row As DataRow In ds3.Tables(0).Rows


                Dim values() As Object = row.ItemArray

                Dim temp As String = String.Empty

                For Each value As Object In values 'Selecciona cada tarea individualmente

                    If Not value Is DBNull.Value Then
                        temp &= CStr(value) & Environment.NewLine
                    End If

                Next





                '  MsgBox("Conteo " & temp1)
                ' MsgBox("Codigo " & temp)


#Region "Insertar en historial cantidad de registro de tareas"
                'Inserta en historial el conteo con respecto a la cantidad de tareas disponibles en ese momento

                Dim dsConteo As New DataSet
                Dim dtconteo As New DataTable

                dsConteo.Tables.Add(dtconteo)
                dtconteo.Columns.Add("Columna1")



                conectar()
                Dim adaptador1 As New SqlCommand("insert into " & historial & "(Conteo,Codigo,Estado,Responsable,Fecha) values(" & contar & "," & temp & ",0,'" & nombre.Text & "','" & hoy & "')", cn)
                adaptador1.ExecuteNonQuery()
                desconectar()

                dtconteo.Rows.Add(contar)




#End Region

                contar = contar + 1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


#End Region

    End Sub

    Sub VisibleBotonCargar()
#Region "Verifica si hay algo creado"

        'Almacena en variable contar la cantidad de registros en el historial
        conectar()
        Dim contar7 As Integer

        Dim consulta7 As String
        consulta7 = ("select count (" & historial & ".Fecha)from " & historial & " where Fecha='" & hoy & "'  ")
        Dim cmd7 As New SqlCommand(consulta7, cn)
        contar7 = cmd7.ExecuteScalar

        desconectar()

        If contar7 > 0 Then
            bCargar.Visible = False
            label5.Visible = False
            label6.Visible = False
            combo1.Visible = False
            datagr.CurrentCell = datagr.Item(0, 1) 'Selecciona el celda 0,1 para evitar bug de invisibilidad
            Exit Sub
        Else
            bCargar.Visible = True
            label5.Visible = True
            label6.Visible = True
            combo1.Visible = True

        End If
#End Region
    End Sub

#Region "Historial"
    Sub CargarFecha()
#Region "Configuracion datagridview1"
        conectar()
        Dim formulario As DataGridView = datagr
        Dim conteo As String
        conteo = 1

        '#Region "Formato de letra"

        '        formulario.DefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)
        '        formulario.ColumnHeadersDefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)

        '#End Region
        formulario.RowTemplate.Height = 25
#Region "Cambios de color celdas y alternadas"
        datagr.RowsDefaultCellStyle.BackColor = Color.White
        datagr.AlternatingRowsDefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control)

#End Region
        '#Region "Cambios de color celdas y alternadas"
        '        formulario.RowsDefaultCellStyle.BackColor = Color.LightGray
        '        formulario.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray

        '#End Region
#Region "Alineacion de titulos"
        formulario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
#End Region
#Region "Buscar todos los equipos"

        Dim tabla As DataGridView = datagr
        Dim adaptador As New SqlDataAdapter("select distinct (Fecha)from " & historial & ";", cn)
        Dim dataS As New DataSet
        adaptador.Fill(dataS, "" & historial & "")

        tabla.DataSource = dataS.Tables("" & historial & "")

#End Region


#Region "Configuracion tabla"



        tabla.RowHeadersVisible = False

        tabla.EnableHeadersVisualStyles = False

        '   tabla.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51)
        tabla.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

        tabla.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(218, 218, 218)
        tabla.RowsDefaultCellStyle.SelectionForeColor = Color.Black
        'tabla.AutoResizeColumn(DataGridViewAutoSizeColumnMode.Fill)



        'tabla.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'tabla.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        ' tabla.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


        ' tabla.Columns(0).Width = 200%
        'tabla.Columns(2).Width = 240
        'tabla.Columns(3).Width = 170



#End Region
#End Region
    End Sub

    Sub CargarDatosFecha()
#Region "Configuracion datagridview1"
        conectar()
        Dim formulario As DataGridView = datagr2
        Dim conteo As String
        conteo = 1

        '#Region "Formato de letra"

        '        formulario.DefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)
        '        formulario.ColumnHeadersDefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)

        '#End Region
        formulario.RowTemplate.Height = 25
#Region "Cambios de color celdas y alternadas"
        datagr2.RowsDefaultCellStyle.BackColor = Color.White
        datagr2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control)

#End Region
        '#Region "Cambios de color celdas y alternadas"
        '        formulario.RowsDefaultCellStyle.BackColor = Color.LightGray
        '        formulario.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray

        '#End Region
#Region "Alineacion de titulos"
        formulario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
#End Region
#Region "Buscar todos los equipos"

        Dim tabla As DataGridView = datagr2
        Dim adaptador As New SqlDataAdapter("select hist.Conteo,list.Tarea,list.Equipo,case when Estado=0 then 'Pendiente' when Estado=1 then 'Finalizado' end '  Estado',hist.Fecha,hist.Responsable,hist.Comentarios  from " & historial & " hist,List_Startup_Shutdown list where hist.Codigo=list.Codigo and fecha='" & presionar & "' ", cn)
        Dim dataS As New DataSet
        adaptador.Fill(dataS, "" & historial & "")

        tabla.DataSource = dataS.Tables("" & historial & "")

#End Region


#Region "Configuracion tabla"



        tabla.RowHeadersVisible = False


        tabla.EnableHeadersVisualStyles = False
        tabla.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51)
        tabla.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        tabla.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(218, 218, 218)
        tabla.RowsDefaultCellStyle.SelectionForeColor = Color.Black



        tabla.Columns(0).Visible = False
        'tabla.Columns(3).Visible = False


        ' tabla.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'tabla.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        tabla.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(1).Width = 300
        tabla.Columns(2).Width = 240
        tabla.Columns(3).Width = 170
        tabla.Columns(3).Width = 100
        tabla.Columns(5).Width = 150


#End Region
#End Region
    End Sub
#End Region


End Module

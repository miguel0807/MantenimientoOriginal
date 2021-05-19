Imports System.IO
Imports System.Data
Imports System.Reflection
Imports ClosedXML.Excel
Imports System.Data.SqlClient



Module Modulo_Indicadores
    Public datagridIndicadores As DataGridView

    Public segundotimer As Integer

    Public Caso As Integer

    Public EtiquetaConteo As Label
    Public MItxtTiempoInicio As TextBox
    Public MItxtTiempoFinal As TextBox
    Public MIminutoAcumulado As TextBox
    Public MIhoraAcumulada As TextBox



    Public MItitulo As TextBox
    Public MIresponsable As ComboBox
    Public MIclase As ComboBox
    Public MIequipo As ComboBox
    Public MIubicacion As ComboBox
    Public MIclasificacion As ComboBox
    Public MIdescripcion As TextBox
    Public MIsolucionProblema As TextBox
    Public MIfechaInicio As TextBox
    Public MIfechaFinal As TextBox



    Public MIcalHoras As Label
    Public MIcalMinutos As Label
    Public MIpanelControlTiempo As Panel

    Public MIbtnControlTiempo As Button



    Public Conteo3 As Integer
    Public MIseleccion As Integer = 0
    Public MIvalorEditable As Integer

    Dim hora As Integer
    Dim minuto As Integer

    Dim minutodivision As Integer
    Dim minutoresta As Integer

    Dim acumhora As Integer
    Dim acumminuto As Integer

    Dim almacenar As Boolean = False


#Region "Reportes por area"
    Public adatosAño As ComboBox
    Public adatosMes As ComboBox
    Public adatosUbicación As ComboBox
    Public adatosCargar As Button

    Public adatosDtg As DataGridView
    Public adatosCheckAño As CheckBox
    Public adatosCheckMes As CheckBox
    Public adatosCheckUbicación As CheckBox
    Public adatosDataSet As New DataSet
    Public adatosChart1 As DataVisualization.Charting.Chart

    Public adatosVariableMes As Integer
#End Region



#Region "Resolucion de casos"
    Public ResolucionDtg As DataGridView
    Public ResolucionChar1 As DataVisualization.Charting.Chart
    Public ResolucionDataSet As New DataSet
    Public ResolucionCboFecha As ComboBox
#End Region

#Region "Reporte Casos Cerrados"
    Public repoCaCedtg As DataGridView
    Public repoCaCeDataSet As New DataSet
    Public repoCaCeAño As ComboBox
    Public repoCaCeMes As ComboBox
#End Region


    Sub cargarIndicadores()
#Region "Buscar casos abiertos"
        conectar()
        Dim tabla As DataGridView = datagridIndicadores
        Dim adaptador As New SqlDataAdapter("select Caso,Título,Responsable,Clase,Equipo,Ubicación,Clasificación,Descripción,
        [Fecha Inicial] as 'Fecha Inicial',
        [Fecha Final] as 'Fecha Final', Horas,Minutos from Indicadores1", cn)
        Dim dataS As New DataSet
        adaptador.Fill(dataS, "Indicadores")

        tabla.DataSource = dataS.Tables("Indicadores")
        desconectar()



#Region "Formato de letra"
        datagridIndicadores.DefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)
        datagridIndicadores.ColumnHeadersDefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)

#End Region
        '  DataGridView1.RowTemplate.Height = 50
#Region "Cambios de color celdas y alternadas"
        datagridIndicadores.RowsDefaultCellStyle.BackColor = Color.White
        datagridIndicadores.AlternatingRowsDefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control)

#End Region
#Region "Personalizacion header"
        datagridIndicadores.EnableHeadersVisualStyles = False
        datagridIndicadores.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51)
        datagridIndicadores.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        datagridIndicadores.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(218, 218, 218)
        datagridIndicadores.RowsDefaultCellStyle.SelectionForeColor = Color.Black

        datagridIndicadores.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 51, 51)

        'formulario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

#End Region
#Region "Alineacion de titulos"
        datagridIndicadores.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
#End Region
        tabla.RowHeadersVisible = False
#End Region
    End Sub

    Sub exportarArchivo()

        Dim carpeta As New FolderBrowserDialog
        Dim direccion As String = String.Empty

        If carpeta.ShowDialog = Windows.Forms.DialogResult.OK Then
            direccion = carpeta.SelectedPath
            direccion = direccion & "\"
        Else


            Exit Sub


        End If



        'Creating DataTable
        Dim dt As New DataTable()

        'Adding the Columns
        For Each column As DataGridViewColumn In datagridIndicadores.Columns
            dt.Columns.Add(column.HeaderText, column.ValueType)
        Next

        'Adding the Rows
        For Each row As DataGridViewRow In datagridIndicadores.Rows
            dt.Rows.Add()
            For Each cell As DataGridViewCell In row.Cells
                dt.Rows(dt.Rows.Count - 1)(cell.ColumnIndex) = cell.Value.ToString()
            Next
        Next

        'Exporting to Excel
        ' Dim folderPath As String = "C:\Excel\"
        Dim folderPath As String = direccion
        If Not Directory.Exists(folderPath) Then
            Directory.CreateDirectory(folderPath)
        End If
        Using wb As New XLWorkbook()
            wb.Worksheets.Add(dt, "Datos")
            wb.SaveAs(folderPath & Convert.ToString("Historial Indicadores.xlsx"))
        End Using

        MessageBox.Show("Exportación completa")
    End Sub



#Region "Registro nuevo caso"
    Sub MostrarCantidadCasos()
        Try
            conectar()

            Dim Query As String
            Query = ("select COUNT (Estado) from Indicadores1")
            Dim cmd As New SqlCommand(Query, cn)
            Conteo3 = cmd.ExecuteScalar

            EtiquetaConteo.Text = Conteo3
            EtiquetaConteo.Text = "Caso #" + EtiquetaConteo.Text
            'Coloca la cantidad de filas que hay en la tabla temporal
            desconectar()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub





    Sub CargarPendiente()

        Try


            If MItitulo.Text = "" Or MIfechaInicio.Text = "" Then
                MsgBox("Necesita completar título y fecha de inicio")
            Else
                If MIvalorEditable = 0 Then

                    If MItxtTiempoInicio.Text = "00:00:00" Then
                        MIseleccion = 0
                    ElseIf MItxtTiempoInicio.Text = "" Then
                        MIseleccion = 0
                    Else

                        MIseleccion = 1
                    End If

                    Dim adaptador As New SqlCommand("insert into Indicadores1 values (" & Conteo3 & ",'" & MItitulo.Text & "' ,'" & MIresponsable.Text & "',
                                        '" & MIclase.Text & "','" & MIequipo.Text & "','" & MIubicacion.Text & "',
                                     '" & MIclasificacion.Text & "','" & MIdescripcion.Text & "','" & MIsolucionProblema.Text & "','" & MIfechaInicio.Text & "',
                                     '" & MIfechaFinal.Text & "'," & 1 & ",'" & MItxtTiempoInicio.Text & "'," & MIhoraAcumulada.Text & ",
                                     " & MIminutoAcumulado.Text & "," & MIseleccion & ")", cn)
                    conectar()
                    adaptador.ExecuteNonQuery()
                    MsgBox("Se registro correctamente")
                    desconectar()


                    For Each frm As Form In formularios
                        frm.Close()

                    Next
                Else

                    If MItxtTiempoInicio.Text = "00:00:00" Then
                        MIseleccion = 0
                    ElseIf MItxtTiempoInicio.Text = "" Then
                        MIseleccion = 0
                    Else

                        MIseleccion = 1
                    End If

                    Dim adaptador As New SqlCommand("update Indicadores1 set Título =('" & MItitulo.Text & "'),
                                                    Responsable =('" & MIresponsable.Text & "'),Clase =('" & MIclase.Text & "'),
                                                    Equipo =('" & MIequipo.Text & "'),Ubicación =('" & MIubicacion.Text & "'),
                                                    Clasificación =('" & MIclasificacion.Text & "'),Descripción =('" & MIdescripcion.Text & "'),
                                                    SoluciónProblema =('" & MIsolucionProblema.Text & "'),
                                                    [Fecha Inicial] =('" & MIfechaInicio.Text & "'),[Fecha Final] =('" & MIfechaFinal.Text & "'),
                                                     Estado =(1),[Tiempo Inicial] =('" & MItxtTiempoInicio.Text & "'),
                                                     Horas =('" & MIhoraAcumulada.Text & "'),Minutos =('" & MIminutoAcumulado.Text & "'),
                                                     Seleccion =(" & MIseleccion & ") where Caso =(" & Conteo3 & ")", cn)
                    conectar()
                    adaptador.ExecuteNonQuery()
                    MsgBox("Se registro correctamente")
                    desconectar()
                    Registrar_Nuevo_Caso.Dispose()
                End If
            End If




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub CargarFinalizado()

        Try
            If MIclasificacion.Text = "" Then

                MsgBox("Necesita completar todos los campos para finalizar")
                Exit Sub
            End If
            If MIvalorEditable = 0 Then
                If MIclasificacion.Text = "Servicio" Or MIclasificacion.Text = "Proyecto" Then


                    If MItitulo.Text = "" Or MIfechaInicio.Text = "" Or MIclasificacion.Text = "" Or MIresponsable.Text = "" Or MIubicacion.Text = "" Or MIfechaFinal.Text = "" Or MIdescripcion.Text = "" Or MIsolucionProblema.Text = "" Then



                        MsgBox("Necesita completar todos los campos para finalizar")
                        Exit Sub
                    Else


                        If MItxtTiempoInicio.Text = "00:00:00" Then
                            MIseleccion = 0
                        ElseIf MItxtTiempoInicio.Text = "" Then
                            MIseleccion = 0
                        Else

                            MIseleccion = 1
                        End If
                        Dim adaptador As New SqlCommand("insert into Indicadores1 values (" & Conteo3 & ",'" & MItitulo.Text & "' ,'" & MIresponsable.Text & "',
                                        'N/A','N/A','" & MIubicacion.Text & "',
                                     '" & MIclasificacion.Text & "','" & MIdescripcion.Text & "','" & MIsolucionProblema.Text & "','" & MIfechaInicio.Text & "',
                                     '" & MIfechaFinal.Text & "'," & 0 & ",'" & MItxtTiempoInicio.Text & "'," & MIhoraAcumulada.Text & ",
                                     " & MIminutoAcumulado.Text & "," & MIseleccion & ")", cn)
                        conectar()
                        adaptador.ExecuteNonQuery()
                        MsgBox("Se registro correctamente")
                        desconectar()
                        For Each frm As Form In formularios
                            frm.Close()

                        Next

                    End If







                ElseIf MIclasificacion.Text = "Correctivo" Or MIclasificacion.Text = "Mejora" Then


                    If MItitulo.Text = "" Or MIfechaInicio.Text = "" Or MIclasificacion.Text = "" Or MIresponsable.Text = "" Or MIubicacion.Text = "" Or MIclase.Text = "" Or MIequipo.Text = "" Or MIfechaFinal.Text = "" Or MIdescripcion.Text = "" Or MIsolucionProblema.Text = "" Then



                        MsgBox("Necesita completar todos los campos para finalizar")
                        Exit Sub
                    Else


                        If MItxtTiempoInicio.Text = "00:00:00" Then
                            MIseleccion = 0
                        ElseIf MItxtTiempoInicio.Text = "" Then
                            MIseleccion = 0
                        Else

                            MIseleccion = 1
                        End If
                        Dim adaptador As New SqlCommand("insert into Indicadores1 values (" & Conteo3 & ",'" & MItitulo.Text & "' ,'" & MIresponsable.Text & "',
                                        '" & MIclase.Text & "','" & MIequipo.Text & "','" & MIubicacion.Text & "',
                                     '" & MIclasificacion.Text & "','" & MIdescripcion.Text & "','" & MIsolucionProblema.Text & "','" & MIfechaInicio.Text & "',
                                     '" & MIfechaFinal.Text & "'," & 0 & ",'" & MItxtTiempoInicio.Text & "'," & MIhoraAcumulada.Text & ",
                                     " & MIminutoAcumulado.Text & "," & MIseleccion & ")", cn)
                        conectar()
                        adaptador.ExecuteNonQuery()
                        MsgBox("Se registro correctamente")
                        desconectar()
                        For Each frm As Form In formularios
                            frm.Close()

                        Next

                    End If
                End If






            Else



                'Si es actualizar entonces


                If MIclasificacion.Text = "Servicio" Or MIclasificacion.Text = "Proyecto" Then


                    If MItitulo.Text = "" Or MIfechaInicio.Text = "" Or MIclasificacion.Text = "" Or MIresponsable.Text = "" Or MIubicacion.Text = "" Or MIfechaFinal.Text = "" Or MIdescripcion.Text = "" Or MIsolucionProblema.Text = "" Then



                        MsgBox("Necesita completar todos los campos para finalizar")
                        Exit Sub
                    Else


                        If MItxtTiempoInicio.Text = "00:00:00" Then
                            MIseleccion = 0
                        ElseIf MItxtTiempoInicio.Text = "" Then
                            MIseleccion = 0
                        Else

                            MIseleccion = 1
                        End If


                        Dim adaptador As New SqlCommand("update Indicadores1 set Título =('" & MItitulo.Text & "'),
                                                    Responsable =('" & MIresponsable.Text & "'),Clase =('N/A'),
                                                    Equipo =('N/A'),Ubicación =('" & MIubicacion.Text & "'),
                                                    Clasificación =('" & MIclasificacion.Text & "'),Descripción =('" & MIdescripcion.Text & "'),
                                                    SoluciónProblema =('" & MIsolucionProblema.Text & "'),
                                                    [Fecha Inicial] =('" & MIfechaInicio.Text & "'),[Fecha Final] =('" & MIfechaFinal.Text & "'),
                                                     Estado =(0),[Tiempo Inicial] =('" & MItxtTiempoInicio.Text & "'),
                                                     Horas =('" & MIhoraAcumulada.Text & "'),Minutos =('" & MIminutoAcumulado.Text & "'),
                                                     Seleccion =(" & MIseleccion & ") where Caso =(" & Conteo3 & ")", cn)



                        conectar()
                        adaptador.ExecuteNonQuery()
                        MsgBox("Se registro correctamente")
                        desconectar()
                        For Each frm As Form In formularios
                            frm.Close()

                        Next
                    End If







                ElseIf MIclasificacion.Text = "Correctivo" Or MIclasificacion.Text = "Mejora" Then


                    If MItitulo.Text = "" Or MIfechaInicio.Text = "" Or MIclasificacion.Text = "" Or MIresponsable.Text = "" Or MIubicacion.Text = "" Or MIclase.Text = "" Or MIequipo.Text = "" Or MIfechaFinal.Text = "" Or MIdescripcion.Text = "" Or MIsolucionProblema.Text = "" Then



                        MsgBox("Necesita completar todos los campos para finalizar")

                        Exit Sub
                    Else


                        If MItxtTiempoInicio.Text = "00:00:00" Then
                            MIseleccion = 0
                        ElseIf MItxtTiempoInicio.Text = "" Then
                            MIseleccion = 0
                        Else

                            MIseleccion = 1
                        End If
                        Dim adaptador As New SqlCommand("update Indicadores1 set Título =('" & MItitulo.Text & "'),
                                                    Responsable =('" & MIresponsable.Text & "'),Clase =('" & MIclase.Text & "'),
                                                    Equipo =('" & MIequipo.Text & "'),Ubicación =('" & MIubicacion.Text & "'),
                                                    Clasificación =('" & MIclasificacion.Text & "'),Descripción =('" & MIdescripcion.Text & "'),
                                                    SoluciónProblema =('" & MIsolucionProblema.Text & "'),
                                                    [Fecha Inicial] =('" & MIfechaInicio.Text & "'),[Fecha Final] =('" & MIfechaFinal.Text & "'),
                                                     Estado =(0),[Tiempo Inicial] =('" & MItxtTiempoInicio.Text & "'),
                                                     Horas =('" & MIhoraAcumulada.Text & "'),Minutos =('" & MIminutoAcumulado.Text & "'),
                                                     Seleccion =(" & MIseleccion & ") where Caso =(" & Conteo3 & ")", cn)
                        conectar()
                        adaptador.ExecuteNonQuery()
                        MsgBox("Se registro correctamente")
                        desconectar()
                        For Each frm As Form In formularios
                            frm.Close()

                        Next
                    End If
                End If



            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub


    Sub btnTiempoInicio()

        Try
#Region "Colocacion de fecha cuando se genera la licencia"


            MItxtTiempoInicio.Text = DateTime.Now
            Dim fechacreacion1 As Date
            fechacreacion1 = MItxtTiempoInicio.Text
            MItxtTiempoInicio.Text = Format(fechacreacion1, "HH:mm")
#End Region

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        'MItxtTiempoInicio.Text = DateTime.Now
        'Dim fechacreacion As Date
        'fechacreacion = MItxtTiempoInicio.Text

        'MItxtTiempoInicio.Text = Format(fechacreacion, "yyyy/MM/dd HH:mm")



    End Sub

    Sub btnTiempoFinal()

        'MItxtTiempoFinal.Text = DateTime.Now
        'Dim fechacreacion As Date
        'fechacreacion = MItxtTiempoFinal.Text
        'MItxtTiempoFinal.Text = Format(fechacreacion, "yyyy/MM/dd HH:mm")

        Try
#Region "Colocacion de fecha cuando se genera la licencia"


            MItxtTiempoFinal.Text = DateTime.Now
            Dim fechacreacion1 As Date
            fechacreacion1 = MItxtTiempoFinal.Text
            MItxtTiempoFinal.Text = Format(fechacreacion1, "HH:mm")
#End Region

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub btnControlTiempo()
        If MIpanelControlTiempo.Visible = True Then
            MIpanelControlTiempo.Visible = False
            MIbtnControlTiempo.Text = "Control de tiempo"
        Else
            MIpanelControlTiempo.Visible = True
            MIbtnControlTiempo.Text = "Inicio"

        End If

    End Sub

    Sub btnFechaInicio()




        MIfechaInicio.Text = DateTime.Now
        Dim fechacreacion As Date
        fechacreacion = MIfechaInicio.Text
        MIfechaInicio.Text = Format(fechacreacion, "yyyy/MM/dd HH:mm")


    End Sub

    Sub btnFechaFinal()

        MIfechaFinal.Text = DateTime.Now
        Dim fechacreacion As Date
        fechacreacion = MIfechaFinal.Text
        MIfechaFinal.Text = Format(fechacreacion, "yyyy/MM/dd HH:mm")
    End Sub

    Sub btnCalcular()
        If MItxtTiempoInicio.Text = "" Or MItxtTiempoFinal.Text = "" Then
            MsgBox("Favor complete los tiempos")
        Else
            Dim minutos As String


            Dim FechaEntrada As String = MItxtTiempoInicio.Text
            Dim FechaSalida As String = MItxtTiempoFinal.Text
            Dim IntMinutos As Double



            minutos = DateDiff(DateInterval.Minute, CDate(FechaEntrada), CDate(FechaSalida))

            IntMinutos = minutos

            hora = Math.Truncate(IntMinutos / 60)

            minuto = Math.Truncate(IntMinutos - (hora * 60))

            If hora = 1 Then
                MIcalHoras.Text = hora & " hora"
            Else
                MIcalHoras.Text = hora & " horas"
            End If

            If minuto = 1 Then
                MIcalMinutos.Text = minuto & " minuto"
            Else
                MIcalMinutos.Text = minuto & " minutos"
            End If

            almacenar = True
        End If
    End Sub

    Sub btnAgregarTiempo()
        Try
            If almacenar = True Then
                acumhora = MIhoraAcumulada.Text
                acumhora = acumhora + hora

                acumminuto = MIminutoAcumulado.Text
                If minuto + acumminuto >= 60 Then
                    minutodivision = Math.Truncate((minuto + acumminuto) / 60)
                    minutoresta = (minuto + acumminuto) - (minutodivision * 60)
                    acumminuto = minutoresta

                    acumhora = acumhora + minutodivision
                Else
                    acumminuto = acumminuto + minuto
                End If


                MItxtTiempoInicio.Text = "00:00:00"
                MItxtTiempoFinal.Text = "00:00:00"
                MIcalHoras.Text = 0
                MIcalMinutos.Text = 0



                MIhoraAcumulada.Text = acumhora
                MIminutoAcumulado.Text = acumminuto
            End If
            almacenar = False


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

    Sub MIcargarResponsable()
#Region "Cargar datos en combobox de Responsable"

        Dim cmd3 As String = "select*from Usuarios"
        Dim da3 As New SqlDataAdapter(cmd3, cn)
        Dim ds3 As New DataSet
        da3.Fill(ds3)
        With MIresponsable
            MIresponsable.DataSource = ds3.Tables(0)
            MIresponsable.DisplayMember = "Nombre"
        End With
        cn.Close()
        MIresponsable.SelectedIndex = -1


#End Region
    End Sub

    Sub MIcargarClase()

        Dim cmd As String = "select*from Caracteristicas_Equipo"

        Dim da As New SqlDataAdapter(cmd, cn)
        Dim ds As New DataSet
        da.Fill(ds)
        With MIclase
            MIclase.DataSource = ds.Tables(0)
            MIclase.DisplayMember = "Clase"
        End With

        MIclase.SelectedIndex = -1




        cn.Close()

    End Sub

    Sub MIcargarEquipos()
        Dim Clasecodigo As Integer

#Region "Obtener # de Clase"
        'En el parentesis entre & & se coloca cual valor se usara para la busqueda
        Dim adaptador As New SqlDataAdapter("select*from Caracteristicas_Equipo where CONVERT(char,Clase)='" & MIclase.Text & "'", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "Codigo")

        'El item selecciona de cual columna de la base de datos se conectara y row es la fila
        If ds.Tables("Codigo").Rows.Count > 0 Then

            Clasecodigo = ds.Tables("Codigo").Rows(0).Item(0).ToString


        End If

#End Region

#Region "Crear lista con lista de equipos"
        Dim cmd5 As String = "select*from Lista_Equipos where Codigo=" & Clasecodigo & ""
        Dim da5 As New SqlDataAdapter(cmd5, cn)
        Dim dt5 As New DataTable()
        da5.Fill(dt5)

        Dim arrayEquipos As String() = dt5.Rows.OfType(Of DataRow)().[Select](Function(x) x(1).ToString()).ToArray() 'Se crea array

        Dim listaEquipos As New List(Of String) 'Se crea lista manipulable
        For Each elemento As String In arrayEquipos 'Se carga la lista con la informacion del array
            listaEquipos.Add(elemento)
        Next
#Region "Asignacion de lista final en combobox de etiqueta"
        With MIequipo
            MIequipo.DataSource = listaEquipos
        End With
#End Region
#End Region
        MIequipo.SelectedIndex = -1
    End Sub

    Sub MIcargarUbicacion()
        Dim cmd As String = "select*from Ubicacion_Datos"

        Dim da As New SqlDataAdapter(cmd, cn)
        Dim ds As New DataSet
        da.Fill(ds)
        With MIubicacion
            MIubicacion.DataSource = ds.Tables(0)
            MIubicacion.DisplayMember = "Ubicacion"
        End With

        cn.Close()

        MIubicacion.SelectedIndex = -1
    End Sub
    Sub MIcargarClasificación()
        Dim cmd As String = "select*from Clasificación_Datos"

        Dim da As New SqlDataAdapter(cmd, cn)
        Dim ds As New DataSet
        conectar()
        If CerrarSubs = True Then
            CerrarSubs = False
            Exit Sub
        End If
        da.Fill(ds)
        With MIclasificacion
            MIclasificacion.DataSource = ds.Tables(0)
            MIclasificacion.DisplayMember = "Clasificación"
        End With

        cn.Close()

        MIclasificacion.SelectedIndex = -1
    End Sub

#Region "Reportes por área"
    Sub AdatosCargarDatos1()
        Dim mes12 As Integer
        Select Case adatosMes.Text
            Case "Enero"
                mes12 = 1
            Case "Febrero"
                mes12 = 2
            Case "Marzo"
                mes12 = 3
            Case "Abril"
                mes12 = 4
            Case "Mayo"
                mes12 = 5
            Case "Junio"
                mes12 = 6
            Case "Julio"
                mes12 = 7
            Case "Agosto"
                mes12 = 8
            Case "Septiembre"
                mes12 = 9
            Case "Octubre"
                mes12 = 10
            Case "Noviembre"
                mes12 = 11
            Case "Diciembre"
                mes12 = 12

        End Select
        adatosDtg.DataSource = Nothing
        adatosDtg.Columns.Clear()
        adatosDataSet.Clear()

        If adatosCheckAño.Checked = False And adatosCheckMes.Checked = False And adatosCheckUbicación.Checked = False Then
            Dim adaptador As New SqlDataAdapter("select CAST(Ubicación AS varchar(max)) as 'Ubicación',COUNT(*) as Cantidad from  Indicadores1 group by CAST(Ubicación AS varchar(max))", cn)
            adaptador.Fill(adatosDataSet, "Indicadores1")



        ElseIf adatosCheckAño.Checked = True And adatosCheckMes.Checked = True And adatosCheckUbicación.Checked = True Then
            Dim adaptador As New SqlDataAdapter("select CAST(Ubicación AS varchar(max)) as 'Ubicación',COUNT(*) as Cantidad from  Indicadores1 where YEAR([Fecha Inicial])=" & adatosAño.Text & " and Month([Fecha Inicial])=" & mes12 & " and  convert(char,Ubicación)='" & adatosUbicación.Text & "'  group by CAST(Ubicación AS varchar(max))", cn)
            adaptador.Fill(adatosDataSet, "Indicadores1")



        ElseIf adatosCheckAño.Checked = True And adatosCheckMes.Checked = False And adatosCheckUbicación.Checked = False Then
            Dim adaptador As New SqlDataAdapter("select CAST(Ubicación AS varchar(max)) as 'Ubicación',COUNT(*) as Cantidad from  Indicadores1 where YEAR([Fecha Inicial])=" & adatosAño.Text & "  group by CAST(Ubicación AS varchar(max))", cn)
            adaptador.Fill(adatosDataSet, "Indicadores1")

        ElseIf adatosCheckAño.Checked = False And adatosCheckMes.Checked = True And adatosCheckUbicación.Checked = False Then
            Dim adaptador As New SqlDataAdapter("select CAST(Ubicación AS varchar(max)) as 'Ubicación',COUNT(*) as Cantidad from  Indicadores1 where Month([Fecha Inicial])=" & mes12 & " group by CAST(Ubicación AS varchar(max))", cn)
            adaptador.Fill(adatosDataSet, "Indicadores1")

        ElseIf adatosCheckAño.Checked = False And adatosCheckMes.Checked = False And adatosCheckUbicación.Checked = True Then
            Dim adaptador As New SqlDataAdapter("select CAST(Ubicación AS varchar(max)) as 'Ubicación',COUNT(*) as Cantidad from  Indicadores1 where convert(char,Ubicación)='" & adatosUbicación.Text & "' group by CAST(Ubicación AS varchar(max))", cn)
            adaptador.Fill(adatosDataSet, "Indicadores1")

        ElseIf adatosCheckAño.Checked = True And adatosCheckMes.Checked = True And adatosCheckUbicación.Checked = False Then
            Dim adaptador As New SqlDataAdapter("select CAST(Ubicación AS varchar(max)) as 'Ubicación',COUNT(*) as Cantidad from  Indicadores1 where YEAR([Fecha Inicial])=" & adatosAño.Text & " and MONTH([Fecha Inicial])=" & mes12 & " group by CAST(Ubicación AS varchar(max))", cn)
            adaptador.Fill(adatosDataSet, "Indicadores1")

        ElseIf adatosCheckAño.Checked = False And adatosCheckMes.Checked = True And adatosCheckUbicación.Checked = True Then
            Dim adaptador As New SqlDataAdapter("select CAST(Ubicación AS varchar(max)) as 'Ubicación',COUNT(*) as Cantidad from  Indicadores1 where Month([Fecha Inicial])=" & mes12 & " and convert(char,Ubicación)='" & adatosUbicación.Text & "' group by CAST(Ubicación AS varchar(max))", cn)
            adaptador.Fill(adatosDataSet, "Indicadores1")

        ElseIf adatosCheckAño.Checked = True And adatosCheckMes.Checked = False And adatosCheckUbicación.Checked = True Then
            Dim adaptador As New SqlDataAdapter("select CAST(Ubicación AS varchar(max)) as 'Ubicación',COUNT(*) as Cantidad from  Indicadores1 where YEAR([Fecha Inicial])=" & adatosAño.Text & " and convert(char,Ubicación)='" & adatosUbicación.Text & "' group by CAST(Ubicación AS varchar(max))", cn)
            adaptador.Fill(adatosDataSet, "Indicadores1")
        End If



        If adatosDataSet.Tables("Indicadores1").Rows.Count > 0 Then
            adatosDtg.DataSource = adatosDataSet.Tables("Indicadores1")
            desconectar()
        Else


        End If
    End Sub

    Sub AdatosEsteticaDtg()


#Region "Formato de letra"
        adatosDtg.DefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)
        adatosDtg.ColumnHeadersDefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)

#End Region
        ' Indicadores_Proceso.DataGridView1.RowTemplate.Height = 25
#Region "Cambios de color celdas y alternadas"
        adatosDtg.RowsDefaultCellStyle.BackColor = Color.White
        adatosDtg.AlternatingRowsDefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control)

#End Region
#Region "Personalizacion header"
        adatosDtg.EnableHeadersVisualStyles = False
        adatosDtg.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51)
        adatosDtg.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        'Me.DataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(218, 218, 218)
        adatosDtg.RowsDefaultCellStyle.SelectionForeColor = Color.Black

        adatosDtg.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 51, 51)

        'formulario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

#End Region
#Region "Alineacion de titulos"
        adatosDtg.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
#End Region

        If adatosDataSet.Tables("Indicadores1").Rows.Count > 0 Then
            adatosDtg.RowHeadersVisible = False
            adatosDtg.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            adatosDtg.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


            adatosDtg.Rows(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            adatosDtg.Columns(0).Width = 200
            adatosDtg.Columns(1).Width = 200



#Region "Bloquear filtro cuando se de click a columna"
            For Each col As DataGridViewColumn In adatosDtg.Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable


            Next
#End Region

        End If
    End Sub

    Sub AdatosCargarGrafico1()
        Dim miView As DataView = New DataView(adatosDataSet.Tables("Indicadores1")) 'Enviamos a un dataview los datos

        adatosChart1.Series("Ubicación").Points.Clear()

        For f = 0 To miView.Count - 1

            adatosChart1.Series("Ubicación").Points.AddXY(miView(f)("Ubicación"), miView(f)("Cantidad"))
        Next

        If adatosDataSet.Tables("Indicadores1").Rows.Count > 0 Then
            adatosDtg.DataSource = adatosDataSet.Tables("Indicadores1")
            desconectar()
        Else

            MsgBox("No hay datos para el filtro seleccionado")
        End If



    End Sub
#End Region

#Region "Reportes por Casos"

    Sub ResolucionEsteticaDtg()




#Region "Formato de letra"
        ResolucionDtg.DefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)
        ResolucionDtg.ColumnHeadersDefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)

#End Region
        ' Indicadores_Proceso.DataGridView1.RowTemplate.Height = 25
#Region "Cambios de color celdas y alternadas"
        ResolucionDtg.RowsDefaultCellStyle.BackColor = Color.White
        ResolucionDtg.AlternatingRowsDefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control)

#End Region
#Region "Personalizacion header"
        ResolucionDtg.EnableHeadersVisualStyles = False
        ResolucionDtg.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51)
        ResolucionDtg.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        'Me.DataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(218, 218, 218)
        ResolucionDtg.RowsDefaultCellStyle.SelectionForeColor = Color.Black

        ResolucionDtg.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 51, 51)

        'formulario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

#End Region
#Region "Alineacion de titulos"
        ResolucionDtg.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
#End Region

        If ResolucionDataSet.Tables("Indicadores1").Rows.Count > 0 Then
            ResolucionDtg.RowHeadersVisible = False
            ResolucionDtg.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            ResolucionDtg.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            ResolucionDtg.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            ResolucionDtg.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            ResolucionDtg.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            ResolucionDtg.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            ResolucionDtg.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            ResolucionDtg.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            ResolucionDtg.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            ResolucionDtg.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            ResolucionDtg.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            ResolucionDtg.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            ResolucionDtg.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            ResolucionDtg.Rows(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            ResolucionDtg.Columns(0).Width = 130
            ResolucionDtg.Columns(1).Width = 70
            ResolucionDtg.Columns(2).Width = 80
            ResolucionDtg.Columns(3).Width = 70
            ResolucionDtg.Columns(4).Width = 60
            ResolucionDtg.Columns(5).Width = 70
            ResolucionDtg.Columns(6).Width = 70
            ResolucionDtg.Columns(7).Width = 70
            ResolucionDtg.Columns(8).Width = 70
            ResolucionDtg.Columns(9).Width = 100
            ResolucionDtg.Columns(10).Width = 70
            ResolucionDtg.Columns(11).Width = 100
            ResolucionDtg.Columns(12).Width = 100


#Region "Bloquear filtro cuando se de click a columna"
            For Each col As DataGridViewColumn In ResolucionDtg.Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable


            Next
#End Region

        End If



    End Sub

    Sub ResolucionCargarDatos()
        ResolucionDataSet.Clear()
        ResolucionDtg.DataSource = Nothing
        ResolucionDtg.Columns.Clear()




        Dim adaptador As New SqlDataAdapter("
    set language spanish;



    with

    indicadores4 as (
    select Caso,[Fecha Inicial],[Fecha Final]
      from Indicadores1
    )
    ,
    IntervaloIndicador as (
    select   month([Fecha Inicial]) Mes
           , case 
               when datediff(day, [Fecha Inicial], [Fecha Final]) <= 2 then '0-2'
               when datediff(day, [Fecha Inicial], [Fecha Final]) <= 4 then '3-4'
               when datediff(day, [Fecha Inicial], [Fecha Final]) <= 6 then '5-6'
               when datediff(day, [Fecha Inicial], [Fecha Final]) <= 10 then '7-10'
               else '10+'
             end Intervalo
      from Indicadores1
     where year([Fecha Inicial]) = " & ResolucionCboFecha.Text & "

    -- DateName( month , DateAdd( month , Mes , 0 ) - 1 )

    ),


    PruebaCT as (

	       select Intervalo, 
	       case 
               when  Mes=1 then '1'
		    else 0		
             end Enero,
		       case 
               when  Mes=2 then '1'
		       else 0
             end Febrero,

		      case 
               when  Mes=3 then '1'
               else 0
             end Marzo,

		       case 
               when  Mes=4 then '1'
		    else 0		
             end Abril,

		       case 
               when  Mes=5 then '1'
		       else 0
             end Mayo,

		      case 
               when  Mes=6 then '1'
               else 0
             end Junio,

		      case 
               when  Mes=7 then '1'
		    else 0		
             end Julio,

		       case 
               when  Mes=8 then '1'
		       else 0
             end Agosto,

		      case 
               when  Mes=9 then '1'
               else 0
             end Septiembre,

		       case 
               when  Mes=10 then '1'
		    else 0		
             end Octubre,

		       case 
               when  Mes=11 then '1'
		       else 0
             end Noviembre,

		      case 
               when  Mes=12 then '1'
               else 0
             end Diciembre
	
		     from IntervaloIndicador
	
		     )
		 	     --SELECT*FROM PruebaCT;
		
		
	

		     select Intervalo,case
		     when Intervalo=Intervalo then SUM(enero)
		    end Enero,
		    case
		    when Intervalo=Intervalo then sum (Febrero)
		    end Febrero,
		    case
		    when Intervalo=Intervalo then sum (Marzo)
		    end Marzo,
		     case
		    when Intervalo=Intervalo then sum (Abril)
		    end Abril,case
		    when Intervalo=Intervalo then sum (Mayo)
		    end Mayo,
		    case
		    when Intervalo=Intervalo then sum (Junio)
		    end Junio,
		    case
		    when Intervalo=Intervalo then sum (Julio)
		    end Julio,
		     case
		    when Intervalo=Intervalo then sum (Agosto)
		    end Agosto,
		    case
		    when Intervalo=Intervalo then sum (Septiembre)
		    end Septiembre,
		    case
		    when Intervalo=Intervalo then sum (Octubre)
		    end Octubre,
		     case
		    when Intervalo=Intervalo then sum (Noviembre)
		    end Noviembre,
		    case
		    when Intervalo=Intervalo then sum (Diciembre)
		    end Diciembre  from PruebaCT
		     group by Intervalo
	
		
		    order by 
		    case Intervalo
		    when '0-2' then 1
		    when '3-4' then 2
		    when '5-6' then 3
		    when '7-10' then 4
		    when '10+' then 5
		    end



", cn)

        adaptador.Fill(ResolucionDataSet, "Indicadores1")

        If ResolucionDataSet.Tables("Indicadores1").Rows.Count > 0 Then
            ResolucionDtg.DataSource = ResolucionDataSet.Tables("Indicadores1")

            desconectar()
        Else


        End If




    End Sub

    Sub ResolucionCargaGrafico()
        Dim miView As DataView = New DataView(ResolucionDataSet.Tables("Indicadores1")) 'Enviamos a un dataview los datos




        ResolucionChar1.Series("Enero").Points.Clear()
        ResolucionChar1.Series("Febrero").Points.Clear()
        ResolucionChar1.Series("Marzo").Points.Clear()
        ResolucionChar1.Series("Abril").Points.Clear()
        ResolucionChar1.Series("Mayo").Points.Clear()
        ResolucionChar1.Series("Junio").Points.Clear()
        ResolucionChar1.Series("Julio").Points.Clear()
        ResolucionChar1.Series("Agosto").Points.Clear()
        ResolucionChar1.Series("Septiembre").Points.Clear()
        ResolucionChar1.Series("Octubre").Points.Clear()
        ResolucionChar1.Series("Noviembre").Points.Clear()
        ResolucionChar1.Series("Diciembre").Points.Clear()

        For x = 0 To miView.Count - 1
            ResolucionChar1.Series("Enero").Points.AddXY(miView(x)("Intervalo"), miView(x)("Enero"))
            ResolucionChar1.Series("Febrero").Points.AddXY(miView(x)("Intervalo"), miView(x)("Febrero"))
            ResolucionChar1.Series("Marzo").Points.AddXY(miView(x)("Intervalo"), miView(x)("Marzo"))
            ResolucionChar1.Series("Abril").Points.AddXY(miView(x)("Intervalo"), miView(x)("Abril"))
            ResolucionChar1.Series("Mayo").Points.AddXY(miView(x)("Intervalo"), miView(x)("Mayo"))
            ResolucionChar1.Series("Junio").Points.AddXY(miView(x)("Intervalo"), miView(x)("Junio"))
            ResolucionChar1.Series("Julio").Points.AddXY(miView(x)("Intervalo"), miView(x)("Julio"))
            ResolucionChar1.Series("Agosto").Points.AddXY(miView(x)("Intervalo"), miView(x)("Agosto"))
            ResolucionChar1.Series("Septiembre").Points.AddXY(miView(x)("Intervalo"), miView(x)("Septiembre"))
            ResolucionChar1.Series("Octubre").Points.AddXY(miView(x)("Intervalo"), miView(x)("Octubre"))
            ResolucionChar1.Series("Noviembre").Points.AddXY(miView(x)("Intervalo"), miView(x)("Noviembre"))
            ResolucionChar1.Series("Diciembre").Points.AddXY(miView(x)("Intervalo"), miView(x)("Diciembre"))



        Next
        If ResolucionDataSet.Tables("Indicadores1").Rows.Count > 0 Then

        Else
            MsgBox("No hay datos para la fecha seleccionada")

        End If




    End Sub
#End Region
#Region "Reportes Casos"

    Sub RepoCasosCerradosCargarDatos()

        repoCaCedtg.DataSource = Nothing
        repoCaCedtg.Columns.Clear()
        repoCaCeDataSet.Clear()

        Dim adaptador As New SqlDataAdapter("

with
TablaDatos as(
select Título,Descripción,Caso,month([Fecha Inicial])as 'Mes',year([Fecha Inicial]) as 'Año' , 
case 

when month([Fecha Final])>month([Fecha Inicial]) THEN 0 
else 1
end as Estado

from Indicadores1 

)
select count(Estado) from TablaDatos where Estado=0 and Mes=" & repoCaCeMes.Text & " and Año=" & repoCaCeAño.Text & "


", cn)

        adaptador.Fill(repoCaCeDataSet, "Datos")

        If repoCaCeDataSet.Tables("Datos").Rows.Count > 0 Then
            repoCaCedtg.DataSource = repoCaCeDataSet.Tables("Datos")

            desconectar()
        Else


        End If
    End Sub

#End Region
End Module
                   
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
End Module

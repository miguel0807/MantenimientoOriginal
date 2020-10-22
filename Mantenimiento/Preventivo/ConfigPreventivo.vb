Imports System.Data.SqlClient


Module ConfigPreventivo
    Public codigo As String
    Public columna As String

#Region "Lista Equipos"


    Sub busqueda_equipos()

#Region "Configuracion datagridview1"
        conectar()
        Dim formulario As DataGridView = Lista_Equipos.DataGridView1
        Dim conteo As String
        conteo = 1

#Region "Formato de letra"

        formulario.DefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)
        formulario.ColumnHeadersDefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)

#End Region
        formulario.RowTemplate.Height = 25
#Region "Color de los titulos"
        formulario.ColumnHeadersDefaultCellStyle.BackColor = Color.SlateGray
        formulario.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
#End Region
#Region "Cambios de color celdas y alternadas"
        formulario.RowsDefaultCellStyle.BackColor = Color.LightGray
        formulario.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray

#End Region
#Region "Alineacion de titulos"
        formulario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
#End Region
#Region "Buscar todos los equipos"

        Dim tabla As DataGridView = Lista_Equipos.DataGridView1
        Dim adaptador As New SqlDataAdapter("SELECT Lista_Equipos.Etiqueta,Lista_Equipos.Placa,Caracteristicas_Equipo.Clase,Lista_Equipos.Ubicacion from Lista_Equipos,Caracteristicas_Equipo where Lista_Equipos.Codigo=Caracteristicas_Equipo.Codigo", cn)
        Dim dataS As New DataSet
        adaptador.Fill(dataS, "Lista_Equipos")

        tabla.DataSource = dataS.Tables("Lista_Equipos")

#End Region


#Region "Configuracion tabla"



        tabla.RowHeadersVisible = False




        tabla.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        tabla.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


        tabla.Columns(1).Width = 380
        tabla.Columns(2).Width = 240
        tabla.Columns(3).Width = 170



#End Region
#End Region

#Region "Conteo de cantidad de equipos"

        Lista_Equipos.Label1.Visible = True
        Lista_Equipos.Label1.Text = "Cantidad: " & tabla.RowCount
        Lista_Equipos.conteo = tabla.RowCount
#End Region
    End Sub

    Sub busqueda_clase()
#Region "Configuracion datagridview1"
        conectar()
        Dim formulario As DataGridView = Lista_Equipos.DataGridView1
        Dim conteo As String
        conteo = 1

#Region "Formato de letra"

        formulario.DefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)
        formulario.ColumnHeadersDefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)

#End Region
        formulario.RowTemplate.Height = 25
#Region "Color de los titulos"
        formulario.ColumnHeadersDefaultCellStyle.BackColor = Color.SlateGray
        formulario.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
#End Region
#Region "Cambios de color celdas y alternadas"
        formulario.RowsDefaultCellStyle.BackColor = Color.LightGray
        formulario.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray

#End Region
#Region "Alineacion de titulos"
        formulario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
#End Region

#Region "Buscar la clase espeficifica"

        Dim numero_clase As Integer
        Dim adaptador1 As New SqlDataAdapter("select Codigo from Caracteristicas_Equipo where convert(char,clase)='" & Lista_Equipos.detalle.Text & "'", cn)
        Dim dataS1 As New DataSet
        'busqueda.Text = adaptador.SelectCommand.CommandText
        adaptador1.Fill(dataS1, "Codigo")
        numero_clase = dataS1.Tables("Codigo").Rows(0).Item(0).ToString



#End Region
#Region "Buscar todos los equipos"


        Dim tabla As DataGridView = Lista_Equipos.DataGridView1
        Dim adaptador As New SqlDataAdapter("select*from Lista_Equipos where codigo='" & numero_clase & "'", cn)
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

#Region "Conteo de cantidad de equipos"

        Lista_Equipos.Label1.Visible = True
        Lista_Equipos.Label1.Text = "Cantidad: " & tabla.RowCount
        Lista_Equipos.conteo = tabla.RowCount
#End Region
    End Sub

    Sub busqueda_clasificacion()
#Region "Configuracion datagridview1"
        conectar()
        Dim formulario As DataGridView = Lista_Equipos.DataGridView1
        Dim conteo As String
        conteo = 1

#Region "Formato de letra"

        formulario.DefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)
        formulario.ColumnHeadersDefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)

#End Region
        formulario.RowTemplate.Height = 25
#Region "Color de los titulos"
        formulario.ColumnHeadersDefaultCellStyle.BackColor = Color.SlateGray
        formulario.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
#End Region
#Region "Cambios de color celdas y alternadas"
        formulario.RowsDefaultCellStyle.BackColor = Color.LightGray
        formulario.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray

#End Region
#Region "Alineacion de titulos"
        formulario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
#End Region


#Region "Buscar todos las clases"


        Dim tabla As DataGridView = Lista_Equipos.DataGridView1
        Dim adaptador As New SqlDataAdapter("select Lista_Equipos.Etiqueta,Caracteristicas_Equipo.Clase, Caracteristicas_Equipo.Clasificacion from Caracteristicas_Equipo,Lista_Equipos where Caracteristicas_Equipo.Codigo=Lista_Equipos.Codigo and convert(char,Caracteristicas_Equipo.Clasificacion)='" & Lista_Equipos.detalle.Text & "'", cn)
        Dim dataS As New DataSet
        adaptador.Fill(dataS, "Lista_Equipos")

        tabla.DataSource = dataS.Tables("Lista_Equipos")

#End Region


#Region "Configuracion tabla"



        tabla.RowHeadersVisible = False




        tabla.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        'tabla.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


        tabla.Columns(1).Width = 380
        tabla.Columns(2).Width = 240
        'tabla.Columns(3).Width = 170



#End Region
#End Region

#Region "Conteo de cantidad de equipos"

        Lista_Equipos.Label1.Visible = True
        Lista_Equipos.Label1.Text = "Cantidad: " & tabla.RowCount
        Lista_Equipos.conteo = tabla.RowCount
#End Region
    End Sub

    Sub busqueda_frecuencia()
#Region "Configuracion datagridview1"
        conectar()
        Dim formulario As DataGridView = Lista_Equipos.DataGridView1
        Dim conteo As String
        conteo = 1

#Region "Formato de letra"

        formulario.DefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)
        formulario.ColumnHeadersDefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)

#End Region
        formulario.RowTemplate.Height = 25
#Region "Color de los titulos"
        formulario.ColumnHeadersDefaultCellStyle.BackColor = Color.SlateGray
        formulario.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
#End Region
#Region "Cambios de color celdas y alternadas"
        formulario.RowsDefaultCellStyle.BackColor = Color.LightGray
        formulario.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray

#End Region
#Region "Alineacion de titulos"
        formulario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
#End Region


#Region "Buscar todos las clases"


        Dim tabla As DataGridView = Lista_Equipos.DataGridView1
        Dim adaptador As New SqlDataAdapter("SELECT Caracteristicas_Equipo.Clase as [Nombre], Caracteristicas_Equipo.Frecuencia, Caracteristicas_Equipo.Provedor from Caracteristicas_Equipo where convert(char,caracteristicas_equipo.frecuencia)='" & Lista_Equipos.detalle.Text & "'", cn)
        Dim dataS As New DataSet
        adaptador.Fill(dataS, "Lista_Equipos")

        tabla.DataSource = dataS.Tables("Lista_Equipos")

#End Region


#Region "Configuracion tabla"



        tabla.RowHeadersVisible = False




        tabla.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        'tabla.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        tabla.Columns(0).Width = 380
        tabla.Columns(1).Width = 300
        tabla.Columns(2).Width = 380




#End Region
#End Region

#Region "Conteo de cantidad de equipos"

        Lista_Equipos.Label1.Visible = True
        Lista_Equipos.Label1.Text = "Cantidad: " & tabla.RowCount
        Lista_Equipos.conteo = tabla.RowCount
#End Region
    End Sub


#End Region

#Region "Planificacion_Preventivo"


    Sub Configuracion_Año()

        Try
            Dim cmd As String = "select*from Año_Datos"
            Dim da As New SqlDataAdapter(cmd, cn)
            Dim ds As New DataSet
            da.Fill(ds)
            With Planificacion_Preventivo.año
                Planificacion_Preventivo.año.DataSource = ds.Tables(0)
                Planificacion_Preventivo.año.DisplayMember = "Año"
            End With

            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub Configuracion_Mes()

        Try
            Dim cmd As String = "select*from Meses_Datos"
            Dim da As New SqlDataAdapter(cmd, cn)
            Dim ds As New DataSet
            da.Fill(ds)
            With Planificacion_Preventivo.mes
                Planificacion_Preventivo.mes.DataSource = ds.Tables(0)
                Planificacion_Preventivo.mes.DisplayMember = "Meses"
            End With

            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Sub general()



#Region "Configuracion datagridview1"
        conectar()
        Dim formulario As DataGridView = Planificacion_Preventivo.DataGridView1
        Dim conteo As String
        conteo = 1

#Region "Formato de letra"

        formulario.DefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)
        formulario.ColumnHeadersDefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)

#End Region
        formulario.RowTemplate.Height = 30
#Region "Color de los titulos"
        formulario.ColumnHeadersDefaultCellStyle.BackColor = Color.SlateGray
        formulario.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
#End Region
#Region "Cambios de color celdas y alternadas"
        formulario.RowsDefaultCellStyle.BackColor = Color.LightGray
        formulario.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray

#End Region
#Region "Alineacion de titulos"
        formulario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
#End Region
#Region "Buscar la planificacion"

        Dim tabla As DataGridView = Planificacion_Preventivo.DataGridView1
        Dim adaptador As New SqlDataAdapter("select carac.codigo, carac.clase as Equipos, plani.Enero,plani.Febrero,plani.Marzo,plani.Abril,plani.Mayo,plani.Junio,plani.Julio,plani.Agosto,plani.Septiembre,plani.Octubre,plani.Noviembre,plani.Diciembre from Caracteristicas_Equipo carac,Planificacion_Equipos plani where Año='2020' and plani.Codigo=carac.Codigo", cn)
        Dim dataS As New DataSet
        adaptador.Fill(dataS, "Planificacion_Equipos")

        tabla.DataSource = dataS.Tables("Planificacion_Equipos")

#End Region


#Region "Configuracion tabla"



        '  tabla.RowHeadersVisible = False


        tabla.Columns(0).Visible = False

        tabla.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter




        'tabla.Columns(1).Width = 380
        'tabla.Columns(2).Width = 240
        'tabla.Columns(3).Width = 170



#End Region
#End Region

#Region "Conteo de cantidad de equipos"

        Planificacion_Preventivo.Label1.Visible = True
        Planificacion_Preventivo.Label1.Text = "Cantidad: " & tabla.RowCount
        Planificacion_Preventivo.conteo = tabla.RowCount
#End Region
    End Sub

    Sub agregar_Planificacion()
        'Try

        conectar()
        Select Case columna
            Case "2"
                columna = "Enero"
            Case "3"
                columna = "Febrero"
            Case "4"
                columna = "Marzo"
            Case "5"
                columna = "Abril"
            Case "6"
                columna = "Mayo"
            Case "7"
                columna = "Junio"
            Case "8"
                columna = "Julio"
            Case "9"
                columna = "Agosto"
            Case "10"
                columna = "Septiembre"
            Case "11"
                columna = "Octubre"
            Case "12"
                columna = "Noviembre"
            Case "13"
                columna = "Diciembre"

        End Select
        Dim conteo1 As New SqlCommand("UPDATE Planificacion_Equipos SET " & columna & "='X'  WHERE Codigo='" & codigo & "'", cn)
        conteo1.ExecuteNonQuery()
        ' MsgBox("Agregado con exito")
        desconectar()


        general()





        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Sub Eliminar_Planificacion()
        'Try

        conectar()
        Select Case columna
            Case "2"
                columna = "Enero"
            Case "3"
                columna = "Febrero"
            Case "4"
                columna = "Marzo"
            Case "5"
                columna = "Abril"
            Case "6"
                columna = "Mayo"
            Case "7"
                columna = "Junio"
            Case "8"
                columna = "Julio"
            Case "9"
                columna = "Agosto"
            Case "10"
                columna = "Septiembre"
            Case "11"
                columna = "Octubre"
            Case "12"
                columna = "Noviembre"
            Case "13"
                columna = "Diciembre"

        End Select
        Dim conteo1 As New SqlCommand("UPDATE Planificacion_Equipos SET " & columna & "=''  WHERE Codigo='" & codigo & "'", cn)
        conteo1.ExecuteNonQuery()
        ' MsgBox("Agregado con exito")
        desconectar()


        general()





        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

#End Region
End Module

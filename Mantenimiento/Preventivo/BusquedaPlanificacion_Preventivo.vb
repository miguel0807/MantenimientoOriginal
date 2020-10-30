Imports System.Data.SqlClient
Public Class BusquedaPlanificacion_Preventivo
    Public conteo As Integer
    Public codigo As String
    Public columna As String
    Public cantidad_equipos As Integer
    Dim eliminar_dentro As Boolean


    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tipobusqueda.SelectedIndexChanged
        Select Case tipobusqueda.Text

            Case "General"

                año.Visible = True
                mes.Visible = False
                Label2.Visible = False
                clase.Visible = False
                detalle_equipo.Visible = False
                Configuracion_Año()

            Case "Especifico"
                año.Visible = True
                mes.Visible = True
                Label2.Visible = True
                clase.Visible = True
                detalle_equipo.Visible = True
                Configuracion_Año()
                Configuracion_Mes()

        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Select Case tipobusqueda.Text

            Case "General"

                detalle_equipo.Visible = False

                general()
                Button4.Visible = True
            Case "Especifico"



        End Select
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        codigo = DataGridView1.CurrentRow.Cells.Item(0).Value.ToString

        columna = (String.Format("{0}", e.ColumnIndex))
        eliminar_dentro = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If columna = 1 Then
        ElseIf columna = 0 Then
        Else

            If eliminar_dentro = True Then
                Eliminar_Planificacion()

            End If
        End If

    End Sub

#Region "Planificacion_Preventivo"


    Sub Configuracion_Año()

        Try
            Dim cmd As String = "select*from Año_Datos"
            Dim da As New SqlDataAdapter(cmd, cn)
            Dim ds As New DataSet
            da.Fill(ds)
            With Me.año
                Me.año.DataSource = ds.Tables(0)
                Me.año.DisplayMember = "Año"
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
            With Me.mes
                Me.mes.DataSource = ds.Tables(0)
                Me.mes.DisplayMember = "Meses"
            End With

            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Sub general()



#Region "Configuracion datagridview1"
        conectar()
        Dim formulario As DataGridView = Me.DataGridView1
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

        Dim tabla As DataGridView = Me.DataGridView1

        ' Dim adaptador As New SqlDataAdapter("select carac.codigo, carac.clase as Equipos,  case when Enero =9999 then 'N/A' when Enero=Enero then CONVERT(char(3),Enero)end Enero, case when Febrero =9999 then 'N/A' when Febrero=Febrero then CONVERT(char(3),Febrero)end Febrero,case when Marzo =9999 then 'N/A'when Marzo=Marzo then CONVERT(char(3),Marzo)end Marzo,case when Abril =9999 then 'N/A'when Abril=Abril then CONVERT(char(3),Abril)end Abril,case when Mayo =9999 then 'N/A' when Mayo=Mayo then CONVERT(char(3),Mayo)end Mayo,case when Junio =9999 then 'N/A' when Junio=Junio then CONVERT(char(3),Junio)end Junio,case when Julio =9999 then 'N/A' when Julio=Julio then CONVERT(char(3),Julio)end Julio,case when Agosto =9999 then 'N/A' when Agosto=Agosto then CONVERT(char(3),Agosto)end Agosto,case when Septiembre =9999 then 'N/A' when Septiembre=Septiembre then CONVERT(char(3),Septiembre)end Septiembre,case when Octubre =9999 then 'N/A' when Octubre=Octubre then CONVERT(char(3),Octubre)end Octubre,case when Noviembre =9999 then 'N/A' when Noviembre=Noviembre then CONVERT(char(3),Noviembre)end Noviembre,case when Diciembre =9999 then 'N/A' when Diciembre=Diciembre then CONVERT(char(3),Diciembre)end Diciembre from Caracteristicas_Equipo carac,ConteoPlanificacion_Equipos plani where Año='2020' and plani.Codigo=carac.Codigo ", cn)
        Dim adaptador As New SqlDataAdapter("select carac.codigo, carac.clase as Equipos,  case when Enero =9999 then 'N/A' when Enero=0 then 'Finalizado'  when Enero=Enero then CONVERT(char(3),Enero)end Enero, case when Febrero =9999 then 'N/A' when Febrero=0 then 'Finalizado'  when Febrero=Febrero then CONVERT(char(3),Febrero)end Febrero,case when Marzo =9999 then 'N/A' when Marzo=0 then 'Finalizado'   when Marzo=Marzo then CONVERT(char(3),Marzo)end Marzo,case when Abril =9999 then 'N/A' when Abril=0 then 'Finalizado'  when Abril=Abril then CONVERT(char(3),Abril)end Abril,case when Mayo =9999 then 'N/A'  when Mayo=0 then 'Finalizado'  when Mayo=Mayo then CONVERT(char(3),Mayo)end Mayo,case when Junio =9999 then 'N/A'  when Junio=0 then 'Finalizado'  when Junio=Junio then CONVERT(char(3),Junio)end Junio,case when Julio =9999 then 'N/A'  when Julio=0 then 'Finalizado'  when Julio=Julio then CONVERT(char(3),Julio)end Julio,case when Agosto =9999 then 'N/A'  when Agosto=0 then 'Finalizado'  when Agosto=Agosto then CONVERT(char(3),Agosto)end Agosto,case when Septiembre =9999 then 'N/A'  when Septiembre=0 then 'Finalizado'  when Septiembre=Septiembre then CONVERT(char(3),Septiembre)end Septiembre,case when Octubre =9999 then 'N/A'  when Octubre=0 then 'Finalizado'  when Octubre=0 then 'Finalizado' when Octubre=Octubre then CONVERT(char(3),Octubre)end Octubre,case when Noviembre =9999 then 'N/A'  when Noviembre=0 then 'Finalizado'  when Noviembre=Noviembre then CONVERT(char(3),Noviembre)end Noviembre,case when Diciembre =9999 then 'N/A'  when Diciembre=0 then 'Finalizado'  when Diciembre=Diciembre then CONVERT(char(3),Diciembre)end Diciembre from Caracteristicas_Equipo carac,ConteoPlanificacion_Equipos plani where Año='" & año.Text & "' and plani.Codigo=carac.Codigo", cn)
        Dim dataS As New DataSet
        adaptador.Fill(dataS, "ConteoPlanificacion_Equipos")

        tabla.DataSource = dataS.Tables("ConteoPlanificacion_Equipos")

#End Region


#Region "Configuracion tabla"


        tabla.RowHeadersVisible = False

        tabla.Columns(1).Frozen = True
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
        tabla.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter



        tabla.Columns(1).Width = 225


        tabla.Columns(2).Width = 110
        tabla.Columns(3).Width = 110
        tabla.Columns(4).Width = 110
        tabla.Columns(5).Width = 110
        tabla.Columns(6).Width = 110
        tabla.Columns(7).Width = 110
        tabla.Columns(8).Width = 110
        tabla.Columns(9).Width = 110
        tabla.Columns(10).Width = 110
        tabla.Columns(11).Width = 110
        tabla.Columns(12).Width = 110
        tabla.Columns(13).Width = 110




#End Region
#End Region

#Region "Conteo de cantidad de equipos"

        Me.Label1.Visible = True
        Me.Label1.Text = "Cantidad: " & tabla.RowCount
        Me.conteo = tabla.RowCount
#End Region
    End Sub

    Sub agregar_Planificacion()
        'Try



#Region "Conseguir cantidad equipos"
        'En el parentesis entre & & se coloca cual valor se usara para la busqueda
        Dim adaptador As New SqlDataAdapter("select*from Caracteristicas_Equipo where Codigo=" & codigo & "", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "datos")

        'El item selecciona de cual columna de la base de datos se conectara y row es la fila
        If ds.Tables("datos").Rows.Count > 0 Then
            cantidad_equipos = ds.Tables("datos").Rows(0).Item(2).ToString


        End If
#End Region



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
        Dim conteo1 As New SqlCommand("UPDATE ConteoPlanificacion_Equipos SET " & columna & "=" & cantidad_equipos & "  WHERE Codigo='" & codigo & "'", cn)
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
#Region "Conseguir cantidad equipos"
        'En el parentesis entre & & se coloca cual valor se usara para la busqueda
        Dim adaptador As New SqlDataAdapter("select*from Caracteristicas_Equipo where Codigo=" & codigo & "", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "datos")

        'El item selecciona de cual columna de la base de datos se conectara y row es la fila
        If ds.Tables("datos").Rows.Count > 0 Then
            cantidad_equipos = ds.Tables("datos").Rows(0).Item(2).ToString


        End If
#End Region
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
        Dim conteo1 As New SqlCommand("UPDATE ConteoPlanificacion_Equipos SET " & columna & "=9999  WHERE Codigo='" & codigo & "'", cn)
        conteo1.ExecuteNonQuery()
        ' MsgBox("Agregado con exito")
        desconectar()


        general()





        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub Planificacion_Preventivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not formularios.Contains(Me) Then formularios.Add(Me) 'Agrega a la lista los formularios para luego cerrarlos
        tipobusqueda.SelectedIndex = 0


    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        If columna = 1 Then
        ElseIf columna = 0 Then
        Else

            agregar_Planificacion()
        End If

    End Sub



    Private Sub DataGridView1_Leave(sender As Object, e As EventArgs) Handles DataGridView1.Leave

    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub




#End Region
End Class
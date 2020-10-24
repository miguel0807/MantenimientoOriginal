Imports System.Data.SqlClient
Public Class Planificacion_Preventivo
    Public conteo As Integer
    Public codigo As String
    Public columna As String


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
            Case "Especifico"



        End Select
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        agregar_Planificacion()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        codigo = DataGridView1.CurrentRow.Cells.Item(0).Value.ToString

        columna = (String.Format("{0}", e.ColumnIndex))

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Eliminar_Planificacion()
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

        Me.Label1.Visible = True
        Me.Label1.Text = "Cantidad: " & tabla.RowCount
        Me.conteo = tabla.RowCount
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

    Private Sub Planificacion_Preventivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not formularios.Contains(Me) Then formularios.Add(Me) 'Agrega a la lista los formularios para luego cerrarlos
    End Sub

#End Region
End Class
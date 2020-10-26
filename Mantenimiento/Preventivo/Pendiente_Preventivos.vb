Imports System.Data.SqlClient
Public Class Pendiente_Preventivos

    Dim conteo As Integer
    Private Sub Pendiente_Preventivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not formularios.Contains(Me) Then formularios.Add(Me) 'Agrega a la lista los formularios para luego cerrarlos
    End Sub

    Private Sub tipobusqueda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tipobusqueda.SelectedIndexChanged
        Select Case tipobusqueda.Text

            Case "Pendientes Mensual"
                Clase.Visible = True


            Case "Pendientes Anual"

                Clase.Visible = True
        End Select
    End Sub

    Private Sub Clase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Clase.SelectedIndexChanged
        Select Case Clase.Text


            Case "Clase"
                Clase.Visible = True
                equipos.Visible = True

#Region "Cargar datos en combobox de Ubicacion"
                Try
                    Dim cmd As String = "select*from Caracteristicas_Equipo"
                    Dim da As New SqlDataAdapter(cmd, cn)
                    Dim ds As New DataSet
                    da.Fill(ds)
                    With Me.equipos
                        Me.equipos.DataSource = ds.Tables(0)
                        Me.equipos.DisplayMember = "Clase"
                    End With
                    cn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
#End Region

            Case "Todos"
                equipos.Visible = False

        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Select Case Clase.Text


            Case "Clase"




            Case "Todos"
                general()


        End Select
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
        Dim adaptador As New SqlDataAdapter("select carac.codigo, carac.clase as Equipos, plani.Enero,plani.Febrero,plani.Marzo,plani.Abril,plani.Mayo,plani.Junio,plani.Julio,plani.Agosto,plani.Septiembre,plani.Octubre,plani.Noviembre,plani.Diciembre from Caracteristicas_Equipo carac,Conteo_Equipos plani where Año='2020' and plani.Codigo=carac.Codigo", cn)
        Dim dataS As New DataSet
        adaptador.Fill(dataS, "Conteo_Equipos")

        tabla.DataSource = dataS.Tables("Conteo_Equipos")

#End Region


#Region "Configuracion tabla"



        tabla.RowHeadersVisible = False


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




        tabla.Columns(1).Width = 250
        tabla.Columns(2).Width = 80
        tabla.Columns(3).Width = 80
        tabla.Columns(4).Width = 80
        tabla.Columns(5).Width = 80
        tabla.Columns(6).Width = 80
        tabla.Columns(7).Width = 80
        tabla.Columns(8).Width = 80
        tabla.Columns(9).Width = 80
        tabla.Columns(10).Width = 110
        tabla.Columns(11).Width = 100
        tabla.Columns(12).Width = 100
        tabla.Columns(13).Width = 100

#End Region
#End Region

#Region "Conteo de cantidad de equipos"

        Me.Label1.Visible = True
        Me.Label1.Text = "Cantidad: " & tabla.RowCount
        Me.conteo = tabla.RowCount
#End Region
    End Sub
End Class
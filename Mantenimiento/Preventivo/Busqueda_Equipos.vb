Imports System.Data.SqlClient
Public Class Busqueda_Equipos
    Public conteo As Integer



    Private Sub Tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tipo.SelectedIndexChanged
        Select Case Tipo.Text


            Case "Equipos"
                detalle.Visible = False
                detalle.Enabled = False


            Case "Clase"
                detalle.Visible = True
                detalle.Enabled = True


                Try
                    Dim cmd As String = "select*from Caracteristicas_Equipo"
                    Dim da As New SqlDataAdapter(cmd, cn)
                    Dim ds As New DataSet
                    da.Fill(ds)
                    With Me.detalle
                        Me.detalle.DataSource = ds.Tables(0)
                        Me.detalle.DisplayMember = "Clase"
                    End With

                    cn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            Case "Clasificacion"
                detalle.Visible = True

                detalle.Enabled = True


                Try
                    Dim cmd As String = "select*from Clasificacion_Datos"
                    Dim da As New SqlDataAdapter(cmd, cn)
                    Dim ds As New DataSet
                    da.Fill(ds)
                    With Me.detalle
                        Me.detalle.DataSource = ds.Tables(0)
                        Me.detalle.DisplayMember = "Clasificacion"
                    End With
                    cn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            Case "Frecuencia"
                detalle.Visible = True

                detalle.Enabled = True

                Try
                    Dim cmd As String = "select*from Frecuencia_Datos"
                    Dim da As New SqlDataAdapter(cmd, cn)
                    Dim ds As New DataSet
                    da.Fill(ds)
                    With Me.detalle
                        Me.detalle.DataSource = ds.Tables(0)
                        Me.detalle.DisplayMember = "Frecuencia"
                    End With
                    cn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try


        End Select
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Select Case Tipo.Text
            Case "Equipos"
                busqueda_equipos()

            Case "Clase"
                busqueda_clase()

            Case "Clasificacion"
                busqueda_clasificacion()

            Case "Frecuencia"
                busqueda_frecuencia()
        End Select


    End Sub

    Private Sub Lista_Equipos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not formularios.Contains(Me) Then formularios.Add(Me) 'Agrega a la lista los formularios para luego cerrarlos
    End Sub
#Region "Lista Equipos"


    Sub busqueda_equipos()

#Region "Configuracion datagridview1"
        conectar()
        Dim formulario As DataGridView = Me.DataGridView1
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

        Dim tabla As DataGridView = Me.DataGridView1
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

        Me.Label1.Visible = True
        Me.Label1.Text = "Cantidad: " & tabla.RowCount
        Me.conteo = tabla.RowCount
#End Region
    End Sub

    Sub busqueda_clase()
#Region "Configuracion datagridview1"
        conectar()
        Dim formulario As DataGridView = Me.DataGridView1
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
        Dim adaptador1 As New SqlDataAdapter("select Codigo from Caracteristicas_Equipo where convert(char,clase)='" & Me.detalle.Text & "'", cn)
        Dim dataS1 As New DataSet
        'busqueda.Text = adaptador.SelectCommand.CommandText
        adaptador1.Fill(dataS1, "Codigo")
        numero_clase = dataS1.Tables("Codigo").Rows(0).Item(0).ToString



#End Region
#Region "Buscar todos los equipos"


        Dim tabla As DataGridView = Me.DataGridView1
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

        Me.Label1.Visible = True
        Me.Label1.Text = "Cantidad: " & tabla.RowCount
        Me.conteo = tabla.RowCount
#End Region
    End Sub

    Sub busqueda_clasificacion()
#Region "Configuracion datagridview1"
        conectar()
        Dim formulario As DataGridView = Me.DataGridView1
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


        Dim tabla As DataGridView = Me.DataGridView1
        Dim adaptador As New SqlDataAdapter("select Lista_Equipos.Etiqueta,Caracteristicas_Equipo.Clase, Caracteristicas_Equipo.Clasificacion from Caracteristicas_Equipo,Lista_Equipos where Caracteristicas_Equipo.Codigo=Lista_Equipos.Codigo and convert(char,Caracteristicas_Equipo.Clasificacion)='" & Me.detalle.Text & "'", cn)
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

        Me.Label1.Visible = True
        Me.Label1.Text = "Cantidad: " & tabla.RowCount
        Me.conteo = tabla.RowCount
#End Region
    End Sub

    Sub busqueda_frecuencia()
#Region "Configuracion datagridview1"
        conectar()
        Dim formulario As DataGridView = Me.DataGridView1
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


        Dim tabla As DataGridView = Me.DataGridView1
        Dim adaptador As New SqlDataAdapter("SELECT Caracteristicas_Equipo.Clase as [Nombre], Caracteristicas_Equipo.Frecuencia, Caracteristicas_Equipo.Provedor from Caracteristicas_Equipo where convert(char,caracteristicas_equipo.frecuencia)='" & Me.detalle.Text & "'", cn)
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

        Me.Label1.Visible = True
        Me.Label1.Text = "Cantidad: " & tabla.RowCount
        Me.conteo = tabla.RowCount
#End Region
    End Sub


#End Region
End Class
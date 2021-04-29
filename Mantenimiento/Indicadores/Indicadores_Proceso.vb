Imports System.Data.SqlClient
Public Class Indicadores_Proceso
    Public conteo_total As Integer

    Private Sub Indicadores_Proceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not formularios.Contains(Me) Then formularios.Add(Me) 'Agrega a la lista los formularios para luego cerrarlos
        Clasificacion.SelectedIndex = 0

        datag()
        Timer1.Start()





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If conteo_total <= 0 Then
                MsgBox("No hay casos pendientes")
            Else
                Registrar_Nuevo_Caso.Show()


                Me.DataGridView1.Select() 'Seleccionar primera fila del datagridview



                'Almacena informacion para ser impresa


                EtiquetaConteo.Text = "Caso #" + Me.DataGridView1.CurrentRow.Cells.Item(0).Value.ToString
                Conteo3 = Me.DataGridView1.CurrentRow.Cells.Item(0).Value.ToString
                MItitulo.Text = Me.DataGridView1.CurrentRow.Cells.Item(1).Value.ToString
                MIresponsable.Text = Me.DataGridView1.CurrentRow.Cells.Item(2).Value.ToString
                MIclase.Text = Me.DataGridView1.CurrentRow.Cells.Item(3).Value.ToString
                MIequipo.Text = Me.DataGridView1.CurrentRow.Cells.Item(4).Value.ToString
                MIubicacion.Text = Me.DataGridView1.CurrentRow.Cells.Item(5).Value.ToString
                MIclasificacion.Text = Me.DataGridView1.CurrentRow.Cells.Item(6).Value.ToString
                MIdescripcion.Text = Me.DataGridView1.CurrentRow.Cells.Item(7).Value.ToString
                MIsolucionProblema.Text = Me.DataGridView1.CurrentRow.Cells.Item(8).Value.ToString
                MIfechaInicio.Text = Me.DataGridView1.CurrentRow.Cells.Item(9).Value.ToString
                'MIfechaFinal.Text = Me.DataGridView1.CurrentRow.Cells.Item(10).Value.ToString

                MItxtTiempoInicio.Text = Me.DataGridView1.CurrentRow.Cells.Item(12).Value.ToString
                MIhoraAcumulada.Text = Me.DataGridView1.CurrentRow.Cells.Item(13).Value.ToString
                MIminutoAcumulado.Text = Me.DataGridView1.CurrentRow.Cells.Item(14).Value.ToString
                MIseleccion = Me.DataGridView1.CurrentRow.Cells.Item(14).Value.ToString

                MIvalorEditable = 1
                ' Indicadores_Editable.fecha_final.Text = Me.DataGridView1.CurrentRow.Cells.Item(5).Value.ToString
                'Almacena informacion para ser impresa




            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        datag()


    End Sub



    Private Sub DataGridView1_Sorted(sender As Object, e As EventArgs) Handles DataGridView1.Sorted
        prue()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        datacombobox()

    End Sub

#Region "ConfigDatagridview"


#Region "Indicadores en proceso"
    Sub datag()


#Region "Configuracion datagridview1"
        conectar()

        Dim conteo As String
        conteo = 1
#Region "Formato de letra"
        Me.DataGridView1.DefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)

#End Region
        ' Indicadores_Proceso.DataGridView1.RowTemplate.Height = 25
#Region "Cambios de color celdas y alternadas"
        Me.DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control)

#End Region
#Region "Personalizacion header"
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51)
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        'Me.DataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(218, 218, 218)
        Me.DataGridView1.RowsDefaultCellStyle.SelectionForeColor = Color.Black

        Me.DataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 51, 51)

        'formulario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

#End Region
#Region "Alineacion de titulos"
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
#End Region
#Region "Buscar casos abiertos"

        Dim tabla As DataGridView = DataGridView1
        Dim adaptador As New SqlDataAdapter("select*from Indicadores1 where Estado=" & conteo & "", cn)
        Dim dataS As New DataSet
        adaptador.Fill(dataS, "Indicadores1")

        tabla.DataSource = dataS.Tables("Indicadores1")

#End Region


#Region "Configuracion tabla"



        tabla.RowHeadersVisible = False
        tabla.Columns.Item(0).Visible = False
        tabla.Columns.Item(7).Visible = False
        tabla.Columns.Item(8).Visible = False
        tabla.Columns.Item(10).Visible = False
        tabla.Columns.Item(11).Visible = False
        tabla.Columns.Item(12).Visible = False
        tabla.Columns.Item(13).Visible = False
        tabla.Columns.Item(14).Visible = False
        tabla.Columns.Item(15).Visible = False

        tabla.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        tabla.Columns(1).Width = 380
        tabla.Columns(2).Width = 150
        tabla.Columns(3).Width = 150
        tabla.Columns(4).Width = 100
        tabla.Columns(5).Width = 170
        tabla.Columns(6).Width = 150
        tabla.Columns(9).DefaultCellStyle.Format = "MM/dd/yyyy"

        For Each r As DataGridViewRow In DataGridView1.Rows
            If r.Cells("Seleccion").Value = "1" Then
                r.DefaultCellStyle.BackColor = Color.Green

            End If
        Next
#End Region
#End Region



#Region "Conteo de casos abiertos"

        Me.Label1.Visible = True
        Me.Label1.Text = "Casos pendientes: " & tabla.RowCount
        Me.conteo_total = tabla.RowCount
#End Region
    End Sub

    Sub prue()
#Region "Configuracion datagridview1"

        Dim conteo As String
        conteo = 1
#Region "Formato de letra"
        Me.DataGridView1.DefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)

#End Region
        '  DataGridView1.RowTemplate.Height = 50
#Region "Cambios de color celdas y alternadas"
        Me.DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control)

#End Region
#Region "Personalizacion header"
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51)
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.DataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(218, 218, 218)
        Me.DataGridView1.RowsDefaultCellStyle.SelectionForeColor = Color.Black

        Me.DataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 51, 51)

        'formulario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

#End Region
#Region "Alineacion de titulos"
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
#End Region


        Dim tabla As DataGridView = Me.DataGridView1



#Region "Configuracion tabla"



        tabla.RowHeadersVisible = False
        tabla.Columns.Item(0).Visible = False
        tabla.Columns.Item(7).Visible = False
        tabla.Columns.Item(8).Visible = False
        tabla.Columns.Item(10).Visible = False
        tabla.Columns.Item(11).Visible = False
        tabla.Columns.Item(12).Visible = False
        tabla.Columns.Item(13).Visible = False
        tabla.Columns.Item(14).Visible = False
        tabla.Columns.Item(15).Visible = False

        tabla.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        tabla.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        tabla.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        tabla.Columns(1).Width = 380
        tabla.Columns(2).Width = 240
        tabla.Columns(3).Width = 170
        tabla.Columns(4).Width = 450
        tabla.Columns(9).DefaultCellStyle.Format = "MM/dd/yyyy"
        tabla.Columns(5).Width = 140


        For Each r As DataGridViewRow In Me.DataGridView1.Rows
            If r.Cells("Seleccion").Value = "1" Then
                r.DefaultCellStyle.BackColor = Color.Green

            End If
        Next
#End Region
#End Region



#Region "Conteo de casos abiertos"

        Me.Label1.Visible = True
        Me.Label1.Text = "Casos pendientes: " & tabla.RowCount
        Me.conteo_total = tabla.RowCount
#End Region
    End Sub

#End Region

    Sub datacombobox()





#Region "Configuracion datagridview1"
        conectar()

        Dim conteo As String
        conteo = 1
#Region "Formato de letra"
        Me.DataGridView1.DefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)

#End Region
        ' Indicadores_Proceso.DataGridView1.RowTemplate.Height = 25
#Region "Cambios de color celdas y alternadas"
        Me.DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control)

#End Region
#Region "Personalizacion header"
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51)
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.DataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(218, 218, 218)
        Me.DataGridView1.RowsDefaultCellStyle.SelectionForeColor = Color.Black

        Me.DataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 51, 51)

        'formulario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

#End Region
#Region "Alineacion de titulos"
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
#End Region
#Region "Buscar casos abiertos"

        Dim tabla As DataGridView = Me.DataGridView1
        Dim adaptador As New SqlDataAdapter("select*from Indicadores where Estado=" & conteo & "and convert(char,Clasificacion)=" & "'" & Me.Clasificacion.Text & "'" & "", cn)
        Dim dataS As New DataSet
        adaptador.Fill(dataS, "Indicadores")

        tabla.DataSource = dataS.Tables("Indicadores")

#End Region


#Region "Configuracion tabla"



        tabla.RowHeadersVisible = False
        tabla.Columns.Item(6).Visible = False
        tabla.Columns.Item(7).Visible = False
        tabla.Columns.Item(0).Visible = False
        tabla.Columns.Item(11).Visible = False


        tabla.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        tabla.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        tabla.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        tabla.Columns(1).Width = 380
        tabla.Columns(2).Width = 240
        tabla.Columns(3).Width = 170
        tabla.Columns(4).Width = 450
        tabla.Columns(5).DefaultCellStyle.Format = "MM/dd/yyyy"
        tabla.Columns(5).Width = 140


        For Each r As DataGridViewRow In Me.DataGridView1.Rows
            If r.Cells("Seleccion").Value = "1" Then
                r.DefaultCellStyle.BackColor = Color.Green

            End If
        Next
#End Region
#End Region



#Region "Conteo de casos abiertos"

        Me.Label1.Visible = True
        Me.Label1.Text = "Casos pendientes: " & tabla.RowCount
        Me.conteo_total = tabla.RowCount
#End Region


    End Sub

    Private Sub Clasificacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Clasificacion.SelectedIndexChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim segundo As Integer

        segundo = segundo + 1

        If segundo = 1 Then

            Timer1.Stop()
            datag()

        End If
    End Sub






#End Region
End Class
Imports System.Data.SqlClient

Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Imports System.Data
Public Class Pendiente_Preventivos

    Dim conteo As Integer
    Dim i As Integer = 0



    Private Sub Pendiente_Preventivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not formularios.Contains(Me) Then formularios.Add(Me) 'Agrega a la lista los formularios para luego cerrarlos
        tipobusqueda.SelectedIndex = 0
        Clase.SelectedIndex = 0
        general()
    End Sub

    Private Sub tipobusqueda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tipobusqueda.SelectedIndexChanged
        Select Case tipobusqueda.Text

            Case "Mostrar Año"
                Clase.Visible = True
                Clase.DataSource = Nothing
                Clase.Items.Clear()
                Clase.Items.Add("General")
                Clase.Items.Add("Clase")



            Case "Mostrar Mes"
                Clase.Visible = True
                equipos.Visible = False

#Region "Cargar datos en combobox de los Meses"
                Try
                    Dim cmd As String = "select*from Meses_Datos"
                    Dim da As New SqlDataAdapter(cmd, cn)
                    Dim ds As New DataSet
                    da.Fill(ds)
                    With Me.Clase
                        Me.Clase.DataSource = ds.Tables(0)
                        Me.Clase.DisplayMember = "Meses"
                    End With
                    cn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
#End Region
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

            Case "General"
                equipos.Visible = False

        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Select Case Clase.Text


            Case "Clase"




            Case "General"
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

        'formulario.DefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)
        'formulario.ColumnHeadersDefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)

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
        Dim adaptador As New SqlDataAdapter("select carac.codigo, carac.clase as Equipos,  case when Enero =9999 then 'N/A' when Enero=0 then 'Finalizado'  when Enero=Enero then CONVERT(char(3),Enero)end Enero, case when Febrero =9999 then 'N/A' when Febrero=0 then 'Finalizado'  when Febrero=Febrero then CONVERT(char(3),Febrero)end Febrero,case when Marzo =9999 then 'N/A' when Marzo=0 then 'Finalizado'   when Marzo=Marzo then CONVERT(char(3),Marzo)end Marzo,case when Abril =9999 then 'N/A' when Abril=0 then 'Finalizado'  when Abril=Abril then CONVERT(char(3),Abril)end Abril,case when Mayo =9999 then 'N/A'  when Mayo=0 then 'Finalizado'  when Mayo=Mayo then CONVERT(char(3),Mayo)end Mayo,case when Junio =9999 then 'N/A'  when Junio=0 then 'Finalizado'  when Junio=Junio then CONVERT(char(3),Junio)end Junio,case when Julio =9999 then 'N/A'  when Julio=0 then 'Finalizado'  when Julio=Julio then CONVERT(char(3),Julio)end Julio,case when Agosto =9999 then 'N/A'  when Agosto=0 then 'Finalizado'  when Agosto=Agosto then CONVERT(char(3),Agosto)end Agosto,case when Septiembre =9999 then 'N/A'  when Septiembre=0 then 'Finalizado'  when Septiembre=Septiembre then CONVERT(char(3),Septiembre)end Septiembre,case when Octubre =9999 then 'N/A'  when Octubre=0 then 'Finalizado'  when Octubre=0 then 'Finalizado' when Octubre=Octubre then CONVERT(char(3),Octubre)end Octubre,case when Noviembre =9999 then 'N/A'  when Noviembre=0 then 'Finalizado'  when Noviembre=Noviembre then CONVERT(char(3),Noviembre)end Noviembre,case when Diciembre =9999 then 'N/A'  when Diciembre=0 then 'Finalizado'  when Diciembre=Diciembre then CONVERT(char(3),Diciembre)end Diciembre from Caracteristicas_Equipo carac,ConteoPlanificacion_Equipos plani where Año='2020' and plani.Codigo=carac.Codigo", cn)
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


    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        'funcion para obtener el tamaño de la columnas del datagridview
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1

            If i = 0 Then
                i = 1
            End If
            If i = 1 Then
                values(i) = CSng(200)
            ElseIf i = 12 Then
                values(i) = CSng(160)

            ElseIf i = 13 Then
                values(i) = CSng(160)
            Else
                values(i) = CSng(160)
                'values(i) = CSng(dg.Columns(i).Width)
            End If







        Next
        Return values
    End Function
    Public Sub ExportarDatosPDF(ByVal document As Document)
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView.
        Dim datatable As New PdfPTable(DataGridView1.ColumnCount)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(DataGridView1)
        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
        'Se crea el encabezado en el PDF.
        Dim encabezado As New Paragraph("Mantenimiento Preventivo 2020", New Font(Font.Name = "Tahoma", 20, Font.Bold))

        'Se crea el texto abajo del encabezado.
        Dim texto As New Phrase("Reporte de mantenimiento generado el: " + Now.Date(), New Font(Font.Name = "Tahoma", 14, Font.Bold))
        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To DataGridView1.ColumnCount - 1
            datatable.AddCell(DataGridView1.Columns(i).HeaderText)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To DataGridView1.RowCount - 1
            For j As Integer = 0 To DataGridView1.ColumnCount - 1
                datatable.AddCell(DataGridView1(j, i).Value.ToString())
            Next
            datatable.CompleteRow()
        Next
        'Se agrega el PDFTable al documento.
        document.Add(encabezado)
        document.Add(texto)
        document.Add(datatable)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try


            'Intentar generar el documento.
            Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\Registro Anual.pdf"

            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF(doc)
            doc.Close()
            Process.Start(filename)

        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox.
            MessageBox.Show("No se puede generar el documento PDF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
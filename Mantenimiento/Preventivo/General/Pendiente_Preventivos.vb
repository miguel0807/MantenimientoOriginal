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
        generalaño()
    End Sub

    Private Sub tipobusqueda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tipobusqueda.SelectedIndexChanged
        Select Case tipobusqueda.Text

            Case "Mostrar Año"
                Clase.Visible = False
                Label3.Visible = False
                clases.Visible = False
                Label2.Visible = False

                Clase.DataSource = Nothing
                Clase.Items.Clear()
                Clase.Items.Add("General")
                Clase.Items.Add("Clase")
                Clase.Visible = False


            Case "Mostrar Mes"
                Label3.Visible = True
                Clase.Visible = True
                clases.Visible = False
                Label3.Text = "Seleccione el mes"

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

            Case "Clase"
                Clase.Visible = True
                Label3.Visible = True
                Label3.Text = "Seleccione el equipo"
                clases.SelectedIndex = -1


#Region "Cargar datos en combobox de Ubicacion"
                Try
                    Dim cmd As String = "select*from Caracteristicas_Equipo"
                    Dim da As New SqlDataAdapter(cmd, cn)
                    Dim ds As New DataSet
                    da.Fill(ds)
                    With Me.Clase
                        Me.Clase.DataSource = ds.Tables(0)
                        Me.Clase.DisplayMember = "Clase"
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


        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Select Case tipobusqueda.Text


            Case "Mostrar Año"
                generalaño()



            Case "Mostrar Mes"

                generalmes()

            Case "Clase"
                busqueda_clase()
        End Select
    End Sub


    Sub generalaño()



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
        formulario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
#End Region
#End Region

#Region "Buscar la planificacion"

        Dim tabla As DataGridView = Me.DataGridView1

        ' Dim adaptador As New SqlDataAdapter("select carac.codigo, carac.clase as Equipos,  case when Enero =9999 then 'N/A' when Enero=Enero then CONVERT(char(3),Enero)end Enero, case when Febrero =9999 then 'N/A' when Febrero=Febrero then CONVERT(char(3),Febrero)end Febrero,case when Marzo =9999 then 'N/A'when Marzo=Marzo then CONVERT(char(3),Marzo)end Marzo,case when Abril =9999 then 'N/A'when Abril=Abril then CONVERT(char(3),Abril)end Abril,case when Mayo =9999 then 'N/A' when Mayo=Mayo then CONVERT(char(3),Mayo)end Mayo,case when Junio =9999 then 'N/A' when Junio=Junio then CONVERT(char(3),Junio)end Junio,case when Julio =9999 then 'N/A' when Julio=Julio then CONVERT(char(3),Julio)end Julio,case when Agosto =9999 then 'N/A' when Agosto=Agosto then CONVERT(char(3),Agosto)end Agosto,case when Septiembre =9999 then 'N/A' when Septiembre=Septiembre then CONVERT(char(3),Septiembre)end Septiembre,case when Octubre =9999 then 'N/A' when Octubre=Octubre then CONVERT(char(3),Octubre)end Octubre,case when Noviembre =9999 then 'N/A' when Noviembre=Noviembre then CONVERT(char(3),Noviembre)end Noviembre,case when Diciembre =9999 then 'N/A' when Diciembre=Diciembre then CONVERT(char(3),Diciembre)end Diciembre from Caracteristicas_Equipo carac,ConteoPlanificacion_Equipos plani where Año='2020' and plani.Codigo=carac.Codigo ", cn)
        '  Dim columncheck As New DataGridViewCheckBoxColumn
        ' columncheck.HeaderText = "Prueba"
        ' columncheck.Name = "cerrar"

        Dim adaptador As New SqlDataAdapter("select carac.codigo, carac.clase as Equipos,  case when Enero =9999 then 'N/A' when Enero=0 then 'Finalizado'  when Enero=Enero then CONVERT(char(3),Enero)end Enero, case when Febrero =9999 then 'N/A' when Febrero=0 then 'Finalizado'  when Febrero=Febrero then CONVERT(char(3),Febrero)end Febrero,case when Marzo =9999 then 'N/A' when Marzo=0 then 'Finalizado'   when Marzo=Marzo then CONVERT(char(3),Marzo)end Marzo,case when Abril =9999 then 'N/A' when Abril=0 then 'Finalizado'  when Abril=Abril then CONVERT(char(3),Abril)end Abril,case when Mayo =9999 then 'N/A'  when Mayo=0 then 'Finalizado'  when Mayo=Mayo then CONVERT(char(3),Mayo)end Mayo,case when Junio =9999 then 'N/A'  when Junio=0 then 'Finalizado'  when Junio=Junio then CONVERT(char(3),Junio)end Junio,case when Julio =9999 then 'N/A'  when Julio=0 then 'Finalizado'  when Julio=Julio then CONVERT(char(3),Julio)end Julio,case when Agosto =9999 then 'N/A'  when Agosto=0 then 'Finalizado'  when Agosto=Agosto then CONVERT(char(3),Agosto)end Agosto,case when Septiembre =9999 then 'N/A'  when Septiembre=0 then 'Finalizado'  when Septiembre=Septiembre then CONVERT(char(3),Septiembre)end Septiembre,case when Octubre =9999 then 'N/A'  when Octubre=0 then 'Finalizado'  when Octubre=0 then 'Finalizado' when Octubre=Octubre then CONVERT(char(3),Octubre)end Octubre,case when Noviembre =9999 then 'N/A'  when Noviembre=0 then 'Finalizado'  when Noviembre=Noviembre then CONVERT(char(3),Noviembre)end Noviembre,case when Diciembre =9999 then 'N/A'  when Diciembre=0 then 'Finalizado'  when Diciembre=Diciembre then CONVERT(char(3),Diciembre)end Diciembre from Caracteristicas_Equipo carac,ConteoPlanificacion_Equipos plani where Año='" & Now.Date.Year & "' and plani.Codigo=carac.Codigo", cn)
        Dim dataS As New DataSet
        adaptador.Fill(dataS, "ConteoPlanificacion_Equipos")

        tabla.DataSource = dataS.Tables("ConteoPlanificacion_Equipos")

#End Region


#Region "Configuracion tabla"

        ' tabla.Columns.Add(columncheck)
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


        'tabla.Columns(2).Width = 110
        'tabla.Columns(3).Width = 110
        'tabla.Columns(4).Width = 110
        'tabla.Columns(5).Width = 110
        'tabla.Columns(6).Width = 110
        'tabla.Columns(7).Width = 110
        'tabla.Columns(8).Width = 110
        'tabla.Columns(9).Width = 110
        'tabla.Columns(10).Width = 110
        'tabla.Columns(11).Width = 110
        'tabla.Columns(12).Width = 110
        'tabla.Columns(13).Width = 110




#End Region


#Region "Conteo de cantidad de equipos"

        Me.Label1.Visible = True
        Me.Label1.Text = "Cantidad: " & tabla.RowCount
        Me.conteo = tabla.RowCount
#End Region



    End Sub
    Sub generalmes()



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
        formulario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
#End Region
#End Region

#Region "Buscar la planificacion"

        Dim tabla As DataGridView = Me.DataGridView1



        Dim adaptador As New SqlDataAdapter("select carac.codigo, carac.clase as Equipos,  case when " & Clase.Text & " =9999 then 'N/A' when " & Clase.Text & "=0 then 'Finalizado'  when " & Clase.Text & "=" & Clase.Text & " then CONVERT(char(3)," & Clase.Text & ")end " & Clase.Text & " from Caracteristicas_Equipo carac,ConteoPlanificacion_Equipos plani where Año='" & Date.Now.Year & "' and plani.Codigo=carac.Codigo", cn)
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




        tabla.Columns(1).Width = 225


        tabla.Columns(2).Width = 110





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
        Dim encabezado As New Paragraph("Mantenimiento Preventivo " & Date.Now.Year, New Font(Font.Name = "Tahoma", 20, Font.Bold))

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


    Sub busqueda_clase()
#Region "Configuracion datagridview1"
        conectar()
        Dim formulario As DataGridView = Me.DataGridView1
        Dim conteo As String
        conteo = 1

        '#Region "Formato de letra"

        '        formulario.DefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)
        '        formulario.ColumnHeadersDefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)

        '#End Region
        formulario.RowTemplate.Height = 25
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
        formulario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
#End Region

#Region "Buscar la clase espeficifica"

        Dim numero_clase As Integer
        Dim adaptador1 As New SqlDataAdapter("select Codigo from Caracteristicas_Equipo where convert(char,clase)='" & Me.Clase.Text & "'", cn)
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

    Private Sub clases_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clases.SelectedIndexChanged

    End Sub
End Class
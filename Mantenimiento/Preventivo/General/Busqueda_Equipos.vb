Imports System.Data.SqlClient

Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Imports System.Data
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
                    Dim cmd As String = "select*from Clasificación_Datos"
                    Dim da As New SqlDataAdapter(cmd, cn)
                    Dim ds As New DataSet
                    da.Fill(ds)
                    With Me.detalle
                        Me.detalle.DataSource = ds.Tables(0)
                        Me.detalle.DisplayMember = "Clasificación"
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

        Tipo.SelectedIndex = 0
    End Sub
#Region "Lista Equipos"


    Sub busqueda_equipos()

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
        formulario.RowsDefaultCellStyle.BackColor = Color.White
        formulario.AlternatingRowsDefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control)

#End Region
#Region "Personalizacion header"
        formulario.EnableHeadersVisualStyles = False
        formulario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51)
        formulario.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        formulario.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(218, 218, 218)
        formulario.RowsDefaultCellStyle.SelectionForeColor = Color.Black

        formulario.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 51, 51)

        'formulario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

#End Region
#Region "Alineacion de titulos"
        formulario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
#End Region
#Region "Buscar todos los equipos"

        Dim tabla As DataGridView = Me.DataGridView1
        Dim adaptador As New SqlDataAdapter("SELECT Lista_Equipos.Etiqueta,Lista_Equipos.Información,Caracteristicas_Equipo.Clase,Lista_Equipos.Ubicación from Lista_Equipos,Caracteristicas_Equipo where Lista_Equipos.Codigo=Caracteristicas_Equipo.Codigo", cn)
        Dim dataS As New DataSet
        adaptador.Fill(dataS, "Lista_Equipos")

        tabla.DataSource = dataS.Tables("Lista_Equipos")

#End Region


#Region "Configuracion tabla"



        tabla.RowHeadersVisible = False




        tabla.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tabla.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        tabla.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


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
        formulario.RowsDefaultCellStyle.BackColor = Color.White
        formulario.AlternatingRowsDefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control)

#End Region
#Region "Personalizacion header"
        formulario.EnableHeadersVisualStyles = False
        formulario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51)
        formulario.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        formulario.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(218, 218, 218)
        formulario.RowsDefaultCellStyle.SelectionForeColor = Color.Black

        formulario.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 51, 51)

        'formulario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

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

    Sub busqueda_clasificacion()
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
        formulario.RowsDefaultCellStyle.BackColor = Color.White
        formulario.AlternatingRowsDefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control)

#End Region
#Region "Personalizacion header"
        formulario.EnableHeadersVisualStyles = False
        formulario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51)
        formulario.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        formulario.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(218, 218, 218)
        formulario.RowsDefaultCellStyle.SelectionForeColor = Color.Black

        formulario.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 51, 51)

        'formulario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

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


        'tabla.Columns(1).Width = 380
        'tabla.Columns(2).Width = 240
        ''tabla.Columns(3).Width = 170



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

        '#Region "Formato de letra"

        '        formulario.DefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)
        '        formulario.ColumnHeadersDefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)

        '#End Region
        formulario.RowTemplate.Height = 25

#Region "Cambios de color celdas y alternadas"
        formulario.RowsDefaultCellStyle.BackColor = Color.White
        formulario.AlternatingRowsDefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control)

#End Region
#Region "Personalizacion header"
        formulario.EnableHeadersVisualStyles = False
        formulario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51)
        formulario.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        formulario.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(218, 218, 218)
        formulario.RowsDefaultCellStyle.SelectionForeColor = Color.Black

        formulario.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 51, 51)

        'formulario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

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

        'tabla.Columns(0).Width = 380
        'tabla.Columns(1).Width = 300
        'tabla.Columns(2).Width = 380




#End Region
#End Region

#Region "Conteo de cantidad de equipos"

        Me.Label1.Visible = True
        Me.Label1.Text = "Cantidad: " & tabla.RowCount
        Me.conteo = tabla.RowCount
#End Region
    End Sub




#End Region


    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        'funcion para obtener el tamaño de la columnas del datagridview
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1

            If i = 0 Then
                i = 1
            End If
            If i = 10 Then
                values(i) = CSng(160)
            ElseIf i = 12 Then
                values(i) = CSng(160)

            ElseIf i = 13 Then
                values(i) = CSng(160)
            Else

                values(i) = CSng(dg.Columns(i).Width)
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
        Dim encabezado As New Paragraph("Mantenimiento Preventivo " + Now.Year.ToString, New Font(Font.Name = "Tahoma", 20, Font.Bold))

        'Se crea el texto abajo del encabezado.
        Dim texto As New Phrase("Lista de equipos de " + detalle.Text + " generada el: " + Now.Date(), New Font(Font.Name = "Tahoma", 14, Font.Bold))
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try


            'Intentar generar el documento.
            Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\Registro Equipos.pdf"

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

    Private Sub detalle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles detalle.SelectedIndexChanged

    End Sub
End Class
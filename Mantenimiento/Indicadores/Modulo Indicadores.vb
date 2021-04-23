Imports System.IO
Imports System.Data
Imports System.Reflection
Imports ClosedXML.Excel
Imports System.Data.SqlClient



Module Modulo_Indicadores
    Public datagridIndicadores As DataGridView

    Public Conteo3 As Integer
    Public EtiquetaConteo As Label
    Public MItxtTiempoInicio As TextBox
    Public MItxtTiempoFinal As TextBox
    Public MIminutoAcumulado As TextBox
    Public MIhoraAcumulada As TextBox



    Public MItitulo As TextBox
    Public MIubicacion As TextBox
    Public MIclasificacion As ComboBox
    Public MIfechaInicio As TextBox
    Public MIfechaFinal As TextBox
    Public MIdescripcion As TextBox


    Public MIseleccion As Integer = 0






    Sub cargarIndicadores()
#Region "Buscar casos abiertos"
        conectar()
        Dim tabla As DataGridView = datagridIndicadores
        Dim adaptador As New SqlDataAdapter("select Nombre, Ubicacion as 'Ubicación',
        Clasificacion as 'Clasificación', Descripcion as 'Descripción',[Fecha Inicial] as 'Fecha Inicial',
        [Fecha Final] as 'Fecha Final', Horas,Minutos from Indicadores", cn)
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
    Sub CargarEtiquetas()
        Try
            conectar()

            Dim Query As String
            Query = ("select COUNT (Estado) from Indicadores")
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

#End Region

#Region "Cargar Pendiente"

    Sub Pendiente()

        Try
            If MItitulo.Text = "" Or MIfechaInicio.Text = "" Then
                MsgBox("Necesita completar problema y fecha de inicio")
            Else


                If MitxtTiempoInicio.Text = "00:00:00" Then
                    MIseleccion = 0
                ElseIf mitxtTiempoInicio.Text = "" Then
                    MIseleccion = 0
                Else

                    MIseleccion = 1
                End If
                Dim adaptador As New SqlCommand("insert into Indicadores values (" & Conteo3 & ",'" & MItitulo.Text & "','" & MIubicacion.Text & "','" & MIclasificacion.Text & "','" & MIdescripcion.Text & "','" & MIfechaInicio.Text & "','" & MIfechaFinal.Text & "'," & 1 & ",'" & MItxtTiempoInicio.Text & "'," & MIhoraAcumulada.Text & "," & MIminutoAcumulado.Text & "," & MIseleccion & ")", cn)
                conectar()
                adaptador.ExecuteNonQuery()
                MsgBox("Se registro correctamente")
                desconectar()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
End Module

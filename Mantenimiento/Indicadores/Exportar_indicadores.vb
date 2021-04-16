Imports System.IO
Imports System.Data
Imports System.Reflection
Imports ClosedXML.Excel
Imports System.Data.SqlClient




Public Class Exportar_indicadores
    Public eliminar22 As String




    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click



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
        For Each column As DataGridViewColumn In dataGridView1.Columns
            dt.Columns.Add(column.HeaderText, column.ValueType)
        Next

        'Adding the Rows
        For Each row As DataGridViewRow In dataGridView1.Rows
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
#Region "Buscar casos abiertos"
        conectar()
        Dim tabla As DataGridView = dataGridView1
        Dim adaptador As New SqlDataAdapter("select Nombre, Ubicacion as 'Ubicación',
        Clasificacion as 'Clasificación', Descripcion as 'Descripción',[Fecha Inicial] as 'Fecha Inicial',
        [Fecha Final] as 'Fecha Final', Horas,Minutos from Indicadores", cn)
        Dim dataS As New DataSet
        adaptador.Fill(dataS, "Indicadores")

        tabla.DataSource = dataS.Tables("Indicadores")
        desconectar()



#Region "Formato de letra"
        Me.dataGridView1.DefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)
        Me.dataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)

#End Region
        '  DataGridView1.RowTemplate.Height = 50
#Region "Cambios de color celdas y alternadas"
        Me.dataGridView1.RowsDefaultCellStyle.BackColor = Color.White
        Me.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control)

#End Region
#Region "Personalizacion header"
        Me.dataGridView1.EnableHeadersVisualStyles = False
        Me.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51)
        Me.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(218, 218, 218)
        Me.dataGridView1.RowsDefaultCellStyle.SelectionForeColor = Color.Black

        Me.dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 51, 51)

        'formulario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

#End Region
#Region "Alineacion de titulos"
        Me.dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
#End Region
        tabla.RowHeadersVisible = False
#End Region
    End Sub



End Class

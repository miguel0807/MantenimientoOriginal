Imports System.IO
Imports System.Data
Imports System.Reflection
Imports ClosedXML.Excel
Imports System.Data.SqlClient

Public Class Exportar_indicadores

    Public Sub New()
        InitializeComponent()

    End Sub



    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
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
        Dim folderPath As String = "C:\Excel\"
        If Not Directory.Exists(folderPath) Then
            Directory.CreateDirectory(folderPath)
        End If
        Using wb As New XLWorkbook()
            wb.Worksheets.Add(dt, "Datos")
            wb.SaveAs(folderPath & Convert.ToString("DataGridViewExport.xlsx"))
        End Using
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "Buscar casos abiertos"
        conectar()
        Dim tabla As DataGridView = dataGridView1
        Dim adaptador As New SqlDataAdapter("select*from Indicadores", cn)
        Dim dataS As New DataSet
        adaptador.Fill(dataS, "Indicadores")

        tabla.DataSource = dataS.Tables("Indicadores")
        desconectar()
    End Sub
#End Region
End Class

Imports System.IO
Imports System.Data
Imports System.Reflection
Imports ClosedXML.Excel

Public Class Form1

    Public Sub New()
        InitializeComponent()
        Me.BindDataGridView()
    End Sub

    Private Sub BindDataGridView()
        Dim dt As New DataTable()
        dt.Columns.AddRange(New DataColumn(2) {New DataColumn("Id", GetType(Integer)), New DataColumn("Name", GetType(String)), New DataColumn("Country", GetType(String))})
        dt.Rows.Add(1, "John Hammond", "United States")
        dt.Rows.Add(2, "Mudassar Khan", "India")
        dt.Rows.Add(3, "Suzanne Mathews", "France")
        dt.Rows.Add(4, "Robert Schidner", "Russia")
        Me.dataGridView1.DataSource = dt
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
            wb.Worksheets.Add(dt, "Customers")
            wb.SaveAs(folderPath & Convert.ToString("DataGridViewExport.xlsx"))
        End Using
    End Sub
End Class

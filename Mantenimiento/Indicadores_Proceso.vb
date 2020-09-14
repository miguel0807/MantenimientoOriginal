Imports System.Data.SqlClient
Public Class Indicadores_Proceso
    Public conteo_total As Integer
    Private Sub Indicadores_Proceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conectar()

            Dim conteo As String
            conteo = 1



            Dim tabla As DataGridView = DataGridView1
            Dim adaptador As New SqlDataAdapter("select*from Indicadores where Estado=" & conteo & "", cn)
            Dim dataS As New DataSet
            adaptador.Fill(dataS, "Indicadores")

            tabla.DataSource = dataS.Tables("Indicadores")
            tabla.RowHeadersVisible = False
            tabla.Columns.Item(6).Visible = False
            tabla.Columns.Item(7).Visible = False
            tabla.Columns.Item(0).Visible = False



            tabla.Columns(1).Width = 200
            tabla.Columns(2).Width = 130
            tabla.Columns(3).Width = 170
            tabla.Columns(4).Width = 267
            tabla.Columns(5).DefaultCellStyle.Format = "yyyy/MM/dd"
            tabla.Columns(5).Width = 100

            'Habilita conteo de filas en datagridview
            Label1.Visible = True
            ' Label8.Text = tabla.DisplayedRowCount(0) - 1
            Label1.Text = "Casos pendientes: " & tabla.RowCount
            conteo_total = tabla.RowCount

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If conteo_total <= 0 Then
                MsgBox("No hay casos pendientes")
            Else
                Indicadores_Editable.Show()


                Me.DataGridView1.Select() 'Seleccionar primera fila del datagridview



                'Almacena informacion para ser impresa
                Indicadores_Editable.Caso = Me.DataGridView1.CurrentRow.Cells.Item(0).Value.ToString
                Indicadores_Editable.Nombre.Text = Me.DataGridView1.CurrentRow.Cells.Item(1).Value.ToString
                Indicadores_Editable.Ubicacion.Text = Me.DataGridView1.CurrentRow.Cells.Item(2).Value.ToString
                Indicadores_Editable.Clasificacion.Text = Me.DataGridView1.CurrentRow.Cells.Item(3).Value.ToString
                Indicadores_Editable.Descripcion.Text = Me.DataGridView1.CurrentRow.Cells.Item(4).Value.ToString
                Indicadores_Editable.Fecha.Text = Me.DataGridView1.CurrentRow.Cells.Item(5).Value.ToString

                Indicadores_Editable.Tiempo_Inicio.Text = Me.DataGridView1.CurrentRow.Cells.Item(8).Value.ToString
                Indicadores_Editable.acuhora.Text = Me.DataGridView1.CurrentRow.Cells.Item(9).Value.ToString
                Indicadores_Editable.acuminutos.Text = Me.DataGridView1.CurrentRow.Cells.Item(10).Value.ToString
                ' Indicadores_Editable.fecha_final.Text = Me.DataGridView1.CurrentRow.Cells.Item(5).Value.ToString
                'Almacena informacion para ser impresa




            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            conectar()

            Dim etiqueta As String
            etiqueta = 1



            Dim tabla As DataGridView = DataGridView1
            Dim adaptador As New SqlDataAdapter("select*from Indicadores where Estado=" & etiqueta & "", cn)
            Dim dataS As New DataSet
            adaptador.Fill(dataS, "Indicadores")

            tabla.DataSource = dataS.Tables("Indicadores")
            tabla.RowHeadersVisible = False
            tabla.Columns.Item(6).Visible = False
            tabla.Columns.Item(7).Visible = False
            tabla.Columns.Item(0).Visible = False



            tabla.Columns(1).Width = 200
            tabla.Columns(2).Width = 130
            tabla.Columns(3).Width = 170
            tabla.Columns(4).Width = 267
            tabla.Columns(5).Width = 100

            'Habilita conteo de filas en datagridview
            Label1.Visible = True
            ' Label8.Text = tabla.DisplayedRowCount(0) - 1
            Label1.Text = "Casos pendientes: " & tabla.RowCount
            conteo_total = tabla.RowCount
            desconectar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
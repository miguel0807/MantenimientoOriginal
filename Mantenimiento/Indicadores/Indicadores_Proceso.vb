Imports System.Data.SqlClient
Public Class Indicadores_Proceso
    Public conteo_total As Integer
    Private Sub Indicadores_Proceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        datag()




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
                Indicadores_Editable.txtacuhora.Text = Me.DataGridView1.CurrentRow.Cells.Item(9).Value.ToString
                Indicadores_Editable.txtacuminutos.Text = Me.DataGridView1.CurrentRow.Cells.Item(10).Value.ToString
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_Sorted(sender As Object, e As EventArgs) Handles DataGridView1.Sorted
        prue()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        datamiguel()
    End Sub
End Class
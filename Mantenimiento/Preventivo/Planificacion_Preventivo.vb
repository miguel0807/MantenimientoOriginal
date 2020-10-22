Public Class Planificacion_Preventivo
    Public conteo As Integer


    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tipobusqueda.SelectedIndexChanged
        Select Case tipobusqueda.Text

            Case "General"

                año.Visible = True
                mes.Visible = False
                Label2.Visible = False
                clase.Visible = False
                detalle_equipo.Visible = False
                Configuracion_Año()

            Case "Especifico"
                año.Visible = True
                mes.Visible = True
                Label2.Visible = True
                clase.Visible = True
                detalle_equipo.Visible = True
                Configuracion_Año()
                Configuracion_Mes()

        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Select Case tipobusqueda.Text

            Case "General"

                detalle_equipo.Visible = False

                general()
            Case "Especifico"



        End Select
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        agregar_Planificacion()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        codigo = DataGridView1.CurrentRow.Cells.Item(0).Value.ToString

        columna = (String.Format("{0}", e.ColumnIndex))

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Eliminar_Planificacion()
    End Sub
End Class
Public Class Preventivo_Busqueda
    Private Sub Tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tipo.SelectedIndexChanged
        Select Case Tipo.Text
            Case "Mensual"
                detalle.Items.Clear()
                detalle.Items.Add("Enero")
                detalle.Items.Add("Febrero")
                detalle.Items.Add("Marzo")
                detalle.Items.Add("Abril")
                detalle.Items.Add("Mayo")
                detalle.Items.Add("Junio")
                detalle.Items.Add("Julio")
                detalle.Items.Add("Agosto")
                detalle.Items.Add("Septiembre")
                detalle.Items.Add("Octubre")
                detalle.Items.Add("Noviembre")
                detalle.Items.Add("Diciembre")

            Case "Equipo"

                detalle.Items.Clear()
                detalle.Items.Add("N/A")

            Case "Clasificacion"
                detalle.Items.Clear()
                detalle.Items.Add("Electrico")
                detalle.Items.Add("Mecanico")
                detalle.Items.Add("Neumatico")
                detalle.Items.Add("Electro-Mecanico")
                detalle.Items.Add("Mecanico-Neumatico")

            Case "Frecuencia"
                detalle.Items.Clear()
                detalle.Items.Add("Diario")
                detalle.Items.Add("Semanal")
                detalle.Items.Add("Mensual")
                detalle.Items.Add("Trimestral")
                detalle.Items.Add("Anual")

            Case "Provedor"
                detalle.Items.Clear()
                detalle.Items.Add("N/A")




        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class
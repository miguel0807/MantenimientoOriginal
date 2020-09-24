Public Class Presentacion




    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Indicadores_Nuevo.BringToFront()
        Indicadores_Nuevo.WindowState = FormWindowState.Normal
        Indicadores_Nuevo.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Indicadores_Proceso.BringToFront()
        Indicadores_Proceso.WindowState = FormWindowState.Maximized

        Indicadores_Proceso.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        MaterialNuevo.BringToFront()
        MaterialNuevo.WindowState = FormWindowState.Normal
        MaterialNuevo.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Busqueda_Material.BringToFront()
        Busqueda_Material.WindowState = FormWindowState.Maximized
        Busqueda_Material.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)


    End Sub
End Class
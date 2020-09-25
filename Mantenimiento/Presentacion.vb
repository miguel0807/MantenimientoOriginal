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





    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick


        Me.Show()
        Me.WindowState = FormWindowState.Normal
        Me.BringToFront()
    End Sub

    Private Sub Presentacion_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If (Me.WindowState = FormWindowState.Minimized) Then

            ' Me.Hide()

            ' Me.NotifyIcon1.BalloonTipText = "Controlador de casos en segundo plano"
            'Me.NotifyIcon1.ShowBalloonTip(2000)
        End If
    End Sub



    Private Sub BusquedaDeMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BusquedaDeMaterialToolStripMenuItem.Click
        Busqueda_Material.BringToFront()
        Busqueda_Material.WindowState = FormWindowState.Maximized
        Busqueda_Material.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Indicadores_Proceso.BringToFront()
        Indicadores_Proceso.WindowState = FormWindowState.Maximized

        Indicadores_Proceso.Show()
    End Sub

    Private Sub RegistrarNuevoCasoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarNuevoCasoToolStripMenuItem.Click
        Indicadores_Nuevo.BringToFront()
        Indicadores_Nuevo.WindowState = FormWindowState.Normal
        Indicadores_Nuevo.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        MaterialNuevo.BringToFront()
        MaterialNuevo.WindowState = FormWindowState.Normal
        MaterialNuevo.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Preventivo.Show()
    End Sub
End Class
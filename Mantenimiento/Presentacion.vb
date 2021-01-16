

Public Class Presentacion

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubmenu()


    End Sub

    Private Sub hideSubmenu()

        PanelMediaSubmenu.Visible = False
        PanelPlaylistSubmenu.Visible = False
        PanelToolsSubmenu.Visible = False
        PanelToolsSubConfiguration.Visible = False

    End Sub

    Private Sub showSubmenu(submenu As Panel)

        If submenu.Visible = False Then
            hideSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If

    End Sub

    Private Sub btnMedia_Click(sender As Object, e As EventArgs) Handles btnMedia.Click
        showSubmenu(PanelMediaSubmenu)
    End Sub

    Private Sub btnPlaylist_Click(sender As Object, e As EventArgs) Handles btnPlaylist.Click
        showSubmenu(PanelPlaylistSubmenu)
    End Sub

    Private Sub btnTools_Click(sender As Object, e As EventArgs) Handles btnTools.Click
        showSubmenu(PanelToolsSubmenu)
        PanelToolsSubmenu.Size = New Size(229, 400)


    End Sub

#Region "Botones Indicadores"
    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click

        openChildForm(New Indicadores_Nuevo())

        hideSubmenu()

    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        openChildForm(New Indicadores_Proceso())

        hideSubmenu()


    End Sub


#End Region

#Region "Botones Control de inventario"
    Private Sub button8_Click(sender As Object, e As EventArgs) Handles button8.Click
        openChildForm(New MaterialNuevo())

        hideSubmenu()
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        openChildForm(New Busqueda_Material())

        hideSubmenu()
    End Sub

#End Region
#Region "Botones Mantenimiento Preventivo"

    Private Sub button13_Click(sender As Object, e As EventArgs) Handles button13.Click
        openChildForm(New Busqueda_Equipos())

        hideSubmenu()
    End Sub
    Private Sub button12_Click(sender As Object, e As EventArgs) Handles button12.Click
        openChildForm(New BusquedaPlanificacion_Preventivo())




    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        openChildForm(New NuevoProvedor_Preventivo())
        hideSubmenu()
    End Sub

    Private Sub button10_Click(sender As Object, e As EventArgs) Handles button10.Click


        openChildForm(New NuevaClase_Preventivo())
        hideSubmenu()
    End Sub




    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        openChildForm(New NuevoEquipo_Preventivo())
        hideSubmenu()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        openChildForm(New Registro_Preventivo())
        hideSubmenu()
    End Sub


#End Region



    Private currentForm As Form = Nothing
    Private Sub openChildForm(childForm As Form)

        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelChildForm.Controls.Add(childForm)
        PanelChildForm.Tag = childForm
        childForm.BringToFront()
        childForm.Show()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()

    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        '#Region "Preguntar si quiere cerrar la lista de formularios"
        '        For Each frm As Form In formularios
        '            If MessageBox.Show(String.Format("¿Deseas cerrar el formulario {0}?", frm.Name), "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
        '                frm.Close()
        '            Else
        '                Exit For
        '            End If
        '        Next
        '#End Region
        For Each frm As Form In formularios
            frm.Close()



        Next
        hideSubmenu()
    End Sub



    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        openChildForm(New Startup())


    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If PanelToolsSubConfiguration.Visible = True Then
            PanelToolsSubConfiguration.Visible = False
        Else
            PanelToolsSubConfiguration.Visible = True
        End If

        PanelToolsSubmenu.Size = New Size(229, 550)

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        openChildForm(New Shutdown())
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        openChildForm(New Pendiente_Preventivos())
        hideSubmenu()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        openChildForm(New NuevoProvedor_Preventivo())
        hideSubmenu()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        openChildForm(New Nueva_Tarea())

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        openChildForm(New HistShutdownStartup())
    End Sub


End Class

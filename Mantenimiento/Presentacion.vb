Imports Common

Public Class Presentacion

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubmenu()
        Label1.Text = ActiveUser.firstName + " " + ActiveUser.lastName
        Label2.Text = ActiveUser.email
        Label3.Text = ActiveUser.position


    End Sub

    Private Sub hideSubmenu()

        PanelIndicadores.Visible = False
        PanelControlInventario.Visible = False
        PanelToolsSubmenu.Visible = False
        PanelToolsSubConfiguration.Visible = False
        PanelCreacion.Visible = False
        PanelTareas.Visible = False
        PanelToolsSubmenu.Size = New Size(229, 550)

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
        showSubmenu(PanelIndicadores)
    End Sub

    Private Sub btnPlaylist_Click(sender As Object, e As EventArgs) Handles btnPlaylist.Click
        showSubmenu(PanelControlInventario)
    End Sub

    Private Sub btnTools_Click(sender As Object, e As EventArgs) Handles btnTools.Click
        showSubmenu(PanelToolsSubmenu)
        PanelToolsSubmenu.Size = New Size(229, 300)


    End Sub

#Region "Botones Indicadores"
    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        MIvalorEditable = 0
        openChildForm(New Registrar_Nuevo_Caso())

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
        openChildForm(New RegistroPreventivo())
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

        'If MessageBox.Show("Esta seguro de cerrar sesión?", "Precaución",
        '    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then




        '    Me.Close()
        'End If

        Application.Exit()

    End Sub





    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        openChildForm(New Startup())


    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If PanelToolsSubConfiguration.Visible = True Then
            PanelToolsSubConfiguration.Visible = False

        Else
            PanelToolsSubConfiguration.Visible = True
            PanelToolsSubmenu.Size = New Size(229, 550)
        End If



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
        openChildForm(New ConfiguShSt())

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        openChildForm(New HistShutdownStartup())
    End Sub



    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If PanelCreacion.Visible = True Then
            PanelCreacion.Visible = False

        Else
            PanelCreacion.Visible = True
            PanelToolsSubmenu.Size = New Size(229, 550)
        End If


    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If PanelTareas.Visible = True Then
            PanelTareas.Visible = False

        Else
            PanelTareas.Visible = True
            PanelToolsSubmenu.Size = New Size(229, 550)
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        openChildForm(New Configuracion_Tarea())

        hideSubmenu()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        openChildForm(New Planificacion_Tareas())

        hideSubmenu()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click

        For Each frm As Form In formularios
            frm.Close()



        Next
        hideSubmenu()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click


        openChildForm(New Notas())

        hideSubmenu()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        openChildForm(New Exportar_indicadores())

        hideSubmenu()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        openChildForm(New Reportes_área())

        hideSubmenu()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        openChildForm(New Resolución_Casos())

        hideSubmenu()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        openChildForm(New Reporte_Casos_Cerrados())

        hideSubmenu()
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        openChildForm(New Tank_Farm.Niveles())

        hideSubmenu()
    End Sub
End Class

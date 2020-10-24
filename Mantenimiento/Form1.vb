

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubmenu()


    End Sub

    Private Sub hideSubmenu()

        PanelMediaSubmenu.Visible = False
        PanelPlaylistSubmenu.Visible = False
        PanelToolsSubmenu.Visible = False

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
        openChildForm(New Lista_Equipos())

        hideSubmenu()
    End Sub
    Private Sub button12_Click(sender As Object, e As EventArgs) Handles button12.Click
        openChildForm(New Planificacion_Preventivo())




    End Sub


    Private Sub button10_Click(sender As Object, e As EventArgs) Handles button10.Click


        openChildForm(New Clase_Preventivo())
        hideSubmenu()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        openChildForm(New Provedor_Preventivo())
        hideSubmenu()
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        openChildForm(New Equipo_Preventivo())
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
    End Sub


End Class

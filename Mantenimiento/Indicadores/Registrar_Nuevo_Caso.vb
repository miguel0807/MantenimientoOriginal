Public Class Registrar_Nuevo_Caso
    Private Sub Registrar_Nuevo_Caso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not formularios.Contains(Me) Then formularios.Add(Me) 'Agrega a la lista los formularios para luego cerrarlos




        'Declaración de variables
        MItitulo = txtTitulo
        MIubicacion = cboUbicacion
        MIclasificacion = cboClasificacion
        MIfechaInicio = fecha_Inicio
        MIfechaFinal = fecha_final
        MIdescripcion = txtDescripcion


        EtiquetaConteo = Label3

        MItxtTiempoInicio = Tiempo_Inicio
        MItxtTiempoFinal = Tiempo_Final
        MIhoraAcumulada = horaAcumulada
        MIminutoAcumulado = minutoAcumulado
        MIcalHoras = calhoras
        MIcalMinutos = calminutos

        MIpanelControlTiempo = panelTiempos
        MIbtnControlTiempo = btnPanelTiempo



        CargarEtiquetas()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnPendiente.Click
        CargarPendiente()
    End Sub

    Private Sub btnControlTiempo_Click(sender As Object, e As EventArgs) Handles btnPanelTiempo.Click
        btnControlTiempo()


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnTiempoInicio.Click
        Modulo_Indicadores.btnTiempoInicio()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnTiempoFinal.Click
        Modulo_Indicadores.btnTiempoFinal()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Modulo_Indicadores.btnCalcular()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnAgregarTiempo.Click
        Modulo_Indicadores.btnAgregarTiempo()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        btnFechaInicio()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        btnFechaFinal()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class
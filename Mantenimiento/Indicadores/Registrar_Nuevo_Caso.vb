Public Class Registrar_Nuevo_Caso
    Private Sub Registrar_Nuevo_Caso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not formularios.Contains(Me) Then formularios.Add(Me) 'Agrega a la lista los formularios para luego cerrarlos





        MItitulo = Nombre
        MIubicacion = Ubicacion
        MIclasificacion = Clasificacion
        MIfechaInicio = Fecha_Inicio
        MIfechaFinal = fecha_final
        MIdescripcion = Descripcion


        EtiquetaConteo = Label3

        MItxtTiempoInicio = Tiempo_Inicio
        MItxtTiempoFinal = Tiempo_Final
        MIhoraAcumulada = horaAcumulada
        MIminutoAcumulado = minutoAcumulado
        MIcalHoras = calhoras
        MIcalMinutos = calminutos

        MIpanelControlTiempo = panel_boton
        MIbtnControlTiempo = butonControlTiempo



        CargarEtiquetas()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CargarPendiente()
    End Sub

    Private Sub btnControlTiempo_Click(sender As Object, e As EventArgs) Handles butonControlTiempo.Click
        btnControlTiempo()


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        btnFechaInicio()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        btnFechaFinal()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        btnCalcular()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        btnAgregarTiempo()
    End Sub
End Class
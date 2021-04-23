Public Class Registrar_Nuevo_Caso
    Private Sub Registrar_Nuevo_Caso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not formularios.Contains(Me) Then formularios.Add(Me) 'Agrega a la lista los formularios para luego cerrarlos

        EtiquetaConteo = Label3
        MItxtTiempoInicio = Tiempo_Inicio
        MIfechaInicio = Fecha
        MIfechaFinal = fecha_final




        CargarEtiquetas()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Pendiente()
    End Sub
End Class
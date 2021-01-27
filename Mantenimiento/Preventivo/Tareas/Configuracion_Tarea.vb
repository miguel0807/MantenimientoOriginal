Public Class Configuracion_Tarea
    Private Sub Nueva_Tarea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not formularios.Contains(Me) Then formularios.Add(Me) 'Agrega a la lista los formularios para luego cerrarlos

        Dim CodTarea As Integer = 0
        Dim TiempoTarea As Integer = 0


        codigoTarea = CodTarea
        txtTarea = Tarea.Text
        txtMateriales = Materiales.Text
        intTiempo = Tiempo.Text




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CrearTarea()

    End Sub
End Class
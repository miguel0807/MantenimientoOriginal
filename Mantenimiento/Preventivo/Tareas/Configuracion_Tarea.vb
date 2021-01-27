Public Class Configuracion_Tarea
    Private Sub Nueva_Tarea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not formularios.Contains(Me) Then formularios.Add(Me) 'Agrega a la lista los formularios para luego cerrarlos

    End Sub
End Class
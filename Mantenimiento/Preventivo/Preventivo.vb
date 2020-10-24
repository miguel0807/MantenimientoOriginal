Public Class Preventivo
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Preventivo_Busqueda.Show()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Lista_Equipos.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Planificacion_Preventivo.Show()
    End Sub

    Private Sub Preventivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not formularios.Contains(Me) Then formularios.Add(Me) 'Agrega a la lista los formularios para luego cerrarlos
    End Sub
End Class
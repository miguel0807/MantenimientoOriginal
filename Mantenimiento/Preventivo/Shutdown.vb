Public Class Shutdown

    Private Sub Shutdown_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not formularios.Contains(Me) Then formularios.Add(Me) 'Agrega a la lista los formularios para luego cerrarlos

        datagr = DataGridView1
        labe1 = Label1
        MOstartup.shutdown()
    End Sub
End Class
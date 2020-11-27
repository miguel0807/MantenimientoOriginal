Public Class Shutdown

    Private Sub Shutdown_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not formularios.Contains(Me) Then formularios.Add(Me) 'Agrega a la lista los formularios para luego cerrarlos



        datagr = DataGridView1
        labe1 = Label1

        usuario = ComboBox1


        usuarios()


        labelFecha = Label2
        LoadFechaEscrita()


        nombre = ComboBox1


        bCargar = Cargar
    End Sub


End Class
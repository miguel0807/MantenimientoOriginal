
Public Class Configuracion_Tarea
    Private Sub Nueva_Tarea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not formularios.Contains(Me) Then formularios.Add(Me) 'Agrega a la lista los formularios para luego cerrarlos





        txtTarea = Tarea
        txtMateriales = Equipo

        intTiempo = Tiempo
        cbo1Clase = Equipo

        CargaClase()

#Region "Cargar lista de equipos"
        Me.DataGridView1.Select()
        datagr = DataGridView1
        labe1 = Label1
        RevisarTareas()
#End Region
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        CrearTarea()
#Region "Cargar lista de equipos"
        Me.DataGridView1.Select()
        datagr = DataGridView1
        labe1 = Label1
        RevisarTareas()
#End Region

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Tarea.Text = ""
        Equipo.Text = ""
        Tiempo.Text = 0



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.DataGridView1.Select()



        datagr = DataGridView1
        labe1 = Label1
        RevisarTareas()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.DataGridView1.Select()

        eliminacionTarea()

        datagr = DataGridView1
        labe1 = Label1

        RevisarTareas()
    End Sub
End Class
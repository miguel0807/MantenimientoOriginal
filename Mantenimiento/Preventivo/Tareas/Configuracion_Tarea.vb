
Public Class Configuracion_Tarea
    Private Sub Nueva_Tarea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not formularios.Contains(Me) Then formularios.Add(Me) 'Agrega a la lista los formularios para luego cerrarlos





        txtTarea = Tarea
        txtMateriales = Equipo

        intTiempo = Tiempo
        cbo1Clase = Equipo
        CboClase = Equipo

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



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If datagr.Rows.Count = 0 Then
            MessageBox.Show("No hay datos para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Me.DataGridView1.Select()

            eliminacionTarea()

            datagr = DataGridView1
            labe1 = Label1

            RevisarTareas()
        End If

    End Sub

    Private Sub Equipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Equipo.SelectedIndexChanged
        Me.DataGridView1.Select()



        datagr = DataGridView1
        labe1 = Label1
        RevisarTareas()
        Equipo.Select()
    End Sub


End Class
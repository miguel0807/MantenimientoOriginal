Imports System.Data.SqlClient
Public Class Planificacion_Tareas


    Dim mes As String


    ' Dim Año As Integer


    Private Sub Planificacion_Tareas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not formularios.Contains(Me) Then formularios.Add(Me) 'Agrega a la lista los formularios para luego cerrarlos

        CboClase = txtClase
        CboEtiqueta = txtEtiqueta
        CboMes = txtMeses
        CboAño = txtAño



        TareaClase()

        TareaAño()


        TareaMes()
    End Sub

    Private Sub Clase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtClase.SelectedIndexChanged


        TareaEtiqueta()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SQLEtiqueta = txtEtiqueta.Text
        SQLAño = txtAño.Text
        SQLMes = txtMeses.Text

        Me.DataGridView2.Select()



        datagr = DataGridView2
        labe1 = Label4
        RevisarTareas()

        Me.DataGridView1.Select()
        datagr = DataGridView1
        labe1 = Label5
        CargarPendientesTareasPlanificacion()

        Me.DataGridView3.Select()
        datagr = DataGridView3
        labe1 = Label7
        CargarPendientesTareasPlanificacionRealizadas()



    End Sub



    Private Sub Crear_Click(sender As Object, e As EventArgs) Handles Crear.Click
        Me.DataGridView2.Select()
        SQLCodTarea = DataGridView2.CurrentRow.Cells.Item(0).Value.ToString



#Region "Insertar en la lista de equipos la informacion del nuevo equipo"
        Dim adaptador1 As New SqlCommand("insert into Historial_Tareas values(" & SQLCodTarea & "," & SQLCodigo & ",'" & SQLEtiqueta & "','N/A','Sin asignar'," & SQLAño & ",'" & SQLMes & "','1/1/1900','N/A',0)", cn)
        conectar()
        'MsgBox(adaptador1.CommandText)

        adaptador1.ExecuteNonQuery()
        desconectar()
        MsgBox("Tarea agregada correctamente")


#End Region

        'Me.DataGridView1.Select()
        'datagr = DataGridView1
        'labe1 = Label5
        'CargarPendientesTareas()

        Me.DataGridView1.Select()
        datagr = DataGridView1
        labe1 = Label5
        CargarPendientesTareasPlanificacion()

        Me.DataGridView3.Select()
        datagr = DataGridView3
        labe1 = Label7
        CargarPendientesTareasPlanificacionRealizadas()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DataGridView1.Select()
        SQLSumar = DataGridView1.CurrentRow.Cells.Item(1).Value.ToString
        BorrarTarea()

        Me.DataGridView1.Select()
        datagr = DataGridView1
        labe1 = Label5
        CargarPendientesTareasPlanificacion()

        Me.DataGridView3.Select()
        datagr = DataGridView3
        labe1 = Label7
        CargarPendientesTareasPlanificacionRealizadas()

    End Sub



    Private Sub txtEtiqueta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtEtiqueta.SelectedIndexChanged






    End Sub

    Private Sub txtAño_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtAño.SelectedIndexChanged



    End Sub

    Private Sub txtMeses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtMeses.SelectedIndexChanged



    End Sub
End Class
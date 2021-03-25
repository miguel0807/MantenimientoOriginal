Public Class RegistroPreventivo
    Private Sub RegistroPreventivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not formularios.Contains(Me) Then formularios.Add(Me) 'Agrega a la lista los formularios para luego cerrarlos




        'Declaracion de item del formulario 
        formularioAbierto = Me

        mtcFecha = Fecha

        cboClase3 = Clase
        cboEtiqueta2 = Etiqueta
        cboResponsable = Responsable

        txtComentarios = Comentarios


        btnSalir = FinalizadoSalir
        btnSalirContinuar = FinalizadoContinuar

        dtgTareas = DataGridView1

        lblCantidad = Cantidad
        'Declaracion de item del formulario 


        'Declaracion de modulos 
        CargarResponsable()

    End Sub

    Private Sub Fecha_DateChanged(sender As Object, e As DateRangeEventArgs) Handles Fecha.DateChanged

        Cargarclase() 'Carga la lista de equipos para la fecha seleccionada
    End Sub

    Private Sub Clase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Clase.SelectedIndexChanged
        CargarEtiqueta()


    End Sub

    Private Sub Etiqueta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Etiqueta.SelectedIndexChanged
        CargarTareas()
    End Sub

    Private Sub DataGridView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseDoubleClick

        If Clase.Text = "" Or Etiqueta.Text = "" Or Responsable.Text = "" Or Comentarios.Text = "" Then
            MsgBox("Complete todos los campos para registrar la tarea")
            Exit Sub
        End If

        CodigoTareaNumerico = DataGridView1.CurrentRow.Cells.Item(1).Value.ToString
        RegistrarTarea()
        CargarTareas()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub FinalizadoContinuar_Click(sender As Object, e As EventArgs) Handles FinalizadoContinuar.Click
        If Clase.Text = "" Or Etiqueta.Text = "" Or Responsable.Text = "" Or Comentarios.Text = "" Then
            MsgBox("Complete todos los campos para registrar preventivo")
            Exit Sub
        End If

        InsertarHistorial()
        ActualizarConteoPlanificacion()
        CargarEtiqueta()

        verificarEtiqueta()
    End Sub

    Private Sub FinalizadoSalir_Click(sender As Object, e As EventArgs) Handles FinalizadoSalir.Click
        If Clase.Text = "" Or Etiqueta.Text = "" Or Responsable.Text = "" Or Comentarios.Text = "" Then
            MsgBox("Complete todos los campos para registrar preventivo")
            Exit Sub
        End If

        InsertarHistorial()
        ActualizarConteoPlanificacion()
        CargarEtiqueta()
        MsgBox("Se registro correctamente")

        Me.Close()
    End Sub
End Class
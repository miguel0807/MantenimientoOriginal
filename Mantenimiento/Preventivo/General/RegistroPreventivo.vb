Public Class RegistroPreventivo
    Private Sub RegistroPreventivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        habilitaCerrarFormulario() 'Habilita el formulario para ser cerrado desde un boton en el form presentacion



        'Declaracion de item del formulario 
        formularioAbierto = Me

        mtcFecha = Fecha

        cboClase3 = Clase
        cboEtiqueta2 = Etiqueta
        cboResponsable = Responsable

        txtComentarios = Comentarios
        txtFinal = TextBox1
        txtEliminacion = TextBox2

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
End Class
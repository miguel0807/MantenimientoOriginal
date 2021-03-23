Public Class RegistroPreventivo
    Private Sub RegistroPreventivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        habilitaCerrarFormulario()


        'Declaracion de item del formulario 
        formularioAbierto = Me

        mtcFecha = Fecha


        cboClase3 = Clase
        cboEtiqueta2 = Etiqueta
        cboResponsable = Responsable
        txtComentarios = Comentarios

        btnSalir = FinalizadoSalir
        btnSalirContinuar = FinalizadoContinuar

        dtgTareas = datagr

    End Sub

    Private Sub Fecha_DateChanged(sender As Object, e As DateRangeEventArgs) Handles Fecha.DateChanged
        Cargarclase()
    End Sub
End Class
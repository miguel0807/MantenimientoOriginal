

Public Class Notas
    Private Sub Notas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not formularios.Contains(Me) Then formularios.Add(Me) 'Agrega a la lista los formularios para luego cerrarlos


        txtTexto = Texto
        btnAgregar = Agregar
        btnEliminar = Eliminar
        dtg1 = DtgPrincipal
        cboResponsable2 = Responsable
        lblConteo = Label1
        CargarInformación()
        cargarCboResponsable()


    End Sub

    Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles Agregar.Click
        CrearNota()
        CargarInformación()
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        DtgPrincipal.Select()
        EliminarTareaNotas()
        CargarInformación()
    End Sub
End Class
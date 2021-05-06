Public Class Registrar_Nuevo_Caso
    Private Sub Registrar_Nuevo_Caso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not formularios.Contains(Me) Then formularios.Add(Me) 'Agrega a la lista los formularios para luego cerrarlos




        'Declaración de variables
        MItitulo = txtTitulo
        MIresponsable = cboResponsable
        MIclase = cboClase
        MIequipo = cboEquipo
        MIubicacion = cboUbicacion
        MIclasificacion = cboClasificacion
        MIdescripcion = txtDescripcion
        MIsolucionProblema = txtSolucionProblema
        MIfechaInicio = fecha_Inicio
        MIfechaFinal = fecha_final


        MItxtTiempoInicio = Tiempo_Inicio
        MItxtTiempoFinal = Tiempo_Final
        MIhoraAcumulada = horaAcumulada
        MIminutoAcumulado = minutoAcumulado
        MIcalHoras = calhoras
        MIcalMinutos = calminutos

        EtiquetaConteo = lblCaso


        MIvalorEditable = 0

        MostrarCantidadCasos()
        MIcargarClase()
        MIcargarResponsable()
        MIcargarEquipos()
        MIcargarUbicacion()
        MIcargarClasificación()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFechaInicio.Click
        Modulo_Indicadores.btnFechaInicio()
    End Sub

    Private Sub btnTiempoInicio_Click(sender As Object, e As EventArgs) Handles btnTiempoInicio.Click
        Modulo_Indicadores.btnTiempoInicio()
    End Sub

    Private Sub btnTiempoFinal_Click(sender As Object, e As EventArgs) Handles btnTiempoFinal.Click
        Modulo_Indicadores.btnTiempoFinal()
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Modulo_Indicadores.btnCalcular()
    End Sub

    Private Sub btnAgregarTiempo_Click(sender As Object, e As EventArgs) Handles btnAgregarTiempo.Click
        Modulo_Indicadores.btnAgregarTiempo()
    End Sub

    Private Sub btnFechaFinal_Click(sender As Object, e As EventArgs) Handles btnFechaFinal.Click
        Modulo_Indicadores.btnFechaFinal()
    End Sub

    Private Sub btnPendiente_Click(sender As Object, e As EventArgs) Handles btnPendiente.Click
        CargarPendiente()


    End Sub


    Private Sub btnFinalizado_Click(sender As Object, e As EventArgs) Handles btnFinalizado.Click
        CargarFinalizado()
    End Sub

    Private Sub cboClase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboClase.SelectedIndexChanged
        MIcargarEquipos()
    End Sub

    Private Sub cboClasificacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboClasificacion.SelectedIndexChanged
        If cboClasificacion.Text = "Servicio" Or cboClasificacion.Text = "Proyecto" Then
            cboClase.Visible = False
            cboEquipo.Visible = False
            lblClase.Visible = False
            lblEquipo.Visible = False


        Else
            cboClase.Visible = True
            cboEquipo.Visible = True
            lblClase.Visible = True
            lblEquipo.Visible = True
        End If
    End Sub



    Private Sub cboClasificacion_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cboClasificacion.DrawItem

    End Sub

    Private Sub panelDatos_Paint(sender As Object, e As PaintEventArgs) Handles panelDatos.Paint

    End Sub
End Class

'Public Class CenteredComboBox
'    Inherits ComboBox
'    Sub New()
'        Me.DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
'        Me.DropDownStyle = ComboBoxStyle.DropDownList
'    End Sub

'    Private Sub CenteredComboBox_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles Me.DrawItem
'        e.DrawBackground()
'        Dim txt As String = ""
'        If e.Index >= 0 Then txt = Me.Items(e.Index).ToString
'        TextRenderer.DrawText(e.Graphics, txt, e.Font, e.Bounds, e.ForeColor, TextFormatFlags.HorizontalCenter)
'        e.DrawFocusRectangle()

'    End Sub
'End Class
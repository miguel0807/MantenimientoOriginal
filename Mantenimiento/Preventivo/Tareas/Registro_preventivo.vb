Imports System.Data.SqlClient
Module Registro_preventivoModulo





    'Declaracion de item del formulario 
    Public formularioAbierto As Form
    Public mtcFecha As MonthCalendar


    Public cboClase3 As ComboBox
    Public cboEtiqueta2 As ComboBox
    Public cboResponsable As ComboBox

    Public txtComentarios As TextBox
    Public txtFinal As TextBox
    Public txtEliminacion As TextBox

    Public btnSalir As Button
    Public btnSalirContinuar As Button

    Public dtgTareas As DataGridView

    Public CodigoClase As Integer


    Dim mesRegistro As String

    Sub CargarResponsable()
#Region "Cargar datos en combobox de Responsable"

        Dim cmd3 As String = "select*from Usuarios"
            Dim da3 As New SqlDataAdapter(cmd3, cn)
            Dim ds3 As New DataSet
            da3.Fill(ds3)
            With cboResponsable
                cboResponsable.DataSource = ds3.Tables(0)
                cboResponsable.DisplayMember = "Nombre"
            End With
            cn.Close()



#End Region
    End Sub



    Sub Cargarclase()
#Region "Cargar datos en combobox de Clase"

        mesRegistro = mtcFecha.SelectionStart.Month.ToString
        Select Case mesRegistro
            Case "1"
                mesRegistro = "Enero"
            Case "2"
                mesRegistro = "Febrero"
            Case "3"
                mesRegistro = "Marzo"
            Case "4"
                mesRegistro = "Abril"
            Case "5"
                mesRegistro = "Mayo"
            Case "6"
                mesRegistro = "Junio"
            Case "7"
                mesRegistro = "Julio"
            Case "8"
                mesRegistro = "Agosto"
            Case "9"
                mesRegistro = "Septiembre"
            Case "10"
                mesRegistro = "Octubre"
            Case "11"
                mesRegistro = "Noviembre"
            Case "12"
                mesRegistro = "Diciembre"

        End Select


        Dim cmd As String = "select carac.Clase from ConteoPlanificacion_Equipos conteo, Caracteristicas_Equipo carac where año=" & mtcFecha.SelectionStart.Year.ToString & "  and " & mesRegistro & " <5000 and " & mesRegistro & ">0 and conteo.Codigo=carac.Codigo"

        Dim da As New SqlDataAdapter(cmd, cn)
        Dim ds As New DataSet
        da.Fill(ds)
        With cboClase3
            cboClase3.DataSource = ds.Tables(0)
            cboClase3.DisplayMember = "Clase"
        End With
        cn.Close()



#End Region
    End Sub

    Sub CargarEtiqueta()
#Region "Obtener # de Clase"
        'En el parentesis entre & & se coloca cual valor se usara para la busqueda
        Dim adaptador As New SqlDataAdapter("select*from Caracteristicas_Equipo where CONVERT(char,Clase)='" & cboClase3.Text & "'", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "Codigo")

        'El item selecciona de cual columna de la base de datos se conectara y row es la fila
        If ds.Tables("Codigo").Rows.Count > 0 Then

            CodigoClase = ds.Tables("Codigo").Rows(0).Item(0).ToString

        End If
#End Region

#Region "Crear lista con lista de equipos"
        Dim cmd5 As String = "select*from Lista_Equipos where Codigo=" & CodigoClase & ""
        Dim da5 As New SqlDataAdapter(cmd5, cn)
        Dim dt5 As New DataTable()
        da5.Fill(dt5)

        Dim arrayEquipos As String() = dt5.Rows.OfType(Of DataRow)().[Select](Function(x) x(1).ToString()).ToArray() 'Se crea array

        Dim listaEquipos As New List(Of String) 'Se crea lista manipulable
        For Each elemento As String In arrayEquipos 'Se carga la lista con la informacion del array
            listaEquipos.Add(elemento)
        Next

#End Region

#Region "Crear lista con equipos registrados en historial"
        Dim cmd3 As String = "select*from Historial_Equipos where Codigo=" & CodigoClase & " and CONVERT(char,Mes)='" & mesRegistro & "' and Año=" & mtcFecha.SelectionStart.Year.ToString & ""
        Dim da3 As New SqlDataAdapter(cmd3, cn)
        Dim dt3 As New DataTable()
        da3.Fill(dt3)

        'Se crea array
        Dim arrayRegistrados As String() = dt3.Rows.OfType(Of DataRow)().[Select](Function(x) x(1).ToString()).ToArray()
        Dim listaRegistrados As New List(Of String) 'Se crea lista manipulable
        For Each elemento As String In arrayRegistrados 'Se carga lista con la informacacion del array
            listaRegistrados.Add(elemento)
        Next

#End Region

#Region "Se crea lista con los resultados finales"

        Dim resultadoFinal = listaEquipos.Except(listaRegistrados) 'Se crea lista para guardar los resultados

        Dim listaFinal As New List(Of String)
        For Each elemento As String In resultadoFinal
            listaFinal.Add(elemento)
        Next
#End Region

#Region "Asignacion de lista final en combobox de etiqueta"
        With cboEtiqueta2
            cboEtiqueta2.DataSource = listaFinal
        End With
#End Region

        'Puede borrarse
        txtComentarios.Text = ""
        For Each elemento As String In listaEquipos
            txtComentarios.Text = txtComentarios.Text & vbCrLf & (elemento)
        Next
        'Puede borrarse

        txtEliminacion.Text = ""
        'Puede borrarse
        For Each elemento As String In listaRegistrados
            txtEliminacion.Text = txtEliminacion.Text & vbCrLf & (elemento)
        Next
        'Puede borrarse
        txtFinal.Text = ""
        For Each elemento As String In resultadoFinal
            txtFinal.Text = txtFinal.Text & vbCrLf & (elemento)
            ' MessageBox.Show("Resultado Final" + elemento)

        Next
    End Sub

    Sub habilitaCerrarFormulario()
        If Not formularios.Contains(formularioAbierto) Then formularios.Add(formularioAbierto) 'Agrega a la lista los formularios para luego cerrarlos

    End Sub


End Module

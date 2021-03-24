Imports System.Data.SqlClient
Module Registro_preventivoModulo





    'Declaracion de item del formulario 
    Public formularioAbierto As Form
    Public mtcFecha As MonthCalendar


    Public cboClase3 As ComboBox
    Public cboEtiqueta2 As ComboBox
    Public cboResponsable As ComboBox

    Public txtComentarios As TextBox

    Public btnSalir As Button
    Public btnSalirContinuar As Button

    Public dtgTareas As DataGridView

    Public CodigoClase As Integer





    Sub Cargarclase()
#Region "Cargar datos en combobox de Clase"
        Dim mesRegistro As String
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
#Region "Verificar etiquetas"
        'En el parentesis entre & & se coloca cual valor se usara para la busqueda
        Dim adaptador As New SqlDataAdapter("select*from Caracteristicas_Equipo where CONVERT(char,Clase)='" & cboClase3.Text & "'", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "Codigo")

        'El item selecciona de cual columna de la base de datos se conectara y row es la fila
        If ds.Tables("Codigo").Rows.Count > 0 Then

            CodigoClase = ds.Tables("Codigo").Rows(0).Item(0).ToString


        End If
#End Region

#Region "Crear array con lista de equipos"
        Dim cmd5 As String = "select*from Lista_Equipos where Codigo=" & CodigoClase & ""
        Dim da5 As New SqlDataAdapter(cmd5, cn)
        Dim dt5 As New DataTable()
        da5.Fill(dt5)

        Dim listaEquipos As String() = dt5.Rows.OfType(Of DataRow)().[Select](Function(x) x(1).ToString()).ToArray()

        'For Each elemento As String In listaEquipos
        '    MessageBox.Show(elemento)
        'Next
#End Region

#Region "Crear array con equipos registrados en historial"
        Dim cmd3 As String = "select*from Historial_Equipos where Codigo=8 and CONVERT(char,Mes)='Marzo' and Año=2021"
        Dim da3 As New SqlDataAdapter(cmd3, cn)
        Dim dt3 As New DataTable()
        da3.Fill(dt3)

        Dim listaRegistrados As String() = dt3.Rows.OfType(Of DataRow)().[Select](Function(x) x(1).ToString()).ToArray()

        'For Each elemento As String In listaRegistrados
        '    MessageBox.Show("Lista registrados y el equipo es:" + elemento)
        'Next
#End Region
        Dim resultadoFinal As String


#Region "Cargar datos en combobox de Etiqueta"

        Dim cmd1 As String = "select*from Lista_Equipos where Codigo=" & CodigoClase & ""
        Dim da1 As New SqlDataAdapter(cmd1, cn)
        Dim ds1 As New DataSet
        da1.Fill(ds1)
        With cboResponsable
            'cboEtiqueta2.DataSource = ds1.Tables(0)
            'cboEtiqueta2.DisplayMember = "Etiqueta"

        End With
        cn.Close()

#End Region
    End Sub

    Sub habilitaCerrarFormulario()
        If Not formularios.Contains(formularioAbierto) Then formularios.Add(formularioAbierto) 'Agrega a la lista los formularios para luego cerrarlos

    End Sub


End Module

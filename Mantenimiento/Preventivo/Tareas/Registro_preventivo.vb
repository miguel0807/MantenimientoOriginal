Imports System.Data.SqlClient
Module Registro_preventivoModulo





    'Declaracion de item del formulario 
    Public formularioAbierto As Form
    Public mtcFecha As MonthCalendar


    Public cboClase As ComboBox
    Public cboEtiqueta As ComboBox
    Public cboResponsable As ComboBox

    Public txtComentarios As TextBox

    Public btnSalir As Button
    Public btnSalirContinuar As Button

    Public dtgTareas As DataGridView





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

        'Try
        '    Dim cmd As String = "select carac.Clase from ConteoPlanificacion_Equipos conteo, Caracteristicas_Equipo carac where año=" & Fecha.SelectionStart.Year.ToString & "  and " & mesRegistro & " <5000 and " & mesRegistro & ">0 and conteo.Codigo=carac.Codigo"

        '    Dim da As New SqlDataAdapter(cmd, cn)
        '    Dim ds As New DataSet
        '    da.Fill(ds)
        '    With Me.Clase
        '        Me.Clase.DataSource = ds.Tables(0)
        '        Me.Clase.DisplayMember = "Clase"
        '    End With
        '    cn.Close()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try


#End Region
    End Sub

    Sub habilitaCerrarFormulario()
        If Not formularios.Contains(formularioAbierto) Then formularios.Add(formularioAbierto) 'Agrega a la lista los formularios para luego cerrarlos

    End Sub


End Module

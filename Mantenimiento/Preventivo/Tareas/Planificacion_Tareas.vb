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

        SQLEtiqueta = txtEtiqueta.Text
        SQLAño = txtAño.Text
        SQLMes = txtMeses.Text
    End Sub

    Private Sub Clase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtClase.SelectedIndexChanged


        TareaEtiqueta()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CheckBox1.Checked = True Then
            txtEtiqueta.Enabled = False
#Region "Cargar lista de tareas"

            Me.DataGridView2.Select()
            datagr = DataGridView2
            labe1 = Label4
            RevisarTareas()

#End Region

        Else
            txtEtiqueta.Enabled = True



#Region "Cargar lista de tareas"

            Me.DataGridView2.Select()
            datagr = DataGridView2
            labe1 = Label4
            RevisarTareas()

#End Region

#Region "Cargar tareas activas"
            Me.DataGridView1.Select()
            datagr = DataGridView1
            labe1 = Label5
            CargarPendientesTareasPlanificacion()
#End Region

#Region "Cargar tareas realizadas"
            Me.DataGridView3.Select()
            datagr = DataGridView3
            labe1 = Label7
            CargarPendientesTareasPlanificacionRealizadas()
            EquipoActivo.Text = "Equipo Activo: " & txtEtiqueta.Text

#End Region
        End If




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

    Private Sub DataGridView2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DataGridView2.MouseDoubleClick
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
#Region "Refrescar pestañas"
        Me.DataGridView1.Select()
        datagr = DataGridView1
        labe1 = Label5
        CargarPendientesTareasPlanificacion()

        Me.DataGridView3.Select()
        datagr = DataGridView3
        labe1 = Label7
        CargarPendientesTareasPlanificacionRealizadas()

#End Region
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtEtiqueta.Enabled = False
        Else
            txtEtiqueta.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.DataGridView2.Select()
        SQLCodTarea = DataGridView2.CurrentRow.Cells.Item(0).Value.ToString






        'Using cn
        '    Dim command As SqlCommand = New SqlCommand(
        '      "select*from Lista_Equipos where Codigo=" & clasecodigo & "" &
        '      "select*from Caracteristicas_Tareas where convert(char,Equipo)='" & CboClase.Text & "' ", cn)
        '    cn.Open()

        '    Dim reader As SqlDataReader = command.ExecuteReader()

        '    Do While reader.Read
        '        MsgBox(reader.GetString(1))

        '        Do While reader.Read()
        '            MsgBox(reader.GetString(1))
        '        Loop

        '        ' reader.NextResult()
        '    Loop



        'End Using


        Dim adaptador As New SqlDataAdapter("select*from Lista_Equipos where Codigo=" & clasecodigo & " ", cn)
        Dim dtDatos As DataTable = New DataTable
        adaptador.Fill(dtDatos)
        For i As Integer = 0 To dtDatos.Rows.Count - 1
            MsgBox(dtDatos.Rows(i)("Etiqueta"))


            Dim adaptador1 As New SqlDataAdapter("select*from Caracteristicas_Tareas where convert(char,Equipo)='" & CboClase.Text & "'  ", cn)
            Dim dtDatos1 As DataTable = New DataTable
            adaptador1.Fill(dtDatos1)
            For w As Integer = 0 To dtDatos1.Rows.Count - 1
                MsgBox(dtDatos1.Rows(w)("Tarea"))

            Next

        Next
        ' SQLCodTarea

        '  SQLCodigo
        desconectar()
    End Sub
End Class
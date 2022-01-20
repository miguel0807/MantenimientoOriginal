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

        verificarMes(clasecodigo)




    End Sub

    Private Sub Clase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtClase.SelectedIndexChanged


        TareaEtiqueta()


        verificarMes(clasecodigo)





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CheckBox1.Checked = True Then

#Region "Cargar lista de tareas"
            TabControl1.SelectedTab = TabPage1
            Me.DataGridView2.Select()
            datagr = DataGridView2
            labe1 = Label4


            SQLEtiqueta = txtEtiqueta.Text
            SQLAño = txtAño.Text
            SQLMes = txtMeses.Text

            RevisarTareas()

#End Region

        Else

            SQLEtiqueta = txtEtiqueta.Text
            SQLAño = txtAño.Text
            SQLMes = txtMeses.Text


#Region "Cargar lista de tareas"
            TabControl1.SelectedTab = TabPage1
            Me.DataGridView2.Select()
            datagr = DataGridView2
            labe1 = Label4
            RevisarTareas()

#End Region

#Region "Cargar tareas activas"
            TabControl1.SelectedTab = TabPage2
            Me.DataGridView1.Select()
            datagr = DataGridView1
            labe1 = Label5
            CargarPendientesTareasPlanificacion()
#End Region

#Region "Cargar tareas realizadas"
            TabControl1.SelectedTab = TabPage3
            Me.DataGridView3.Select()
            datagr = DataGridView3
            labe1 = Label7

            CargarPendientesTareasPlanificacionRealizadas()
            EquipoActivo.Text = "Etiqueta: " & txtEtiqueta.Text
            ClaseActivo.Text = "Clase: " & txtClase.Text
            AñoActivo.Text = "Año: " & txtAño.Text
            MesActivo.Text = "Mes: " & txtMeses.Text

#End Region


        End If

        If CheckBox1.Checked = True Then

            TabControl1.SelectedTab = TabPage1
        Else
            TabControl1.SelectedTab = TabPage2
        End If


    End Sub



    Private Sub Crear_Click(sender As Object, e As EventArgs) Handles Crear.Click
        TabControl1.SelectedTab = TabPage1
        If DataGridView2.Rows.Count = 0 Then
            MessageBox.Show("No hay datos para agregar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            Me.DataGridView2.Select()
            SQLCodTarea = DataGridView2.CurrentRow.Cells.Item(0).Value.ToString


#Region "Verificar si la tarea esta agregada"




            Dim adaptador As New SqlDataAdapter("select*from Historial_Tareas where codTarea=" & SQLCodTarea & " and Codigo=" & SQLCodigo & " and convert(char,Etiqueta)='" & SQLEtiqueta & "' and Año=" & SQLAño & " and convert(char,Mes)='" & SQLMes & "'", cn)
            Dim dataS As New DataSet
            'MsgBox(adaptador.SelectCommand.CommandText)
            adaptador.Fill(dataS, "Shutdowns")

            ' datagr.DataSource = dataS.Tables("Shutdowns")

#End Region


            If dataS.Tables("Shutdowns").Rows.Count > 0 Then


                MsgBox("No se puede agregar la tarea, ya se encuentra registrada")
            Else


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
                TabControl1.SelectedTab = TabPage2
                Me.DataGridView1.Select()
                datagr = DataGridView1
                labe1 = Label5
                CargarPendientesTareasPlanificacion()

                TabControl1.SelectedTab = TabPage3
                Me.DataGridView3.Select()
                datagr = DataGridView3
                labe1 = Label7
                CargarPendientesTareasPlanificacionRealizadas()
            End If



        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DataGridView1.Rows.Count = 0 Then
            MessageBox.Show("No hay datos para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

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
        End If
    End Sub





    Private Sub DataGridView2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DataGridView2.MouseDoubleClick
        If DataGridView2.Rows.Count = 0 Then
            MessageBox.Show("No hay datos para agregar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            If CheckBox1.Checked = True Then
            Else

                Me.DataGridView2.Select()
                SQLCodTarea = DataGridView2.CurrentRow.Cells.Item(0).Value.ToString


#Region "Verificar si la tarea esta agregada"




                Dim adaptador As New SqlDataAdapter("select*from Historial_Tareas where codTarea=" & SQLCodTarea & " and Codigo=" & SQLCodigo & " and convert(char,Etiqueta)='" & SQLEtiqueta & "' and Año=" & SQLAño & " and convert(char,Mes)='" & SQLMes & "'", cn)
                Dim dataS As New DataSet
                'MsgBox(adaptador.SelectCommand.CommandText)
                adaptador.Fill(dataS, "Shutdowns")

                ' datagr.DataSource = dataS.Tables("Shutdowns")

#End Region


                If dataS.Tables("Shutdowns").Rows.Count > 0 Then


                    MsgBox("No se puede agregar la tarea, ya se encuentra registrada")
                Else


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
                End If


            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtEtiqueta.Enabled = False
            Tareas.Visible = True
            EliminarTareasbtn.Visible = True
            Crear.Visible = False
            TabPage2.Parent = Nothing
            TabPage3.Parent = Nothing
            TabPage1.Parent = TabControl1

            ModoClase.Visible = True
            DataGridView1.DataSource = Nothing
            DataGridView2.DataSource = Nothing
            DataGridView3.DataSource = Nothing
            Label4.Text = "Cantidad:0"
        Else
            txtEtiqueta.Enabled = True
            Tareas.Visible = False
            EliminarTareasbtn.Visible = False
            Crear.Visible = True

            TabPage2.Parent = TabControl1
            TabPage3.Parent = TabControl1
            TabPage1.Parent = TabControl1
            ModoClase.Visible = False
            DataGridView1.DataSource = Nothing
            DataGridView2.DataSource = Nothing
            DataGridView3.DataSource = Nothing

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Tareas.Click
        If DataGridView2.Rows.Count = 0 Then
            MessageBox.Show("No hay datos para agregar ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Dim msgvalue As Integer

            msgvalue = MsgBox("Está seguro de agregar en el mes de " & SQLMes & ", el año " & SQLAño & " y la clase " & txtClase.Text & " la lista de tareas?", vbInformation + vbYesNo, "Mensaje de Alerta")

            Select Case msgvalue

                Case 6 'Yes

                    Me.DataGridView2.Select()
                    SQLCodTarea = DataGridView2.CurrentRow.Cells.Item(0).Value.ToString


                    Dim adaptador As New SqlDataAdapter("select*from Lista_Equipos where Codigo=" & clasecodigo & " ", cn)
                    Dim dtDatos As DataTable = New DataTable
                    adaptador.Fill(dtDatos)
                    For i As Integer = 0 To dtDatos.Rows.Count - 1
                        SQLEtiqueta = (dtDatos.Rows(i)("Etiqueta"))
                        ' MsgBox(dtDatos.Rows(i)("Etiqueta"))


                        Dim adaptador1 As New SqlDataAdapter("select*from Caracteristicas_Tareas where convert(char,Equipo)='" & CboClase.Text & "'  ", cn)
                        Dim dtDatos1 As DataTable = New DataTable
                        adaptador1.Fill(dtDatos1)
                        For w As Integer = 0 To dtDatos1.Rows.Count - 1
                            SQLCodTarea = (dtDatos1.Rows(w)("CodTarea"))
                            'MsgBox(dtDatos1.Rows(w)("CodTarea"))





                            Dim adaptador5 As New SqlDataAdapter("select*from Historial_Tareas where codTarea=" & SQLCodTarea & " and Codigo=" & SQLCodigo & " and convert(char,Etiqueta)='" & SQLEtiqueta & "' and Año=" & SQLAño & " and convert(char,Mes)='" & SQLMes & "'", cn)
                            Dim dataS5 As New DataSet
                            'MsgBox(adaptador.SelectCommand.CommandText)
                            adaptador5.Fill(dataS5, "Shutdowns")

                            ' datagr.DataSource = dataS.Tables("Shutdowns")
                            If dataS5.Tables("Shutdowns").Rows.Count > 0 Then


                                MsgBox("Habian datos cargados en el equipo " & SQLEtiqueta & "")


                            Else


#Region "Insertar en la lista de equipos la informacion del nuevo equipo"
                                Dim adaptador3 As New SqlCommand("insert into Historial_Tareas values(" & SQLCodTarea & "," & SQLCodigo & ",'" & SQLEtiqueta & "','N/A','Sin asignar'," & SQLAño & ",'" & SQLMes & "','1/1/1900','N/A',0)", cn)
                                conectar()
                                'MsgBox(adaptador1.CommandText)

                                adaptador3.ExecuteNonQuery()
                                desconectar()



#End Region
                            End If


                        Next

                    Next
                    MsgBox("Tareas cargadas con exito")
                    ' SQLCodTarea

                    '  SQLCodigo
                    desconectar()



                Case 7 'No



            End Select



        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If PanelActivo.Visible = True Then
            PanelActivo.Visible = False
        Else
            PanelActivo.Visible = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles EliminarTareasbtn.Click
        If DataGridView2.Rows.Count = 0 Then
            MessageBox.Show("No hay datos para agregar ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Dim msgvalue As Integer

            msgvalue = MsgBox("Está seguro de Eliminar en el mes de " & SQLMes & ", el año " & SQLAño & " y la clase " & txtClase.Text & " la lista de tareas?", vbInformation + vbYesNo, "Mensaje de Alerta")

            Select Case msgvalue

                Case 6 'Yes

                    Me.DataGridView2.Select()
                    SQLCodTarea = DataGridView2.CurrentRow.Cells.Item(0).Value.ToString


                    Dim adaptador As New SqlDataAdapter("select*from Lista_Equipos where Codigo=" & clasecodigo & " ", cn)
                    Dim dtDatos As DataTable = New DataTable
                    adaptador.Fill(dtDatos)
                    For i As Integer = 0 To dtDatos.Rows.Count - 1
                        SQLEtiqueta = (dtDatos.Rows(i)("Etiqueta"))
                        ' MsgBox(dtDatos.Rows(i)("Etiqueta"))


                        Dim adaptador1 As New SqlDataAdapter("select*from Caracteristicas_Tareas where convert(char,Equipo)='" & CboClase.Text & "'  ", cn)
                        Dim dtDatos1 As DataTable = New DataTable
                        adaptador1.Fill(dtDatos1)
                        For w As Integer = 0 To dtDatos1.Rows.Count - 1
                            SQLCodTarea = (dtDatos1.Rows(w)("CodTarea"))
                            'MsgBox(dtDatos1.Rows(w)("CodTarea"))





                            Dim adaptador5 As New SqlDataAdapter("select*from Historial_Tareas where codTarea=" & SQLCodTarea & " and Codigo=" & SQLCodigo & " and convert(char,Etiqueta)='" & SQLEtiqueta & "' and Año=" & SQLAño & " and convert(char,Mes)='" & SQLMes & "'", cn)
                            Dim dataS5 As New DataSet
                            'MsgBox(adaptador.SelectCommand.CommandText)
                            adaptador5.Fill(dataS5, "Shutdowns")

                            ' datagr.DataSource = dataS.Tables("Shutdowns")
                            If dataS5.Tables("Shutdowns").Rows.Count > 0 Then


                                MsgBox("Habian datos cargados en el equipo " & SQLEtiqueta & " y se procedió a eliminarlo ")
#Region "Eliminar en la lista de equipos la informacion del nuevo equipo"
                                Dim adaptador3 As New SqlCommand("delete from Historial_Tareas where codTarea=" & SQLCodTarea & " and Codigo=" & SQLCodigo & " and convert(char,Etiqueta)='" & SQLEtiqueta & "' and Año=" & SQLAño & " and convert(char,Mes)='" & SQLMes & "'", cn)
                                conectar()
                                'TextBox1.Text = (adaptador3.CommandText)

                                adaptador3.ExecuteNonQuery()
                                desconectar()



#End Region

                            Else


#Region "Eliminar en la lista de equipos la informacion del nuevo equipo"
                                Dim adaptador3 As New SqlCommand("delete from Historial_Tareas where codTarea=" & SQLCodTarea & " and Codigo=" & SQLCodigo & " and convert(char,Etiqueta)='" & SQLEtiqueta & "' and Año=" & SQLAño & " and convert(char,Mes)='" & SQLMes & "'", cn)
                                conectar()
                                'MsgBox(adaptador3.CommandText)
                                'TextBox1.Text = (adaptador3.CommandText)
                                adaptador3.ExecuteNonQuery()
                                desconectar()



#End Region
                            End If


                        Next

                    Next
                    MsgBox("Tareas eliminadas con exito")
                    ' SQLCodTarea

                    '  SQLCodigo
                    desconectar()



                Case 7 'No



            End Select



        End If
    End Sub





    Private Sub txtAño_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtAño.SelectedIndexChanged
        verificarMes(clasecodigo)
    End Sub

    Private Sub txtMeses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtMeses.SelectedIndexChanged
        If CheckBox1.Checked = True Then

#Region "Cargar lista de tareas"
            TabControl1.SelectedTab = TabPage1
            Me.DataGridView2.Select()
            datagr = DataGridView2
            labe1 = Label4


            SQLEtiqueta = txtEtiqueta.Text
            SQLAño = txtAño.Text
            SQLMes = txtMeses.Text

            RevisarTareas()

#End Region

        Else

            SQLEtiqueta = txtEtiqueta.Text
            SQLAño = txtAño.Text
            SQLMes = txtMeses.Text


#Region "Cargar lista de tareas"
            TabControl1.SelectedTab = TabPage1
            Me.DataGridView2.Select()
            datagr = DataGridView2
            labe1 = Label4
            RevisarTareas()

#End Region

#Region "Cargar tareas activas"
            TabControl1.SelectedTab = TabPage2
            Me.DataGridView1.Select()
            datagr = DataGridView1
            labe1 = Label5
            CargarPendientesTareasPlanificacion()
#End Region

#Region "Cargar tareas realizadas"
            TabControl1.SelectedTab = TabPage3
            Me.DataGridView3.Select()
            datagr = DataGridView3
            labe1 = Label7

            CargarPendientesTareasPlanificacionRealizadas()
            EquipoActivo.Text = "Etiqueta: " & txtEtiqueta.Text
            ClaseActivo.Text = "Clase: " & txtClase.Text
            AñoActivo.Text = "Año: " & txtAño.Text
            MesActivo.Text = "Mes: " & txtMeses.Text

#End Region


        End If

        If CheckBox1.Checked = True Then

            TabControl1.SelectedTab = TabPage1
        Else
            TabControl1.SelectedTab = TabPage2
        End If
    End Sub
End Class
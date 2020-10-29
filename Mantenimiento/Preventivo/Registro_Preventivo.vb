Imports System.Data.SqlClient
Public Class Registro_Preventivo
    Dim clasecodigo As Integer
    Dim mes As String
    Private Sub Fecha_DateSelected(sender As Object, e As DateRangeEventArgs) Handles Fecha.DateSelected
        Clase.Visible = True
        Label1.Visible = True
    End Sub

    Private Sub Fecha_DateChanged(sender As Object, e As DateRangeEventArgs) Handles Fecha.DateChanged


#Region "Cargar datos en combobox de Clase"

        mes = Fecha.SelectionStart.Month.ToString
        Select Case mes
            Case "1"
                mes = "Enero"
            Case "2"
                mes = "Febrero"
            Case "3"
                mes = "Marzo"
            Case "4"
                mes = "Abril"
            Case "5"
                mes = "Mayo"
            Case "6"
                mes = "Junio"
            Case "7"
                mes = "Julio"
            Case "8"
                mes = "Agosto"
            Case "9"
                mes = "Septiembre"
            Case "10"
                mes = "Octubre"
            Case "11"
                mes = "Noviembre"
            Case "12"
                mes = "Diciembre"

        End Select

        Try
            Dim cmd As String = "select carac.Clase from ConteoPlanificacion_Equipos conteo, Caracteristicas_Equipo carac where año=" & Fecha.SelectionStart.Year.ToString & "  and " & mes & " <5000 and " & mes & ">0 and conteo.Codigo=carac.Codigo"

            Dim da As New SqlDataAdapter(cmd, cn)
            Dim ds As New DataSet
            da.Fill(ds)
            With Me.Clase
                Me.Clase.DataSource = ds.Tables(0)
                Me.Clase.DisplayMember = "Clase"
            End With
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
#End Region



    End Sub

    Private Sub Registro_Preventivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not formularios.Contains(Me) Then formularios.Add(Me) 'Agrega a la lista los formularios para luego cerrarlos

        Clase.SelectedIndex = -1
        Etiqueta.SelectedIndex = -1
        Responsable.SelectedIndex = -1
    End Sub




    Private Sub Etiqueta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Etiqueta.SelectedIndexChanged
#Region "Verificar etiquetas"
        'En el parentesis entre & & se coloca cual valor se usara para la busqueda
        Dim adaptador As New SqlDataAdapter("select*from Historial_Equipos where convert(char,etiqueta)='" & Etiqueta.Text & "' and Año=" & Fecha.SelectionStart.Year.ToString & " and convert(char,Mes)='" & mes & "'", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "Codigo")

        'El item selecciona de cual columna de la base de datos se conectara y row es la fila
        If ds.Tables("Codigo").Rows.Count > 0 Then
            Finalizado.Visible = False

            Button1.Visible = False

            '    cantidad_equipos = ds.Tables("datos").Rows(0).Item(2).ToString
        Else
            Finalizado.Visible = True

            Button1.Visible = True

#Region "Cargar datos en combobox de Responsable"
            Try
                Dim cmd3 As String = "select*from Usuarios"
                Dim da3 As New SqlDataAdapter(cmd3, cn)
                Dim ds3 As New DataSet
                da3.Fill(ds3)
                With Me.Responsable
                    Me.Responsable.DataSource = ds3.Tables(0)
                    Me.Responsable.DisplayMember = "Nombre"
                End With
                cn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
#End Region


        End If
#End Region
    End Sub

    Private Sub Clase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Clase.SelectedIndexChanged
#Region "Verificar etiquetas"
        'En el parentesis entre & & se coloca cual valor se usara para la busqueda
        Dim adaptador As New SqlDataAdapter("select*from Caracteristicas_Equipo where CONVERT(char,Clase)='" & Clase.Text & "'", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "Codigo")

        'El item selecciona de cual columna de la base de datos se conectara y row es la fila
        If ds.Tables("Codigo").Rows.Count > 0 Then

            clasecodigo = ds.Tables("Codigo").Rows(0).Item(0).ToString


        End If
#End Region

#Region "Cargar datos en combobox de Etiqueta"

        Dim cmd1 As String = "select*from Lista_Equipos where Codigo=" & clasecodigo & ""
        Dim da1 As New SqlDataAdapter(cmd1, cn)
        Dim ds1 As New DataSet
        da1.Fill(ds1)
        With Me.Responsable
            Me.Etiqueta.DataSource = ds1.Tables(0)
            Me.Etiqueta.DisplayMember = "Etiqueta"
            End With
            cn.Close()

#End Region
        Etiqueta.Visible = True
    End Sub

    Private Sub Responsable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Responsable.SelectedIndexChanged
        Comentarios.Visible = True
    End Sub

    Private Sub Comentarios_TextChanged(sender As Object, e As EventArgs) Handles Comentarios.TextChanged
        Finalizado.Visible = True
    End Sub


    Private Sub Finalizado_Click(sender As Object, e As EventArgs) Handles Finalizado.Click
        If Clase.Text = "" Or Etiqueta.Text = "" Or Responsable.Text = "" Or Comentarios.Text = "" Then
            MsgBox("Complete todos los campos para registrar preventivo")
            Exit Sub

        End If



        Dim adaptador As New SqlCommand("insert into Historial_Equipos values (" & clasecodigo & ",'" & Etiqueta.Text & "','" & Comentarios.Text & "','" & Responsable.Text & "', " & Fecha.SelectionStart.Year.ToString & ", '" & mes & "'  ,  '" & Fecha.SelectionStart.ToShortDateString.ToString & "')", cn)
        conectar()
        'TextBox1.Text = adaptador.CommandText
        '  MsgBox(adaptador.CommandText)
        adaptador.ExecuteNonQuery()

        Me.Close()

        desconectar()

#Region "Rebajar de conteo_equipos el mantenimiento del equipo"
        Try
            conectar()
            Dim convermes As Integer = 0
            Dim converletrames As String = ""
            convermes = Fecha.SelectionStart.Month.ToString
            Select Case convermes
                Case 1
                    converletrames = "Enero"
                Case 2
                    converletrames = "Febrero"
                Case 3
                    converletrames = "Marzo"
                Case 4
                    converletrames = "Abril"
                Case 5
                    converletrames = "Mayo"
                Case 6
                    converletrames = "Junio"
                Case 7
                    converletrames = "Julio"
                Case 8
                    converletrames = "Agosto"
                Case 9
                    converletrames = "Septiembre"
                Case 10
                    converletrames = "Octubre"
                Case 11
                    converletrames = "Noviembre"
                Case 12
                    converletrames = "Diciembre"
            End Select


            Dim actualizarcantidadconteo As New SqlCommand("update ConteoPlanificacion_Equipos set " & converletrames & "=" & converletrames & " - 1 where codigo=" & clasecodigo & " and Año=" & Date.Now.Year & "", cn)
            'TextBox1.Text = actualizarnombre.CommandText
            actualizarcantidadconteo.ExecuteNonQuery()
            cn.Close()
            MsgBox("Se registro correctamente")

            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


#End Region
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Clase.Text = "" Or Etiqueta.Text = "" Or Responsable.Text = "" Or Comentarios.Text = "" Then
            MsgBox("Complete todos los campos para registrar preventivo")
            Exit Sub

        End If



        Dim adaptador As New SqlCommand("insert into Historial_Equipos values (" & clasecodigo & ",'" & Etiqueta.Text & "','" & Comentarios.Text & "','" & Responsable.Text & "', " & Fecha.SelectionStart.Year.ToString & ", '" & mes & "'  ,  '" & Fecha.SelectionStart.ToShortDateString.ToString & "')", cn)
        conectar()
        'TextBox1.Text = adaptador.CommandText
        '  MsgBox(adaptador.CommandText)
        adaptador.ExecuteNonQuery()



        desconectar()

#Region "Rebajar de conteo_equipos el mantenimiento del equipo"
        Try
            conectar()
            Dim convermes As Integer = 0
            Dim converletrames As String = ""
            convermes = Fecha.SelectionStart.Month.ToString
            Select Case convermes
                Case 1
                    converletrames = "Enero"
                Case 2
                    converletrames = "Febrero"
                Case 3
                    converletrames = "Marzo"
                Case 4
                    converletrames = "Abril"
                Case 5
                    converletrames = "Mayo"
                Case 6
                    converletrames = "Junio"
                Case 7
                    converletrames = "Julio"
                Case 8
                    converletrames = "Agosto"
                Case 9
                    converletrames = "Septiembre"
                Case 10
                    converletrames = "Octubre"
                Case 11
                    converletrames = "Noviembre"
                Case 12
                    converletrames = "Diciembre"
            End Select


            Dim actualizarcantidadconteo As New SqlCommand("update ConteoPlanificacion_Equipos set " & converletrames & "=" & converletrames & " - 1 where codigo=" & clasecodigo & " and Año=" & Date.Now.Year & "", cn)
            'TextBox1.Text = actualizarnombre.CommandText
            actualizarcantidadconteo.ExecuteNonQuery()
            cn.Close()
            MsgBox("Se registro correctamente")

            Finalizado.Visible = False
            Button1.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


#End Region
    End Sub
End Class
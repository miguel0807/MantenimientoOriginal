Imports System.Data.SqlClient
Public Class Ejecucion_Preventivo
    Dim codigo As String = ""
    Private Sub Ejecucion_Preventivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not formularios.Contains(Me) Then formularios.Add(Me) 'Agrega a la lista los formularios para luego cerrarlos


#Region "Cargar datos en combobox de Clase"
        Try
            Dim cmd As String = "select*from Caracteristicas_Equipo"
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
#Region "Cargar datos en combobox de Clase"
        Try
            Dim cmd As String = "select*from Usuarios"
            Dim da As New SqlDataAdapter(cmd, cn)
            Dim ds As New DataSet
            da.Fill(ds)
            With Me.Responsable
                Me.Responsable.DataSource = ds.Tables(0)
                Me.Responsable.DisplayMember = "Nombre"
            End With
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
#End Region


    End Sub

    Private Sub Clase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Clase.SelectedIndexChanged

        Select Case Clase.Text

            Case Clase.Text


                'En el parentesis entre & & se coloca cual valor se usara para la busqueda
                Dim adaptador As New SqlDataAdapter("select*from Caracteristicas_Equipo where convert(char,Clase) ='" & Clase.Text & "'", cn)
                Dim ds As New DataSet
                adaptador.Fill(ds, "datos")

                'El item selecciona de cual columna de la base de datos se conectara y row es la fila
                If ds.Tables("datos").Rows.Count > 0 Then

                    codigo = ds.Tables("datos").Rows(0).Item(0).ToString

#Region "Cargar datos en combobox de Etiqueta"
                    Try
                        Dim cmd As String = "select*from Lista_Equipos where codigo= " & codigo & ""
                        Dim da As New SqlDataAdapter(cmd, cn)
                        Dim ds1 As New DataSet
                        da.Fill(ds1)
                        With Me.Etiqueta
                            Me.Etiqueta.DataSource = ds1.Tables(0)
                            Me.Etiqueta.DisplayMember = "Etiqueta"
                        End With
                        cn.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
#End Region
                End If





        End Select
    End Sub

    Private Sub Finalizado_Click(sender As Object, e As EventArgs) Handles Finalizado.Click

        If Clase.Text = "" Or Etiqueta.Text = "" Or Responsable.Text = "" Or Comentarios.Text = "" Then
            MsgBox("Complete todos los campos para registrar preventivo")
            Exit Sub

        End If



        Dim adaptador As New SqlCommand("insert into Historial_Equipos values (" & codigo & ",'" & Etiqueta.Text & "','" & Comentarios.Text & "','" & Responsable.Text & "','" & Fecha.SelectionStart.ToShortDateString.ToString & "')", cn)
        conectar()
        'TextBox1.Text = adaptador.CommandText

        adaptador.ExecuteNonQuery()
        MsgBox("Se registro correctamente")
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


            Dim actualizarcantidadconteo As New SqlCommand("update ConteoPlanificacion_Equipos set " & converletrames & "=" & converletrames & " - 1 where codigo=" & codigo & " and Año=" & Date.Now.Year & "", cn)
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

    Private Sub Etiqueta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Etiqueta.SelectedIndexChanged

    End Sub
End Class
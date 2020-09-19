Imports System.Data.SqlClient

Public Class Indicadores_Editable
    Public Caso As Integer

    Dim count As Integer
    Dim hora As Integer
    Dim minuto As Integer
    Dim acumhora As Integer
    Dim acumminuto As Integer
    Dim almacenar As Boolean = False


    Dim minutodivision As Integer
    Dim minutoresta As Integer
    Dim minutototal As Integer


    Dim seleccion As Integer = 0




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
#Region "Colocacion de fecha cuando se genera la licencia"


            Fecha.Text = DateTime.Now
            Dim fechacreacion As Date
            fechacreacion = Fecha.Text
            Fecha.Text = Format(fechacreacion, "yyyy/MM/dd HH:mm")
#End Region

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
#Region "Colocacion de fecha cuando se genera la licencia"


            fecha_final.Text = DateTime.Now
            Dim fechacreacion As Date
            fechacreacion = fecha_final.Text
            fecha_final.Text = Format(fechacreacion, "yyyy/MM/dd HH:mm")
#End Region

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            If panel_boton.Visible = True Then
                panel_boton.Visible = False
                Button5.Text = "Control de tiempo"
            Else
                panel_boton.Visible = True
                Button5.Text = "Inicio"

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
#Region "Colocacion de fecha cuando se genera la licencia"


            Tiempo_Inicio.Text = DateTime.Now
            Dim fechacreacion As Date
            fechacreacion = Tiempo_Inicio.Text
            Tiempo_Inicio.Text = Format(fechacreacion, "HH:mm")
#End Region

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
#Region "Colocacion de fecha cuando se genera la licencia"


            Tiempo_Final.Text = DateTime.Now
            Dim fechacreacion As Date
            fechacreacion = Tiempo_Final.Text
            Tiempo_Final.Text = Format(fechacreacion, "HH:mm")
#End Region

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            If Tiempo_Inicio.Text = "" Or Tiempo_Final.Text = "" Then
                MsgBox("Favor complete los tiempos")
            Else
                Dim minutos As String


                Dim FechaEntrada As String = Tiempo_Inicio.Text
                Dim FechaSalida As String = Tiempo_Final.Text
                Dim IntMinutos As Double



                minutos = DateDiff(DateInterval.Minute, CDate(FechaEntrada), CDate(FechaSalida))

                IntMinutos = minutos

                hora = Math.Truncate(IntMinutos / 60)

                minuto = Math.Truncate(IntMinutos - (hora * 60))

                If hora = 1 Then
                    calhoras.Text = hora & " hora"
                Else
                    calhoras.Text = hora & " horas"
                End If

                If minuto = 1 Then
                    calminutos.Text = minuto & " minuto"
                Else
                    calminutos.Text = minuto & " minutos"
                End If

                almacenar = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            If almacenar = True Then
            acumhora = txtacuhora.Text
            acumhora = acumhora + hora

            acumminuto = txtacuminutos.Text
            If minuto + acumminuto >= 60 Then
                minutodivision = Math.Truncate((minuto + acumminuto) / 60)
                minutoresta = (minuto + acumminuto) - (minutodivision * 60)
                acumminuto = minutoresta

                acumhora = acumhora + minutodivision
            Else
                acumminuto = acumminuto + minuto
            End If


            Tiempo_Inicio.Text = "00:00"
            Tiempo_Final.Text = "00:00"
            calhoras.Text = 0
            calminutos.Text = 0



            txtacuhora.Text = acumhora
            txtacuminutos.Text = acumminuto
        End If
        almacenar = False


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub



    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            If Nombre.Text = "" Or Fecha.Text = "" Then
                MsgBox("Necesita completar problema y fecha de inicio")
            Else


                If Tiempo_Inicio.Text = "00:00:00" Then
                    seleccion = 0
                Else


                    seleccion = 1
                End If

                conectar()
                Dim actualizarnombre As New SqlCommand("Update Indicadores SET Nombre =('" & Nombre.Text & "'), Ubicacion =('" & Ubicacion.Text & "'), Clasificacion =('" & Clasificacion.Text & "') , Descripcion =('" & Descripcion.Text & "'), [Fecha Inicial] =('" & Fecha.Text & "'), [Fecha Final] =('" & fecha_final.Text & "'), [Estado] =(" & 1 & "), [Tiempo Inicial]= ('" & Tiempo_Inicio.Text & "'), [Horas]= ('" & txtacuhora.Text & "'), [Minutos]= ('" & txtacuminutos.Text & "'),[Seleccion]=( " & seleccion & ")  where [Caso] = ('" & Caso & "')", cn)
                'TextBox1.Text = actualizarnombre.CommandText
                actualizarnombre.ExecuteNonQuery()
                    cn.Close()
                    MsgBox("Se registro correctamente")


                    Me.Close()
                End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



        Try
            conectar()

            Dim etiqueta As String
            etiqueta = 1



            Dim tabla As DataGridView = Indicadores_Proceso.DataGridView1
            Dim adaptador As New SqlDataAdapter("select*from Indicadores where Estado=" & etiqueta & "", cn)
            Dim dataS As New DataSet
            adaptador.Fill(dataS, "Indicadores")

            tabla.DataSource = dataS.Tables("Indicadores")
            tabla.RowHeadersVisible = False
            tabla.Columns.Item(6).Visible = False
            tabla.Columns.Item(7).Visible = False
            tabla.Columns.Item(0).Visible = False



            tabla.Columns(1).Width = 200
            tabla.Columns(2).Width = 130
            tabla.Columns(3).Width = 170
            tabla.Columns(4).Width = 267
            tabla.Columns(5).Width = 100

            'Habilita conteo de filas en datagridview
            Indicadores_Proceso.Label1.Visible = True
            ' Label8.Text = tabla.DisplayedRowCount(0) - 1
            Indicadores_Proceso.Label1.Text = "Casos pendientes: " & tabla.RowCount
            Indicadores_Proceso.conteo_total = tabla.RowCount
            desconectar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If Nombre.Text = "" Or Fecha.Text = "" Or fecha_final.Text = "" Or Descripcion.Text = "" Then
                MsgBox("Complete todos los campos para poder Finalizar")
            Else


                conectar()
                Dim actualizarnombre As New SqlCommand("Update Indicadores SET Nombre =('" & Nombre.Text & "'), Ubicacion =('" & Ubicacion.Text & "'), Clasificacion =('" & Clasificacion.Text & "') , Descripcion =('" & Descripcion.Text & "'), [Fecha Inicial] =('" & Fecha.Text & "'), [Fecha Final] =('" & fecha_final.Text & "'), [Estado] =(" & 0 & "), [Tiempo Inicial]= ('" & Tiempo_Inicio.Text & "'), [Horas]= ('" & txtacuhora.Text & "'), [Minutos]= ('" & txtacuminutos.Text & "')  where [Caso] = ('" & Caso & "')", cn)
                'TextBox1.Text = actualizarnombre.CommandText
                actualizarnombre.ExecuteNonQuery()
                cn.Close()
                MsgBox("Se registro correctamente")


                Me.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



        Try
            conectar()

            Dim etiqueta As String
            etiqueta = 1



            Dim tabla As DataGridView = Indicadores_Proceso.DataGridView1
            Dim adaptador As New SqlDataAdapter("select*from Indicadores where Estado=" & etiqueta & "", cn)
            Dim dataS As New DataSet
            adaptador.Fill(dataS, "Indicadores")

            tabla.DataSource = dataS.Tables("Indicadores")
            tabla.RowHeadersVisible = False
            tabla.Columns.Item(6).Visible = False
            tabla.Columns.Item(7).Visible = False
            tabla.Columns.Item(0).Visible = False



            tabla.Columns(1).Width = 200
            tabla.Columns(2).Width = 130
            tabla.Columns(3).Width = 170
            tabla.Columns(4).Width = 267
            tabla.Columns(5).Width = 100

            'Habilita conteo de filas en datagridview
            Indicadores_Proceso.Label1.Visible = True
            ' Label8.Text = tabla.DisplayedRowCount(0) - 1
            Indicadores_Proceso.Label1.Text = "Casos pendientes: " & tabla.RowCount
            Indicadores_Proceso.conteo_total = tabla.RowCount
            desconectar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)

    End Sub
End Class
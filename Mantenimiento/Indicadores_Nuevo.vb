Imports System.Data.SqlClient

Public Class Indicadores_Nuevo

    Dim count As Integer
    Dim hora As Integer
    Dim minuto As Integer
    Dim acumhora As Integer
    Dim acumminuto As Integer
    Dim almacenar As Boolean = False
    Dim seleccion As Integer = 0


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Try
            If Nombre.Text = "" Or Fecha.Text = "" Then
                MsgBox("Necesita completar problema y fecha de inicio")
            Else


                If Tiempo_Inicio.Text = "00:00:00" Then
                    seleccion = 0
                Else


                    seleccion = 1
                End If
                Dim adaptador As New SqlCommand("insert into Indicadores values (" & count & ",'" & Nombre.Text & "','" & Ubicacion.Text & "','" & Clasificacion.Text & "','" & Descripcion.Text & "','" & Fecha.Text & "','" & fecha_final.Text & "'," & 1 & ",'" & Tiempo_Inicio.Text & "'," & acuhora.Text & "," & acuminutos.Text & "," & seleccion & ")", cn)
                conectar()
                adaptador.ExecuteNonQuery()
                MsgBox("Se registro correctamente")
                desconectar()
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If Nombre.Text = "" Or Fecha.Text = "" Or fecha_final.Text = "" Or Descripcion.Text = "" Then
                MsgBox("Complete todos los campos para poder Finalizar")
            Else


                Dim adaptador As New SqlCommand("insert into Indicadores values (" & count & ",'" & Nombre.Text & "','" & Ubicacion.Text & "','" & Clasificacion.Text & "','" & Descripcion.Text & "','" & Fecha.Text & "','" & fecha_final.Text & "'," & 0 & ",'" & Tiempo_Inicio.Text & "'," & acuhora.Text & "," & acuminutos.Text & ")", cn)
                conectar()
                adaptador.ExecuteNonQuery()
                MsgBox("Se registro correctamente")
                desconectar()
                Me.Close()
            End If


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

    Private Sub Indicadores_Nuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conectar()

            Dim Query As String
            Query = ("select COUNT (Estado) from Indicadores")
            Dim cmd As New SqlCommand(Query, cn)
            count = cmd.ExecuteScalar
            Label3.Text = count
            Label3.Text = "Caso #" + Label3.Text
            'Coloca la cantidad de filas que hay en la tabla temporal
            desconectar()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If panel_boton.Visible = True Then
            panel_boton.Visible = False
            Button5.Text = "Control de tiempo"
        Else
            panel_boton.Visible = True
            Button5.Text = "Inicio"

        End If


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






    End Sub

    Private Sub panel_boton_Paint(sender As Object, e As PaintEventArgs) Handles panel_boton.Paint

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        If almacenar = True Then

            acumhora = acumhora + hora
            acumminuto = acumminuto + minuto

            Tiempo_Inicio.Text = ""
            Tiempo_Final.Text = ""
            calhoras.Text = 0
            calminutos.Text = 0



            acuhora.Text = acumhora
            acuminutos.Text = acumminuto
        End If
        almacenar = False









    End Sub
End Class
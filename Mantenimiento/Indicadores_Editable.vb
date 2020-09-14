Imports System.Data.SqlClient

Public Class Indicadores_Editable
    Public Caso As Integer

    Dim count As Integer
    Dim hora As Integer
    Dim minuto As Integer
    Dim acumhora As Integer
    Dim acumminuto As Integer
    Dim almacenar As Boolean = False
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Try
        If Nombre.Text = "" Or Fecha.Text = "" Or fecha_final.Text = "" Or Descripcion.Text = "" Then
                MsgBox("Complete todos los campos para poder Finalizar")
            Else


                conectar()
            Dim actualizarnombre As New SqlCommand("Update Indicadores SET Nombre =('" & Nombre.Text & "'), Ubicacion =('" & Ubicacion.Text & "'), Clasificacion =('" & Clasificacion.Text & "') , Descripcion =('" & Descripcion.Text & "'), [Fecha Inicial] =('" & Fecha.Text & "'), [Fecha Final] =('" & fecha_final.Text & "'), [Estado] =(" & 0 & "), [Tiempo Inicial]= ('" & Tiempo_Inicio.Text & "'), [Horas]= ('" & acuhora.Text & "'), [Minutos]= ('" & acuminutos.Text & "')  where [Caso] = ('" & Caso & "')", cn)
            'TextBox1.Text = actualizarnombre.CommandText
            actualizarnombre.ExecuteNonQuery()
            cn.Close()
                MsgBox("Se registro correctamente")


            Me.Close()
        End If

        'Catch ex As Exception
        'MsgBox(ex.Message)
        'End Try



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

    Private Sub Indicadores_Editable_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub panel_boton_Paint(sender As Object, e As PaintEventArgs) Handles panel_boton.Paint

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

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        If almacenar = True Then
            acumhora = acuhora.Text
            acumhora = acumhora + hora

            acumminuto = acuminutos.Text
            acumminuto = acumminuto + minuto

            Tiempo_Inicio.Text = "00:00"
            Tiempo_Final.Text = "00:00"
            calhoras.Text = 0
            calminutos.Text = 0



            acuhora.Text = acumhora
            acuminutos.Text = acumminuto
        End If
        almacenar = False



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            If Nombre.Text = "" Or Fecha.Text = "" Then
                MsgBox("Necesita completar problema y fecha de inicio")
            Else

                conectar()
                Dim actualizarnombre As New SqlCommand("Update Indicadores SET Nombre =('" & Nombre.Text & "'), Ubicacion =('" & Ubicacion.Text & "'), Clasificacion =('" & Clasificacion.Text & "') , Descripcion =('" & Descripcion.Text & "'), [Fecha Inicial] =('" & Fecha.Text & "'), [Fecha Final] =('" & fecha_final.Text & "'), [Estado] =(" & 1 & "), [Tiempo Inicial]= ('" & Tiempo_Inicio.Text & "'), [Horas]= ('" & acuhora.Text & "'), [Minutos]= ('" & acuminutos.Text & "')  where [Caso] = ('" & Caso & "')", cn)
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
End Class
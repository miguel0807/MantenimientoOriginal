Imports System.Data.SqlClient

Public Class Indicadores_Editable
    Public Caso As Integer
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If Nombre.Text = "" Or Fecha.Text = "" Or fecha_final.Text = "" Or Descripcion.Text = "" Then
                MsgBox("Complete todos los campos para poder Finalizar")
            Else


                conectar()
                Dim actualizarnombre As New SqlCommand("Update Indicadores SET Nombre =('" & Nombre.Text & "'  ), Ubicacion =('" & Ubicacion.Text & "'), Clasificacion =('" & Clasificacion.Text & "') , Descripcion =('" & Descripcion.Text & "'), [Fecha Inicial] =('" & Fecha.Text & "'), [Fecha Final] =('" & fecha_final.Text & "'), [Estado] =(" & 0 & ")  where [Caso] = ('" & Caso & "')", cn)

                actualizarnombre.ExecuteNonQuery()
                cn.Close()
                MsgBox("Se registro correctamente")

                ' MsgBox(actualizarnombre.CommandText)
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
End Class
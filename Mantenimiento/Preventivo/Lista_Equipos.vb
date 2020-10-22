Imports System.Data.SqlClient
Public Class Lista_Equipos
    Public conteo As Integer



    Private Sub Tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tipo.SelectedIndexChanged
        Select Case Tipo.Text


            Case "Equipos"
                detalle.Visible = False
                detalle.Enabled = False


            Case "Clase"
                detalle.Visible = True
                detalle.Enabled = True


                Try
                    Dim cmd As String = "select*from Caracteristicas_Equipo"
                    Dim da As New SqlDataAdapter(cmd, cn)
                    Dim ds As New DataSet
                    da.Fill(ds)
                    With Me.detalle
                        Me.detalle.DataSource = ds.Tables(0)
                        Me.detalle.DisplayMember = "Clase"
                    End With

                    cn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            Case "Clasificacion"
                detalle.Visible = True

                detalle.Enabled = True


                Try
                    Dim cmd As String = "select*from Clasificacion_Datos"
                    Dim da As New SqlDataAdapter(cmd, cn)
                    Dim ds As New DataSet
                    da.Fill(ds)
                    With Me.detalle
                        Me.detalle.DataSource = ds.Tables(0)
                        Me.detalle.DisplayMember = "Clasificacion"
                    End With
                    cn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            Case "Frecuencia"
                detalle.Visible = True

                detalle.Enabled = True

                Try
                    Dim cmd As String = "select*from Frecuencia_Datos"
                    Dim da As New SqlDataAdapter(cmd, cn)
                    Dim ds As New DataSet
                    da.Fill(ds)
                    With Me.detalle
                        Me.detalle.DataSource = ds.Tables(0)
                        Me.detalle.DisplayMember = "Frecuencia"
                    End With
                    cn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try


        End Select
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Select Case Tipo.Text
            Case "Equipos"
                busqueda_equipos()

            Case "Clase"
                busqueda_clase()

            Case "Clasificacion"
                busqueda_clasificacion()

            Case "Frecuencia"
                busqueda_frecuencia()
        End Select


    End Sub


End Class
﻿Imports System.Data.SqlClient
Public Class Clase_Preventivo
    Dim count As Integer
    Private Sub Crear_Click(sender As Object, e As EventArgs) Handles Crear.Click



        If Clase.Text = "" And Frecuencia.Text = "" And Clasificacion.Text = "" And Provedor.Text = "" Then
                MsgBox("Complete todos los campos para crear nueva clase")
                Exit Sub

            End If



        Dim adaptador As New SqlCommand("insert into Caracteristicas_Equipo values (" & count & ",'" & Clase.Text & "','" & Frecuencia.Text & "','" & Clasificacion.Text & "','" & Provedor.Text & "')", cn)
        conectar()
        'TextBox1.Text = adaptador.CommandText
        adaptador.ExecuteNonQuery()
        MsgBox("Se registro correctamente")
        Me.Close()

        desconectar()


    End Sub

    Private Sub Clase_Preventivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            conectar()

            Dim Query As String
            Query = ("select COUNT (Codigo) from Caracteristicas_Equipo")
            Dim cmd As New SqlCommand(Query, cn)
            count = cmd.ExecuteScalar
            Label5.Text = "Codigo =" & count
            'Coloca la cantidad de filas que hay en la tabla temporal
            desconectar()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

#Region "Cargar datos en combobox de frecuencia"
        Try
            Dim cmd As String = "select*from Frecuencia_Datos"
            Dim da As New SqlDataAdapter(cmd, cn)
            Dim ds As New DataSet
            da.Fill(ds)
            With Me.Frecuencia
                Me.Frecuencia.DataSource = ds.Tables(0)
                Me.Frecuencia.DisplayMember = "Frecuencia"
            End With
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
#End Region

#Region "Cargar datos en combobox de Clasificacion"
        Try
            Dim cmd As String = "select*from Clasificacion_Datos"
            Dim da As New SqlDataAdapter(cmd, cn)
            Dim ds As New DataSet
            da.Fill(ds)
            With Me.Clasificacion
                Me.Clasificacion.DataSource = ds.Tables(0)
                Me.Clasificacion.DisplayMember = "Clasificacion"
            End With
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
#End Region

#Region "Cargar datos en combobox de Provedor"
        Try
            Dim cmd As String = "select*from Provedor_Datos"
            Dim da As New SqlDataAdapter(cmd, cn)
            Dim ds As New DataSet
            da.Fill(ds)
            With Me.Provedor
                Me.Provedor.DataSource = ds.Tables(0)
                Me.Provedor.DisplayMember = "Provedor"
            End With
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
#End Region
    End Sub
End Class
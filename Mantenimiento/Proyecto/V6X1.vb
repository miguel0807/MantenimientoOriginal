﻿Imports System.Data.SqlClient
Imports vb = Microsoft.VisualBasic
Imports Common

Public Class V6X1
    Public tiempo As Integer = 0
    Public basedatos(5) As String
    Public manual As Boolean = False
    Dim caja As String
    Dim orden As String
    Dim nombre As String

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles refrescar2.Click
        MaskedTextBox2.Text = ""
        bueno2.Visible = False
        igual2.Visible = False
        equis2.Visible = False
        refrescar2.Visible = False

        MaskedTextBox2.ReadOnly = False
        MaskedTextBox2.Enabled = True
        MaskedTextBox2.Focus()

        MaskedTextBox2.BackColor = Color.White
        manual = True



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles botoncaja.Click
        textboxcaja.Text = ""



        botonAutomatico.Enabled = False
        MaskedTextBox1.Clear()
        MaskedTextBox2.Clear()
        MaskedTextBox3.Clear()
        MaskedTextBox4.Clear()
        MaskedTextBox5.Clear()
        MaskedTextBox6.Clear()
        txtBasedatos6.Clear()
        txtBasedatos5.Clear()
        txtBasedatos4.Clear()
        txtBasedatos3.Clear()
        txtBasedatos2.Clear()
        txtBasedatos1.Clear()
        textboxcaja.Enabled = True
        textboxcaja.Focus()


        igual1.Visible = False
        igual2.Visible = False
        igual3.Visible = False
        igual4.Visible = False
        igual5.Visible = False
        igual6.Visible = False


        bueno1.Visible = False
        bueno2.Visible = False
        bueno3.Visible = False
        bueno4.Visible = False
        bueno5.Visible = False
        bueno6.Visible = False

        txtBasedatos1.BackColor = SystemColors.Control
        txtBasedatos2.BackColor = SystemColors.Control
        txtBasedatos3.BackColor = SystemColors.Control
        txtBasedatos4.BackColor = SystemColors.Control
        txtBasedatos5.BackColor = SystemColors.Control
        txtBasedatos6.BackColor = SystemColors.Control
        Label1.Text = "Caja # "

    End Sub



    Private Sub caja_LostFocus(sender As Object, e As EventArgs) Handles textboxcaja.LostFocus
        CircularProgressBar1.Visible = False
        Timer1.Enabled = False
        textboxcaja.Enabled = False
    End Sub

    Private Sub caja_TextChanged(sender As Object, e As EventArgs) Handles textboxcaja.TextChanged
        Try


            Dim entrada As String
            Dim contador As Integer
            entrada = textboxcaja.Text
            contador = Len(entrada)
            If contador = 1 Then
                Timer1.Start()
            End If

            If contador = 13 Then
                If IsNumeric(textboxcaja.Text) Then

                    botonAutomatico.Enabled = True

                    Dim extraccion As String = textboxcaja.Text


                    orden = vb.Mid(extraccion, 1, 8)
                    caja = vb.Mid(extraccion, 9, 5)
                    Label1.Text = "Caja #" & (caja - 90000)

#Region "Orden de produccion"
#Region "Conectarse a SAP"

                    'En el parentesis entre & & se coloca cual valor se usara para la busqueda
                    Dim adaptador As New SqlDataAdapter("select * from BaseDatosOficial where [Order]=" & orden & " and [Verificado]=" & 0 & " and [Caja]=" & caja & "", cn) 'Funciona con lote y material



                    Dim ds As New DataSet
                    adaptador.Fill(ds, "datos")



#End Region
#Region "Pregunta"
                    'El item selecciona de cual columna de la base de datos se conectara y row es la fila
                    If ds.Tables("datos").Rows.Count > 0 Then
                        txtBasedatos1.Text = ds.Tables("datos").Rows(0).Item(1).ToString
                        txtBasedatos2.Text = ds.Tables("datos").Rows(1).Item(1).ToString
                        txtBasedatos3.Text = ds.Tables("datos").Rows(2).Item(1).ToString
                        txtBasedatos4.Text = ds.Tables("datos").Rows(3).Item(1).ToString
                        txtBasedatos5.Text = ds.Tables("datos").Rows(4).Item(1).ToString
                        txtBasedatos6.Text = ds.Tables("datos").Rows(5).Item(1).ToString



                        basedatos(0) = txtBasedatos1.Text
                        basedatos(1) = txtBasedatos2.Text
                        basedatos(2) = txtBasedatos3.Text
                        basedatos(3) = txtBasedatos4.Text
                        basedatos(4) = txtBasedatos5.Text
                        basedatos(5) = txtBasedatos6.Text


                    Else

                        MsgBox("La caja ya se encuentra registrada")
                        botoncaja.Focus()
                        botonAutomatico.Enabled = False
                        Label1.Text = "Caja # "
                        Exit Sub
                    End If
#End Region
#End Region

                Else
                    MsgBox("QR Invalido")
                    textboxcaja.Text = ""
                    botoncaja.Focus()
                End If
            End If
            CircularProgressBar1.Visible = False
            botonAutomatico.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Interval = 500
        controlTimer.Text = controlTimer.Text + 1
        Dim entrada As String
        Dim contador As Integer
        entrada = textboxcaja.Text
        contador = Len(entrada)

        If controlTimer.Text = 6 Then



            If contador < 11 Then
                MsgBox("Favor utilizar el scaner")

                controlTimer.Text = 0
                textboxcaja.Text = ""
                Timer1.Stop()
                botoncaja.Focus()
            End If
            If contador >= 14 Then
                MsgBox("Favor utilizar el scaner")

                controlTimer.Text = 0
                textboxcaja.Text = ""
                Timer1.Stop()
                botoncaja.Focus()
            End If




        End If
        If controlTimer.Text = 7 Then
            controlTimer.Text = 0
            Timer1.Stop()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles botonAutomatico.Click




        MaskedTextBox1.Clear()
        MaskedTextBox2.Clear()
        MaskedTextBox3.Clear()
        MaskedTextBox4.Clear()
        MaskedTextBox5.Clear()
        MaskedTextBox6.Clear()


        MaskedTextBox1.BackColor = Color.White
        MaskedTextBox2.BackColor = Color.White
        MaskedTextBox3.BackColor = Color.White
        MaskedTextBox4.BackColor = Color.White
        MaskedTextBox5.BackColor = Color.White
        MaskedTextBox6.BackColor = Color.White

        MaskedTextBox1.Enabled = True
        MaskedTextBox1.Focus()
        tiempo = 0


        igual1.Visible = False
        igual2.Visible = False
        igual3.Visible = False
        igual4.Visible = False
        igual5.Visible = False
        igual6.Visible = False

        bueno1.Visible = False
        bueno2.Visible = False
        bueno3.Visible = False
        bueno4.Visible = False
        bueno5.Visible = False
        bueno6.Visible = False

        refrescar1.Visible = False
        refrescar2.Visible = False
        refrescar3.Visible = False
        refrescar4.Visible = False
        refrescar5.Visible = False
        refrescar6.Visible = False

        equis1.Visible = False
        equis2.Visible = False
        equis3.Visible = False
        equis4.Visible = False
        equis5.Visible = False
        equis6.Visible = False

        txtBasedatos1.BackColor = SystemColors.Control
        txtBasedatos2.BackColor = SystemColors.Control
        txtBasedatos3.BackColor = SystemColors.Control
        txtBasedatos4.BackColor = SystemColors.Control
        txtBasedatos5.BackColor = SystemColors.Control
        txtBasedatos6.BackColor = SystemColors.Control

        manual = False
    End Sub





    Private Sub MaskedTextBox1_LostFocus(sender As Object, e As EventArgs) Handles MaskedTextBox1.LostFocus
        CircularProgressBar2.Visible = False
        Botella1.Enabled = False
        tiempo = 0
        MaskedTextBox1.Enabled = False



    End Sub




    Private Sub MaskedTextBox1_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBox1.TextChanged
        Dim entrada1 As String
        Dim contador2 As Integer
        entrada1 = MaskedTextBox1.Text
        contador2 = Len(entrada1)

        If contador2 = 14 Then


            Botella1.Enabled = True
            For Each elemento As String In basedatos
                If MaskedTextBox1.Text = elemento Then
                    Dim ret As Integer = Array.IndexOf(basedatos, elemento)
                    ' devuelve posicion de array encontrado 



                    If ret = 0 Then
                        txtBasedatos1.BackColor = Color.ForestGreen
                        bueno1.Visible = True
                        refrescar1.Visible = False
                        igual1.Visible = False
                        equis1.Visible = False

                    End If

                    If ret = 1 Then
                        txtBasedatos2.BackColor = Color.ForestGreen
                        bueno1.Visible = True
                        refrescar1.Visible = False
                        igual1.Visible = False
                        equis1.Visible = False
                    End If

                    If ret = 2 Then
                        txtBasedatos3.BackColor = Color.ForestGreen
                        bueno1.Visible = True
                        refrescar1.Visible = False
                        igual1.Visible = False
                        equis1.Visible = False
                    End If

                    If ret = 3 Then
                        txtBasedatos4.BackColor = Color.ForestGreen
                        bueno1.Visible = True
                        refrescar1.Visible = False
                        igual1.Visible = False
                        equis1.Visible = False
                    End If

                    If ret = 4 Then
                        txtBasedatos5.BackColor = Color.ForestGreen
                        bueno1.Visible = True
                        refrescar1.Visible = False
                        igual1.Visible = False
                        equis1.Visible = False
                    End If

                    If ret = 5 Then
                        txtBasedatos6.BackColor = Color.ForestGreen
                        bueno1.Visible = True
                        refrescar1.Visible = False
                        igual1.Visible = False
                        equis1.Visible = False
                    End If


                End If
                If MaskedTextBox1.Text = MaskedTextBox2.Text Or MaskedTextBox1.Text = MaskedTextBox3.Text Or MaskedTextBox1.Text = MaskedTextBox4.Text Or MaskedTextBox1.Text = MaskedTextBox5.Text Or MaskedTextBox1.Text = MaskedTextBox6.Text Then
                        MaskedTextBox1.BackColor = Color.LightSlateGray
                        bueno1.Visible = False
                        equis1.Visible = False
                        igual1.Visible = True
                        refrescar1.Visible = True
                    End If



                If MaskedTextBox1.Text = MaskedTextBox2.Text Or MaskedTextBox1.Text = MaskedTextBox3.Text Or MaskedTextBox1.Text = MaskedTextBox4.Text Or MaskedTextBox1.Text = MaskedTextBox5.Text Or MaskedTextBox1.Text = MaskedTextBox6.Text Or MaskedTextBox1.Text = txtBasedatos1.Text Or MaskedTextBox1.Text = txtBasedatos2.Text Or MaskedTextBox1.Text = txtBasedatos3.Text Or MaskedTextBox1.Text = txtBasedatos4.Text Or MaskedTextBox1.Text = txtBasedatos5.Text Or MaskedTextBox1.Text = txtBasedatos6.Text Then

                Else
                    MaskedTextBox1.BackColor = Color.LightSlateGray
                    igual1.Visible = False
                    bueno1.Visible = False
                    equis1.Visible = True
                    refrescar1.Visible = True

                End If

            Next
        End If




    End Sub



    Private Sub MaskedTextBox2_LostFocus(sender As Object, e As EventArgs) Handles MaskedTextBox2.LostFocus





        CircularProgressBar3.Visible = False
        Botella2.Enabled = False
        tiempo = 0
        MaskedTextBox2.Enabled = False

    End Sub

    Private Sub MaskedTextBox2_GotFocus(sender As Object, e As EventArgs) Handles MaskedTextBox2.GotFocus

        CircularProgressBar3.Visible = True

        MaskedTextBox2.Clear()
    End Sub



    Private Sub MaskedTextBox3_GotFocus(sender As Object, e As EventArgs) Handles MaskedTextBox3.GotFocus
        If manual = False Then
            CircularProgressBar4.Visible = True
        End If
        MaskedTextBox3.Clear()
    End Sub

    Private Sub MaskedTextBox3_LostFocus(sender As Object, e As EventArgs) Handles MaskedTextBox3.LostFocus
        CircularProgressBar4.Visible = False
        Botella3.Enabled = False
        tiempo = 0
        MaskedTextBox3.Enabled = False

    End Sub






    Private Sub MaskedTextBox2_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBox2.TextChanged
        Dim entrada1 As String
        Dim contador2 As Integer
        entrada1 = MaskedTextBox2.Text
        contador2 = Len(entrada1)


        If contador2 = 14 Then

            Botella2.Enabled = True




            For Each elemento As String In basedatos
                If MaskedTextBox2.Text = elemento Then
                    Dim ret As Integer = Array.IndexOf(basedatos, elemento)
                    ' devuelve posicion de array encontrado 


                    If ret = 0 Then

                        txtBasedatos1.BackColor = Color.ForestGreen
                        bueno2.Visible = True
                        refrescar2.Visible = False
                        igual2.Visible = False
                        equis2.Visible = False


                    End If

                    If ret = 1 Then
                        txtBasedatos2.BackColor = Color.ForestGreen
                        bueno2.Visible = True
                        refrescar2.Visible = False
                        igual2.Visible = False
                        equis2.Visible = False
                    End If

                    If ret = 2 Then
                        txtBasedatos3.BackColor = Color.ForestGreen
                        bueno2.Visible = True
                        refrescar2.Visible = False
                        igual2.Visible = False
                        equis2.Visible = False
                    End If

                    If ret = 3 Then
                        txtBasedatos4.BackColor = Color.ForestGreen
                        bueno2.Visible = True
                        refrescar2.Visible = False
                        igual2.Visible = False
                        equis2.Visible = False
                    End If

                    If ret = 4 Then
                        txtBasedatos5.BackColor = Color.ForestGreen
                        bueno2.Visible = True
                        refrescar2.Visible = False
                        igual2.Visible = False
                        equis2.Visible = False
                    End If

                    If ret = 5 Then
                        txtBasedatos6.BackColor = Color.ForestGreen
                        bueno2.Visible = True
                        refrescar2.Visible = False
                        igual2.Visible = False
                        equis2.Visible = False
                    End If





                End If

                If MaskedTextBox2.Text = MaskedTextBox1.Text Or MaskedTextBox2.Text = MaskedTextBox3.Text Or MaskedTextBox2.Text = MaskedTextBox4.Text Or MaskedTextBox2.Text = MaskedTextBox5.Text Or MaskedTextBox2.Text = MaskedTextBox6.Text Then
                    MaskedTextBox2.BackColor = Color.LightSlateGray
                    bueno2.Visible = False
                    equis2.Visible = False
                    igual2.Visible = True
                    refrescar2.Visible = True


                End If
                If MaskedTextBox2.Text = MaskedTextBox1.Text Or MaskedTextBox2.Text = MaskedTextBox3.Text Or MaskedTextBox2.Text = MaskedTextBox4.Text Or MaskedTextBox2.Text = MaskedTextBox5.Text Or MaskedTextBox2.Text = MaskedTextBox6.Text Or MaskedTextBox2.Text = txtBasedatos1.Text Or MaskedTextBox2.Text = txtBasedatos2.Text Or MaskedTextBox2.Text = txtBasedatos3.Text Or MaskedTextBox2.Text = txtBasedatos4.Text Or MaskedTextBox2.Text = txtBasedatos5.Text Or MaskedTextBox2.Text = txtBasedatos6.Text Then

                Else
                    MaskedTextBox2.BackColor = Color.LightSlateGray
                    igual2.Visible = False
                    bueno2.Visible = False
                    equis2.Visible = True
                    refrescar2.Visible = True

                End If
            Next



        End If
    End Sub





    Private Sub MaskedTextBox3_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBox3.TextChanged
        Dim entrada1 As String
        Dim contador2 As Integer
        entrada1 = MaskedTextBox3.Text
        contador2 = Len(entrada1)

        If contador2 = 14 Then

            Botella3.Enabled = True



            For Each elemento As String In basedatos
                If MaskedTextBox3.Text = elemento Then
                    Dim ret As Integer = Array.IndexOf(basedatos, elemento)
                    ' devuelve posicion de array encontrado 


                    If ret = 0 Then
                        txtBasedatos1.BackColor = Color.ForestGreen
                        bueno3.Visible = True
                        refrescar3.Visible = False
                        igual3.Visible = False
                        equis3.Visible = False
                    End If

                    If ret = 1 Then
                        txtBasedatos2.BackColor = Color.ForestGreen
                        bueno3.Visible = True
                        refrescar3.Visible = False
                        igual3.Visible = False
                        equis3.Visible = False
                    End If

                    If ret = 2 Then
                        txtBasedatos3.BackColor = Color.ForestGreen
                        bueno3.Visible = True
                        refrescar3.Visible = False
                        igual3.Visible = False
                        equis3.Visible = False
                    End If

                    If ret = 3 Then
                        txtBasedatos4.BackColor = Color.ForestGreen
                        bueno3.Visible = True
                        refrescar3.Visible = False
                        igual3.Visible = False
                        equis3.Visible = False
                    End If

                    If ret = 4 Then
                        txtBasedatos5.BackColor = Color.ForestGreen
                        bueno3.Visible = True
                        refrescar3.Visible = False
                        igual3.Visible = False
                        equis3.Visible = False
                    End If

                    If ret = 5 Then
                        txtBasedatos6.BackColor = Color.ForestGreen
                        bueno3.Visible = True
                        refrescar3.Visible = False
                        igual3.Visible = False
                        equis3.Visible = False
                    End If



                End If

                If MaskedTextBox3.Text = MaskedTextBox1.Text Or MaskedTextBox3.Text = MaskedTextBox2.Text Or MaskedTextBox3.Text = MaskedTextBox4.Text Or MaskedTextBox3.Text = MaskedTextBox5.Text Or MaskedTextBox3.Text = MaskedTextBox6.Text Then
                    MaskedTextBox3.BackColor = Color.LightSlateGray
                    bueno3.Visible = False
                    igual3.Visible = True
                    equis3.Visible = False
                    refrescar3.Visible = True

                End If


                If MaskedTextBox3.Text = MaskedTextBox1.Text Or MaskedTextBox3.Text = MaskedTextBox2.Text Or MaskedTextBox3.Text = MaskedTextBox4.Text Or MaskedTextBox3.Text = MaskedTextBox5.Text Or MaskedTextBox3.Text = MaskedTextBox6.Text Or MaskedTextBox3.Text = txtBasedatos1.Text Or MaskedTextBox3.Text = txtBasedatos2.Text Or MaskedTextBox3.Text = txtBasedatos3.Text Or MaskedTextBox3.Text = txtBasedatos4.Text Or MaskedTextBox3.Text = txtBasedatos5.Text Or MaskedTextBox3.Text = txtBasedatos6.Text Then

                Else
                    MaskedTextBox3.BackColor = Color.LightSlateGray
                    igual3.Visible = False
                    bueno3.Visible = False
                    equis3.Visible = True
                    refrescar3.Visible = True

                End If
            Next


        End If
    End Sub

    Private Sub MaskedTextBox3_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox3.MaskInputRejected

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub

    Private Sub MaskedTextBox2_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox2.MaskInputRejected

    End Sub

    Private Sub Botella3_Tick(sender As Object, e As EventArgs) Handles Botella3.Tick
        Botella3.Interval = 500
        If manual = False Then
            If tiempo = 1 Then
                MaskedTextBox4.Enabled = True
                MaskedTextBox4.Focus()
            End If
        Else
            botonAutomatico.Focus()
        End If
        If bueno1.Visible = True And bueno2.Visible = True And bueno3.Visible = True And bueno4.Visible = True And bueno5.Visible = True And bueno6.Visible = True Then
            'Guarda la etiqueta+codigo+volumen+fecha en BaseDatos
            Dim registrarVerificado As New SqlCommand("Update BaseDatosOficial SET Verificado=1 where caja = (" & caja & ")and [order]=(" & orden & ")", cn)
            cn.Open()
            registrarVerificado.ExecuteNonQuery()
            'Guarda la etiqueta+codigo+volumen+fecha en BaseDatos
            cn.Close()


            Dim actualizarnombre As New SqlCommand("Update BaseDatosOficial SET Usuariocampo=('" & nombre & "'  ) where caja = (" & caja & ")and [order]=(" & orden & ")", cn)
            cn.Open()
            actualizarnombre.ExecuteNonQuery()
            cn.Close()


            MsgBox("Etiquetas Verificadas con exito")
            botoncaja.Focus()
        End If
        tiempo = tiempo + 1

    End Sub

    Private Sub Botella1_Tick(sender As Object, e As EventArgs) Handles Botella1.Tick

        Botella1.Interval = 500

        If manual = False Then
            If tiempo = 1 Then
            MaskedTextBox2.Enabled = True
            MaskedTextBox2.Focus()
        End If

        Else
            botonAutomatico.Focus()
        End If


        If bueno1.Visible = True And bueno2.Visible = True And bueno3.Visible = True And bueno4.Visible = True And bueno5.Visible = True And bueno6.Visible = True Then
            'Guarda la etiqueta+codigo+volumen+fecha en BaseDatos
            Dim registrarVerificado As New SqlCommand("Update BaseDatosOficial SET Verificado=1 where caja = (" & caja & ")and [order]=(" & orden & ")", cn)


            cn.Open()
            registrarVerificado.ExecuteNonQuery()
            'Guarda la etiqueta+codigo+volumen+fecha en BaseDatos
            cn.Close()


            Dim actualizarnombre As New SqlCommand("Update BaseDatosOficial SET Usuariocampo=('" & nombre & "'  ) where caja = (" & caja & ")and [order]=(" & orden & ")", cn)
            cn.Open()
            actualizarnombre.ExecuteNonQuery()
            cn.Close()


            MsgBox("Etiquetas Verificadas con exito")
            botoncaja.Focus()
        End If
        tiempo = tiempo + 1
    End Sub

    Private Sub Botella2_Tick(sender As Object, e As EventArgs) Handles Botella2.Tick

        Botella2.Interval = 500
        If manual = False Then
            If tiempo = 1 Then
                MaskedTextBox3.Enabled = True
                MaskedTextBox3.Focus()
            End If
        Else
            botonAutomatico.Focus()
        End If


        If bueno1.Visible = True And bueno2.Visible = True And bueno3.Visible = True And bueno4.Visible = True And bueno5.Visible = True And bueno6.Visible = True Then
            'Guarda la etiqueta+codigo+volumen+fecha en BaseDatos
            Dim registrarVerificado As New SqlCommand("Update BaseDatosOficial SET Verificado=1 where caja = (" & caja & ")and [order]=(" & orden & ")", cn)


            cn.Open()
            registrarVerificado.ExecuteNonQuery()
            'Guarda la etiqueta+codigo+volumen+fecha en BaseDatos
            cn.Close()


            Dim actualizarnombre As New SqlCommand("Update BaseDatosOficial SET Usuariocampo=('" & nombre & "'  ) where caja = (" & caja & ")and [order]=(" & orden & ")", cn)
            cn.Open()
            actualizarnombre.ExecuteNonQuery()
            cn.Close()

            MsgBox("Etiquetas Verificadas con exito")
            botoncaja.Focus()
        End If

        tiempo = tiempo + 1
    End Sub

    Private Sub MaskedTextBox4_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox4.MaskInputRejected

    End Sub

    Private Sub MaskedTextBox4_GotFocus(sender As Object, e As EventArgs) Handles MaskedTextBox4.GotFocus
        If manual = False Then
            CircularProgressBar5.Visible = True
        End If
        MaskedTextBox4.Clear()
    End Sub

    Private Sub MaskedTextBox4_LostFocus(sender As Object, e As EventArgs) Handles MaskedTextBox4.LostFocus
        CircularProgressBar5.Visible = False
        Botella4.Enabled = False
        tiempo = 0
        MaskedTextBox4.Enabled = False

    End Sub

    Private Sub Botella4_Tick(sender As Object, e As EventArgs) Handles Botella4.Tick
        Botella4.Interval = 500
        If manual = False Then
            If tiempo = 1 Then
                MaskedTextBox5.Enabled = True
                MaskedTextBox5.Focus()
            End If
        Else
            botonAutomatico.Focus()
        End If
        If bueno1.Visible = True And bueno2.Visible = True And bueno3.Visible = True And bueno4.Visible = True And bueno5.Visible = True And bueno6.Visible = True Then
            'Guarda la etiqueta+codigo+volumen+fecha en BaseDatos
            Dim registrarVerificado As New SqlCommand("Update BaseDatosOficial SET Verificado=1 where caja = (" & caja & ")and [order]=(" & orden & ")", cn)


            cn.Open()
            registrarVerificado.ExecuteNonQuery()
            'Guarda la etiqueta+codigo+volumen+fecha en BaseDatos
            cn.Close()


            Dim actualizarnombre As New SqlCommand("Update BaseDatosOficial SET Usuariocampo=('" & nombre & "'  ) where caja = (" & caja & ")and [order]=(" & orden & ")", cn)
            cn.Open()
            actualizarnombre.ExecuteNonQuery()
            cn.Close()

            MsgBox("Etiquetas Verificadas con exito")
            botoncaja.Focus()
        End If
        tiempo = tiempo + 1

    End Sub

    Private Sub MaskedTextBox4_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBox4.TextChanged
        Dim entrada1 As String
        Dim contador2 As Integer
        entrada1 = MaskedTextBox4.Text
        contador2 = Len(entrada1)

        If contador2 = 14 Then

            Botella4.Enabled = True


            For Each elemento As String In basedatos
                If MaskedTextBox4.Text = elemento Then
                    Dim ret As Integer = Array.IndexOf(basedatos, elemento)
                    ' devuelve posicion de array encontrado 


                    If ret = 0 Then
                        txtBasedatos1.BackColor = Color.ForestGreen
                        bueno4.Visible = True
                        refrescar4.Visible = False
                        equis4.Visible = False
                        igual4.Visible = False
                    End If

                    If ret = 1 Then
                        txtBasedatos2.BackColor = Color.ForestGreen
                        bueno4.Visible = True
                        refrescar4.Visible = False
                        equis4.Visible = False
                        igual4.Visible = False
                    End If

                    If ret = 2 Then
                        txtBasedatos3.BackColor = Color.ForestGreen
                        bueno4.Visible = True
                        refrescar4.Visible = False
                        equis4.Visible = False
                        igual4.Visible = False
                    End If

                    If ret = 3 Then
                        txtBasedatos4.BackColor = Color.ForestGreen
                        bueno4.Visible = True
                        refrescar4.Visible = False
                        equis4.Visible = False
                        igual4.Visible = False
                    End If

                    If ret = 4 Then
                        txtBasedatos5.BackColor = Color.ForestGreen
                        bueno4.Visible = True
                        refrescar4.Visible = False
                        equis4.Visible = False
                        igual4.Visible = False
                    End If

                    If ret = 5 Then
                        txtBasedatos6.BackColor = Color.ForestGreen
                        bueno4.Visible = True
                        refrescar4.Visible = False
                        equis4.Visible = False
                        igual4.Visible = False
                    End If

                End If
                If MaskedTextBox4.Text = MaskedTextBox1.Text Or MaskedTextBox4.Text = MaskedTextBox2.Text Or MaskedTextBox4.Text = MaskedTextBox3.Text Or MaskedTextBox4.Text = MaskedTextBox5.Text Or MaskedTextBox4.Text = MaskedTextBox6.Text Then
                    MaskedTextBox4.BackColor = Color.LightSlateGray
                    bueno4.Visible = False
                    igual4.Visible = True
                    equis4.Visible = False
                    refrescar4.Visible = True


                End If

                If MaskedTextBox4.Text = MaskedTextBox1.Text Or MaskedTextBox4.Text = MaskedTextBox2.Text Or MaskedTextBox4.Text = MaskedTextBox3.Text Or MaskedTextBox4.Text = MaskedTextBox5.Text Or MaskedTextBox4.Text = MaskedTextBox6.Text Or MaskedTextBox4.Text = txtBasedatos1.Text Or MaskedTextBox4.Text = txtBasedatos2.Text Or MaskedTextBox4.Text = txtBasedatos3.Text Or MaskedTextBox4.Text = txtBasedatos4.Text Or MaskedTextBox4.Text = txtBasedatos5.Text Or MaskedTextBox4.Text = txtBasedatos6.Text Then
                Else
                    MaskedTextBox4.BackColor = Color.LightSlateGray
                    igual4.Visible = False
                    bueno4.Visible = False
                    equis4.Visible = True
                    refrescar4.Visible = True
                End If
            Next
        End If
    End Sub

    Private Sub MaskedTextBox5_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox5.MaskInputRejected

    End Sub

    Private Sub MaskedTextBox5_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBox5.TextChanged
        Dim entrada1 As String
        Dim contador2 As Integer
        entrada1 = MaskedTextBox5.Text
        contador2 = Len(entrada1)

        If contador2 = 14 Then

            Botella5.Enabled = True


            For Each elemento As String In basedatos
                If MaskedTextBox5.Text = elemento Then
                    Dim ret As Integer = Array.IndexOf(basedatos, elemento)
                    ' devuelve posicion de array encontrado 


                    If ret = 0 Then
                        txtBasedatos1.BackColor = Color.ForestGreen
                        bueno5.Visible = True
                        refrescar5.Visible = False
                        igual5.Visible = False
                        equis5.Visible = False
                    End If

                    If ret = 1 Then
                        txtBasedatos2.BackColor = Color.ForestGreen
                        bueno5.Visible = True
                        refrescar5.Visible = False
                        igual5.Visible = False
                        equis5.Visible = False
                    End If

                    If ret = 2 Then
                        txtBasedatos3.BackColor = Color.ForestGreen
                        bueno5.Visible = True
                        refrescar5.Visible = False
                        igual5.Visible = False
                        equis5.Visible = False
                    End If

                    If ret = 3 Then
                        txtBasedatos4.BackColor = Color.ForestGreen
                        bueno5.Visible = True
                        refrescar5.Visible = False
                        igual5.Visible = False
                        equis5.Visible = False
                    End If

                    If ret = 4 Then
                        txtBasedatos5.BackColor = Color.ForestGreen
                        bueno5.Visible = True
                        refrescar5.Visible = False
                        igual5.Visible = False
                        equis5.Visible = False
                    End If

                    If ret = 5 Then
                        txtBasedatos6.BackColor = Color.ForestGreen
                        bueno5.Visible = True
                        refrescar5.Visible = False
                        igual5.Visible = False
                        equis5.Visible = False
                    End If

                End If
                If MaskedTextBox5.Text = MaskedTextBox1.Text Or MaskedTextBox5.Text = MaskedTextBox2.Text Or MaskedTextBox5.Text = MaskedTextBox3.Text Or MaskedTextBox5.Text = MaskedTextBox4.Text Or MaskedTextBox5.Text = MaskedTextBox6.Text Then
                    MaskedTextBox5.BackColor = Color.LightSlateGray
                    bueno5.Visible = False
                    igual5.Visible = True
                    equis5.Visible = False
                    refrescar5.Visible = True


                End If
                If MaskedTextBox5.Text = MaskedTextBox1.Text Or MaskedTextBox5.Text = MaskedTextBox2.Text Or MaskedTextBox5.Text = MaskedTextBox3.Text Or MaskedTextBox5.Text = MaskedTextBox4.Text Or MaskedTextBox5.Text = MaskedTextBox6.Text Or MaskedTextBox5.Text = txtBasedatos1.Text Or MaskedTextBox5.Text = txtBasedatos2.Text Or MaskedTextBox5.Text = txtBasedatos3.Text Or MaskedTextBox5.Text = txtBasedatos4.Text Or MaskedTextBox5.Text = txtBasedatos5.Text Or MaskedTextBox5.Text = txtBasedatos6.Text Then

                Else
                    MaskedTextBox5.BackColor = Color.LightSlateGray
                    igual5.Visible = False
                    bueno5.Visible = False
                    equis5.Visible = True
                    refrescar5.Visible = True
                End If
            Next
        End If
    End Sub

    Private Sub Botella5_Tick(sender As Object, e As EventArgs) Handles Botella5.Tick
        Botella5.Interval = 500
        If manual = False Then
            If tiempo = 1 Then
                MaskedTextBox6.Enabled = True
                MaskedTextBox6.Focus()
            End If
        Else
            botonAutomatico.Focus()
        End If
        If bueno1.Visible = True And bueno2.Visible = True And bueno3.Visible = True And bueno4.Visible = True And bueno5.Visible = True And bueno6.Visible = True Then
            'Guarda la etiqueta+codigo+volumen+fecha en BaseDatos
            Dim registrarVerificado As New SqlCommand("Update BaseDatosOficial SET Verificado=1 where caja = (" & caja & ")and [order]=(" & orden & ")", cn)


            cn.Open()
            registrarVerificado.ExecuteNonQuery()
            'Guarda la etiqueta+codigo+volumen+fecha en BaseDatos
            cn.Close()


            Dim actualizarnombre As New SqlCommand("Update BaseDatosOficial SET Usuariocampo=('" & nombre & "'  ) where caja = (" & caja & ")and [order]=(" & orden & ")", cn)
            cn.Open()
            actualizarnombre.ExecuteNonQuery()
            cn.Close()

            MsgBox("Etiquetas Verificadas con exito")
            botoncaja.Focus()
        End If
        tiempo = tiempo + 1

    End Sub

    Private Sub MaskedTextBox5_LostFocus(sender As Object, e As EventArgs) Handles MaskedTextBox5.LostFocus
        CircularProgressBar6.Visible = False
        Botella5.Enabled = False
        tiempo = 0
        MaskedTextBox5.Enabled = False

    End Sub

    Private Sub MaskedTextBox5_GotFocus(sender As Object, e As EventArgs) Handles MaskedTextBox5.GotFocus
        If manual = False Then
            CircularProgressBar6.Visible = True
        End If
        MaskedTextBox5.Clear()
    End Sub

    Private Sub MaskedTextBox6_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox6.MaskInputRejected

    End Sub

    Private Sub MaskedTextBox6_GotFocus(sender As Object, e As EventArgs) Handles MaskedTextBox6.GotFocus
        If manual = False Then
            CircularProgressBar7.Visible = True
        End If
        MaskedTextBox6.Clear()
    End Sub

    Private Sub MaskedTextBox6_LostFocus(sender As Object, e As EventArgs) Handles MaskedTextBox6.LostFocus
        CircularProgressBar7.Visible = False
        Botella6.Enabled = False
        tiempo = 0
        MaskedTextBox6.Enabled = False

    End Sub

    Private Sub Botella6_Tick(sender As Object, e As EventArgs) Handles Botella6.Tick
        Botella6.Interval = 500
        If manual = False Then
            If tiempo = 1 Then
                botonAutomatico.Focus()
            End If
        Else
            botonAutomatico.Focus()
        End If
        If bueno1.Visible = True And bueno2.Visible = True And bueno3.Visible = True And bueno4.Visible = True And bueno5.Visible = True And bueno6.Visible = True Then
            'Guarda la etiqueta+codigo+volumen+fecha en BaseDatos
            Dim registrarVerificado As New SqlCommand("Update BaseDatosOficial SET Verificado=1 where caja = (" & caja & ")and [order]=(" & orden & ")", cn)
            cn.Close()

            cn.Open()
            registrarVerificado.ExecuteNonQuery()
            'Guarda la etiqueta+codigo+volumen+fecha en BaseDatos
            cn.Close()


            Dim actualizarnombre As New SqlCommand("Update BaseDatosOficial SET Usuariocampo=('" & nombre & "'  ) where caja = (" & caja & ")and [order]=(" & orden & ")", cn)
            cn.Open()
            actualizarnombre.ExecuteNonQuery()
            cn.Close()

            MsgBox("Etiquetas Verificadas con exito")
            botoncaja.Focus()
        End If
        tiempo = tiempo + 1
    End Sub

    Private Sub MaskedTextBox6_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBox6.TextChanged
        Dim entrada1 As String
        Dim contador2 As Integer
        entrada1 = MaskedTextBox6.Text
        contador2 = Len(entrada1)

        If contador2 = 14 Then

            Botella6.Enabled = True


            For Each elemento As String In basedatos
                If MaskedTextBox6.Text = elemento Then
                    Dim ret As Integer = Array.IndexOf(basedatos, elemento)
                    ' devuelve posicion de array encontrado 


                    If ret = 0 Then
                        txtBasedatos1.BackColor = Color.ForestGreen
                        bueno6.Visible = True
                        refrescar6.Visible = False
                        equis6.Visible = False
                        igual6.Visible = False
                    End If

                    If ret = 1 Then
                        txtBasedatos2.BackColor = Color.ForestGreen
                        bueno6.Visible = True
                        refrescar6.Visible = False
                        equis6.Visible = False
                        igual6.Visible = False
                    End If

                    If ret = 2 Then
                        txtBasedatos3.BackColor = Color.ForestGreen
                        bueno6.Visible = True
                        refrescar6.Visible = False
                        equis6.Visible = False
                        igual6.Visible = False
                    End If

                    If ret = 3 Then
                        txtBasedatos4.BackColor = Color.ForestGreen
                        bueno6.Visible = True
                        refrescar6.Visible = False
                        equis6.Visible = False
                        igual6.Visible = False
                    End If

                    If ret = 4 Then
                        txtBasedatos5.BackColor = Color.ForestGreen
                        bueno6.Visible = True
                        refrescar6.Visible = False
                        equis6.Visible = False
                        igual6.Visible = False
                    End If

                    If ret = 5 Then
                        txtBasedatos6.BackColor = Color.ForestGreen
                        bueno6.Visible = True
                        refrescar6.Visible = False
                        equis6.Visible = False
                        igual6.Visible = False
                    End If



                End If

                If MaskedTextBox6.Text = MaskedTextBox1.Text Or MaskedTextBox6.Text = MaskedTextBox2.Text Or MaskedTextBox6.Text = MaskedTextBox3.Text Or MaskedTextBox6.Text = MaskedTextBox4.Text Or MaskedTextBox5.Text = MaskedTextBox6.Text Then
                    MaskedTextBox6.BackColor = Color.LightSlateGray
                    bueno6.Visible = False
                    igual6.Visible = True
                    equis6.Visible = False
                    refrescar6.Visible = True


                End If

                If MaskedTextBox6.Text = MaskedTextBox1.Text Or MaskedTextBox6.Text = MaskedTextBox2.Text Or MaskedTextBox6.Text = MaskedTextBox3.Text Or MaskedTextBox6.Text = MaskedTextBox4.Text Or MaskedTextBox6.Text = MaskedTextBox5.Text Or MaskedTextBox6.Text = txtBasedatos1.Text Or MaskedTextBox6.Text = txtBasedatos2.Text Or MaskedTextBox6.Text = txtBasedatos3.Text Or MaskedTextBox6.Text = txtBasedatos4.Text Or MaskedTextBox6.Text = txtBasedatos5.Text Or MaskedTextBox6.Text = txtBasedatos6.Text Then
                Else
                    MaskedTextBox6.BackColor = Color.LightSlateGray
                    igual6.Visible = False
                    bueno6.Visible = False
                    equis6.Visible = True
                    refrescar6.Visible = True
                End If
            Next
        End If
    End Sub

    Private Sub MaskedTextBox1_GotFocus(sender As Object, e As EventArgs) Handles MaskedTextBox1.GotFocus
        If manual = False Then
            CircularProgressBar2.Visible = True
        End If
        MaskedTextBox1.Clear()


    End Sub

    Private Sub textboxcaja_GotFocus(sender As Object, e As EventArgs) Handles textboxcaja.GotFocus
        CircularProgressBar1.Visible = True
    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles txtBasedatos2.TextChanged

    End Sub

    Private Sub MaskedTextBox4_MouseClick(sender As Object, e As MouseEventArgs) Handles MaskedTextBox4.MouseClick

    End Sub

    Private Sub MaskedTextBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles MaskedTextBox1.MouseClick

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CircularProgressBar2_Click(sender As Object, e As EventArgs) Handles CircularProgressBar2.Click

    End Sub

    Private Sub MaskedTextBox1_RightToLeftChanged(sender As Object, e As EventArgs) Handles MaskedTextBox1.RightToLeftChanged

    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles refrescar1.Click
        MaskedTextBox1.Text = ""
        bueno1.Visible = False
        igual1.Visible = False
        equis1.Visible = False
        refrescar1.Visible = False

        MaskedTextBox1.ReadOnly = False
        MaskedTextBox1.Enabled = True
        MaskedTextBox1.Focus()
        MaskedTextBox1.BackColor = Color.White
        manual = True




    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles refrescar3.Click
        MaskedTextBox3.Text = ""
        bueno3.Visible = False
        igual3.Visible = False
        equis3.Visible = False
        MaskedTextBox3.ReadOnly = False
        MaskedTextBox3.Enabled = True
        MaskedTextBox3.Focus()
        refrescar3.Visible = False
        MaskedTextBox3.BackColor = Color.White
        manual = True
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles refrescar4.Click


        MaskedTextBox4.Text = ""
        bueno4.Visible = False
        igual4.Visible = False
        equis4.Visible = False
        refrescar4.Visible = False

        MaskedTextBox4.ReadOnly = False
        MaskedTextBox4.Enabled = True
        MaskedTextBox4.Focus()

        MaskedTextBox4.BackColor = Color.White
        manual = True



    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles refrescar5.Click

        MaskedTextBox5.Text = ""
        bueno5.Visible = False
        igual5.Visible = False
        equis5.Visible = False
        refrescar5.Visible = False

        MaskedTextBox5.ReadOnly = False
        MaskedTextBox5.Enabled = True
        MaskedTextBox5.Focus()

        MaskedTextBox5.BackColor = Color.White
        manual = True
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles refrescar6.Click

        MaskedTextBox6.Text = ""
        bueno6.Visible = False
        igual6.Visible = False
        equis6.Visible = False
        refrescar6.Visible = False

        MaskedTextBox6.ReadOnly = False
        MaskedTextBox6.Enabled = True
        MaskedTextBox6.Focus()

        MaskedTextBox6.BackColor = Color.White
        manual = True
    End Sub

    Private Sub Verificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()
        nombre = ActiveUser.firstName + " " + ActiveUser.lastName
    End Sub

    Private Sub OrdenVerificacion_Click(sender As Object, e As EventArgs) Handles botonVerificacionOrden.Click
        MaskedTextBox7.Enabled = True
        MaskedTextBox7.Clear()
        MaskedTextBox7.Focus()
        DataGridView1.Visible = False
        Label10.Visible = False
    End Sub



    Private Sub MaskedTextBox7_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox7.MaskInputRejected

    End Sub

    Private Sub MaskedTextBox7_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBox7.TextChanged
        Try
            Dim entrada As String
            Dim contador As Integer
            entrada = MaskedTextBox7.Text
            contador = Len(entrada)


            If contador = 8 Then

                DataGridView1.Visible = True
                Label10.Visible = True

                conectar()



                Dim tabla As DataGridView = DataGridView1
                Dim adaptador As New SqlDataAdapter("select * from BaseDatosOficial where [Order]=" & MaskedTextBox7.Text & " and [Verificado]=" & 0 & "", cn) 'Funciona con lote y material

                Dim dataS As New DataSet
                adaptador.Fill(dataS, "BaseDatosOficial")

                tabla.DataSource = dataS.Tables("BaseDatosOficial")
                tabla.RowHeadersVisible = False
                tabla.Columns.Item(0).Visible = False
                tabla.Columns.Item(2).Visible = False
                tabla.Columns.Item(3).Visible = False
                tabla.Columns.Item(4).Visible = False
                tabla.Columns.Item(5).Visible = False
                tabla.Columns.Item(6).Visible = False
                tabla.Columns.Item(7).Visible = False
                tabla.Columns.Item(8).Visible = False
                tabla.Columns.Item(9).Visible = False
                tabla.Columns(1).Width = 130
                tabla.Columns(10).Width = 130


                'Habilita conteo de filas en datagridview
                Label10.Visible = True
                ' Label8.Text = tabla.DisplayedRowCount(0) - 1
                Label10.Text = tabla.RowCount - 1

                botonVerificacionOrden.Focus()
                MaskedTextBox7.Enabled = False
                desconectar()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MaskedTextBox7_LostFocus(sender As Object, e As EventArgs) Handles MaskedTextBox7.LostFocus
        MaskedTextBox7.Enabled = False
    End Sub


End Class
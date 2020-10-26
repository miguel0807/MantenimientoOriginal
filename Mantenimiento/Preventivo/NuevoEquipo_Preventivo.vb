Imports System.Data.SqlClient
Public Class NuevoEquipo_Preventivo
    Dim codigo As String = ""
    Dim conteoequipos As String = ""
    Dim conteonumero As Integer = 0
    Dim count As Integer = 0
    Dim manualconteo As Boolean = False
    Dim codigointer As Integer
    Dim codigo_cantidad As Integer = 0
    Private Sub Equipo_Preventivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

#Region "Cargar datos en combobox de Ubicacion"
        Try
            Dim cmd As String = "select*from Ubicacion_Datos"
            Dim da As New SqlDataAdapter(cmd, cn)
            Dim ds As New DataSet
            da.Fill(ds)
            With Me.Ubicacion
                Me.Ubicacion.DataSource = ds.Tables(0)
                Me.Ubicacion.DisplayMember = "Ubicacion"
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
#Region "Convertir nombre en codigo para ingresarlo en tabla"

                'En el parentesis entre & & se coloca cual valor se usara para la busqueda
                Dim adaptador1 As New SqlDataAdapter("select*from Caracteristicas_Equipo where convert(char,Clase) ='" & Clase.Text & "'", cn)
                Dim ds1 As New DataSet
                adaptador1.Fill(ds1, "datos")

                'El item selecciona de cual columna de la base de datos se conectara y row es la fila
                If ds1.Tables("datos").Rows.Count > 0 Then
                    '  MaskedTextBox1.Mask = ""

                    codigointer = ds1.Tables("datos").Rows(0).Item(0).ToString

                End If


                'En el parentesis entre & & se coloca cual valor se usara para la busqueda
                Dim adaptador As New SqlDataAdapter("select*from Caracteristicas_Equipo where convert(char,Clase) ='" & Clase.Text & "'", cn)
                Dim ds As New DataSet
                adaptador.Fill(ds, "datos")

                'El item selecciona de cual columna de la base de datos se conectara y row es la fila
                If ds.Tables("datos").Rows.Count > 0 Then
                    '  MaskedTextBox1.Mask = ""

                    Clave.Text = ds.Tables("datos").Rows(0).Item(3).ToString

                End If

#End Region


#Region "Insertar numero de equipos en etiqueta.text"


                conectar()

                Dim Query As String
                Query = ("select COUNT (Codigo) from Lista_Equipos where Codigo=" & codigointer & " ")
                Dim cmd As New SqlCommand(Query, cn)

                Etiqueta.Text = cmd.ExecuteScalar + 1


                desconectar()



#End Region

        End Select
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Placa.Text = ""
            Placa.Enabled = True
            Placa.Focus()

        Else
            Placa.Enabled = False
            Placa.Text = "N/A"
        End If
    End Sub

    Private Sub Crear_Click(sender As Object, e As EventArgs) Handles Crear.Click
#Region "Verifica que todos los campos esten completos para proceder con la carga de informacion"
        If Clase.Text = "" Or Clave.Text = "" Or Etiqueta.Text = "" Or Placa.Text = "" Or Ubicacion.Text = "" Then
            MsgBox("Complete todos los campos para crear una nuevo equipo")
            Exit Sub

        End If

#End Region


        Select Case Clase.Text

            Case Clase.Text

#Region "Busco el codigo de la clase en la tabla caracteristicas equipo"


                'En el parentesis entre & & se coloca cual valor se usara para la busqueda
                Dim adaptador As New SqlDataAdapter("select*from Caracteristicas_Equipo where convert(char,Clase) ='" & Clase.Text & "'", cn)
                Dim ds As New DataSet
                adaptador.Fill(ds, "datos")

                'El item selecciona de cual columna de la base de datos se conectara y row es la fila
                If ds.Tables("datos").Rows.Count > 0 Then
                    '  MaskedTextBox1.Mask = ""

                    codigo = ds.Tables("datos").Rows(0).Item(0).ToString
                    codigo_cantidad = ds.Tables("datos").Rows(0).Item(0).ToString
                End If

#End Region
#Region "Contar numero de equipo por clase"
                If manualconteo = False Then



                    conectar()

                    Dim Query As String
                    Query = ("select COUNT (Codigo) from Lista_Equipos where codigo=" & codigo_cantidad & "")
                    Dim cmd As New SqlCommand(Query, cn)
                    count = cmd.ExecuteScalar
                    Etiqueta.Text = count + 1

                    desconectar()

                Else



                End If


#End Region
#Region "Insertar en la lista de equipos la informacion del nuevo equipo"
                Dim adaptador1 As New SqlCommand("insert into Lista_Equipos values (" & codigo & ",'" & Clave.Text + Etiqueta.Text & "','" & Placa.Text & "','" & Ubicacion.Text & "')", cn)
                conectar()
                adaptador1.ExecuteNonQuery()
                desconectar()


#End Region
#Region "Buscar la cantidad de equipos para la clase seleccionada"




                'En el parentesis entre & & se coloca cual valor se usara para la busqueda
                Dim adaptador5 As New SqlDataAdapter("select*from Caracteristicas_Equipo where codigo ='" & codigo & "'", cn)
                    Dim ds5 As New DataSet
                adaptador5.Fill(ds5, "datos")

                'El item selecciona de cual columna de la base de datos se conectara y row es la fila
                If ds5.Tables("datos").Rows.Count > 0 Then
                        '  MaskedTextBox1.Mask = ""

                        conteoequipos = ds.Tables("datos").Rows(0).Item(2).ToString
                        conteonumero = conteoequipos
                        conteonumero = conteonumero + 1

                    End If
#End Region
#Region "Actualiza el dato de cantidad en la tabla caracteristicas_equipo"
                    conectar()
                    Dim actualizarcantidad As New SqlCommand("Update Caracteristicas_Equipo SET Cantidad =" & conteonumero & "where [Codigo] = (" & codigo & ")", cn)
                    'TextBox1.Text = actualizarnombre.CommandText
                    actualizarcantidad.ExecuteNonQuery()
                    cn.Close()


#End Region
#Region "Actualizar conteo"
                Try





                    conectar()
                    Dim actualizarcantidadconteo As New SqlCommand("update Conteo_Equipos set Enero=Enero+1,Febrero=Febrero+1,Marzo=Marzo+1,Abril=Abril+1,Mayo=Mayo+1,Junio=Junio+1,Julio=Julio+1,Agosto=Agosto+1,Septiembre=Septiembre+1,Octubre=Octubre+1,Noviembre=Noviembre+1,Diciembre=Diciembre+1 where codigo=" & codigo & " and Año=" & Date.Now.Year & "", cn)
                    'TextBox1.Text = actualizarnombre.CommandText
                    actualizarcantidadconteo.ExecuteNonQuery()
                    cn.Close()
                    MsgBox("Se registro correctamente")

                    Me.Close()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

#End Region

            Case "Clasificacion"


        End Select


    End Sub



    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = False Then
            Etiqueta.Enabled = False
            manualconteo = False

        ElseIf CheckBox2.Checked = True Then

            manualconteo = True
            Etiqueta.Enabled = True

        End If
    End Sub
End Class
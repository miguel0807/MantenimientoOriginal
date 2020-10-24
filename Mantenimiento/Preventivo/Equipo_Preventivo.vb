Imports System.Data.SqlClient
Public Class Equipo_Preventivo
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




                'En el parentesis entre & & se coloca cual valor se usara para la busqueda
                Dim adaptador As New SqlDataAdapter("select*from Caracteristicas_Equipo where convert(char,Clase) ='" & Clase.Text & "'", cn)
                Dim ds As New DataSet
                adaptador.Fill(ds, "datos")

                'El item selecciona de cual columna de la base de datos se conectara y row es la fila
                If ds.Tables("datos").Rows.Count > 0 Then
                    '  MaskedTextBox1.Mask = ""

                    clave.text = ds.Tables("datos").Rows(0).Item(2).ToString

                End If



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

        If Clase.Text = "" Or Clave.Text = "" Or Etiqueta.Text = "" Or Placa.Text = "" Or Ubicacion.Text = "" Then
            MsgBox("Complete todos los campos para crear una nuevo equipo")
            Exit Sub

        End If

        Dim codigo As String = ""


        Select Case Clase.Text




            Case Clase.Text




                'En el parentesis entre & & se coloca cual valor se usara para la busqueda
                Dim adaptador As New SqlDataAdapter("select*from Caracteristicas_Equipo where convert(char,Clase) ='" & Clase.Text & "'", cn)
                Dim ds As New DataSet
                adaptador.Fill(ds, "datos")

                'El item selecciona de cual columna de la base de datos se conectara y row es la fila
                If ds.Tables("datos").Rows.Count > 0 Then
                    '  MaskedTextBox1.Mask = ""

                    codigo = ds.Tables("datos").Rows(0).Item(0).ToString

                End If

            Case "Clasificacion"


        End Select

        Dim adaptador1 As New SqlCommand("insert into Lista_Equipos values (" & codigo & ",'" & Clave.Text + Etiqueta.Text & "','" & Placa.Text & "','" & Ubicacion.Text & "')", cn)
        conectar()
        adaptador1.ExecuteNonQuery()
        MsgBox("Se registro correctamente")
        Me.Close()
        desconectar()
    End Sub
End Class
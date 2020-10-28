Imports System.Data.SqlClient
Public Class NuevaClase_Preventivo
    Dim count As Integer
    Private Sub Crear_Click(sender As Object, e As EventArgs) Handles Crear.Click



        If Clase.Text = "" Or Clave.Text = "" Or Frecuencia.Text = "" Or Clasificacion.Text = "" Or Provedor.Text = "" Then
            MsgBox("Complete todos los campos para crear una nueva clase")
            Exit Sub

        End If



        Dim adaptador As New SqlCommand("insert into Caracteristicas_Equipo values (" & count & ",'" & Clase.Text & "', 0 ,'" & Clave.Text & "','" & Frecuencia.Text & "','" & Clasificacion.Text & "','" & Provedor.Text & "')", cn)
        conectar()
        'TextBox1.Text = adaptador.CommandText
        adaptador.ExecuteNonQuery()



        desconectar()


#Region "Insertar 9999 en la tabla conteo"

        Dim adaptador1 As New SqlCommand("insert into ConteoPlanificacion_Equipos(Codigo,Año,Enero,Febrero,Marzo,Abril,Mayo,Junio,Julio,Agosto,Septiembre,Octubre,Noviembre,Diciembre) values (" & count & "," & Date.Now.Year & ",9999,9999,9999,9999,9999,9999,9999,9999,9999,9999,9999,9999)", cn)
        conectar()
        ' TextBox1.Text = adaptador1.CommandText
        adaptador1.ExecuteNonQuery()
        MsgBox("Se registro correctamente")
        Me.Close()

        desconectar()
#End Region


    End Sub

    Private Sub Clase_Preventivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not formularios.Contains(Me) Then formularios.Add(Me) 'Agrega a la lista los formularios para luego cerrarlos
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
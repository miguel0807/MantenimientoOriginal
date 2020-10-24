Imports System.Data.SqlClient
Public Class Provedor_Preventivo


    Private Sub Crear_Click(sender As Object, e As EventArgs) Handles Crear.Click

        If Provedor.Text = "" Then
            MsgBox("Primero escriba un nuevo provedor")
            Exit Sub

        End If



        Dim adaptador As New SqlCommand("insert into Provedor_Datos values ('" & Provedor.Text & "')", cn)
        conectar()
        'TextBox1.Text = adaptador.CommandText
        adaptador.ExecuteNonQuery()
        MsgBox("Se registro correctamente")
        Me.Close()

        desconectar()
    End Sub

    Private Sub Provedor_Preventivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not formularios.Contains(Me) Then formularios.Add(Me) 'Agrega a la lista los formularios para luego cerrarlos
    End Sub
End Class
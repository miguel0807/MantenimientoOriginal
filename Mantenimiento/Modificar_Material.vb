Imports System.Data.SqlClient
Public Class Modificar_Material
    Public conteo As Integer
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If Material.Enabled = False Then
            Material.Enabled = True
        Else
            Material.Enabled = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If Cantidad.Enabled = False Then
            Cantidad.Enabled = True
        Else
            Cantidad.Enabled = False
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If Unidad.Enabled = False Then
            Unidad.Enabled = True
        Else
            Unidad.Enabled = False
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If Empresa.Enabled = False Then
            Empresa.Enabled = True
        Else
            Empresa.Enabled = False
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If Parte.Enabled = False Then
            Parte.Enabled = True
        Else
            Parte.Enabled = False
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If Equipo.Enabled = False Then
            Equipo.Enabled = True
        Else
            Equipo.Enabled = False
        End If
    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        If Marca.Enabled = False Then
            Marca.Enabled = True
        Else
            Marca.Enabled = False
        End If
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        If Modelo.Enabled = False Then
            Modelo.Enabled = True
        Else
            Modelo.Enabled = False
        End If
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        If Serie.Enabled = False Then
            Serie.Enabled = True
        Else
            Serie.Enabled = False
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        If Ubicacion.Enabled = False Then
            Ubicacion.Enabled = True
        Else
            Ubicacion.Enabled = False
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        If Clasificacion.Enabled = False Then
            Clasificacion.Enabled = True
        Else
            Clasificacion.Enabled = False
        End If
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        If Descripcion.Enabled = False Then
            Descripcion.Enabled = True
        Else
            Descripcion.Enabled = False
        End If
    End Sub

    Private Sub Ingresar_Click(sender As Object, e As EventArgs) Handles Ingresar.Click

        Try

            conectar()
        Dim actualizarnombre As New SqlCommand("Update Bodega SET Material =('" & Material.Text & "'), Cantidad =(" & Cantidad.Text & "), Unidad =('" & Unidad.Text & "') , Empresa =('" & Empresa.Text & "'), [#Parte] =('" & Parte.Text & "'), [Equipo] =('" & Equipo.Text & "'), [Marca] =('" & Marca.Text & "'), [Modelo]= ('" & Modelo.Text & "'), [Serie]= ('" & Serie.Text & "'), [Ubicacion]= ('" & Ubicacion.Text & "'),[Clasificacion]= ('" & Clasificacion.Text & "'),[Descripcion]= ('" & Descripcion.Text & "')  where [Conteo] = (" & conteo & ")", cn)
        'TextBox1.Text = actualizarnombre.CommandText
        actualizarnombre.ExecuteNonQuery()
        cn.Close()
        MsgBox("Se registro correctamente")

        Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Modificar_Material_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
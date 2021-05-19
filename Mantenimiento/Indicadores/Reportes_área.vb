Imports System.Data.SqlClient
Public Class Reportes_área






    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AdatosCargarDatos1()
        AdatosCargarGrafico1()
        AdatosEsteticaDtg()




    End Sub

    Private Sub Análisis_Datos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not formularios.Contains(Me) Then formularios.Add(Me) 'Agrega a la lista los formularios para luego cerrarlos


        Año.SelectedIndex = 0
        Mes.SelectedIndex = 0
        ' Ubicación.SelectedIndex = 0

        adatosAño = Año
        adatosMes = Mes
        adatosUbicación = Ubicación

        MIubicacion = Ubicación

        adatosDtg = DataGridView1
        adatosCheckAño = checkAño
        adatosCheckMes = checkMes
        adatosCheckUbicación = checkUbicación

        adatosChart1 = Chart1

        AdatosCargarDatos1()
        AdatosCargarGrafico1()
        AdatosEsteticaDtg()

        MIcargarUbicacion()

    End Sub

    Private Sub checkAño_CheckedChanged(sender As Object, e As EventArgs) Handles checkAño.CheckedChanged
        If checkAño.Checked = True Then
            Año.Enabled = True
        Else

            Año.Enabled = False
        End If
    End Sub

    Private Sub checkMes_CheckedChanged(sender As Object, e As EventArgs) Handles checkMes.CheckedChanged
        If checkMes.Checked = True Then
            Mes.Enabled = True
        Else
            Mes.Enabled = False
        End If
    End Sub

    Private Sub checkUbicación_CheckedChanged(sender As Object, e As EventArgs) Handles checkUbicación.CheckedChanged
        If checkUbicación.Checked = True Then
            Ubicación.Enabled = True
        Else
            Ubicación.Enabled = False
        End If
    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
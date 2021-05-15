Imports System.Data.SqlClient
Public Class Reportes_área


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        'Dim miView As DataView = New DataView(dataS.Tables("Indicadores1")) 'Enviamos a un dataview los datos
        'Chart1.Series("Reporte por área").Points.Clear()


        'For x = 0 To miView.Count - 1
        '    'Tomanos los datos de DataView para la gráfica
        '    ' Me.Chart1.Series("Ubicaciónes").Points.AddXY(miView(x)("Ubicación"), miView(x)("Conteo"))

        '    Me.Chart1.Series("Reporte por área").Points.AddXY(miView(x)("Ubicación"), miView(x)("Contar"))
        'Next


    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AdatosCargarDatos1()
        AdatosCargarGrafico1()




    End Sub

    Private Sub Análisis_Datos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not formularios.Contains(Me) Then formularios.Add(Me) 'Agrega a la lista los formularios para luego cerrarlos


        Año.SelectedIndex = 0
        Mes.SelectedIndex = 0
        Ubicación.SelectedIndex = 0

        adatosAño = Año
        adatosMes = Mes
        adatosUbicación = Ubicación

        adatosDtg = DataGridView1
        adatosCheckAño = checkAño
        adatosCheckMes = checkMes
        adatosCheckUbicación = checkUbicación

        adatosChart1 = Chart1

    End Sub

    Private Sub checkAño_CheckedChanged(sender As Object, e As EventArgs) Handles checkAño.CheckedChanged
        If checkAño.Checked = True Then
            Año.Visible = True
        Else
            Año.Visible = False
        End If
    End Sub

    Private Sub checkMes_CheckedChanged(sender As Object, e As EventArgs) Handles checkMes.CheckedChanged
        If checkMes.Checked = True Then
            Mes.Visible = True
        Else
            Mes.Visible = False
        End If
    End Sub

    Private Sub checkUbicación_CheckedChanged(sender As Object, e As EventArgs) Handles checkUbicación.CheckedChanged
        If checkUbicación.Checked = True Then
            Ubicación.Visible = True
        Else
            Ubicación.Visible = False
        End If
    End Sub
End Class
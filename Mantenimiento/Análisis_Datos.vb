Imports System.Data.SqlClient
Public Class Análisis_Datos
    Dim dataS As New DataSet

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim miView As DataView = New DataView(dataS.Tables("Indicadores1")) 'Enviamos a un dataview los datos
        Chart1.Series("Reporte por área").Points.Clear()


        For x = 0 To miView.Count - 1
            'Tomanos los datos de DataView para la gráfica
            ' Me.Chart1.Series("Ubicaciónes").Points.AddXY(miView(x)("Ubicación"), miView(x)("Conteo"))

            Me.Chart1.Series("Reporte por área").Points.AddXY(miView(x)("Ubicación"), miView(x)("Contar"))
        Next


    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim mes12 As Integer
        Select Case adatosMes.Text
            Case "Enero"
                mes12 = 1
            Case "Febrero"
                mes12 = 2
            Case "Marzo"
                mes12 = 3
            Case "Abril"
                mes12 = 4
            Case "Mayo"
                mes12 = 5
            Case "Junio"
                mes12 = 6
            Case "Julio"
                mes12 = 7
            Case "Agosto"
                mes12 = 8
            Case "Septiembre"
                mes12 = 9
            Case "Octubre"
                mes12 = 10
            Case "Noviembre"
                mes12 = 11
            Case "Diciembre"
                mes12 = 12

        End Select

        dataS.Clear()
        Dim tabla As DataGridView = DataGridView1
        If checkAño.Checked = False And checkMes.Checked = False And checkUbicación.Checked = False Then
            Dim adaptador As New SqlDataAdapter("select CAST(Ubicación AS varchar(max)) as 'Ubicación',COUNT(*) as Contar from  Indicadores1 group by CAST(Ubicación AS varchar(max))", cn)
            adaptador.Fill(dataS, "Indicadores1")



        ElseIf checkAño.Checked = True And checkMes.Checked = True And checkUbicación.Checked = True Then
            Dim adaptador As New SqlDataAdapter("select CAST(Ubicación AS varchar(max)) as 'Ubicación',COUNT(*) as Contar from  Indicadores1 where YEAR([Fecha Inicial])=" & adatosAño.Text & " and Month([Fecha Inicial])=" & mes12 & " and  convert(char,Ubicación)='" & adatosUbicación.Text & "'  group by CAST(Ubicación AS varchar(max))", cn)
            adaptador.Fill(dataS, "Indicadores1")



        ElseIf checkAño.Checked = True And checkMes.Checked = False And checkUbicación.Checked = False Then
            Dim adaptador As New SqlDataAdapter("select CAST(Ubicación AS varchar(max)) as 'Ubicación',COUNT(*) as Contar from  Indicadores1 where YEAR([Fecha Inicial])=" & adatosAño.Text & "  group by CAST(Ubicación AS varchar(max))", cn)
            adaptador.Fill(dataS, "Indicadores1")

        ElseIf checkAño.Checked = False And checkMes.Checked = True And checkUbicación.Checked = False Then
            Dim adaptador As New SqlDataAdapter("select CAST(Ubicación AS varchar(max)) as 'Ubicación',COUNT(*) as Contar from  Indicadores1 where Month([Fecha Inicial])=" & mes12 & " group by CAST(Ubicación AS varchar(max))", cn)
            adaptador.Fill(dataS, "Indicadores1")

        ElseIf checkAño.Checked = False And checkMes.Checked = False And checkUbicación.Checked = True Then
            Dim adaptador As New SqlDataAdapter("select CAST(Ubicación AS varchar(max)) as 'Ubicación',COUNT(*) as contar from  Indicadores1 where convert(char,Ubicación)='" & adatosUbicación.Text & "' group by CAST(Ubicación AS varchar(max))", cn)
            adaptador.Fill(dataS, "Indicadores1")

        ElseIf checkAño.Checked = True And checkMes.Checked = True And checkUbicación.Checked = False Then
            Dim adaptador As New SqlDataAdapter("select CAST(Ubicación AS varchar(max)) as 'Ubicación',COUNT(*) as Contar from  Indicadores1 where YEAR([Fecha Inicial])=" & adatosAño.Text & " and MONTH([Fecha Inicial])=" & mes12 & " group by CAST(Ubicación AS varchar(max))", cn)
            adaptador.Fill(dataS, "Indicadores1")

        ElseIf checkAño.Checked = False And checkMes.Checked = True And checkUbicación.Checked = True Then
            Dim adaptador As New SqlDataAdapter("select CAST(Ubicación AS varchar(max)) as 'Ubicación',COUNT(*) as Contar from  Indicadores1 where Month([Fecha Inicial])=" & mes12 & " and convert(char,Ubicación)='" & adatosUbicación.Text & "' group by CAST(Ubicación AS varchar(max))", cn)
            adaptador.Fill(dataS, "Indicadores1")

        ElseIf checkAño.Checked = True And checkMes.Checked = False And checkUbicación.Checked = True Then
            Dim adaptador As New SqlDataAdapter("select CAST(Ubicación AS varchar(max)) as 'Ubicación',COUNT(*) as Contar from  Indicadores1 where YEAR([Fecha Inicial])=" & adatosAño.Text & " and convert(char,Ubicación)='" & adatosUbicación.Text & "' group by CAST(Ubicación AS varchar(max))", cn)
            adaptador.Fill(dataS, "Indicadores1")
        End If

        tabla.DataSource = dataS.Tables("Indicadores1")
        desconectar()

        Dim miView As DataView = New DataView(dataS.Tables("Indicadores1")) 'Enviamos a un dataview los datos




        Chart1.Series("Reporte por área").Points.Clear()



        For x = 0 To miView.Count - 1
            Me.Chart1.Series("Reporte por área").Points.AddXY(miView(x)("Ubicación"), miView(x)("Contar"))
        Next




    End Sub

    Private Sub Análisis_Datos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        adatosAño.SelectedIndex = 0
        adatosMes.SelectedIndex = 0
        adatosUbicación.SelectedIndex = 0
    End Sub

    Private Sub checkAño_CheckedChanged(sender As Object, e As EventArgs) Handles checkAño.CheckedChanged
        If checkAño.Checked = True Then
            adatosAño.Visible = True
        Else
            adatosAño.Visible = False
        End If
    End Sub

    Private Sub checkMes_CheckedChanged(sender As Object, e As EventArgs) Handles checkMes.CheckedChanged
        If checkMes.Checked = True Then
            adatosMes.Visible = True
        Else
            adatosMes.Visible = False
        End If
    End Sub

    Private Sub checkUbicación_CheckedChanged(sender As Object, e As EventArgs) Handles checkUbicación.CheckedChanged
        If checkUbicación.Checked = True Then
            adatosUbicación.Visible = True
        Else
            adatosUbicación.Visible = False
        End If
    End Sub
End Class
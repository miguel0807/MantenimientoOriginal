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
        Select Case ComboBox2.Text
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
        '  Dim adaptador As New SqlDataAdapter("select CAST(Ubicación AS varchar(max)) as 'Ubicación', COUNT(*) as 'Conteo' from Indicadores1 group by CAST(Ubicación AS varchar(max))", cn)
        Dim adaptador As New SqlDataAdapter("select CAST(Ubicación AS varchar(max)) as 'Ubicación',COUNT(*) as Contar from  Indicadores1 where YEAR([Fecha Inicial])=2021 group by CAST(Ubicación AS varchar(max))", cn)
        adaptador.Fill(dataS, "Indicadores1")
        tabla.DataSource = dataS.Tables("Indicadores1")
        desconectar()

        Dim miView As DataView = New DataView(dataS.Tables("Indicadores1")) 'Enviamos a un dataview los datos




        Chart1.Series("Reporte por área").Points.Clear()



        For x = 0 To miView.Count - 1
            Me.Chart1.Series("Reporte por área").Points.AddXY(miView(x)("Ubicación"), miView(x)("Contar"))
        Next




    End Sub

    Private Sub Análisis_Datos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
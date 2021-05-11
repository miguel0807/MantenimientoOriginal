Imports System.Data.SqlClient
Public Class Análisis_Datos
    Dim dataS As New DataSet

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim miView As DataView = New DataView(dataS.Tables("Indicadores1")) 'Enviamos a un dataview los datos
        Chart1.Series("Ubicaciónes").Points.Clear()
        Chart1.Series("Ubicaciónes").Points.Clear()

        For x = 0 To miView.Count - 1
            'Tomanos los datos de DataView para la gráfica
            Me.Chart1.Series("Ubicaciónes").Points.AddXY(miView(x)("Ubicación"), miView(x)("Conteo"))
        Next


    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        dataS.Clear()
        Dim tabla As DataGridView = DataGridView1
        Dim adaptador As New SqlDataAdapter("select CAST(Ubicación AS varchar(max)) as 'Ubicación', COUNT(*) as 'Conteo' from Indicadores1 group by CAST(Ubicación AS varchar(max))", cn)
        adaptador.Fill(dataS, "Indicadores1")
        tabla.DataSource = dataS.Tables("Indicadores1")
        desconectar()

        Dim miView As DataView = New DataView(dataS.Tables("Indicadores1")) 'Enviamos a un dataview los datos




        Chart1.Series("Ubicaciónes").Points.Clear()
        Chart1.Series("Ubicaciónes").Points.Clear()


        For x = 0 To miView.Count - 1
                'Tomanos los datos de DataView para la gráfica
                ' Me.Chart1.Series("Ubicaciónes").Points.AddXY(miView(x)("Ubicación"), miView(x)("Conteo"))
                Me.Chart1.Series("Ubicaciónes").Points.AddXY(miView(x)("Ubicación"), miView(x)("Conteo"))
            Next




    End Sub
End Class
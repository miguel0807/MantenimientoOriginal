Imports System.Data.SqlClient
Public Class Análisis_Datos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Chart1.Series("Ubicaciónes").Points.AddXY("Bodega", 6)
        Chart1.Series("Ubicaciónes").Points.AddXY("Cartuchos DD", 9)
        Chart1.Series("Ubicaciónes").Points.AddXY("Cartuchos Wilsonville", 22)
        Chart1.Series("Ubicaciónes").Points.AddXY("Contacto", 4)
        Chart1.Series("Ubicaciónes").Points.AddXY("CR7", 1)
        Chart1.Series("Ubicaciónes").Points.AddXY("CR8", 5)
        Chart1.Series("Ubicaciónes").Points.AddXY("Cuarto de compresor", 4)
        Chart1.Series("Ubicaciónes").Points.AddXY("N/A", 10)

        Chart1.Series("Ubicaciónes").Points.AddXY("Oficinas", 2)
        Chart1.Series("Ubicaciónes").Points.AddXY("Producción Empaque", 5)
        Chart1.Series("Ubicaciónes").Points.AddXY("Producción Etiquetas", 6)
        Chart1.Series("Ubicaciónes").Points.AddXY("Producción Master batch", 15)
        Chart1.Series("Ubicaciónes").Points.AddXY("Taller Mantenimiento", 39)
        Chart1.Series("Ubicaciónes").Points.AddXY("Tank Farm", 9)


        ' Dim tabla As DataGridView = DataGridView1

    End Sub
End Class
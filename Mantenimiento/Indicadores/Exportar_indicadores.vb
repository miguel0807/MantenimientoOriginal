




Public Class Exportar_indicadores




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datagridIndicadores = dataGridView1
    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        exportarArchivo()


    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cargarIndicadores()
        btnExportExcel.Visible = True

    End Sub



End Class

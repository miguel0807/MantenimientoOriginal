Public Class Reporte_Casos_Cerrados
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RepoPreventivosCerradosCargarDatos()
        ReportePreventivosCerradosEstetica()

        ReportePreventivosCerradosGrafica()



    End Sub

    Private Sub Reporte_Casos_Cerrados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        repoCaCedtg = DataGridView1
        repoCaCeAño = Año
        repoCaCeMes = Mes
        repoCaCeChar1 = Chart1
        Año.Text = Year(Now)
        Mes.SelectedIndex = 11
        RepoPreventivosCerradosCargarDatos()
        ReportePreventivosCerradosEstetica()

        ReportePreventivosCerradosGrafica()

    End Sub
End Class
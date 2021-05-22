Public Class Reporte_Casos_Cerrados
    Private Sub Button1_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub Reporte_Casos_Cerrados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        repoCaCedtg = DataGridView1
        repoCaCeAño = Año
        ' repoCaCeMes = Mes
        repoCaCeChar1 = Chart1
        Año.Text = Year(Now)
        '  Mes.SelectedIndex = 11
        RepoPreventivosCerradosCargarDatos()
        ReportePreventivosCerradosEstetica()

        ReportePreventivosCerradosGrafica()

    End Sub

    Private Sub Año_DrawItem(sender As Object, e As DrawItemEventArgs) Handles Año.DrawItem
        If e.Index >= 0 Then
            Using st As New StringFormat With {.Alignment = StringAlignment.Center}
                e.Graphics.DrawString(sender.Items(e.Index).ToString, e.Font, Brushes.Black, e.Bounds, st)
            End Using
        End If
    End Sub

    Private Sub Año_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Año.SelectedIndexChanged
        RepoPreventivosCerradosCargarDatos()
        ReportePreventivosCerradosEstetica()

        ReportePreventivosCerradosGrafica()
    End Sub
End Class
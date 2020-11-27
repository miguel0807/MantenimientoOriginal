Imports System.Data.SqlClient
Public Class HistShutdownStartup

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        historial = "Hist_Startup"
        CargarFecha()
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CargarDatosFecha()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        presionar = Me.DataGridView1.CurrentCell.Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox(DataGridView1.CurrentCell.Value)
    End Sub



    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        presionar = MonthCalendar1.SelectionRange.Start.ToString
    End Sub

    Private Sub HistShutdownStartup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datagr = DataGridView1
        datagr2 = DataGridView2
    End Sub
End Class
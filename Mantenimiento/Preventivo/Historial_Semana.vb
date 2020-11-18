Public Class Historial_Semana
    Private Sub Historial_Semana_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not formularios.Contains(Me) Then formularios.Add(Me) 'Agrega a la lista los formularios para luego cerrarlos
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim d As DateTime = Now

        '  TextBox1.Text = MonthCalendar1.SelectionStart.DayOfWeek

        TextBox1.Text = DatePart(DateInterval.WeekOfYear, Now, FirstDayOfWeek.Monday, FirstWeekOfYear.FirstFullWeek)

    End Sub
End Class
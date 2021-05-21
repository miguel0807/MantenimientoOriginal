Imports System.Data.SqlClient

Public Class Resolución_Casos
    Private Sub Resolución_Casos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		If Not formularios.Contains(Me) Then formularios.Add(Me) 'Agrega a la lista los formularios para luego cerrarlos

		ResolucionChar1 = Chart1
		ResolucionDtg = DataGridView1
		ResolucionCboFecha = CboFecha
		ResolucionCboFecha.Text = Year(Now)

		ResolucionCargarDatos()
		ResolucionEsteticaDtg()
		ResolucionCargaGrafico()



	End Sub



	Private Sub CboFecha_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboFecha.SelectedIndexChanged

		ResolucionCargarDatos()
		ResolucionEsteticaDtg()
		ResolucionCargaGrafico()
	End Sub

	Private Sub CboFecha_DrawItem(sender As Object, e As DrawItemEventArgs) Handles CboFecha.DrawItem
		If e.Index >= 0 Then
			Using st As New StringFormat With {.Alignment = StringAlignment.Center}
				e.Graphics.DrawString(sender.Items(e.Index).ToString, e.Font, Brushes.Black, e.Bounds, st)
			End Using
		End If
	End Sub


End Class
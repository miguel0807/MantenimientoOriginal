Imports System.Data.SqlClient
Public Class Registro_Preventivo
    Private Sub Fecha_DateSelected(sender As Object, e As DateRangeEventArgs) Handles Fecha.DateSelected
        Clase.Visible = True
        Label1.Visible = True
    End Sub

    Private Sub Fecha_DateChanged(sender As Object, e As DateRangeEventArgs) Handles Fecha.DateChanged


#Region "Cargar datos en combobox de Clase"
        Dim mes As String = Fecha.SelectionStart.Month.ToString

        Select Case mes
            Case "1"
                mes = "Enero"
            Case "2"
                mes = "Febrero"
            Case "3"
                mes = "Marzo"
            Case "4"
                mes = "Abril"
            Case "5"
                mes = "Mayo"
            Case "6"
                mes = "Junio"
            Case "7"
                mes = "Julio"
            Case "8"
                mes = "Agosto"
            Case "9"
                mes = "Septiembre"
            Case "10"
                mes = "Octubre"
            Case "11"
                mes = "Noviembre"
            Case "12"
                mes = "Diciembre"

        End Select
        '  MsgBox(mes)
        Try
            Dim cmd As String = "select carac.Clase from ConteoPlanificacion_Equipos conteo, Caracteristicas_Equipo carac where año=" & Fecha.SelectionStart.Year.ToString & "  and " & mes & " <5000 and " & mes & ">0 and conteo.Codigo=carac.Codigo"
            '  MsgBox(cmd)
            Dim da As New SqlDataAdapter(cmd, cn)
            Dim ds As New DataSet
            da.Fill(ds)
            With Me.Clase
                Me.Clase.DataSource = ds.Tables(0)
                Me.Clase.DisplayMember = "Clase"
            End With
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
#End Region
#Region "Cargar datos en combobox de Responsable"
        Try
            Dim cmd As String = "select*from Usuarios"
            Dim da As New SqlDataAdapter(cmd, cn)
            Dim ds As New DataSet
            da.Fill(ds)
            With Me.Responsable
                Me.Responsable.DataSource = ds.Tables(0)
                Me.Responsable.DisplayMember = "Nombre"
            End With
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
#End Region
    End Sub

    Private Sub Registro_Preventivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not formularios.Contains(Me) Then formularios.Add(Me) 'Agrega a la lista los formularios para luego cerrarlos
    End Sub

    Private Sub Clase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Clase.SelectedIndexChanged

    End Sub
End Class
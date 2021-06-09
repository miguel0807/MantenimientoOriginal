Public Class Programas
    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Dim f As New Tank_Farm.Niveles()

        f.Show()
        Me.Close()

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Presentacion.Show()
        Me.Close()
    End Sub

    Private Sub Programas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Programas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'Mantenimiento.Login.Close()
    End Sub
End Class
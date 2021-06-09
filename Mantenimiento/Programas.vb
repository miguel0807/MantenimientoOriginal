Public Class Programas


    Dim _enabledCerrar As Boolean = False
    <System.ComponentModel.DefaultValue(False), System.ComponentModel.Description("Define si se habilita el botón cerrar en el formulario")>
    Public Property EnabledCerrar() As Boolean
        Get
            Return _enabledCerrar
        End Get
        Set(ByVal Value As Boolean)
            If _enabledCerrar <> Value Then
                _enabledCerrar = Value
            End If
        End Set
    End Property
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            If _enabledCerrar = False Then
                Const CS_NOCLOSE As Integer = &H200
                cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE

            End If
            Return cp
        End Get
    End Property


    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Dim f As New Tank_Farm.Niveles()

        f.Show()
        Me.Close()

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Presentacion.Show()
        Me.Close()
    End Sub



    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim f As New Proyecto.FormPrincipal()

        f.Show()
        Me.Close()
    End Sub
End Class
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
        'Me.Close()
        esconder()

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Presentacion.Show()
        ' Me.Close()
        esconder()
    End Sub



    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim f As New Proyecto.FormPrincipal()



        f.Show()
        ' Me.Close()
        esconder()
    End Sub

    Private Sub Programas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sympro
        Common.isOpenForm = True
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        Proyecto.FormPrincipal.ReleaseCapture()
        Proyecto.FormPrincipal.SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)
        Me.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ContextMenuStrip1_Opening_1(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Iconostrip.Opening

    End Sub

    Private Sub ContextMenuStrip1_MouseClick(sender As Object, e As MouseEventArgs) Handles Iconostrip.MouseClick
        Me.Show()
    End Sub

    Private Sub Iconostrip_Click(sender As Object, e As EventArgs) Handles Iconostrip.Click
        Me.Show()
    End Sub

    Sub esconder()
        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        '  NotifyIcon1.BalloonTipTitle = "Enviado notificacion"
        NotifyIcon1.BalloonTipText = "Interfaz minimizada"
        NotifyIcon1.ShowBalloonTip(1000)
        Me.Hide()
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        'Dim f As New CR7.SN_Evolution()
        Dim f As New Electrónicos.Presentacion()


        f.Show()
        'Me.Close()
        esconder()
    End Sub



End Class
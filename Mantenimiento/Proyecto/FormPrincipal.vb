﻿Imports System.Runtime.InteropServices
Imports Common




Public Class FormPrincipal
#Region "FUNCIONALIDADES DEL FORMULARIO"
    'RESIZE DEL FORMULARIO- CAMBIAR TAMAÑO
    Dim cGrip As Integer = 10

    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                        >= (Me.ClientSize.Width - cGrip)) _
                        AndAlso (pos.Y _
                        >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    ''----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
    'Dim sizeGripRectangle As Rectangle
    'Dim tolerance As Integer = 15

    'Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
    '    MyBase.OnSizeChanged(e)
    '    Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
    '    sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
    '    region.Exclude(sizeGripRectangle)
    '    Me.PanelContenedor.Region = region
    '    Me.Invalidate()
    'End Sub

    ''----------------COLOR Y GRIP DE RECTANGULO INFERIOR
    'Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
    '    Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(244, 244, 244))
    '    e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
    '    MyBase.OnPaint(e)
    '    ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    'End Sub
    'ARRASTRAR EL FORMULARIO
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click


        If MessageBox.Show("Esta seguro de cerrar la aplicacion?", "Precaución",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then




            Application.Exit()
        End If

    End Sub

    Dim lx, ly As Integer
    Dim sw, sh As Integer

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click

        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Size.Width
        sh = Me.Size.Height

        btnMaximizar.Visible = False
        btnRestaurar.Visible = True

        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location

    End Sub



    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)

        btnMaximizar.Visible = True
        btnRestaurar.Visible = False
    End Sub
#End Region
    Public Formulario As Form
    'METODO DE ABRIR FORMULARIO
    Private Sub AbrirFormEnPanel(Of Miform As {Form, New})()

        Formulario = PanelFormularios.Controls.OfType(Of Miform)().FirstOrDefault() 'Busca el formulario en la coleccion
        'Si form no fue econtrado/ no existe
        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False

            Formulario.FormBorderStyle = FormBorderStyle.None 'Elimina el estilo de borde para los formularios abriertos
            Formulario.Dock = DockStyle.Fill 'El nuevo formulario se expande en el formulario principal

            PanelFormularios.Controls.Add(Formulario)
            PanelFormularios.Tag = Formulario
            AddHandler Formulario.FormClosed, AddressOf Me.CerrarFormulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles GenerarL.Click


#Region "Generar"

        Formulario.Close()

        My.Application.OpenForms.Cast(Of Form)() _
           .Except({Me}) _
           .ToList()


        AbrirFormEnPanel(Of Generar)()
        GenerarL.BackColor = Color.FromArgb(12, 61, 92)

        ReimpresionL.BackColor = Color.FromArgb(4, 41, 68) 'original
        CargarL.BackColor = Color.FromArgb(4, 41, 68) 'original
        VerficadorL.BackColor = Color.FromArgb(4, 41, 68) 'original
        ConfiguracionL.BackColor = Color.DimGray 'original
        ComprobacionL.BackColor = Color.FromArgb(4, 41, 68) 'original

        caja4X4.BackColor = Color.DimGray
        caja2X4.BackColor = Color.DimGray
        caja6X1.BackColor = Color.DimGray


#End Region

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ReimpresionL.Click


#Region "Reimpresion"
        Formulario.Close()

        My.Application.OpenForms.Cast(Of Form)() _
           .Except({Me}) _
           .ToList() _
        '   .ForEach(Sub(form) form.Close())


        AbrirFormEnPanel(Of Modulo_de_reimpresion)()
        ReimpresionL.BackColor = Color.FromArgb(12, 61, 92)

        GenerarL.BackColor = Color.FromArgb(4, 41, 68) 'original
        CargarL.BackColor = Color.FromArgb(4, 41, 68) 'original
        VerficadorL.BackColor = Color.FromArgb(4, 41, 68) 'original
        ConfiguracionL.BackColor = Color.DimGray 'original
        ComprobacionL.BackColor = Color.FromArgb(4, 41, 68)

        caja4X4.BackColor = Color.DimGray
        caja2X4.BackColor = Color.DimGray
        caja6X1.BackColor = Color.DimGray


#End Region

    End Sub



    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("Esta seguro de cerrar sesión?", "Precaución",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then


            'AbrirFormEnPanel(Of Cargar)()
            'Formulario.Close()
            'AbrirFormEnPanel(Of Generar)()
            'Formulario.Close()
            'AbrirFormEnPanel(Of Modulo_de_reimpresion)()

            'Formulario.Close()


            Me.Close()
        End If


    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles CargarL.Click


#Region "Cargar"
        Formulario.Close()



        My.Application.OpenForms.Cast(Of Form)()







        AbrirFormEnPanel(Of Cargar)()
        CargarL.BackColor = Color.FromArgb(12, 61, 92)
        ReimpresionL.BackColor = Color.FromArgb(4, 41, 68) 'original
        GenerarL.BackColor = Color.FromArgb(4, 41, 68) 'original
        VerficadorL.BackColor = Color.FromArgb(4, 41, 68) 'original
        ConfiguracionL.BackColor = Color.DimGray 'original
        ComprobacionL.BackColor = Color.FromArgb(4, 41, 68) 'original

        caja4X4.BackColor = Color.DimGray
        caja2X4.BackColor = Color.DimGray
        caja6X1.BackColor = Color.DimGray

#End Region
    End Sub


    'METODO/EVENTO AL CERRAR FORMS
    Private Sub CerrarFormulario(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        'CONDICION SI FORMS ESTA ABIERTO
        If (Application.OpenForms("Form1") Is Nothing) Then
            GenerarL.BackColor = Color.FromArgb(4, 41, 68)
        End If
        If (Application.OpenForms("Form2") Is Nothing) Then
            ReimpresionL.BackColor = Color.FromArgb(4, 41, 68)
        End If
        If (Application.OpenForms("Form3") Is Nothing) Then
            CargarL.BackColor = Color.FromArgb(4, 41, 68)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles VerficadorL.Click
#Region "Verificador"
        Formulario.Close()
        AbrirFormEnPanel(Of Verificador)()
        My.Application.OpenForms.Cast(Of Form)()




        VerficadorL.BackColor = Color.FromArgb(12, 61, 92)
        GenerarL.BackColor = Color.FromArgb(4, 41, 68) 'original
        ReimpresionL.BackColor = Color.FromArgb(4, 41, 68) 'original
        CargarL.BackColor = Color.FromArgb(4, 41, 68) 'original
        ConfiguracionL.BackColor = Color.DimGray 'original
        ComprobacionL.BackColor = Color.FromArgb(4, 41, 68)

        caja4X4.BackColor = Color.DimGray
        caja2X4.BackColor = Color.DimGray
        caja6X1.BackColor = Color.DimGray

#End Region
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles ConfiguracionL.Click
        Formulario.Close()
        AbrirFormEnPanel(Of Configuracion)()
        My.Application.OpenForms.Cast(Of Form)()



        ConfiguracionL.BackColor = Color.DimGray 'original


        GenerarL.BackColor = Color.FromArgb(4, 41, 68) 'original
        ReimpresionL.BackColor = Color.FromArgb(4, 41, 68) 'original
        CargarL.BackColor = Color.FromArgb(4, 41, 68) 'original
        VerficadorL.BackColor = Color.FromArgb(4, 41, 68) 'original
        ComprobacionL.BackColor = Color.FromArgb(4, 41, 68)

        caja4X4.BackColor = Color.DimGray
        caja2X4.BackColor = Color.DimGray
        caja6X1.BackColor = Color.DimGray

    End Sub



    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles ComprobacionL.Click
#Region "Comprobacion"
        Formulario.Close()
        If Panel2.Visible = True Then
            Panel2.Visible = False
        Else
            Panel2.Visible = True
        End If

        GenerarL.BackColor = Color.FromArgb(4, 41, 68) 'original
        CargarL.BackColor = Color.FromArgb(4, 41, 68) 'original
        VerficadorL.BackColor = Color.FromArgb(4, 41, 68) 'original
        ConfiguracionL.BackColor = Color.DimGray 'original
        ComprobacionL.BackColor = Color.FromArgb(4, 41, 68)

        caja4X4.BackColor = Color.DimGray
        caja2X4.BackColor = Color.DimGray
        caja6X1.BackColor = Color.DimGray
#End Region
    End Sub



    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles caja6X1.Click
        Formulario.Close()
        AbrirFormEnPanel(Of V6X1)()
        My.Application.OpenForms.Cast(Of Form)()





        caja6X1.BackColor = Color.FromArgb(12, 61, 92)




        caja4X4.BackColor = Color.DimGray
        caja2X4.BackColor = Color.DimGray
        GenerarL.BackColor = Color.FromArgb(4, 41, 68) 'original
        ReimpresionL.BackColor = Color.FromArgb(4, 41, 68) 'original
        CargarL.BackColor = Color.FromArgb(4, 41, 68) 'original
        VerficadorL.BackColor = Color.FromArgb(4, 41, 68)
        ConfiguracionL.BackColor = Color.DimGray 'original
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles caja2X4.Click
        Formulario.Close()
        AbrirFormEnPanel(Of V2X4)()
        My.Application.OpenForms.Cast(Of Form)()





        caja2X4.BackColor = Color.FromArgb(12, 61, 92)

        caja4X4.BackColor = Color.DimGray
        caja6X1.BackColor = Color.DimGray

        GenerarL.BackColor = Color.FromArgb(4, 41, 68) 'original
        ReimpresionL.BackColor = Color.FromArgb(4, 41, 68) 'original
        CargarL.BackColor = Color.FromArgb(4, 41, 68) 'original
        VerficadorL.BackColor = Color.FromArgb(4, 41, 68)
        ConfiguracionL.BackColor = Color.DimGray 'original
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles caja4X4.Click
        Formulario.Close()
        AbrirFormEnPanel(Of V4X4)()
        My.Application.OpenForms.Cast(Of Form)()






        caja4X4.BackColor = Color.FromArgb(12, 61, 92)



        caja2X4.BackColor = Color.DimGray
        caja6X1.BackColor = Color.DimGray



        GenerarL.BackColor = Color.FromArgb(4, 41, 68) 'original
        ReimpresionL.BackColor = Color.FromArgb(4, 41, 68) 'original
        CargarL.BackColor = Color.FromArgb(4, 41, 68) 'original
        VerficadorL.BackColor = Color.FromArgb(4, 41, 68)
        ConfiguracionL.BackColor = Color.DimGray 'original
    End Sub

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        CenterToScreen()

        AbrirFormEnPanel(Of Presentacion)()
        ' Me.WindowState = FormWindowState.Maximized
        'Me.Size = My.Computer.Screen.WorkingArea.Size

        ' Me.Location = New System.Drawing.Point(0, 0)

        Label1.Text = ActiveUser.firstName + " " + ActiveUser.lastName
        Label2.Text = ActiveUser.email
        Label3.Text = ActiveUser.position

        If Label3.Text = "Quality Inspector" Then
            VerficadorL.Enabled = True

        ElseIf Label3.Text = "Administrador" Then
            GenerarL.Enabled = True
            ReimpresionL.Enabled = True
            VerficadorL.Enabled = True
            CargarL.Enabled = True
            ComprobacionL.Enabled = True
            ConfiguracionL.Enabled = True
        ElseIf Label3.Text = "Machine Operator" Then
            GenerarL.Enabled = True
            ReimpresionL.Enabled = True
            VerficadorL.Enabled = True
            CargarL.Enabled = True


        ElseIf Label3.Text = "Filler Operator" Then
            ComprobacionL.Enabled = True

        ElseIf Label3.Text = "Production Supervisor" Then
            ComprobacionL.Enabled = True

        ElseIf Label3.Text = "" Then
            MsgBox("El usuario no tiene autorizacion para usar el programa")
            GenerarL.Enabled = False
            ReimpresionL.Enabled = False
            CargarL.Enabled = False
            VerficadorL.Enabled = False
            ConfiguracionL.Enabled = False
        End If






    End Sub

    Private Sub PanelFormularios_Paint(sender As Object, e As PaintEventArgs) Handles PanelFormularios.Paint

    End Sub

    Private Sub LOGO_ClientSizeChanged(sender As Object, e As EventArgs)
        CenterToScreen()
    End Sub

    Private Sub btnCerrar_MouseHover(sender As Object, e As EventArgs) Handles btnCerrar.MouseHover

    End Sub
End Class

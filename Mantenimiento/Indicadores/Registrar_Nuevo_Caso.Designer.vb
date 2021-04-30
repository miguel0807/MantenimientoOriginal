<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registrar_Nuevo_Caso
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.panelDatos = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblAcumuladoMinutos = New System.Windows.Forms.Label()
        Me.lblTiempoAcumulado = New System.Windows.Forms.Label()
        Me.minutoAcumulado = New System.Windows.Forms.TextBox()
        Me.lblAcumuladoHoras = New System.Windows.Forms.Label()
        Me.btnAgregarTiempo = New System.Windows.Forms.Button()
        Me.calminutos = New System.Windows.Forms.Label()
        Me.horaAcumulada = New System.Windows.Forms.TextBox()
        Me.btnTiempoInicio = New System.Windows.Forms.Button()
        Me.lblCalcularMinutos = New System.Windows.Forms.Label()
        Me.Tiempo_Inicio = New System.Windows.Forms.TextBox()
        Me.btnTiempoFinal = New System.Windows.Forms.Button()
        Me.calhoras = New System.Windows.Forms.Label()
        Me.Tiempo_Final = New System.Windows.Forms.TextBox()
        Me.lblCalcularHoras = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSolucionProblema = New System.Windows.Forms.TextBox()
        Me.btnFinalizado = New System.Windows.Forms.Button()
        Me.lblSolucionProblema = New System.Windows.Forms.Label()
        Me.btnFechaInicio = New System.Windows.Forms.Button()
        Me.fecha_final = New System.Windows.Forms.TextBox()
        Me.cboEquipo = New System.Windows.Forms.ComboBox()
        Me.btnPendiente = New System.Windows.Forms.Button()
        Me.btnFechaFinal = New System.Windows.Forms.Button()
        Me.lblEquipo = New System.Windows.Forms.Label()
        Me.fecha_Inicio = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.cboResponsable = New System.Windows.Forms.ComboBox()
        Me.cboClase = New System.Windows.Forms.ComboBox()
        Me.lblClase = New System.Windows.Forms.Label()
        Me.lblResponsable = New System.Windows.Forms.Label()
        Me.cboUbicacion = New System.Windows.Forms.ComboBox()
        Me.cboClasificacion = New System.Windows.Forms.ComboBox()
        Me.lblClasificacion = New System.Windows.Forms.Label()
        Me.lblUbicacion = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.lblCaso = New System.Windows.Forms.Label()
        Me.panelDatos.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtDescripcion.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(559, 143)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(380, 81)
        Me.txtDescripcion.TabIndex = 83
        '
        'panelDatos
        '
        Me.panelDatos.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelDatos.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.panelDatos.Controls.Add(Me.Panel2)
        Me.panelDatos.Controls.Add(Me.Panel1)
        Me.panelDatos.Controls.Add(Me.txtSolucionProblema)
        Me.panelDatos.Controls.Add(Me.btnFinalizado)
        Me.panelDatos.Controls.Add(Me.lblSolucionProblema)
        Me.panelDatos.Controls.Add(Me.btnFechaInicio)
        Me.panelDatos.Controls.Add(Me.fecha_final)
        Me.panelDatos.Controls.Add(Me.cboEquipo)
        Me.panelDatos.Controls.Add(Me.btnPendiente)
        Me.panelDatos.Controls.Add(Me.btnFechaFinal)
        Me.panelDatos.Controls.Add(Me.lblEquipo)
        Me.panelDatos.Controls.Add(Me.fecha_Inicio)
        Me.panelDatos.Controls.Add(Me.lblDescripcion)
        Me.panelDatos.Controls.Add(Me.cboResponsable)
        Me.panelDatos.Controls.Add(Me.txtDescripcion)
        Me.panelDatos.Controls.Add(Me.cboClase)
        Me.panelDatos.Controls.Add(Me.lblClase)
        Me.panelDatos.Controls.Add(Me.lblResponsable)
        Me.panelDatos.Controls.Add(Me.cboUbicacion)
        Me.panelDatos.Controls.Add(Me.cboClasificacion)
        Me.panelDatos.Controls.Add(Me.lblClasificacion)
        Me.panelDatos.Controls.Add(Me.lblUbicacion)
        Me.panelDatos.Controls.Add(Me.lblTitulo)
        Me.panelDatos.Controls.Add(Me.txtTitulo)
        Me.panelDatos.Location = New System.Drawing.Point(18, 31)
        Me.panelDatos.MinimumSize = New System.Drawing.Size(1016, 702)
        Me.panelDatos.Name = "panelDatos"
        Me.panelDatos.Size = New System.Drawing.Size(1016, 702)
        Me.panelDatos.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.lblAcumuladoMinutos)
        Me.Panel2.Controls.Add(Me.lblTiempoAcumulado)
        Me.Panel2.Controls.Add(Me.minutoAcumulado)
        Me.Panel2.Controls.Add(Me.lblAcumuladoHoras)
        Me.Panel2.Controls.Add(Me.btnAgregarTiempo)
        Me.Panel2.Controls.Add(Me.calminutos)
        Me.Panel2.Controls.Add(Me.horaAcumulada)
        Me.Panel2.Controls.Add(Me.btnTiempoInicio)
        Me.Panel2.Controls.Add(Me.lblCalcularMinutos)
        Me.Panel2.Controls.Add(Me.Tiempo_Inicio)
        Me.Panel2.Controls.Add(Me.btnTiempoFinal)
        Me.Panel2.Controls.Add(Me.calhoras)
        Me.Panel2.Controls.Add(Me.Tiempo_Final)
        Me.Panel2.Controls.Add(Me.lblCalcularHoras)
        Me.Panel2.Controls.Add(Me.btnCalcular)
        Me.Panel2.Location = New System.Drawing.Point(8, 405)
        Me.Panel2.MinimumSize = New System.Drawing.Size(712, 274)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(712, 274)
        Me.Panel2.TabIndex = 112
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Location = New System.Drawing.Point(429, -15)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 309)
        Me.Panel3.TabIndex = 111
        '
        'lblAcumuladoMinutos
        '
        Me.lblAcumuladoMinutos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAcumuladoMinutos.BackColor = System.Drawing.Color.LightGray
        Me.lblAcumuladoMinutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.lblAcumuladoMinutos.Location = New System.Drawing.Point(483, 122)
        Me.lblAcumuladoMinutos.Name = "lblAcumuladoMinutos"
        Me.lblAcumuladoMinutos.Size = New System.Drawing.Size(103, 31)
        Me.lblAcumuladoMinutos.TabIndex = 107
        Me.lblAcumuladoMinutos.Text = "Minutos:"
        Me.lblAcumuladoMinutos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTiempoAcumulado
        '
        Me.lblTiempoAcumulado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTiempoAcumulado.AutoSize = True
        Me.lblTiempoAcumulado.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblTiempoAcumulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.lblTiempoAcumulado.Location = New System.Drawing.Point(456, 18)
        Me.lblTiempoAcumulado.Name = "lblTiempoAcumulado"
        Me.lblTiempoAcumulado.Size = New System.Drawing.Size(229, 29)
        Me.lblTiempoAcumulado.TabIndex = 105
        Me.lblTiempoAcumulado.Text = "Tiempo Acumulado:"
        '
        'minutoAcumulado
        '
        Me.minutoAcumulado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minutoAcumulado.BackColor = System.Drawing.Color.WhiteSmoke
        Me.minutoAcumulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minutoAcumulado.Location = New System.Drawing.Point(599, 122)
        Me.minutoAcumulado.Name = "minutoAcumulado"
        Me.minutoAcumulado.Size = New System.Drawing.Size(45, 34)
        Me.minutoAcumulado.TabIndex = 110
        Me.minutoAcumulado.Text = "0"
        Me.minutoAcumulado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAcumuladoHoras
        '
        Me.lblAcumuladoHoras.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAcumuladoHoras.BackColor = System.Drawing.Color.LightGray
        Me.lblAcumuladoHoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.lblAcumuladoHoras.Location = New System.Drawing.Point(483, 64)
        Me.lblAcumuladoHoras.Name = "lblAcumuladoHoras"
        Me.lblAcumuladoHoras.Size = New System.Drawing.Size(103, 31)
        Me.lblAcumuladoHoras.TabIndex = 106
        Me.lblAcumuladoHoras.Text = "Horas:"
        Me.lblAcumuladoHoras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAgregarTiempo
        '
        Me.btnAgregarTiempo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarTiempo.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarTiempo.Location = New System.Drawing.Point(477, 187)
        Me.btnAgregarTiempo.Name = "btnAgregarTiempo"
        Me.btnAgregarTiempo.Size = New System.Drawing.Size(193, 49)
        Me.btnAgregarTiempo.TabIndex = 108
        Me.btnAgregarTiempo.Text = "Agregar tiempo"
        Me.btnAgregarTiempo.UseVisualStyleBackColor = True
        '
        'calminutos
        '
        Me.calminutos.BackColor = System.Drawing.Color.LightGray
        Me.calminutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.calminutos.Location = New System.Drawing.Point(311, 218)
        Me.calminutos.Name = "calminutos"
        Me.calminutos.Size = New System.Drawing.Size(45, 34)
        Me.calminutos.TabIndex = 103
        Me.calminutos.Text = "0"
        Me.calminutos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'horaAcumulada
        '
        Me.horaAcumulada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.horaAcumulada.BackColor = System.Drawing.Color.WhiteSmoke
        Me.horaAcumulada.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.horaAcumulada.Location = New System.Drawing.Point(599, 61)
        Me.horaAcumulada.Name = "horaAcumulada"
        Me.horaAcumulada.Size = New System.Drawing.Size(45, 34)
        Me.horaAcumulada.TabIndex = 109
        Me.horaAcumulada.Text = "0"
        Me.horaAcumulada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnTiempoInicio
        '
        Me.btnTiempoInicio.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTiempoInicio.Location = New System.Drawing.Point(10, 40)
        Me.btnTiempoInicio.Name = "btnTiempoInicio"
        Me.btnTiempoInicio.Size = New System.Drawing.Size(151, 52)
        Me.btnTiempoInicio.TabIndex = 95
        Me.btnTiempoInicio.Text = "Tiempo Inicio"
        Me.btnTiempoInicio.UseVisualStyleBackColor = True
        '
        'lblCalcularMinutos
        '
        Me.lblCalcularMinutos.BackColor = System.Drawing.Color.LightGray
        Me.lblCalcularMinutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.lblCalcularMinutos.Location = New System.Drawing.Point(187, 216)
        Me.lblCalcularMinutos.Name = "lblCalcularMinutos"
        Me.lblCalcularMinutos.Size = New System.Drawing.Size(103, 31)
        Me.lblCalcularMinutos.TabIndex = 102
        Me.lblCalcularMinutos.Text = "Minutos:"
        Me.lblCalcularMinutos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tiempo_Inicio
        '
        Me.Tiempo_Inicio.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Tiempo_Inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tiempo_Inicio.Location = New System.Drawing.Point(186, 38)
        Me.Tiempo_Inicio.Name = "Tiempo_Inicio"
        Me.Tiempo_Inicio.Size = New System.Drawing.Size(230, 34)
        Me.Tiempo_Inicio.TabIndex = 96
        Me.Tiempo_Inicio.Text = "00:00:00"
        Me.Tiempo_Inicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnTiempoFinal
        '
        Me.btnTiempoFinal.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTiempoFinal.Location = New System.Drawing.Point(10, 107)
        Me.btnTiempoFinal.Name = "btnTiempoFinal"
        Me.btnTiempoFinal.Size = New System.Drawing.Size(151, 52)
        Me.btnTiempoFinal.TabIndex = 97
        Me.btnTiempoFinal.Text = "Tiempo Final"
        Me.btnTiempoFinal.UseVisualStyleBackColor = True
        '
        'calhoras
        '
        Me.calhoras.BackColor = System.Drawing.Color.LightGray
        Me.calhoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.calhoras.Location = New System.Drawing.Point(311, 165)
        Me.calhoras.Name = "calhoras"
        Me.calhoras.Size = New System.Drawing.Size(45, 34)
        Me.calhoras.TabIndex = 100
        Me.calhoras.Text = "0"
        Me.calhoras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tiempo_Final
        '
        Me.Tiempo_Final.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Tiempo_Final.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tiempo_Final.Location = New System.Drawing.Point(186, 105)
        Me.Tiempo_Final.Name = "Tiempo_Final"
        Me.Tiempo_Final.Size = New System.Drawing.Size(230, 34)
        Me.Tiempo_Final.TabIndex = 98
        Me.Tiempo_Final.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCalcularHoras
        '
        Me.lblCalcularHoras.BackColor = System.Drawing.Color.LightGray
        Me.lblCalcularHoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.lblCalcularHoras.Location = New System.Drawing.Point(187, 165)
        Me.lblCalcularHoras.Name = "lblCalcularHoras"
        Me.lblCalcularHoras.Size = New System.Drawing.Size(103, 31)
        Me.lblCalcularHoras.TabIndex = 101
        Me.lblCalcularHoras.Text = "Horas:"
        Me.lblCalcularHoras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(10, 196)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(136, 40)
        Me.btnCalcular.TabIndex = 99
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Location = New System.Drawing.Point(0, 368)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1016, 16)
        Me.Panel1.TabIndex = 111
        '
        'txtSolucionProblema
        '
        Me.txtSolucionProblema.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtSolucionProblema.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSolucionProblema.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSolucionProblema.Location = New System.Drawing.Point(559, 259)
        Me.txtSolucionProblema.Multiline = True
        Me.txtSolucionProblema.Name = "txtSolucionProblema"
        Me.txtSolucionProblema.Size = New System.Drawing.Size(380, 103)
        Me.txtSolucionProblema.TabIndex = 87
        '
        'btnFinalizado
        '
        Me.btnFinalizado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFinalizado.Font = New System.Drawing.Font("Microsoft PhagsPa", 16.2!)
        Me.btnFinalizado.Location = New System.Drawing.Point(762, 548)
        Me.btnFinalizado.Name = "btnFinalizado"
        Me.btnFinalizado.Size = New System.Drawing.Size(233, 58)
        Me.btnFinalizado.TabIndex = 85
        Me.btnFinalizado.Text = "Finalizado"
        Me.btnFinalizado.UseVisualStyleBackColor = True
        '
        'lblSolucionProblema
        '
        Me.lblSolucionProblema.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblSolucionProblema.AutoSize = True
        Me.lblSolucionProblema.BackColor = System.Drawing.Color.Transparent
        Me.lblSolucionProblema.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSolucionProblema.ForeColor = System.Drawing.SystemColors.Control
        Me.lblSolucionProblema.Location = New System.Drawing.Point(562, 227)
        Me.lblSolucionProblema.Name = "lblSolucionProblema"
        Me.lblSolucionProblema.Size = New System.Drawing.Size(258, 32)
        Me.lblSolucionProblema.TabIndex = 88
        Me.lblSolucionProblema.Text = "Solución al problema"
        '
        'btnFechaInicio
        '
        Me.btnFechaInicio.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnFechaInicio.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechaInicio.Location = New System.Drawing.Point(559, 23)
        Me.btnFechaInicio.Name = "btnFechaInicio"
        Me.btnFechaInicio.Size = New System.Drawing.Size(135, 31)
        Me.btnFechaInicio.TabIndex = 1
        Me.btnFechaInicio.Text = "Fecha Inicio"
        Me.btnFechaInicio.UseVisualStyleBackColor = True
        '
        'fecha_final
        '
        Me.fecha_final.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.fecha_final.BackColor = System.Drawing.Color.WhiteSmoke
        Me.fecha_final.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_final.Location = New System.Drawing.Point(720, 75)
        Me.fecha_final.Name = "fecha_final"
        Me.fecha_final.Size = New System.Drawing.Size(230, 34)
        Me.fecha_final.TabIndex = 2
        '
        'cboEquipo
        '
        Me.cboEquipo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cboEquipo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEquipo.FormattingEnabled = True
        Me.cboEquipo.Items.AddRange(New Object() {"c3-1"})
        Me.cboEquipo.Location = New System.Drawing.Point(300, 250)
        Me.cboEquipo.Name = "cboEquipo"
        Me.cboEquipo.Size = New System.Drawing.Size(228, 33)
        Me.cboEquipo.TabIndex = 79
        Me.cboEquipo.Visible = False
        '
        'btnPendiente
        '
        Me.btnPendiente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPendiente.Font = New System.Drawing.Font("Microsoft PhagsPa", 16.2!)
        Me.btnPendiente.Location = New System.Drawing.Point(762, 441)
        Me.btnPendiente.Name = "btnPendiente"
        Me.btnPendiente.Size = New System.Drawing.Size(233, 58)
        Me.btnPendiente.TabIndex = 84
        Me.btnPendiente.Text = "Pendiente"
        Me.btnPendiente.UseVisualStyleBackColor = True
        '
        'btnFechaFinal
        '
        Me.btnFechaFinal.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnFechaFinal.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechaFinal.Location = New System.Drawing.Point(559, 75)
        Me.btnFechaFinal.Name = "btnFechaFinal"
        Me.btnFechaFinal.Size = New System.Drawing.Size(135, 31)
        Me.btnFechaFinal.TabIndex = 1
        Me.btnFechaFinal.Text = "Fecha Final"
        Me.btnFechaFinal.UseVisualStyleBackColor = True
        '
        'lblEquipo
        '
        Me.lblEquipo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblEquipo.AutoSize = True
        Me.lblEquipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEquipo.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!)
        Me.lblEquipo.Location = New System.Drawing.Point(369, 214)
        Me.lblEquipo.Name = "lblEquipo"
        Me.lblEquipo.Size = New System.Drawing.Size(90, 33)
        Me.lblEquipo.TabIndex = 80
        Me.lblEquipo.Text = "Equipo"
        Me.lblEquipo.Visible = False
        '
        'fecha_Inicio
        '
        Me.fecha_Inicio.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.fecha_Inicio.BackColor = System.Drawing.Color.WhiteSmoke
        Me.fecha_Inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_Inicio.Location = New System.Drawing.Point(719, 21)
        Me.fecha_Inicio.Name = "fecha_Inicio"
        Me.fecha_Inicio.Size = New System.Drawing.Size(230, 34)
        Me.fecha_Inicio.TabIndex = 2
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.ForeColor = System.Drawing.SystemColors.Control
        Me.lblDescripcion.Location = New System.Drawing.Point(562, 109)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(150, 32)
        Me.lblDescripcion.TabIndex = 86
        Me.lblDescripcion.Text = "Descripción"
        '
        'cboResponsable
        '
        Me.cboResponsable.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cboResponsable.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboResponsable.FormattingEnabled = True
        Me.cboResponsable.Location = New System.Drawing.Point(299, 47)
        Me.cboResponsable.Name = "cboResponsable"
        Me.cboResponsable.Size = New System.Drawing.Size(228, 33)
        Me.cboResponsable.TabIndex = 75
        '
        'cboClase
        '
        Me.cboClase.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cboClase.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClase.FormattingEnabled = True
        Me.cboClase.Location = New System.Drawing.Point(17, 250)
        Me.cboClase.Name = "cboClase"
        Me.cboClase.Size = New System.Drawing.Size(228, 33)
        Me.cboClase.TabIndex = 76
        Me.cboClase.Visible = False
        '
        'lblClase
        '
        Me.lblClase.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblClase.AutoSize = True
        Me.lblClase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblClase.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!)
        Me.lblClase.Location = New System.Drawing.Point(82, 214)
        Me.lblClase.Name = "lblClase"
        Me.lblClase.Size = New System.Drawing.Size(72, 33)
        Me.lblClase.TabIndex = 78
        Me.lblClase.Text = "Clase"
        Me.lblClase.Visible = False
        '
        'lblResponsable
        '
        Me.lblResponsable.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblResponsable.AutoSize = True
        Me.lblResponsable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResponsable.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!)
        Me.lblResponsable.Location = New System.Drawing.Point(333, 11)
        Me.lblResponsable.Name = "lblResponsable"
        Me.lblResponsable.Size = New System.Drawing.Size(150, 33)
        Me.lblResponsable.TabIndex = 77
        Me.lblResponsable.Text = "Responsable"
        '
        'cboUbicacion
        '
        Me.cboUbicacion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cboUbicacion.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUbicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUbicacion.FormattingEnabled = True
        Me.cboUbicacion.Items.AddRange(New Object() {"Mantenimiento"})
        Me.cboUbicacion.Location = New System.Drawing.Point(17, 146)
        Me.cboUbicacion.Name = "cboUbicacion"
        Me.cboUbicacion.Size = New System.Drawing.Size(228, 33)
        Me.cboUbicacion.TabIndex = 2
        '
        'cboClasificacion
        '
        Me.cboClasificacion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cboClasificacion.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboClasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClasificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClasificacion.FormattingEnabled = True
        Me.cboClasificacion.Location = New System.Drawing.Point(17, 47)
        Me.cboClasificacion.Name = "cboClasificacion"
        Me.cboClasificacion.Size = New System.Drawing.Size(228, 33)
        Me.cboClasificacion.TabIndex = 3
        '
        'lblClasificacion
        '
        Me.lblClasificacion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblClasificacion.AutoSize = True
        Me.lblClasificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblClasificacion.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!)
        Me.lblClasificacion.Location = New System.Drawing.Point(58, 11)
        Me.lblClasificacion.Name = "lblClasificacion"
        Me.lblClasificacion.Size = New System.Drawing.Size(147, 33)
        Me.lblClasificacion.TabIndex = 74
        Me.lblClasificacion.Text = "Clasificación"
        '
        'lblUbicacion
        '
        Me.lblUbicacion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblUbicacion.AutoSize = True
        Me.lblUbicacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUbicacion.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!)
        Me.lblUbicacion.Location = New System.Drawing.Point(59, 110)
        Me.lblUbicacion.Name = "lblUbicacion"
        Me.lblUbicacion.Size = New System.Drawing.Size(120, 33)
        Me.lblUbicacion.TabIndex = 72
        Me.lblUbicacion.Text = "Ubicación"
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(360, 110)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(77, 33)
        Me.lblTitulo.TabIndex = 66
        Me.lblTitulo.Text = "Título"
        '
        'txtTitulo
        '
        Me.txtTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtTitulo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.Location = New System.Drawing.Point(299, 146)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(229, 30)
        Me.txtTitulo.TabIndex = 1
        '
        'lblCaso
        '
        Me.lblCaso.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCaso.AutoSize = True
        Me.lblCaso.BackColor = System.Drawing.Color.Transparent
        Me.lblCaso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCaso.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.lblCaso.ForeColor = System.Drawing.SystemColors.Control
        Me.lblCaso.Location = New System.Drawing.Point(21, -1)
        Me.lblCaso.Name = "lblCaso"
        Me.lblCaso.Size = New System.Drawing.Size(86, 29)
        Me.lblCaso.TabIndex = 87
        Me.lblCaso.Text = "Label3"
        '
        'Registrar_Nuevo_Caso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1046, 745)
        Me.Controls.Add(Me.lblCaso)
        Me.Controls.Add(Me.panelDatos)
        Me.MinimumSize = New System.Drawing.Size(1064, 792)
        Me.Name = "Registrar_Nuevo_Caso"
        Me.panelDatos.ResumeLayout(False)
        Me.panelDatos.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents panelDatos As Panel
    Friend WithEvents cboUbicacion As ComboBox
    Friend WithEvents cboClasificacion As ComboBox
    Friend WithEvents lblClasificacion As Label
    Friend WithEvents lblUbicacion As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents fecha_final As TextBox
    Friend WithEvents btnFechaFinal As Button
    Friend WithEvents fecha_Inicio As TextBox
    Friend WithEvents btnFechaInicio As Button
    Friend WithEvents lblCaso As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents cboEquipo As ComboBox
    Friend WithEvents lblEquipo As Label
    Friend WithEvents cboResponsable As ComboBox
    Friend WithEvents cboClase As ComboBox
    Friend WithEvents lblClase As Label
    Friend WithEvents lblResponsable As Label
    Friend WithEvents lblSolucionProblema As Label
    Friend WithEvents txtSolucionProblema As TextBox
    Friend WithEvents minutoAcumulado As TextBox
    Friend WithEvents btnAgregarTiempo As Button
    Friend WithEvents horaAcumulada As TextBox
    Friend WithEvents lblAcumuladoMinutos As Label
    Friend WithEvents lblAcumuladoHoras As Label
    Friend WithEvents lblTiempoAcumulado As Label
    Friend WithEvents btnFinalizado As Button
    Friend WithEvents calminutos As Label
    Friend WithEvents lblCalcularMinutos As Label
    Friend WithEvents calhoras As Label
    Friend WithEvents lblCalcularHoras As Label
    Friend WithEvents btnPendiente As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Tiempo_Final As TextBox
    Friend WithEvents btnTiempoFinal As Button
    Friend WithEvents btnTiempoInicio As Button
    Friend WithEvents Tiempo_Inicio As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class

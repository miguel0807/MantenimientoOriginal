<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar_Nuevo_Caso
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.panelDatos = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.minutoAcumulado = New System.Windows.Forms.TextBox()
        Me.btnAgregarTiempo = New System.Windows.Forms.Button()
        Me.horaAcumulada = New System.Windows.Forms.TextBox()
        Me.lblAcumuladoMinutos = New System.Windows.Forms.Label()
        Me.lblAcumuladoHoras = New System.Windows.Forms.Label()
        Me.lblTiempoAcumulado = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnFinalizado = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.calminutos = New System.Windows.Forms.Label()
        Me.btnFechaInicio = New System.Windows.Forms.Button()
        Me.lblCalcularMinutos = New System.Windows.Forms.Label()
        Me.fecha_final = New System.Windows.Forms.TextBox()
        Me.calhoras = New System.Windows.Forms.Label()
        Me.lblCalcularHoras = New System.Windows.Forms.Label()
        Me.cboEquipo = New System.Windows.Forms.ComboBox()
        Me.btnPendiente = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnFechaFinal = New System.Windows.Forms.Button()
        Me.Tiempo_Final = New System.Windows.Forms.TextBox()
        Me.lblEquipo = New System.Windows.Forms.Label()
        Me.btnTiempoFinal = New System.Windows.Forms.Button()
        Me.fecha_Inicio = New System.Windows.Forms.TextBox()
        Me.btnTiempoInicio = New System.Windows.Forms.Button()
        Me.Tiempo_Inicio = New System.Windows.Forms.TextBox()
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panelDatos.SuspendLayout()
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
        Me.panelDatos.Controls.Add(Me.Panel1)
        Me.panelDatos.Controls.Add(Me.minutoAcumulado)
        Me.panelDatos.Controls.Add(Me.btnAgregarTiempo)
        Me.panelDatos.Controls.Add(Me.horaAcumulada)
        Me.panelDatos.Controls.Add(Me.lblAcumuladoMinutos)
        Me.panelDatos.Controls.Add(Me.lblAcumuladoHoras)
        Me.panelDatos.Controls.Add(Me.lblTiempoAcumulado)
        Me.panelDatos.Controls.Add(Me.TextBox1)
        Me.panelDatos.Controls.Add(Me.btnFinalizado)
        Me.panelDatos.Controls.Add(Me.Label1)
        Me.panelDatos.Controls.Add(Me.calminutos)
        Me.panelDatos.Controls.Add(Me.btnFechaInicio)
        Me.panelDatos.Controls.Add(Me.lblCalcularMinutos)
        Me.panelDatos.Controls.Add(Me.fecha_final)
        Me.panelDatos.Controls.Add(Me.calhoras)
        Me.panelDatos.Controls.Add(Me.lblCalcularHoras)
        Me.panelDatos.Controls.Add(Me.cboEquipo)
        Me.panelDatos.Controls.Add(Me.btnPendiente)
        Me.panelDatos.Controls.Add(Me.btnCalcular)
        Me.panelDatos.Controls.Add(Me.btnFechaFinal)
        Me.panelDatos.Controls.Add(Me.Tiempo_Final)
        Me.panelDatos.Controls.Add(Me.lblEquipo)
        Me.panelDatos.Controls.Add(Me.btnTiempoFinal)
        Me.panelDatos.Controls.Add(Me.fecha_Inicio)
        Me.panelDatos.Controls.Add(Me.btnTiempoInicio)
        Me.panelDatos.Controls.Add(Me.Tiempo_Inicio)
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
        Me.panelDatos.Name = "panelDatos"
        Me.panelDatos.Size = New System.Drawing.Size(1016, 702)
        Me.panelDatos.TabIndex = 1
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
        'minutoAcumulado
        '
        Me.minutoAcumulado.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.minutoAcumulado.BackColor = System.Drawing.Color.WhiteSmoke
        Me.minutoAcumulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minutoAcumulado.Location = New System.Drawing.Point(867, 547)
        Me.minutoAcumulado.Name = "minutoAcumulado"
        Me.minutoAcumulado.Size = New System.Drawing.Size(45, 34)
        Me.minutoAcumulado.TabIndex = 110
        Me.minutoAcumulado.Text = "0"
        Me.minutoAcumulado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAgregarTiempo
        '
        Me.btnAgregarTiempo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnAgregarTiempo.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarTiempo.Location = New System.Drawing.Point(559, 492)
        Me.btnAgregarTiempo.Name = "btnAgregarTiempo"
        Me.btnAgregarTiempo.Size = New System.Drawing.Size(138, 67)
        Me.btnAgregarTiempo.TabIndex = 108
        Me.btnAgregarTiempo.Text = "Agregar tiempo"
        Me.btnAgregarTiempo.UseVisualStyleBackColor = True
        '
        'horaAcumulada
        '
        Me.horaAcumulada.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.horaAcumulada.BackColor = System.Drawing.Color.WhiteSmoke
        Me.horaAcumulada.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.horaAcumulada.Location = New System.Drawing.Point(867, 486)
        Me.horaAcumulada.Name = "horaAcumulada"
        Me.horaAcumulada.Size = New System.Drawing.Size(45, 34)
        Me.horaAcumulada.TabIndex = 109
        Me.horaAcumulada.Text = "0"
        Me.horaAcumulada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAcumuladoMinutos
        '
        Me.lblAcumuladoMinutos.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblAcumuladoMinutos.AutoSize = True
        Me.lblAcumuladoMinutos.BackColor = System.Drawing.Color.LightGray
        Me.lblAcumuladoMinutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.lblAcumuladoMinutos.Location = New System.Drawing.Point(751, 547)
        Me.lblAcumuladoMinutos.Name = "lblAcumuladoMinutos"
        Me.lblAcumuladoMinutos.Size = New System.Drawing.Size(103, 29)
        Me.lblAcumuladoMinutos.TabIndex = 107
        Me.lblAcumuladoMinutos.Text = "Minutos:"
        '
        'lblAcumuladoHoras
        '
        Me.lblAcumuladoHoras.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblAcumuladoHoras.AutoSize = True
        Me.lblAcumuladoHoras.BackColor = System.Drawing.Color.LightGray
        Me.lblAcumuladoHoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.lblAcumuladoHoras.Location = New System.Drawing.Point(751, 489)
        Me.lblAcumuladoHoras.Name = "lblAcumuladoHoras"
        Me.lblAcumuladoHoras.Size = New System.Drawing.Size(83, 29)
        Me.lblAcumuladoHoras.TabIndex = 106
        Me.lblAcumuladoHoras.Text = "Horas:"
        '
        'lblTiempoAcumulado
        '
        Me.lblTiempoAcumulado.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTiempoAcumulado.AutoSize = True
        Me.lblTiempoAcumulado.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblTiempoAcumulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.lblTiempoAcumulado.Location = New System.Drawing.Point(714, 454)
        Me.lblTiempoAcumulado.Name = "lblTiempoAcumulado"
        Me.lblTiempoAcumulado.Size = New System.Drawing.Size(229, 29)
        Me.lblTiempoAcumulado.TabIndex = 105
        Me.lblTiempoAcumulado.Text = "Tiempo Acumulado:"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TextBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(559, 259)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(380, 103)
        Me.TextBox1.TabIndex = 87
        '
        'btnFinalizado
        '
        Me.btnFinalizado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFinalizado.Font = New System.Drawing.Font("Microsoft PhagsPa", 16.2!)
        Me.btnFinalizado.Location = New System.Drawing.Point(559, 628)
        Me.btnFinalizado.Name = "btnFinalizado"
        Me.btnFinalizado.Size = New System.Drawing.Size(233, 55)
        Me.btnFinalizado.TabIndex = 85
        Me.btnFinalizado.Text = "Finalizado"
        Me.btnFinalizado.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(562, 227)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 32)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Solución al problema"
        '
        'calminutos
        '
        Me.calminutos.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.calminutos.AutoSize = True
        Me.calminutos.BackColor = System.Drawing.Color.LightGray
        Me.calminutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.calminutos.Location = New System.Drawing.Point(335, 542)
        Me.calminutos.Name = "calminutos"
        Me.calminutos.Size = New System.Drawing.Size(26, 29)
        Me.calminutos.TabIndex = 103
        Me.calminutos.Text = "0"
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
        'lblCalcularMinutos
        '
        Me.lblCalcularMinutos.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblCalcularMinutos.AutoSize = True
        Me.lblCalcularMinutos.BackColor = System.Drawing.Color.LightGray
        Me.lblCalcularMinutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.lblCalcularMinutos.Location = New System.Drawing.Point(215, 542)
        Me.lblCalcularMinutos.Name = "lblCalcularMinutos"
        Me.lblCalcularMinutos.Size = New System.Drawing.Size(103, 29)
        Me.lblCalcularMinutos.TabIndex = 102
        Me.lblCalcularMinutos.Text = "Minutos:"
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
        'calhoras
        '
        Me.calhoras.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.calhoras.AutoSize = True
        Me.calhoras.BackColor = System.Drawing.Color.LightGray
        Me.calhoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.calhoras.Location = New System.Drawing.Point(328, 489)
        Me.calhoras.Name = "calhoras"
        Me.calhoras.Size = New System.Drawing.Size(26, 29)
        Me.calhoras.TabIndex = 100
        Me.calhoras.Text = "0"
        '
        'lblCalcularHoras
        '
        Me.lblCalcularHoras.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblCalcularHoras.AutoSize = True
        Me.lblCalcularHoras.BackColor = System.Drawing.Color.LightGray
        Me.lblCalcularHoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.lblCalcularHoras.Location = New System.Drawing.Point(226, 489)
        Me.lblCalcularHoras.Name = "lblCalcularHoras"
        Me.lblCalcularHoras.Size = New System.Drawing.Size(83, 29)
        Me.lblCalcularHoras.TabIndex = 101
        Me.lblCalcularHoras.Text = "Horas:"
        '
        'cboEquipo
        '
        Me.cboEquipo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cboEquipo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEquipo.FormattingEnabled = True
        Me.cboEquipo.Location = New System.Drawing.Point(296, 146)
        Me.cboEquipo.Name = "cboEquipo"
        Me.cboEquipo.Size = New System.Drawing.Size(228, 33)
        Me.cboEquipo.TabIndex = 79
        '
        'btnPendiente
        '
        Me.btnPendiente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPendiente.Font = New System.Drawing.Font("Microsoft PhagsPa", 16.2!)
        Me.btnPendiente.Location = New System.Drawing.Point(251, 628)
        Me.btnPendiente.Name = "btnPendiente"
        Me.btnPendiente.Size = New System.Drawing.Size(233, 58)
        Me.btnPendiente.TabIndex = 84
        Me.btnPendiente.Text = "Pendiente"
        Me.btnPendiente.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(58, 510)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(135, 31)
        Me.btnCalcular.TabIndex = 99
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
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
        'Tiempo_Final
        '
        Me.Tiempo_Final.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Tiempo_Final.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Tiempo_Final.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tiempo_Final.Location = New System.Drawing.Point(756, 391)
        Me.Tiempo_Final.Name = "Tiempo_Final"
        Me.Tiempo_Final.Size = New System.Drawing.Size(230, 34)
        Me.Tiempo_Final.TabIndex = 98
        Me.Tiempo_Final.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblEquipo
        '
        Me.lblEquipo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblEquipo.AutoSize = True
        Me.lblEquipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEquipo.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!)
        Me.lblEquipo.Location = New System.Drawing.Point(359, 110)
        Me.lblEquipo.Name = "lblEquipo"
        Me.lblEquipo.Size = New System.Drawing.Size(90, 33)
        Me.lblEquipo.TabIndex = 80
        Me.lblEquipo.Text = "Equipo"
        '
        'btnTiempoFinal
        '
        Me.btnTiempoFinal.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnTiempoFinal.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTiempoFinal.Location = New System.Drawing.Point(574, 394)
        Me.btnTiempoFinal.Name = "btnTiempoFinal"
        Me.btnTiempoFinal.Size = New System.Drawing.Size(138, 31)
        Me.btnTiempoFinal.TabIndex = 97
        Me.btnTiempoFinal.Text = "Tiempo Final"
        Me.btnTiempoFinal.UseVisualStyleBackColor = True
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
        'btnTiempoInicio
        '
        Me.btnTiempoInicio.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnTiempoInicio.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTiempoInicio.Location = New System.Drawing.Point(58, 394)
        Me.btnTiempoInicio.Name = "btnTiempoInicio"
        Me.btnTiempoInicio.Size = New System.Drawing.Size(138, 31)
        Me.btnTiempoInicio.TabIndex = 95
        Me.btnTiempoInicio.Text = "Tiempo Inicio"
        Me.btnTiempoInicio.UseVisualStyleBackColor = True
        '
        'Tiempo_Inicio
        '
        Me.Tiempo_Inicio.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Tiempo_Inicio.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Tiempo_Inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tiempo_Inicio.Location = New System.Drawing.Point(229, 394)
        Me.Tiempo_Inicio.Name = "Tiempo_Inicio"
        Me.Tiempo_Inicio.Size = New System.Drawing.Size(230, 34)
        Me.Tiempo_Inicio.TabIndex = 96
        Me.Tiempo_Inicio.Text = "00:00"
        Me.Tiempo_Inicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.cboResponsable.Location = New System.Drawing.Point(296, 47)
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
        Me.cboClase.Location = New System.Drawing.Point(13, 143)
        Me.cboClase.Name = "cboClase"
        Me.cboClase.Size = New System.Drawing.Size(228, 33)
        Me.cboClase.TabIndex = 76
        '
        'lblClase
        '
        Me.lblClase.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblClase.AutoSize = True
        Me.lblClase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblClase.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!)
        Me.lblClase.Location = New System.Drawing.Point(78, 107)
        Me.lblClase.Name = "lblClase"
        Me.lblClase.Size = New System.Drawing.Size(72, 33)
        Me.lblClase.TabIndex = 78
        Me.lblClase.Text = "Clase"
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
        Me.cboUbicacion.Location = New System.Drawing.Point(13, 252)
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
        Me.cboClasificacion.Location = New System.Drawing.Point(296, 252)
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
        Me.lblClasificacion.Location = New System.Drawing.Point(337, 216)
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
        Me.lblUbicacion.Location = New System.Drawing.Point(55, 216)
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
        Me.lblTitulo.Location = New System.Drawing.Point(73, 11)
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
        Me.txtTitulo.Location = New System.Drawing.Point(12, 47)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(229, 30)
        Me.txtTitulo.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(21, -1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 29)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Label3"
        '
        'Registrar_Nuevo_Caso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1046, 745)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.panelDatos)
        Me.Name = "Registrar_Nuevo_Caso"
        Me.Text = "Registrar_Nuevo_Caso"
        Me.panelDatos.ResumeLayout(False)
        Me.panelDatos.PerformLayout()
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
    Friend WithEvents Label3 As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents cboEquipo As ComboBox
    Friend WithEvents lblEquipo As Label
    Friend WithEvents cboResponsable As ComboBox
    Friend WithEvents cboClase As ComboBox
    Friend WithEvents lblClase As Label
    Friend WithEvents lblResponsable As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
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
End Class

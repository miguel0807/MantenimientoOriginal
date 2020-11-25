<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Presentacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Presentacion))
        Me.panelLogo = New System.Windows.Forms.Panel()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.PanelSideMenu = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.PanelToolsSubmenu = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.PanelToolsSubConfiguration = New System.Windows.Forms.Panel()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.button10 = New System.Windows.Forms.Button()
        Me.button12 = New System.Windows.Forms.Button()
        Me.button13 = New System.Windows.Forms.Button()
        Me.btnTools = New System.Windows.Forms.Button()
        Me.PanelPlaylistSubmenu = New System.Windows.Forms.Panel()
        Me.button7 = New System.Windows.Forms.Button()
        Me.button8 = New System.Windows.Forms.Button()
        Me.btnPlaylist = New System.Windows.Forms.Button()
        Me.PanelMediaSubmenu = New System.Windows.Forms.Panel()
        Me.btnMedia = New System.Windows.Forms.Button()
        Me.PanelChildForm = New System.Windows.Forms.Panel()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.panelLogo.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSideMenu.SuspendLayout()
        Me.PanelToolsSubmenu.SuspendLayout()
        Me.PanelToolsSubConfiguration.SuspendLayout()
        Me.PanelPlaylistSubmenu.SuspendLayout()
        Me.PanelMediaSubmenu.SuspendLayout()
        Me.PanelChildForm.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelLogo
        '
        Me.panelLogo.Controls.Add(Me.pictureBox1)
        Me.panelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelLogo.Location = New System.Drawing.Point(0, 0)
        Me.panelLogo.Name = "panelLogo"
        Me.panelLogo.Size = New System.Drawing.Size(229, 92)
        Me.panelLogo.TabIndex = 0
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(36, 15)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(159, 60)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 0
        Me.pictureBox1.TabStop = False
        '
        'button3
        '
        Me.button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.button3.FlatAppearance.BorderSize = 0
        Me.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button3.ForeColor = System.Drawing.Color.Silver
        Me.button3.Location = New System.Drawing.Point(0, 40)
        Me.button3.Name = "button3"
        Me.button3.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.button3.Size = New System.Drawing.Size(229, 40)
        Me.button3.TabIndex = 1
        Me.button3.Text = "Casos en proceso"
        Me.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.button2.FlatAppearance.BorderSize = 0
        Me.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.ForeColor = System.Drawing.Color.Silver
        Me.button2.Location = New System.Drawing.Point(0, 0)
        Me.button2.Name = "button2"
        Me.button2.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.button2.Size = New System.Drawing.Size(229, 40)
        Me.button2.TabIndex = 0
        Me.button2.Text = "Registrar nuevo caso"
        Me.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button2.UseVisualStyleBackColor = True
        '
        'PanelSideMenu
        '
        Me.PanelSideMenu.AutoScroll = True
        Me.PanelSideMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.PanelSideMenu.Controls.Add(Me.btnExit)
        Me.PanelSideMenu.Controls.Add(Me.btnHelp)
        Me.PanelSideMenu.Controls.Add(Me.PanelToolsSubmenu)
        Me.PanelSideMenu.Controls.Add(Me.btnTools)
        Me.PanelSideMenu.Controls.Add(Me.PanelPlaylistSubmenu)
        Me.PanelSideMenu.Controls.Add(Me.btnPlaylist)
        Me.PanelSideMenu.Controls.Add(Me.PanelMediaSubmenu)
        Me.PanelSideMenu.Controls.Add(Me.btnMedia)
        Me.PanelSideMenu.Controls.Add(Me.panelLogo)
        Me.PanelSideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSideMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelSideMenu.Name = "PanelSideMenu"
        Me.PanelSideMenu.Size = New System.Drawing.Size(250, 753)
        Me.PanelSideMenu.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.Color.Silver
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(0, 997)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnExit.Size = New System.Drawing.Size(229, 39)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Salir"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHelp.FlatAppearance.BorderSize = 0
        Me.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.ForeColor = System.Drawing.Color.Silver
        Me.btnHelp.Image = CType(resources.GetObject("btnHelp.Image"), System.Drawing.Image)
        Me.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHelp.Location = New System.Drawing.Point(0, 952)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnHelp.Size = New System.Drawing.Size(229, 45)
        Me.btnHelp.TabIndex = 8
        Me.btnHelp.Text = "Cerrar Formularios"
        Me.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'PanelToolsSubmenu
        '
        Me.PanelToolsSubmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelToolsSubmenu.Controls.Add(Me.Button1)
        Me.PanelToolsSubmenu.Controls.Add(Me.Button9)
        Me.PanelToolsSubmenu.Controls.Add(Me.PanelToolsSubConfiguration)
        Me.PanelToolsSubmenu.Controls.Add(Me.Button11)
        Me.PanelToolsSubmenu.Controls.Add(Me.Button6)
        Me.PanelToolsSubmenu.Controls.Add(Me.Button4)
        Me.PanelToolsSubmenu.Controls.Add(Me.button10)
        Me.PanelToolsSubmenu.Controls.Add(Me.button12)
        Me.PanelToolsSubmenu.Controls.Add(Me.button13)
        Me.PanelToolsSubmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelToolsSubmenu.Location = New System.Drawing.Point(0, 398)
        Me.PanelToolsSubmenu.Name = "PanelToolsSubmenu"
        Me.PanelToolsSubmenu.Size = New System.Drawing.Size(229, 554)
        Me.PanelToolsSubmenu.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Silver
        Me.Button1.Location = New System.Drawing.Point(0, 472)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(229, 40)
        Me.Button1.TabIndex = 223
        Me.Button1.Text = "Nuevo Provedor"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.ForeColor = System.Drawing.Color.Silver
        Me.Button9.Location = New System.Drawing.Point(0, 432)
        Me.Button9.Name = "Button9"
        Me.Button9.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button9.Size = New System.Drawing.Size(229, 40)
        Me.Button9.TabIndex = 222
        Me.Button9.Text = "Historial Preventivo"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.UseVisualStyleBackColor = True
        '
        'PanelToolsSubConfiguration
        '
        Me.PanelToolsSubConfiguration.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelToolsSubConfiguration.Controls.Add(Me.Button16)
        Me.PanelToolsSubConfiguration.Controls.Add(Me.Button15)
        Me.PanelToolsSubConfiguration.Controls.Add(Me.Button14)
        Me.PanelToolsSubConfiguration.Controls.Add(Me.Button5)
        Me.PanelToolsSubConfiguration.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelToolsSubConfiguration.Location = New System.Drawing.Point(0, 259)
        Me.PanelToolsSubConfiguration.Name = "PanelToolsSubConfiguration"
        Me.PanelToolsSubConfiguration.Size = New System.Drawing.Size(229, 173)
        Me.PanelToolsSubConfiguration.TabIndex = 1
        '
        'Button16
        '
        Me.Button16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button16.FlatAppearance.BorderSize = 0
        Me.Button16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Button16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.ForeColor = System.Drawing.Color.White
        Me.Button16.Location = New System.Drawing.Point(0, 120)
        Me.Button16.Name = "Button16"
        Me.Button16.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button16.Size = New System.Drawing.Size(229, 40)
        Me.Button16.TabIndex = 11
        Me.Button16.Text = "Configuracion"
        Me.Button16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button15.FlatAppearance.BorderSize = 0
        Me.Button15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.ForeColor = System.Drawing.Color.White
        Me.Button15.Location = New System.Drawing.Point(0, 80)
        Me.Button15.Name = "Button15"
        Me.Button15.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button15.Size = New System.Drawing.Size(229, 40)
        Me.Button15.TabIndex = 10
        Me.Button15.Text = "Historial"
        Me.Button15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button14.FlatAppearance.BorderSize = 0
        Me.Button14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.ForeColor = System.Drawing.Color.White
        Me.Button14.Location = New System.Drawing.Point(0, 40)
        Me.Button14.Name = "Button14"
        Me.Button14.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button14.Size = New System.Drawing.Size(229, 40)
        Me.Button14.TabIndex = 9
        Me.Button14.Text = "Shutdown"
        Me.Button14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(0, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button5.Size = New System.Drawing.Size(229, 40)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Startup"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.ForeColor = System.Drawing.Color.Silver
        Me.Button11.Location = New System.Drawing.Point(0, 200)
        Me.Button11.Name = "Button11"
        Me.Button11.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button11.Size = New System.Drawing.Size(229, 59)
        Me.Button11.TabIndex = 221
        Me.Button11.Text = "Shutdown/Startup"
        Me.Button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.Silver
        Me.Button6.Location = New System.Drawing.Point(0, 160)
        Me.Button6.Name = "Button6"
        Me.Button6.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button6.Size = New System.Drawing.Size(229, 40)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Registrar Preventivo"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Silver
        Me.Button4.Location = New System.Drawing.Point(0, 120)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button4.Size = New System.Drawing.Size(229, 40)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Nuevo Equipo"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = True
        '
        'button10
        '
        Me.button10.Dock = System.Windows.Forms.DockStyle.Top
        Me.button10.FlatAppearance.BorderSize = 0
        Me.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button10.ForeColor = System.Drawing.Color.Silver
        Me.button10.Location = New System.Drawing.Point(0, 80)
        Me.button10.Name = "button10"
        Me.button10.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.button10.Size = New System.Drawing.Size(229, 40)
        Me.button10.TabIndex = 2
        Me.button10.Text = "Nueva clase"
        Me.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button10.UseVisualStyleBackColor = True
        '
        'button12
        '
        Me.button12.Dock = System.Windows.Forms.DockStyle.Top
        Me.button12.FlatAppearance.BorderSize = 0
        Me.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button12.ForeColor = System.Drawing.Color.Silver
        Me.button12.Location = New System.Drawing.Point(0, 40)
        Me.button12.Name = "button12"
        Me.button12.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.button12.Size = New System.Drawing.Size(229, 40)
        Me.button12.TabIndex = 1
        Me.button12.Text = "Planificacion Preventivos"
        Me.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button12.UseVisualStyleBackColor = True
        '
        'button13
        '
        Me.button13.Dock = System.Windows.Forms.DockStyle.Top
        Me.button13.FlatAppearance.BorderSize = 0
        Me.button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button13.ForeColor = System.Drawing.Color.Silver
        Me.button13.Location = New System.Drawing.Point(0, 0)
        Me.button13.Name = "button13"
        Me.button13.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.button13.Size = New System.Drawing.Size(229, 40)
        Me.button13.TabIndex = 0
        Me.button13.Text = "Lista de equipos"
        Me.button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button13.UseVisualStyleBackColor = True
        '
        'btnTools
        '
        Me.btnTools.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTools.FlatAppearance.BorderSize = 0
        Me.btnTools.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnTools.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTools.ForeColor = System.Drawing.Color.Silver
        Me.btnTools.Image = CType(resources.GetObject("btnTools.Image"), System.Drawing.Image)
        Me.btnTools.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTools.Location = New System.Drawing.Point(0, 353)
        Me.btnTools.Name = "btnTools"
        Me.btnTools.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnTools.Size = New System.Drawing.Size(229, 45)
        Me.btnTools.TabIndex = 6
        Me.btnTools.Text = "Mantenimiento Preventivo"
        Me.btnTools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTools.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTools.UseVisualStyleBackColor = True
        '
        'PanelPlaylistSubmenu
        '
        Me.PanelPlaylistSubmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelPlaylistSubmenu.Controls.Add(Me.button7)
        Me.PanelPlaylistSubmenu.Controls.Add(Me.button8)
        Me.PanelPlaylistSubmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelPlaylistSubmenu.Location = New System.Drawing.Point(0, 272)
        Me.PanelPlaylistSubmenu.Name = "PanelPlaylistSubmenu"
        Me.PanelPlaylistSubmenu.Size = New System.Drawing.Size(229, 81)
        Me.PanelPlaylistSubmenu.TabIndex = 4
        '
        'button7
        '
        Me.button7.Dock = System.Windows.Forms.DockStyle.Top
        Me.button7.FlatAppearance.BorderSize = 0
        Me.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button7.ForeColor = System.Drawing.Color.Silver
        Me.button7.Location = New System.Drawing.Point(0, 40)
        Me.button7.Name = "button7"
        Me.button7.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.button7.Size = New System.Drawing.Size(229, 40)
        Me.button7.TabIndex = 1
        Me.button7.Text = "Busqueda de materiales"
        Me.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button7.UseVisualStyleBackColor = True
        '
        'button8
        '
        Me.button8.Dock = System.Windows.Forms.DockStyle.Top
        Me.button8.FlatAppearance.BorderSize = 0
        Me.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button8.ForeColor = System.Drawing.Color.Silver
        Me.button8.Location = New System.Drawing.Point(0, 0)
        Me.button8.Name = "button8"
        Me.button8.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.button8.Size = New System.Drawing.Size(229, 40)
        Me.button8.TabIndex = 0
        Me.button8.Text = "Nuevo Material"
        Me.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button8.UseVisualStyleBackColor = True
        '
        'btnPlaylist
        '
        Me.btnPlaylist.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPlaylist.FlatAppearance.BorderSize = 0
        Me.btnPlaylist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnPlaylist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlaylist.ForeColor = System.Drawing.Color.Silver
        Me.btnPlaylist.Image = CType(resources.GetObject("btnPlaylist.Image"), System.Drawing.Image)
        Me.btnPlaylist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPlaylist.Location = New System.Drawing.Point(0, 227)
        Me.btnPlaylist.Name = "btnPlaylist"
        Me.btnPlaylist.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnPlaylist.Size = New System.Drawing.Size(229, 45)
        Me.btnPlaylist.TabIndex = 3
        Me.btnPlaylist.Text = "  Control de inventario"
        Me.btnPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPlaylist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPlaylist.UseVisualStyleBackColor = True
        '
        'PanelMediaSubmenu
        '
        Me.PanelMediaSubmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelMediaSubmenu.Controls.Add(Me.button3)
        Me.PanelMediaSubmenu.Controls.Add(Me.button2)
        Me.PanelMediaSubmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMediaSubmenu.Location = New System.Drawing.Point(0, 137)
        Me.PanelMediaSubmenu.Name = "PanelMediaSubmenu"
        Me.PanelMediaSubmenu.Size = New System.Drawing.Size(229, 90)
        Me.PanelMediaSubmenu.TabIndex = 2
        '
        'btnMedia
        '
        Me.btnMedia.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMedia.FlatAppearance.BorderSize = 0
        Me.btnMedia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnMedia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMedia.ForeColor = System.Drawing.Color.Silver
        Me.btnMedia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMedia.Location = New System.Drawing.Point(0, 92)
        Me.btnMedia.Name = "btnMedia"
        Me.btnMedia.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnMedia.Size = New System.Drawing.Size(229, 45)
        Me.btnMedia.TabIndex = 1
        Me.btnMedia.Text = "Indicadores"
        Me.btnMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMedia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMedia.UseVisualStyleBackColor = True
        '
        'PanelChildForm
        '
        Me.PanelChildForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.PanelChildForm.Controls.Add(Me.PictureBox9)
        Me.PanelChildForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelChildForm.Location = New System.Drawing.Point(250, 0)
        Me.PanelChildForm.Name = "PanelChildForm"
        Me.PanelChildForm.Size = New System.Drawing.Size(932, 753)
        Me.PanelChildForm.TabIndex = 2
        '
        'PictureBox9
        '
        Me.PictureBox9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(223, 247)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(512, 310)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox9.TabIndex = 0
        Me.PictureBox9.TabStop = False
        '
        'Presentacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1182, 753)
        Me.Controls.Add(Me.PanelChildForm)
        Me.Controls.Add(Me.PanelSideMenu)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1200, 800)
        Me.Name = "Presentacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.panelLogo.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSideMenu.ResumeLayout(False)
        Me.PanelToolsSubmenu.ResumeLayout(False)
        Me.PanelToolsSubConfiguration.ResumeLayout(False)
        Me.PanelPlaylistSubmenu.ResumeLayout(False)
        Me.PanelMediaSubmenu.ResumeLayout(False)
        Me.PanelChildForm.ResumeLayout(False)
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panelLogo As Panel
    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents PanelSideMenu As Panel
    Private WithEvents PanelToolsSubmenu As Panel
    Private WithEvents button10 As Button
    Private WithEvents button12 As Button
    Private WithEvents button13 As Button
    Private WithEvents btnTools As Button
    Private WithEvents PanelPlaylistSubmenu As Panel
    Private WithEvents button7 As Button
    Private WithEvents button8 As Button
    Private WithEvents btnPlaylist As Button
    Private WithEvents PanelMediaSubmenu As Panel
    Private WithEvents btnMedia As Button
    Friend WithEvents PanelChildForm As Panel
    Private WithEvents pictureBox1 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Private WithEvents Button6 As Button
    Private WithEvents Button4 As Button
    Private WithEvents Button5 As Button
    Private WithEvents Button11 As Button
    Friend WithEvents PanelToolsSubConfiguration As Panel
    Private WithEvents Button1 As Button
    Private WithEvents Button9 As Button
    Private WithEvents Button16 As Button
    Private WithEvents Button15 As Button
    Private WithEvents Button14 As Button
    Private WithEvents btnExit As Button
    Private WithEvents btnHelp As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_Material
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
        Me.Equipo = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Empresa = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Parte = New System.Windows.Forms.TextBox()
        Me.Serie = New System.Windows.Forms.ComboBox()
        Me.Modelo = New System.Windows.Forms.ComboBox()
        Me.Marca = New System.Windows.Forms.ComboBox()
        Me.Clasificacion = New System.Windows.Forms.ComboBox()
        Me.Ubicacion = New System.Windows.Forms.ComboBox()
        Me.Unidad = New System.Windows.Forms.ComboBox()
        Me.Codigo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Descripcion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Material = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.RadioButton11 = New System.Windows.Forms.RadioButton()
        Me.RadioButton12 = New System.Windows.Forms.RadioButton()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Equipo
        '
        Me.Equipo.BackColor = System.Drawing.SystemColors.Control
        Me.Equipo.Enabled = False
        Me.Equipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Equipo.FormattingEnabled = True
        Me.Equipo.Items.AddRange(New Object() {"Llenadora Cartuchos Wilsonville", "Llenadora Cartuchos DD", "Llenadora litros", "LLenadora Pails", "LLenadora limpiadores", "Agitadores pequeños", "Agitadores medianos", "Agitadores grandes", "Bomba de diafragma 1/2", "Bomba de diafragma 3/4", "Bomba de diafragma 1""", "Tank Farm"})
        Me.Equipo.Location = New System.Drawing.Point(148, 448)
        Me.Equipo.Name = "Equipo"
        Me.Equipo.Size = New System.Drawing.Size(331, 37)
        Me.Equipo.TabIndex = 67
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Label12.Location = New System.Drawing.Point(32, 448)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 29)
        Me.Label12.TabIndex = 88
        Me.Label12.Text = "Equipo"
        '
        'Empresa
        '
        Me.Empresa.BackColor = System.Drawing.SystemColors.Control
        Me.Empresa.Enabled = False
        Me.Empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Empresa.FormattingEnabled = True
        Me.Empresa.Items.AddRange(New Object() {"McMaster", "Amazon", "Industrial Solution", "Ebay", "N/A"})
        Me.Empresa.Location = New System.Drawing.Point(148, 344)
        Me.Empresa.Name = "Empresa"
        Me.Empresa.Size = New System.Drawing.Size(331, 37)
        Me.Empresa.TabIndex = 65
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Label10.Location = New System.Drawing.Point(32, 398)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 29)
        Me.Label10.TabIndex = 87
        Me.Label10.Text = "#Parte"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Label11.Location = New System.Drawing.Point(32, 344)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 29)
        Me.Label11.TabIndex = 86
        Me.Label11.Text = "Empresa"
        '
        'Parte
        '
        Me.Parte.BackColor = System.Drawing.SystemColors.Control
        Me.Parte.Enabled = False
        Me.Parte.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Parte.Location = New System.Drawing.Point(148, 398)
        Me.Parte.Name = "Parte"
        Me.Parte.Size = New System.Drawing.Size(331, 34)
        Me.Parte.TabIndex = 66
        '
        'Serie
        '
        Me.Serie.BackColor = System.Drawing.SystemColors.Control
        Me.Serie.Enabled = False
        Me.Serie.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Serie.FormattingEnabled = True
        Me.Serie.Items.AddRange(New Object() {"N/A"})
        Me.Serie.Location = New System.Drawing.Point(741, 299)
        Me.Serie.Name = "Serie"
        Me.Serie.Size = New System.Drawing.Size(283, 37)
        Me.Serie.TabIndex = 70
        '
        'Modelo
        '
        Me.Modelo.BackColor = System.Drawing.SystemColors.Control
        Me.Modelo.Enabled = False
        Me.Modelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Modelo.FormattingEnabled = True
        Me.Modelo.Items.AddRange(New Object() {"N/A"})
        Me.Modelo.Location = New System.Drawing.Point(741, 235)
        Me.Modelo.Name = "Modelo"
        Me.Modelo.Size = New System.Drawing.Size(283, 37)
        Me.Modelo.TabIndex = 69
        '
        'Marca
        '
        Me.Marca.BackColor = System.Drawing.SystemColors.Control
        Me.Marca.Enabled = False
        Me.Marca.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Marca.FormattingEnabled = True
        Me.Marca.Items.AddRange(New Object() {"FORCE", "N/A"})
        Me.Marca.Location = New System.Drawing.Point(741, 177)
        Me.Marca.Name = "Marca"
        Me.Marca.Size = New System.Drawing.Size(283, 37)
        Me.Marca.TabIndex = 68
        '
        'Clasificacion
        '
        Me.Clasificacion.BackColor = System.Drawing.SystemColors.Control
        Me.Clasificacion.Enabled = False
        Me.Clasificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Clasificacion.FormattingEnabled = True
        Me.Clasificacion.Items.AddRange(New Object() {"Electrico", "Mecanico", "Neumatico", "Hidraulico", "Electronico", "Otros"})
        Me.Clasificacion.Location = New System.Drawing.Point(741, 434)
        Me.Clasificacion.Name = "Clasificacion"
        Me.Clasificacion.Size = New System.Drawing.Size(283, 37)
        Me.Clasificacion.TabIndex = 72
        '
        'Ubicacion
        '
        Me.Ubicacion.BackColor = System.Drawing.SystemColors.Control
        Me.Ubicacion.Enabled = False
        Me.Ubicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Ubicacion.FormattingEnabled = True
        Me.Ubicacion.Location = New System.Drawing.Point(741, 365)
        Me.Ubicacion.Name = "Ubicacion"
        Me.Ubicacion.Size = New System.Drawing.Size(283, 37)
        Me.Ubicacion.TabIndex = 71
        '
        'Unidad
        '
        Me.Unidad.BackColor = System.Drawing.SystemColors.Control
        Me.Unidad.Enabled = False
        Me.Unidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Unidad.FormattingEnabled = True
        Me.Unidad.Items.AddRange(New Object() {"Metros", "Unidad", "Bolsas()", "N/A"})
        Me.Unidad.Location = New System.Drawing.Point(149, 293)
        Me.Unidad.Name = "Unidad"
        Me.Unidad.Size = New System.Drawing.Size(331, 37)
        Me.Unidad.TabIndex = 64
        '
        'Codigo
        '
        Me.Codigo.BackColor = System.Drawing.SystemColors.Control
        Me.Codigo.Enabled = False
        Me.Codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Codigo.Location = New System.Drawing.Point(12, 700)
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Size = New System.Drawing.Size(145, 34)
        Me.Codigo.TabIndex = 85
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Label9.Location = New System.Drawing.Point(575, 437)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(149, 29)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "Clasificacion"
        '
        'Descripcion
        '
        Me.Descripcion.BackColor = System.Drawing.SystemColors.Control
        Me.Descripcion.Enabled = False
        Me.Descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descripcion.Location = New System.Drawing.Point(291, 521)
        Me.Descripcion.Multiline = True
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(519, 197)
        Me.Descripcion.TabIndex = 73
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Label6.Location = New System.Drawing.Point(144, 521)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 29)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "Descripcion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Label5.Location = New System.Drawing.Point(575, 368)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 29)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Ubicacion"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Label7.Location = New System.Drawing.Point(575, 302)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 29)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "Serie"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Label8.Location = New System.Drawing.Point(575, 243)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 29)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "Modelo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Label3.Location = New System.Drawing.Point(32, 301)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 29)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Unidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Label4.Location = New System.Drawing.Point(575, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 29)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Marca"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Label2.Location = New System.Drawing.Point(32, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 29)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Cantidad"
        '
        'Cantidad
        '
        Me.Cantidad.BackColor = System.Drawing.SystemColors.Control
        Me.Cantidad.Enabled = False
        Me.Cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cantidad.Location = New System.Drawing.Point(149, 243)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(331, 34)
        Me.Cantidad.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Label1.Location = New System.Drawing.Point(32, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 29)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Material"
        '
        'Material
        '
        Me.Material.BackColor = System.Drawing.SystemColors.Control
        Me.Material.Enabled = False
        Me.Material.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Material.Location = New System.Drawing.Point(149, 193)
        Me.Material.Name = "Material"
        Me.Material.Size = New System.Drawing.Size(331, 34)
        Me.Material.TabIndex = 62
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(495, 198)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(17, 16)
        Me.RadioButton1.TabIndex = 89
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(495, 253)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(17, 16)
        Me.RadioButton2.TabIndex = 90
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(495, 306)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(17, 16)
        Me.RadioButton3.TabIndex = 91
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(495, 357)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(17, 16)
        Me.RadioButton4.TabIndex = 92
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(495, 408)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(17, 16)
        Me.RadioButton5.TabIndex = 93
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(495, 458)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(17, 16)
        Me.RadioButton6.TabIndex = 94
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(1043, 447)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(17, 16)
        Me.RadioButton7.TabIndex = 100
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Location = New System.Drawing.Point(1043, 378)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(17, 16)
        Me.RadioButton8.TabIndex = 99
        Me.RadioButton8.TabStop = True
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.Location = New System.Drawing.Point(1043, 311)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(17, 16)
        Me.RadioButton9.TabIndex = 98
        Me.RadioButton9.TabStop = True
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'RadioButton11
        '
        Me.RadioButton11.AutoSize = True
        Me.RadioButton11.Location = New System.Drawing.Point(1043, 246)
        Me.RadioButton11.Name = "RadioButton11"
        Me.RadioButton11.Size = New System.Drawing.Size(17, 16)
        Me.RadioButton11.TabIndex = 96
        Me.RadioButton11.TabStop = True
        Me.RadioButton11.UseVisualStyleBackColor = True
        '
        'RadioButton12
        '
        Me.RadioButton12.AutoSize = True
        Me.RadioButton12.Location = New System.Drawing.Point(1043, 185)
        Me.RadioButton12.Name = "RadioButton12"
        Me.RadioButton12.Size = New System.Drawing.Size(17, 16)
        Me.RadioButton12.TabIndex = 95
        Me.RadioButton12.TabStop = True
        Me.RadioButton12.UseVisualStyleBackColor = True
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.Location = New System.Drawing.Point(816, 531)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(17, 16)
        Me.RadioButton10.TabIndex = 101
        Me.RadioButton10.TabStop = True
        Me.RadioButton10.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button1.FlatAppearance.BorderSize = 3
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!)
        Me.Button1.Location = New System.Drawing.Point(468, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(186, 84)
        Me.Button1.TabIndex = 102
        Me.Button1.Text = "Ajustar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Modificar_Material
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1136, 736)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RadioButton10)
        Me.Controls.Add(Me.RadioButton7)
        Me.Controls.Add(Me.RadioButton8)
        Me.Controls.Add(Me.RadioButton9)
        Me.Controls.Add(Me.RadioButton11)
        Me.Controls.Add(Me.RadioButton12)
        Me.Controls.Add(Me.RadioButton6)
        Me.Controls.Add(Me.RadioButton5)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Equipo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Empresa)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Parte)
        Me.Controls.Add(Me.Serie)
        Me.Controls.Add(Me.Modelo)
        Me.Controls.Add(Me.Marca)
        Me.Controls.Add(Me.Clasificacion)
        Me.Controls.Add(Me.Ubicacion)
        Me.Controls.Add(Me.Unidad)
        Me.Controls.Add(Me.Codigo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Descripcion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Cantidad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Material)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Modificar_Material"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Equipo As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Empresa As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Parte As TextBox
    Friend WithEvents Serie As ComboBox
    Friend WithEvents Modelo As ComboBox
    Friend WithEvents Marca As ComboBox
    Friend WithEvents Clasificacion As ComboBox
    Friend WithEvents Ubicacion As ComboBox
    Friend WithEvents Unidad As ComboBox
    Friend WithEvents Codigo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Descripcion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Cantidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Material As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents RadioButton11 As RadioButton
    Friend WithEvents RadioButton12 As RadioButton
    Friend WithEvents RadioButton10 As RadioButton
    Friend WithEvents Button1 As Button
End Class

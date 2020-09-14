<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Indicadores_Editable
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Ubicacion = New System.Windows.Forms.ComboBox()
        Me.Clasificacion = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Nombre = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.fecha_final = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Fecha = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Descripcion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.panel_boton = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.acuminutos = New System.Windows.Forms.TextBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.acuhora = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.calminutos = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.calhoras = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Tiempo_Final = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Tiempo_Inicio = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.panel_boton.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft PhagsPa", 16.2!)
        Me.Button3.Location = New System.Drawing.Point(367, 525)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(223, 78)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Finalizado"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(12, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1001, 262)
        Me.Panel1.TabIndex = 84
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Ubicacion)
        Me.Panel4.Controls.Add(Me.Clasificacion)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Nombre)
        Me.Panel4.Location = New System.Drawing.Point(10, 15)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(441, 213)
        Me.Panel4.TabIndex = 1
        '
        'Ubicacion
        '
        Me.Ubicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ubicacion.FormattingEnabled = True
        Me.Ubicacion.Items.AddRange(New Object() {"Cartuchos Wilsonville", "Cartuchos DD", "Produccion Master batch", "Produccion Empaque", "Contacto", "Oficinas", "CR7"})
        Me.Ubicacion.Location = New System.Drawing.Point(188, 82)
        Me.Ubicacion.Name = "Ubicacion"
        Me.Ubicacion.Size = New System.Drawing.Size(228, 33)
        Me.Ubicacion.TabIndex = 2
        '
        'Clasificacion
        '
        Me.Clasificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clasificacion.FormattingEnabled = True
        Me.Clasificacion.Items.AddRange(New Object() {"Electrico", "Mecanico", "Neumatico", "Servicio", ""})
        Me.Clasificacion.Location = New System.Drawing.Point(187, 148)
        Me.Clasificacion.Name = "Clasificacion"
        Me.Clasificacion.Size = New System.Drawing.Size(228, 33)
        Me.Clasificacion.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!)
        Me.Label9.Location = New System.Drawing.Point(11, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(145, 31)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "Clasificacion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!)
        Me.Label5.Location = New System.Drawing.Point(11, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 31)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Ubicacion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!)
        Me.Label1.Location = New System.Drawing.Point(11, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 31)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Problema"
        '
        'Nombre
        '
        Me.Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre.Location = New System.Drawing.Point(188, 12)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(229, 30)
        Me.Nombre.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.fecha_final)
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Location = New System.Drawing.Point(578, 150)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(416, 79)
        Me.Panel3.TabIndex = 3
        '
        'fecha_final
        '
        Me.fecha_final.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_final.Location = New System.Drawing.Point(162, 18)
        Me.fecha_final.Name = "fecha_final"
        Me.fecha_final.Size = New System.Drawing.Size(230, 34)
        Me.fecha_final.TabIndex = 2
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!)
        Me.Button4.Location = New System.Drawing.Point(12, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(91, 64)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "Fecha Final"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.Fecha)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(578, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(416, 79)
        Me.Panel2.TabIndex = 2
        '
        'Fecha
        '
        Me.Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Location = New System.Drawing.Point(162, 28)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(230, 34)
        Me.Fecha.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!)
        Me.Button1.Location = New System.Drawing.Point(12, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 64)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Fecha Inicio"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Descripcion
        '
        Me.Descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descripcion.Location = New System.Drawing.Point(180, 321)
        Me.Descripcion.Multiline = True
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(564, 156)
        Me.Descripcion.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!)
        Me.Label6.Location = New System.Drawing.Point(33, 324)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 31)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Descripcion"
        '
        'panel_boton
        '
        Me.panel_boton.Controls.Add(Me.Panel5)
        Me.panel_boton.Controls.Add(Me.calminutos)
        Me.panel_boton.Controls.Add(Me.Label13)
        Me.panel_boton.Controls.Add(Me.Label14)
        Me.panel_boton.Controls.Add(Me.calhoras)
        Me.panel_boton.Controls.Add(Me.Button8)
        Me.panel_boton.Controls.Add(Me.Tiempo_Final)
        Me.panel_boton.Controls.Add(Me.Button7)
        Me.panel_boton.Controls.Add(Me.Tiempo_Inicio)
        Me.panel_boton.Controls.Add(Me.Button6)
        Me.panel_boton.Location = New System.Drawing.Point(11, 27)
        Me.panel_boton.Name = "panel_boton"
        Me.panel_boton.Size = New System.Drawing.Size(1010, 579)
        Me.panel_boton.TabIndex = 87
        Me.panel_boton.Visible = False
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.acuminutos)
        Me.Panel5.Controls.Add(Me.Button9)
        Me.Panel5.Controls.Add(Me.acuhora)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Location = New System.Drawing.Point(522, 37)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(469, 280)
        Me.Panel5.TabIndex = 94
        '
        'acuminutos
        '
        Me.acuminutos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.acuminutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acuminutos.Location = New System.Drawing.Point(342, 197)
        Me.acuminutos.Name = "acuminutos"
        Me.acuminutos.Size = New System.Drawing.Size(45, 34)
        Me.acuminutos.TabIndex = 96
        Me.acuminutos.Text = "0"
        Me.acuminutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(29, 104)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(145, 67)
        Me.Button9.TabIndex = 93
        Me.Button9.Text = "Agregar tiempo"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'acuhora
        '
        Me.acuhora.BackColor = System.Drawing.Color.WhiteSmoke
        Me.acuhora.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acuhora.Location = New System.Drawing.Point(342, 136)
        Me.acuhora.Name = "acuhora"
        Me.acuhora.Size = New System.Drawing.Size(45, 34)
        Me.acuhora.TabIndex = 95
        Me.acuhora.Text = "0"
        Me.acuhora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.LightGray
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Label10.Location = New System.Drawing.Point(226, 197)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 29)
        Me.Label10.TabIndex = 87
        Me.Label10.Text = "Minutos:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.LightGray
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Label8.Location = New System.Drawing.Point(226, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 29)
        Me.Label8.TabIndex = 86
        Me.Label8.Text = "Horas:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.LightGray
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Label7.Location = New System.Drawing.Point(211, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(229, 29)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Tiempo Acumulado:"
        '
        'calminutos
        '
        Me.calminutos.AutoSize = True
        Me.calminutos.BackColor = System.Drawing.Color.LightGray
        Me.calminutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.calminutos.Location = New System.Drawing.Point(339, 433)
        Me.calminutos.Name = "calminutos"
        Me.calminutos.Size = New System.Drawing.Size(26, 29)
        Me.calminutos.TabIndex = 92
        Me.calminutos.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.LightGray
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Label13.Location = New System.Drawing.Point(219, 433)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 29)
        Me.Label13.TabIndex = 91
        Me.Label13.Text = "Minutos:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.LightGray
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Label14.Location = New System.Drawing.Point(219, 367)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 29)
        Me.Label14.TabIndex = 90
        Me.Label14.Text = "Horas:"
        '
        'calhoras
        '
        Me.calhoras.AutoSize = True
        Me.calhoras.BackColor = System.Drawing.Color.LightGray
        Me.calhoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.calhoras.Location = New System.Drawing.Point(339, 367)
        Me.calhoras.Name = "calhoras"
        Me.calhoras.Size = New System.Drawing.Size(26, 29)
        Me.calhoras.TabIndex = 89
        Me.calhoras.Text = "0"
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(26, 384)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(145, 67)
        Me.Button8.TabIndex = 83
        Me.Button8.Text = "Calcular"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Tiempo_Final
        '
        Me.Tiempo_Final.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Tiempo_Final.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tiempo_Final.Location = New System.Drawing.Point(208, 208)
        Me.Tiempo_Final.Name = "Tiempo_Final"
        Me.Tiempo_Final.Size = New System.Drawing.Size(230, 34)
        Me.Tiempo_Final.TabIndex = 6
        Me.Tiempo_Final.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(13, 191)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(145, 67)
        Me.Button7.TabIndex = 5
        Me.Button7.Text = "Tiempo Final"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Tiempo_Inicio
        '
        Me.Tiempo_Inicio.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Tiempo_Inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tiempo_Inicio.Location = New System.Drawing.Point(208, 45)
        Me.Tiempo_Inicio.Name = "Tiempo_Inicio"
        Me.Tiempo_Inicio.Size = New System.Drawing.Size(230, 34)
        Me.Tiempo_Inicio.TabIndex = 4
        Me.Tiempo_Inicio.Text = "00:00"
        Me.Tiempo_Inicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(13, 28)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(145, 67)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "Tiempo Inicio"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(11, -1)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(167, 29)
        Me.Button5.TabIndex = 88
        Me.Button5.Text = "Control de tiempo"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Indicadores_Editable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BackgroundImage = Global.Mantenimiento.My.Resources.Resources.gris
        Me.ClientSize = New System.Drawing.Size(1051, 646)
        Me.Controls.Add(Me.panel_boton)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Descripcion)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(1069, 693)
        Me.Name = "Indicadores_Editable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.panel_boton.ResumeLayout(False)
        Me.panel_boton.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents fecha_final As TextBox
    Friend WithEvents Ubicacion As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Clasificacion As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Fecha As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Nombre As TextBox
    Friend WithEvents Descripcion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents panel_boton As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents acuminutos As TextBox
    Friend WithEvents Button9 As Button
    Friend WithEvents acuhora As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents calminutos As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents calhoras As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Tiempo_Final As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Tiempo_Inicio As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
End Class

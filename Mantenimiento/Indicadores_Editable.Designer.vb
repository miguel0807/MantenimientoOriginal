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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.fecha_final = New System.Windows.Forms.TextBox()
        Me.Ubicacion = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Clasificacion = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Fecha = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Nombre = New System.Windows.Forms.TextBox()
        Me.Descripcion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft PhagsPa", 16.2!)
        Me.Button3.Location = New System.Drawing.Point(367, 525)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(223, 78)
        Me.Button3.TabIndex = 88
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
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.fecha_final)
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Location = New System.Drawing.Point(578, 150)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(416, 79)
        Me.Panel3.TabIndex = 101
        '
        'fecha_final
        '
        Me.fecha_final.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_final.Location = New System.Drawing.Point(162, 18)
        Me.fecha_final.Name = "fecha_final"
        Me.fecha_final.Size = New System.Drawing.Size(230, 34)
        Me.fecha_final.TabIndex = 99
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
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!)
        Me.Button4.Location = New System.Drawing.Point(12, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(91, 64)
        Me.Button4.TabIndex = 100
        Me.Button4.Text = "Fecha Final"
        Me.Button4.UseVisualStyleBackColor = True
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
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.Fecha)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(578, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(416, 79)
        Me.Panel2.TabIndex = 76
        '
        'Fecha
        '
        Me.Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Location = New System.Drawing.Point(162, 28)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(230, 34)
        Me.Fecha.TabIndex = 99
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!)
        Me.Button1.Location = New System.Drawing.Point(12, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 64)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Fecha Inicio"
        Me.Button1.UseVisualStyleBackColor = True
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
        'Descripcion
        '
        Me.Descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descripcion.Location = New System.Drawing.Point(180, 321)
        Me.Descripcion.Multiline = True
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(564, 156)
        Me.Descripcion.TabIndex = 85
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!)
        Me.Label6.Location = New System.Drawing.Point(33, 324)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 31)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Descripcion"
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
        Me.Panel4.TabIndex = 102
        '
        'Indicadores_Editable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BackgroundImage = Global.Mantenimiento.My.Resources.Resources.gris
        Me.ClientSize = New System.Drawing.Size(1051, 646)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Descripcion)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(1069, 693)
        Me.Name = "Indicadores_Editable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
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
End Class

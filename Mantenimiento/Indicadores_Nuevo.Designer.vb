<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Indicadores_Nuevo
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Descripcion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Fecha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Nombre = New System.Windows.Forms.TextBox()
        Me.Borrar = New System.Windows.Forms.Button()
        Me.Ingresar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Ubicacion = New System.Windows.Forms.ComboBox()
        Me.Clasificacion = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Label9.Location = New System.Drawing.Point(21, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(149, 29)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "Clasificacion"
        '
        'Descripcion
        '
        Me.Descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descripcion.Location = New System.Drawing.Point(180, 339)
        Me.Descripcion.Multiline = True
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(564, 156)
        Me.Descripcion.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Label6.Location = New System.Drawing.Point(33, 342)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 29)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Descripcion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Label5.Location = New System.Drawing.Point(21, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 29)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Ubicacion"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Label8.Location = New System.Drawing.Point(3, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 59)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Fecha Inicio"
        '
        'Fecha
        '
        Me.Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Location = New System.Drawing.Point(100, 13)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(230, 34)
        Me.Fecha.TabIndex = 99
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Label1.Location = New System.Drawing.Point(21, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 29)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Problema"
        '
        'Nombre
        '
        Me.Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre.Location = New System.Drawing.Point(198, 27)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(192, 34)
        Me.Nombre.TabIndex = 1
        '
        'Borrar
        '
        Me.Borrar.Location = New System.Drawing.Point(429, -80)
        Me.Borrar.Name = "Borrar"
        Me.Borrar.Size = New System.Drawing.Size(190, 58)
        Me.Borrar.TabIndex = 65
        Me.Borrar.Text = "Borrar"
        Me.Borrar.UseVisualStyleBackColor = True
        '
        'Ingresar
        '
        Me.Ingresar.Location = New System.Drawing.Point(121, -80)
        Me.Ingresar.Name = "Ingresar"
        Me.Ingresar.Size = New System.Drawing.Size(190, 58)
        Me.Ingresar.TabIndex = 64
        Me.Ingresar.Text = "Ingresar"
        Me.Ingresar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Ubicacion)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Clasificacion)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Nombre)
        Me.Panel1.Location = New System.Drawing.Point(12, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(978, 247)
        Me.Panel1.TabIndex = 0
        '
        'Ubicacion
        '
        Me.Ubicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ubicacion.FormattingEnabled = True
        Me.Ubicacion.Location = New System.Drawing.Point(198, 97)
        Me.Ubicacion.Name = "Ubicacion"
        Me.Ubicacion.Size = New System.Drawing.Size(191, 37)
        Me.Ubicacion.TabIndex = 2
        '
        'Clasificacion
        '
        Me.Clasificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clasificacion.FormattingEnabled = True
        Me.Clasificacion.Location = New System.Drawing.Point(197, 163)
        Me.Clasificacion.Name = "Clasificacion"
        Me.Clasificacion.Size = New System.Drawing.Size(191, 37)
        Me.Clasificacion.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Fecha)
        Me.Panel2.Location = New System.Drawing.Point(578, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(356, 64)
        Me.Panel2.TabIndex = 76
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(460, 49)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 64)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Automatico"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(29, 534)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(223, 78)
        Me.Button2.TabIndex = 77
        Me.Button2.Text = "Pendiente"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(330, 534)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(223, 78)
        Me.Button3.TabIndex = 78
        Me.Button3.Text = "Finalizado"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Location = New System.Drawing.Point(578, 152)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(356, 64)
        Me.Panel3.TabIndex = 101
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Label2.Location = New System.Drawing.Point(3, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 61)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Fecha Final"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(100, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(230, 34)
        Me.TextBox1.TabIndex = 99
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(460, 152)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(91, 64)
        Me.Button4.TabIndex = 100
        Me.Button4.Text = "Automatico"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Indicadores_Nuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 648)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Descripcion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Borrar)
        Me.Controls.Add(Me.Ingresar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Indicadores_Nuevo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents Descripcion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Fecha As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Nombre As TextBox
    Friend WithEvents Borrar As Button
    Friend WithEvents Ingresar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Clasificacion As ComboBox
    Friend WithEvents Ubicacion As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button4 As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Equipo_Preventivo
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
        Me.Crear = New System.Windows.Forms.Button()
        Me.Clase = New System.Windows.Forms.ComboBox()
        Me.Ubicacion = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Etiqueta = New System.Windows.Forms.TextBox()
        Me.Placa = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Clave = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Crear
        '
        Me.Crear.Location = New System.Drawing.Point(576, 253)
        Me.Crear.Name = "Crear"
        Me.Crear.Size = New System.Drawing.Size(131, 54)
        Me.Crear.TabIndex = 6
        Me.Crear.Text = "Crear"
        Me.Crear.UseVisualStyleBackColor = True
        '
        'Clase
        '
        Me.Clase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Clase.FormattingEnabled = True
        Me.Clase.Location = New System.Drawing.Point(227, 29)
        Me.Clase.Name = "Clase"
        Me.Clase.Size = New System.Drawing.Size(200, 24)
        Me.Clase.TabIndex = 0
        '
        'Ubicacion
        '
        Me.Ubicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Ubicacion.FormattingEnabled = True
        Me.Ubicacion.Location = New System.Drawing.Point(227, 290)
        Me.Ubicacion.Name = "Ubicacion"
        Me.Ubicacion.Size = New System.Drawing.Size(200, 24)
        Me.Ubicacion.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(93, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Clase"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(93, 290)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Ubicacion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(93, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Placa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Etiqueta"
        '
        'Etiqueta
        '
        Me.Etiqueta.Location = New System.Drawing.Point(273, 96)
        Me.Etiqueta.Name = "Etiqueta"
        Me.Etiqueta.Size = New System.Drawing.Size(40, 22)
        Me.Etiqueta.TabIndex = 2
        Me.Etiqueta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Placa
        '
        Me.Placa.Enabled = False
        Me.Placa.Location = New System.Drawing.Point(227, 185)
        Me.Placa.Name = "Placa"
        Me.Placa.Size = New System.Drawing.Size(200, 22)
        Me.Placa.TabIndex = 3
        Me.Placa.Text = "N/A"
        Me.Placa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(446, 187)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(18, 17)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Clave
        '
        Me.Clave.AutoSize = True
        Me.Clave.Location = New System.Drawing.Point(224, 99)
        Me.Clave.Name = "Clave"
        Me.Clave.Size = New System.Drawing.Size(43, 17)
        Me.Clave.TabIndex = 24
        Me.Clave.Text = "Clave"
        '
        'Equipo_Preventivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Clave)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Placa)
        Me.Controls.Add(Me.Crear)
        Me.Controls.Add(Me.Clase)
        Me.Controls.Add(Me.Ubicacion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Etiqueta)
        Me.Name = "Equipo_Preventivo"
        Me.Text = "Equipo_Preventivo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Crear As Button
    Friend WithEvents Clase As ComboBox
    Friend WithEvents Ubicacion As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Etiqueta As TextBox
    Friend WithEvents Placa As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Clave As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NuevaClase_Preventivo
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
        Me.Clase = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Frecuencia = New System.Windows.Forms.ComboBox()
        Me.Clasificacion = New System.Windows.Forms.ComboBox()
        Me.Provedor = New System.Windows.Forms.ComboBox()
        Me.Crear = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Clave = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Clase
        '
        Me.Clase.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clase.Location = New System.Drawing.Point(182, 81)
        Me.Clase.Name = "Clase"
        Me.Clase.Size = New System.Drawing.Size(200, 27)
        Me.Clase.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Clase"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Frecuencia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 286)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Clasificacion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 360)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Provedor"
        '
        'Frecuencia
        '
        Me.Frecuencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Frecuencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frecuencia.FormattingEnabled = True
        Me.Frecuencia.Location = New System.Drawing.Point(182, 221)
        Me.Frecuencia.Name = "Frecuencia"
        Me.Frecuencia.Size = New System.Drawing.Size(200, 28)
        Me.Frecuencia.TabIndex = 3
        '
        'Clasificacion
        '
        Me.Clasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Clasificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clasificacion.FormattingEnabled = True
        Me.Clasificacion.Location = New System.Drawing.Point(182, 286)
        Me.Clasificacion.Name = "Clasificacion"
        Me.Clasificacion.Size = New System.Drawing.Size(200, 28)
        Me.Clasificacion.TabIndex = 4
        '
        'Provedor
        '
        Me.Provedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Provedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Provedor.FormattingEnabled = True
        Me.Provedor.Location = New System.Drawing.Point(182, 360)
        Me.Provedor.Name = "Provedor"
        Me.Provedor.Size = New System.Drawing.Size(200, 28)
        Me.Provedor.TabIndex = 5
        '
        'Crear
        '
        Me.Crear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Crear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Crear.Location = New System.Drawing.Point(508, 199)
        Me.Crear.Name = "Crear"
        Me.Crear.Size = New System.Drawing.Size(190, 111)
        Me.Crear.TabIndex = 6
        Me.Crear.Text = "Crear"
        Me.Crear.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Label5.Location = New System.Drawing.Point(11, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 29)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Codigo"
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 24)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Clave"
        '
        'Clave
        '
        Me.Clave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clave.Location = New System.Drawing.Point(182, 148)
        Me.Clave.Name = "Clave"
        Me.Clave.Size = New System.Drawing.Size(200, 27)
        Me.Clave.TabIndex = 2
        '
        'NuevaClase_Preventivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Clave)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Crear)
        Me.Controls.Add(Me.Provedor)
        Me.Controls.Add(Me.Clasificacion)
        Me.Controls.Add(Me.Frecuencia)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Clase)
        Me.Name = "NuevaClase_Preventivo"
        Me.Text = "Clase_Preventivo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Clase As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Frecuencia As ComboBox
    Friend WithEvents Clasificacion As ComboBox
    Friend WithEvents Provedor As ComboBox
    Friend WithEvents Crear As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Clave As TextBox
End Class

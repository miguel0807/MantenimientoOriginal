<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejecucion_Preventivo
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Clave = New System.Windows.Forms.TextBox()
        Me.Crear = New System.Windows.Forms.Button()
        Me.Provedor = New System.Windows.Forms.ComboBox()
        Me.Clasificacion = New System.Windows.Forms.ComboBox()
        Me.Frecuencia = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Clase = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(93, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 17)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Clave"
        '
        'Clave
        '
        Me.Clave.Location = New System.Drawing.Point(227, 116)
        Me.Clave.Name = "Clave"
        Me.Clave.Size = New System.Drawing.Size(200, 22)
        Me.Clave.TabIndex = 24
        '
        'Crear
        '
        Me.Crear.Location = New System.Drawing.Point(576, 236)
        Me.Crear.Name = "Crear"
        Me.Crear.Size = New System.Drawing.Size(131, 54)
        Me.Crear.TabIndex = 23
        Me.Crear.Text = "Crear"
        Me.Crear.UseVisualStyleBackColor = True
        '
        'Provedor
        '
        Me.Provedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Provedor.FormattingEnabled = True
        Me.Provedor.Location = New System.Drawing.Point(227, 361)
        Me.Provedor.Name = "Provedor"
        Me.Provedor.Size = New System.Drawing.Size(200, 24)
        Me.Provedor.TabIndex = 22
        '
        'Clasificacion
        '
        Me.Clasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Clasificacion.FormattingEnabled = True
        Me.Clasificacion.Location = New System.Drawing.Point(227, 273)
        Me.Clasificacion.Name = "Clasificacion"
        Me.Clasificacion.Size = New System.Drawing.Size(200, 24)
        Me.Clasificacion.TabIndex = 21
        '
        'Frecuencia
        '
        Me.Frecuencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Frecuencia.FormattingEnabled = True
        Me.Frecuencia.Location = New System.Drawing.Point(227, 168)
        Me.Frecuencia.Name = "Frecuencia"
        Me.Frecuencia.Size = New System.Drawing.Size(200, 24)
        Me.Frecuencia.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(93, 364)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 17)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Provedor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(93, 273)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Clasificacion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(93, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Frecuencia"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Clase"
        '
        'Clase
        '
        Me.Clase.Location = New System.Drawing.Point(227, 66)
        Me.Clase.Name = "Clase"
        Me.Clase.Size = New System.Drawing.Size(200, 22)
        Me.Clase.TabIndex = 15
        '
        'Ejecucion_Preventivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Clave)
        Me.Controls.Add(Me.Crear)
        Me.Controls.Add(Me.Provedor)
        Me.Controls.Add(Me.Clasificacion)
        Me.Controls.Add(Me.Frecuencia)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Clase)
        Me.Name = "Ejecucion_Preventivo"
        Me.Text = "Ejecucion_Preventivo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Clave As TextBox
    Friend WithEvents Crear As Button
    Friend WithEvents Provedor As ComboBox
    Friend WithEvents Clasificacion As ComboBox
    Friend WithEvents Frecuencia As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Clase As TextBox
End Class

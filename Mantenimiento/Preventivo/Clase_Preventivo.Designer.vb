<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Clase_Preventivo
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
        Me.SuspendLayout()
        '
        'Clase
        '
        Me.Clase.Location = New System.Drawing.Point(159, 44)
        Me.Clase.Name = "Clase"
        Me.Clase.Size = New System.Drawing.Size(200, 22)
        Me.Clase.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Clase"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Frecuencia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Clasificacion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 342)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Provedor"
        '
        'Frecuencia
        '
        Me.Frecuencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Frecuencia.FormattingEnabled = True
        Me.Frecuencia.Location = New System.Drawing.Point(159, 146)
        Me.Frecuencia.Name = "Frecuencia"
        Me.Frecuencia.Size = New System.Drawing.Size(200, 24)
        Me.Frecuencia.TabIndex = 8
        '
        'Clasificacion
        '
        Me.Clasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Clasificacion.FormattingEnabled = True
        Me.Clasificacion.Location = New System.Drawing.Point(159, 251)
        Me.Clasificacion.Name = "Clasificacion"
        Me.Clasificacion.Size = New System.Drawing.Size(200, 24)
        Me.Clasificacion.TabIndex = 9
        '
        'Provedor
        '
        Me.Provedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Provedor.FormattingEnabled = True
        Me.Provedor.Location = New System.Drawing.Point(159, 339)
        Me.Provedor.Name = "Provedor"
        Me.Provedor.Size = New System.Drawing.Size(200, 24)
        Me.Provedor.TabIndex = 10
        '
        'Crear
        '
        Me.Crear.Location = New System.Drawing.Point(508, 214)
        Me.Crear.Name = "Crear"
        Me.Crear.Size = New System.Drawing.Size(131, 54)
        Me.Crear.TabIndex = 11
        Me.Crear.Text = "Crear"
        Me.Crear.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Codigo"
        '
        'Clase_Preventivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
        Me.Name = "Clase_Preventivo"
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
End Class

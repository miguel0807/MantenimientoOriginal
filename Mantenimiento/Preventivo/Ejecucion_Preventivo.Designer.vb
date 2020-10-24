<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ejecucion_Preventivo
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Finalizado = New System.Windows.Forms.Button()
        Me.Responsable = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Etiqueta = New System.Windows.Forms.ComboBox()
        Me.Clase = New System.Windows.Forms.ComboBox()
        Me.Fecha = New System.Windows.Forms.MonthCalendar()
        Me.Comentarios = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 17)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Etiqueta"
        '
        'Finalizado
        '
        Me.Finalizado.Location = New System.Drawing.Point(534, 275)
        Me.Finalizado.Name = "Finalizado"
        Me.Finalizado.Size = New System.Drawing.Size(173, 88)
        Me.Finalizado.TabIndex = 5
        Me.Finalizado.Text = "Finalizado"
        Me.Finalizado.UseVisualStyleBackColor = True
        '
        'Responsable
        '
        Me.Responsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Responsable.FormattingEnabled = True
        Me.Responsable.Location = New System.Drawing.Point(146, 125)
        Me.Responsable.Name = "Responsable"
        Me.Responsable.Size = New System.Drawing.Size(200, 24)
        Me.Responsable.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(483, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 17)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Comentarios"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Responsable"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Clase"
        '
        'Etiqueta
        '
        Me.Etiqueta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Etiqueta.FormattingEnabled = True
        Me.Etiqueta.Location = New System.Drawing.Point(146, 73)
        Me.Etiqueta.Name = "Etiqueta"
        Me.Etiqueta.Size = New System.Drawing.Size(200, 24)
        Me.Etiqueta.TabIndex = 1
        '
        'Clase
        '
        Me.Clase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Clase.FormattingEnabled = True
        Me.Clase.Location = New System.Drawing.Point(146, 20)
        Me.Clase.Name = "Clase"
        Me.Clase.Size = New System.Drawing.Size(200, 24)
        Me.Clase.TabIndex = 0
        '
        'Fecha
        '
        Me.Fecha.Location = New System.Drawing.Point(146, 193)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.TabIndex = 3
        '
        'Comentarios
        '
        Me.Comentarios.Location = New System.Drawing.Point(486, 42)
        Me.Comentarios.Multiline = True
        Me.Comentarios.Name = "Comentarios"
        Me.Comentarios.Size = New System.Drawing.Size(300, 166)
        Me.Comentarios.TabIndex = 4
        '
        'Ejecucion_Preventivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Comentarios)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.Clase)
        Me.Controls.Add(Me.Etiqueta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Finalizado)
        Me.Controls.Add(Me.Responsable)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Ejecucion_Preventivo"
        Me.Text = "Ejecucion_Preventivo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Finalizado As Button
    Friend WithEvents Responsable As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Etiqueta As ComboBox
    Friend WithEvents Clase As ComboBox
    Friend WithEvents Fecha As MonthCalendar
    Friend WithEvents Comentarios As TextBox
End Class

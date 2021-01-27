<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro_Preventivo
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
        Me.Comentarios = New System.Windows.Forms.TextBox()
        Me.Fecha = New System.Windows.Forms.MonthCalendar()
        Me.Clase = New System.Windows.Forms.ComboBox()
        Me.Etiqueta = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Finalizado = New System.Windows.Forms.Button()
        Me.Responsable = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Tarea = New System.Windows.Forms.DataGridView()
        CType(Me.Tarea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Comentarios
        '
        Me.Comentarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comentarios.Location = New System.Drawing.Point(476, 47)
        Me.Comentarios.Multiline = True
        Me.Comentarios.Name = "Comentarios"
        Me.Comentarios.Size = New System.Drawing.Size(300, 166)
        Me.Comentarios.TabIndex = 30
        Me.Comentarios.Text = "N/A"
        '
        'Fecha
        '
        Me.Fecha.Location = New System.Drawing.Point(98, 32)
        Me.Fecha.MaxSelectionCount = 1
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ShowTodayCircle = False
        Me.Fecha.TabIndex = 29
        '
        'Clase
        '
        Me.Clase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Clase.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clase.FormattingEnabled = True
        Me.Clase.Location = New System.Drawing.Point(216, 318)
        Me.Clase.Name = "Clase"
        Me.Clase.Size = New System.Drawing.Size(200, 30)
        Me.Clase.TabIndex = 26
        '
        'Etiqueta
        '
        Me.Etiqueta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Etiqueta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta.FormattingEnabled = True
        Me.Etiqueta.Location = New System.Drawing.Point(216, 369)
        Me.Etiqueta.Name = "Etiqueta"
        Me.Etiqueta.Size = New System.Drawing.Size(200, 30)
        Me.Etiqueta.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 371)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 26)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Etiqueta"
        '
        'Finalizado
        '
        Me.Finalizado.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Finalizado.Location = New System.Drawing.Point(685, 452)
        Me.Finalizado.Name = "Finalizado"
        Me.Finalizado.Size = New System.Drawing.Size(173, 88)
        Me.Finalizado.TabIndex = 31
        Me.Finalizado.Text = "Finalizado y Salir"
        Me.Finalizado.UseVisualStyleBackColor = True
        '
        'Responsable
        '
        Me.Responsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Responsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Responsable.FormattingEnabled = True
        Me.Responsable.Location = New System.Drawing.Point(685, 315)
        Me.Responsable.Name = "Responsable"
        Me.Responsable.Size = New System.Drawing.Size(200, 30)
        Me.Responsable.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(528, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 26)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Comentarios"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 26)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(501, 313)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 26)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Responsable"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 313)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 26)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Clase"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(685, 580)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 88)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Finalizado y Continuar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 431)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 26)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Tareas"
        '
        'Tarea
        '
        Me.Tarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tarea.Location = New System.Drawing.Point(216, 431)
        Me.Tarea.Name = "Tarea"
        Me.Tarea.RowHeadersWidth = 51
        Me.Tarea.RowTemplate.Height = 24
        Me.Tarea.Size = New System.Drawing.Size(405, 237)
        Me.Tarea.TabIndex = 40
        '
        'Registro_Preventivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(922, 680)
        Me.Controls.Add(Me.Tarea)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
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
        Me.Name = "Registro_Preventivo"
        Me.Text = "Registro_Preventivo"
        CType(Me.Tarea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Comentarios As TextBox
    Friend WithEvents Fecha As MonthCalendar
    Friend WithEvents Clase As ComboBox
    Friend WithEvents Etiqueta As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Finalizado As Button
    Friend WithEvents Responsable As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Tarea As DataGridView
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistroPreventivo
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
        Me.Cantidad = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FinalizadoContinuar = New System.Windows.Forms.Button()
        Me.Comentarios = New System.Windows.Forms.TextBox()
        Me.Fecha = New System.Windows.Forms.MonthCalendar()
        Me.Clase = New System.Windows.Forms.ComboBox()
        Me.Etiqueta = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FinalizadoSalir = New System.Windows.Forms.Button()
        Me.Responsable = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cantidad
        '
        Me.Cantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Cantidad.AutoSize = True
        Me.Cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cantidad.Location = New System.Drawing.Point(12, 730)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(106, 25)
        Me.Cantidad.TabIndex = 65
        Me.Cantidad.Text = "Cantidad:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 401)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(825, 326)
        Me.DataGridView1.TabIndex = 66
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 372)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 26)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Tareas"
        '
        'FinalizadoContinuar
        '
        Me.FinalizadoContinuar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.FinalizadoContinuar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinalizadoContinuar.Location = New System.Drawing.Point(843, 501)
        Me.FinalizadoContinuar.Name = "FinalizadoContinuar"
        Me.FinalizadoContinuar.Size = New System.Drawing.Size(173, 88)
        Me.FinalizadoContinuar.TabIndex = 63
        Me.FinalizadoContinuar.Text = "Finalizado y Continuar"
        Me.FinalizadoContinuar.UseVisualStyleBackColor = True
        Me.FinalizadoContinuar.Visible = False
        '
        'Comentarios
        '
        Me.Comentarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Comentarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comentarios.Location = New System.Drawing.Point(481, 27)
        Me.Comentarios.Multiline = True
        Me.Comentarios.Name = "Comentarios"
        Me.Comentarios.Size = New System.Drawing.Size(356, 154)
        Me.Comentarios.TabIndex = 56
        Me.Comentarios.Text = "N/A"
        '
        'Fecha
        '
        Me.Fecha.Location = New System.Drawing.Point(69, 27)
        Me.Fecha.MaxSelectionCount = 1
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ShowTodayCircle = False
        Me.Fecha.TabIndex = 55
        '
        'Clase
        '
        Me.Clase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Clase.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clase.FormattingEnabled = True
        Me.Clase.Location = New System.Drawing.Point(144, 269)
        Me.Clase.Name = "Clase"
        Me.Clase.Size = New System.Drawing.Size(200, 30)
        Me.Clase.TabIndex = 52
        '
        'Etiqueta
        '
        Me.Etiqueta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Etiqueta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta.FormattingEnabled = True
        Me.Etiqueta.Location = New System.Drawing.Point(144, 320)
        Me.Etiqueta.Name = "Etiqueta"
        Me.Etiqueta.Size = New System.Drawing.Size(200, 30)
        Me.Etiqueta.TabIndex = 53
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 327)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 26)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Etiqueta"
        '
        'FinalizadoSalir
        '
        Me.FinalizadoSalir.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.FinalizadoSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinalizadoSalir.Location = New System.Drawing.Point(843, 401)
        Me.FinalizadoSalir.Name = "FinalizadoSalir"
        Me.FinalizadoSalir.Size = New System.Drawing.Size(173, 88)
        Me.FinalizadoSalir.TabIndex = 57
        Me.FinalizadoSalir.Text = "Finalizado y Salir"
        Me.FinalizadoSalir.UseVisualStyleBackColor = True
        Me.FinalizadoSalir.Visible = False
        '
        'Responsable
        '
        Me.Responsable.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Responsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Responsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Responsable.FormattingEnabled = True
        Me.Responsable.Location = New System.Drawing.Point(638, 263)
        Me.Responsable.Name = "Responsable"
        Me.Responsable.Size = New System.Drawing.Size(200, 30)
        Me.Responsable.TabIndex = 54
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(476, -2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 26)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Comentarios"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, -2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 26)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(477, 263)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 26)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Responsable"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 269)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 26)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Clase"
        '
        'RegistroPreventivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1040, 755)
        Me.Controls.Add(Me.Cantidad)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.FinalizadoContinuar)
        Me.Controls.Add(Me.Comentarios)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.Clase)
        Me.Controls.Add(Me.Etiqueta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.FinalizadoSalir)
        Me.Controls.Add(Me.Responsable)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RegistroPreventivo"
        Me.Text = "RegistroPreventivo"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cantidad As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents FinalizadoContinuar As Button
    Friend WithEvents Comentarios As TextBox
    Friend WithEvents Fecha As MonthCalendar
    Friend WithEvents Clase As ComboBox
    Friend WithEvents Etiqueta As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents FinalizadoSalir As Button
    Friend WithEvents Responsable As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class

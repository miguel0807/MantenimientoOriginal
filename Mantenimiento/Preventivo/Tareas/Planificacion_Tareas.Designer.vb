<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Planificacion_Tareas
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtClase = New System.Windows.Forms.ComboBox()
        Me.txtEtiqueta = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAño = New System.Windows.Forms.ComboBox()
        Me.txtMeses = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Crear = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.EliminarTareasbtn = New System.Windows.Forms.Button()
        Me.Tareas = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.EquipoActivo = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ClaseActivo = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PanelActivo = New System.Windows.Forms.Panel()
        Me.MesActivo = New System.Windows.Forms.Label()
        Me.AñoActivo = New System.Windows.Forms.Label()
        Me.ModoClase = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelActivo.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(24, 59)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(983, 295)
        Me.DataGridView1.TabIndex = 49
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 357)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 25)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Cantidad:"
        '
        'txtClase
        '
        Me.txtClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtClase.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClase.FormattingEnabled = True
        Me.txtClase.Location = New System.Drawing.Point(199, 29)
        Me.txtClase.Name = "txtClase"
        Me.txtClase.Size = New System.Drawing.Size(200, 30)
        Me.txtClase.TabIndex = 51
        '
        'txtEtiqueta
        '
        Me.txtEtiqueta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtEtiqueta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEtiqueta.FormattingEnabled = True
        Me.txtEtiqueta.Location = New System.Drawing.Point(199, 80)
        Me.txtEtiqueta.Name = "txtEtiqueta"
        Me.txtEtiqueta.Size = New System.Drawing.Size(200, 30)
        Me.txtEtiqueta.TabIndex = 52
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(55, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 26)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Etiqueta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 26)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Clase"
        '
        'txtAño
        '
        Me.txtAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAño.FormattingEnabled = True
        Me.txtAño.Location = New System.Drawing.Point(586, 33)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(200, 30)
        Me.txtAño.TabIndex = 55
        '
        'txtMeses
        '
        Me.txtMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtMeses.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMeses.FormattingEnabled = True
        Me.txtMeses.Location = New System.Drawing.Point(586, 78)
        Me.txtMeses.Name = "txtMeses"
        Me.txtMeses.Size = New System.Drawing.Size(200, 30)
        Me.txtMeses.TabIndex = 56
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(480, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 26)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Mes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(482, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 26)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Año"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(24, 59)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(983, 295)
        Me.DataGridView2.TabIndex = 59
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 357)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 25)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Cantidad:"
        '
        'Crear
        '
        Me.Crear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Crear.Location = New System.Drawing.Point(856, 357)
        Me.Crear.Name = "Crear"
        Me.Crear.Size = New System.Drawing.Size(151, 65)
        Me.Crear.TabIndex = 32
        Me.Crear.Text = "Agregar Tarea"
        Me.Crear.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(860, 37)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(151, 65)
        Me.Button2.TabIndex = 64
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl1.Location = New System.Drawing.Point(0, 259)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1136, 489)
        Me.TabControl1.TabIndex = 65
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.EliminarTareasbtn)
        Me.TabPage1.Controls.Add(Me.Tareas)
        Me.TabPage1.Controls.Add(Me.Crear)
        Me.TabPage1.Controls.Add(Me.DataGridView2)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1128, 460)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "Lista de tareas"
        '
        'EliminarTareasbtn
        '
        Me.EliminarTareasbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EliminarTareasbtn.Location = New System.Drawing.Point(548, 369)
        Me.EliminarTareasbtn.Name = "EliminarTareasbtn"
        Me.EliminarTareasbtn.Size = New System.Drawing.Size(211, 72)
        Me.EliminarTareasbtn.TabIndex = 62
        Me.EliminarTareasbtn.Text = "Eliminar todas las tareas"
        Me.EliminarTareasbtn.UseVisualStyleBackColor = True
        Me.EliminarTareasbtn.Visible = False
        '
        'Tareas
        '
        Me.Tareas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tareas.Location = New System.Drawing.Point(331, 369)
        Me.Tareas.Name = "Tareas"
        Me.Tareas.Size = New System.Drawing.Size(211, 72)
        Me.Tareas.TabIndex = 61
        Me.Tareas.Text = "Agregar todas las tareas"
        Me.Tareas.UseVisualStyleBackColor = True
        Me.Tareas.Visible = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1128, 460)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Tareas activas"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(856, 357)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 65)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "Eliminar Tarea"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.DataGridView3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1128, 460)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Tareas Realizadas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 358)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 25)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Cantidad:"
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AllowUserToResizeRows = False
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(24, 59)
        Me.DataGridView3.MultiSelect = False
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.RowTemplate.Height = 24
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView3.Size = New System.Drawing.Size(983, 295)
        Me.DataGridView3.TabIndex = 64
        '
        'EquipoActivo
        '
        Me.EquipoActivo.AutoSize = True
        Me.EquipoActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EquipoActivo.Location = New System.Drawing.Point(3, 39)
        Me.EquipoActivo.Name = "EquipoActivo"
        Me.EquipoActivo.Size = New System.Drawing.Size(100, 26)
        Me.EquipoActivo.TabIndex = 66
        Me.EquipoActivo.Text = "Etiqueta"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(405, 87)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(18, 17)
        Me.CheckBox1.TabIndex = 67
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ClaseActivo
        '
        Me.ClaseActivo.AutoSize = True
        Me.ClaseActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClaseActivo.Location = New System.Drawing.Point(3, 13)
        Me.ClaseActivo.Name = "ClaseActivo"
        Me.ClaseActivo.Size = New System.Drawing.Size(73, 26)
        Me.ClaseActivo.TabIndex = 68
        Me.ClaseActivo.Text = "Clase"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(405, 162)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(131, 36)
        Me.Button4.TabIndex = 62
        Me.Button4.Text = "Activo"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PanelActivo
        '
        Me.PanelActivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelActivo.Controls.Add(Me.MesActivo)
        Me.PanelActivo.Controls.Add(Me.AñoActivo)
        Me.PanelActivo.Controls.Add(Me.EquipoActivo)
        Me.PanelActivo.Controls.Add(Me.ClaseActivo)
        Me.PanelActivo.Location = New System.Drawing.Point(552, 149)
        Me.PanelActivo.Name = "PanelActivo"
        Me.PanelActivo.Size = New System.Drawing.Size(490, 104)
        Me.PanelActivo.TabIndex = 69
        Me.PanelActivo.Visible = False
        '
        'MesActivo
        '
        Me.MesActivo.AutoSize = True
        Me.MesActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MesActivo.Location = New System.Drawing.Point(302, 45)
        Me.MesActivo.Name = "MesActivo"
        Me.MesActivo.Size = New System.Drawing.Size(56, 26)
        Me.MesActivo.TabIndex = 69
        Me.MesActivo.Text = "Mes"
        '
        'AñoActivo
        '
        Me.AñoActivo.AutoSize = True
        Me.AñoActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AñoActivo.Location = New System.Drawing.Point(302, 13)
        Me.AñoActivo.Name = "AñoActivo"
        Me.AñoActivo.Size = New System.Drawing.Size(54, 26)
        Me.AñoActivo.TabIndex = 70
        Me.AñoActivo.Text = "Año"
        '
        'ModoClase
        '
        Me.ModoClase.AutoSize = True
        Me.ModoClase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ModoClase.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModoClase.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ModoClase.Location = New System.Drawing.Point(4, 222)
        Me.ModoClase.Name = "ModoClase"
        Me.ModoClase.Size = New System.Drawing.Size(328, 40)
        Me.ModoClase.TabIndex = 71
        Me.ModoClase.Text = "Modo Clase Activado"
        Me.ModoClase.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(146, 391)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(106, 49)
        Me.Button3.TabIndex = 63
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Planificacion_Tareas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1136, 748)
        Me.Controls.Add(Me.ModoClase)
        Me.Controls.Add(Me.PanelActivo)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtAño)
        Me.Controls.Add(Me.txtMeses)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtClase)
        Me.Controls.Add(Me.txtEtiqueta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Planificacion_Tareas"
        Me.Text = "s"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelActivo.ResumeLayout(False)
        Me.PanelActivo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents txtClase As ComboBox
    Friend WithEvents txtEtiqueta As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAño As ComboBox
    Friend WithEvents txtMeses As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Crear As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents EquipoActivo As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Tareas As Button
    Friend WithEvents ClaseActivo As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents PanelActivo As Panel
    Friend WithEvents MesActivo As Label
    Friend WithEvents AñoActivo As Label
    Friend WithEvents ModoClase As Label
    Friend WithEvents EliminarTareasbtn As Button
    Friend WithEvents Button3 As Button
End Class

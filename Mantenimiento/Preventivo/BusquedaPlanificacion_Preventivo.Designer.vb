<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BusquedaPlanificacion_Preventivo
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.mes = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.año = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tipobusqueda = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.detalle_equipo = New System.Windows.Forms.ComboBox()
        Me.clase = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonShadow
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SlateGray
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(60, 194)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1316, 467)
        Me.DataGridView1.TabIndex = 110
        '
        'mes
        '
        Me.mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.mes.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.mes.FormattingEnabled = True
        Me.mes.Location = New System.Drawing.Point(875, 12)
        Me.mes.Name = "mes"
        Me.mes.Size = New System.Drawing.Size(229, 37)
        Me.mes.TabIndex = 109
        Me.mes.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button2.FlatAppearance.BorderSize = 3
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!)
        Me.Button2.Location = New System.Drawing.Point(341, 87)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(186, 84)
        Me.Button2.TabIndex = 108
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'año
        '
        Me.año.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.año.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.año.FormattingEnabled = True
        Me.año.Location = New System.Drawing.Point(12, 134)
        Me.año.Name = "año"
        Me.año.Size = New System.Drawing.Size(229, 37)
        Me.año.TabIndex = 107
        Me.año.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Label10.Location = New System.Drawing.Point(31, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(210, 29)
        Me.Label10.TabIndex = 106
        Me.Label10.Text = "Tipo de busqueda"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!)
        Me.Label1.Location = New System.Drawing.Point(94, 685)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 33)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'tipobusqueda
        '
        Me.tipobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tipobusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.tipobusqueda.FormattingEnabled = True
        Me.tipobusqueda.Items.AddRange(New Object() {"General"})
        Me.tipobusqueda.Location = New System.Drawing.Point(12, 91)
        Me.tipobusqueda.Name = "tipobusqueda"
        Me.tipobusqueda.Size = New System.Drawing.Size(229, 37)
        Me.tipobusqueda.TabIndex = 114
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button4.FlatAppearance.BorderSize = 3
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!)
        Me.Button4.Location = New System.Drawing.Point(1245, 125)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(131, 63)
        Me.Button4.TabIndex = 116
        Me.Button4.Text = "Eliminar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Label2.Location = New System.Drawing.Point(679, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 29)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Agregar equipo"
        Me.Label2.Visible = False
        '
        'detalle_equipo
        '
        Me.detalle_equipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.detalle_equipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.detalle_equipo.FormattingEnabled = True
        Me.detalle_equipo.Location = New System.Drawing.Point(671, 123)
        Me.detalle_equipo.Name = "detalle_equipo"
        Me.detalle_equipo.Size = New System.Drawing.Size(229, 37)
        Me.detalle_equipo.TabIndex = 112
        Me.detalle_equipo.Visible = False
        '
        'clase
        '
        Me.clase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.clase.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.clase.FormattingEnabled = True
        Me.clase.Location = New System.Drawing.Point(671, 65)
        Me.clase.Name = "clase"
        Me.clase.Size = New System.Drawing.Size(229, 37)
        Me.clase.TabIndex = 113
        Me.clase.Visible = False
        '
        'BusquedaPlanificacion_Preventivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1437, 793)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.tipobusqueda)
        Me.Controls.Add(Me.clase)
        Me.Controls.Add(Me.detalle_equipo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.mes)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.año)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BusquedaPlanificacion_Preventivo"
        Me.Text = "Planificacion_Preventivo"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents mes As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents año As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tipobusqueda As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents detalle_equipo As ComboBox
    Friend WithEvents clase As ComboBox
End Class

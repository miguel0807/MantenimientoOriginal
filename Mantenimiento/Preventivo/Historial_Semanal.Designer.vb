<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Historial_Semanal
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tipobusqueda = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.equipos = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Clase = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tipobusqueda
        '
        Me.tipobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tipobusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.tipobusqueda.FormattingEnabled = True
        Me.tipobusqueda.Items.AddRange(New Object() {"Mostrar Año", "Mostrar Mes"})
        Me.tipobusqueda.Location = New System.Drawing.Point(25, 96)
        Me.tipobusqueda.Name = "tipobusqueda"
        Me.tipobusqueda.Size = New System.Drawing.Size(229, 37)
        Me.tipobusqueda.TabIndex = 134
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(25, 198)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1316, 467)
        Me.DataGridView1.TabIndex = 133
        '
        'equipos
        '
        Me.equipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.equipos.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.equipos.FormattingEnabled = True
        Me.equipos.Location = New System.Drawing.Point(280, 128)
        Me.equipos.Name = "equipos"
        Me.equipos.Size = New System.Drawing.Size(229, 37)
        Me.equipos.TabIndex = 132
        Me.equipos.Visible = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button2.FlatAppearance.BorderSize = 3
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!)
        Me.Button2.Location = New System.Drawing.Point(647, 671)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(186, 84)
        Me.Button2.TabIndex = 131
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Clase
        '
        Me.Clase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Clase.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Clase.FormattingEnabled = True
        Me.Clase.Location = New System.Drawing.Point(25, 139)
        Me.Clase.Name = "Clase"
        Me.Clase.Size = New System.Drawing.Size(229, 37)
        Me.Clase.TabIndex = 130
        Me.Clase.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Label10.Location = New System.Drawing.Point(34, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(210, 29)
        Me.Label10.TabIndex = 129
        Me.Label10.Text = "Tipo de busqueda"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!)
        Me.Label1.Location = New System.Drawing.Point(59, 689)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 33)
        Me.Label1.TabIndex = 128
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'Historial_Semanal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1437, 793)
        Me.Controls.Add(Me.tipobusqueda)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.equipos)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Clase)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Historial_Semanal"
        Me.Text = "Historial_Semanal"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tipobusqueda As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents equipos As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Clase As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
End Class

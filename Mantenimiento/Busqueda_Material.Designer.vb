<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Busqueda_Material
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.busqueda = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Tipo = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button2.FlatAppearance.BorderSize = 3
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!)
        Me.Button2.Location = New System.Drawing.Point(350, 670)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(186, 84)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Actualizar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!)
        Me.Label1.Location = New System.Drawing.Point(58, 670)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 33)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button1.FlatAppearance.BorderSize = 3
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!)
        Me.Button1.Location = New System.Drawing.Point(551, 670)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(186, 84)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Editar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonShadow
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(32, 174)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1370, 490)
        Me.DataGridView1.TabIndex = 7
        '
        'busqueda
        '
        Me.busqueda.BackColor = System.Drawing.SystemColors.Control
        Me.busqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.busqueda.Location = New System.Drawing.Point(296, 79)
        Me.busqueda.Name = "busqueda"
        Me.busqueda.Size = New System.Drawing.Size(323, 34)
        Me.busqueda.TabIndex = 80
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Label11.Location = New System.Drawing.Point(389, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(122, 29)
        Me.Label11.TabIndex = 83
        Me.Label11.Text = "Busqueda"
        '
        'Tipo
        '
        Me.Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Tipo.FormattingEnabled = True
        Me.Tipo.Items.AddRange(New Object() {"Material", "Codigo", "Equipo"})
        Me.Tipo.Location = New System.Drawing.Point(24, 79)
        Me.Tipo.Name = "Tipo"
        Me.Tipo.Size = New System.Drawing.Size(229, 37)
        Me.Tipo.TabIndex = 82
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Label10.Location = New System.Drawing.Point(27, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(210, 29)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = "Tipo de busqueda"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(783, 58)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(190, 58)
        Me.Button4.TabIndex = 78
        Me.Button4.Text = "Buscar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Busqueda_Material
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1437, 793)
        Me.Controls.Add(Me.busqueda)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Tipo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "Busqueda_Material"
        Me.Text = "Busqueda_Material"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents busqueda As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Tipo As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button4 As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notas
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
        Me.Texto = New System.Windows.Forms.TextBox()
        Me.DtgPrincipal = New System.Windows.Forms.DataGridView()
        Me.Agregar = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Responsable = New System.Windows.Forms.ComboBox()
        CType(Me.DtgPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Texto
        '
        Me.Texto.Location = New System.Drawing.Point(22, 49)
        Me.Texto.Name = "Texto"
        Me.Texto.Size = New System.Drawing.Size(728, 22)
        Me.Texto.TabIndex = 0
        '
        'DtgPrincipal
        '
        Me.DtgPrincipal.AllowUserToAddRows = False
        Me.DtgPrincipal.AllowUserToDeleteRows = False
        Me.DtgPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtgPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DtgPrincipal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DtgPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgPrincipal.Location = New System.Drawing.Point(22, 100)
        Me.DtgPrincipal.MultiSelect = False
        Me.DtgPrincipal.Name = "DtgPrincipal"
        Me.DtgPrincipal.ReadOnly = True
        Me.DtgPrincipal.RowHeadersWidth = 51
        Me.DtgPrincipal.RowTemplate.Height = 24
        Me.DtgPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtgPrincipal.Size = New System.Drawing.Size(1038, 533)
        Me.DtgPrincipal.TabIndex = 1
        '
        'Agregar
        '
        Me.Agregar.Location = New System.Drawing.Point(812, 22)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(145, 49)
        Me.Agregar.TabIndex = 2
        Me.Agregar.Text = "Agregar"
        Me.Agregar.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Eliminar.Location = New System.Drawing.Point(969, 639)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(91, 26)
        Me.Eliminar.TabIndex = 3
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!)
        Me.Label1.Location = New System.Drawing.Point(22, 636)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 33)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'Responsable
        '
        Me.Responsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Responsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Responsable.FormattingEnabled = True
        Me.Responsable.Location = New System.Drawing.Point(22, 12)
        Me.Responsable.Name = "Responsable"
        Me.Responsable.Size = New System.Drawing.Size(200, 30)
        Me.Responsable.TabIndex = 55
        '
        'Notas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 677)
        Me.Controls.Add(Me.Responsable)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Agregar)
        Me.Controls.Add(Me.DtgPrincipal)
        Me.Controls.Add(Me.Texto)
        Me.Name = "Notas"
        Me.Text = "Notas"
        CType(Me.DtgPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Texto As TextBox
    Friend WithEvents DtgPrincipal As DataGridView
    Friend WithEvents Agregar As Button
    Friend WithEvents Eliminar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Responsable As ComboBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoProvedor_Preventivo
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
        Me.Crear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Provedor = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Crear
        '
        Me.Crear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Crear.Location = New System.Drawing.Point(428, 161)
        Me.Crear.Name = "Crear"
        Me.Crear.Size = New System.Drawing.Size(131, 54)
        Me.Crear.TabIndex = 15
        Me.Crear.Text = "Crear"
        Me.Crear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 24)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Provedor"
        '
        'Provedor
        '
        Me.Provedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Provedor.Location = New System.Drawing.Point(169, 188)
        Me.Provedor.Name = "Provedor"
        Me.Provedor.Size = New System.Drawing.Size(200, 27)
        Me.Provedor.TabIndex = 13
        '
        'NuevoProvedor_Preventivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Crear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Provedor)
        Me.Name = "NuevoProvedor_Preventivo"
        Me.Text = "Provedor_Preventivo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Crear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Provedor As TextBox
End Class

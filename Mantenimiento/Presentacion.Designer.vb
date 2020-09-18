<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Presentacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Presentacion))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.FlatAppearance.BorderSize = 3
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft PhagsPa", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(-1, 66)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 135)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Registrar nuevo caso"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.FlatAppearance.BorderSize = 3
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft PhagsPa", 16.2!)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(215, 66)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 135)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Casos en proceso"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(0, 0)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel2.Location = New System.Drawing.Point(-1, 391)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(814, 260)
        Me.Panel2.TabIndex = 5
        '
        'Button5
        '
        Me.Button5.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button5.FlatAppearance.BorderSize = 3
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft PhagsPa", 16.2!)
        Me.Button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button5.Location = New System.Drawing.Point(588, 250)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(200, 135)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Busqueda Material"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button6.FlatAppearance.BorderSize = 3
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft PhagsPa", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button6.Location = New System.Drawing.Point(364, 250)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(200, 135)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Material Nuevo"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.AutoSize = True
        Me.Panel3.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel3.Location = New System.Drawing.Point(-22, -56)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(835, 116)
        Me.Panel3.TabIndex = 6
        '
        'Presentacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(818, 497)
        Me.Name = "Presentacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel3 As Panel
End Class

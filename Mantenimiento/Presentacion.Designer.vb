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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft PhagsPa", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(70, 140)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 118)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Registrar nuevo caso"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft PhagsPa", 16.2!)
        Me.Button2.Location = New System.Drawing.Point(514, 140)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(178, 118)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Casos en proceso"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(116, 358)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(132, 72)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Nuevo Material"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(264, 358)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(132, 72)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Ejemplo"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'Presentacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.BackgroundImage = Global.Mantenimiento.My.Resources.Resources._109634705_blue_dark_blue_black_abstract_background_blur_gradient
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.MaximumSize = New System.Drawing.Size(818, 497)
        Me.Name = "Presentacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class

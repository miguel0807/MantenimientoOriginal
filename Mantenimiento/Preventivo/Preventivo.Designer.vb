﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Preventivo
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
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(666, 359)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 79)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Nuevo preventivo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(146, 228)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(209, 135)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Registrar Preventivos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(666, 274)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(122, 79)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Nuevo Equipo"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(666, 189)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(122, 79)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Nueva Clase"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(156, 27)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(122, 79)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Planificacion Equipos"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(12, 27)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(122, 79)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Lista Equipos"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(310, 27)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(122, 79)
        Me.Button7.TabIndex = 4
        Me.Button7.Text = "Historial Equipos"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Preventivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Preventivo"
        Me.Text = "Preventivo"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Programas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Programas))
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Button26 = New System.Windows.Forms.Button()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.Silver
        Me.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.ForeColor = System.Drawing.Color.Black
        Me.button2.Image = Global.Mantenimiento.My.Resources.Resources.etiquetas_64
        Me.button2.Location = New System.Drawing.Point(837, 282)
        Me.button2.Name = "button2"
        Me.button2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.button2.Size = New System.Drawing.Size(308, 136)
        Me.button2.TabIndex = 20
        Me.button2.Text = "Etiquetas"
        Me.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.button2.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.Silver
        Me.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.Color.Black
        Me.button1.Image = Global.Mantenimiento.My.Resources.Resources.mantenimiento_64
        Me.button1.Location = New System.Drawing.Point(466, 282)
        Me.button1.Name = "button1"
        Me.button1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.button1.Size = New System.Drawing.Size(308, 136)
        Me.button1.TabIndex = 19
        Me.button1.Text = "Mantenimiento"
        Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.button1.UseVisualStyleBackColor = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(145, 47)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(831, 158)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox9.TabIndex = 18
        Me.PictureBox9.TabStop = False
        '
        'Button26
        '
        Me.Button26.BackColor = System.Drawing.Color.Silver
        Me.Button26.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button26.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button26.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button26.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button26.ForeColor = System.Drawing.Color.Black
        Me.Button26.Image = Global.Mantenimiento.My.Resources.Resources.icons8_tanque_de_almacenamiento_químico_641
        Me.Button26.Location = New System.Drawing.Point(34, 282)
        Me.Button26.Name = "Button26"
        Me.Button26.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Button26.Size = New System.Drawing.Size(308, 136)
        Me.Button26.TabIndex = 17
        Me.Button26.Text = "Tank Farm"
        Me.Button26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button26.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button26.UseVisualStyleBackColor = False
        '
        'Programas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1167, 512)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.Button26)
        Me.Name = "Programas"
        Me.Opacity = 0.95R
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Friend WithEvents PictureBox9 As PictureBox
    Private WithEvents Button26 As Button
End Class

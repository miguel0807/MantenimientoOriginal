<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Programas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Programas))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Iconostrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ProgramasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Iconostrip.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1167, 38)
        Me.Panel1.TabIndex = 21
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = Global.Mantenimiento.My.Resources.Resources.Delete_80_icon_icons_com_57340
        Me.btnClose.Location = New System.Drawing.Point(1122, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(32, 32)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnClose.TabIndex = 22
        Me.btnClose.TabStop = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.Iconostrip
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "SIM PRO"
        Me.NotifyIcon1.Visible = True
        '
        'Iconostrip
        '
        Me.Iconostrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Iconostrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramasToolStripMenuItem, Me.CerrarToolStripMenuItem})
        Me.Iconostrip.Name = "Iconostrip"
        Me.Iconostrip.Size = New System.Drawing.Size(154, 56)
        '
        'ProgramasToolStripMenuItem
        '
        Me.ProgramasToolStripMenuItem.Image = Global.Mantenimiento.My.Resources.Resources.tools_22686
        Me.ProgramasToolStripMenuItem.Name = "ProgramasToolStripMenuItem"
        Me.ProgramasToolStripMenuItem.Size = New System.Drawing.Size(153, 26)
        Me.ProgramasToolStripMenuItem.Text = "Programas"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Image = Global.Mantenimiento.My.Resources.Resources.salir1
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(153, 26)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Silver
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = Global.Mantenimiento.My.Resources.Resources.Chip1_icon_icons_com_55238__2_
        Me.Button3.Location = New System.Drawing.Point(12, 274)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Button3.Size = New System.Drawing.Size(308, 136)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "Electrónicos"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = False
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
        Me.button2.Location = New System.Drawing.Point(819, 463)
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
        Me.button1.Location = New System.Drawing.Point(430, 463)
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
        Me.PictureBox9.Location = New System.Drawing.Point(142, 70)
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
        Me.Button26.Location = New System.Drawing.Point(12, 463)
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
        Me.ClientSize = New System.Drawing.Size(1167, 655)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.Button26)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Programas"
        Me.Opacity = 0.98R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIM PRO"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Iconostrip.ResumeLayout(False)
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Friend WithEvents PictureBox9 As PictureBox
    Private WithEvents Button26 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Iconostrip As ContextMenuStrip
    Friend WithEvents ProgramasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Private WithEvents Button3 As Button
End Class

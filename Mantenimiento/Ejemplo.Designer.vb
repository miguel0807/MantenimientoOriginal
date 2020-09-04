<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejemplo
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Registrar = New System.Windows.Forms.TabPage()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.BTN_Registrar = New System.Windows.Forms.Button()
        Me.Cbo_genero = New System.Windows.Forms.ComboBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_apePaterno = New System.Windows.Forms.TextBox()
        Me.txt_apeMaterno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Actualizar = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Cbo_GeneroA = New System.Windows.Forms.ComboBox()
        Me.txt_nombreA = New System.Windows.Forms.TextBox()
        Me.txt_apePaternoA = New System.Windows.Forms.TextBox()
        Me.TXT_apeMaternoA = New System.Windows.Forms.TextBox()
        Me.txt_codigoA = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Eliminar = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Cbo_generoE = New System.Windows.Forms.ComboBox()
        Me.txt_nombreE = New System.Windows.Forms.TextBox()
        Me.txt_apePaternoE = New System.Windows.Forms.TextBox()
        Me.txt_apeMaternoE = New System.Windows.Forms.TextBox()
        Me.txt_codigoE = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.Registrar.SuspendLayout()
        Me.Actualizar.SuspendLayout()
        Me.Eliminar.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Registrar)
        Me.TabControl1.Controls.Add(Me.Actualizar)
        Me.TabControl1.Controls.Add(Me.Eliminar)
        Me.TabControl1.Location = New System.Drawing.Point(22, 38)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(807, 501)
        Me.TabControl1.TabIndex = 1
        '
        'Registrar
        '
        Me.Registrar.Controls.Add(Me.Button5)
        Me.Registrar.Controls.Add(Me.BTN_Registrar)
        Me.Registrar.Controls.Add(Me.Cbo_genero)
        Me.Registrar.Controls.Add(Me.txt_nombre)
        Me.Registrar.Controls.Add(Me.txt_apePaterno)
        Me.Registrar.Controls.Add(Me.txt_apeMaterno)
        Me.Registrar.Controls.Add(Me.Label2)
        Me.Registrar.Controls.Add(Me.Label3)
        Me.Registrar.Controls.Add(Me.Label4)
        Me.Registrar.Controls.Add(Me.Label5)
        Me.Registrar.Controls.Add(Me.txt_codigo)
        Me.Registrar.Controls.Add(Me.Label1)
        Me.Registrar.Location = New System.Drawing.Point(4, 25)
        Me.Registrar.Name = "Registrar"
        Me.Registrar.Padding = New System.Windows.Forms.Padding(3)
        Me.Registrar.Size = New System.Drawing.Size(799, 472)
        Me.Registrar.TabIndex = 0
        Me.Registrar.Text = "Registrar"
        Me.Registrar.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(521, 87)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(139, 103)
        Me.Button5.TabIndex = 25
        Me.Button5.Text = "SQL"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'BTN_Registrar
        '
        Me.BTN_Registrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Registrar.Location = New System.Drawing.Point(85, 364)
        Me.BTN_Registrar.Name = "BTN_Registrar"
        Me.BTN_Registrar.Size = New System.Drawing.Size(295, 65)
        Me.BTN_Registrar.TabIndex = 6
        Me.BTN_Registrar.Text = "Registrar"
        Me.BTN_Registrar.UseVisualStyleBackColor = True
        '
        'Cbo_genero
        '
        Me.Cbo_genero.FormattingEnabled = True
        Me.Cbo_genero.Items.AddRange(New Object() {"Femenino", "Masculino"})
        Me.Cbo_genero.Location = New System.Drawing.Point(244, 303)
        Me.Cbo_genero.Name = "Cbo_genero"
        Me.Cbo_genero.Size = New System.Drawing.Size(121, 24)
        Me.Cbo_genero.TabIndex = 5
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(241, 156)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(156, 22)
        Me.txt_nombre.TabIndex = 2
        '
        'txt_apePaterno
        '
        Me.txt_apePaterno.Location = New System.Drawing.Point(241, 200)
        Me.txt_apePaterno.Name = "txt_apePaterno"
        Me.txt_apePaterno.Size = New System.Drawing.Size(156, 22)
        Me.txt_apePaterno.TabIndex = 3
        '
        'txt_apeMaterno
        '
        Me.txt_apeMaterno.Location = New System.Drawing.Point(241, 248)
        Me.txt_apeMaterno.Name = "txt_apeMaterno"
        Me.txt_apeMaterno.Size = New System.Drawing.Size(156, 22)
        Me.txt_apeMaterno.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(133, 303)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Genero:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 20)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Apellido Paterno:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(53, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 20)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Nombre:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(53, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 20)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Apellido Materno:"
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(241, 106)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(156, 22)
        Me.txt_codigo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
        '
        'Actualizar
        '
        Me.Actualizar.Controls.Add(Me.Button2)
        Me.Actualizar.Controls.Add(Me.Button1)
        Me.Actualizar.Controls.Add(Me.Cbo_GeneroA)
        Me.Actualizar.Controls.Add(Me.txt_nombreA)
        Me.Actualizar.Controls.Add(Me.txt_apePaternoA)
        Me.Actualizar.Controls.Add(Me.TXT_apeMaternoA)
        Me.Actualizar.Controls.Add(Me.txt_codigoA)
        Me.Actualizar.Controls.Add(Me.Label6)
        Me.Actualizar.Controls.Add(Me.Label7)
        Me.Actualizar.Controls.Add(Me.Label8)
        Me.Actualizar.Controls.Add(Me.Label9)
        Me.Actualizar.Controls.Add(Me.Label10)
        Me.Actualizar.Location = New System.Drawing.Point(4, 25)
        Me.Actualizar.Name = "Actualizar"
        Me.Actualizar.Padding = New System.Windows.Forms.Padding(3)
        Me.Actualizar.Size = New System.Drawing.Size(799, 472)
        Me.Actualizar.TabIndex = 1
        Me.Actualizar.Text = "Actualizar"
        Me.Actualizar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(77, 363)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(295, 65)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Actualizar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(652, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 39)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Cbo_GeneroA
        '
        Me.Cbo_GeneroA.FormattingEnabled = True
        Me.Cbo_GeneroA.Items.AddRange(New Object() {"Femenino", "Masculino"})
        Me.Cbo_GeneroA.Location = New System.Drawing.Point(251, 283)
        Me.Cbo_GeneroA.Name = "Cbo_GeneroA"
        Me.Cbo_GeneroA.Size = New System.Drawing.Size(121, 24)
        Me.Cbo_GeneroA.TabIndex = 6
        '
        'txt_nombreA
        '
        Me.txt_nombreA.Location = New System.Drawing.Point(248, 136)
        Me.txt_nombreA.Name = "txt_nombreA"
        Me.txt_nombreA.Size = New System.Drawing.Size(156, 22)
        Me.txt_nombreA.TabIndex = 3
        '
        'txt_apePaternoA
        '
        Me.txt_apePaternoA.Location = New System.Drawing.Point(248, 180)
        Me.txt_apePaternoA.Name = "txt_apePaternoA"
        Me.txt_apePaternoA.Size = New System.Drawing.Size(156, 22)
        Me.txt_apePaternoA.TabIndex = 4
        '
        'TXT_apeMaternoA
        '
        Me.TXT_apeMaternoA.Location = New System.Drawing.Point(248, 228)
        Me.TXT_apeMaternoA.Name = "TXT_apeMaternoA"
        Me.TXT_apeMaternoA.Size = New System.Drawing.Size(156, 22)
        Me.TXT_apeMaternoA.TabIndex = 5
        '
        'txt_codigoA
        '
        Me.txt_codigoA.Location = New System.Drawing.Point(390, 37)
        Me.txt_codigoA.Name = "txt_codigoA"
        Me.txt_codigoA.Size = New System.Drawing.Size(200, 22)
        Me.txt_codigoA.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(140, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Genero:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(60, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Apellido Paterno:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(60, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 20)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Nombre:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(60, 228)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(156, 20)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Apellido Materno:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(146, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 20)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Ingrese codigo"
        '
        'Eliminar
        '
        Me.Eliminar.Controls.Add(Me.Button3)
        Me.Eliminar.Controls.Add(Me.Button4)
        Me.Eliminar.Controls.Add(Me.Cbo_generoE)
        Me.Eliminar.Controls.Add(Me.txt_nombreE)
        Me.Eliminar.Controls.Add(Me.txt_apePaternoE)
        Me.Eliminar.Controls.Add(Me.txt_apeMaternoE)
        Me.Eliminar.Controls.Add(Me.txt_codigoE)
        Me.Eliminar.Controls.Add(Me.Label11)
        Me.Eliminar.Controls.Add(Me.Label12)
        Me.Eliminar.Controls.Add(Me.Label13)
        Me.Eliminar.Controls.Add(Me.Label14)
        Me.Eliminar.Controls.Add(Me.Label15)
        Me.Eliminar.Location = New System.Drawing.Point(4, 25)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(799, 472)
        Me.Eliminar.TabIndex = 2
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(61, 372)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(295, 65)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(636, 35)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(118, 39)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Buscar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Cbo_generoE
        '
        Me.Cbo_generoE.FormattingEnabled = True
        Me.Cbo_generoE.Items.AddRange(New Object() {"Femenino", "Masculino"})
        Me.Cbo_generoE.Location = New System.Drawing.Point(235, 292)
        Me.Cbo_generoE.Name = "Cbo_generoE"
        Me.Cbo_generoE.Size = New System.Drawing.Size(121, 24)
        Me.Cbo_generoE.TabIndex = 6
        '
        'txt_nombreE
        '
        Me.txt_nombreE.Location = New System.Drawing.Point(232, 145)
        Me.txt_nombreE.Name = "txt_nombreE"
        Me.txt_nombreE.Size = New System.Drawing.Size(156, 22)
        Me.txt_nombreE.TabIndex = 3
        '
        'txt_apePaternoE
        '
        Me.txt_apePaternoE.Location = New System.Drawing.Point(232, 189)
        Me.txt_apePaternoE.Name = "txt_apePaternoE"
        Me.txt_apePaternoE.Size = New System.Drawing.Size(156, 22)
        Me.txt_apePaternoE.TabIndex = 4
        '
        'txt_apeMaternoE
        '
        Me.txt_apeMaternoE.Location = New System.Drawing.Point(232, 237)
        Me.txt_apeMaternoE.Name = "txt_apeMaternoE"
        Me.txt_apeMaternoE.Size = New System.Drawing.Size(156, 22)
        Me.txt_apeMaternoE.TabIndex = 5
        '
        'txt_codigoE
        '
        Me.txt_codigoE.Location = New System.Drawing.Point(374, 46)
        Me.txt_codigoE.Name = "txt_codigoE"
        Me.txt_codigoE.Size = New System.Drawing.Size(200, 22)
        Me.txt_codigoE.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(124, 292)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 20)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Genero:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(44, 189)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(153, 20)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Apellido Paterno:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(44, 147)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 20)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Nombre:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(44, 237)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(156, 20)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Apellido Materno:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(130, 46)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(138, 20)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Ingrese codigo:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Ejemplo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1176, 694)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Ejemplo"
        Me.Text = "Ejemplo"
        Me.TabControl1.ResumeLayout(False)
        Me.Registrar.ResumeLayout(False)
        Me.Registrar.PerformLayout()
        Me.Actualizar.ResumeLayout(False)
        Me.Actualizar.PerformLayout()
        Me.Eliminar.ResumeLayout(False)
        Me.Eliminar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Registrar As TabPage
    Friend WithEvents Button5 As Button
    Friend WithEvents BTN_Registrar As Button
    Friend WithEvents Cbo_genero As ComboBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_apePaterno As TextBox
    Friend WithEvents txt_apeMaterno As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_codigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Actualizar As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Cbo_GeneroA As ComboBox
    Friend WithEvents txt_nombreA As TextBox
    Friend WithEvents txt_apePaternoA As TextBox
    Friend WithEvents TXT_apeMaternoA As TextBox
    Friend WithEvents txt_codigoA As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Eliminar As TabPage
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Cbo_generoE As ComboBox
    Friend WithEvents txt_nombreE As TextBox
    Friend WithEvents txt_apePaternoE As TextBox
    Friend WithEvents txt_apeMaternoE As TextBox
    Friend WithEvents txt_codigoE As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reportes_área
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Año = New System.Windows.Forms.ComboBox()
        Me.Mes = New System.Windows.Forms.ComboBox()
        Me.Ubicación = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.checkAño = New System.Windows.Forms.CheckBox()
        Me.checkMes = New System.Windows.Forms.CheckBox()
        Me.checkUbicación = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Año
        '
        Me.Año.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Año.FormattingEnabled = True
        Me.Año.Items.AddRange(New Object() {"2020", "2021", "2022", "2023", "2024", "2025"})
        Me.Año.Location = New System.Drawing.Point(17, 41)
        Me.Año.Name = "Año"
        Me.Año.Size = New System.Drawing.Size(241, 24)
        Me.Año.TabIndex = 0
        Me.Año.Visible = False
        '
        'Mes
        '
        Me.Mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Mes.FormattingEnabled = True
        Me.Mes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.Mes.Location = New System.Drawing.Point(17, 116)
        Me.Mes.Name = "Mes"
        Me.Mes.Size = New System.Drawing.Size(241, 24)
        Me.Mes.TabIndex = 1
        Me.Mes.Visible = False
        '
        'Ubicación
        '
        Me.Ubicación.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Ubicación.FormattingEnabled = True
        Me.Ubicación.Items.AddRange(New Object() {"Bodega", "Cartuchos DD", "Cartuchos Wilsonville", "Contacto", "CR7", "CR8", "Cuarto de compresor", "N/A", "Oficinas", "Produccion Empaque", "Produccion Etiquetas", "Produccion Master batch", "Taller Mantenimiento", "Tank Farm", ""})
        Me.Ubicación.Location = New System.Drawing.Point(17, 195)
        Me.Ubicación.Name = "Ubicación"
        Me.Ubicación.Size = New System.Drawing.Size(241, 24)
        Me.Ubicación.TabIndex = 2
        Me.Ubicación.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Año"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Mes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Ubicación"
        '
        'Chart1
        '
        Me.Chart1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.AxisX.Interval = 1.0R
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.LabelStyle.Angle = -90
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(25, 320)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Reporte por área"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(1273, 342)
        Me.Chart1.TabIndex = 8
        Me.Chart1.Text = "Chart1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(67, 222)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(154, 54)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Location = New System.Drawing.Point(25, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(778, 292)
        Me.DataGridView1.TabIndex = 10
        '
        'checkAño
        '
        Me.checkAño.AutoSize = True
        Me.checkAño.Location = New System.Drawing.Point(262, 45)
        Me.checkAño.Name = "checkAño"
        Me.checkAño.Size = New System.Drawing.Size(18, 17)
        Me.checkAño.TabIndex = 11
        Me.checkAño.UseVisualStyleBackColor = True
        '
        'checkMes
        '
        Me.checkMes.AutoSize = True
        Me.checkMes.Location = New System.Drawing.Point(262, 120)
        Me.checkMes.Name = "checkMes"
        Me.checkMes.Size = New System.Drawing.Size(18, 17)
        Me.checkMes.TabIndex = 12
        Me.checkMes.UseVisualStyleBackColor = True
        '
        'checkUbicación
        '
        Me.checkUbicación.AutoSize = True
        Me.checkUbicación.Location = New System.Drawing.Point(262, 199)
        Me.checkUbicación.Name = "checkUbicación"
        Me.checkUbicación.Size = New System.Drawing.Size(18, 17)
        Me.checkUbicación.TabIndex = 13
        Me.checkUbicación.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(877, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(197, 25)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Modo de busqueda"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.checkUbicación)
        Me.Panel1.Controls.Add(Me.checkMes)
        Me.Panel1.Controls.Add(Me.checkAño)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Ubicación)
        Me.Panel1.Controls.Add(Me.Mes)
        Me.Panel1.Controls.Add(Me.Año)
        Me.Panel1.Location = New System.Drawing.Point(873, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(283, 279)
        Me.Panel1.TabIndex = 15
        '
        'Reportes_área
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1323, 689)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "Reportes_área"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Año As ComboBox
    Friend WithEvents Mes As ComboBox
    Friend WithEvents Ubicación As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents checkAño As CheckBox
    Friend WithEvents checkMes As CheckBox
    Friend WithEvents checkUbicación As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
End Class

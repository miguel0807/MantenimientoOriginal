﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Análisis_Datos
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
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.adatosAño = New System.Windows.Forms.ComboBox()
        Me.adatosMes = New System.Windows.Forms.ComboBox()
        Me.adatosUbicación = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.checkAño = New System.Windows.Forms.CheckBox()
        Me.checkMes = New System.Windows.Forms.CheckBox()
        Me.checkUbicación = New System.Windows.Forms.CheckBox()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'adatosAño
        '
        Me.adatosAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.adatosAño.FormattingEnabled = True
        Me.adatosAño.Items.AddRange(New Object() {"2020", "2021", "2022", "2023", "2024", "2025"})
        Me.adatosAño.Location = New System.Drawing.Point(42, 56)
        Me.adatosAño.Name = "adatosAño"
        Me.adatosAño.Size = New System.Drawing.Size(241, 24)
        Me.adatosAño.TabIndex = 0
        Me.adatosAño.Visible = False
        '
        'adatosMes
        '
        Me.adatosMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.adatosMes.FormattingEnabled = True
        Me.adatosMes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.adatosMes.Location = New System.Drawing.Point(42, 139)
        Me.adatosMes.Name = "adatosMes"
        Me.adatosMes.Size = New System.Drawing.Size(241, 24)
        Me.adatosMes.TabIndex = 1
        Me.adatosMes.Visible = False
        '
        'adatosUbicación
        '
        Me.adatosUbicación.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.adatosUbicación.FormattingEnabled = True
        Me.adatosUbicación.Items.AddRange(New Object() {"Bodega", "Cartuchos DD", "Cartuchos Wilsonville", "Contacto", "CR7", "CR8", "Cuarto de compresor", "N/A", "Oficinas", "Produccion Empaque", "Produccion Etiquetas", "Produccion Master batch", "Taller Mantenimiento", "Tank Farm", ""})
        Me.adatosUbicación.Location = New System.Drawing.Point(42, 220)
        Me.adatosUbicación.Name = "adatosUbicación"
        Me.adatosUbicación.Size = New System.Drawing.Size(241, 24)
        Me.adatosUbicación.TabIndex = 2
        Me.adatosUbicación.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Año"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Mes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Ubicación"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 566)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(286, 92)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Actualizar Grafico"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea5.AxisX.Interval = 1.0R
        ChartArea5.AxisX.IsLabelAutoFit = False
        ChartArea5.AxisX.LabelStyle.Angle = -90
        ChartArea5.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea5)
        Legend5.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend5)
        Me.Chart1.Location = New System.Drawing.Point(316, 313)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series5.ChartArea = "ChartArea1"
        Series5.Legend = "Legend1"
        Series5.Name = "Reporte por área"
        Me.Chart1.Series.Add(Series5)
        Me.Chart1.Size = New System.Drawing.Size(950, 379)
        Me.Chart1.TabIndex = 8
        Me.Chart1.Text = "Chart1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 333)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(286, 103)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Cargar Datos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(316, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(832, 308)
        Me.DataGridView1.TabIndex = 10
        '
        'checkAño
        '
        Me.checkAño.AutoSize = True
        Me.checkAño.Location = New System.Drawing.Point(25, 37)
        Me.checkAño.Name = "checkAño"
        Me.checkAño.Size = New System.Drawing.Size(18, 17)
        Me.checkAño.TabIndex = 11
        Me.checkAño.UseVisualStyleBackColor = True
        '
        'checkMes
        '
        Me.checkMes.AutoSize = True
        Me.checkMes.Location = New System.Drawing.Point(25, 120)
        Me.checkMes.Name = "checkMes"
        Me.checkMes.Size = New System.Drawing.Size(18, 17)
        Me.checkMes.TabIndex = 12
        Me.checkMes.UseVisualStyleBackColor = True
        '
        'checkUbicación
        '
        Me.checkUbicación.AutoSize = True
        Me.checkUbicación.Location = New System.Drawing.Point(25, 201)
        Me.checkUbicación.Name = "checkUbicación"
        Me.checkUbicación.Size = New System.Drawing.Size(18, 17)
        Me.checkUbicación.TabIndex = 13
        Me.checkUbicación.UseVisualStyleBackColor = True
        '
        'Análisis_Datos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1323, 689)
        Me.Controls.Add(Me.checkUbicación)
        Me.Controls.Add(Me.checkMes)
        Me.Controls.Add(Me.checkAño)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.adatosUbicación)
        Me.Controls.Add(Me.adatosMes)
        Me.Controls.Add(Me.adatosAño)
        Me.Name = "Análisis_Datos"
        Me.Text = "Análisis_Datos"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents adatosAño As ComboBox
    Friend WithEvents adatosMes As ComboBox
    Friend WithEvents adatosUbicación As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents checkAño As CheckBox
    Friend WithEvents checkMes As CheckBox
    Friend WithEvents checkUbicación As CheckBox
End Class

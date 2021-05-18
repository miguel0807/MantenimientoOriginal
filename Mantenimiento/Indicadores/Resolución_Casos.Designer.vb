<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Resolución_Casos
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
        Dim ChartArea7 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend7 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series73 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series74 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series75 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series76 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series77 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series78 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series79 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series80 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series81 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series82 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series83 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series84 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title7 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.CboFecha = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 51)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1243, 177)
        Me.DataGridView1.TabIndex = 23
        '
        'Chart1
        '
        Me.Chart1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chart1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Chart1.CausesValidation = False
        ChartArea7.Area3DStyle.Enable3D = True
        ChartArea7.Area3DStyle.IsClustered = True
        ChartArea7.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea7.AxisX.Interval = 1.0R
        ChartArea7.AxisX.IsLabelAutoFit = False
        ChartArea7.AxisX.IsMarginVisible = False
        ChartArea7.AxisX.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea7.AxisX.MaximumAutoSize = 100.0!
        ChartArea7.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea7.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea7.AxisY.IsLabelAutoFit = False
        ChartArea7.AxisY.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea7.AxisY.MaximumAutoSize = 100.0!
        ChartArea7.BackColor = System.Drawing.Color.White
        ChartArea7.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea7)
        Me.Chart1.IsSoftShadows = False
        Legend7.BackColor = System.Drawing.SystemColors.ScrollBar
        Legend7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Legend7.BorderWidth = 5
        Legend7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend7.IsTextAutoFit = False
        Legend7.Name = "Legend1"
        Legend7.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chart1.Legends.Add(Legend7)
        Me.Chart1.Location = New System.Drawing.Point(12, 237)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.Chart1.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(189, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(89, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(162, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(198, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(70, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(117, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(42, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(48, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(98, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(124, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(8, Byte), Integer))}
        Series73.ChartArea = "ChartArea1"
        Series73.CustomProperties = "PointWidth=1"
        Series73.Legend = "Legend1"
        Series73.Name = "Enero"
        Series74.ChartArea = "ChartArea1"
        Series74.CustomProperties = "PointWidth=1"
        Series74.Legend = "Legend1"
        Series74.Name = "Febrero"
        Series75.ChartArea = "ChartArea1"
        Series75.CustomProperties = "PointWidth=1"
        Series75.Legend = "Legend1"
        Series75.Name = "Marzo"
        Series76.ChartArea = "ChartArea1"
        Series76.CustomProperties = "PointWidth=1"
        Series76.Legend = "Legend1"
        Series76.Name = "Abril"
        Series77.ChartArea = "ChartArea1"
        Series77.CustomProperties = "PointWidth=1"
        Series77.Legend = "Legend1"
        Series77.Name = "Mayo"
        Series78.ChartArea = "ChartArea1"
        Series78.CustomProperties = "PointWidth=1"
        Series78.Legend = "Legend1"
        Series78.Name = "Junio"
        Series79.ChartArea = "ChartArea1"
        Series79.CustomProperties = "PointWidth=1"
        Series79.Legend = "Legend1"
        Series79.Name = "Julio"
        Series80.ChartArea = "ChartArea1"
        Series80.CustomProperties = "PointWidth=1"
        Series80.Legend = "Legend1"
        Series80.Name = "Agosto"
        Series81.ChartArea = "ChartArea1"
        Series81.CustomProperties = "PointWidth=1"
        Series81.Legend = "Legend1"
        Series81.Name = "Septiembre"
        Series82.ChartArea = "ChartArea1"
        Series82.CustomProperties = "PointWidth=1"
        Series82.Legend = "Legend1"
        Series82.Name = "Octubre"
        Series83.ChartArea = "ChartArea1"
        Series83.CustomProperties = "PointWidth=1"
        Series83.Legend = "Legend1"
        Series83.Name = "Noviembre"
        Series84.ChartArea = "ChartArea1"
        Series84.CustomProperties = "PointWidth=1"
        Series84.Legend = "Legend1"
        Series84.Name = "Diciembre"
        Me.Chart1.Series.Add(Series73)
        Me.Chart1.Series.Add(Series74)
        Me.Chart1.Series.Add(Series75)
        Me.Chart1.Series.Add(Series76)
        Me.Chart1.Series.Add(Series77)
        Me.Chart1.Series.Add(Series78)
        Me.Chart1.Series.Add(Series79)
        Me.Chart1.Series.Add(Series80)
        Me.Chart1.Series.Add(Series81)
        Me.Chart1.Series.Add(Series82)
        Me.Chart1.Series.Add(Series83)
        Me.Chart1.Series.Add(Series84)
        Me.Chart1.Size = New System.Drawing.Size(1243, 521)
        Me.Chart1.TabIndex = 28
        Me.Chart1.TabStop = False
        Me.Chart1.Text = "Chart1"
        Title7.BackColor = System.Drawing.Color.Transparent
        Title7.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center
        Title7.BorderColor = System.Drawing.Color.Black
        Title7.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title7.Name = "Title1"
        Title7.Text = "Resolución de Casos"
        Me.Chart1.Titles.Add(Title7)
        '
        'CboFecha
        '
        Me.CboFecha.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CboFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboFecha.FormattingEnabled = True
        Me.CboFecha.Items.AddRange(New Object() {"2020", "2021", "2022", "2023", "2024", "2025"})
        Me.CboFecha.Location = New System.Drawing.Point(12, 12)
        Me.CboFecha.Name = "CboFecha"
        Me.CboFecha.Size = New System.Drawing.Size(137, 35)
        Me.CboFecha.TabIndex = 29
        '
        'Resolución_Casos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1267, 770)
        Me.Controls.Add(Me.CboFecha)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Resolución_Casos"
        Me.Text = "Resolución_Casos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents CboFecha As ComboBox
End Class

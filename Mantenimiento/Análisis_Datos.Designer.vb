<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Análisis_Datos
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
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"2020", "2021", "2022"})
        Me.ComboBox1.Location = New System.Drawing.Point(57, 56)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(241, 24)
        Me.ComboBox1.TabIndex = 0
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre", "Todos"})
        Me.ComboBox2.Location = New System.Drawing.Point(57, 186)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(241, 24)
        Me.ComboBox2.TabIndex = 1
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Bodega", "Cartuchos DD", "Cartuchos Wilsonville", "Contacto", "CR7", "CR8", "Cuarto de compresor", "N/A", "Oficinas", "Produccion Empaque", "Produccion Etiquetas", "Produccion Master batch", "Taller Mantenimiento", "Tank Farm", ""})
        Me.ComboBox3.Location = New System.Drawing.Point(57, 284)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(241, 24)
        Me.ComboBox3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Año"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Mes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Ubicación"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 410)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(286, 92)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Actualizar Grafico"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea4.AxisX.Interval = 1.0R
        ChartArea4.AxisX.IsLabelAutoFit = False
        ChartArea4.AxisX.LabelStyle.Angle = -90
        ChartArea4.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend4)
        Me.Chart1.Location = New System.Drawing.Point(316, 313)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "Ubicaciónes"
        Me.Chart1.Series.Add(Series4)
        Me.Chart1.Size = New System.Drawing.Size(950, 379)
        Me.Chart1.TabIndex = 8
        Me.Chart1.Text = "Chart1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 560)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(286, 103)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Cargar datagridview"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(316, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(832, 308)
        Me.DataGridView1.TabIndex = 10
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(77, 120)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(203, 22)
        Me.TextBox1.TabIndex = 11
        '
        'Análisis_Datos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1323, 689)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Análisis_Datos"
        Me.Text = "Análisis_Datos"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
End Class

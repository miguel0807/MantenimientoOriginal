<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exportar_indicadores
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
        Me.btnExportExcel = New System.Windows.Forms.Button()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Location = New System.Drawing.Point(375, 175)
        Me.btnExportExcel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(100, 28)
        Me.btnExportExcel.TabIndex = 1
        Me.btnExportExcel.Text = "Export Excel"
        Me.btnExportExcel.UseVisualStyleBackColor = True
        '
        'dataGridView1
        '
        Me.dataGridView1.AllowUserToAddRows = False
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Location = New System.Drawing.Point(16, 15)
        Me.dataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.RowHeadersWidth = 51
        Me.dataGridView1.Size = New System.Drawing.Size(459, 138)
        Me.dataGridView1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 218)
        Me.Controls.Add(Me.btnExportExcel)
        Me.Controls.Add(Me.dataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExportExcel As System.Windows.Forms.Button
    Friend WithEvents dataGridView1 As System.Windows.Forms.DataGridView

End Class

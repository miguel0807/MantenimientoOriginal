Imports System.Data.SqlClient


Public Module MOstartup
    Public datagr As DataGridView
    Public labe1 As Label
    Public columncheck As New DataGridViewColumn
    Public usuario As ComboBox



    Sub CheckColumna()
        'Crea una nueva columna tipo checkbox
        datagr.Columns.Clear()
        Dim Obj As New DataGridViewColumn
        Dim Col As New DataGridViewCheckBoxColumn
        Obj = Col
        Obj.HeaderText = "Realizado" ' el texto que ira en la cabecera
        Obj.Name = "Realizado" ' Nombre de la Columna del checkbox
        Obj.Width = 50
        datagr.Columns.Add(Obj)

        datagr.Columns(datagr.Columns.Count - 1).DisplayIndex = 0 ' Es para que la columna sea la primera en la grilla

        ' Luego esta propiedad para la grilla

        datagr.ReadOnly = False ' Esto para que toda la grilla sea editable
        datagr.DataSource = Nothing ' al inicio no va ningun enlaze de datos
        'Crea una nueva columna tipo checkbox
    End Sub
    Sub startupDatagridview()



#Region "Configuracion datagridview1"
        conectar()

        Dim conteo As String
        conteo = 1

#Region "Formato de letra"

        datagr.DefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)
        datagr.ColumnHeadersDefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)

#End Region
        datagr.RowTemplate.Height = 30
#Region "Color de los titulos"
        datagr.ColumnHeadersDefaultCellStyle.BackColor = Color.Green
        datagr.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
#End Region
#Region "Cambios de color celdas y alternadas"
        datagr.RowsDefaultCellStyle.BackColor = Color.White
        datagr.AlternatingRowsDefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control)

#End Region
#Region "Alineacion de titulos"
        datagr.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
#End Region
#End Region

#Region "Buscar la planificacion"




        Dim adaptador As New SqlDataAdapter("select Conteo as #, Tarea,Equipo,Estado from Shutdowns ", cn)
        Dim dataS As New DataSet
        adaptador.Fill(dataS, "Shutdowns")

        datagr.DataSource = dataS.Tables("Shutdowns")



#Region "prueba check"
#End Region

#End Region


        datagr.RowHeadersVisible = False
        datagr.Columns(1).Visible = False
        datagr.Columns(4).Visible = False


        datagr.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        datagr.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        datagr.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter







#Region "Conteo de cantidad de equipos"

        labe1.Visible = True
        labe1.Text = "Cantidad: " & datagr.RowCount
        conteo = datagr.RowCount
#End Region
        'Desactiva el autofiltro
        Dim col As Integer

        For col = 0 To datagr.Columns.Count - 1

            datagr.Columns(col).SortMode = DataGridViewColumnSortMode.NotSortable

        Next
        'Desactiva el autofiltro
    End Sub
    Sub CheckSoloEditable()
        'Desabilita todo el datagridview contra escritura excepto con el checkbox
        For cole As Integer = 0 To datagr.Columns.Count - 1
            If Not cole = 0 Then
                datagr.Columns(cole).ReadOnly = True
            End If
        Next
        'Desabilita todo el datagridview contra escritura excepto con el checkbox
    End Sub


    Sub marcarCheck()
        'Selecciona el checkbox dependiente de la columna estado
#Region "Marcar checkbox con informacion de SQL"
        For Each Row As DataGridViewRow In datagr.Rows

            If Row.Cells(4).Value = 1 Then  ' suponiendo que sea la ultima columna
                Row.Cells(0).Value = True ' suponiendo que sea la columna del check
            Else
                Row.Cells(0).Value = False
            End If
        Next
#End Region
    End Sub

    Sub marcarEstado()

        'Cambia el valor de estado en datagridview
        If datagr.CurrentCell.Value = True Then

            datagr.CurrentRow.Cells.Item(4).Value = 1
        Else
            datagr.CurrentRow.Cells.Item(4).Value = 0
        End If
        'Cambia el valor de estado en datagridview

    End Sub

    Sub cheackActualizarSql()

        Dim celda As String = datagr.CurrentRow.Cells.Item(1).Value
        Dim estado As String = datagr.CurrentRow.Cells.Item(4).Value
        Dim actualizarRealizado As New SqlCommand("update Shutdowns set Estado=" & estado & " where Conteo=" & celda & " ", cn)
        'TextBox1.Text = actualizarnombre.CommandText
        conectar()
        actualizarRealizado.ExecuteNonQuery()
        desconectar()

    End Sub

    Sub shutdown()



#Region "Configuracion datagridview1"
        conectar()

        Dim conteo As String
        conteo = 1

#Region "Formato de letra"

        datagr.DefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)
        datagr.ColumnHeadersDefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)

#End Region
        '        datagr.RowTemplate.Height = 30
        '#Region "Color de los titulos"
        '        datagr.ColumnHeadersDefaultCellStyle.BackColor = Color.SlateGray
        '        datagr.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        '#End Region
        '#Region "Cambios de color celdas y alternadas"
        '        datagr.RowsDefaultCellStyle.BackColor = Color.LightGray
        '        datagr.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray

        '#End Region
#Region "Alineacion de titulos"
        datagr.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
#End Region
#End Region

#Region "Buscar la planificacion"




        Dim adaptador As New SqlDataAdapter("Select*from Shutdowns", cn)
        Dim dataS As New DataSet
        adaptador.Fill(dataS, "ConteoPlanificacion_Equipos")

        datagr.DataSource = dataS.Tables("ConteoPlanificacion_Equipos")
        Dim columncheck As New DataGridViewCheckBoxColumn
        columncheck.HeaderText = "Realizado"
        columncheck.Name = "cerrar"
        datagr.Columns.Add(columncheck)
#End Region


        '#Region "Configuracion tabla"
        datagr.Columns(0).Visible = False
        datagr.Columns(3).Visible = False
        datagr.Columns(4).Visible = False
        datagr.RowHeadersVisible = False


        datagr.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        datagr.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        datagr.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        datagr.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '        datagr.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '        datagr.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '        datagr.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '        datagr.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '        datagr.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '        datagr.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '        datagr.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '        datagr.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '        datagr.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '        datagr.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter



        '        datagr.Columns(1).Width = 225


        '        datagr.Columns(2).Width = 110
        '        datagr.Columns(3).Width = 110
        '        datagr.Columns(4).Width = 110
        '        datagr.Columns(5).Width = 110
        '        datagr.Columns(6).Width = 110
        '        datagr.Columns(7).Width = 110
        '        datagr.Columns(8).Width = 110
        '        datagr.Columns(9).Width = 110
        '        datagr.Columns(10).Width = 110
        '        datagr.Columns(11).Width = 110
        '        datagr.Columns(12).Width = 110
        '        datagr.Columns(13).Width = 110




        '#End Region


#Region "Conteo de cantidad de equipos"

        labe1.Visible = True
        labe1.Text = "Cantidad: " & datagr.RowCount
        conteo = datagr.RowCount
#End Region



    End Sub

    Sub usuarios()

#Region "Cargar datos en combobox de Responsable"
        Try

            Dim cmd3 As String = "select*from Usuarios"
            Dim da3 As New SqlDataAdapter(cmd3, cn)
            Dim ds3 As New DataSet

            da3.Fill(ds3)
            With usuario
                usuario.DataSource = ds3.Tables(0)
                usuario.DisplayMember = "Nombre"
            End With
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
#End Region

    End Sub
End Module

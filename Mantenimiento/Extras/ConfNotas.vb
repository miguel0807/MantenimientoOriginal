Imports System.Data.SqlClient
Module ConfNotas

    'Declaracion de variables



    Public txtTexto As TextBox

    Public btnAgregar As Button
    Public btnEliminar As Button

    Public dtg1 As DataGridView

    Public cboResponsable2 As ComboBox

    Public lblConteo As Label

    Sub CrearNota()

#Region "Insertar información en notas "
        Dim adaptador1 As New SqlCommand("insert into Notas values('" & txtTexto.Text & "','" & cboResponsable2.Text & "','" & Date.Now & "')", cn)
        conectar()
        'MsgBox(adaptador1.CommandText)

        adaptador1.ExecuteNonQuery()
        desconectar()
        MsgBox("Nota agregada correctamente")


#End Region
    End Sub

    Sub CargarInformación()

#Region "Buscar la planificacion"
        conectar()
        Dim conteo As String = 1
        Dim adaptador As New SqlDataAdapter("select*from Notas", cn)
        Dim dataS As New DataSet
        adaptador.Fill(dataS, "Carga")
        dtg1.DataSource = dataS.Tables("Carga")

#End Region

#Region "Diseño Datagridview"
#Region "Formato de letra"
        dtg1.EnableHeadersVisualStyles = False
        dtg1.DefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)
        dtg1.ColumnHeadersDefaultCellStyle.Font = New Font("Mircrosoft Sans Serif", 15)
        dtg1.RowTemplate.Height = 30

#End Region

#Region "Color de los titulos"
        dtg1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 51, 51)
        dtg1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51)
        dtg1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dtg1.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(218, 218, 218)
        dtg1.RowsDefaultCellStyle.SelectionForeColor = Color.Black
#End Region

#Region "Cambios de color celdas y alternadas"
        dtg1.RowsDefaultCellStyle.BackColor = Color.White
        dtg1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control)

#End Region

#Region "Alineacion de titulos y columnas"
        dtg1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dtg1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dtg1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dtg1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
#End Region

#Region "Configuración Datagridview"
        dtg1.RowHeadersVisible = False
        dtg1.Columns(0).Visible = False

#Region "Desactivación autofiltro de columnas"
        Dim col As Integer
        For col = 0 To dtg1.Columns.Count - 1

            dtg1.Columns(col).SortMode = DataGridViewColumnSortMode.NotSortable

        Next
#End Region
#End Region



#End Region

#Region "Contar cantidad de notas"
        lblConteo.Visible = True
        lblConteo.Text = "Cantidad: " & dtg1.RowCount
        conteo = dtg1.RowCount
#End Region

    End Sub

    Sub cargarCboResponsable()

#Region "Cargar datos en combobox de Responsable"

        Dim cmd3 As String = "select*from Usuarios"
        Dim da3 As New SqlDataAdapter(cmd3, cn)
        Dim ds3 As New DataSet
        da3.Fill(ds3)
        With cboResponsable2
            cboResponsable2.DataSource = ds3.Tables(0)
            cboResponsable2.DisplayMember = "Nombre"
        End With
        cn.Close()



#End Region

    End Sub

    Sub EliminarTareaNotas()
        Dim msgvalue As Integer
        msgvalue = MsgBox("Está seguro de eliminar la nota?", vbInformation + vbYesNo, "Mensaje de Alerta")
        Select Case msgvalue
            Case 6 'Si
                conectar()
                Dim comando As New SqlCommand("delete from Notas where id =" & dtg1.CurrentRow.Cells.Item(0).Value.ToString() & " ", cn)
                comando.ExecuteNonQuery()
                desconectar()
                MsgBox("Se elimino correctamente")
            Case 7 'No

        End Select
    End Sub
End Module

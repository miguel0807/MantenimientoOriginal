Imports System.Data.SqlClient
Public Class Planificacion_Tareas

    Dim clasecodigo As Integer
    Dim mes As String


    ' Dim Año As Integer


    Private Sub Planificacion_Tareas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not formularios.Contains(Me) Then formularios.Add(Me) 'Agrega a la lista los formularios para luego cerrarlos

#Region "Cargar en comboBox las clases"

        Try
            Dim cmd As String = "select*from Caracteristicas_Equipo"
            Dim da As New SqlDataAdapter(cmd, cn)
            Dim ds As New DataSet
            da.Fill(ds)
            With Clase
                Clase.DataSource = ds.Tables(0)
                Clase.DisplayMember = "Clase"
            End With

            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
#End Region

#Region "Cargar comboBox con los años"
        Try
            Dim cmd As String = "select*from Año_Datos"
            Dim da As New SqlDataAdapter(cmd, cn)
            Dim ds As New DataSet
            da.Fill(ds)
            With Me.año
                Me.año.DataSource = ds.Tables(0)
                Me.año.DisplayMember = "Año"
            End With

            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
#End Region

#Region "Cargar MES"
        Try
            Dim cmd As String = "select*from Meses_Datos"
            Dim da As New SqlDataAdapter(cmd, cn)
            Dim ds As New DataSet
            da.Fill(ds)
            With Meses
                Meses.DataSource = ds.Tables(0)
                Meses.DisplayMember = "Meses"
            End With

            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
#End Region
    End Sub

    Private Sub Clase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Clase.SelectedIndexChanged
#Region "Verificar etiquetas"
        'En el parentesis entre & & se coloca cual valor se usara para la busqueda
        Dim adaptador As New SqlDataAdapter("select*from Caracteristicas_Equipo where CONVERT(char,Clase)='" & Clase.Text & "'", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "Codigo")

        'El item selecciona de cual columna de la base de datos se conectara y row es la fila
        If ds.Tables("Codigo").Rows.Count > 0 Then

            clasecodigo = ds.Tables("Codigo").Rows(0).Item(0).ToString
            SQLCodigo = clasecodigo

        End If
#End Region

#Region "Cargar datos en combobox de Etiqueta"

        Dim cmd1 As String = "select*from Lista_Equipos where Codigo=" & clasecodigo & ""
        Dim da1 As New SqlDataAdapter(cmd1, cn)
        Dim ds1 As New DataSet
        da1.Fill(ds1)
        With Etiqueta
            Me.Etiqueta.DataSource = ds1.Tables(0)
            Me.Etiqueta.DisplayMember = "Etiqueta"
        End With
        cn.Close()

#End Region
        Etiqueta.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SQLEtiqueta = Etiqueta.Text
        SQLAño = Año.Text
        SQLMes = Meses.Text

        Me.DataGridView2.Select()



        datagr = DataGridView2
        labe1 = Label4
        RevisarTareas()

        Me.DataGridView1.Select()
        datagr = DataGridView1
        labe1 = Label5
        CargarPendientesTareas()





    End Sub



    Private Sub Crear_Click(sender As Object, e As EventArgs) Handles Crear.Click
        Me.DataGridView2.Select()
        SQLCodTarea = DataGridView2.CurrentRow.Cells.Item(0).Value.ToString



#Region "Insertar en la lista de equipos la informacion del nuevo equipo"
        Dim adaptador1 As New SqlCommand("insert into Historial_Tareas values(" & SQLCodTarea & "," & SQLCodigo & ",'" & SQLEtiqueta & "','N/A','Sin asignar'," & SQLAño & ",'" & SQLMes & "','1/1/1900','N/A',0)", cn)
        conectar()
        'MsgBox(adaptador1.CommandText)

        adaptador1.ExecuteNonQuery()
        desconectar()
        MsgBox("Tarea agregada correctamente")


#End Region

        Me.DataGridView1.Select()
        datagr = DataGridView1
        labe1 = Label5
        CargarPendientesTareas()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DataGridView1.Select()
        SQLSumar = DataGridView1.CurrentRow.Cells.Item(1).Value.ToString
        BorrarTarea()

        Me.DataGridView1.Select()
        datagr = DataGridView1
        labe1 = Label5
        CargarPendientesTareas()

    End Sub

    Private Sub Meses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Meses.SelectedIndexChanged

    End Sub
End Class
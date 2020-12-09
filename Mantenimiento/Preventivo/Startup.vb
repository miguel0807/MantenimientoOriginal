﻿Imports System.Data.SqlClient
Imports Mantenimiento.Startup


Public Class Startup




    Private Sub Startup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not formularios.Contains(Me) Then formularios.Add(Me) 'Agrega a la lista los formularios para luego cerrarlos



        datagr = DataGridView1
        labe1 = Label1

        usuario = ComboBox1


        usuarios()


        labelFecha = Label2
        LoadFechaEscrita()


        nombre = ComboBox1


        bCargar = Cargar

        label5 = Label3
        label6 = Label4
        combo1 = ComboBox1

        historial = "Hist_Startup"
        hisInteger = 1
    End Sub




    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex < 0 Or Not e.ColumnIndex = 0 Then Exit Sub
        If Convert.ToBoolean(datagr.Rows(e.RowIndex).Cells(0).Value) Then
            datagr.Rows(e.RowIndex).Cells(0).Value = False
        Else
            datagr.Rows(e.RowIndex).Cells(0).Value = True
        End If

        marcarEstado()
        cheackActualizarSql()
        cheackActualizarSQLComentarios()
        cheackActualizarSQLusuario()





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Cont As Integer = 0
        For Each Row As DataGridViewRow In datagr.Rows
            If Convert.ToBoolean(Row.Cells(0).Value) = True Then ' Si chekee una fila de la grilla
                Cont += 1
                ' aqui tu procedimiento para guardar
            End If
        Next

        ' Al final obtienes la cantidad de registros marcados
        MsgBox(Cont)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

        crearHistorial()
        CheckColumna()
        startupDatagridview()
        CheckSoloEditable()
        marcarCheck()



        ' puebaTabla()

    End Sub


    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick

        'Convierte el check en formato boolean sea false o true
        If e.RowIndex < 0 Or Not e.ColumnIndex = 0 Then Exit Sub
        If Convert.ToBoolean(datagr.Rows(e.RowIndex).Cells(0).Value) Then
            datagr.Rows(e.RowIndex).Cells(0).Value = False
        Else
            datagr.Rows(e.RowIndex).Cells(0).Value = True
        End If
        'Convierte el check en formato boolean sea false o true


        marcarEstado()

        cheackActualizarSql()
        cheackActualizarSQLComentarios()
        cheackActualizarSQLusuario()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        DerechaFecha()
        '  crearHistorial()
        CheckColumna()
        startupDatagridview()
        CheckSoloEditable()
        marcarCheck()

        VisibleBotonCargar()




    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        IzquierdaFecha()

        '  crearHistorial()
        CheckColumna()
        startupDatagridview()
        CheckSoloEditable()
        marcarCheck()
        VisibleBotonCargar()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        LoadFechaEscrita()

        'crearHistorial()
        CheckColumna()
        startupDatagridview()
        CheckSoloEditable()
        marcarCheck()

        VisibleBotonCargar()

    End Sub



    Private Sub Cargar_Click(sender As Object, e As EventArgs) Handles Cargar.Click
        crearHistorial()
        CheckColumna()
        startupDatagridview()
        CheckSoloEditable()
        marcarCheck()
        VisibleBotonCargar()

    End Sub


End Class
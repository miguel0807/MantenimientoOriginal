Public Class Nueva_Tarea
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Complete todos los campos para continuar")
            Exit Sub

        End If

        ntarea = TextBox2.Text
        nequipo = TextBox1.Text
        If RadioButton1.Checked = True Then
            st_sh = 1 'Startup
        Else
            st_sh = 0 'Shutdown

        End If
        nuevaTarea()

        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        datagr = DataGridView1
        labe1 = Label1
        startupCheck = 1
        nuevaTareaDatagridview()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        datagr = DataGridView1
        labe1 = Label1
        startupCheck = 0
        nuevaTareaDatagridview()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Nueva_Tarea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not formularios.Contains(Me) Then formularios.Add(Me) 'Agrega a la lista los formularios para luego cerrarlos

    End Sub
End Class
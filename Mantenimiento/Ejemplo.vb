Imports System.Data.SqlClient
Public Class Ejemplo

    Private Sub BTN_Registrar_Click(sender As Object, e As EventArgs) Handles BTN_Registrar.Click
        Dim conexion As String
        conexion = "Data Source=MAT-COS-DB-10Z2\SQLEXPRESS;Initial Catalog=Inventario;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion


        Dim adaptador As New SqlCommand("insert into Usuarios values (" & txt_codigo.Text & ",'" & txt_nombre.Text & "','" & txt_apePaterno.Text & "','" & txt_apeMaterno.Text & "','" & Cbo_genero.Text & "')", cn)
        cn.Open()
        adaptador.ExecuteNonQuery()
        MsgBox("Se registro correctamente")

        txt_apeMaterno.Text = ""
        txt_apePaterno.Text = ""
        txt_codigo.Text = ""
        txt_nombre.Text = ""
        Cbo_genero.Text = ""



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Esta es la cadena de conexion siempre hay que usarla para conectarse
        Dim conexion As String
        conexion = "Data Source=MAT-COS-DB-10Z2\SQLEXPRESS;Initial Catalog=Inventario;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        'Esta es la cadena de conexion siempre hay que usarla para conectarse "LLega hasta aqui"




        'En el parentesis entre & & se coloca cual valor se usara para la busqueda
        Dim adaptador As New SqlDataAdapter("select*from Usuarios where Codigo=" & txt_codigoA.Text & "", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "datos")

        'El item selecciona de cual columna de la base de datos se conectara y row es la fila
        If ds.Tables("datos").Rows.Count > 0 Then
            txt_nombreA.Text = ds.Tables("datos").Rows(0).Item(1).ToString
            txt_apePaternoA.Text = ds.Tables("datos").Rows(0).Item(2).ToString
            TXT_apeMaternoA.Text = ds.Tables("datos").Rows(0).Item(3).ToString
            Cbo_GeneroA.Text = ds.Tables("datos").Rows(0).Item(4).ToString
        Else
            MsgBox("Usuario no existe")

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Esta es la cadena de conexion siempre hay que usarla para conectarse
        Dim conexion As String
        conexion = "Data Source=MAT-COS-DB-10Z2\SQLEXPRESS;Initial Catalog=Inventario;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        'Esta es la cadena de conexion siempre hay que usarla para conectarse "LLega hasta aqui"

        Dim adaptador As New SqlCommand("update Usuarios set Nombre='" & txt_nombreA.Text & "',Apellido_Paterno='" & txt_apePaternoA.Text & "' where Codigo = " & txt_codigoA.Text & " ", cn)
        cn.Open()
        adaptador.ExecuteNonQuery()
        MsgBox("Datos Actualizados")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Esta es la cadena de conexion siempre hay que usarla para conectarse
        Dim conexion As String
        conexion = "Data Source=MAT-COS-DB-10Z2\SQLEXPRESS;Initial Catalog=Inventario;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        'Esta es la cadena de conexion siempre hay que usarla para conectarse "LLega hasta aqui"




        'En el parentesis entre & & se coloca cual valor se usara para la busqueda
        Dim adaptador As New SqlDataAdapter("select*from Usuarios where Codigo=" & txt_codigoE.Text & "", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "datos")

        'El item selecciona de cual columna de la base de datos se conectara y row es la fila
        If ds.Tables("datos").Rows.Count > 0 Then
            txt_nombreE.Text = ds.Tables("datos").Rows(0).Item(1).ToString
            txt_apePaternoE.Text = ds.Tables("datos").Rows(0).Item(2).ToString
            txt_apeMaternoE.Text = ds.Tables("datos").Rows(0).Item(3).ToString
            Cbo_generoE.Text = ds.Tables("datos").Rows(0).Item(4).ToString
        Else
            MsgBox("Usuario no existe")

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Esta es la cadena de conexion siempre hay que usarla para conectarse
        Dim conexion As String
        conexion = "Data Source=MAT-COS-DB-10Z2\SQLEXPRESS;Initial Catalog=Inventario;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        'Esta es la cadena de conexion siempre hay que usarla para conectarse "LLega hasta aqui"
        cn.Open()


        Dim comando As New SqlCommand("delete from Usuarios where Codigo =" & txt_codigoE.Text & " ", cn)
        comando.ExecuteNonQuery()

        MsgBox("Se elimino correctamente")

        txt_apeMaternoE.Text = ""
        txt_apePaternoE.Text = ""
        txt_codigoE.Text = ""
        txt_nombreE.Text = ""
        Cbo_generoE.Text = ""

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Esta es la cadena de conexion siempre hay que usarla para conectarse
        Dim conexion As String
        conexion = "Data Source=MAT-COS-DB-10Z2\SQLEXPRESS;Initial Catalog=Inventario;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        'Esta es la cadena de conexion siempre hay que usarla para conectarse "LLega hasta aqui"
        cn.Open()

        'Configuro el showDialog
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Text Files|*.txt"

        'Abro showdialog
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then 'Si ok procede y declara direccion de txt
            Dim direccion As String
            direccion = "'" + OpenFileDialog1.FileName + "'" 'Se agregar ' para escribir en sql
            Try
                'Se inserta datos de txt hacia tabla llamada Temporal
                Dim prueba As New SqlCommand("BULK INSERT Temporal FROM" & direccion & "WITH(FIELDTERMINATOR = '\t',ROWTERMINATOR = '\n')", cn)
                prueba.ExecuteNonQuery()

                MsgBox("Se cargo correctamente")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try



        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Registrar_Click(sender As Object, e As EventArgs) Handles Registrar.Click

    End Sub
End Class
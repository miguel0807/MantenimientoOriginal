Imports System.Data.SqlClient
Imports Mantenimiento.Startup


Public Class Startup



    Private Sub Startup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datagr = DataGridView1
        labe1 = Label1
        MOstartup.generalaño()
    End Sub
End Class
Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
    Private Sub btnCreateAcct_Click(sender As Object, e As EventArgs) Handles btnCreateAcct.Click

        Dim CreateAcct As New CreateAccountForm
        CreateAcct.ShowDialog()



    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim userLogin As New LoginForm
        userLogin.ShowDialog()

    End Sub
End Class

Imports System.Data
Imports System.Data.SqlClient
Public Class LoginForm
    Private Sub Login_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim userLogin As String
        Dim userPW As String

        'check if user info matches database
        Using myconn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\johnd\Documents\.Net framework\StoreProjectDB\DB\CustomerAccounts.mdf;Integrated Security=True;Connect Timeout=30"),
                    mycmd As New SqlCommand("Select * from Customer_T where CustomerEmail = @email") 'Query
            mycmd.Parameters.Add("@email", SqlDbType.VarChar)
            mycmd.Parameters("@state").Value = txtEmail.Text


            'open connection
            myconn.Open()

            mycmd.Connection = myconn
            Dim myadapter As New SqlDataAdapter
            myadapter.SelectCommand = mycmd

        End Using

        'if valid then return to mainpage

        'else 
        lblError.Show()

    End Sub

    Private Sub ForgotPW_Click(sender As Object, e As EventArgs) Handles lblForgotPW.Click
        Dim recovery As New RecoveryForm
        recovery.Show()


    End Sub
End Class
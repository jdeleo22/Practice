Imports System.Data
Imports System.Data.SqlClient
Public Class RecoveryForm
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim userEmail As String

        userEmail = txtEmail.Text

        ' check if useremail is in database
        Using myconn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\johnd\Documents\.Net framework\StoreProjectDB\DB\CustomerAccounts.mdf;Integrated Security=True;Connect Timeout=30"),
                    mycmd As New SqlCommand("Select * from Customer_T where CustomerEmail = @email") 'Query
            mycmd.Parameters.Add("@email", SqlDbType.VarChar)
            mycmd.Parameters("@email").Value = txtEmail.Text


            'open connection
            myconn.Open()

            mycmd.Connection = myconn

            Dim myadapter As New SqlDataAdapter With {
           .SelectCommand = mycmd
           }


        End Using


        'if exists then
        MessageBox.Show("Recovery Email has been sent")
        'send email?


        'else
        MessageBox.Show("Email not registered")
    End Sub
End Class
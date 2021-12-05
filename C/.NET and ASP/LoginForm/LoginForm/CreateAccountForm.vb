Imports System.Data
Imports System.Data.SqlClient
Public Class CreateAccountForm

    'use accountinfo form 
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        ' declare input vars
        Dim cusName As String
        Dim cusEmail As String
        Dim cusPW As String
        Dim cusConfirmPW As String

        'take inputs from user
        cusName = txtName.Text
        cusEmail = txtEmail.Text
        cusPW = txtPW.Text
        cusConfirmPW = txtConfirmPW.Text

        'check database for existing email

        'validate pw
        If ValidPassword(cusPW) Then
            ' Valid

            'compare PWs
            If String.Equals(cusPW, cusConfirmPW) Then
                'store info into database
                'make connection
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




                ' open main page

            Else
                lblError.Text = "Passwords must match"

            End If


        Else
            'Invalid
            lblError.Text = "Invalid Password. Must be at least 8 characters," & vbCrLf & "1 number, and 1 uppercase"

        End If
    End Sub

    Function ValidPassword(userPW As String) As Boolean
        If userPW.Length < 8 Then Return False 'more than 8 chars
        '.any checks if any in sequence satisfies condition
        If Not userPW.Any(Function(c) Char.IsDigit(c)) Then Return False    'must have digit
        If Not userPW.Any(Function(c) Char.IsLower(c)) Then Return False    'lowercase
        If Not userPW.Any(Function(c) Char.IsUpper(c)) Then Return False    'uppercase
        Return True
    End Function

End Class
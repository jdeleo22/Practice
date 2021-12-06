using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DB
/// </summary>
public class DB
{
    DataTable mytable = new DataTable();
    SqlConnection myconn = new SqlConnection();
    SqlTransaction mytxn;

    public DB()
    {
        myconn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\johnd\\Documents\\.Net framework\\PVFC\\PVFC.mdf;Integrated Security=True;Connect Timeout=30";   //name of db, type of db, userid, pw, security lvls, timeouts
        myconn.Open();
    }
    public DataTable getAllProducts()
    {
        SqlCommand mycommand = new SqlCommand();
        mycommand.CommandText = " Select * from Product_T ";
        mycommand.Connection = myconn;
        SqlDataAdapter myadapter = new SqlDataAdapter();
        myadapter.SelectCommand = mycommand;
        DataTable mytable = new DataTable();
        myadapter.Fill(mytable);
        return mytable;

    }
}
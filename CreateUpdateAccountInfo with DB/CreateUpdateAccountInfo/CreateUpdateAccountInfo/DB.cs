using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CreateUpdateAccountInfo
{
    class DB
    {
        DataTable mydt;
        SqlConnection myconn;
        SqlCommand mycmd;
        SqlDataAdapter myadapter;
        String type;

        public DB()
        {
            myconn = new SqlConnection();
            myconn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\johnd\\Documents\\SupplyStoreDB.mdf;Integrated Security=True;Connect Timeout=30";
            myconn.Open();

            //Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\johnd\\Documents\\SupplyStoreDB.mdf;Integrated Security=True;Connect Timeout=30
        }

        public DataTable getAccountInfo(int ID)
        {
            mycmd = new SqlCommand();
            mycmd.CommandText = "select * from CustomerInfo_T where Id = " + "'" + ID + "'";
            mycmd.Connection = myconn;
            myadapter = new SqlDataAdapter();
            myadapter.SelectCommand = mycmd;
            mydt = new DataTable();
            myadapter.Fill(mydt);
            return mydt;
        }

        public void updateAccountInfo(int ID,String fName,String lName,String Address,String city,String state,String email)
        {

            //update
            mycmd = new SqlCommand();
            mycmd.CommandText = "Update CustomerInfo_T set CustomerFirstName = '" + fName +"', CustomerLastName = '"+ lName + "', CustomerAddress = '" +Address+
                "', CustomerCity = '"+city+"', CustomerState = '"+state+"', CustomerEmail = '"+email+"' where Id = '"+ID+"'";
            mycmd.Connection = myconn;
            myadapter = new SqlDataAdapter();
            myadapter.UpdateCommand = mycmd;


        }

        public void createAccount(String fName, String lName, String pass, String Address, String email, String city, String state, String postal, String country)
        {
            
            mycmd = new SqlCommand();

            mycmd.CommandText = "Insert INTO CustomerInfo_T (CustomerFirstName, CustomerLastName, CustomerPassword, CustomerAddress, CustomerEmail, CustomerCity, CustomerState, CustomerPostal, CustomerCountry) Values "+
            "('"+fName+"', '"+lName+"', '"+pass+"', '"+Address+"', '"+email+"', '"+city+"', '"+state+"', '"+postal+"', '" +country+"')";

            mycmd.Connection = myconn;
            myadapter = new SqlDataAdapter();
            myadapter.InsertCommand = mycmd;

        }

    }
}

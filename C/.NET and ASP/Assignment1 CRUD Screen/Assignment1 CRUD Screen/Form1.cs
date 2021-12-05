using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace Assignment1_CRUD_Screen
{
    public partial class Form1 : Form
    {

        
       

     SqlCommand mycmd;
        DataTable mydt;
        SqlConnection myconn;
        SqlDataAdapter myadapter;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            
            myconn = new SqlConnection();
            myconn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\johnd\\Documents\\.Net framework\\PVFC\\PVFC.mdf;Integrated Security=True;Connect Timeout=30";   //name of db, type of db, userid, pw, security lvls, timeouts
            myconn.Open();


            mycmd = new SqlCommand();
            mycmd.CommandType = CommandType.StoredProcedure;
            mycmd.CommandText = "SelectAllProducts";

            mycmd.Connection = myconn;

            myadapter = new SqlDataAdapter();
            myadapter.SelectCommand = mycmd;

            mydt = new DataTable();
            myadapter.Fill(mydt);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = mydt;

            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            mycmd = new SqlCommand();
            mycmd.Connection = myconn;
            //desc finish price

            //update
            mycmd.CommandText = "Update Product_T set ProductDescription = @ProductDesc, ProductFinish = @ProductFinish, ProductStandardPrice = @ProductPrice where ProductID=@id";

            mycmd.Parameters.Add("@ProductDesc", SqlDbType.VarChar, 50, "ProductDescription");
            mycmd.Parameters.Add("@ProductFinish", SqlDbType.VarChar, 50, "ProductFinish");
            mycmd.Parameters.Add("@ProductPrice", SqlDbType.VarChar, 50, "ProductStandardPrice");
            mycmd.Parameters.Add("@id", SqlDbType.Int, 50, "ProductID");
            myadapter.UpdateCommand = mycmd;

            //delete
            mycmd = new SqlCommand();
            mycmd.Connection = myconn;
            mycmd.CommandText = "Delete Product_T where ProductID=@id ";
            mycmd.Parameters.Add("@id", SqlDbType.Int, 50, "ProductID");
            myadapter.DeleteCommand = mycmd;

            //insert
            mycmd = new SqlCommand();
            mycmd.Connection = myconn;
            mycmd.CommandText = "Insert INTO Product_T (ProductDescription, ProductFinish, ProductStandardPrice) Values (@ProductDesc, @ProductFinish, @ProductPrice)";

            mycmd.Parameters.Add("@ProductDesc", SqlDbType.VarChar, 50, "ProductDescription");
            mycmd.Parameters.Add("@ProductFinish", SqlDbType.VarChar, 50, "ProductFinish");
            mycmd.Parameters.Add("@ProductPrice", SqlDbType.VarChar, 50, "ProductStandardPrice");
            myadapter.InsertCommand = mycmd;


            try
            {
                myadapter.Update(mydt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Updated record is outdated, reload then try again" + ex);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            myconn = new SqlConnection();
            myconn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\johnd\\Documents\\.Net framework\\PVFC\\PVFC.mdf;Integrated Security=True;Connect Timeout=30";   //name of db, type of db, userid, pw, security lvls, timeouts
            myconn.Open();


            mycmd = new SqlCommand();
            mycmd.CommandType = CommandType.Text;
             //mycmd.CommandType = CommandType.StoredProcedure;
            //mycmd.CommandText = "SearchProductDesc";
            
            //lblTest.Text = 
            mycmd.CommandText = "Select ProductDescription, ProductStandardPrice, ProductFinish from Product_T where ProductDescription like @description";
            mycmd.Parameters.Add("@description", SqlDbType.VarChar);
            mycmd.Parameters["@description"].Value = "%" + txtSearchDesc.Text + "%";
            //wildcard %%
            //mycmd.Parameters["@description"].Value = "%" + textBox1.Text + "%";

            mycmd.Connection = myconn;
    
            myadapter = new SqlDataAdapter();
            myadapter.SelectCommand = mycmd;

            mydt = new DataTable();
            myadapter.Fill(mydt);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = mydt;
        }

        
        private void btnAverage_Click(object sender, EventArgs e)
        {

            //display average
            int sum = 0;
            int average = 0;
            int rows = dataGridView1.Rows.Count;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);

            }
            
            average = sum / rows;

            lblAvgDisplay.Text = average.ToString();
        }
    }
}

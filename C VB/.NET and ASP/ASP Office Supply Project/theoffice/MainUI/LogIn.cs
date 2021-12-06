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


namespace MainUI
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection mysqlcon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\liaba\\OneDrive\\Desktop\\4708\\theoffice\\SupplyStoreDB.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter myadp = new SqlDataAdapter("select * from CustomerInfo_T where CustomerEmail = '" + textBox1.Text + "' and CustomerPassword='" + textBox2.Text + "'", mysqlcon);
            DataTable dtbl = new DataTable();
            myadp.Fill(dtbl);
           
               
            
            if (dtbl.Rows.Count == 1)
            {




                this.Hide();
                Products mf = new Products();
                mf.Show();
               
            }
            else
            {
                MessageBox.Show("Check Your Info");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome backto = new Welcome();
            backto.Show();


        }

      
    }
}

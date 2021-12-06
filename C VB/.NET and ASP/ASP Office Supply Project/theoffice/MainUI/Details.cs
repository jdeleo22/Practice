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
    public partial class Details : Form
    {

        DataTable mydt;
        DB mydb;
        public Details(int  ID)
        {
            InitializeComponent();
            mydb = new DB();
            mydt = mydb.getDetails(ID);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = mydt;


        }

        private void button2_Click(object sender, EventArgs e)
        {
           // var newForm = new ShoppingCart();
            //newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newForm = new LogIn();
            newForm.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var newForm = new CreateAccount();
            newForm.Show();

        }
    }
}

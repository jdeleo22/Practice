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
    public partial class Products : Form

    {
        
        DataTable mydt;
        DB mydb;
        
        public Products()
        {
            InitializeComponent();
            mydb = new DB();
            mydt = mydb.getAllProducts();
           dataGridView1.AutoGenerateColumns = false;
           dataGridView1.DataSource = mydt;
        }

            

        private void pensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mydt = mydb.getAllPens();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = mydt;
        }

        private void papersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mydt = mydb.getAllPapers();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = mydt;
        }

        private void officeDevicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mydt = mydb.getAllOfficeDevicess();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = mydt;
        }

        private void schoolSuppliesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mydt = mydb.getAllSchoolSupplies();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = mydt;
        }

        private void officeFurnitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mydt = mydb.getAllOfficeFurniture();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = mydt;
        }

        private void printersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mydt = mydb.getAllPrinters();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = mydt;

        }

        private void allProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            mydt = mydb.getAllProducts();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = mydt;
        }

     

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // String value = dataGridView1.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
            int ID = (int)dataGridView1.Rows[e.RowIndex].Cells["ProductID"].Value;
           


            var newForm = new Details(ID);
            newForm.Show();
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            var newForm = new LogIn();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new CreateAccount();
            newForm.Show();
        }
    }
}

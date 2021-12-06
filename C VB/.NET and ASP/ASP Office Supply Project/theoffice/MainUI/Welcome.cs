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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sales!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Products!");
            var newForm = new Products();
            newForm.Show();
               
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Login!");
            var newForm = new LogIn();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Create a new account!");
            var newForm = new CreateAccount();
            newForm.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainUI
{
    public partial class CreateAccount : Form
    {
        DataTable mydt;
        DB mydb;
        public CreateAccount()
        {
            InitializeComponent();
            mydb = new DB();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //take info from textboxes
            String firstName = txtFirstName.Text;
            String lastName = txtLastName.Text;
            String address = txtAddress.Text;
            String city = txtCity.Text;
            String state = txtState.Text;
            String email = txtEmail.Text;
            String postal = txtPostal.Text;
            String password = txtPassword.Text;
            String country = txtCountry.Text;

            try
            {
                mydb.createAccount(firstName, lastName, password, address, email, city, state, postal, country);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Account not Created" + ex);
            }
            

        }
    }
}

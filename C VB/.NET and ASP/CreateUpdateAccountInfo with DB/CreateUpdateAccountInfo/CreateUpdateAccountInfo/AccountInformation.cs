using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateUpdateAccountInfo
{
    public partial class AccountInformation : Form
    {
        DataTable mydt;
        DB mydb;
        public AccountInformation()
        {
            InitializeComponent();
            mydb = new DB();
        }

        private void AccountInformation_Load(object sender, EventArgs e)
        {
           // String firstName, lastName, custAddress, custEmail, custCity, custState, custPostal, custCountry, custPass = "";

            //take account information from session logged in user table

            DataTable usertable = (DataTable)Session["LoggedInUser"];

            //or by ID with getAccountInfo(int ID)
            //returns table with logged in user based on ID then populate form


            //fill form with values
            if (usertable.Rows.Count > 0)
            {
                DataRow row = usertable.Rows[0];

                txtFirstName.Text = row["CustomerFirstName"].ToString();
                txtLastName.Text = row["CustomerLastName"].ToString();
                txtPassword.Text = row["CustomerPassword"].ToString();
                txtAddress.Text = row["CustomerAddress"].ToString();
                txtEmail.Text = row["CustomerEmail"].ToString();
                txtCity.Text = row["CustomerCity"].ToString();
                txtState.Text = row["CustomerState"].ToString();

            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccountForm updateform = new UpdateAccountForm();
            updateform.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

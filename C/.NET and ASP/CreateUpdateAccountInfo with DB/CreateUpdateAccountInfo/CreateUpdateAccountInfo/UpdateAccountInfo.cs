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
    public partial class UpdateAccountForm : Form
    {
        DataTable mydt;
        DB mydb;
        public UpdateAccountForm()
        {
            InitializeComponent();
            mydb = new DB();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //validate textboxes

            //take UserID from session
            DataTable usertable = (DataTable)Session["LoggedInUser"];
            
            DataRow row = usertable.Rows[0];
           int ID = (int)row["Id"];

            //take info from textboxes
            String firstName = txtFirstName.Text;
            String lastName = txtLastName.Text;
            String address = txtAddress.Text;
            String city = txtCity.Text;
            String state = txtState.Text;
            String email = txtEmail.Text;

            //update info
            try
            {
               mydb.updateAccountInfo(ID, firstName, lastName, address, city, state, email);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Account not Updated" + ex);
            }
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

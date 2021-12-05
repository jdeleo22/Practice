using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

    int invalidcount;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            invalidcount = 0;
            Session["NumFailures"] = "0";
        }
        else
        {
            invalidcount = Int32.Parse(Session["NumFailures"].ToString());
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (txtUsername.Text == txtPassword.Text)
        {
            // lblMessage.Text = "Successful Login";
            Session["Username"] = txtUsername.Text;
            Response.Redirect("Greetings.aspx?Username=" + txtUsername.Text);

        }
        else
        {
            lblMessage.Text = "Invalid Username or Password";
            invalidcount = invalidcount + 1;
            Session["NumFailures"] = invalidcount.ToString();
            if (invalidcount >= 3)
            {
                lblMessage.Text = "blocked";
            }
        }
    }
}
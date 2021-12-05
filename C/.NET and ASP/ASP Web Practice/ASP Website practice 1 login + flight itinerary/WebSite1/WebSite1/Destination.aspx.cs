using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Destination : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnViewItin_Click(object sender, EventArgs e)
    {
        Session["destination_description"] = ListBox1.SelectedItem.Text;
        Session["destination_code"] = ListBox1.SelectedItem.Value;

        Response.Redirect("Itinerary.aspx");
    }
}
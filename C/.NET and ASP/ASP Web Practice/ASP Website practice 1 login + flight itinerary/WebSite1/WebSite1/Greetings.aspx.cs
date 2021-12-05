using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Greetings : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblHello.Text = "Hello " + Request.QueryString["Username"];

        //populate cities listbox
        String[] CityTable = (String[])Application["cities"];
        for (int i = 0; i < CityTable.Length; i++)
        {
            ListBox1.Items.Add(CityTable[i]);
        }

    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["sourcecity_description"] = ListBox1.SelectedItem.Text;
        Session["sourcecity_code"] = ListBox1.SelectedItem.Value;

        Response.Redirect("Destination.aspx");

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Itinerary : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String sourcedesc, sourcecode, destdesc, destcode;
        sourcedesc = Session["sourcecity_description"].ToString();
        sourcecode = Session["sourcecity_code"].ToString();
        destdesc = Session["destination_description"].ToString();
        destcode = Session["destination_code"].ToString();
        Literal1.Text = "You are Travelling From: <b> <i>" +sourcedesc+ " </b> </i>" + "(" + sourcecode + ")";
        Literal1.Text = "You are Travelling From: <b> <i>" + destdesc + " </b> </i>" + "(" + destcode + ")";
    }
}
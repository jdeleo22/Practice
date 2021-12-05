using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnProducts_Click(object sender, EventArgs e)
    {
        DB mydb = new DB();
        DataTable webdatatable;
        webdatatable = mydb.getAllProducts();
        GridView1.DataSource = webdatatable;
        GridView1.DataBind();

        //save table to session


    }
}
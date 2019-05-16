using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NathanWeb.Admin
{
    public partial class Categories : System.Web.UI.Page
    {
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(dsCategories.ConnectionString))
            {
                var cmd = new SqlCommand("INSERT INTO categories (orderBy,name,active) VALUES (0,'',0)");
                cmd.ExecuteNonQuery();
            }
            gvCategories.DataBind();
        }
    }
}
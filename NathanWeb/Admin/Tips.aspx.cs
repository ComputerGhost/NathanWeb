using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NathanWeb.Admin
{
    public partial class Tips : System.Web.UI.Page
    {
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(dsTips.ConnectionString))
            {
                connection.Open();
                var cmd = new SqlCommand("INSERT INTO tips (orderBy,title,content,orderBy,active) VALUES (0,'','',0)", connection);
                cmd.ExecuteNonQuery();
            }
            gvTips.DataBind();
        }
    }
}
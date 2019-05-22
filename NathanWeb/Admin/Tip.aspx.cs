using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NathanWeb.Admin
{
    public partial class Tip : System.Web.UI.Page
    {
        public Tip()
        {
            Load += Page_Load;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var tipId = int.Parse(Request.Params["id"]);
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString))
            {
                connection.Open();

                var cmd = new SqlCommand("SELECT t.id,ISNULL(c.name,'') category,t.title,t.content FROM tips t LEFT JOIN categories c ON c.id=t.categoryId WHERE t.id=@id", connection);
                cmd.Parameters.AddWithValue("id", tipId);

                var dReader = cmd.ExecuteReader();
                dReader.Read();
                litId.Text = tipId.ToString();
                litCategory.Text = dReader["category"] as string;
                litTitle.Text = dReader["title"] as string;
                txtContent.Text = dReader["content"] as string;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //tbd
        }
    }
}
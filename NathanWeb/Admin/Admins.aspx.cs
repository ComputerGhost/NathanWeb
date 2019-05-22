using NathanWeb.Include;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NathanWeb.Admin
{
    public partial class Admins : System.Web.UI.Page
    {
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(dsAdmins.ConnectionString))
            {
                connection.Open();
                var cmd = new SqlCommand("INSERT INTO admins (username,passHash,passSalt,active) VALUES ('',0x00,0x00,0)", connection);
                cmd.ExecuteNonQuery();
            }
            gvAdmins.DataBind();
        }

        protected void gvAdmins_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvAdmins.EditIndex = e.NewEditIndex;
            gvAdmins.DataBind();
            var row = gvAdmins.Rows[e.NewEditIndex];
            var txtPassword = row.FindControl("txtPassword") as TextBox;
            txtPassword.Text = "";
        }

        protected void gvAdmins_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            var row = gvAdmins.Rows[e.RowIndex];
            var txtPassword = row.FindControl("txtPassword") as TextBox;
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
                return;

            var salt = AccountHelper.GenerateSalt();
            var hash = AccountHelper.Hash(txtPassword.Text, salt);

            using (var connection = new SqlConnection(dsAdmins.ConnectionString))
            {
                connection.Open();
                var cmd = new SqlCommand("UPDATE admins SET passHash=@hash,passSalt=@salt WHERE id=@id", connection);
                cmd.Parameters.AddWithValue("id", e.Keys[0]);
                cmd.Parameters.AddWithValue("salt", salt);
                cmd.Parameters.AddWithValue("hash", hash);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
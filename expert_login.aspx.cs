using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace farmerapp
{
    public partial class expert_login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            operations o = new operations();
            SqlConnection con = o.getcon();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from experttbl where emailid=@email and passw=@pass";
            cmd.Parameters.AddWithValue("@email", txtusername.Text.Trim());
            cmd.Parameters.AddWithValue("@pass", txtpass.Text.Trim());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Session["expertuser"] = txtusername.Text;
                Response.Redirect("experthome.aspx");
            }
            else
            {
                Response.Write("<script>alert('Invalid Credentials')</script>");
                txtusername.Text = "";
            }

        }

        protected void btncancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }
    }
}
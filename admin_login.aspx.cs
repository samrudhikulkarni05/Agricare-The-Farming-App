using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace farmerapp
{
    public partial class admin_login : System.Web.UI.Page
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
            cmd.CommandText = "select * from admintbl where aname=@a and apassword=@p";
            cmd.Parameters.Add("@a", txtusername.Text.Trim());
            cmd.Parameters.Add("@p", txtpass.Text.Trim());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Session["admin"] = txtusername.Text.Trim();
                Response.Redirect("farmerlist.aspx");
            }
            else
            {
                Response.Write("<script>alert('Invalid Credentials')</script>");
                txtusername.Text = "";
                txtpass.Text = "";
                txtusername.Focus();
            }
        }

        protected void btncancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }
    }
}
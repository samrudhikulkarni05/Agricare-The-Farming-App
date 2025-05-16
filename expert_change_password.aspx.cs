using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace farmerapp
{
    public partial class expert_change_password : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected void btnchng_Click1(object sender, EventArgs e)
        {
            operations o = new operations();
            SqlConnection con = o.getcon();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from experttbl where emailid=@email and passw=@passw ";
            cmd.Parameters.AddWithValue("@email", Session["expertuser"].ToString());
            cmd.Parameters.Add("@passw", txtpass.Text.Trim());

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Dispose();
                cmd.Dispose();
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con;
                cmd1.CommandText = "update experttbl set passw=@pass where emailid=@email";
                cmd1.Parameters.Add("@pass", txtnewpass2.Text.Trim());
                cmd1.Parameters.Add("@email", Session["expertuser"].ToString());
                cmd1.ExecuteNonQuery();
                Response.Write("<script>alert('Password Changed !')</script>");
                txtnewpass.Text = "";
                txtnewpass2.Text = "";
                txtpass.Text = "";


                //Password update code
            }
            else
            {
                Response.Write("<script>alert('Invalid Old Password')</script>");
                txtpass.Text = "";
                txtpass.Focus();
            }
        }
    }
}
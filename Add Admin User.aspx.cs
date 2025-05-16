using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace farmerapp
{
    public partial class Add_Admin_User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadadminusers();
            }
        }




        public void loadadminusers()
        {
            operations o = new operations();
            SqlConnection con = o.getcon();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from admintbl";
            SqlDataReader dr = cmd.ExecuteReader();
            gvadmin.DataSource = dr;
            gvadmin.DataBind();
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
                Response.Write("<script>alert('This User Already Exists')</script>");
            }
            else
            {
                dr.Dispose();
                cmd.CommandText = "insert into admintbl(aname,apassword)values(@a,@p)";
                cmd.ExecuteNonQuery();

                txtusername.Text = "";
                txtpass.Text = "";
                txtusername.Focus();
                loadadminusers();
            }
        }

        protected void gvadmin_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            operations o = new operations();
            SqlConnection con = o.getcon();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from admintbl where id=@id";
            cmd.Parameters.Add("@id", id);
            cmd.ExecuteNonQuery();
            loadadminusers();
        }
    }
}
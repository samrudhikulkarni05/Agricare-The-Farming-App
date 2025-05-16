using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace farmerapp
{
    public partial class experts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadexperts();
            }
        }


        public void loadexperts()
        {
            operations d = new operations();
            SqlConnection con = d.getcon();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from experttbl";
            SqlDataReader dr = cmd.ExecuteReader();
            gvexpert.DataSource = dr;
            gvexpert.DataBind();
        }

        protected void btnadd_Click(object sender, EventArgs e)
        {   
            operations d=new operations();
            SqlConnection con = d.getcon();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from experttbl where emailid=@email";
            cmd.Parameters.Add("@email", txtemail.Text.Trim());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Response.Write("<script>alert('Email id Already Added')</script>");
                txtemail.Text = "";
                txtemail.Focus();
            }
            else
            {
                dr.Dispose();
                cmd.CommandText = "insert into experttbl(fullname,emailid,mobile,passw)values(@fullname,@email,@mobile,@pass)";
                cmd.Parameters.Add("@fullname", txtfullname.Text.Trim());
                cmd.Parameters.Add("@mobile", txtmobile.Text.Trim());
                cmd.Parameters.Add("@pass", txtpass.Text.Trim());
                cmd.ExecuteNonQuery();
                loadexperts();
            }
        }

        protected void gvexpert_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int eid = Convert.ToInt32(e.CommandArgument);
            operations d = new operations();
            SqlConnection con = d.getcon();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from experttbl where eid=@eid";
            cmd.Parameters.Add("@eid", eid);
            cmd.ExecuteNonQuery();
            loadexperts();
        }
    }
}
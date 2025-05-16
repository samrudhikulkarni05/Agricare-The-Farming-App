using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace farmerapp
{
    public partial class statecity : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadallstate();
                loadallstateindd();
                loadallcity();
            }
        }
        public void loadallstate()
        {
            operations o = new operations();
            SqlConnection con = o.getcon();

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from statetbl";
            SqlDataReader dr = cmd.ExecuteReader();
            gvstate.DataSource = dr;
            gvstate.DataBind();
        }

        public void loadallstateindd()
        {
            drdstate.Items.Clear();
            operations o = new operations();
            SqlConnection con = o.getcon();

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from statetbl";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                drdstate.Items.Add(dr["statename"].ToString());
            }
        }

        public void loadallcity()
        {
            operations o = new operations();
            SqlConnection con = o.getcon();

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from citytbl";
            SqlDataReader dr = cmd.ExecuteReader();
            gvcity.DataSource = dr;
            gvcity.DataBind();
        }




        protected void btnadd_Click(object sender, EventArgs e)
        {
            operations o = new operations();
            SqlConnection con = o.getcon();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from statetbl where statename=@statename";
            cmd.Parameters.Add("@statename", txtstate.Text.Trim());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Response.Write("<script>alert('State Already Exist!')</script>");
                txtstate.Text = "";
                txtstate.Focus();
            }
            else
            {
                dr.Dispose();
                cmd.CommandText = "insert into statetbl(statename)values(@statename)";
                cmd.ExecuteNonQuery();
                txtstate.Text = "";
                txtstate.Focus();
                loadallstate();
                loadallstateindd();
            }
        }

        protected void gvstate_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int sid = Convert.ToInt32(e.CommandArgument);
            operations o = new operations();
            SqlConnection con = o.getcon();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from statetbl where sid=@sid";
            cmd.Parameters.Add("@sid", sid);
            cmd.ExecuteNonQuery();
            loadallstate();
            loadallstateindd();
        }

        protected void gvstate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnaddcity_Click(object sender, EventArgs e)
        {

            operations o = new operations();
            SqlConnection con = o.getcon();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from citytbl where cityname=@cityname";
            cmd.Parameters.Add("@cityname", txtcityname.Text.Trim());
            SqlDataReader dr = cmd.ExecuteReader();
           
        if(dr.HasRows)
        {
         Response.Write("<script>alert('City already exist')</script>");
            txtcityname.Text="";
            txtcityname.Focus();
        }
        else
        {
            dr.Dispose();
            cmd.CommandText = "insert into citytbl(statename,cityname)values(@state,@cityname)";
            cmd.Parameters.AddWithValue("@state",drdstate.Text);
            cmd.ExecuteNonQuery();
            txtcityname.Text = "";
            txtcityname.Focus();
            loadallstate();
            loadallcity();

        }
        
        }

        protected void btncancelcity_Click(object sender, EventArgs e)
        {

        }

        protected void gvcity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvcity_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int cityid = Convert.ToInt32(e.CommandArgument);
            operations o = new operations();
            SqlConnection con = o.getcon();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from citytbl where cityid=@cityid";
            cmd.Parameters.Add("@cityid", cityid);
            cmd.ExecuteNonQuery();
            loadallstate();
            loadallcity();
        }






    }
}
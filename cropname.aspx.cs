using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace farmerapp
{
    public partial class cropname : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadallcategory();
                loadallcrops();
            }
        }


        public void loadallcrops()
        {
            operations o = new operations();
            SqlConnection con = o.getcon(); 
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from croptbl";
            SqlDataReader dr = cmd.ExecuteReader();
            gvcrops.DataSource = dr;
            gvcrops.DataBind();
        }




        public void loadallcategory()
        {
            operations o = new operations();
            SqlConnection con = o.getcon(); 
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from cattbl";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                drdcategory.Items.Add(dr["catname"].ToString());
            }

        }

        protected void btnaddcrop_Click(object sender, EventArgs e)
        {
            operations o = new operations();
            SqlConnection con = o.getcon(); 
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from croptbl where catname=@catname and cropname=@cropname";
            cmd.Parameters.Add("@catname", drdcategory.Text.Trim());
            cmd.Parameters.Add("@cropname", txtcropname.Text.Trim());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Response.Write("<script>alert('Crop Already Exist!')</script>");
             }
            else
            {
                dr.Dispose();
                cmd.CommandText = "insert into croptbl(catname,cropname)values(@catname,@cropname)";
                cmd.ExecuteNonQuery();
                txtcropname.Text = "";
                loadallcrops();
            }
        }

        protected void gvcrops_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int crid = Convert.ToInt32(e.CommandArgument);
            operations o = new operations();
            SqlConnection con = o.getcon(); 
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from croptbl where crid=@crid";
            cmd.Parameters.Add("@crid", crid);
            cmd.ExecuteNonQuery();
            loadallcrops();
        }

    }
}
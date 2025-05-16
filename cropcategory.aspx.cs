using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace farmerapp
{
    public partial class cropcategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadallcategory();
            }
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
            gvcategory.DataSource = dr;
            gvcategory.DataBind();
        }



        protected void btnadd_Click(object sender, EventArgs e)
        {
            operations o = new operations();
            SqlConnection con = o.getcon();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from cattbl where catname=@catname";
            cmd.Parameters.Add("@catname", txtcategory.Text.Trim());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Response.Write("<script>alert('Category Already Exist!')</script>");
                txtcategory.Text = "";
                txtcategory.Focus();
            }
            else
            {
                dr.Dispose();
                cmd.CommandText = "insert into cattbl(catname)values(@catname)";
                cmd.ExecuteNonQuery();
                txtcategory.Text = "";
                txtcategory.Focus();
                loadallcategory();
            }
        }

        protected void gvcategory_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int cid=Convert.ToInt32(e.CommandArgument);
            operations o = new operations();
            SqlConnection con = o.getcon(); 
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from cattbl where catid=@catid";
            cmd.Parameters.Add("@catid", cid);
            cmd.ExecuteNonQuery();
            loadallcategory();
        }
    }
}
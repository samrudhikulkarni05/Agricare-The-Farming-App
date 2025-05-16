using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace farmerapp
{
    public partial class add_crop_to_experts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getallexperts();
                getallcrops();
                loadexpertcrop();
            }
        }



        public void getallexperts()
        {
            drdexpert.Items.Clear();
            operations o = new operations();
            SqlConnection con = o.getcon();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from experttbl";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                drdexpert.Items.Add(dr["fullname"].ToString());
            }
        }
        public void getallcrops()
        {
            drdcrop.Items.Clear();
            operations o = new operations();
            SqlConnection con = o.getcon();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from croptbl";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                drdcrop.Items.Add(dr["cropname"].ToString());
            }
        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            operations d = new operations();
            SqlConnection con = d.getcon();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            
            cmd.CommandText = "select * from expertcroptbl where expertname=@ename and cropname=@cname";
            cmd.Parameters.Add("@ename", drdexpert.Text);
            cmd.Parameters.Add("@cname", drdcrop.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Response.Write("<script>alert('Crop Already added to This Expert')</script>");
            }
            else
            {
                dr.Dispose();
                cmd.CommandText = "insert into expertcroptbl(expertname,cropname) values(@ename,@cname)";
                cmd.ExecuteNonQuery();
                loadexpertcrop();
            }

        }


        public void loadexpertcrop()
        {
            operations o = new operations();
            SqlConnection con = o.getcon();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from expertcroptbl";
            SqlDataReader dr = cmd.ExecuteReader();
            gvexpertcrop.DataSource = dr;
            gvexpertcrop.DataBind();
        }

        protected void gvexpertcrop_RowCreated(object sender, GridViewRowEventArgs e)
        {

        }

        protected void gvexpertcrop_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int ecid = Convert.ToInt32(e.CommandArgument);
            operations o = new operations();
            SqlConnection con = o.getcon();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from expertcroptbl where ecid=@ecid";
            cmd.Parameters.Add("@ecid", ecid);
            cmd.ExecuteNonQuery();
            loadexpertcrop();
            
        }

    }
}
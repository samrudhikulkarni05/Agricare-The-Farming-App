using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace farmerapp
{
    public partial class detailreply : System.Web.UI.Page
    {
        int qid;
        String ename;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            qid= Convert.ToInt32(Request.QueryString["qid"]);
            loadquery(qid);
        }



        public String getexpertname(String email)
        {
            operations o = new operations();
            SqlConnection con = o.getcon();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from experttbl where emailid=@email";
            cmd.Parameters.AddWithValue("@email",email);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            String expertname = dr["fullname"].ToString();
            return expertname;
        }

        public void loadquery(int qid)
        { 
            operations o = new operations();
            SqlConnection con = o.getcon();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select qid,querydetails,nfile from querytbl where qid=@qid";
            cmd.Parameters.AddWithValue("@qid",qid);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                imgquery.ImageUrl = dr["nfile"].ToString();
            }
        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            operations o = new operations();
            SqlConnection con = o.getcon();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into responsetbl(qid,expertname,response)values(@id,@ename,@response)";
            cmd.Parameters.AddWithValue("@id",qid);
            cmd.Parameters.AddWithValue("@ename", getexpertname(Session["expertuser"].ToString()));
            cmd.Parameters.AddWithValue("@response",txtreply.Text.Trim());
            cmd.ExecuteNonQuery();
            txtreply.Text = "";
            Response.Write("<script>alert('Reply Added')</script>");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("expertqueries.aspx");
        }
    }
}
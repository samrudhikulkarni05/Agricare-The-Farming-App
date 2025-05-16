using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace farmerapp
{
    public partial class expertqueries : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadqueries();
            }
        }




        public void loadqueries()
        { 
             operations o = new operations();
            SqlConnection con = o.getcon();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select qid,querydetails,nfile from querytbl";
            SqlDataReader dr = cmd.ExecuteReader();
            repqueries.DataSource = dr;
            repqueries.DataBind();
        }

        protected void repqueries_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int qid = Convert.ToInt32(e.CommandArgument);
            Response.Redirect("detailreply.aspx?qid=" + qid);

        }

    }
}
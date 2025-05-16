using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace farmerapp
{
    public partial class farmerlist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadfarmerlist(txtsearch.Text);
        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            loadfarmerlist(txtsearch.Text);
        }

        public void loadfarmerlist(String search)
        {
            operations d = new operations();
            SqlConnection con = d.getcon();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from farmertbl where mobileNo like @search or state like @search or city like @search or fullname like @search";
            cmd.Parameters.Add("@search", "%" + search + "%");
            SqlDataReader dr = cmd.ExecuteReader();
            gvfarmerlist.DataSource = dr;
            gvfarmerlist.DataBind();
        }

    }
}
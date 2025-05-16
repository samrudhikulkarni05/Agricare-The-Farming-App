using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace farmerapp
{
    public partial class expert : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Session["expertuser"] as String))
            {
                Response.Redirect("expert_login.aspx");
            }
            else
            {
                lblexpertuser.Text = "Welcome: " + (Session["expertuser"].ToString());
            }

        }

        protected void lbtnlopgout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session["expertuser"] = "";
            Response.Redirect("expert_login.aspx");
        }
    }
}
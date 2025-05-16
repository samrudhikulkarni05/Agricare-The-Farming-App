using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace farmerapp
{
    /// <summary>
    /// Summary description for cropbycat
    /// </summary>
    public class cropbycat : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            String cat = context.Request.QueryString["cat"];
            operations o = new operations();
            SqlDataReader dr = o.getallcropbycategory(cat);
            List<String> lcrop = new List<String>();
            while (dr.Read())
            {
                lcrop.Add(dr["cropname"].ToString());

           }
            String json = Newtonsoft.Json.JsonConvert.SerializeObject(lcrop);


            context.Response.ContentType = "text/plain";
            context.Response.Write(json);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
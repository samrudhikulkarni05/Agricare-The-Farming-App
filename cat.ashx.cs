using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Newtonsoft;

namespace farmerapp
{
    /// <summary>
    /// Summary description for cat
    /// </summary>
    public class cat : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {

            operations o = new operations();
            SqlDataReader dr = o.getallcategory();
            List<String> lcat = new List<String>();
            while (dr.Read())
            {
                lcat.Add(dr["catname"].ToString());
            }

            String json = Newtonsoft.Json.JsonConvert.SerializeObject(lcat);

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
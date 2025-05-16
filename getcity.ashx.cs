using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Newtonsoft;

namespace farmerapp
{
    /// <summary>
    /// Summary description for getcity
    /// </summary>
    public class getcity : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            String state = context.Request.QueryString["state"];
            operations o = new operations();
            SqlDataReader dr = o.getcitybystate(state);
            List<String> lcity = new List<String>();
            while (dr.Read())
            {
                lcity.Add(dr["cityname"].ToString());
            }
            String json = Newtonsoft.Json.JsonConvert.SerializeObject(lcity);

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
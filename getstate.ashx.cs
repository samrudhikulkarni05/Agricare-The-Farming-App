using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Newtonsoft;


namespace farmerapp
{
    /// <summary>
    /// Summary description for getstate
    /// </summary>
    public class getstate : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            operations o = new operations();
            SqlDataReader dr = o.getallstate();
            List<String> lstate = new List<String>();
            while (dr.Read())
            {
                lstate.Add(dr["statename"].ToString());
            }
            String json = Newtonsoft.Json.JsonConvert.SerializeObject(lstate);


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





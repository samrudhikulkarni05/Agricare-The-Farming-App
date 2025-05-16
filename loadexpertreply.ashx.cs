using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
namespace farmerapp
{
    /// <summary>
    /// Summary description for loadexpertreply
    /// </summary>
    public class loadexpertreply : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {

            String mobile=context.Request.QueryString["mobile"];
            operations o = new operations();
            DataTable dr= o.getreply(mobile);
            String json = Newtonsoft.Json.JsonConvert.SerializeObject(dr);

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
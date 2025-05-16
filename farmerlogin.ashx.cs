using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace farmerapp
{
    /// <summary>
    /// Summary description for farmerlogin
    /// </summary>
    public class farmerlogin : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {

            String mobileno, passw;
            mobileno = context.Request.QueryString["mob"].ToString();
            passw = context.Request.QueryString["pass"].ToString();
            operations o = new operations();
            int result = o.checklogin(mobileno, passw);
           // context.Response.Write(result);

            if (result == 1)
            {
                context.Response.Write("Login Success");
            }
            else if (result == 0)
            {
                context.Response.Write("Invalid User Name or password");
            }
            else
            {
                context.Response.Write("Please try again Later");
            }

            
//        context.Response.ContentType = "text/plain";
  //      context.Response.Write("Hello World");
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
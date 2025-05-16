using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace farmerapp
{
    /// <summary>
    /// Summary description for farmer_reg
    /// </summary>
    public class farmer_reg : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            byte[] b = operations.ReadAllStream(context.Request.InputStream);
            String str = System.Text.Encoding.UTF8.GetString(b);
            Farmer f = Newtonsoft.Json.JsonConvert.DeserializeObject<Farmer>(str);

            String Fullname = f.FullName;
            String MobileNo = f.MobileNo;
            String city = f.city;
            String state = f.state;
            String password = f.password;


            //String fullname = "sam";
            //String mobile = "9890";
            //String city = "Solapur";
            //String state = "MH";
            //String password = "abc";





            operations o = new operations();
            int result = o.registerfarmer(Fullname, MobileNo, password, city, state);
            if (result == 0)
            {
                context.Response.Write("Number Registored");
            }
            if (result == 1)
            {
                context.Response.Write("Success");
            }
            if (result == -1)
            {
                context.Response.Write("try again");
            }
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
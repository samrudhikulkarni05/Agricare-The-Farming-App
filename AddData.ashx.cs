using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace farmerapp
{
    /// <summary>
    /// Summary description for AddData
    /// </summary>
    public class AddData : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            byte[] b = operations.ReadAllStream(context.Request.InputStream);
            String str = System.Text.Encoding.UTF8.GetString(b);
            NQuery n = Newtonsoft.Json.JsonConvert.DeserializeObject<NQuery>(str);

            String farmermobile = n.farmermobile;
            String categoryname = n.categoryname;
            String Cropname = n.Cropname;
            String querydetails = n.querdetails;
            String qimage = n.qimage;



            operations o = new operations();
            String newfile = o.getticks() + ".jpg";
            string base64String = qimage;
            byte[] imageBytes = Convert.FromBase64String(base64String);


            using (MemoryStream ms = new MemoryStream(imageBytes))
            {

                Image image = Image.FromStream(ms);

                image.Save(context.Server.MapPath((newfile)), ImageFormat.Jpeg);
            }

            int result=o.queryinsert(farmermobile, categoryname, Cropname, querydetails, qimage,newfile);
            context.Response.Write("Success");

             

                
           
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
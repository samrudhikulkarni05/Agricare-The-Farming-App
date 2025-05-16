using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Data;


namespace farmerapp
{
    public class operations
    {
        public SqlConnection getcon()
        {
            SqlConnection con = new SqlConnection(@"Data Source=sharedmssql10.znetindia.net,1234;Initial Catalog=farmerapp;Persist Security Info=True;User ID=farmerdb;Password=Ebj0t310&");
            return con;
        }



        public DataTable getreply(String mobile)
        {
            operations o = new operations();
            SqlConnection con = o.getcon();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from querytbl q, responsetbl r, experttbl e where r.qid=q.qid and e.fullname=r.expertname and q.farmermobile=@mobile";
            cmd.Parameters.AddWithValue("@mobile",mobile);
            //SqlDataReader dr = cmd.ExecuteReader();
            SqlDataAdapter a = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            a.Fill(table);
            return table;

        }



        public static Image ConvertToImage(byte[] byteArrayIn)
        {
            Image image;
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                image = Image.FromStream(ms);
            }
            return image;
        }






        public int checklogin(String mobileNo, String password) 
        {
            try
            {
                operations o = new operations();
                SqlConnection con = o.getcon();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from farmertbl where mobileno=@mobileNo and password=@password";
                cmd.Parameters.AddWithValue("@mobileNo", mobileNo);
                cmd.Parameters.AddWithValue("@password", password);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception e1)
            {
                return -1;
            }
            
            
             
        }



        public SqlDataReader getallcategory()
        {
            try
            {
                operations o = new operations();
                SqlConnection con = o.getcon();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from cattbl";
                SqlDataReader dr = cmd.ExecuteReader();
                return dr;
            }
            catch (Exception e1)
            {
                return null;
            }
        }


        public SqlDataReader getallcropbycategory(String category)
        {
            operations o = new operations();
            SqlConnection con = o.getcon();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from croptbl where catname=@category";
            cmd.Parameters.Add("@category", category);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
            
        }




        public String getticks()
        {
            String ticks = System.DateTime.Now.Ticks.ToString();
            return ticks;
        }

        public int queryinsert(String farmermob,String categoryn,String cropname,String querydetail,String qimg,String nfile)
        {
            operations d = new operations();
            SqlConnection con = d.getcon();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
                
                cmd.CommandText = "insert into querytbl(farmermobile,categoryname,Cropname,querydetails,qimage,nfile)values(@farmermob,@categoryn,@cropname,@querydetail,@qimg,@nfile)";
                cmd.Parameters.Add("@farmermob", farmermob);
                cmd.Parameters.Add("@categoryn", categoryn);
                cmd.Parameters.Add("@cropname", cropname);
                cmd.Parameters.Add("@querydetail", querydetail);
                cmd.Parameters.Add("@qimg", qimg);
                cmd.Parameters.Add("@nfile", nfile);
                cmd.ExecuteNonQuery();
                return 1;   
        }
        public SqlDataReader getallstate()
        {
            operations o = new operations();
            SqlConnection con = o.getcon();

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from statetbl";
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader getcitybystate(String statename)
        {
            operations o = new operations();
            SqlConnection con = o.getcon();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from citytbl where statename=@statename";
            cmd.Parameters.Add("@statename",statename);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        
        }


        public int registerfarmer(String FullName, String MobileNo, String Password, String city, String State)
    {
        try
        {
            operations d = new operations();
            SqlConnection con = d.getcon();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from farmertbl where mobileNo=@mobileNo";
            cmd.Parameters.Add("@mobileNo", MobileNo);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                return 0;
            }

            else
            {
                dr.Dispose();
                cmd.CommandText = "insert into farmertbl(fullname,mobileNo,city,state,password)values(@fullname,@mobile,@city,@state,@pass)";
                cmd.Parameters.Add("@fullname", FullName);
                cmd.Parameters.Add("@mobile", MobileNo);
                cmd.Parameters.Add("@pass", Password);
                cmd.Parameters.Add("@city", city);
                cmd.Parameters.Add("@state", State);
                cmd.ExecuteNonQuery();
                return 1;

            }
        }
        catch (Exception e1)
        {
            return -1;
        }
        
 

        

        
    }

        public void addresponse(int qid, String expertemail, String response)
        {
            operations d=new operations();
            SqlConnection con= d.getcon();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into responsetbl(qid,exemail,response)values(@qid,@expertemail,@response)";
            cmd.Parameters.Add("@qid", qid);
            cmd.Parameters.Add("@expertemail", expertemail);
            cmd.Parameters.Add("@response", response);
            cmd.ExecuteNonQuery();
                
    }



        public SqlDataReader getquerybyfarmer(String fmobile)
        {
            operations d = new operations();
            SqlConnection con = d.getcon();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from querytbl where farmermobile=@fmobile";
            cmd.Parameters.Add("@fmobile", fmobile);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;

        }



        public static byte[] ReadAllStream(Stream s)
        {
            MemoryStream ms = new MemoryStream();
            byte[] b = new byte[10240];
            int n;
            while ((n = s.Read(b, 0, b.Length)) > 0)
            {

                ms.Write(b, 0, n);
            }
            b = ms.ToArray();
            ms.Dispose();
            return b;

        }


        public SqlDataReader getresponsebyquery(int qid)
        {
            operations d = new operations();
            SqlConnection con = d.getcon();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from responsetbl where qid=@qid";
            cmd.Parameters.Add("@qid", qid);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }


      


    }
} 
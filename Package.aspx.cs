using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;
using System.Web.Configuration;

public partial class Package : System.Web.UI.Page
{
    OdbcConnection con = new OdbcConnection(WebConfigurationManager.ConnectionStrings["myConnectionString"].ToString());
    int pos=1;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        String name = "select max(pos) from notifyadmin" ;
        OdbcCommand cmd1 = new OdbcCommand(name, con);
        OdbcDataReader dr1 = cmd1.ExecuteReader();
        dr1.Read();
        if (dr1.HasRows)
        {
            pos = Convert.ToInt32(dr1[0].ToString());
            

        }   
       
        con.Close();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        string dt = DateTime.Now.ToString("yyyy-MM-dd");
        string tm = DateTime.Now.ToShortTimeString();
        con.Open();

        //retriving username and mail id
        String name = "select Name from user where status='1'";
        OdbcCommand cmd1 = new OdbcCommand(name, con);
        OdbcDataReader dr1 = cmd1.ExecuteReader();
        dr1.Read();
        String mail = "select Mailid from user where status='1'";
        OdbcCommand cmd2 = new OdbcCommand(mail, con);
        OdbcDataReader dr2 = cmd2.ExecuteReader();
        dr2.Read();

        if (dr2.HasRows)
        {
            pos = pos + 1;
            String str = "insert into notifyadmin values('" + dr1[0].ToString() + "','" + dr2[0].ToString() + "','" + dt + "','" + tm + "','summer pack','"+pos+"')";
            OdbcCommand cmd = new OdbcCommand(str, con);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('Package succefully added to your cart. Our employee will contact you shortly for further details ')</script>");
        }
        else
        {
            Response.Write("<script>alert('Login to book this package')</script>");  
        }
    }


    protected void Button2_Click(object sender, EventArgs e)
    {

        string dt = DateTime.Now.ToString("yyyy-MM-dd");
        string tm = DateTime.Now.ToShortTimeString();
        con.Open();

        //retriving username and mail id
        String name = "select Name from user where status='1'";
        OdbcCommand cmd1 = new OdbcCommand(name, con);
        OdbcDataReader dr1 = cmd1.ExecuteReader();
        dr1.Read();
        String mail = "select Mailid from user where status='1'";
        OdbcCommand cmd2 = new OdbcCommand(mail, con);
        OdbcDataReader dr2 = cmd2.ExecuteReader();
        dr2.Read();

        if (dr2.HasRows)
          {
              pos = pos + 1;
              String str = "insert into notifyadmin values('" + dr1[0].ToString() + "','" + dr2[0].ToString() + "','" + dt + "','" + tm + "','weekly wonder','" + pos + "')";
           OdbcCommand cmd = new OdbcCommand(str, con);
           cmd.ExecuteNonQuery();
           con.Close();
           Response.Write("<script>alert('Package succefully added to your cart. Our employee will contact you shortly for further details ')</script>");
   
          }
        else
          {
           Response.Write("<script>alert('Login to book this package')</script>");  
          }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {

        string dt = DateTime.Now.ToString("yyyy-MM-dd");
        string tm = DateTime.Now.ToShortTimeString();
        con.Open();

        //retriving username and mail id
        String name = "select Name from user where status='1'";
        OdbcCommand cmd1 = new OdbcCommand(name, con);
        OdbcDataReader dr1 = cmd1.ExecuteReader();
        dr1.Read();
        String mail = "select Mailid from user where status='1'";
        OdbcCommand cmd2 = new OdbcCommand(mail, con);
        OdbcDataReader dr2 = cmd2.ExecuteReader();
        dr2.Read();

        if (dr2.HasRows)
         {
             pos = pos + 1;
             String str = "insert into notifyadmin values('" + dr1[0].ToString() + "','" + dr2[0].ToString() + "','" + dt + "','" + tm + "','Honeymoon special','" + pos + "')";
          OdbcCommand cmd = new OdbcCommand(str, con);
          cmd.ExecuteNonQuery();
          con.Close();
          Response.Write("<script>alert('Package succefully added to your cart. Our employee will contact you shortly for further details ')</script>");
         }
        else
        {
            Response.Write("<script>alert('Login to book this package')</script>");  
        }
          
       
    }

    protected void Button4_Click(object sender, EventArgs e)
    {

        string dt = DateTime.Now.ToString("yyyy-MM-dd");
        string tm = DateTime.Now.ToShortTimeString();
        con.Open();

        //retriving username and mail id
        String name = "select Name from user where status='1'";
        OdbcCommand cmd1 = new OdbcCommand(name, con);
        OdbcDataReader dr1 = cmd1.ExecuteReader();
        dr1.Read();
        String mail = "select Mailid from user where status='1'";
        OdbcCommand cmd2 = new OdbcCommand(mail, con);
        OdbcDataReader dr2 = cmd2.ExecuteReader();
        dr2.Read();

        if (dr2.HasRows)
        {
            pos = pos + 1;
            String str = "insert into notifyadmin values('" + dr1[0].ToString() + "','" + dr2[0].ToString() + "','" + dt + "','" + tm + "','vibrant goa','"+pos+"')";
            OdbcCommand cmd = new OdbcCommand(str, con);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('Package succefully added to your cart. Our employee will contact you shortly for further details ')</script>");
        }
        else
        {
            Response.Write("<script>alert('Login to book this package')</script>");
        }
   }

    protected void Button5_Click(object sender, EventArgs e)
    {

        string dt = DateTime.Now.ToString("yyyy-MM-dd");
        string tm = DateTime.Now.ToShortTimeString();
        con.Open();

        //retriving username and mail id
        String name = "select Name from user where status='1'";
        OdbcCommand cmd1 = new OdbcCommand(name, con);
        OdbcDataReader dr1 = cmd1.ExecuteReader();
        dr1.Read();
        String mail = "select Mailid from user where status='1'";
        OdbcCommand cmd2 = new OdbcCommand(mail, con);
        OdbcDataReader dr2 = cmd2.ExecuteReader();
        dr2.Read();

        if (dr2.HasRows)
        {
            pos = pos + 1;
            String str = "insert into notifyadmin values('" + dr1[0].ToString() + "','" + dr2[0].ToString() + "','" + dt + "','" + tm + "','Thrilling manali','" + pos + "')";
            OdbcCommand cmd = new OdbcCommand(str, con);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('Package succefully added to your cart. Our employee will contact you shortly for further details ')</script>");
        }
        else
        {
            Response.Write("<script>alert('Login to book this package')</script>");
        }
    }

    protected void Button6_Click(object sender, EventArgs e)
    {

        string dt = DateTime.Now.ToString("yyyy-MM-dd");
        string tm = DateTime.Now.ToShortTimeString();
        con.Open();

        //retriving username and mail id
        String name = "select Name from user where status='1'";
        OdbcCommand cmd1 = new OdbcCommand(name, con);
        OdbcDataReader dr1 = cmd1.ExecuteReader();
        dr1.Read();
        String mail = "select Mailid from user where status='1'";
        OdbcCommand cmd2 = new OdbcCommand(mail, con);
        OdbcDataReader dr2 = cmd2.ExecuteReader();
        dr2.Read();

        if (dr2.HasRows)
        {
            pos = pos + 1;
            String str = "insert into notifyadmin values('" + dr1[0].ToString() + "','" + dr2[0].ToString() + "','" + dt + "','" + tm + "','Holy Land(Jerusalem) pack','" + pos + "')";
            OdbcCommand cmd = new OdbcCommand(str, con);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('Package succefully added to your cart. Our employee will contact you shortly for further details ')</script>");
        }
        else
        {
            Response.Write("<script>alert('Login to book this package')</script>");
        }
    }
}
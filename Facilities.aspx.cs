using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;
using System.Web.Configuration;

public partial class Facilities : System.Web.UI.Page
{
    OdbcConnection con = new OdbcConnection(WebConfigurationManager.ConnectionStrings["myConnectionString"].ToString());
   String sname="";
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        String snameorg="";

        String z = "select Mailid from user where status=1";
        OdbcCommand cmdorg = new OdbcCommand(z, con);
        OdbcDataReader dnameorg = cmdorg.ExecuteReader();

        dnameorg.Read();
        if (dnameorg.HasRows)
        {
            snameorg = dnameorg[0].ToString();



        }

        String n = "select mailid from usertemp where mailid='" + snameorg + "'";
        OdbcCommand cmdname = new OdbcCommand(n, con);
        OdbcDataReader dname = cmdname.ExecuteReader();

        dname.Read();
        if (dname.HasRows)
        {
            

            Button5.Text = "View customised pack";

        }
        con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();

       ///notify btn
        String n = "select Mailid from user where status=1";
        OdbcCommand cmdname = new OdbcCommand(n, con);
        OdbcDataReader dname = cmdname.ExecuteReader();

        dname.Read();
        if (dname.HasRows)
        {
            sname = dname[0].ToString();

            String nT = "select mailid from usertemp where mailid='" + sname + "'";
            OdbcCommand cmdnameT = new OdbcCommand(nT, con);
            OdbcDataReader dnameT = cmdnameT.ExecuteReader();

            dnameT.Read();
            if (dnameT.HasRows)
            {
            
                String strk = "update usertemp set bus='Rider' where mailid='" + sname + "'";
                OdbcCommand cmdk = new OdbcCommand(strk, con);
                cmdk.ExecuteNonQuery();
                Response.Write("<script>alert('bus added')</script>");

            }
            else
            {
                Response.Write("<script>alert(' add some tourist spots before adding bus ')</script>");
            }


        }
        else
        {
            Response.Write("<script>alert('Login/signup to perform this action')</script>");
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        con.Open();

        ///notify btn
        String n = "select Mailid from user where status=1";
        OdbcCommand cmdname = new OdbcCommand(n, con);
        OdbcDataReader dname = cmdname.ExecuteReader();

        dname.Read();
        if (dname.HasRows)
        {
            sname = dname[0].ToString();

            String nT = "select mailid from usertemp where mailid='" + sname + "'";
            OdbcCommand cmdnameT = new OdbcCommand(nT, con);
            OdbcDataReader dnameT = cmdnameT.ExecuteReader();

            dnameT.Read();
            if (dnameT.HasRows)
            {
                String strk = "update usertemp set bus='Comfy' where mailid='" + sname + "'";
                OdbcCommand cmdk = new OdbcCommand(strk, con);
                cmdk.ExecuteNonQuery();
                Response.Write("<script>alert('bus added')</script>");

            }
            else
            {
                Response.Write("<script>alert(' add some tourist spots before adding bus ')</script>");
            }


        }
        else
        {
            Response.Write("<script>alert('Login/signup to perform this action')</script>");
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        con.Open();

        ///notify btn
        String n = "select Mailid from user where status=1";
        OdbcCommand cmdname = new OdbcCommand(n, con);
        OdbcDataReader dname = cmdname.ExecuteReader();

        dname.Read();
        if (dname.HasRows)
        {
            sname = dname[0].ToString();

            String nT = "select mailid from usertemp where mailid='" + sname + "'";
            OdbcCommand cmdnameT = new OdbcCommand(nT, con);
            OdbcDataReader dnameT = cmdnameT.ExecuteReader();

            dnameT.Read();
            if (dnameT.HasRows)
            {
                String strk = "update usertemp set bus='Companion' where mailid='" + sname + "'";
                OdbcCommand cmdk = new OdbcCommand(strk, con);
                cmdk.ExecuteNonQuery();
                Response.Write("<script>alert('bus added')</script>");

            }
            else
            {
                Response.Write("<script>alert(' add some tourist spots before adding bus ')</script>");
            }


        }
        else
        {
            Response.Write("<script>alert('Login/signup to perform this action')</script>");
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        con.Open();

        ///notify btn
        String n = "select Mailid from user where status=1";
        OdbcCommand cmdname = new OdbcCommand(n, con);
        OdbcDataReader dname = cmdname.ExecuteReader();

        dname.Read();
        if (dname.HasRows)
        {
            sname = dname[0].ToString();

            String nT = "select mailid from usertemp where mailid='" + sname + "'";
            OdbcCommand cmdnameT = new OdbcCommand(nT, con);
            OdbcDataReader dnameT = cmdnameT.ExecuteReader();

            dnameT.Read();
            if (dnameT.HasRows)
            {
                String strk = "update usertemp set bus='Slingshot' where mailid='" + sname + "'";
                OdbcCommand cmdk = new OdbcCommand(strk, con);
                cmdk.ExecuteNonQuery();
                Response.Write("<script>alert('bus added')</script>");

            }
            else
            {
                Response.Write("<script>alert(' add some tourist spots before adding bus ')</script>");
            }


        }
        else
        {
            Response.Write("<script>alert('Login/signup to perform this action')</script>");
        }
    }
    protected void Button5_Click(object sender, EventArgs e)
    {


        con.Open();

        String n = "select Mailid from user where status=1";
        OdbcCommand cmdname = new OdbcCommand(n, con);
        OdbcDataReader dname = cmdname.ExecuteReader();

        dname.Read();
        if (dname.HasRows)
        {
            sname = dname[0].ToString();
            Response.Redirect("Customlist.aspx");


        }
        else
        {
            Response.Write("<script>alert('Login to continue')</script>");

        }
        con.Close();
    }
}
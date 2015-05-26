﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.Odbc;
using System.Web.Configuration;
using System.Web.UI.WebControls;

public partial class RegUser : System.Web.UI.Page
{
    OdbcConnection con = new OdbcConnection(WebConfigurationManager.ConnectionStrings["myConnectionString"].ToString());
    public String sname = "";
    public string sn { get { return sname; } }


    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();

        String n = "select Name from user where status=1";
        OdbcCommand cmdname = new OdbcCommand(n, con);
        OdbcDataReader dname = cmdname.ExecuteReader();

        dname.Read();
        if (dname.HasRows)
        {
            sname = dname[0].ToString();

        }
        con.Close();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();

        String str = "select Area_code from touristareas where Areas='" + TextBox1.Text + "'";
        OdbcCommand cmd = new OdbcCommand(str, con);
        OdbcDataReader dr = cmd.ExecuteReader();

        dr.Read();
        if (dr.HasRows)
        {
            Response.Redirect("TouristSpots.aspx");
        }
        else
        {
            String str1 = "select package_name from packages where package_name='" + TextBox1.Text + "'";
            OdbcCommand cmd1 = new OdbcCommand(str1, con);
            OdbcDataReader dr1 = cmd1.ExecuteReader();

            dr1.Read();
            if (dr1.HasRows)
            {
                Response.Redirect("Package.aspx");
            }
            else
            {
                Response.Write("<script>alert('Sorry..could not find a match for the text entered...Try another place or package')</script>");
            }

        }
        con.Close();

    }

   
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("RegMessages.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        con.Open();
        String str1 = "update user set status='0' ;";
        OdbcCommand cmd1 = new OdbcCommand(str1, con);
        cmd1.ExecuteNonQuery();
        con.Close();
        Response.Redirect("Home.aspx");
    }
    protected void Button4_Click(object sender, EventArgs e)
    {

        con.Open();

        int pos = 0;
        String Uname = "unknown user", Umail = "unknown";

        String dt = DateTime.Now.ToString("yyyy-MM-dd");
        String tm = DateTime.Now.ToShortTimeString();

        String k = "select max(pos) from notifyadmin";
        OdbcCommand cmd1 = new OdbcCommand(k, con);
        OdbcDataReader dr1 = cmd1.ExecuteReader();
        dr1.Read();
        if (dr1.HasRows)
        {
            pos = Convert.ToInt32(dr1[0].ToString());

        }
        //retriving username and mail id
        String name = "select Name from user where status='1'";
        OdbcCommand cmd2 = new OdbcCommand(name, con);
        OdbcDataReader dr2 = cmd2.ExecuteReader();
        dr2.Read();
        String mail = "select Mailid from user where status='1'";
        OdbcCommand cmd3 = new OdbcCommand(mail, con);
        OdbcDataReader dr3 = cmd3.ExecuteReader();
        dr3.Read();

        if (dr3.HasRows)
        {
            ++pos;
            String str = "insert into notifyadmin values('" + dr2[0].ToString() + "','" + dr3[0].ToString() + "','" + dt + "','" + tm + "','" + TextBox2.Text + "','" + pos + "')";
            OdbcCommand cn = new OdbcCommand(str, con);
            cn.ExecuteNonQuery();

            Response.Write("<script>alert('Message sent ')</script>");

        }
        else
        {
            pos = pos + 1;
            String str = "insert into notifyadmin values('" + Uname + "','" + Umail + "','" + dt + "','" + tm + "','" + TextBox2.Text + "','" + pos + "')";
            OdbcCommand cn = new OdbcCommand(str, con);
            cn.ExecuteNonQuery();

            Response.Write("<script>alert('Message sent ')</script>");
        }

        con.Close();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;
using System.Web.Configuration;

public partial class Notifications : System.Web.UI.Page
{
    OdbcConnection con = new OdbcConnection(WebConfigurationManager.ConnectionStrings["myConnectionString"].ToString());
    int smax=0,smaxtemp=0;
    int btn1=0,btn2=0,btn3=0,btn4=0;
    public String s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16,s17,s18,s19,s20;
    public string sh1 { get { return s1; } }
    public string sh2 { get { return s2; } }
    public string sh3 { get { return s3; } }
    public string sh4 { get { return s4; } }
    public string sd1 { get { return s5; } }
    public string sd2 { get { return s6; } }
    public string sd3 { get { return s7; } }
    public string sd4 { get { return s8; } }
    public string st1 { get { return s9; } }
    public string st2 { get { return s10; } }
    public string st3 { get { return s11; } }
    public string st4 { get { return s12; } }
    public string si1 { get { return s13; } }
    public string si2 { get { return s14; } }
    public string si3 { get { return s15; } }
    public string si4 { get { return s16; } }
    public string sm1 { get { return s17; } }
    public string sm2 { get { return s18; } }
    public string sm3 { get { return s19; } }
    public string sm4 { get { return s20; } }

    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();

        String sm = "select max(pos) from notifyadmin";
        OdbcCommand smax1 = new OdbcCommand(sm, con);
        OdbcDataReader sel = smax1.ExecuteReader();

        sel.Read();
        if (sel.HasRows)
        {
            if (sel[0].ToString() == "")
            {
                smax = 0;
            }
            else
            {
                smax = Convert.ToInt32(sel[0].ToString());
                smaxtemp = smax;
            }
        }

       

        btn1 = smax;
        String str1 = "select UserName from notifyadmin where pos='"+smax+"'";
        OdbcCommand cmd1 = new OdbcCommand(str1, con);
        OdbcDataReader dr1 = cmd1.ExecuteReader();

        dr1.Read();
        if (dr1.HasRows)
        {
            s1 = dr1[0].ToString();

        }
        else
        {
            s1 = "";
        }

        String str5 = "select mail_id from notifyadmin where pos='" + smax + "'";
        OdbcCommand cmd5 = new OdbcCommand(str5, con);
        OdbcDataReader dr5 = cmd5.ExecuteReader();

        dr5.Read();
        if (dr5.HasRows)
        {
            s5 = dr5[0].ToString();
        }
        else
        {
            s5 = "";
        }

        String str9 = "select date from notifyadmin where pos='" + smax + "'";
        OdbcCommand cmd9 = new OdbcCommand(str9, con);
        OdbcDataReader dr9 = cmd9.ExecuteReader();

        dr9.Read();
        if (dr9.HasRows)
        {
            s9 = dr9[0].ToString();
        }
        else
        {
            s9 = "";
        }
        String str13 = "select time from notifyadmin where pos='" + smax + "'";
        OdbcCommand cmd13 = new OdbcCommand(str13, con);
        OdbcDataReader dr13 = cmd13.ExecuteReader();

        dr13.Read();
        if (dr13.HasRows)
        {
            s13 = dr13[0].ToString();
        }
        else
        {
            s13 = "";
        }
        String str17 = "select details from notifyadmin where pos='" + smax + "'";
        OdbcCommand cmd17 = new OdbcCommand(str17, con);
        OdbcDataReader dr17 = cmd17.ExecuteReader();

        dr17.Read();
        if (dr17.HasRows)
        {
            s17 = dr17[0].ToString();
        }
        else
        {
            s16 = "";
        }
        smax--;
        btn2 = smax;
        String str2 = "select UserName from notifyadmin where pos='" + smax + "'";
        OdbcCommand cmd2 = new OdbcCommand(str2, con);
        OdbcDataReader dr2 = cmd2.ExecuteReader();

        dr2.Read();
        if (dr2.HasRows)
        {
            s2 = dr2[0].ToString();
        }
        else
        {
            s2 = "";
        }

        String str6 = "select mail_id from notifyadmin where pos='" + smax + "'";
        OdbcCommand cmd6 = new OdbcCommand(str6, con);
        OdbcDataReader dr6 = cmd6.ExecuteReader();

        dr6.Read();
        if (dr6.HasRows)
        {
            s6 = dr6[0].ToString();
        }
        else
        {
            s6 = "";
        }
        String str10 = "select date from notifyadmin where pos='" + smax + "'";
        OdbcCommand cmd10 = new OdbcCommand(str10, con);
        OdbcDataReader dr10 = cmd10.ExecuteReader();

        dr10.Read();
        if (dr10.HasRows)
        {
            s10 = dr10[0].ToString();
        }
        else
        {
            s10 = "";
        }
        String str14 = "select time from notifyadmin where pos='" + smax + "'";
        OdbcCommand cmd14 = new OdbcCommand(str14, con);
        OdbcDataReader dr14 = cmd14.ExecuteReader();

        dr14.Read();
        if (dr14.HasRows)
        {
            s14 = dr14[0].ToString();
        }
        else
        {
            s14 = "";
        }


        String str18 = "select details from notifyadmin where pos='" + smax + "'";
        OdbcCommand cmd18 = new OdbcCommand(str18, con);
        OdbcDataReader dr18 = cmd18.ExecuteReader();

        dr18.Read();
        if (dr18.HasRows)
        {
            s18 = dr18[0].ToString();
        }
        else
        {
            s18 = "";
        }
        smax--;

        btn3 = smax;
        String str3 = "select UserName from notifyadmin where pos='" + smax + "'";
        OdbcCommand cmd3 = new OdbcCommand(str3, con);
        OdbcDataReader dr3 = cmd3.ExecuteReader();

        dr3.Read();
        if (dr3.HasRows)
        {
            s3 = dr3[0].ToString();
        }
        else
        {
            s3 = "";
        }
        String str7 = "select mail_id from notifyadmin where pos='" + smax + "'";
        OdbcCommand cmd7 = new OdbcCommand(str7, con);
        OdbcDataReader dr7 = cmd7.ExecuteReader();

        dr7.Read();
        if (dr7.HasRows)
        {
            s7 = dr7[0].ToString();
        }
        else
        {
            s7 = "";
        }
        String str11 = "select date from notifyadmin where pos='" + smax + "'";
        OdbcCommand cmd11 = new OdbcCommand(str11, con);
        OdbcDataReader dr11 = cmd11.ExecuteReader();

        dr11.Read();
        if (dr11.HasRows)
        {
            s11 = dr11[0].ToString();
        }
        else
        {
            s11 = "";
        }
        String str15 = "select time from notifyadmin where pos='" + smax + "'";
        OdbcCommand cmd15 = new OdbcCommand(str15, con);
        OdbcDataReader dr15 = cmd15.ExecuteReader();

        dr15.Read();
        if (dr15.HasRows)
        {
            s15 = dr15[0].ToString();
        }
        else
        {
            s15 = "";
        }
        String str19 = "select details from notifyadmin where pos='" + smax + "'";
        OdbcCommand cmd19 = new OdbcCommand(str19, con);
        OdbcDataReader dr19 = cmd19.ExecuteReader();

        dr19.Read();
        if (dr19.HasRows)
        {
            s19 = dr19[0].ToString();
        }
        else
        {
            s19 = "";
        }
        smax--;
        btn4 = smax;
        String str4 = "select UserName from notifyadmin where pos='" + smax + "'";
        OdbcCommand cmd4 = new OdbcCommand(str4, con);
        OdbcDataReader dr4 = cmd4.ExecuteReader();

        dr4.Read();
        if (dr4.HasRows)
        {
            s4 = dr4[0].ToString();
        }
        else
        {
            s4 = "";
        }




        String str8 = "select mail_id from notifyadmin where pos='" + smax + "'";
        OdbcCommand cmd8 = new OdbcCommand(str8, con);
        OdbcDataReader dr8 = cmd8.ExecuteReader();

        dr8.Read();
        if (dr8.HasRows)
        {
            s8 = dr8[0].ToString();
        }
        else
        {
            s8 = "";
        }





        String str12 = "select date from notifyadmin where pos='" + smax + "'";
        OdbcCommand cmd12 = new OdbcCommand(str12, con);
        OdbcDataReader dr12 = cmd12.ExecuteReader();

        dr12.Read();
        if (dr12.HasRows)
        {
            s12 = dr12[0].ToString();
        }
        else
        {
            s12 = "";
        }







        String str16 = "select time from notifyadmin where pos='" + smax + "'";
        OdbcCommand cmd16 = new OdbcCommand(str16, con);
        OdbcDataReader dr16 = cmd16.ExecuteReader();

        dr16.Read();
        if (dr16.HasRows)
        {
            s16 = dr16[0].ToString();
        }
        else
        {
            s16 = "";
        }






        String str20 = "select details from notifyadmin where pos='" + smax + "'";
        OdbcCommand cmd20 = new OdbcCommand(str20, con);
        OdbcDataReader dr20 = cmd20.ExecuteReader();

        dr20.Read();
        if (dr20.HasRows)
        {
            s20 = dr20[0].ToString();
        }
        else
        {
            s20 = "";
        }



        con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        String str = "delete from notifyadmin where pos='"+btn1+"'";
        OdbcCommand cmd = new OdbcCommand(str, con);
        cmd.ExecuteNonQuery();
        con.Close();
        this.Page_Load(null, null);
     
        
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        con.Open();
        String str = "delete from notifyadmin where pos='" + btn2 + "'";
        OdbcCommand cmd = new OdbcCommand(str, con);
        cmd.ExecuteNonQuery();

        String str1 = "update notifyadmin set pos='"+btn2+"' where pos='" + btn1 + "'";
        OdbcCommand cmd1 = new OdbcCommand(str1, con);
        cmd1.ExecuteNonQuery();

        con.Close();
        this.Page_Load(null, null);
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        con.Open();
        String str = "delete from notifyadmin where pos='" + btn3 + "'";
        OdbcCommand cmd = new OdbcCommand(str, con);
        cmd.ExecuteNonQuery();

        String str1 = "update notifyadmin set pos='" + btn3 + "' where pos='" + btn2 + "'";
        OdbcCommand cmd1 = new OdbcCommand(str1, con);
        cmd1.ExecuteNonQuery();

        String str2 = "update notifyadmin set pos='" + btn2 + "' where pos='" + btn1 + "'";
        OdbcCommand cmd2 = new OdbcCommand(str2, con);
        cmd2.ExecuteNonQuery();

        con.Close();
        this.Page_Load(null, null);
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        con.Open();
        String str = "delete from notifyadmin where pos='" + btn4 + "'";
        OdbcCommand cmd = new OdbcCommand(str, con);
        cmd.ExecuteNonQuery();

        String str1 = "update notifyadmin set pos='" + btn4 + "' where pos='" + btn3 + "'";
        OdbcCommand cmd1 = new OdbcCommand(str1, con);
        cmd1.ExecuteNonQuery();

        String str2 = "update notifyadmin set pos='" + btn3 + "' where pos='" + btn2 + "'";
        OdbcCommand cmd2 = new OdbcCommand(str2, con);
        cmd2.ExecuteNonQuery();

        String str3 = "update notifyadmin set pos='" + btn2 + "' where pos='" + btn1 + "'";
        OdbcCommand cmd3 = new OdbcCommand(str3, con);
        cmd3.ExecuteNonQuery();

        con.Close();
        this.Page_Load(null, null);
    }
}
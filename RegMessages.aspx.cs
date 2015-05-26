using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;
using System.Web.Configuration;

public partial class RegMessages : System.Web.UI.Page
{
    OdbcConnection con = new OdbcConnection(WebConfigurationManager.ConnectionStrings["myConnectionString"].ToString());

    int smax, smax2, smax3, smax4;

   
   
    public String schk = "", rch1 = "", rch2 = "", rch3 = "", rch4 = "", s1 = "BonVoyageInc", s2 = "BonVoyageInc", s3 = "BonVoyageInc", s4 = "BonVoyageInc", s5 = "12-03-2015", s6 = "8-03-2015", s7 = "5-03-2015", s8 = "12-06-2015", s9 = "06:49 PM", s10 = "06:56 PM", s11 = "06:32 PM", s12 = "03:49 PM", s13 = "advertise bonvoyage spread the word of happy journey", s14 = "advertise bonvoyage spread the word of happy journey", s15 = "advertise bonvoyage spread the word of happy journey", s16 = "advertise bonvoyage spread the word of happy journey", s17 = "server_images/m1.jpg", s18 = "server_images/m1.jpg", s19 = "server_images/m1.jpg", s20 = "server_images/m1.jpg";
    
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
    public string simg1 { get { return s17; } }
    public string simg2 { get { return s18; } }
    public string simg3 { get { return s19; } }
    public string simg4 { get { return s20; } }
    




    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();

        String check = "select Mailid from user where status=1";
        OdbcCommand cmdcheck = new OdbcCommand(check, con);
        OdbcDataReader drchk = cmdcheck.ExecuteReader();

        drchk.Read();
        if (drchk.HasRows)
        {
            schk = drchk[0].ToString();

        }

        String sm1 = "select max(pos) from messageuser where reach='all' or reach='"+ schk +"'";
        OdbcCommand smk1 = new OdbcCommand(sm1, con);
        OdbcDataReader sel1 = smk1.ExecuteReader();

        sel1.Read();
        if (sel1.HasRows)
        {
            if (sel1[0].ToString() == "")
            {
                smax = 0;
            }
            else
            {
                smax = Convert.ToInt32(sel1[0].ToString());
            
            }
        }

        String sm2 = "select max(pos) from messageuser where (reach='all' and pos< '"+smax+"') or (reach='" + schk + "' and pos<'"+smax+"')";
        OdbcCommand smk2 = new OdbcCommand(sm2, con);
        OdbcDataReader sel2 = smk2.ExecuteReader();

        sel2.Read();
        if (sel2.HasRows)
        {
            if (sel2[0].ToString() == "")
            {
                smax2 = 0;
            }
            else
            {
                smax2 = Convert.ToInt32(sel2[0].ToString());
                
            }
        }

        String sm3 = "select max(pos) from messageuser where (reach='all' and pos< '" + smax2 + "') or (reach='" + schk + "' and pos<'" + smax2 + "')";
        OdbcCommand smk3 = new OdbcCommand(sm3, con);
        OdbcDataReader sel3 = smk3.ExecuteReader();

        sel3.Read();
        if (sel3.HasRows)
        {
            if (sel3[0].ToString() == "")
            {
                smax3 = 0;
            }
            else
            {
                smax3 = Convert.ToInt32(sel3[0].ToString());

            }
        }

        String sm4 = "select max(pos) from messageuser where (reach='all' and pos< '" + smax3 + "') or (reach='" + schk + "' and pos<'" + smax3 + "')";
        OdbcCommand smk4 = new OdbcCommand(sm4, con);
        OdbcDataReader sel4 = smk4.ExecuteReader();

        sel4.Read();
        if (sel4.HasRows)
        {
            if (sel4[0].ToString() == "")
            {
                smax4 = 0;
            }
            else
            {
                smax4 = Convert.ToInt32(sel3[0].ToString());

            }
        }

      
            String str1 = "select header from messageuser where pos='"+smax+"'";
            OdbcCommand cmd1 = new OdbcCommand(str1, con);
            OdbcDataReader dr1 = cmd1.ExecuteReader();

            dr1.Read();
            if (dr1.HasRows)
            {
                s1 = dr1[0].ToString();

            }


            String str5 = "select date from messageuser where pos='" + smax + "'";
            OdbcCommand cmd5 = new OdbcCommand(str5, con);
            OdbcDataReader dr5 = cmd5.ExecuteReader();

            dr5.Read();
            if (dr5.HasRows)
            {
                s5 = dr5[0].ToString();
            }


            String str9 = "select time from messageuser where pos='" + smax + "'";
            OdbcCommand cmd9 = new OdbcCommand(str9, con);
            OdbcDataReader dr9 = cmd9.ExecuteReader();

            dr9.Read();
            if (dr9.HasRows)
            {
                s9 = dr9[0].ToString();
            }


            String str13 = "select message from messageuser where pos='" + smax + "'";
            OdbcCommand cmd13 = new OdbcCommand(str13, con);
            OdbcDataReader dr13 = cmd13.ExecuteReader();

            dr13.Read();
            if (dr13.HasRows)
            {
                s13 = dr13[0].ToString();
            }

            String str17 = "select imageLink from messageuser where pos='" + smax + "'";
            OdbcCommand cmd17 = new OdbcCommand(str17, con);
            OdbcDataReader dr17 = cmd17.ExecuteReader();

            dr17.Read();
            if (dr17.HasRows)
            {
                s17 = dr17[0].ToString();
            }
           
                    
            
            String str2 = "select header from messageuser where pos='" + smax2 + "'";
            OdbcCommand cmd2 = new OdbcCommand(str2, con);
            OdbcDataReader dr2 = cmd2.ExecuteReader();

            dr2.Read();
            if (dr2.HasRows)
            {
                s2 = dr2[0].ToString();
            }

            String str6 = "select date from messageuser where pos='" + smax2 + "'";
            OdbcCommand cmd6 = new OdbcCommand(str6, con);
            OdbcDataReader dr6 = cmd6.ExecuteReader();

            dr6.Read();
            if (dr6.HasRows)
            {
                s6 = dr6[0].ToString();
            }

            String str10 = "select time from messageuser where pos='" + smax2 + "'";
            OdbcCommand cmd10 = new OdbcCommand(str10, con);
            OdbcDataReader dr10 = cmd10.ExecuteReader();

            dr10.Read();
            if (dr10.HasRows)
            {
                s10 = dr10[0].ToString();
            }

            String str14 = "select message from messageuser where pos='" + smax2 + "'";
            OdbcCommand cmd14 = new OdbcCommand(str14, con);
            OdbcDataReader dr14 = cmd14.ExecuteReader();

            dr14.Read();
            if (dr14.HasRows)
            {
                s14 = dr14[0].ToString();
            }

            String str18 = "select imageLink from messageuser where pos='" + smax2 + "'";
            OdbcCommand cmd18 = new OdbcCommand(str18, con);
            OdbcDataReader dr18 = cmd18.ExecuteReader();

            dr18.Read();
            if (dr18.HasRows)
            {
                s18 = dr18[0].ToString();
            }

            String str3 = "select header from messageuser where pos='" + smax3 + "'";
            OdbcCommand cmd3 = new OdbcCommand(str3, con);
            OdbcDataReader dr3 = cmd3.ExecuteReader();

            dr3.Read();
            if (dr3.HasRows)
            {
                s3 = dr3[0].ToString();
            }

            String str7 = "select date from messageuser where pos='" + smax3 + "'";
            OdbcCommand cmd7 = new OdbcCommand(str7, con);
            OdbcDataReader dr7 = cmd7.ExecuteReader();

            dr7.Read();
            if (dr7.HasRows)
            {
                s7 = dr7[0].ToString();
            }


            String str11 = "select time from messageuser where pos='" + smax3 + "'";
            OdbcCommand cmd11 = new OdbcCommand(str11, con);
            OdbcDataReader dr11 = cmd11.ExecuteReader();

            dr11.Read();
            if (dr11.HasRows)
            {
                s11 = dr11[0].ToString();
            }


            String str15 = "select message from messageuser where pos='" + smax3 + "'";
            OdbcCommand cmd15 = new OdbcCommand(str15, con);
            OdbcDataReader dr15 = cmd15.ExecuteReader();

            dr15.Read();
            if (dr15.HasRows)
            {
                s15 = dr15[0].ToString();
            }

            String str19 = "select imageLink from messageuser where pos='" + smax3 + "'";
            OdbcCommand cmd19 = new OdbcCommand(str19, con);
            OdbcDataReader dr19 = cmd19.ExecuteReader();

            dr19.Read();
            if (dr19.HasRows)
            {
                s19 = dr19[0].ToString();
            }

           
        

            String str4 = "select header from messageuser where pos='" + smax4 + "'";
            OdbcCommand cmd4 = new OdbcCommand(str4, con);
            OdbcDataReader dr4 = cmd4.ExecuteReader();

            dr4.Read();
            if (dr4.HasRows)
            {
                s4 = dr4[0].ToString();
            }


            String str8 = "select date from messageuser where pos='" + smax4 + "'";
            OdbcCommand cmd8 = new OdbcCommand(str8, con);
            OdbcDataReader dr8 = cmd8.ExecuteReader();

            dr8.Read();
            if (dr8.HasRows)
            {
                s8 = dr8[0].ToString();
            }


            String str12 = "select time from messageuser where pos='" + smax4 + "'";
            OdbcCommand cmd12 = new OdbcCommand(str12, con);
            OdbcDataReader dr12 = cmd12.ExecuteReader();

            dr12.Read();
            if (dr12.HasRows)
            {
                s12 = dr12[0].ToString();
            }


            String str16 = "select message from messageuser where pos='" + smax4 + "'";
            OdbcCommand cmd16 = new OdbcCommand(str16, con);
            OdbcDataReader dr16 = cmd16.ExecuteReader();

            dr16.Read();
            if (dr16.HasRows)
            {
                s16 = dr16[0].ToString();
            }

            String str20 = "select imageLink from messageuser where pos='" + smax4 + "'";
            OdbcCommand cmd20 = new OdbcCommand(str20, con);
            OdbcDataReader dr20 = cmd20.ExecuteReader();

            dr20.Read();
            if (dr20.HasRows)
            {
                s20 = dr20[0].ToString();
            }

        con.Close();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        String str = "delete from messageuser where pos='" + smax + "'";
        OdbcCommand cmd = new OdbcCommand(str, con);
        cmd.ExecuteNonQuery();
        con.Close();
        this.Page_Load(null, null);
     
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        con.Open();
        String str = "delete from messageuser where pos='" + smax2 + "'";
        OdbcCommand cmd = new OdbcCommand(str, con);
        cmd.ExecuteNonQuery();
        if (smax2 != 0)
        {

            String str1 = "update messageuser set pos='" + smax2 + "' where pos='" + smax + "'";
            OdbcCommand cmd1 = new OdbcCommand(str1, con);
            cmd1.ExecuteNonQuery();
        }
        con.Close();
        this.Page_Load(null, null);
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        con.Open();
        String str = "delete from messageuser where pos='" + smax3 + "'";
        OdbcCommand cmd = new OdbcCommand(str, con);
        cmd.ExecuteNonQuery();
        if (smax3 != 0)
        {
            String str1 = "update messageuser set pos='" + smax3 + "' where pos='" + smax2 + "'";
            OdbcCommand cmd1 = new OdbcCommand(str1, con);
            cmd1.ExecuteNonQuery();

            String str2 = "update messageuser set pos='" + smax2 + "' where pos='" + smax + "'";
            OdbcCommand cmd2 = new OdbcCommand(str2, con);
            cmd2.ExecuteNonQuery();

            con.Close();
            this.Page_Load(null, null);
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        con.Open();
        String str = "delete from messageuser where pos='" + smax4 + "'";
        OdbcCommand cmd = new OdbcCommand(str, con);
        cmd.ExecuteNonQuery();
        if (smax4 != 0)
        {
            String str1 = "update messageuser set pos='" + smax4 + "' where pos='" + smax3 + "'";
            OdbcCommand cmd1 = new OdbcCommand(str1, con);
            cmd1.ExecuteNonQuery();

            String str2 = "update messageuser set pos='" + smax3 + "' where pos='" + smax2 + "'";
            OdbcCommand cmd2 = new OdbcCommand(str2, con);
            cmd2.ExecuteNonQuery();

            String str3 = "update messageuser set pos='" + smax2 + "' where pos='" + smax + "'";
            OdbcCommand cmd3 = new OdbcCommand(str3, con);
            cmd3.ExecuteNonQuery();
        }
        con.Close();
        this.Page_Load(null, null);
    }
}
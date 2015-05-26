using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;
using System.Web.Configuration;

public partial class TouristSpots : System.Web.UI.Page
{
    OdbcConnection con = new OdbcConnection(WebConfigurationManager.ConnectionStrings["myConnectionString"].ToString());

    String sname,snameorg;

    public String  s1 = "", s2 = "", s3 = "", s4 = "", s5 = "", s6 = "", s7 = "", s8 = "", s9 = "", s10 = "", s11 = "", s12 = "", s13 = "", s14 = "", s15 = "", s16 = "", s17 = "", s18 = "", s19 = "", s20 = "",s21="",s22="",s23="",s24="";
    int sminstr1, mintemp1, smaxstr1, sminstr2, mintemp2, smaxstr2, sminstr3, mintemp3, smaxstr3, sminstr4, mintemp4, smaxstr4;

    public string sh1 { get { return s1; } }
    public string sd1 { get { return s2; } }
    public string sim1 { get { return s3; } }
    public string sim2 { get { return s4; } }
    public string sim3 { get { return s5; } }
    public string sim4 { get { return s6; } }
    public string sh2 { get { return s7; } }
    public string sd2 { get { return s8; } }
    public string sif1 { get { return s9; } }
    public string sif2{ get { return s10; } }
    public string sif3{ get { return s11; } }
    public string sif4 { get { return s12; } }
    public string sh3 { get { return s13; } }
    public string sd3 { get { return s14; } }
    public string siw1 { get { return s15; } }
    public string siw2{ get { return s16; } }
    public string siw3 { get { return s17; } }
    public string siw4 { get { return s18; } }
    public string sh4 { get { return s19; } }
    public string sd4 { get { return s20; } }
    public string sik1 { get { return s21; } }
    public string sik2 { get { return s22; } }
    public string sik3 { get { return s23; } }
    public string sik4 { get { return s24; } }
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();


        String z = "select Mailid from user where status=1";
        OdbcCommand cmdorg = new OdbcCommand(z, con);
        OdbcDataReader dnameorg = cmdorg.ExecuteReader();

        dnameorg.Read();
        if (dnameorg.HasRows)
        {
            snameorg = dnameorg[0].ToString();
           


        }

        String n = "select mailid from usertemp where mailid='"+snameorg +"'";
        OdbcCommand cmdname = new OdbcCommand(n, con);
        OdbcDataReader dname = cmdname.ExecuteReader();

        dname.Read();
        if (dname.HasRows)
        {
            sname = dname[0].ToString();

            Button1.Text = "View customised pack";

        }



        String str1 = "select Area from touristareas where Area_code='mn'";
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

        String str2 = "select small_description from touristareas where Area_code='mn' ";
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

        String smin1 = "select min(pos) from imagespath where image_code='mn'";
        OdbcCommand cmdmin1 = new OdbcCommand(smin1, con);
        OdbcDataReader drmin1 = cmdmin1.ExecuteReader();

        drmin1.Read();
        if (drmin1.HasRows)
        {
            sminstr1 = Convert.ToInt32(drmin1[0].ToString());
            mintemp1 = sminstr1;
        }
        String smax1 = "select max(pos) from imagespath where image_code='mn'";
        OdbcCommand cmdmax1 = new OdbcCommand(smax1, con);
        OdbcDataReader drmax1 = cmdmax1.ExecuteReader();

        drmax1.Read();
        if (drmax1.HasRows)
        {
            smaxstr1 = Convert.ToInt32(drmax1[0].ToString());

        }



        String str3 = "select  path from imagespath where image_code='mn' and pos='" + mintemp1 + "'";
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
        ++mintemp1;
        String str4 = "select  path from imagespath where image_code='mn' and pos='" + mintemp1 + "'";
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
        ++mintemp1;
        String str5 = "select  path from imagespath where image_code='mn' and pos='" + mintemp1 + "'";
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
        ++mintemp1;
        String str6 = "select  path from imagespath where image_code='mn' and pos='" + mintemp1 + "'";
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

       

        String str7 = "select Area from touristareas where Area_code='fk'";
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
        String str8 = "select small_description from touristareas where Area_code='fk'";
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

        String smin2 = "select min(pos) from imagespath where image_code='fk'";
        OdbcCommand cmdmin2 = new OdbcCommand(smin2, con);
        OdbcDataReader drmin2 = cmdmin2.ExecuteReader();

        drmin2.Read();
        if (drmin2.HasRows)
        {
            sminstr2 = Convert.ToInt32(drmin2[0].ToString());
            mintemp2 = sminstr2;
        }
        String smax2 = "select max(pos) from imagespath where image_code='fk'";
        OdbcCommand cmdmax2 = new OdbcCommand(smax2, con);
        OdbcDataReader drmax2 = cmdmax2.ExecuteReader();

        drmax2.Read();
        if (drmax2.HasRows)
        {
            smaxstr2 = Convert.ToInt32(drmax2[0].ToString());

        }

        String str9 = "select  path from imagespath where image_code='fk' and pos='" + mintemp2 + "'";
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
        ++mintemp2;
        String str10 = "select  path from imagespath where image_code='fk' and pos='" + mintemp2 + "'";
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
        ++mintemp2;
        String str11 = "select  path from imagespath where image_code='fk' and pos='" + mintemp2 + "'";
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
        ++mintemp2;
        String str12 = "select  path from imagespath where image_code='fk' and pos='" + mintemp2 + "'";
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


        String str13 = "select Area from touristareas where Area_code='wy'";
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


        String str14 = "select small_description from touristareas where Area_code='wy'";
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

        String smin3 = "select min(pos) from imagespath where image_code='wy'";
        OdbcCommand cmdmin3 = new OdbcCommand(smin3, con);
        OdbcDataReader drmin3 = cmdmin3.ExecuteReader();

        drmin3.Read();
        if (drmin3.HasRows)
        {
            sminstr3 = Convert.ToInt32(drmin3[0].ToString());
            mintemp3 = sminstr3;
        }
        String smax3 = "select max(pos) from imagespath where image_code='wy'";
        OdbcCommand cmdmax3 = new OdbcCommand(smax3, con);
        OdbcDataReader drmax3 = cmdmax3.ExecuteReader();

        drmax3.Read();
        if (drmax3.HasRows)
        {
            smaxstr3 = Convert.ToInt32(drmax3[0].ToString());

        }
        String str15 = "select  path from imagespath where image_code='wy' and pos='" + mintemp3 + "'";
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
        ++mintemp3;
        String str16 = "select  path from imagespath where image_code='wy' and pos='" + mintemp3 + "'";
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
        ++mintemp3;
        String str17 = "select  path from imagespath where image_code='wy' and pos='" + mintemp3 + "'";
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
        ++mintemp3;
        String str18 = "select  path from imagespath where image_code='wy' and pos='" + mintemp3 + "'";
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

        String str19 = "select Area from touristareas where Area_code='km'";
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

        String str20 = "select small_description from touristareas where Area_code='km'";
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

        String smin4 = "select min(pos) from imagespath where image_code='km'";
        OdbcCommand cmdmin4 = new OdbcCommand(smin4, con);
        OdbcDataReader drmin4 = cmdmin4.ExecuteReader();

        drmin4.Read();
        if (drmin4.HasRows)
        {
            sminstr4 = Convert.ToInt32(drmin4[0].ToString());
            mintemp4 = sminstr4;
        }
        String smax4 = "select max(pos) from imagespath where image_code='km'";
        OdbcCommand cmdmax4 = new OdbcCommand(smax4, con);
        OdbcDataReader drmax4 = cmdmax4.ExecuteReader();

        drmax4.Read();
        if (drmax4.HasRows)
        {
            smaxstr4 = Convert.ToInt32(drmax4[0].ToString());

        }



        String str21 = "select  path from imagespath where image_code='km' and pos='" + mintemp4 + "'";
        OdbcCommand cmd21 = new OdbcCommand(str21, con);
        OdbcDataReader dr21 = cmd21.ExecuteReader();

        dr21.Read();
        if (dr21.HasRows)
        {
            s21 = dr21[0].ToString();
        }
        else
        {
            s21 = "";
        }
        ++mintemp4;
        String str22 = "select  path from imagespath where image_code='km' and pos='" + mintemp4 + "'";
        OdbcCommand cmd22 = new OdbcCommand(str22, con);
        OdbcDataReader dr22 = cmd22.ExecuteReader();

        dr22.Read();
        if (dr22.HasRows)
        {
            s22 = dr22[0].ToString();
        }
        else
        {
            s22 = "";
        }
        ++mintemp4;
        String str23 = "select  path from imagespath where image_code='km' and pos='" + mintemp4 + "'";
        OdbcCommand cmd23 = new OdbcCommand(str23, con);
        OdbcDataReader dr23 = cmd23.ExecuteReader();

        dr23.Read();
        if (dr23.HasRows)
        {
            s23 = dr23[0].ToString();
        }
        else
        {
            s23 = "";
        }
        ++mintemp4;
        String str24 = "select  path from imagespath where image_code='km' and pos='" + mintemp4 + "'";
        OdbcCommand cmd24 = new OdbcCommand(str24, con);
        OdbcDataReader dr24 = cmd24.ExecuteReader();

        dr24.Read();
        if (dr24.HasRows)
        {
            s24 = dr24[0].ToString();
        }
        else
        {
            s24 = "";
        }
        con.Close();
    }

    protected void Button1_Click(object sender, EventArgs e)
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
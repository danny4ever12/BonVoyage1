using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;
using System.Web.Configuration;

public partial class st_mnr1 : System.Web.UI.Page
{

    OdbcConnection con = new OdbcConnection(WebConfigurationManager.ConnectionStrings["myConnectionString"].ToString());
    int sminstr, mintemp, smaxstr, minhtl, temp, maxhtl;

    int sminstr1, mintemp1, smaxstr1;
    static String h1, h2, h3, h4, h5, h6, h7, h8, h9;

    public String s1, s2, s3, s4, s5, s6, s7, s8, s9;
    //notifybtn
    String sname = "", snametmp = "";



    public string sh1 { get { return s1; } }
    public string sd1 { get { return s2; } }
    public string si1 { get { return s3; } }
    public string si2 { get { return s4; } }
    public string si3 { get { return s5; } }
    public string si4 { get { return s6; } }
    public string sr1 { get { return s7; } }
    public string sr2 { get { return s8; } }
    public string sr3 { get { return s9; } }


    public string sm1 { get { return h1; } }
    public string sm2 { get { return h2; } }
    public string sm3 { get { return h3; } }
    public string sm4 { get { return h4; } }
    public string sm5 { get { return h5; } }
    public string sm6 { get { return h6; } }
    public string sm7 { get { return h7; } }
    public string sm8 { get { return h8; } }
    public string sm9 { get { return h9; } }

    protected void Page_Load(object sender, EventArgs e)
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

        }

        String nt = "select mailid from usertemp where mailid='" + sname + "'";
        OdbcCommand cmdnamet = new OdbcCommand(nt, con);
        OdbcDataReader dnamet = cmdnamet.ExecuteReader();

        dnamet.Read();
        if (dnamet.HasRows)
        {


            Button5.Text = "View customised pack";

        }
     

        String str1 = "select SpotName from locations where HotelCode='mne'";
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

        String str2 = "select description from locations where HotelCode='mne'";
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

        String smin = "select min(pos) from imagespath where image_code='mne'";
        OdbcCommand cmdmin = new OdbcCommand(smin, con);
        OdbcDataReader drmin = cmdmin.ExecuteReader();

        drmin.Read();
        if (drmin.HasRows)
        {
            sminstr = Convert.ToInt32(drmin[0].ToString());
            mintemp = sminstr;
        }
        String smax = "select max(pos) from imagespath where image_code='mne'";
        OdbcCommand cmdmax = new OdbcCommand(smax, con);
        OdbcDataReader drmax = cmdmax.ExecuteReader();

        drmax.Read();
        if (drmax.HasRows)
        {
            smaxstr = Convert.ToInt32(drmax[0].ToString());

        }



        String str3 = "select  path from imagespath where image_code='mne' and pos='" + mintemp + "'";
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
        ++mintemp;
        String str4 = "select  path from imagespath where image_code='mne' and pos='" + mintemp + "'";
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
        ++mintemp;
        String str5 = "select  path from imagespath where image_code='mne' and pos='" + mintemp + "'";
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
        ++mintemp;
        String str6 = "select  path from imagespath where image_code='mne' and pos='" + mintemp + "'";
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



        String sminhtl = "select min(pos) from imagespath where image_code='mne'";
        OdbcCommand cmdminhtl = new OdbcCommand(sminhtl, con);
        OdbcDataReader drminhtl = cmdminhtl.ExecuteReader();

        drminhtl.Read();
        if (drminhtl.HasRows)
        {
            minhtl = Convert.ToInt32(drminhtl[0].ToString());
            temp = sminstr;
        }
        String smaxhtl = "select max(pos) from imagespath where image_code='mne'";
        OdbcCommand cmdmaxhtl = new OdbcCommand(smaxhtl, con);
        OdbcDataReader drmaxhtl = cmdmaxhtl.ExecuteReader();

        drmaxhtl.Read();
        if (drmaxhtl.HasRows)
        {
            maxhtl = Convert.ToInt32(drmaxhtl[0].ToString());

        }



        String str7 = "select hotel_name from hotels where hotel_code='mne' and pos='" + temp + "'";
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
        ++temp;
        String str8 = "select hotel_name from hotels where hotel_code='mne' and pos='" + temp + "'";
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
        ++temp;
        String str9 = "select hotel_name from hotels where hotel_code='mne' and pos='" + temp + "'";
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

        con.Close();
    }


    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        con.Open();

        String smin1 = "select min(pos) from rooms where room_code='mne1'";
        OdbcCommand cmdmin1 = new OdbcCommand(smin1, con);
        OdbcDataReader drmin1 = cmdmin1.ExecuteReader();

        drmin1.Read();
        if (drmin1.HasRows)
        {
            sminstr1 = Convert.ToInt32(drmin1[0].ToString());
            mintemp1 = sminstr1;
        }
        String smax1 = "select max(pos) from rooms where room_code='mne1'";
        OdbcCommand cmdmax1 = new OdbcCommand(smax1, con);
        OdbcDataReader drmax1 = cmdmax1.ExecuteReader();

        drmax1.Read();
        if (drmax1.HasRows)
        {
            smaxstr1 = Convert.ToInt32(drmax1[0].ToString());

        }
        String str1 = "select room from rooms where room_code='mne1' and pos='" + mintemp1 + "'";
        OdbcCommand cmd1 = new OdbcCommand(str1, con);
        OdbcDataReader dr1 = cmd1.ExecuteReader();

        dr1.Read();
        if (dr1.HasRows)
        {
            h1 = dr1[0].ToString();

        }
        else
        {
            h1 = "";
        }

        String str2 = "select facilities from rooms where room_code='mne1' and pos='" + mintemp1 + "'";
        OdbcCommand cmd2 = new OdbcCommand(str2, con);
        OdbcDataReader dr2 = cmd2.ExecuteReader();

        dr2.Read();
        if (dr2.HasRows)
        {
            h2 = dr2[0].ToString();
        }
        else
        {
            h2 = "";
        }


        String str3 = "select price_rate from rooms where room_code='mne1' and pos='" + mintemp1 + "'";
        OdbcCommand cmd3 = new OdbcCommand(str3, con);
        OdbcDataReader dr3 = cmd3.ExecuteReader();

        dr3.Read();
        if (dr3.HasRows)
        {
            h3 = dr3[0].ToString();
        }
        else
        {
            h3 = "";
        }
        ++mintemp1;
        String str4 = "select room from rooms where room_code='mne1' and pos='" + mintemp1 + "'";
        OdbcCommand cmd4 = new OdbcCommand(str4, con);
        OdbcDataReader dr4 = cmd4.ExecuteReader();

        dr4.Read();
        if (dr4.HasRows)
        {
            h4 = dr4[0].ToString();
        }
        else
        {
            h4 = "";
        }

        String str5 = "select facilities from rooms where room_code='mne1' and pos='" + mintemp1 + "'";
        OdbcCommand cmd5 = new OdbcCommand(str5, con);
        OdbcDataReader dr5 = cmd5.ExecuteReader();

        dr5.Read();
        if (dr5.HasRows)
        {
            h5 = dr5[0].ToString();
        }
        else
        {
            h5 = "";
        }

        String str6 = "select price_rate from rooms where room_code='mne1' and pos='" + mintemp1 + "'";
        OdbcCommand cmd6 = new OdbcCommand(str6, con);
        OdbcDataReader dr6 = cmd6.ExecuteReader();

        dr6.Read();
        if (dr6.HasRows)
        {
            h6 = dr6[0].ToString();
        }
        else
        {
            h6 = "";
        }
        ++mintemp1;
        String str7 = "select room from rooms where room_code='mne1' and pos='" + mintemp1 + "'";
        OdbcCommand cmd7 = new OdbcCommand(str7, con);
        OdbcDataReader dr7 = cmd7.ExecuteReader();

        dr7.Read();
        if (dr7.HasRows)
        {
            h7 = dr7[0].ToString();
        }
        else
        {
            h7 = "";
        }

        String str8 = "select facilities from rooms where room_code='mne1' and pos='" + mintemp1 + "'";
        OdbcCommand cmd8 = new OdbcCommand(str8, con);
        OdbcDataReader dr8 = cmd8.ExecuteReader();

        dr8.Read();
        if (dr8.HasRows)
        {
            h8 = dr8[0].ToString();
        }
        else
        {
            h8 = "";
        }

        String str9 = "select price_rate from rooms where room_code='mne1' and pos='" + mintemp1 + "'";
        OdbcCommand cmd9 = new OdbcCommand(str9, con);
        OdbcDataReader dr9 = cmd9.ExecuteReader();

        dr9.Read();
        if (dr9.HasRows)
        {
            h9 = dr9[0].ToString();
        }
        else
        {
            h9 = "";
        }

        con.Close();


    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        con.Open();

        String smin1 = "select min(pos) from rooms where room_code='mne2'";
        OdbcCommand cmdmin1 = new OdbcCommand(smin1, con);
        OdbcDataReader drmin1 = cmdmin1.ExecuteReader();

        drmin1.Read();
        if (drmin1.HasRows)
        {
            sminstr1 = Convert.ToInt32(drmin1[0].ToString());
            mintemp1 = sminstr1;
        }
        String smax1 = "select max(pos) from rooms where room_code='mne2'";
        OdbcCommand cmdmax1 = new OdbcCommand(smax1, con);
        OdbcDataReader drmax1 = cmdmax1.ExecuteReader();

        drmax1.Read();
        if (drmax1.HasRows)
        {
            smaxstr1 = Convert.ToInt32(drmax1[0].ToString());

        }
        String str1 = "select room from rooms where room_code='mne2' and pos='" + mintemp1 + "'";
        OdbcCommand cmd1 = new OdbcCommand(str1, con);
        OdbcDataReader dr1 = cmd1.ExecuteReader();

        dr1.Read();
        if (dr1.HasRows)
        {
            h1 = dr1[0].ToString();

        }
        else
        {
            h1 = "";
        }

        String str2 = "select facilities from rooms where room_code='mne2' and pos='" + mintemp1 + "'";
        OdbcCommand cmd2 = new OdbcCommand(str2, con);
        OdbcDataReader dr2 = cmd2.ExecuteReader();

        dr2.Read();
        if (dr2.HasRows)
        {
            h2 = dr2[0].ToString();
        }
        else
        {
            h2 = "";
        }


        String str3 = "select price_rate from rooms where room_code='mne2' and pos='" + mintemp1 + "'";
        OdbcCommand cmd3 = new OdbcCommand(str3, con);
        OdbcDataReader dr3 = cmd3.ExecuteReader();

        dr3.Read();
        if (dr3.HasRows)
        {
            h3 = dr3[0].ToString();
        }
        else
        {
            h3 = "";
        }
        ++mintemp1;
        String str4 = "select room from rooms where room_code='mne2' and pos='" + mintemp1 + "'";
        OdbcCommand cmd4 = new OdbcCommand(str4, con);
        OdbcDataReader dr4 = cmd4.ExecuteReader();

        dr4.Read();
        if (dr4.HasRows)
        {
            h4 = dr4[0].ToString();
        }
        else
        {
            h4 = "";
        }

        String str5 = "select facilities from rooms where room_code='mne2' and pos='" + mintemp1 + "'";
        OdbcCommand cmd5 = new OdbcCommand(str5, con);
        OdbcDataReader dr5 = cmd5.ExecuteReader();

        dr5.Read();
        if (dr5.HasRows)
        {
            h5 = dr5[0].ToString();
        }
        else
        {
            h5 = "";
        }

        String str6 = "select price_rate from rooms where room_code='mne2' and pos='" + mintemp1 + "'";
        OdbcCommand cmd6 = new OdbcCommand(str6, con);
        OdbcDataReader dr6 = cmd6.ExecuteReader();

        dr6.Read();
        if (dr6.HasRows)
        {
            h6 = dr6[0].ToString();
        }
        else
        {
            h6 = "";
        }
        ++mintemp1;
        String str7 = "select room from rooms where room_code='mne2' and pos='" + mintemp1 + "'";
        OdbcCommand cmd7 = new OdbcCommand(str7, con);
        OdbcDataReader dr7 = cmd7.ExecuteReader();

        dr7.Read();
        if (dr7.HasRows)
        {
            h7 = dr7[0].ToString();
        }
        else
        {
            h7 = "";
        }

        String str8 = "select facilities from rooms where room_code='mne2' and pos='" + mintemp1 + "'";
        OdbcCommand cmd8 = new OdbcCommand(str8, con);
        OdbcDataReader dr8 = cmd8.ExecuteReader();

        dr8.Read();
        if (dr8.HasRows)
        {
            h8 = dr8[0].ToString();
        }
        else
        {
            h8 = "";
        }

        String str9 = "select price_rate from rooms where room_code='mne2' and pos='" + mintemp1 + "'";
        OdbcCommand cmd9 = new OdbcCommand(str9, con);
        OdbcDataReader dr9 = cmd9.ExecuteReader();

        dr9.Read();
        if (dr9.HasRows)
        {
            h9 = dr9[0].ToString();
        }
        else
        {
            h9 = "";
        }

        con.Close();


    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        con.Open();

        String smin1 = "select min(pos) from rooms where room_code='mne3'";
        OdbcCommand cmdmin1 = new OdbcCommand(smin1, con);
        OdbcDataReader drmin1 = cmdmin1.ExecuteReader();

        drmin1.Read();
        if (drmin1.HasRows)
        {
            sminstr1 = Convert.ToInt32(drmin1[0].ToString());
            mintemp1 = sminstr1;
        }
        String smax1 = "select max(pos) from rooms where room_code='mne3'";
        OdbcCommand cmdmax1 = new OdbcCommand(smax1, con);
        OdbcDataReader drmax1 = cmdmax1.ExecuteReader();

        drmax1.Read();
        if (drmax1.HasRows)
        {
            smaxstr1 = Convert.ToInt32(drmax1[0].ToString());

        }
        String str1 = "select room from rooms where room_code='mne3' and pos='" + mintemp1 + "'";
        OdbcCommand cmd1 = new OdbcCommand(str1, con);
        OdbcDataReader dr1 = cmd1.ExecuteReader();

        dr1.Read();
        if (dr1.HasRows)
        {
            h1 = dr1[0].ToString();

        }
        else
        {
            h1 = "";
        }

        String str2 = "select facilities from rooms where room_code='mne3' and pos='" + mintemp1 + "'";
        OdbcCommand cmd2 = new OdbcCommand(str2, con);
        OdbcDataReader dr2 = cmd2.ExecuteReader();

        dr2.Read();
        if (dr2.HasRows)
        {
            h2 = dr2[0].ToString();
        }
        else
        {
            h2 = "";
        }


        String str3 = "select price_rate from rooms where room_code='mne3' and pos='" + mintemp1 + "'";
        OdbcCommand cmd3 = new OdbcCommand(str3, con);
        OdbcDataReader dr3 = cmd3.ExecuteReader();

        dr3.Read();
        if (dr3.HasRows)
        {
            h3 = dr3[0].ToString();
        }
        else
        {
            h3 = "";
        }
        ++mintemp1;
        String str4 = "select room from rooms where room_code='mne3' and pos='" + mintemp1 + "'";
        OdbcCommand cmd4 = new OdbcCommand(str4, con);
        OdbcDataReader dr4 = cmd4.ExecuteReader();

        dr4.Read();
        if (dr4.HasRows)
        {
            h4 = dr4[0].ToString();
        }
        else
        {
            h4 = "";
        }

        String str5 = "select facilities from rooms where room_code='mne3' and pos='" + mintemp1 + "'";
        OdbcCommand cmd5 = new OdbcCommand(str5, con);
        OdbcDataReader dr5 = cmd5.ExecuteReader();

        dr5.Read();
        if (dr5.HasRows)
        {
            h5 = dr5[0].ToString();
        }
        else
        {
            h5 = "";
        }

        String str6 = "select price_rate from rooms where room_code='mne3' and pos='" + mintemp1 + "'";
        OdbcCommand cmd6 = new OdbcCommand(str6, con);
        OdbcDataReader dr6 = cmd6.ExecuteReader();

        dr6.Read();
        if (dr6.HasRows)
        {
            h6 = dr6[0].ToString();
        }
        else
        {
            h6 = "";
        }
        ++mintemp1;
        String str7 = "select room from rooms where room_code='mne3' and pos='" + mintemp1 + "'";
        OdbcCommand cmd7 = new OdbcCommand(str7, con);
        OdbcDataReader dr7 = cmd7.ExecuteReader();

        dr7.Read();
        if (dr7.HasRows)
        {
            h7 = dr7[0].ToString();
        }
        else
        {
            h7 = "";
        }

        String str8 = "select facilities from rooms where room_code='mne3' and pos='" + mintemp1 + "'";
        OdbcCommand cmd8 = new OdbcCommand(str8, con);
        OdbcDataReader dr8 = cmd8.ExecuteReader();

        dr8.Read();
        if (dr8.HasRows)
        {
            h8 = dr8[0].ToString();
        }
        else
        {
            h8 = "";
        }

        String str9 = "select price_rate from rooms where room_code='mne3' and pos='" + mintemp1 + "'";
        OdbcCommand cmd9 = new OdbcCommand(str9, con);
        OdbcDataReader dr9 = cmd9.ExecuteReader();

        dr9.Read();
        if (dr9.HasRows)
        {
            h9 = dr9[0].ToString();
        }
        else
        {
            h9 = "";
        }

        con.Close();

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        int pos = 0;
        String b;
        String n = "select Mailid from user where status=1";
        OdbcCommand cmdname = new OdbcCommand(n, con);
        OdbcDataReader dname = cmdname.ExecuteReader();

        dname.Read();
        if (dname.HasRows)
        {
            snametmp = dname[0].ToString();

            //
            String chk = "select mailid from usertemp where mailid='" + snametmp + "' and place='" + s1 + "'";
            OdbcCommand cmdchk = new OdbcCommand(chk, con);
            OdbcDataReader dchk = cmdchk.ExecuteReader();

            dchk.Read();
            if (dchk.HasRows)
            {
                Response.Write("<script>alert('This place was already added')</script>");
            }
            else
            {
                //


                String name = "select max(pos) from usertemp";
                OdbcCommand cmd1 = new OdbcCommand(name, con);
                OdbcDataReader dr1 = cmd1.ExecuteReader();
                dr1.Read();
                if (dr1.HasRows)
                {
                    pos = Convert.ToInt32(dr1[0].ToString());


                }
                //
                String bus = "select bus from usertemp where mailid='" + snametmp + "'";
                OdbcCommand cmdb = new OdbcCommand(bus, con);
                OdbcDataReader drb = cmdb.ExecuteReader();
                drb.Read();
                if (drb.HasRows)
                {
                    b = drb[0].ToString();
                }
                else
                {
                    b = " ";
                }
                //
                pos++;

                //
                String str = "insert into usertemp values('" + snametmp + "','" + s1 + "','not specified','not specified','not specified','" + b + "','" + pos + "')";
                //
                OdbcCommand cmd = new OdbcCommand(str, con);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('place added')</script>");

            }
        }
        else
        {
            Response.Write("<Script>alert('login or signUp to access this feature')</script>");
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        con.Open();
        String htl = "select hotel_name from hotels where roomcode='mne1'";
        OdbcCommand cmd1 = new OdbcCommand(htl, con);
        OdbcDataReader dr1 = cmd1.ExecuteReader();
        dr1.Read();

        //
        String mid = "select Mailid from user where status=1";
        OdbcCommand cmdmid = new OdbcCommand(mid, con);
        OdbcDataReader drmid = cmdmid.ExecuteReader();
        drmid.Read();

        //
        String str = "update usertemp set hotel='" + dr1[0].ToString() + "',room='" + h1 + "', days='" + TextBox1.Text + "' where place='" + s1 + "' and mailid='" + drmid[0].ToString() + "'";
        //
        OdbcCommand cmd = new OdbcCommand(str, con);
        cmd.ExecuteNonQuery();
        Response.Write("<script>alert('hotel details added')</script>");
        con.Close();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        con.Open();
        String htl = "select hotel_name from hotels where roomcode='mne2'";
        OdbcCommand cmd1 = new OdbcCommand(htl, con);
        OdbcDataReader dr1 = cmd1.ExecuteReader();
        dr1.Read();

        String mid = "select Mailid from user where status=1";
        OdbcCommand cmdmid = new OdbcCommand(mid, con);
        OdbcDataReader drmid = cmdmid.ExecuteReader();
        drmid.Read();

        String str = "update usertemp set hotel='" + dr1[0].ToString() + "',room='" + h4 + "', days='" + TextBox2.Text + "' where place='" + s1 + "' and mailid='" + drmid[0].ToString() + "'";
        OdbcCommand cmd = new OdbcCommand(str, con);
        cmd.ExecuteNonQuery();
        Response.Write("<script>alert('hotel details added')</script>");
        con.Close();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        con.Open();
        String htl = "select hotel_name from hotels where roomcode='mne3'";
        OdbcCommand cmd1 = new OdbcCommand(htl, con);
        OdbcDataReader dr1 = cmd1.ExecuteReader();
        dr1.Read();

        String mid = "select Mailid from user where status=1";
        OdbcCommand cmdmid = new OdbcCommand(mid, con);
        OdbcDataReader drmid = cmdmid.ExecuteReader();
        drmid.Read();

        String str = "update usertemp set hotel='" + dr1[0].ToString() + "',room='" + h7 + "', days='" + TextBox2.Text + "' where place='" + s1 + "' and mailid='" + drmid[0].ToString() + "'";
        OdbcCommand cmd = new OdbcCommand(str, con);
        cmd.ExecuteNonQuery();
        Response.Write("<script>alert('hotel details added')</script>");
        con.Close();
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
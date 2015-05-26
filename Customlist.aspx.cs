using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;
using System.Web.Configuration;


public partial class Customlist : System.Web.UI.Page
{
    String collide="";
    String sname="";
    int smax, smint,smint1,smint2,smint3;

    OdbcConnection con = new OdbcConnection(WebConfigurationManager.ConnectionStrings["myConnectionString"].ToString());

    int s4, s8,s11,s14;
    public String  MD,s1, s2, s3, s5, s6, s7,s9,s10,s12,s13,s15,s16,s17;
    public string sn1 { get { return s1; } }
    public string sh1 { get { return s2; } }
    public string sr1 { get { return s3; } }
    public int sd1 { get { return s4; } }
    public string sn2 { get { return s5; } }
    public string sh2 { get { return s6; } }
    public string sr2 { get { return s7; } }
    public int sd2 { get { return s8; } }

    public string sn3 { get { return s9; } }
    public string sh3 { get { return s10; } }
    public string sr3 { get { return s16; } }
    public int sd3 { get { return s11; } }

    public string sn4 { get { return s12; } }
    public string sh4 { get { return s13; } }
    public string sr4 { get { return s17; } }
    public int sd4 { get { return s14; } }

    public string sb1 { get { return s15; } }



    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();


        
        String org = "select Mailid from user where status=1";
        OdbcCommand cmdorg = new OdbcCommand(org, con);
        OdbcDataReader dorg = cmdorg.ExecuteReader();

        dorg.Read();
        if (dorg.HasRows)
        {
            MD = dorg[0].ToString();
        }

        String n = "select mailid from usertemp where mailid='"+MD+"'";
        OdbcCommand cmdname = new OdbcCommand(n, con);
        OdbcDataReader dname = cmdname.ExecuteReader();

        dname.Read();
        if (dname.HasRows)
        {
            sname = dname[0].ToString();
            Button1.Text = "click to finish customising your package";
            Button1.BackColor = System.Drawing.Color.Black;
            Button1.BorderColor =System.Drawing.Color.Black;
        }




        String sbtn = "select min(pos) from usertemp where mailid='"+sname+"'";
        OdbcCommand smin = new OdbcCommand(sbtn, con);
        OdbcDataReader selbtn = smin.ExecuteReader();

        selbtn.Read();
        if (selbtn.HasRows)
        {
            if (selbtn[0].ToString() == "")
            {
                smint = 0;
            }
            else
            {
                smint = Convert.ToInt32(selbtn[0].ToString());
            }
        }
        
        String sbtn1 = "select min(pos) from usertemp where mailid='" + sname + "' and pos >'"+ smint +"'";
        OdbcCommand smin1 = new OdbcCommand(sbtn1, con);
        OdbcDataReader selbtn1 = smin1.ExecuteReader();

        selbtn1.Read();
        if (selbtn1.HasRows)
        {
            if (selbtn1[0].ToString() == "")
            {
                smint1 = 0;
            }
            else
            {
                smint1 = Convert.ToInt32(selbtn1[0].ToString());
            }
        }
       
        String sbtn2 = "select min(pos) from usertemp where mailid='" + sname + "' and pos >'" + smint1 + "'";
        OdbcCommand smin2 = new OdbcCommand(sbtn2, con);
        OdbcDataReader selbtn2 = smin2.ExecuteReader();

        selbtn2.Read();
        if (selbtn2.HasRows)
        {
            if (selbtn2[0].ToString() == "")
            {
                smint2 = 0;
            }
            else
            {
                smint2 = Convert.ToInt32(selbtn2[0].ToString());
            }
        }
        
        String sbtn3 = "select min(pos) from usertemp where mailid='" + sname + "' and pos >'" + smint2 + "'";
        OdbcCommand smin3 = new OdbcCommand(sbtn3, con);
        OdbcDataReader selbtn3 = smin3.ExecuteReader();

        selbtn3.Read();
        if (selbtn3.HasRows)
        {
            if (selbtn3[0].ToString() == "")
            {
                smint3 = 0;
            }
            else
            {
                smint3 = Convert.ToInt32(selbtn3[0].ToString());
            }
        }
        

       

        String str1 = "select place from usertemp where mailid='"+sname+"' and  pos='"+smint+"'";
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

        String str2 = "select hotel from usertemp where  mailid='" + sname + "' and pos='"+smint+"'";
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

        String str3 = "select room from usertemp where  mailid='" + sname + "' and pos='" + smint + "'";
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




        String str4 = "select days from usertemp where  mailid='" + sname + "' and pos='" + smint + "'";
        OdbcCommand cmd4 = new OdbcCommand(str4, con);
        OdbcDataReader dr4 = cmd4.ExecuteReader();

        dr4.Read();
        if (dr4.HasRows)
        {
            s4 =  Convert.ToInt32(dr4[0].ToString());
        }
        else
        {
            s4 = 0;
        }
        
        String str5 = "select place from usertemp where  mailid='" + sname + "' and pos='" + smint1 + "'";
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

        String str6 = "select hotel from usertemp where  mailid='" + sname + "' and pos='" + smint1 + "'";
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


        String str7 = "select room from usertemp where  mailid='" + sname + "' and pos='" + smint + "'";
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


        String str8 = "select days from usertemp where  mailid='" + sname + "' and pos='" + smint1 + "'";
        OdbcCommand cmd8 = new OdbcCommand(str8, con);
        OdbcDataReader dr8 = cmd8.ExecuteReader();

        dr8.Read();
        if (dr8.HasRows)
        {
            s8 = Convert.ToInt32(dr8[0].ToString());
        }
        else
        {
            s8 = 0;
        }


        String str9 = "select place from usertemp where  mailid='" + sname + "' and pos='" + smint2 + "'";
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

        String str10 = "select hotel from usertemp where  mailid='" + sname + "' and pos='" + smint2 + "'";
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

        String str16 = "select room from usertemp where  mailid='" + sname + "' and pos='" + smint2 + "'";
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



        String str11 = "select days from usertemp where  mailid='" + sname + "' and pos='" + smint2 + "'";
        OdbcCommand cmd11 = new OdbcCommand(str11, con);
        OdbcDataReader dr11 = cmd11.ExecuteReader();

        dr11.Read();
        if (dr11.HasRows)
        {
            s11 = Convert.ToInt32(dr11[0].ToString());
        }
        else
        {
            s11 = 0;
        }

        String str12 = "select place from usertemp where  mailid='" + sname + "' and pos='" + smint3 + "'";
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

        String str13 = "select hotel from usertemp where  mailid='" + sname + "' and pos='" + smint3 + "'";
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


        String str17 = "select room from usertemp where  mailid='" + sname + "' and pos='" + smint2 + "'";
        OdbcCommand cmd17 = new OdbcCommand(str17, con);
        OdbcDataReader dr17 = cmd17.ExecuteReader();

        dr17.Read();
        if (dr17.HasRows)
        {
            s17 = dr17[0].ToString();
        }
        else
        {
            s17 = "";
        }


        String str14 = "select days from usertemp where  mailid='" + sname + "' and pos='" + smint3 + "'";
        OdbcCommand cmd14 = new OdbcCommand(str14, con);
        OdbcDataReader dr14 = cmd14.ExecuteReader();

        dr14.Read();
        if (dr14.HasRows)
        {
            s14 = Convert.ToInt32(dr14[0].ToString());
        }
        else
        {
            s14 = 0;
        }

        String str15 = "select bus from usertemp where  mailid='" + sname + "' ";
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


        

        con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int npos=1;
        String t1=s4.ToString();
        String t2=s8.ToString();
        collide = s1 + " - " + s2 + " - " + s3 + " - " + s4 + " , " + s5 + " - " + s6 + " - " + s7 + " - " + s8 + " - " + s9 + " - " + s10 + " - " + s16 + " - " + s11 + " - " + s12 + " - " + s13 + " - " + s17 + " - " + s14 + "-" + s15;

        string dt = DateTime.Now.ToString("yyyy-MM-dd");
        string tm = DateTime.Now.ToShortTimeString();

        con.Open();
        String maximum = "select max(pos) from notifyadmin";
        OdbcCommand cmd = new OdbcCommand(maximum, con);
        OdbcDataReader dr = cmd.ExecuteReader();
        dr.Read();
        if (dr.HasRows)
        {
            npos = Convert.ToInt32(dr[0].ToString());

        }
      
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
            npos = npos + 1;
            String str = "insert into notifyadmin values('" + dr1[0].ToString() + "','" + dr2[0].ToString() + "','" + dt + "','" + tm + "','"+ collide+"','" + npos + "')";
            OdbcCommand snt = new OdbcCommand(str, con);
            snt.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('Package succefully added to your cart. Our employee will contact you shortly for further details ')</script>");
        }

        con.Close();
            
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        con.Open();
        String str = "delete from usertemp where pos='" + smint + "'";
        OdbcCommand cmd = new OdbcCommand(str, con);
        cmd.ExecuteNonQuery();
        con.Close();
        this.Page_Load(null, null);
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        con.Open();
        String str = "delete from usertemp where pos='" + smint1 + "'";
        OdbcCommand cmd = new OdbcCommand(str, con);
        cmd.ExecuteNonQuery();
        con.Close();
        this.Page_Load(null, null);
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        con.Open();
        String str = "delete from usertemp where pos='" + smint2 + "'";
        OdbcCommand cmd = new OdbcCommand(str, con);
        cmd.ExecuteNonQuery();
        con.Close();
        this.Page_Load(null, null);
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        con.Open();
        String str = "delete from usertemp where pos='" + smint3 + "'";
        OdbcCommand cmd = new OdbcCommand(str, con);
        cmd.ExecuteNonQuery();
        con.Close();
        this.Page_Load(null, null);
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("facilities.aspx");
    }
}
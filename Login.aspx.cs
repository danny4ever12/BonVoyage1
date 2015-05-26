using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;
using System.Web.Configuration;

public partial class Login : System.Web.UI.Page
{
    OdbcConnection con = new OdbcConnection(WebConfigurationManager.ConnectionStrings["myConnectionString"].ToString());

    int Tpos;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();

        String chk = "select Position from user where status=1";
        OdbcCommand cmdchk = new OdbcCommand(chk, con);
        OdbcDataReader drchk = cmdchk.ExecuteReader();

        drchk.Read();
        if (drchk.HasRows)
        {
            if (drchk[0].ToString() == "USER")
            {
                Response.Redirect("RegUser.aspx");

            }
            else if (drchk[0].ToString() == "ADMIN")
            {
                Response.Redirect("Admin.aspx");
            }
        }
        else
        {

            String str = "select Position from user where Mailid='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
            OdbcCommand cmd = new OdbcCommand(str, con);
            OdbcDataReader dr = cmd.ExecuteReader();

            dr.Read();
            if (dr.HasRows)
            {
                if (dr[0].ToString() == "USER")
                {
                    //CHANGING VALUE OF STATUS
                    String str1 = "update user set status='1' where Mailid='" + TextBox1.Text + "';";
                    OdbcCommand cmd1 = new OdbcCommand(str1, con);
                    cmd1.ExecuteNonQuery();

                    Response.Redirect("RegUser.aspx");
                }
                else if (dr[0].ToString() == "ADMIN")
                {

                    String str1 = "update user set status='1' where Mailid='" + TextBox1.Text + "';";
                    OdbcCommand cmd1 = new OdbcCommand(str1, con);
                    cmd1.ExecuteNonQuery();

                    Response.Redirect("Admin.aspx");

                }
            }

        }
        con.Close();

    }
    protected void Button2_Click(object sender, EventArgs e)
    {

        con.Open();

        String name = "select max(pos) from user";
        OdbcCommand cmd1 = new OdbcCommand(name, con);
        OdbcDataReader dr1 = cmd1.ExecuteReader();
        dr1.Read();
        if (dr1.HasRows)
        {
            Tpos = Convert.ToInt32(dr1[0].ToString());


        }

        String str = "insert into user values('" + TextBox3.Text + "','" + TextBox4.Text + "','USER','" + TextBox7.Text + "','" + TextBox5.Text + "','0','" + Tpos + "')";
        OdbcCommand cmd = new OdbcCommand(str, con);
        cmd.ExecuteNonQuery();
        Response.Write("<script>alert('Registred Successfully....! login to continue')</script>");
        //  Response.Redirect("RegUser.aspx");//
        con.Close();

    }
    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {

    }
}
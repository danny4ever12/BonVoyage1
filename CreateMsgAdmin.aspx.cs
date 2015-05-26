using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;
using System.Web.Configuration;
using System.Net;
using System.Net.Mail;

public partial class CreateMsgAdmin : System.Web.UI.Page
{
    OdbcConnection con = new OdbcConnection(WebConfigurationManager.ConnectionStrings["myConnectionString"].ToString());

    String rchusr="",img="";
    
    int smax,smaxtemp,smin,i=0;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        //obtaining max pos
        String sm = "select max(pos) from messageuser";
        OdbcCommand smax1 = new OdbcCommand(sm, con);
        OdbcDataReader sel = smax1.ExecuteReader();

        sel.Read();
        if (sel.HasRows)
        {
            smax = Convert.ToInt32(sel[0].ToString());
            
        }
        else
        {
            smax = 1;
        }

         //obtaining max pos from user
        String sm1 = "select max(pos) from user";
        OdbcCommand smax11 = new OdbcCommand(sm1, con);
        OdbcDataReader sel1 = smax11.ExecuteReader();

        sel1.Read();
        if (sel1.HasRows)
        {
            smaxtemp = Convert.ToInt32(sel1[0].ToString());
            
        }
        else
        {
            smaxtemp = 1;
        }

        //obtaining min pos from user
        String smn = "select min(pos) from user";
        OdbcCommand smin1 = new OdbcCommand(smn, con);
        OdbcDataReader s = smin1.ExecuteReader();

        s.Read();
        if (s.HasRows)
        {
            smin = Convert.ToInt32(s[0].ToString());

        }
        else
        {
            smin = 1;
        }
        con.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        ++smax;
        string dt = DateTime.Now.ToString("yyyy-MM-dd");
        string tm = DateTime.Now.ToShortTimeString();
        img = TextBox3.Text;
        if (RadioButton1.Checked == true)
        {
            rchusr = "all";

            //message
            con.Open();
            String strmg = "insert into messageuser values('" + TextBox4.Text + "','" + rchusr + "','" + dt + "','" + tm + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + smax + "')";
            OdbcCommand cmdtp = new OdbcCommand(strmg, con);
            cmdtp.ExecuteNonQuery();
            Response.Write("<script>alert('Message sent successfully')</script>");

            con.Close();



            //EMAIL
            con.Open();
            String mailadr="";
            for(i=smin;smin<=smaxtemp;smin++)
            {
              try
                {
                   String str = "select Mailid from user where pos='"+smin+"'";
                   OdbcCommand cmd = new OdbcCommand(str, con);
                   OdbcDataReader dr = cmd.ExecuteReader();

                   dr.Read();
                   if (dr.HasRows)
                     {
                       mailadr = dr[0].ToString();

                     }

                
                  var fromAddress = new MailAddress("bonVoyageInc@gmail.com", "BonVoyage");
                  var toAddress = new MailAddress(mailadr);
                  const string fromPassword = "bonVoyage12!";
                  string subject = TextBox4.Text;
                  string body = TextBox2.Text;
                  Attachment attachment;
                  attachment = new System.Net.Mail.Attachment(TextBox3.Text);
               
                  var smtp = new SmtpClient
                      {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                     };
                  using (var message = new MailMessage(fromAddress, toAddress)
                     {
                       Subject = subject,
                       Body = body
                    
                     })
                   {
                       message.Attachments.Add(attachment);
                       smtp.Send(message);
                   
                   }
                }
               catch (Exception ex)
                {
                   Response.Write("Could not send the e-mail to " + mailadr+ex.Message);
                }
           
          }

        con.Close();
        }
        
        else if (RadioButton2.Checked == true)
        {
            rchusr = TextBox1.Text;
            con.Open();
            String strmg = "insert into messageuser values('" + TextBox4.Text + "','" + rchusr + "','" + dt + "','" + tm + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + smax + "')";
            OdbcCommand cmdtp = new OdbcCommand(strmg, con);
            cmdtp.ExecuteNonQuery();
            

            con.Close();

            //EMAIL 
        try
          {
               


                
                var fromAddress = new MailAddress("bonVoyageInc@gmail.com", "BonVoyage");
                var toAddress = new MailAddress(rchusr);
                const string fromPassword = "bonVoyage12!";
                string subject = TextBox4.Text;
                string body = TextBox2.Text;
                Attachment attachment;
                attachment = new System.Net.Mail.Attachment(TextBox3.Text);
                
               
                var smtp = new SmtpClient
                {
                   Host = "smtp.gmail.com",
                   Port = 587,
                   EnableSsl = true,
                   DeliveryMethod = SmtpDeliveryMethod.Network,
                   UseDefaultCredentials = false,
                     
                   Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
               };

                
                
               using (var message = new MailMessage(fromAddress, toAddress)
                 {
                    Subject = subject,
                    Body = body
                   
                    
                })
                {
                    message.Attachments.Add(attachment);


                    smtp.Send(message);


                    Response.Write("<script>alert('Message and email sent successfully')</script>");
                }
            }
            catch (Exception ex)
            {
              
             
              Response.Write("<script>alert('Message sent successfully, error occured while sending email')</script>"+ex.Message);

            
            }
           
        }

       

    }
}
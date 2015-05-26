<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>BonVoyage | Home</title>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form2" runat="server">
    <div class="wrapper col4">
  <div id="containerhme" class="clear"> 
    
    <div id="homepage" class="clear">
      <div class="fl_left">
        <h2 style="color: #800080; font-family: Arial, Helvetica, sans-serif;">Recent Memories</h2>
        <div id="hpage_slider">
          <div class="item"><img src="images/demo/featured-project/1.jpg" alt="" /></div>
          <div class="item"><img src="images/demo/featured-project/2.jpg" alt="" /></div>
          <div class="item"><img src="images/demo/featured-project/3.jpg" alt="" /></div>
          <div class="item"><img src="images/demo/featured-project/4.jpg" alt="" /></div>
          <div class="item"><img src="images/demo/featured-project/5.jpg" alt="" /></div>
        </div>
         <div style="width: 235px; z-index: 1; left: 816px; top: -2px; position: absolute; height: 38px">   
            <asp:Button ID="Button2" runat="server" BackColor="#202020" 
              BorderColor="#202020" Font-Bold="True" Font-Italic="True" Font-Size="Large" 
              ForeColor="White" 
              style="z-index: 1; left: 803px; top: -66px; width: 205px; height: 38px" 
              Text="Login/SignUp" onclick="Button2_Click" /> </div>
      
      </div>
      <div class="fl_right">
        <h2 style="color: #800080; z-index: 1; left: 561px; top: 117px; position: absolute; height: 27px; font-family: Arial, Helvetica, sans-serif;">Our client's tweets</h2>
        <ul class="testimonials">
          <li>
            <p class="name"><strong>sebin</strong> -developer</p>
            <blockquote>Never knew trips can be this enjoying and comfortable at the same time....thank you guys for the awsm rich experience. </blockquote>
          </li>
          <li class="last">
            <p class="name"><strong>Varsha</strong> -analyst</p>
            <blockquote>Had an awsm 3 day vecation all thanks to you guys.....Always remember customer happiness and satisfaction should be your primary motive...profit should come second!  </blockquote>
          </li>
        </ul>
        
             
          <asp:TextBox ID="TextBox1" runat="server" BackColor="#FFCC99" 
              BorderColor="#FF9966" BorderStyle="Solid" Font-Bold="True" Font-Italic="True" 
              Font-Size="Medium" Height="36px" ToolTip="search our site for tourist places" 
              Width="167px">search places</asp:TextBox>
          <asp:Button ID="Button1" runat="server" BackColor="#66CCFF" 
              BorderColor="#6699FF" Font-Bold="True" Font-Italic="True" Font-Size="Large" 
              onclick="Button1_Click" 
              style="z-index: 1; left: 731px; top: 29px; " 
              Text="search" Width="80px" Height="37px" />
        
            
      </div>
     
      <div style="position: absolute; height: 260px; z-index: 1; left: 46px; top: 466px; width: 880px;">   
       <p style="color: #800080; font-family: Arial, Helvetica, sans-serif; font-size: x-large; font-style: italic">Send us your feedback and suggestions</p>
       
         <asp:TextBox ID="TextBox2" runat="server"  BackColor="#FFCC99" 
              BorderColor="#FF9966" BorderStyle="Solid" Font-Bold="True" Font-Italic="True" 
              Font-Size="Medium" Height="157px" Width="636px"></asp:TextBox>
         <asp:Button ID="Button3" runat="server"  BackColor="#66CCFF" 
              BorderColor="#6699FF" Font-Bold="True" Font-Italic="True" 
             Font-Size="Large" Text="Send" Height="51px" 
             Width="140px" onclick="Button3_Click" />
     
     </div> 
    </div>
    
  </div>
 
</div>

    </form>

</asp:Content>

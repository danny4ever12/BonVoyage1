﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>BonVoyage | Admin</title>
    <style type="text/css">
        #containeradmin
        {
            background-image:url('background/h2.jpg');
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
    <div class="wrapper col4">
    <p style="color: #800000; font-family: Arial, Helvetica, sans-serif; font-size: x-large; font-style: italic; z-index: 1; left: 5px; top: 150px; height: 28px; width: 278px; position: absolute;">Welcome <%=sn%></p>
  <div id="containeradmin" class="clear"> 
    
    <div id="homepage" class="clear">
      <div class="fl_left">
          <h2 style="color: #800080">Recent Memories</h2>
        <div id="hpage_slider">
          <div class="item"><img src="images/demo/featured-project/1.jpg" alt="" /></div>
          <div class="item"><img src="images/demo/featured-project/2.jpg" alt="" /></div>
          <div class="item"><img src="images/demo/featured-project/3.jpg" alt="" /></div>
          <div class="item"><img src="images/demo/featured-project/4.jpg" alt="" /></div>
          <div class="item"><img src="images/demo/featured-project/5.jpg" alt="" /></div>
        </div>
        <div style="width: 235px; z-index: 1; left: 633px; top: -1px; position: absolute; height: 38px">   
            <asp:Button ID="Button3" runat="server" BackColor="#202020" 
              BorderColor="#202020" Font-Bold="True" Font-Italic="True" Font-Size="Large" 
              ForeColor="White" 
              style="z-index: 1; left: 803px; top: -66px; width: 205px; height: 38px" 
              Text="Create Message" onclick="Button3_Click" /> </div>

      <div style="z-index: 1; left: 848px; top: -1px; position: absolute; height: 42px; width: 265px">
          <asp:Button ID="Button2" runat="server" BackColor="#202020" 
              BorderColor="#202020" Font-Bold="True" Font-Italic="True" Font-Size="Large" 
              ForeColor="White" 
              style="z-index: 1; left: 803px; top: -66px; width: 205px; height: 38px" 
              Text="View Notifications" onclick="Button2_Click" /></div>
      
      <div style="z-index: 1; left: 420px; top: -1px; position: absolute; height: 42px; width: 265px">
          <asp:Button ID="Button4" runat="server" BackColor="#202020" 
              BorderColor="#202020" Font-Bold="True" Font-Italic="True" Font-Size="Large" 
              ForeColor="White" 
              style="z-index: 1; left: 353px; top: -66px; width: 205px; height: 38px" 
              Text="LogOut" onclick="Button4_Click" /></div>
      </div>
      
      <div class="fl_right">
        <h2 style="color: #800080; z-index: 1; left: 561px; top: 117px; position: absolute; height: 27px;">Our client's tweets</h2>
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
        
             
          <asp:Button ID="Button1" runat="server" BackColor="#66CCFF" 
              BorderColor="#CC99FF" Font-Bold="True" Font-Italic="True" Font-Size="Large" 
              onclick="Button1_Click" 
              style="z-index: 1; left: 732px; top: 67px; position: absolute; height: 33px" 
              Text="search" Width="80px" ForeColor="#CC0000" />
        
             
          
        
             
          <asp:TextBox ID="TextBox1" runat="server" BackColor="#CCFFFF" 
              BorderColor="#FFCCFF" BorderStyle="Solid" Font-Bold="True" Font-Italic="True" 
              Font-Size="Medium" Height="36px" ToolTip="search our site for tourist places" 
              Width="167px" 
              style="z-index: 1; left: 560px; top: 66px; position: absolute">search places</asp:TextBox>
        
             
      </div>
     </div>
    </div>
  </div>
 
    </form>
</asp:Content>


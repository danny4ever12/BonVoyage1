<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Customlist.aspx.cs" Inherits="Customlist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<link rel="stylesheet" href="layout/styles/sidebarcss.css" />
<title>BonVoyage|Customize</title>
    <style type="text/css">
        .style3
        {
            width: 111px;
        }
        .style4
        {
            width: 128px;
        }
        .style5
        {
            width: 113px;
        }
        .style6
        {
            width: 85px;
        }
        .style7
        {
            width: 143px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<form id="form1" runat="server">
<div class="wrapper col4">
<div id="containercsm" class="clear">   
 <div id="homepage" class="clear">
   <div style="z-index: 1; left: 848px; top: -5px; position: absolute; height: 42px; width: 265px">
          <asp:Button ID="Button1" runat="server" BackColor="White" 
              BorderColor="White" Font-Bold="True" Font-Italic="True" Font-Size="Large" 
              ForeColor="White" 
              style="z-index: 1; left: 803px; top: -66px; width: 405px; height: 38px" 
              Text="" onclick="Button1_Click" /></div>

              <div style="z-index: 1; left: 0px; top: -5px; position: absolute; height: 35px; width: 325px">
          <asp:Button ID="Button6" runat="server" BackColor="black" 
              BorderColor="black" Font-Bold="True" Font-Italic="True" Font-Size="Large" 
              ForeColor="white" 
              style="z-index: 1; left: 0px; top: -66px; margin-left: 0px;" 
              Text="click to select bus facility" onclick="Button6_Click" Height="35px" width="325px" /></div>
<div id="cssmenu" 
         
         
         
         style="height: 415px; width: 200px; background-color: #bd0e36; top: 0px; left: 0px;">
   
<ul>
   <li class='active'><a href='TouristSpots.aspx'><span>Tourist Places</span></a></li>
   <li class='has-sub'><a href='#'><span>Munnar</span></a>
      <ul>
         <li><a href='st_mnr1.aspx'><span>Eravikulam national park</span></a></li>
         <li><a href='st_mnr2.aspx'><span>kurinjimala santuary</span></a></li>
         <li class='last'><a href='st_mnr3.aspx'><span>Mattupetty</span></a></li>
      </ul>
   </li>
   <li class='has-sub'><a href='#'><span>FortKochi</span></a>
      <ul>
         <li><a href='st_fort1.aspx'><span>Bastion Bungalow </span></a></li>
         <li><a href='st_fort2.aspx'><span>Santa Cruz Basilica</span></a></li>
         <li class='last'><a href='st_fort3.aspx'><span>Fort Kochi beach</span></a></li>
      </ul>
   </li>
   <li class='has-sub'><a href='#'><span>Wayanad</span></a>
      <ul>
         <li><a href='st_wy1.aspx'><span>Chembra Peak</span></a></li>
         <li><a href='st_wy2.aspx'><span>Neelimala</span></a></li>
         <li class='last'><a href='st_wy3.aspx'><span>Banasura Sagar Dam</span></a></li>
      </ul>
   </li>
   <li class='has-sub'><a href='#'><span>Kollam</span></a>
      <ul>
         <li><a href='st_km1.aspx'><span>Alumkadavu</span></a></li>
         <li><a href='st_km2.aspx'><span>Thenmala</span></a></li>
         <li class='last'><a href='st_km3.aspx'><span>Paravur Lake</span></a></li>
      </ul>
   </li>
   
</ul>



   </div>
    <div style="position: relative; top: -415px; left: 203px; width: 896px; height: 415px; ">
    <p style="color: #800080; font-family: Arial, Helvetica, sans-serif; font-size: large; font-style: italic; width: 725px;">add places to your custom pack</p>
       <table style="width: 75%;">
            <tr>
               
                <td class="style7"><p style="color: #800000; font-family: Arial, Helvetica, sans-serif; font-size: large; font-style: italic">place</p>
                    &nbsp;
                </td>
                <td class="style4"><p style="color: #800000; font-family: Arial, Helvetica, sans-serif; font-size: large; font-style: italic">hotel</p>
                    &nbsp;
                </td>
                  <td class="style5"><p style="color: #800000; font-family: Arial, Helvetica, sans-serif; font-size: large; font-style: italic">room</p>
                    &nbsp;
                </td>
                 <td class="style6"><p style="color: #800000; font-family: Arial, Helvetica, sans-serif; font-size: large; font-style: italic">days</p>
                    &nbsp;
                </td>
                 <td class="style3"><p style="color: #800000; font-family: Arial, Helvetica, sans-serif; font-size: large; font-style: italic">bus</p>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style7"><%=sn1 %>
                    &nbsp;
                </td>
                <td class="style4"><%=sh1 %>
                    &nbsp;
                </td>
                 <td class="style5"><%=sr1 %>
                    &nbsp;
                </td>
                
                <td class="style6"><%=sd1 %>
                &nbsp;</td>
                
                <td class="style3"><%=sb1 %>
                &nbsp;</td>
                <td>
                   <asp:Button ID="Button2" runat="server"  BackColor="#66CCFF" 
              BorderColor="#6699FF" Font-Bold="True" Font-Italic="True" Font-Size="Large" 
              onclick="Button2_Click" 
              style=" height: 25px; width: 90px;" 
              Text="delete" />
                </td>
            </tr>
            <tr>
                <td class="style7"><%=sn2 %>
                    &nbsp;
                </td>
                <td class="style4"><%=sh2 %>
                    &nbsp;
                </td>
                <td class="style5"><%=sr2 %>
                    &nbsp;
                </td>
               
                <td class="style6"><%=sd2 %>
                
                </td>
                 <td class="style3"><%=sb1 %>
                &nbsp;
                </td>
               
                <td>
                   <asp:Button ID="Button3" runat="server"  BackColor="#66CCFF" 
              BorderColor="#6699FF" Font-Bold="True" Font-Italic="True" Font-Size="Large" 
              onclick="Button3_Click" 
              style=" height: 25px; width: 90px;" 
              Text="delete" />
                </td>
            </tr>
            <tr>
                <td class="style7"><%=sn3 %>
                    &nbsp;
                </td>
                <td class="style4"><%=sh3 %>
                    &nbsp;
                </td>
               <td class="style5"><%=sr3 %>
                    &nbsp;
                </td>
               
                <td class="style6"><%=sd3 %>
                
                </td>
                 <td class="style3"><%=sb1 %>
                &nbsp;</td>
             
                <td>
                   <asp:Button ID="Button4" runat="server"  BackColor="#66CCFF" 
              BorderColor="#6699FF" Font-Bold="True" Font-Italic="True" Font-Size="Large" 
              onclick="Button4_Click" 
              style=" height: 25px; width: 90px;" 
              Text="delete" />
                </td>
            </tr>
            <tr>
                <td class="style7"><%=sn4 %>
                    &nbsp;
                </td>
                <td class="style4"><%=sh4 %>
                    &nbsp;
                </td>
                <td class="style5"><%=sr4 %>
                    &nbsp;
                </td>
               
                <td class="style6"><%=sd4 %>
                
                </td>
                 <td class="style3"><%=sb1 %>
                &nbsp;</td>
               
                
               <td>
                   <asp:Button ID="Button5" runat="server"  BackColor="#66CCFF" 
              BorderColor="#6699FF" Font-Bold="True" Font-Italic="True" Font-Size="Large" 
              onclick="Button5_Click" 
              style=" height: 25px; width: 90px;" 
              Text="delete" />
                </td>
            </tr>
            
        </table> 
   </div>
   </div>
   </div>
   </div>
   </form>
</asp:Content>


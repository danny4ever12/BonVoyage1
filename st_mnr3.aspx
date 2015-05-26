<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="st_mnr3.aspx.cs" Inherits="st_mnr3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 <title>BonVoyage | TouristSpots</title>
 <link rel="stylesheet" href="layout/styles/sidebarcss.css" />
    <style type="text/css">
        .style1
        {
            width: 186px;
        }
        .style2
        {
            width: 376px;
        }
        .style3
        {
            width: 186px;
            height: 53px;
        }
        .style4
        {
            width: 376px;
            height: 53px;
        }
        .style5
        {
            height: 53px;
        }
        .style6
        {
            width: 186px;
            height: 65px;
        }
        .style7
        {
            width: 376px;
            height: 65px;
        }
        .style8
        {
            height: 65px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<form id="form1" runat="server">
    <div class="wrapper col4">
  <div id="containerplc" class="clear"> 
    
 <div id="homepage" class="clear">
  <div style="z-index: 1; left: 848px; top: -15px; position: absolute; height: 42px; width: 265px">
          <asp:Button ID="Button1" runat="server" BackColor="#202020" 
              BorderColor="#202020" Font-Bold="True" Font-Italic="True" Font-Size="Large" 
              ForeColor="White" 
              style="z-index: 1; left: 803px; top: -95px; width: 405px; height: 38px" 
              Text="Add this place to your customised package" onclick="Button1_Click" /></div>
 <div id="cssmenu" 
         
         style="height: 1270px; width: 200px; background-color: #bd0e36; top: -34px; left: 0px;">
   
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
    
    <div style="position: relative; top: -1299px; left: 204px; width: 896px; height: 1270px; ">
    <p>
        <asp:Button ID="Button5" runat="server" BackColor="#202020" 
              BorderColor="#202020" Font-Bold="True" Font-Italic="True" Font-Size="Large" 
              ForeColor="White"  Text="create customised pack" 
            onclick="Button5_Click"  Width="260px" 
            style="z-index: 1; left: -5px; top: -55px; position: absolute" />
        </p>
    <p style="color: #800080; font-family: Arial, Helvetica, sans-serif; font-size: 50px; font-weight: bold; font-style: italic" 
            align="center"><%=sh1 %> </p>
    <a href="<%=si1 %>" rel="prettyPhoto[gallery1]"  title="Image 1">
        <img src="<%=si1 %>" alt="Title Text"  
            style="width: 749px; height: 324px; margin-left: 100px;" /></a>
   <p></p>
     <a href="<%=si2 %>" rel="prettyPhoto[gallery1]"  title="Image 1">
        <img src="<%=si2 %>" alt="Title Text"  
            style="width: 246px; height: 128px; margin-left: 100px;" /></a>
     <a href="<%=si3 %>" rel="prettyPhoto[gallery1]"  title="Image 1">
        <img src="<%=si3 %>" alt="Title Text"  
            style="width: 246px; height: 128px; " /></a>
      <a href="<%=si4 %>" rel="prettyPhoto[gallery1]"  title="Image 1">
        <img src="<%=si4 %>" alt="Title Text"  
            style="width: 246px; height: 128px; " /></a>
 
    <p style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic; height: 117px;"><%=sd1 %></p>
    <p style="color: #800080; font-family: Arial, Helvetica, sans-serif; font-size: xx-large; font-weight: bold; font-style: italic">Hotels available</p>   
        <asp:LinkButton ID="LinkButton1" runat="server" 
            style=" font-family: Arial, Helvetica, sans-serif; font-size: x-large; font-weight: normal; font-style: italic" 
            ToolTip="click to view details of this hotel"
            onclick="LinkButton1_Click"  ForeColor="#006600"><%=sr1 %></asp:LinkButton>
        <p></p>
        <asp:LinkButton ID="LinkButton2" runat="server" 
            style=" font-family: Arial, Helvetica, sans-serif; font-size: x-large; font-weight: normal; font-style: italic" 
            ToolTip="click to view details of this hotel" BorderColor="#666699"
            onclick="LinkButton2_Click" ForeColor="#006600"><%=sr2 %></asp:LinkButton>
        <p></p>
        <asp:LinkButton ID="LinkButton3" runat="server" 
            style=" font-family: Arial, Helvetica, sans-serif; font-size: x-large; font-weight: normal; font-style: italic"
            ToolTip="click to view details of this hotel" BorderColor="#666699" 
            onclick="LinkButton3_Click"  ForeColor="#006600" ><%=sr3 %></asp:LinkButton>
        <p></p>
        <table style="width: 75%;">
            <tr>
                <td class="style1"> 
                    <p style="color: #800000; font-size: medium; font-family: Arial, Helvetica, sans-serif; font-style: italic">Rooms Available</p>
                    &nbsp;
                </td>
                <td class="style2"><p style="color: #800000; font-size: medium; font-family: Arial, Helvetica, sans-serif; font-style: italic">Facilities</p>
                    &nbsp;
                </td>
                <td class="style1"><p style="color: #800000; font-size: medium; font-family: Arial, Helvetica, sans-serif; font-style: italic">Price rate</p>
                    &nbsp;
                </td>
                 <td><p style="color: #800000; font-size: medium; font-family: Arial, Helvetica, sans-serif; font-style: italic">no:of days</p>
                    &nbsp;
                </td>
                 <td><p style="color: #800000; font-size: medium; font-family: Arial, Helvetica, sans-serif; font-style: italic">click to add to customised package</p>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style3"><p><%=sm1 %></p>
                    &nbsp;
                </td>
                <td class="style4"><p><%=sm2 %></p>
                    &nbsp;
                </td>
                <td class="style3"><p><%=sm3 %></p>
                    &nbsp;
                </td>
                 <td class="style5">
                     <asp:TextBox ID="TextBox1" runat="server" Width="76px"></asp:TextBox>
                    &nbsp;
                </td>
                 <td class="style5">
                    <asp:Button ID="Button2" runat="server" Text="add" 
                        BackColor="#660066" ForeColor="White" onclick="Button2_Click" 
                        Width="70px" Font-Bold="True" Font-Italic="True" />
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style1"><p><%=sm4 %></p>
                    &nbsp;
                </td>
                <td class="style2"><p><%=sm5 %></p>
                    &nbsp;
                </td>
                <td class="style1"><p><%=sm6 %></p>
                    &nbsp;
                </td>
                 <td class="style5">
                     <asp:TextBox ID="TextBox2" runat="server" Width="76px"></asp:TextBox>
                    &nbsp;
                </td>
                 <td class="style5">
                    <asp:Button ID="Button3" runat="server" Text="add" 
                        BackColor="#660066" ForeColor="White" onclick="Button3_Click" 
                        Width="70px" Font-Bold="True" Font-Italic="True" />
                    &nbsp;
                </td>
            </tr>
             <tr>
                <td class="style6"><p><%=sm7 %></p>
                    &nbsp;
                </td>
                <td class="style7"><p><%=sm8 %></p>
                    &nbsp;
                </td>
                <td class="style6"><p><%=sm9 %></p>
                    &nbsp;
                </td>
                 <td class="style5">
                     <asp:TextBox ID="TextBox3" runat="server" Width="76px"></asp:TextBox>
                    &nbsp;
                </td>
                 <td class="style5">
                    <asp:Button ID="Button4" runat="server" Text="add" 
                        BackColor="#660066" ForeColor="White" onclick="Button4_Click" 
                        Width="70px" Font-Bold="True" Font-Italic="True" />
                    &nbsp;
                </td>
               
            </tr>
        </table>

    
    </div>
   </div>
</div>
</div>
</form>
</asp:Content>


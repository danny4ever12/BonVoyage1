<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TouristSpots.aspx.cs" Inherits="TouristSpots" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>BonVoyage | TouristSpots</title>
 <link rel="stylesheet" href="layout/styles/sidebarcss.css" />
       
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<form id="form1" runat="server">
<div class="wrapper col4">
<div id="containerspt" class="clear">
  
    
 <div id="homepage" class="clear">
  <div style="z-index: 1; left: 848px; top: -1px; position: absolute; height: 42px; width: 265px">
          <asp:Button ID="Button1" runat="server" BackColor="#202020" 
              BorderColor="#202020" Font-Bold="True" Font-Italic="True" Font-Size="Large" 
              ForeColor="White" 
              style="z-index: 1; left: 603px; top: -66px; width: 305px; height: 38px" 
              Text="create customised pack" onclick="Button1_Click" /></div>
 <div id="cssmenu" 
         
         
         style="height: 2668px; width: 200px; background-color: #bd0e36; top: 0px; left: 0px;">
   
<ul>
   <li class='active'><a href='#'><span>Tourist Places</span></a></li>
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
    <div style="position: relative; top: -2668px; left: 203px; width: 896px; height: 600px; ">
    <p style="color: #800080; font-family: Arial, Helvetica, sans-serif; font-size: 30px; font-weight: bold; font-style: italic" 
            >
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <%= sh1%></p>
    <a href="<%= sim1%>" rel="prettyPhoto[gallery1]"  title="Image 1">
        <img src="<%= sim1%>" alt="Title Text"  
            style="width: 749px; height: 324px; margin-left: 100px;" /></a>
     <a href="<%= sim2%>" rel="prettyPhoto[gallery1]"  title="Image 1">
        <img src="<%= sim2%>" alt="Title Text"  
            style="width: 246px; height: 128px; margin-left: 100px;" /></a>
     <a href="<%= sim3%>" rel="prettyPhoto[gallery1]"  title="Image 1">
        <img src="<%= sim3%>" alt="Title Text"  
            style="width: 246px; height: 128px; " /></a>
      <a href="<%= sim4%>" rel="prettyPhoto[gallery1]"  title="Image 1">
        <img src="<%= sim4%>" alt="Title Text"  
            style="width: 246px; height: 128px; " /></a>
 
    <p style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic; height: 66px; left: 10px; margin-left: 74px;"><%= sd1%></p>

    
    
    </div>
    <div style="position: relative; top: -2668px; left: 203px; width: 896px; height: 600px; ">
    <p style="color: #800080; font-family: Arial, Helvetica, sans-serif; font-size: 30px; font-weight: bold; font-style: italic" 
            >
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <%= sh2%></p>
    <a href="<%= sif1%>" rel="prettyPhoto[gallery1]"  title="Image 1">
        <img src="<%= sif1%>" alt="Title Text"  
            style="width: 749px; height: 324px; margin-left: 100px;" /></a>
     <a href="<%= sif2%>" rel="prettyPhoto[gallery1]"  title="Image 1">
        <img src="<%= sif2%>" alt="Title Text"  
            style="width: 246px; height: 128px; margin-left: 100px;" /></a>
     <a href="<%= sif3%>" rel="prettyPhoto[gallery1]"  title="Image 1">
        <img src="<%= sif3%>" alt="Title Text"  
            style="width: 246px; height: 128px; " /></a>
      <a href="<%= sif4%>" rel="prettyPhoto[gallery1]"  title="Image 1">
        <img src="<%= sif4%>" alt="Title Text"  
            style="width: 246px; height: 128px; " /></a>
 
    <p style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic; height: 66px; left: 10px; margin-left: 74px;"><%= sd2%></p>

    
    
    </div>
    <div style="position: relative; top: -2668px; left: 203px; width: 896px; height: 600px; ">
    <p style="color: #800080; font-family: Arial, Helvetica, sans-serif; font-size: 30px; font-weight: bold; font-style: italic" 
            >
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <%= sh3%></p>
    <a href="<%= siw1%>" rel="prettyPhoto[gallery1]"  title="Image 1">
        <img src="<%= siw1%>" alt="Title Text"  
            style="width: 749px; height: 324px; margin-left: 100px;" /></a>
     <a href="<%= siw2%>" rel="prettyPhoto[gallery1]"  title="Image 1">
        <img src="<%= siw2%>" alt="Title Text"  
            style="width: 246px; height: 128px; margin-left: 100px;" /></a>
     <a href="<%= siw3%>" rel="prettyPhoto[gallery1]"  title="Image 1">
        <img src="<%= siw3%>" alt="Title Text"  
            style="width: 246px; height: 128px; " /></a>
      <a href="<%= siw4%>" rel="prettyPhoto[gallery1]"  title="Image 1">
        <img src="<%= siw4%>" alt="Title Text"  
            style="width: 246px; height: 128px; " /></a>
 
    <p style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic; height: 66px; left: 10px; margin-left: 74px;"><%= sd3%></p>

    
    
    </div>
    <div style="position: relative; top: -2668px; left: 203px; width: 896px; height: 607px; ">
    <p style="color: #800080; font-family: Arial, Helvetica, sans-serif; font-size: 30px; font-weight: bold; font-style: italic" 
            >
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <%= sh4%></p>
    <a href="<%= sik1%>" rel="prettyPhoto[gallery1]"  title="Image 1">
        <img src="<%= sik1%>" alt="Title Text"  
            style="width: 749px; height: 324px; margin-left: 100px;" /></a>
     <a href="<%= sik2%>" rel="prettyPhoto[gallery1]"  title="Image 1">
        <img src="<%= sik2%>" alt="Title Text"  
            style="width: 246px; height: 128px; margin-left: 100px;" /></a>
     <a href="<%= sik3%>" rel="prettyPhoto[gallery1]"  title="Image 1">
        <img src="<%= sik3%>" alt="Title Text"  
            style="width: 246px; height: 128px; " /></a>
      <a href="<%= sik4%>" rel="prettyPhoto[gallery1]"  title="Image 1">
        <img src="<%= sik4%>" alt="Title Text"  
            style="width: 246px; height: 128px; " /></a>
 
    <p style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic; height: 66px; left: 10px; margin-left: 74px;"><%= sd4%></p>

    
    
    </div>
    </div>
    </div>
</div>
</form>
</asp:Content>


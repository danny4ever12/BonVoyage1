<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Facilities.aspx.cs" Inherits="Facilities" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<title>BonVoyage | Facilities</title>
    <style type="text/css">
        .style2
        {
            width: 103px;
        }
        .style3
        {
            height: 20px;
        }
        .style4
        {
            width: 103px;
            height: 20px;
        }
        .style5
        {
            width: 78px;
            height: 20px;
        }
        .style6
        {
            width: 78px;
        }
        .style7
        {
            height: 20px;
            width: 170px;
        }
        .style8
        {
            width: 170px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<form id="form1" runat="server">
<div class="wrapper col4">
  <div id="containerfac" class="clear"> 
   <div style="z-index: 1; left: 848px; top: -1px; position: absolute; height: 42px; width: 265px">
          <asp:Button ID="Button5" runat="server" BackColor="#202020" 
              BorderColor="#202020" Font-Bold="True" Font-Italic="True" Font-Size="Large" 
              ForeColor="White" 
              style="z-index: 1; left: 603px; top: -66px; width: 305px; height: 38px" 
              Text="create customised pack" onclick="Button5_Click" /></div>
   <div style="width: 605px; height: 1160px; background-image: url('background/c1.jpg');">
    <p style="color: #800080; font-size: x-large; font-weight: bold; font-style: italic; font-family: Arial, Helvetica, sans-serif;">Bus facilities available</p>
    
    <p>Our agency provides all kinds of busses with moderate and high end facilities.Customers can choose the automobiles according to their affordability.We also provide high end facilities at special prices to all school going and college students.The prices may vary depending on the number of people</p>
    <p>The basic facilities may include</p>
    <ul>
      <li>AC</li>
      <li>TV</li>
      <li>Sound system</li>
      <li>party lights,smoke...etc</li>
      <li>Projectors</li>
      <li>wifi,mobile charging ports etc.</li>
    </ul>

     <p>&nbsp;</p>
      <p style="color: #800080; font-family: Arial, Helvetica, sans-serif; font-size: x-large; font-weight: bold; font-style: italic;">Buses Currently available </p>
      <table style="width: 100%;">
          <tr>
              <td class="style3">
                  <p style="color: #800000; font-family: Arial, Helvetica, sans-serif; font-style: italic; font-size: medium; width: 81px;">Bus Name</p>
                  &nbsp;
              </td>
              <td class="style4">
                  <p style="color: #800000; font-style: italic; font-size: medium; font-family: Arial, Helvetica, sans-serif; width: 111px;">Bus Type</p>
                  &nbsp;
              </td>
              <td class="style5">
                  <p style="color: #800000; font-style: italic; font-size: medium; font-family: Arial, Helvetica, sans-serif; width: 102px;">Capacity</p>
                  &nbsp;
              </td>
              <td class="style7"><p style="color: #800000; font-style: italic; font-size: medium; font-family: Arial, Helvetica, sans-serif">Facilities</p>
                  &nbsp;
              </td>
          </tr>
          <tr>
              <td>Rider
                  &nbsp;
              </td>
              <td class="style2">Traveller
                  &nbsp;
              </td>
              <td class="style6">8
                  &nbsp;
              </td>
               <td class="style8">Stereo system, digital LCD&#8217;s ,AC & non AC
                  &nbsp;
              </td>
              <td>
                  <asp:Button ID="Button1" runat="server" Text="add to package" 
                        BackColor="#660066" ForeColor="White" onclick="Button1_Click" 
                        Width="102px" Font-Bold="True" Font-Italic="True" />
              </td>
          </tr>
           <tr>
              <td>Comfy
                  &nbsp;
              </td>
              <td class="style2">MiniBus
                  &nbsp;
              </td>
              <td class="style6">20
                  &nbsp;
              </td>
               <td class="style8">JBL Sound system,LCD TV&#8217;s, AC
                  &nbsp;
              </td>
              <td>
                  <asp:Button ID="Button2" runat="server" Text="add to package" 
                        BackColor="#660066" ForeColor="White" onclick="Button2_Click" 
                        Width="102px" Font-Bold="True" Font-Italic="True" />
              </td>
          </tr>
          <tr >
              
            <td> Companion
                  &nbsp;
              </td>
              <td class="style2">Air Bus
                  &nbsp;
              </td>
              <td class="style6">50
                  &nbsp;
              </td>
              <td class="style8">wifi enabled, JBL Sound system ,LCD TV&#8217;s, AC
                  &nbsp;
              </td>
              <td>
                  <asp:Button ID="Button3" runat="server" Text="add to package" 
                        BackColor="#660066" ForeColor="White" onclick="Button3_Click" 
                        Width="102px" Font-Bold="True" Font-Italic="True" />
              </td>
          </tr>
          <tr>
              
            <td> Slingshot
                  &nbsp;
              </td>
              <td class="style2">Car
                  &nbsp;
              </td>
              <td class="style6">4
                  &nbsp;
              </td>
              <td class="style8">AC, stock music system
                  &nbsp;
              </td>
              <td>
                  <asp:Button ID="Button4" runat="server" Text="add to package" 
                        BackColor="#660066" ForeColor="White" onclick="Button4_Click" 
                        Width="102px" Font-Bold="True" Font-Italic="True" />
              </td>
          </tr>
      </table>
     
     
      <p>&nbsp;</p>
      <p style="color: #800080; font-family: Arial, Helvetica, sans-serif; font-size: x-large; font-weight: bold; font-style: italic;">Bus Images</p>
       
      
        <a href="images/vehicles/v2.jpg" rel="prettyPhoto[gallery1]" title="Image 3"><img src="images/vehicles/v2.jpg" alt="Title Text" style="height: 133px; width: 190px"/></a>
        <a href="images/vehicles/v3.jpg" rel="prettyPhoto[gallery1]" title="Image 4"><img src="images/vehicles/v3.jpg" alt="Title Text" style="height: 133px; width: 190px"/></a>&nbsp;
        
        <a href="images/vehicles/v5.jpg" rel="prettyPhoto[gallery1]" title="Image 6"><img src="images/vehicles/v5.jpg" alt="Title Text" style="height: 133px; width: 190px"/></a>
        <p></p>
        <a href="images/vehicles/v6.gif" rel="prettyPhoto[gallery1]" title="Image 10"><img src="images/vehicles/v6.gif" alt="Title Text" style="height: 133px; width: 190px"/></a>
        
        <a href="images/vehicles/v7.jpg" rel="prettyPhoto[gallery1]" title="Image 12"><img src="images/vehicles/v7.jpg" alt="Title Text" style="height: 133px; width: 190px"/></a>
        <a href="images/vehicles/v8.jpg" rel="prettyPhoto[gallery1]" title="Image 13"><img src="images/vehicles/v8.jpg" alt="Title Text" style="height: 133px; width: 190px"/></a>
        <p></p>
        <a href="images/vehicles/v9.jpg" rel="prettyPhoto[gallery1]" title="Image 13"><img src="images/vehicles/v9.jpg" alt="Title Text" style="height: 133px; width: 190px"/></a>
        <a href="images/vehicles/v4.jpg" rel="prettyPhoto[gallery1]" title="Image 13"><img src="images/vehicles/v4.jpg" alt="Title Text" style="height: 133px; width: 190px"/></a>
        <a href="images/vehicles/v11.jpg" rel="prettyPhoto[gallery1]" title="Image 13"><img src="images/vehicles/v11.jpg" alt="Title Text" style="height: 133px; width: 190px"/></a>
       
    </div>
    <div style="position: relative; top: -1176px; left: 605px; height: 185px; width: 350px; margin-bottom: 2px; background-color: #FF0000; color: #C488FF; background-image: url('background/c4.jpg');">
    <p style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic; color: #FFFFFF; font-weight: bold;">Take a holy land tour to bethlehem 
        at our special package price this season!To view this package
        <a href="Package.aspx" 
            style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic; color: #800000">click here</a></p>
     <a href="Packimages/jeru.gif.jpg" rel="prettyPhoto[gallery1]" title="Image 13">
        <img src="Packimages/jeru.gif.jpg" alt="Title Text" 
            style="height: 111px; width: 350px"/></a>
    </div>
   <div style="position: relative; top: -1195px; left: 605px; width: 350px; height: 298px; background-image: url('background/c3.jpg');">
    <p style="color: #FF0000; font-family: 'Courier New', Courier, monospace; font-size: medium; text-decoration: blink;">
        &nbsp;</p>
       <p style="color: #FF0000; font-family: 'Courier New', Courier, monospace; font-size: medium; text-decoration: blink; font-weight: bold;">Coming soon.....!</p>
    <p style="color: #800080; font-family: Arial, Helvetica, sans-serif; font-weight: bold; font-style: italic; font-size: medium">Kumarakam Boating festival</p>
    <p style="color: #800080; font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: italic">We plan to provide rich boating facilites,refreshments and other exclusive goodies to the first 100 bookings for this package!</p>
    <p style="color: #800080; font-style: italic; font-size: small; font-family: Arial, Helvetica, sans-serif; text-decoration: blink">Stay in touch and make sure you dont miss this offer!</p>
    <a href="images/hb.png" rel="prettyPhoto[gallery1]" title="Image 13">
        <img src="images/hb.png" alt="Title Text" 
            style="height: 143px; width: 350px"/></a>
   </div>
     <div style="position: relative; top: -1180px; left: 605px; width: 350px; height: 214px; background-color: #9900CC;">
    <p style="color: #800080; font-family: Arial, Helvetica, sans-serif; font-weight: bold; font-style: italic; font-size: medium">
        &nbsp;</p>
         <p style="color: #FFFFFF; font-family: Arial, Helvetica, sans-serif; font-weight: bold; font-style: italic; font-size: medium">Star rated hotels</p>
    <p style="color: #C0C0C0; font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: italic">We provide star rated(3 to 5) hotels at affordable rates to our customers along with free refreshments and goodies with every package!</p>
    
    <a href="Facimages/hotel1.gif.jpg" rel="prettyPhoto[gallery1]" title="Image 13">
        <img src="Facimages/hotel1.gif.jpg" alt="Title Text" 
            style="height: 143px; width: 350px"/></a>
   </div>
     <div style="position: relative; top: -1145px; left: 605px; width: 350px; height: 384px; background-color: #93FDFD;">
    <p style="color: #800080; font-family: Arial, Helvetica, sans-serif; font-weight: bold; font-style: italic; font-size: medium">
        &nbsp;</p>
         <p style="color: #800080; font-family: Arial, Helvetica, sans-serif; font-weight: bold; font-style: italic; font-size: medium">Well trained tour guides ready to take you all the way...!</p>
    <p style="color: #800080; font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: italic">We have well trained and experienced tour guides from all across india ready to take you all the way.We assign different classes of tour guides for different trips. Youngsters are usually preferred for school and colag tours and well informed adults are usually assigned for old aged people.Tour guides can also be assigned upon request from the customer</p>
    
    <a href="Facimages/tourguide.gif.jpg" rel="prettyPhoto[gallery1]" title="Image 13">
        <img src="Facimages/tourguide.gif.jpg" alt="Title Text" 
            style="height: 152px; width: 350px"/></a>
   </div>
    <div style="position: relative; top: -1174px; left: 0px; width: 956px; height: 319px; background-image: url('background/c4.jpg');">
    <p style="color: #800080; font-family: Arial, Helvetica, sans-serif; font-weight: bold; font-style: italic; font-size: medium">
        &nbsp;</p>
         <p style="color: #C0C0C0; font-family: Arial, Helvetica, sans-serif; font-weight: bold; font-style: italic; font-size: medium">Kick start every season with our exiting season offers and packages</p>
    <p style="color: #C0C0C0; font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: italic">Just like the weather every place also has its own seasons when that place becomes a festive ground. These places has it's best to offer during its festive season!Our team realize this fact crystal clear.So we tend to provide attractive season packages suitable for all classes of people so that we can always make your journey a memorable one</p>
    
    <a href="Facimages/ts1.gif.jpg" rel="prettyPhoto[gallery1]" title="Image 13">
        <img src="Facimages/ts1.gif.jpg" alt="Title Text" 
            style="height: 152px; width: 234px"/></a>
    <a href="Facimages/ts2.gif.jpg" rel="prettyPhoto[gallery1]" title="Image 13">
        <img src="Facimages/ts2.gif.jpg" alt="Title Text" 
            style="height: 152px; width: 234px"/></a>
    <a href="Facimages/ts3.gif.jpg" rel="prettyPhoto[gallery1]" title="Image 13">
        <img src="Facimages/ts3.gif.jpg" alt="Title Text" 
            style="height: 152px; width: 234px"/></a>
    <a href="Facimages/2009_6361.jpg" rel="prettyPhoto[gallery1]" title="Image 13">
        <img src="Facimages/2009_6361.jpg" alt="Title Text" 
            style="height: 152px; width: 234px"/></a>
            
   </div>
    
    
  </div>
</div>
</form>
</asp:Content>


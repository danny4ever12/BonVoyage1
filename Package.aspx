<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Package.aspx.cs" Inherits="Package" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>BonVoyage | Packages</title>
    <style type="text/css">
        .style3
        {
            height: 48px;
        }
        .style4
        {
            height: 23px;
        }
        .style5
        {
            height: 23px;
            width: 326px;
        }
        .style6
        {
            height: 48px;
            width: 326px;
        }
        .imgholder
        {
            height: 32px;
            width: 920px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="wrapper col4">
  <div id="container" class="clear"> 
   <form id="form1" runat="server">
     
    <h1 style="color: #800080">Packages we offer</h1>
    <div id="Div1">
      <ul>
        <li>
          
          <p class="title" 
                
                style="color: #00CC00; font-style: italic; font-size: large; font-family: Arial, Helvetica, sans-serif; width: 124px;">Summer Pack</p>
                <div style="width: 349px; height: 24px; z-index: 1; left: 5981px; top: 183px; "> 
                
                    <asp:Button ID="Button1" runat="server" Text="click to avail this package" 
                        BackColor="#660066" ForeColor="White" onclick="Button1_Click" 
                        Width="225px" Font-Bold="True" Font-Italic="True" /> 
                        
               </div>

          <p class="projectdescription" 
                style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;">Enjoy this summer season with a 3 day cruize to munnar banglore and koorg. Take a walk through the tea museums in munnar, have a party time in banglore and enjoy river rafting in coorg. </p> 
              <table style="width:95%; height: 103px;">
                  <tr>
                      <td class="style4" 
                          style="color: #800000; font-style: italic; font-size: medium; font-family: Arial, Helvetica, sans-serif">package name
                          &nbsp;</td>
                      <td class="style4" 
                          style="color: #800000; font-size: medium; font-style: italic; font-family: Arial, Helvetica, sans-serif">duration
                          &nbsp;</td>
                      <td class="style5" 
                          style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic; color: #800000">details
                          &nbsp;</td>
                      <td class="style4" 
                          style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic; color: #800000">hotel facility
                          &nbsp;</td>
                    <td class="style4" style="color: #800000; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic">price
                          &nbsp;</td>
                  </tr>
                  <tr>
                      <td class="style3">summer pack
                          &nbsp;</td>
                      <td class="style3">3days
                          &nbsp;</td>
                      <td class="style6">Munnar(mattupetty and tea museum + stay)<br />
&nbsp;Banglore(wonderla+ commercial street+ stay)
                          <br />
                          Koorg(river rafting,no stay)

                          &nbsp;</td>
                      <td class="style3">Ace hotel (Munnar,AC,1night),
                          <br />
                          Raj hotel(Banglore,AC,1 night)

                          &nbsp;</td>
                      <td class="style3">
                          4000/-approx.
                          &nbsp;</td>
                  </tr>
                
              </table>
            
          

        </li>
        
        

     </ul>
        <p>
            <a href="images/iiii.gif.jpg">
            <img src="images/iiii.gif.jpg"
                      alt="Title Text" style="height: 133px; width: 228px" /></a>
            <a href="images/munnar.gif">
            <img src="images/munnar.gif"
                      alt="Title Text" style="height: 133px; width: 228px" /></a>
            <a href="images/banhotel.gif.jpg">
            <img src="images/banhotel.gif.jpg"
                      alt="Title Text" style="height: 133px; width: 228px" /></a>
            <a href="images/cc.gif.jpg">
            <img src="images/cc.gif.jpg"
                      alt="Title Text" style="height: 133px; width: 228px" /></a>
        </p>
        <p></p>
        <ul>
            <li>
                <p class="title" 
                
                    style="color: #00CC00; font-style: italic; font-size: large; font-family: Arial, Helvetica, sans-serif; width: 138px;">
                  Weekly wonder</p>

               <div style="width: 321px; z-index: 1; left: 197px; top: 455px; height: 26px"> 
                 
                 <asp:Button ID="Button2" runat="server" Text="click to avail this package" 
                     style="width: 225px; "
                      BackColor="#660066" ForeColor="White"  onclick="Button2_Click" 
                       Font-Bold="True" Font-Italic="True" />
                 
                 </div>
          
          <p class="projectdescription" 
                style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;">Enjoy the one day trip to silent valley, cruize the land of peace and enjoy the fresh non toxic breath and get closer to nature atleast for one day....! </p> 
              <table style="width:95%; height: 103px;">
                  <tr>
                      <td class="style4" 
                          style="color: #800000; font-style: italic; font-size: medium; font-family: Arial, Helvetica, sans-serif">package name
                          &nbsp;</td>
                      <td class="style4" 
                          style="color: #800000; font-size: medium; font-style: italic; font-family: Arial, Helvetica, sans-serif">duration
                          &nbsp;</td>
                      <td class="style5" 
                          style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic; color: #800000">details
                          &nbsp;</td>
                      <td class="style4" 
                          style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic; color: #800000">hotel facility
                          &nbsp;</td>
                      <td class="style4" style="color: #800000; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic">price
                          &nbsp;</td>
                  </tr>
                  <tr>
                      <td class="style3">weekly wonder
                          &nbsp;</td>
                      <td class="style3">1 day
                          &nbsp;</td>
                      <td class="style6">SilentValley(trekking+sight seeing)

                          &nbsp;</td>
                      <td class="style3">Sai Hotel(refreshing only, no stay)

                          &nbsp;</td>

                      <td class="style3">
                          1000/-approx.
                          &nbsp;</td>
                  </tr>
                
              </table>
            
          </li>



     </ul>
        <p>
            <a href="images/sil1.gif.jpg">
            <img src="images/sil1.gif.jpg"
                      alt="Title Text" style="height: 133px; width: 228px" /></a>
            <a href="images/sil.gif.jpg">
            <img src="images/sil.gif.jpg"
                      alt="Title Text" style="height: 133px; width: 228px" /></a>
            <a href="images/silhote.gif.jpg">
            <img src="images/silhote.gif.jpg"
                      alt="Title Text" style="height: 133px; width: 228px" /></a>
            <a href="Facimages/silent-valley-national.gif">
            <img src="Facimages/silent-valley-national.gif"
                      alt="Title Text" style="height: 133px; width: 228px" /></a>
        </p>
        <p class="title" 
                style="color: #00CC00; font-style: italic; font-size: large; font-family: Arial, Helvetica, sans-serif;">
            &nbsp;</p>
        <ul>
            <li>
                <p class="title" 
                style="color: #00CC00; font-style: italic; font-size: large; font-family: Arial, Helvetica, sans-serif;">
                  Honeymoon special</p>

                   <div style="width: 354px; z-index: 1; left: 234px; top: 577px; height: 26px" > 
                
                    <asp:Button ID="Button3" runat="server" Text="click to avail this package" 
                        BackColor="#660066" ForeColor="White" onclick="Button3_Click" 
                        Width="225px" Font-Bold="True" Font-Italic="True" /> 
                        
               </div>
          
          <p class="projectdescription" 
                style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;"> 
              Take your better half on a romantic trip to darjeeling,the land of romance.We provide star rated facilities to make sure you have the best honeymoon experience ever! </p> 
              <table style="width:95%; height: 103px;">
                  <tr>
                      <td class="style4" 
                          style="color: #800000; font-style: italic; font-size: medium; font-family: Arial, Helvetica, sans-serif">package name
                          &nbsp;</td>
                      <td class="style4" 
                          style="color: #800000; font-size: medium; font-style: italic; font-family: Arial, Helvetica, sans-serif">duration
                          &nbsp;</td>
                      <td class="style5" 
                          style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic; color: #800000">details
                          &nbsp;</td>
                      <td class="style4" 
                          style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic; color: #800000">hotel facility
                          &nbsp;</td>
                      <td class="style4" style="color: #800000; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic">price
                          &nbsp;</td>
                  </tr>
                  <tr>
                      <td class="style3">Honeymoon special
                          &nbsp;</td>
                      <td class="style3">5nights,6days
                          &nbsp;</td>
                      <td class="style6">
                      Darjeeling-[5N/6D]
                          &nbsp;</td>
                      <td class="style3">
                      SnowLion Homestay(3star,4nights)
                          &nbsp;</td>
                      <td class="style3">
                          8000/-approx.
                          &nbsp;</td>
                  </tr>
                
              </table>
          
          
       </li>



     </ul>
        <p>
            <a href="Packimages/dar.gif.jpg">
            <img src="Packimages/dar.gif.jpg"
                      alt="Title Text" style="height: 133px; width: 228px" /></a>
            <a href="Packimages/darj.gif.jpg">
            <img src="Packimages/darj.gif.jpg"
                      alt="Title Text" style="height: 133px; width: 228px" /></a>
            <a href="Packimages/dar1.gif.jpg">
            <img src="Packimages/dar1.gif.jpg"
                      alt="Title Text" style="height: 133px; width: 228px" /></a>
            <a href="Packimages/darrr.gif.jpg">
            <img src="Packimages/darrr.gif.jpg"
                      alt="Title Text" style="height: 133px; width: 228px" /></a>
        </p>
        <p class="title" 
                style="color: #00CC00; font-style: italic; font-size: large; font-family: Arial, Helvetica, sans-serif;">
            &nbsp;</p>
        <ul>
            <li>
                <p class="title" 
                style="color: #00CC00; font-style: italic; font-size: large; font-family: Arial, Helvetica, sans-serif;">
                  Vibrant goa</p>

                   <div style="width: 317px; z-index: 1; left: 234px; top: 856px;  height: 26px" > 
                
                    <asp:Button ID="Button4" runat="server" Text="click to avail this package" 
                        BackColor="#660066" ForeColor="White" onclick="Button4_Click" 
                        Width="225px" Font-Bold="True" Font-Italic="True" /> 
                        
               </div>
                  
          
          <p class="projectdescription" 
                style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;">Enjoy one of the most exotic places in all of india for 4 days and kick start your summer at a relatively cheap price. Enjoy all the luxury class facilities and night party's have an unforgettable experience altogether...!
               </p> 
                <ul>
                    <li>
                        <p class="projectdescription" 
                style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;">
                            Accommodation at Standard hotels</p>
                    </li>
                    <li>
                        <p class="projectdescription" 
                style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;">
                            3 Nights in GOA at &#8211; Resort Marinha Dourada or Similar</p>
                    </li>
                    <li>
                        <p class="projectdescription" 
                style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;">
                            Accommodation on well appointed Air-conditioned room.</p>
                    </li>
                    <li>
                        <p class="projectdescription" 
                style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;">
                            Buffet breakfast at our restaurants.</p>
                    </li>
                    <li>
                        <p class="projectdescription" 
                style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;">
                            Use of swimming pool.</p>
                    </li>
              </ul>
            


              
              <table style="width:95%; height: 103px;">
                  <tr>
                      <td class="style4" 
                          style="color: #800000; font-style: italic; font-size: medium; font-family: Arial, Helvetica, sans-serif">package name
                          &nbsp;</td>
                      <td class="style4" 
                          style="color: #800000; font-size: medium; font-style: italic; font-family: Arial, Helvetica, sans-serif">duration
                          &nbsp;</td>
                      <td class="style5" 
                          style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic; color: #800000">details
                          &nbsp;</td>
                      <td class="style4" 
                          style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic; color: #800000">hotel facility
                          &nbsp;</td>
                      <td class="style4" style="color: #800000; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic">price
                          &nbsp;</td>
                  </tr>
                  <tr>
                      <td class="style3">Vibrant goa
                          &nbsp;</td>
                      <td class="style3">4 days
                          &nbsp;</td>
                      <td class="style6">goa beaches and other historic places

                          &nbsp;</td>
                      <td class="style3">Resort Marinha Dourda(3 STAR)(3nights)

                          &nbsp;</td>
                      <td class="style3">
                          7000/-approx.
                          &nbsp;</td>
                  </tr>
                
              </table>
            
       </li>



     </ul>
        
        <p>
            <a href="Packimages/goa1.gif.jpg">
            <img src="Packimages/goa1.gif.jpg"
                      alt="Title Text" style="height: 133px; width: 228px" /></a>
            <a href="Packimages/goa2.gif.jpg">
            <img src="Packimages/goa2.gif.jpg"
                      alt="Title Text" style="height: 133px; width: 228px" /></a>
            <a href="Packimages/goa3.gif.jpg">
            <img src="Packimages/goa3.gif.jpg"
                      alt="Title Text" style="height: 133px; width: 228px" /></a>
            <a href="Packimages/goa6.gif.jpg">
            <img src="Packimages/goa6.gif.jpg"
                      alt="Title Text" style="height: 133px; width: 228px" /></a>
        </p>
        <p></p>

         <ul>
            <li>
                <p class="title" 
                style="color: #00CC00; font-style: italic; font-size: large; font-family: Arial, Helvetica, sans-serif;">
                  Thrilling Manali</p>

                   <div style="width: 354px; z-index: 1; left: 234px; top: 577px; height: 26px" > 
                
                    <asp:Button ID="Button5" runat="server" Text="click to avail this package" 
                        BackColor="#660066" ForeColor="White" onclick="Button5_Click" 
                        Width="225px" Font-Bold="True" Font-Italic="True" /> 
                        
               </div>
          
          <p class="projectdescription" 
                style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;"> 
              Take your family on a trip to manali at this time of the year and enjoy the best that manali has to offer! </p> 
              <table style="width:95%; height: 103px;">
                  <tr>
                      <td class="style4" 
                          style="color: #800000; font-style: italic; font-size: medium; font-family: Arial, Helvetica, sans-serif">package name
                          &nbsp;</td>
                      <td class="style4" 
                          style="color: #800000; font-size: medium; font-style: italic; font-family: Arial, Helvetica, sans-serif">duration
                          &nbsp;</td>
                      <td class="style5" 
                          style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic; color: #800000">details
                          &nbsp;</td>
                      <td class="style4" 
                          style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic; color: #800000">hotel facility
                          &nbsp;</td>
                      <td class="style4" style="color: #800000; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic">price
                          &nbsp;</td>
                  </tr>
                  <tr>
                      <td class="style3">Thrilling Manali
                          &nbsp;</td>
                      <td class="style3">3 Nights/4 days
                          &nbsp;</td>
                      <td class="style6">
                      Manali
                          &nbsp;</td>
                      <td class="style3">
                      Snow Crest Manor(3star,3nights)
                          &nbsp;</td>
                      <td class="style3">
                          6000/-approx.
                          &nbsp;</td>
                  </tr>
                
              </table>
          
          
       </li>



     </ul>
        <p>
            <a href="Packimages/man1.gif.jpg">
            <img src="Packimages/man1.gif.jpg"
                      alt="Title Text" style="height: 133px; width: 228px" /></a>
            <a href="Packimages/man2.gif.jpg">
            <img src="Packimages/man2.gif.jpg"
                      alt="Title Text" style="height: 133px; width: 228px" /></a>
            <a href="Packimages/man4.gif.jpg">
            <img src="Packimages/man4.gif.jpg"
                      alt="Title Text" style="height: 133px; width: 228px" /></a>
            <a href="Packimages/man3.gif.jpg">
            <img src="Packimages/man3.gif.jpg"
                      alt="Title Text" style="height: 133px; width: 228px" /></a>
        </p>
        <p class="title" 
                style="color: #00CC00; font-style: italic; font-size: large; font-family: Arial, Helvetica, sans-serif;">
            &nbsp;</p>


              <ul>
            <li>
                <p class="title" 
                style="color: #00CC00; font-style: italic; font-size: large; font-family: Arial, Helvetica, sans-serif;">
                  Holy Land(Jerusalem) pack</p>

                   <div style="width: 354px; z-index: 1; left: 234px; top: 577px; height: 26px" > 
                
                    <asp:Button ID="Button6" runat="server" Text="click to avail this package" 
                        BackColor="#660066" ForeColor="White" onclick="Button6_Click" 
                        Width="225px" Font-Bold="True" Font-Italic="True" /> 
                        
               </div>
          
          <p class="projectdescription" 
                style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;"> 
              Go on a holyland tour visiting the places where jesus christ was born and where his ministry took place and be a witness to the place where the miracles took place  </p> 
              <table style="width:95%; height: 103px;">
                  <tr>
                      <td class="style4" 
                          style="color: #800000; font-style: italic; font-size: medium; font-family: Arial, Helvetica, sans-serif">package name
                          &nbsp;</td>
                      <td class="style4" 
                          style="color: #800000; font-size: medium; font-style: italic; font-family: Arial, Helvetica, sans-serif">duration
                          &nbsp;</td>
                      <td class="style5" 
                          style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic; color: #800000">details
                          &nbsp;</td>
                      <td class="style4" 
                          style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic; color: #800000">hotel facility
                          &nbsp;</td>
                      <td class="style4" style="color: #800000; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic">price
                          &nbsp;</td>
                  </tr>
                  <tr>
                      <td class="style3">Holy Land(Jerusalem) pack
                          &nbsp;</td>
                      <td class="style3">12nights,12 days
                          &nbsp;</td>
                      <td class="style6">
                      Egypt(pyramids,oasis,4days),Jordan river and surrounding places(3days),Bethlahem(3days),Galilea(1day)
                          &nbsp;</td>
                      <td class="style3">
                      Sea Crest hotel(3star,3nights,Egypt),
                      Lorents manor(3star,3nights,Jordan),
                      Mary's residency(3star,3nights,Bethlahem)
                          &nbsp;</td>
                      <td class="style3">
                          40000/-approx.
                          &nbsp;</td>
                  </tr>
                
              </table>
          
          
       </li>



     </ul>
        <p>
            <a href="Packimages/jeru.gif.jpg">
            <img src="Packimages/jeru.gif.jpg"
                      alt="Title Text" style="height: 133px; width: 228px" /></a>
            <a href="Packimages/rock.gif.jpg">
            <img src="Packimages/rock.gif.jpg"
                      alt="Title Text" style="height: 133px; width: 228px" /></a>
            <a href="Packimages/Jer1.gif.jpg">
            <img src="Packimages/Jer1.gif.jpg"
                      alt="Title Text" style="height: 133px; width: 228px" /></a>
            <a href="Packimages/Jer4.gif.jpg">
            <img src="Packimages/Jer4.gif.jpg"
                      alt="Title Text" style="height: 133px; width: 228px" /></a>
        </p>
        <p class="title" 
                style="color: #00CC00; font-style: italic; font-size: large; font-family: Arial, Helvetica, sans-serif;">
            &nbsp;</p>
        
    </div>
    </form>
 </div>


    
    
</div>
</asp:Content>


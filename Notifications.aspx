<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Notifications.aspx.cs" Inherits="Notifications" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>BonVoyage|Notifications</title>
    <style type="text/css">
        .style2
        {
            height: 80px;
        }
        .style3
        {
            height: 78px;
        }
        .style4
        {
            width: 135px;
        }
        .style5
        {
            height: 80px;
            width: 135px;
        }
        .style6
        {
            height: 78px;
            width: 135px;
        }
        .style13
        {
            width: 403px;
        }
        .style16
        {
            width: 110px;
        }
        .style17
        {
            height: 80px;
            width: 110px;
        }
        .style18
        {
            height: 78px;
            width: 110px;
        }
        .style19
        {
            width: 99px;
        }
        .style20
        {
            height: 80px;
            width: 99px;
        }
        .style21
        {
            width: 128px;
        }
        .style22
        {
            height: 80px;
            width: 128px;
        }
        .style23
        {
            height: 78px;
            width: 128px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <form id="form1" runat="server">

    <div class="wrapper col4">
    <div>
          <p style="font-family: Arial, Helvetica, sans-serif; font-size: xx-large; font-weight: bold; font-style: italic; color: #800080;">Notifications</p>
    </div>

    <table style="width: 100%;">
        <tr>
            <td class="style4" 
                style="color: #800000; font-family: Arial, Helvetica, sans-serif; font-size: large; font-style: italic">UserName
                &nbsp;
            </td>
            <td class="style21" 
                
                style="color: #800000; font-family: Arial, Helvetica, sans-serif; font-size: large; font-style: italic">Mail Id
                &nbsp;
            </td>
            <td class="style16" 
                
                style="font-family: Arial, Helvetica, sans-serif; font-size: large; font-style: italic; color: #800000">Date
                &nbsp;
            </td>
             <td class="style19" 
                
                style="color: #800000; font-family: Arial, Helvetica, sans-serif; font-size: large; font-style: italic">Time
                &nbsp;
            </td>
            <td class="style13" 
                style="color: #800000; font-family: Arial, Helvetica, sans-serif; font-size: large; font-style: italic">Details
                &nbsp;
            </td>
            <td class="style13">
                
                &nbsp;
            </td>

            
        </tr>
        <tr>
            <td class="style5"><p id="h1" style="height: 86px; color: #808080; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;"> <%=sh1%></p>
                &nbsp;
            </td>
            <td class="style22"> <p id="P1" style="height: 86px; color: #808080; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;"><%=sd1%></p>
                &nbsp;
            </td>
            <td class="style17"><p id="P8" style="height: 86px; color: #808080; font-family: Arial, Helvetica, sans-serif; font-size:medium ; font-style: italic;"><%=st1%></p>
                &nbsp;
            </td>
            <td class="style19"><p id="P9" style="height: 86px; color: #808080; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;"><%=si1%></p>
                &nbsp;
            </td>
              <td class="style2"><p id="P16" 
                      
                      style="height: 86px; color: #808080; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic; width: 392px;"><%=sm1%></p>
                &nbsp;
            </td>
             <td class="style13">
                
                &nbsp;
                <asp:Button ID="Button1" runat="server" BackColor="#66CCFF" 
              BorderColor="#6699FF" Font-Bold="True" Font-Italic="True" Font-Size="Large" 
              onclick="Button1_Click" 
              style="z-index: 1; left: 29px; top: -32px; position: relative; height: 39px; width: 90px;" 
              Text="delete" />
              </td>
        </tr>
        <tr>
            <td class="style5"> <p id="P7" 
                    style="height: 86px; color: #808080; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;"><%=sh2%></p>
                &nbsp;
            </td> 
            <td class="style22"><p id="P2" style="height: 86px; color: #808080; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;"><%=sd2%></p>
                &nbsp;
            </td>
            <td class="style16"><p id="P10" style="height: 86px; color: #808080; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;"><%=st2%></p>
                &nbsp;
            </td>
            <td class="style20"><p id="P11" style="height: 86px; color: #808080; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;"><%=si2%></p>
                &nbsp;
            </td>
              <td class="style2"><p id="P17" 
                      style="height: 86px; color: #808080; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic; width: 391px;"><%=sm2%></p>
                &nbsp;
            </td>
             <td class="style13">
                &nbsp;
                 <asp:Button ID="Button2" runat="server" BackColor="#66CCFF" 
              BorderColor="#6699FF" Font-Bold="True" Font-Italic="True" Font-Size="Large" 
              onclick="Button2_Click" 
               style="z-index: 1; left: 29px; top: -32px; position: relative; height: 39px; width: 90px;" 
              Text="delete" Width="80px" Height="37px" />
            </td>

        </tr>
         <tr>
            <td class="style5"> <p id="P6" style="height: 86px; color: #808080; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;"><%=sh3%></p>
                &nbsp;
            </td>
            <td class="style21"> <p id="P3" style="height: 86px; color: #808080; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;"><%=sd3%></p>
                &nbsp;
            </td>
            <td class="style17"><p id="P12" style="height: 86px; color: #808080; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;"><%=st3%></p>
                &nbsp;
            </td>
            <td class="style20"><p id="P13" style="height: 86px;color: #808080; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;"><%=si3%></p>
                &nbsp;
            </td>
              <td class="style2"><p id="P18" style="height: 86px; color: #808080; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;"><%=sm3%></p>
                  &nbsp;</td>
              <td class="style13">
                &nbsp;
                 <asp:Button ID="Button3" runat="server" BackColor="#66CCFF" 
              BorderColor="#6699FF" Font-Bold="True" Font-Italic="True" Font-Size="Large" 
              onclick="Button3_Click" 
               style="z-index: 1; left: 29px; top: -32px; position: relative; height: 39px; width: 90px;"
              Text="delete" Width="80px" Height="37px" />
            </td>

        </tr>
         <tr>
            <td class="style6"><p id="P5" style="height: 86px;color: #808080; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;"><%=sh4%></p>
                &nbsp;
            </td>
            <td class="style23"><p id="P4" style="height: 86px;color: #808080; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;"><%=sd4%></p>
                &nbsp;
            </td>
            <td class="style18"><p id="P14" style="height: 86px;color: #808080; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;"><%=st4%></p>
                &nbsp;
            </td>
            <td class="style19"><p id="P15" style="height: 86px;color: #808080; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;"><%=si4%></p>
                &nbsp;
            </td>
              <td class="style3"><p id="P19" style="height: 86px; color: #808080; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;"><%=sm4%></p>
                &nbsp;
            </td>
             <td class="style13">
                &nbsp;
                 <asp:Button ID="Button4" runat="server" BackColor="#66CCFF" 
              BorderColor="#6699FF" Font-Bold="True" Font-Italic="True" Font-Size="Large" 
              onclick="Button4_Click" 
               style="z-index: 1; left: 29px; top: -32px; position: relative; height: 39px; width: 90px;" 
              Text="delete" Width="80px" Height="37px" />
            </td>


        </tr>
    </table>
    </div>

    </form>

</asp:Content>


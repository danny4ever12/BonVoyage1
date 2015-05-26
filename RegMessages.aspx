<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RegMessages.aspx.cs" Inherits="RegMessages" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>BonVoyage|Messages </title>
    <style type="text/css">
        .style2
        {
            height: 80px;
        }
        .style3
        {
            height: 78px;
            width: 358px;
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
        .style7
        {
            width: 95px;
        }
        .style8
        {
            height: 80px;
            width: 95px;
        }
        .style9
        {
            height: 78px;
            width: 95px;
        }
        .style10
        {
            width: 76px;
        }
        .style11
        {
            height: 80px;
            width: 76px;
        }
        .style12
        {
            height: 78px;
            width: 76px;
        }
        .style13
        {
            width: 403px;
        }
        .style14
        {
            height: 80px;
            width: 403px;
        }
        .style15
        {
            width: 358px;
        }
        .style16
        {
            height: 80px;
            width: 358px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<form id="form1" runat="server">
 <div class="wrapper col4">
    <div>
          <p style="font-family: Arial, Helvetica, sans-serif; font-size: xx-large; font-weight: bold; font-style: italic; color: #800080;">Messages</p>
    </div>

    <table style="width: 90%;">
        <tr>
            <td class="style4" 
                style="color: #800000; font-family: Arial, Helvetica, sans-serif; font-size: large; font-style: italic">Header
                &nbsp;
            </td>
            <td class="style7" 
                style="color: #800000; font-family: Arial, Helvetica, sans-serif; font-size: large; font-style: italic">Date
                &nbsp;
            </td>
            <td class="style10" 
                style="font-family: Arial, Helvetica, sans-serif; font-size: large; font-style: italic; color: #800000">Time
                &nbsp;
            </td>
             <td class="style13" 
                style="color: #800000; font-family: Arial, Helvetica, sans-serif; font-size: large; font-style: italic">Details
                &nbsp;
            </td>
             <td class="style15" 
                
                style="color: #800000; font-family: Arial, Helvetica, sans-serif; font-size: large; font-style: italic">Images
                &nbsp;
            </td>
            
        </tr>
        <tr>
            <td class="style5"><p id="h1" style="height: 86px; color: #808080; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;"> <%=sh1%></p>
                &nbsp;
            </td>
            <td class="style8"> <p id="P1" style="height: 86px; color: #808080; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;"><%=sd1%></p>
                &nbsp;
            </td>
            <td class="style11"><p id="P8" style="height: 86px; color: #808080; font-family: Arial, Helvetica, sans-serif; font-size:medium ; font-style: italic;"><%=st1%></p>
                &nbsp;
            </td>
            <td class="style13"><p id="P9" style="height: 86px; color: #808080; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;"><%=si1%></p>
                &nbsp;
            </td>
             <td class="style16">
              
               <a href="<%=simg1%>"><img src="<%=simg1%>"
                      alt="Title Text" style="height: 133px; width: 228px" /></a>
               
            </td>
           
              <td class="style2">
              
               <asp:Button ID="Button1" runat="server" BackColor="#66CCFF" 
              BorderColor="#6699FF" Font-Bold="True" Font-Italic="True" Font-Size="Large" 
              onclick="Button1_Click" 
              style="z-index: 1; left: 0px; top: -32px; position: relative; height: 39px; width: 90px;" 
              Text="delete" />
               
            </td>

        </tr>
        <tr>
            <td class="style5"> <p id="P7" 
                    style="height: 86px; color: #808080; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;"><%=sh2%></p>
                &nbsp;
            </td> 
            <td class="style8"><p id="P2" style="height: 86px; color: #808080; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;"><%=sd2%></p>
                &nbsp;
            </td>
            <td class="style10"><p id="P10" style="height: 86px; color: #808080; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;"><%=st2%></p>
                &nbsp;
            </td>
            <td class="style14"><p id="P11" style="height: 86px; color: #808080; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;"><%=si2%></p>
                &nbsp;
            </td>
              <td class="style16">
               <a href="<%=simg2%>"><img src="<%=simg2%>"
                      alt="Title Text" style="height: 133px; width: 228px" /></a>
              
            </td>
             <td class="style2">
              <asp:Button ID="Button2" runat="server" BackColor="#66CCFF" 
              BorderColor="#6699FF" Font-Bold="True" Font-Italic="True" Font-Size="Large" 
              onclick="Button2_Click" 
              style="z-index: 1; top: -32px; position: relative; height: 39px; width: 90px;" 
              Text="delete" />
               
               
            </td>
        </tr>
         <tr>
            <td class="style5"> <p id="P6" style="height: 86px; color: #808080; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;"><%=sh3%></p>
                &nbsp;
            </td>
            <td> <p id="P3" style="height: 86px; color: #808080; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;"><%=sd3%></p>
                &nbsp;
            </td>
            <td class="style11"><p id="P12" style="height: 86px; color: #808080; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;"><%=st3%></p>
                &nbsp;
            </td>
            <td class="style14"><p id="P13" style="height: 86px;color: #808080; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;"><%=si3%></p>
                &nbsp;
            </td>
              <td class="style16">
               <a href="<%=simg3%>"><img src="<%=simg3%>"
                      alt="Title Text" style="height: 133px; width: 228px" /></a>
             </td>
              <td class="style2">
              
               <asp:Button ID="Button3" runat="server" BackColor="#66CCFF" 
              BorderColor="#6699FF" Font-Bold="True" Font-Italic="True" Font-Size="Large" 
              onclick="Button3_Click" 
              style="z-index: 1; top: -32px; position: relative; height: 39px; width: 90px;" 
              Text="delete" />
               
            </td>
        </tr>
         <tr>
            <td class="style6"><p id="P5" style="height: 86px;color: #808080; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;"><%=sh4%></p>
                &nbsp;
            </td>
            <td class="style9"><p id="P4" style="height: 86px;color: #808080; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;"><%=sd4%></p>
                &nbsp;
            </td>
            <td class="style12"><p id="P14" style="height: 86px;color: #808080; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;"><%=st4%></p>
                &nbsp;
            </td>
            <td class="style13"><p id="P15" style="height: 86px;color: #808080; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic;"><%=si4%></p>
                &nbsp;
            </td>
              <td class="style3">
                 <a href="<%=simg4%>"><img src="<%=simg4%>"
                      alt="Title Text" style="height: 133px; width: 228px" /></a>
            </td>
             <td class="style2">
              <asp:Button ID="Button4" runat="server" BackColor="#66CCFF" 
              BorderColor="#6699FF" Font-Bold="True" Font-Italic="True" Font-Size="Large" 
              onclick="Button4_Click" 
              style="z-index: 1; top: -32px; position: relative; height: 39px; width: 90px;" 
              Text="delete" />
               
               
            </td>
        </tr>
    </table>
    </div>
    </form>
</asp:Content>


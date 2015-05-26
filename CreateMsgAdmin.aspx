<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CreateMsgAdmin.aspx.cs" Inherits="CreateMsgAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<title>BonVoyage|CreateMessage</title>
    <style type="text/css">
        .style1
        {
            height: 701px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

 <form id="form1" runat="server">
    <div class="wrapper col4">
  <div id="containercrmsg" class="clear"> 
    

<table style="width: 100%; height: 734px;">
            <tr>
                <td class="style1">

                    <p style="z-index: 1; left: 6px; height: 35px; width: 698px; color: #800080; font-family: Arial, Helvetica, sans-serif; font-size: xx-large; font-weight: bolder; font-style: italic;">Sent messages and newsletters to clients</p>
                    <p style="color: #800000; font-family: Arial, Helvetica, sans-serif; font-size: x-large; font-style: italic">To</p>
                    <asp:RadioButton ID="RadioButton1" runat="server" Text="All users" 
                        GroupName="v1" />
                    <asp:RadioButton ID="RadioButton2" runat="server" Text="specific user" 
                        GroupName="v1" />
                    <p style="color: #800000; font-family: Arial, Helvetica, sans-serif; font-size: x-large; font-style: italic">Enter email id of specific user </p>
                    <asp:TextBox 
                            ID="TextBox1" runat="server"  BackColor="#FFCC99" 
              BorderColor="#FF9966" BorderStyle="Solid" Font-Bold="True" Font-Italic="True" 
              Font-Size="Medium" Height="36px"
                            style="width: 260px; height: 35px"></asp:TextBox>
                    <p style="color: #800000; font-family: Arial, Helvetica, sans-serif; font-size: x-large; font-style: italic">
                       Header</p>
                    <asp:TextBox ID="TextBox4" runat="server"  BackColor="#FFCC99" 
              BorderColor="#FF9966" BorderStyle="Solid" Font-Bold="True" Font-Italic="True" 
              Font-Size="Medium"  Height="45px" Width="648px"></asp:TextBox>
                   <p style="color: #800000; font-family: Arial, Helvetica, sans-serif; font-size: x-large; font-style: italic">
                       Enter message</p>
                    <asp:TextBox ID="TextBox2" runat="server"  BackColor="#FFCC99" 
              BorderColor="#FF9966" BorderStyle="Solid" Font-Bold="True" Font-Italic="True" 
              Font-Size="Medium" Height="106px" Width="649px"></asp:TextBox>
                    <p style="color: #800000; font-family: Arial, Helvetica, sans-serif; font-size: x-large; font-style: italic">
                        Include pictures if any</p>
                    <asp:TextBox ID="TextBox3" runat="server"  BackColor="#FFCC99" 
              BorderColor="#FF9966" BorderStyle="Solid" Font-Bold="True" Font-Italic="True" 
              Font-Size="Medium" Height="35px" Width="649px"></asp:TextBox>
                    <p></p>
                    <asp:Button ID="Button2" runat="server" Text="send" BackColor="#993333" 
                        BorderColor="#990000" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" 
                        ForeColor="#CCFFFF" onclick="Button2_Click" 
                        
                        
                        style="width: 213px; height: 37px" />
                </td>
              
            </tr>
        </table>
        </div>
        </div>
        </form>
</asp:Content>


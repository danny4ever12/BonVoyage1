<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

  <title>Bonvoyage | Login</title>
    <style type="text/css">
      
        .newStyle1
        {
            font-family: "Courier New";
            font-size: medium;
            font-style: italic;
            color: #808080;
            padding: 0px;
        }
        #containerlgin
        {
           
            font-family: "Courier New";
            font-size: medium;
            font-style: italic;
            color: #808080;
            font-weight: normal;
            width: 1348px;
            background-image: url('images/bonback.jpg');
          
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<form id="form1" runat="server">
    <div class="wrapper col4">
  <div id="containerlgin" class="clear">
  
    
          <p style="width: 351px; z-index: 1; left: 442px; top: 74px; position: absolute; height: 31px; font-size: x-large; font-style: italic; font-weight: bold;">sign up for an account</p>
           <table style="width: 50%; z-index: 1; left: 440px; top: 130px; position: absolute; height: 145px;">
              <tr>
                  <td>
                      User name
                  </td>
                  <td>
                      &nbsp;<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                          ControlToValidate="TextBox3" ErrorMessage="*" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                  </td>
                 
              </tr>
              <tr>
                  <td>
                      email id 
                  </td>
                  <td>
                      &nbsp;<asp:TextBox 
                          ID="TextBox4" runat="server" AutoCompleteType="Email"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                          ControlToValidate="TextBox4" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                  </td>
                 
              </tr>
               <tr>
                  <td>Mobile no
                      &nbsp;
                  </td>
                  <td>
                      &nbsp;<asp:TextBox 
                          ID="TextBox7" runat="server"></asp:TextBox>
                  </td>
                 
              </tr>
              <tr>
                  <td>password
                      &nbsp;
                  </td>
                  <td>
                      &nbsp;<asp:TextBox 
                          ID="TextBox5" runat="server" ontextchanged="TextBox5_TextChanged" 
                          TextMode="Password"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                          ControlToValidate="TextBox5" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                  </td>
                 
              </tr>
               <tr>
                  <td>confirm password
                      &nbsp;
                  </td>
                  <td>
                      &nbsp;<asp:TextBox ID="TextBox6" runat="server" 
                          TextMode="Password"></asp:TextBox>
                      <asp:CompareValidator ID="CompareValidator1" runat="server" 
                          ControlToCompare="TextBox6" ControlToValidate="TextBox5" 
                          ErrorMessage="invalid password" ForeColor="Red"></asp:CompareValidator>
                  </td>
                 
              </tr>
               
               <tr>
                  <td>&nbsp;
                      
                  </td>
                  <td>
                     &nbsp;<asp:Button 
                          ID="Button2" runat="server" 
                          Text="Sign up" Width="126px" onclick="Button2_Click" BackColor="#33CCFF" 
                          BorderColor="#00CCFF" Font-Bold="True" Font-Italic="True" ForeColor="#000066" />
                  </td>
                 
              </tr>
          </table>
      
      <table style="width: 26%; z-index: 1; left: 40px; top: 163px; position: absolute; height: 96px;">
              <tr>
                  <td class="style1" >Mail id
                      &nbsp;
                  </td>
                 
                  <td>
                      &nbsp;<asp:TextBox 
                          ID="TextBox1" runat="server" 
                          Width="136px" AutoCompleteType="Email"></asp:TextBox>
                  </td>
              </tr>
              <tr>
                  <td class="style1">Password
                      &nbsp;
                  </td>
                  <td>&nbsp;<asp:TextBox ID="TextBox2" runat="server" style="margin-left: 0px" 
                          Width="138px" TextMode="Password"></asp:TextBox>
                      &nbsp;</td>
               
              </tr>
              <tr>
                  <td class="style1">&nbsp;
                      
                  </td>
                  <td>
                      &nbsp;<asp:Button 
                          ID="Button1" runat="server" 
                          Text="Log in" Width="130px" onclick="Button1_Click" 
                          CausesValidation="False" BackColor="#33CCFF" BorderColor="#00CCFF" 
                          Font-Bold="True" Font-Italic="True" ForeColor="#000066" />
                  </td>
                  
              </tr>
          </table>


     
    
      <p style="width: 369px; z-index: 1; left: 39px; top: 72px; position: absolute; height: 58px; font-weight: bold; font-size: x-large;">Login if already have an account</p>

   </div>
  </div>
  </form> 
</asp:Content>


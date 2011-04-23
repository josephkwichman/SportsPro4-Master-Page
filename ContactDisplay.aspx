<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="ContactDisplay.aspx.vb" Inherits="ContactDisplay" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Contact Display</title>
    <style type="text/css">
        .style1
        {
            height: 91px;
        }
    </style>
    
</asp:Content>
<asp:Content ID="Main" ContentPlaceHolderID="Main" runat="server"> 
      <div><table width="400">
        <tr><td>
            <asp:Label ID="Label1" runat="server" Text="Contact List: " Font-Bold="True"></asp:Label>
        </td></tr>
        <tr>
        <td>
            <asp:ListBox ID="CustomerListBox" runat="server" Height="150px" Width="600px"></asp:ListBox>
        </td>   
        <td>
            <asp:Button ID="Button2" runat="server" Text="Remove Contact" Width="148px" 
                Font-Bold="True" />
            <br />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" Text="Empty List" Width="145px" 
                Font-Bold="True" />
        </td> 
        
        </tr>
       
        
        <tr>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Select Additional Customers" 
                PostBackUrl="~/CustomerDisplay.aspx" Font-Bold="True" />
        </td>
        <td>
          
        </td>
        </tr>
        
        </table>
        </div>

   
</asp:Content>

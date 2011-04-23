<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="SurveyComplete.aspx.vb" Inherits="SurveyComplete" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Survey Complete</title>
   </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
   <div>
    <table>
    <tr><td></td></tr><tr></tr>
    <tr>
    <td>
        <asp:Label ID="lblThanks" runat="server" Text="Thank you for your feedback!"></asp:Label>
    
    </td>
    </tr>
    <tr>
    <td>

        <asp:Label ID="lblWillContact" runat="server" Text="A customer service representative will contact you within 24 hours."></asp:Label>
    
    </td>
    </tr>
    <tr><td></td></tr>
    <tr>   
    <td>    
        <asp:Button ID="btnReturntoSurvey" runat="server" Text="Return To Survey" />
    </td>
    </tr>
    
    </table>
    </div>   
    </asp:Content>


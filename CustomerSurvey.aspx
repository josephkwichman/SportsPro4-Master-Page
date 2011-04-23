<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="CustomerSurvey.aspx.vb" Inherits="CustomerSurvey" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title></title>
    <style type="text/css">
        .style3
        {
            width: 370px;
        }
        .style8
        {
            width: 281px;
        }
        .style9
        {
            height: 25px;
        }
        .style11
        {
            width: 327px;
        }
        .style12
        {
            width: 346px;
        }
        .style13
        {
            width: 195px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
   <div><table style="width: 686px; height: 43px;">
    <tr>
    <td class="style11">     
        <asp:Label ID="Label1" runat="server" Text="Enter your Customer ID:"></asp:Label>
    </td>
    <td class="style12">
        <asp:TextBox ID="txtBx_Cust_ID" runat="server" Height="27px" Width="156px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Get Incidents" 
            style="margin-left: 18px" ValidationGroup="GetIncidents" />
    </td>
    <td>
        &nbsp;</td>
    </tr>
    <tr>
    <td class="style11">
    
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txtBx_Cust_ID" 
            ErrorMessage="Please Enter a Customer ID." 
            ForeColor="Red" ValidationGroup="GetIncidents"></asp:RequiredFieldValidator>
       </td>
       <td class="style12">
        <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ControlToValidate="txtBx_Cust_ID" 
               ErrorMessage="Customer ID must be an integer." ForeColor="Red" 
               Type="Integer" Operator="DataTypeCheck" ValidationGroup="GetIncidents"></asp:CompareValidator>
    
           <br />
    
    <asp:Label ID="lblNoIncidentsFound" runat="server" Text="No Incidents Found. Please Try Again." ForeColor="Red"></asp:Label>
    </td>    
        
    </tr>
    </table>
    <table>
    <tr>
    <td>
        <asp:ListBox ID="ListBox1" runat="server" Width="608px" Height="143px"></asp:ListBox>
    </td>
    
    </tr>
    <tr>
    <td>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ErrorMessage="Please Select an Incident" ValidationGroup="SubmitSurvey" 
            ControlToValidate="ListBox1" ForeColor="Red"></asp:RequiredFieldValidator>
    </td>
        
    </tr>
        </table>
        <table>
        <tr>
        <td class="style3">
            <asp:Label ID="Label2" runat="server" Text="Please rate this incident by the following categories: " Font-Bold="True"></asp:Label>
        </td>
        </tr>
        </table>
        <table style="margin-left: 8px">
        <tr>
        <td class="style13">
            <asp:Label ID="lblRateResponseTime" runat="server" Text="Response Time: "></asp:Label>
       </td>
       <td>
            <asp:RadioButtonList ID="rblResponseTime" runat="server" RepeatColumns="4" RepeatDirection="Horizontal">
           <asp:ListItem Value="1">Not satisfied</asp:ListItem>
           <asp:ListItem Value="2">Somewhat satisfied</asp:ListItem>
           <asp:ListItem Value="3">Satisfied</asp:ListItem> 
           <asp:ListItem Value="4" Selected="True">Completely satisfied</asp:ListItem>                   
            </asp:RadioButtonList>
             </td>
        </tr> 
        <tr>
        <td class="style13">
            <asp:Label ID="lblTechnicianEfficiency" runat="server" Text="Technician Efficiency: "></asp:Label>
       </td>
       <td>
            <asp:RadioButtonList ID="rbrTechnicianEfficiency" runat="server" RepeatColumns="4" RepeatDirection="Horizontal">
           <asp:ListItem Value="1">Not satisfied</asp:ListItem>
           <asp:ListItem Value="2">Somewhat satisfied</asp:ListItem>
           <asp:ListItem Value="3">Satisfied</asp:ListItem> 
           <asp:ListItem Value="4" Selected="True">Completely satisfied</asp:ListItem>                   
            </asp:RadioButtonList>
             </td>
        </tr>  
        <tr>
        <td class="style13">
            <asp:Label ID="lblProblemResolution" runat="server" Text="Problem Resolution: "></asp:Label>
       </td>
       <td>
            <asp:RadioButtonList ID="rbrProblemResolution" runat="server" RepeatColumns="4" RepeatDirection="Horizontal">
           <asp:ListItem Value="1">Not satisfied</asp:ListItem>
           <asp:ListItem Value="2">Somewhat satisfied</asp:ListItem>
           <asp:ListItem Value="3">Satisfied</asp:ListItem> 
           <asp:ListItem Value="4" Selected="True">Completely satisfied</asp:ListItem>                   
            </asp:RadioButtonList>
             </td>
        </tr> 
        </table>
    </div>
    <div>
    </div>
    <div>
    <table>
    <tr>
    <td align="left" valign="top">
        <asp:Label ID="Label6" runat="server" Text="Additional comments:"></asp:Label>
    </td>
    <td>    
    </td>
    <td>
        <asp:TextBox ID="txtComments" runat="server" Height="72px" Width="607px"></asp:TextBox>
    </td>    
    </tr> 
    <tr>
    <td>
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
            DataFile="~/App_Data/TechSupport.mdb" 
            SelectCommand="SELECT [IncidentID], [CustomerID], [ProductCode], [TechID], [DateOpened], [DateClosed], [Title] FROM [Incidents] ORDER BY [DateClosed]"></asp:AccessDataSource>
    </td>
    </tr>
    </table>
    <table>
    <tr>
    <td class="style8">
        <asp:CheckBox ID="CheckBox1" runat="server" 
            Text="Please contact me to discuss this incident" />
    </td>
    </tr>
    <tr>
    
    <td>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="RadioButton13" runat="server" Text="Contact by email" 
            GroupName="ContactGroup" />
    </td>
    </tr>
    <tr>
     <td class="style9">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="RadioButton14" runat="server" Text="Contact by phone" 
             GroupName="ContactGroup" />
    </td>
    </tr> 
    <tr>
    <td>
    </td>
    </tr>
<tr>
<td>
    <asp:Button ID="Button2" runat="server" Text="Submit" 
        ValidationGroup="SubmitSurvey" />
</td>
</tr>

    </table>
    
    </div>
    
</asp:Content>


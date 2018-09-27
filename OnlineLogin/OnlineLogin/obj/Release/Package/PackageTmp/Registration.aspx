<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="OnlineLogin.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Register..</h1>

    <div>
        <asp:Label ID="Label1" runat="server" Text="USER NAME" Font-Bold="true" Width="100"></asp:Label>
    
        <asp:TextBox ID="TxtUName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"  Text="*" ErrorMessage="Please Enter UserName" ForeColor="Red" ControlToValidate="TxtUName" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Username can have only charecters and numerals" ControlToValidate="TxtUName" Font-Bold="False" ValidationExpression="[a-zA-Z0-9]*$" ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator>
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="PASSWORD" Font-Bold="true" Width="100"></asp:Label>
        <asp:TextBox ID="TxtPwd" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Text="*" ForeColor="Red" ErrorMessage="Please Enter Password" ControlToValidate="TxtPwd" Display="Dynamic"></asp:RequiredFieldValidator>
    </div>
    <div>
        <asp:Label ID="Label3" runat="server" Text="CONFIRM PASSWORD" Font-Bold="true" Width="100"></asp:Label>
    
        <asp:TextBox ID="TxtPwd2" runat="server" MaxLength="50" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please Confirm Password" ControlToValidate="TxtPwd2" Display="Dynamic" ForeColor="Red">*</asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Passwords must be same" Text="" ControlToCompare="TxtPwd" Display="Dynamic" ForeColor="Red" ControlToValidate="TxtPwd2"></asp:CompareValidator>
        </div>
        <div>
            <asp:Label ID="Label4" runat="server" Text="EMAIL ID" Font-Bold="true" Width="100"></asp:Label>
    
        <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please Enter Email ID" ControlToValidate="TxtEmail" Display="Dynamic" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Please Enter Valid Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic" ForeColor="Red" ControlToValidate="TxtEmail"></asp:RegularExpressionValidator>
    </div>
    <asp:Label ID="lblMessage" runat="server" Text="" Font-Bold="true" ForeColor="Red"></asp:Label>
    <br />
    <div>
        <asp:Button ID="BtnSub" runat="server" Text="Submit" Font-Bold="true" OnClick="BtnSub_Click" />
        &nbsp;&nbsp;
        <asp:Button ID="BtnReset" runat="server" Text="Reset" Font-Bold="true" OnClick="BtnReset_Click" />
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" CodeBehind="Registration.aspx.cs" Inherits="OnlineLogin.Regristration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>

        .input { border:1px solid #CCC; padding:5px; font-size:14px; font-weight:normal; }
        .button-blue{ background:#0094ff; color:#FFF; border:1px solid #0094ff; padding:7px 20px;}
        .button-white{ background:#f1f1f1; color:#333; border:1px solid #999; padding:7px 20px;}
    </style>
    <h1>Register..</h1>

    <div style="margin-bottom:10px;">
        <asp:Label ID="Label1" runat="server" Text="USER NAME" Font-Bold="true" Width="100"></asp:Label>
    
        <asp:TextBox ID="TxtUName" runat="server" CssClass="input"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"  Text="*" ErrorMessage="Please Enter UserName" ForeColor="Red" ControlToValidate="TxtUName" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Username can have only charecters and numerals" ControlToValidate="TxtUName" Font-Bold="False" ValidationExpression="[a-zA-Z0-9]*$" ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator>
    </div>
    <div style="margin-bottom:10px;">
        <asp:Label ID="Label2" runat="server" Text="PASSWORD" Font-Bold="true" Width="100"></asp:Label>
        <asp:TextBox ID="TxtPwd" runat="server" TextMode="Password" CssClass="input"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Text="*" ForeColor="Red" ErrorMessage="Please Enter Password" ControlToValidate="TxtPwd" Display="Dynamic"></asp:RequiredFieldValidator>
    </div>
    <div style="margin-bottom:10px;">
        <asp:Label ID="Label3" runat="server" Text="CONFIRM PASSWORD" Font-Bold="true" Width="100"></asp:Label>
    
        <asp:TextBox ID="TxtPwd2" runat="server" MaxLength="50" TextMode="Password" CssClass="input"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please Confirm Password" ControlToValidate="TxtPwd2" Display="Dynamic" ForeColor="Red">*</asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Passwords must be same" Text="" ControlToCompare="TxtPwd" Display="Dynamic" ForeColor="Red" ControlToValidate="TxtPwd2"></asp:CompareValidator>
        </div>
        <div style="margin-bottom:10px;">
            <asp:Label ID="Label4" runat="server" Text="EMAIL ID" Font-Bold="true" Width="100"></asp:Label>
    
        <asp:TextBox ID="TxtEmail" runat="server" CssClass="input"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please Enter Email ID" ControlToValidate="TxtEmail" Display="Dynamic" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Please Enter Valid Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic" ForeColor="Red" ControlToValidate="TxtEmail"></asp:RegularExpressionValidator>
    </div> 
    <asp:Label ID="lblMessage" runat="server" Text="" Font-Bold="true" ForeColor="Red"></asp:Label>
    <br />
    <div style="margin-bottom:10px;">
        <asp:Button ID="BtnSub" runat="server" Text="Submit" Font-Bold="true" OnClick="BtnSub_Click" CssClass="button-blue" />
        &nbsp;&nbsp;
        <asp:Button ID="BtnReset" type="reset" runat="server"  Text="Reset" Font-Bold="true" CssClass="button-white"   OnClientClick="this.form.reset();return true" OnClick="BtnReset_Click"/>
    </div>
</asp:Content>

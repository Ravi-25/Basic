<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Master.aspx.cs" Inherits="OnlineLogin.Master1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <style>

        .input { border:1px solid #CCC; padding:5px; font-size:14px; font-weight:normal; }
        .button-blue{ background:#0094ff; color:#FFF; border:1px solid #0094ff; padding:7px 20px;}
        .button-white{ background:#f1f1f1; color:#333; border:1px solid #999; padding:7px 20px;}
    </style>
    <p>
        <br />
    <br />
               <div style="width:350px; margin:30px auto; border:1px solid #CCC; box-shadow:0px 0px 10px #CCC; padding:20px;">
        <table align="center" BORDER="0">
            <tr><td height="40" valign="middle">
                <asp:Label ID="Label1" runat="server" Text="USER NAME" Font-Bold="true"></asp:Label>
                </td>
            <td>
                <asp:TextBox ID="TxtUname" runat="server" Font-Bold="true" MaxLength="30" placeholder="Enter User Name"  CssClass="input"></asp:TextBox>
                </td>
                </tr>
            <tr>
                <td height="40" valign="middle">
                    <asp:Label ID="Label2" runat="server" Text="PASSWORD" Font-Bold="true"></asp:Label>
                    
                &nbsp;&nbsp;&nbsp;
                    
                </td>
                <td>
                    <asp:TextBox ID="TxtPwd" runat="server" Font-Bold="true" Text="" MaxLength="30" TextMode="Password" placeholder="Enter Password" CssClass="input"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td   height="60" valign="middle"><asp:Button ID="BtnSub" runat="server" Text="Sign In" Font-Bold="true" CssClass="button-blue" OnClick="BtnSub_Click" />
                     <asp:Button ID="BtnReset" runat="server" Text="Reset " Font-Bold="true" OnClick="BtnReset_Click" CssClass="button-white" />
                </td>
            </tr>
           
            </table>
                   <asp:Label ID="Lbl" runat="server" Text="" Font-Bold="true" ForeColor="Red"></asp:Label>
            <br />
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Registration.aspx">Register</asp:LinkButton>
        <br />
          </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Authorisation.aspx.cs" Inherits="OnlineLogin.Authorisation1" %>
<%@ MasterType VirtualPath="~/Site.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
            <b><h2>Role Assignment..</h2></b>
            <div style="margin-bottom:10px;">
            <asp:DropDownList ID="DdlUser" runat="server"  Height="30px" Width="125px" AutoPostBack="True" OnSelectedIndexChanged="DdlUser_SelectedIndexChanged">
                </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DdlType" runat="server"   Height="30px" Width="125px" AutoPostBack="True" OnSelectedIndexChanged="DdlType_SelectedIndexChanged">
                </asp:DropDownList>
                </div >
            <br />
            <div style="margin-bottom:10px;">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="LblUName" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="Blue" Width="100"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="LblUtype" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="Blue" Width="100"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="BtnEdit" runat="server" Font-Bold="True" Font-Italic="True" Text="Edit" OnClick="BtnEdit_Click" style="height: 26px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="BtnSave" runat="server" Font-Bold="True" Font-Italic="True" Text="Save" OnClick="BtnSave_Click" />
                &nbsp;&nbsp;&nbsp;
                </div>
            <br />
            
        </div>
</asp:Content>

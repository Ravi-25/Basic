<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DDLDB.aspx.cs" Inherits="DropDownListWebApplication.DDLDB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Hyderabad</asp:ListItem>
                <asp:ListItem Value="1">Mumbai</asp:ListItem>
                <asp:ListItem Value="2">Chennai</asp:ListItem>
                <asp:ListItem Value="3">Banglore</asp:ListItem>
                <asp:ListItem Value="4">Delhi</asp:ListItem>
                <asp:ListItem Value="5">Kolkatta</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <br />
            <asp:DropDownList ID="DropDownList2" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" />
        </div>
    </form>
</body>
</html>

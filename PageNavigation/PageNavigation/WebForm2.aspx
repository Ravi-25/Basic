<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="PageNavigation.WebForm2" %>
<%@ PreviousPageType VirtualPath="~/WebForm1.aspx" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>WEB FORM 2</h1>

            <br /><br /><b>NAME:</b><asp:Label runat="server" Text="" ID="Lbl1"></asp:Label><br />
            <b>Email  Id:</b><asp:Label runat="server" Text="" ID="Lbl2"></asp:Label>
            <br /><br /><br />
            <asp:Button ID="Button1" runat="server" Text="PostBack" /><br /><br />
            <asp:Label ID="Label1" runat="server" Text="" Font-Bold="true"></asp:Label>
            </div>
            </form>
</body>
</html>

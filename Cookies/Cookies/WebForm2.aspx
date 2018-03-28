<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Cookies.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><h1><b>WebForm 2</b></h1>
            <table><tr><td><b>Name:</b></td>
                <td>
                    <asp:Label ID="Label1" runat="server" Font-Bold="True"></asp:Label>
                </td>
                   </tr>
                <tr><td><b>Email:</b></td>
                <td>
                    <asp:Label ID="Label2" runat="server" Font-Bold="True"></asp:Label>
                </td>
                   </tr>
            </table>
        </div>
    </form>
</body>
</html>

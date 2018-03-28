<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Cookies.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><h1><b>WebForm 1</b></h1>
            <table><tr><td><b>Name:</b></td>
                <td>
                    <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
                </td>
                </tr>
                <tr><td><b>Email:</b></td>
                <td>
                    <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
                </td>
                </tr>
            </table>
            <br /> 
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:Button ID="Button1" runat="server" Text="Send Data" Font-Bold="True" OnClick="Button1_Click" />

            <br />
            <asp:Label ID="Label1" runat="server" Font-Bold="True"></asp:Label>
            <br />
            <br />


        </div>
    </form>
</body>
</html>

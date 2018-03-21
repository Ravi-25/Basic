<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegularExp.aspx.cs" Inherits="ValidationControls.RegularExp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Invalid Email ID" ForeColor="Red" ControlToValidate="TextBox1" EnableClientScript="False" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            <br />
            <br />

            <asp:Label ID="lblStatus" runat="server" Font-Bold="true"/>
        </div>
    </form>
</body>
</html>

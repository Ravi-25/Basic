<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TextBox.aspx.cs" Inherits="ControlsWebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" BackColor="#FF3399" BorderStyle="Solid" OnTextChanged="TextBox1_TextChanged" ToolTip="Enter your name">Enter Name</asp:TextBox>
            <br />
            <br />
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Color"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" Width="100px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="height: 26px" Text="Button" />
        </div>
    </form>
</body>
</html>

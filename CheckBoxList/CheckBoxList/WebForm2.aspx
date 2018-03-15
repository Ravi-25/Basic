<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="CheckBoxList.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged" RepeatDirection="Horizontal">
                <asp:ListItem text="Diploma" Value ="1"></asp:ListItem>
                <asp:ListItem text="Graduation" Value ="2"></asp:ListItem>
                <asp:ListItem text="Post Grduation" Value ="3"></asp:ListItem>
                <asp:ListItem text="Doctorial" Value ="4"></asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Height="113px" Width="147px" SelectionMode="Multiple"></asp:ListBox>
            <br />
            <asp:Label ID="Label1" Font-Bold="True" runat="server" Text="0 Item(s) Selected" ForeColor="Red"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>

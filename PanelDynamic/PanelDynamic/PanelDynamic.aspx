<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PanelDynamic.aspx.cs" Inherits="PanelDynamic.PanelDynamic" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" ForeColor="Black" Font-Bold="true" Font-Size="Medium" runat="server" Text="Label">Control Type</asp:Label>
                <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatDirection="Horizontal">
                 <asp:ListItem text="TextBox" Value ="1"></asp:ListItem>
                 <asp:ListItem text="Button" Value ="2"></asp:ListItem>
                 <asp:ListItem text="Label" Value ="3"></asp:ListItem>
                </asp:CheckBoxList>
            <asp:Label ID="Label2" runat="server" Font-Bold="true" Font-Size="Medium" Text="How Many"></asp:Label>
            &nbsp;<asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="37px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Generate Controls" Font-Bold="True" OnClick="Button1_Click"/>
            <br />
            <asp:Label ID="Label3" runat="server" Text="" Font-Bold="True"></asp:Label>
            <table><tr><td id="Td1" runat="server">
            <asp:Panel ID="PnlTxt" runat="server"></asp:Panel>
                </td></tr></table>
            <asp:Label ID="Label4" runat="server" Text="" Font-Bold="True"></asp:Label>
            <table><tr><td id="Td2" runat="server">
            <asp:Panel ID="pnlBtn" runat="server"></asp:Panel>
                </td></tr></table>
            <asp:Label ID="Label5" runat="server" Text="" Font-Bold="True"></asp:Label>
            <table><tr><td id="Td3" runat="server">
            <asp:Panel ID="pnlLbl" runat="server"></asp:Panel>
                </td></tr></table>
        </div>
    </form>
</body>
</html>

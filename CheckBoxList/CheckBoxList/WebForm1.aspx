<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CheckBoxList.WebForm11" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem text="Diploma" Value ="1"></asp:ListItem>
                <asp:ListItem text="Graduation" Value ="2"></asp:ListItem>
                <asp:ListItem text="Post Grduation" Value ="3"></asp:ListItem>
                <asp:ListItem text="Doctorial" Value ="4"></asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Select All" />
&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Deselect All" />
            <br />
        </div>
    </form>
</body>
</html>

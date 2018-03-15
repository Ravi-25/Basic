<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="RadioButton.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem text="Diploma" Value ="1"></asp:ListItem>
                <asp:ListItem text="Graduation" Value ="2"></asp:ListItem>
                <asp:ListItem text="Post Grduation" Value ="3"></asp:ListItem>
                <asp:ListItem text="Doctorial" Value ="4"></asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Cleaar Selection" OnClick="Button2_Click" />
            <br />
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RequiredField validator.aspx.cs" Inherits="ValidationControls.RequiredField_validator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name" Font-Bold="true" Font-Size="Medium"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ForeColor="Red" runat="server" ControlToValidate="textBox1" ErrorMessage="Name Must Be Entered"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Gender" Font-Bold="true" Font-Size="Medium"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Text="Select Any One" Value="-1"></asp:ListItem>
                <asp:ListItem Text="Male" value="1"></asp:ListItem>
                <asp:ListItem Text="Female" value="2"></asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator2" ControlToValidate="DropDownList1" ForeColor="Red" InitialValue="-1" ErrorMessage="Gender Must Be Selected"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" />
        </div>
    </form>
</body>
</html>

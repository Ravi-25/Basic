<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="RegForm.Add1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                      <asp:Label ID="LblFName" runat="server" Text="First Name" Font-Bold="True"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtFName" runat="server" Font-Bold="true" MaxLength="20"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter First Name" ControlToValidate="TxtFname" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Name can have only characters and numbers" ControlToValidate="TxtFName" Font-Bold="True" ForeColor="Red" ValidationExpression="[a-zA-Z0-9 ]*$"></asp:RegularExpressionValidator>
                    </td>
                    </tr>
                <tr>
                    <td>
                      <asp:Label ID="LblLName" runat="server" Text="Last Name" Font-Bold="True"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtLName" runat="server" Font-Bold="true" MaxLength="20"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Last Name" ControlToValidate="TxtLName" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="Name can have only characters and numbers" ControlToValidate="TxtLName" Font-Bold="True" ForeColor="Red" ValidationExpression="[a-zA-Z0-9 ]*$"></asp:RegularExpressionValidator>
                    </td>
                    </tr>
                <tr>
                    <td>
                      <asp:Label ID="LblEmail" runat="server" Text="Email Id" Font-Bold="True"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtEmail" runat="server" Font-Bold="true" MaxLength="50"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter Email-Id" ControlToValidate="TxtEmail" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Enter a valid Email Id" ControlToValidate="TxtEmail" Font-Bold="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="Red"></asp:RegularExpressionValidator>
                    </td>
                    </tr>
                </table>
                  <table>
                      <tr>
                    <td>
                        <asp:Button ID="BtnAdd" runat="server" Text="ADD" Font-Bold="True" OnClick="BtnAdd_Click" style="height: 26px" />
                    </td>
                        <td>
                          <asp:Button ID="BtnSave" runat="server" Text="Save" Font-Bold="True"  style="height: 26px" OnClick="BtnSave_Click" />
                        </td>
                          <td>
                              <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/DataGrid.aspx" Font-Bold="True" OnUnload="Unload">Back</asp:HyperLink>
                    </td>
                      </tr>
                      </table>
                     <br />
                          
                            <asp:Label ID="Lbl" runat="server" Text="" Font-Bold="True"></asp:Label>
                          
                                         
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Compare.aspx.cs" Inherits="ValidationControls.Compare" %>

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
            <b>Password</b>
        </td>
        <td>
            &nbsp;&nbsp;&nbsp;&nbsp;
            :<asp:TextBox ID="txtPassword" runat="server" Width="150px" TextMode="Password"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <strong>Retype Password</strong></td>
        <td>
            :&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtRetypePassword" runat="server" 
                Width="150px" TextMode="Password"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidatorPassword" runat="server"
            ErrorMessage="Password and Retype Password must match"
            ControlToValidate="txtRetypePassword" ControlToCompare="txtPassword"
            Type="String" Operator="Equal" ForeColor="Red" SetFocusOnError="True"></asp:CompareValidator>
        </td>
    </tr>
</table>
 <b>Date Of Application:</b> <asp:TextBox ID="txtDateofapplication" runat="server" Width="150px">
</asp:TextBox>
<asp:CompareValidator ID="CompareValidatorDateofbirth" runat="server" 
ErrorMessage="Date of application must be greater than 01/01/2012"
ControlToValidate="txtDateofapplication" ValueToCompare="01/01/2012"
Type="Date" Operator="GreaterThan" ForeColor="Red"
SetFocusOnError="true"></asp:CompareValidator><br />
<b>AGE:</b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtAge" runat="server" Width="150px"></asp:TextBox>
<asp:CompareValidator ID="CompareValidatorAge" runat="server" 
ErrorMessage="Age must be a number" ControlToValidate="txtAge" 
Operator="DataTypeCheck" Type="Integer" ForeColor="Red"
SetFocusOnError="true"></asp:CompareValidator> <br /><br />
<asp:Button ID="btnSave" runat="server" Text="Save" Width="100px" 
                onclick="btnSave_Click" Font-Bold="True" />
            <br />
             <asp:Label ID="lblStatus" runat="server" Font-Bold="true"/>
</div>
    </form>
</body>
</html>

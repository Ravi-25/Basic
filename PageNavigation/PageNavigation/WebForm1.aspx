<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PageNavigation.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function OpenNewWindow()
        {
        var Name = document.getElementById('TxtNm').value;
        var Email = document.getElementById('TxtEmail').value;
        window.open('WebForm2.aspx?NameOfUser=' + Name + '&Email=' + Email, '_self', 'location=no,resizable=no', true);
        }
       </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>WEB FORM 1</h1>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/webform2.aspx">Go To Web Form 2</asp:HyperLink><br />
            <br />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Response.Redirect" Font-Bold="true" OnClick="Button1_Click" />

            <br />
            <br />
            <b>Name:&nbsp;&nbsp;&nbsp; </b><asp:TextBox runat="server" ID="TxtNm"></asp:TextBox><br /><br />
            <b>Email Id:</b><asp:TextBox runat="server" ID="TxtEmail"></asp:TextBox><br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="" Font-Bold="true"></asp:Label>
            <br />
&nbsp; <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Server.Transfer" Font-Bold="true" Width="144px" OnClick="Button2_Click" />
            <br />
            <br />
&nbsp;<asp:Button ID="Button3" runat="server" Text="Server.Transfer External" Font-Bold="true" Width="184px" OnClick="Button3_Click" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" Font-Bold="True" OnClick="Button4_Click" Text="Server.Execute" />
            <br />
            <br />
            <asp:Button ID="Button5" runat="server" Text="Server.Execute External" Font-Bold="true" Width="184px" OnClick="Button5_Click" />
            <br />
            <br />
            <asp:Button ID="Button6" runat="server" Text="Cross Page Post Bacck" Font-Bold="true" PostBackUrl="~/WebForm2.aspx" />
            <br />
            <br />
            <input id="Button7" type="button" value="HTML Btn" onclick="OpenNewWindow()"/>

    </form>
</body>
</html>

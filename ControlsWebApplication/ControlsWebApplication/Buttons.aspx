<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Buttons.aspx.cs" Inherits="ControlsWebApplication.Button" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" 
                OnClientClick= "return Confirm('Are you sure Do You Want to submit the page')" 
                OnClick="Button1_Click" />
            <br />
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClientClick="alert('Page is submitting')" OnClick="LinkButton1_Click">Submit</asp:LinkButton>
            <br />
            <br />
            <asp:ImageButton ID="ImageButton1" runat="server" Height="30px" ImageUrl="~/download.jpg" Width="100px" 
                OnClientClick= "return Confirm('Are you sure Do You Want to submit the page')" 
                OnClick="ImageButton1_Click" />
            
        </div>
    </form>
</body>
</html>

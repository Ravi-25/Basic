<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CommandEvents.aspx.cs" Inherits="ButtonEventsWebApplication.CommandEvents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>  <asp:Button ID="Button1" runat="server" Text="Print" CommandName="Print" OnCommand="Button1_Command"/>                
               <asp:Button ID="Button2" runat="server" Text="Delete" CommandName="Delete" OnCommand="Button1_Command" />  
               <asp:Button ID="Button3" runat="server" Text="Show Top 10" CommandName="Show" CommandArgument="Top10" OnCommand="Button1_Command"/>
               <asp:Button ID="Button4" runat="server" Text="show Bottom 10"  CommandName="Show" CommandArgument="Bottom10" OnCommand="Button1_Command"/>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
    
</body>
</html>

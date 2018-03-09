<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckBox.aspx.cs" Inherits="ControlsWebApplication.CheckBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <br />
            <fieldset>
                <legend>Check which ever is Done</legend>
                <asp:CheckBox ID="CheckBox1" runat="server" text="Gradute"/>
                <asp:CheckBox ID="CheckBox2" runat="server" text="Post Graduation"/>
                <asp:CheckBox ID="CheckBox3" runat="server" text="Doctorate"/><br /><br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            </fieldset>
            <br />
            <br />

        </div>
    </form>
</body>
</html>

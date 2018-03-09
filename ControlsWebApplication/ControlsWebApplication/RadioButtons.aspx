<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RadioButtons.aspx.cs" Inherits="ControlsWebApplication.RadioButtons" %>

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
                <legend>Choose a Colour</legend>
                <asp:RadioButton ID="RadioButton1" runat="server" Text="Red" BackColor="#CC0000" GroupName="Colour"/>
                <asp:RadioButton ID="RadioButton2" runat="server" Text="Yellow" BackColor="Yellow" GroupName="Colour"/>
                <asp:RadioButton ID="RadioButton3" runat="server" Text ="Green" BackColor="Lime" GroupName="Colour"/>
                <asp:RadioButton ID="RadioButton4" runat="server" Text="Blue" BackColor="#3366FF" GroupName="Colour"/>
            </fieldset>
            <br />
            <br />
            <fieldset><legend>Sex</legend>
                <asp:RadioButton ID="RadioButton5" runat="server" Text="Male" GroupName="Sex" TextAlign="Left" />
                <asp:RadioButton ID="RadioButton6" runat="server" Text="Female" GroupName="Sex" TextAlign="Left" />
            </fieldset>
            <br />
        </div>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrystalReportDemoaspx.aspx.cs" Inherits="RegForm.CrystalReportDemoaspx1" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" />
            <asp:Button ID="Button1" runat="server" Text="Make It PDF" Font-Bold="True" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomValidator.aspx.cs" Inherits="ValidationControls.CustomValidator1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <script language="javascript" type="text/javascript">
         // Client side validation function to check if the number is even. 
         function IsEven(source, args) {
             if (args.Value == "") {
                 args.IsValid = false;
             }
             else {
                 if (args.Value % 2 == 0) {
                     args.IsValid = true;
                 }
                 else {
                     args.IsValid = false;
                 }
             }
         }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div><b>Enter a Number:</b>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            <asp:CustomValidator ID="CustomValidator2" runat="server" ErrorMessage="Enter A  Even Number" ForeColor="Red" OnServerValidate="CustomValidatorEvenNumber_ServerValidate" ClientValidationFunction="IsEven" ControlToValidate="TextBox1" EnableClientScript="False"></asp:CustomValidator><br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" /><br />
            <asp:Label ID="LblStatus" runat="server" Text="" Font-Bold="true"></asp:Label>
        </div>
    </form>
</body>
</html>

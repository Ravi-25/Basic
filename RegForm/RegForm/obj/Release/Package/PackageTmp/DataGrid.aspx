<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataGrid.aspx.cs" Inherits="RegForm.DataGrid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" language="javascript">
        var checked = false;
        function MyRadioButton_CheckedChanged() {
           // ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "MyRadioButton_CheckedChanged()", true);
            //alert('Hello!');
            checked = true;
        }
        function BtnDel_Click() {
            if (!checked) {
                alert('Please select a Row to Delete !!');
                //var x = document.getElementById("Lbl"); 
                //x.Text = "Please select a Row to Delete";
                //document.getElementById("<%=Lbl.ClientID %>").textContent = "Please select a Row to Delete";
                return true;
            }
            else {
                return confirm('Are you sure you want to Delete the Row ?');
            }
        }
        function BtnEdit_Click() {
            if (!checked) {
                alert('Please select a Row to Edit !!');
                return true;
            }
            else {
                return true;
            }

        }
</script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="PersonGrid" runat="server" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Email" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" style="margin-top: 11px" Width="187px" OnSorting="PersonGrid_Sorting" >
                <Columns>
                    <asp:TemplateField HeaderText="Select One">
                                <ItemTemplate>
                  <asp:RadioButton ID="MyRadioButton" runat="server" value='<%# Eval("Email") %>' AutoPostBack="true"  OnCheckedChanged="MyRadioButton_CheckedChanged" CausesValidation="True" />
                                                            </ItemTemplate>
                                </asp:TemplateField>
                    <asp:BoundField DataField="FirstName" HeaderText="First Name" SortExpression="FirstName" />
                    <asp:BoundField DataField="LastName" HeaderText="Last Name" SortExpression="LastName" />
                    <asp:BoundField DataField="Email" HeaderText="Email Id" ReadOnly="True" SortExpression="Email"/>
                </Columns>
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                
            </asp:GridView>
            
            <br />
            <table>
                <tr>

                    <td>
                      <asp:Button ID="BtnAdd" runat="server" Text="Add" Font-Bold="true" Visible="true" OnClick="BtnAdd_Click" />
                    </td>

                <td>
                   <asp:Button ID="BtnEdit" runat="server" Text="Edit" Font-Bold="true" OnClick="BtnEdit_Click" OnClientClick="BtnEdit_Click();" /> 
                </td>

                <td>
                   <asp:Button ID="BtnDel" runat="server" Text="Delete" Font-Bold="true" OnClick="BtnDel_Click" OnClientClick="javascript:return BtnDel_Click();" /> 
                </td>

              </tr>
                </table>
                <br />
                        <asp:Label ID="Lbl" runat="server" Text="" Font-Bold="true"></asp:Label>
        </div>
    </form>
</body>
</html>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeptManagement.aspx.cs" Inherits="EntityFramework_Part_1.WebForm1" %>

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
                    <td>Dept ID</td>
                    <td>
                        <asp:TextBox ID="txtDeptId" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" /></td>
                </tr>
                <tr>
                    <td>Dept Name</td>
                    <td><asp:TextBox ID="txtDepName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>HOD</td>
                    <td><asp:TextBox ID="txtHod" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>IsActive</td>
                    <td><asp:CheckBox ID="cbIsActive" runat="server" /></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
                        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click"  />
                    </td>
                </tr>
            </table>
        </div>
        <div>
            <asp:GridView ID="GridDept" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <EditRowStyle BackColor="#999999" />
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
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Practical_9.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form runat="server">
        <h1>Placement</h1>

        <hr />

        <h3>Placement Summary</h3>

        <table border="1">
            <tr>
                <td>Total Students</td>
                <td>
                    <asp:Label ID="TotalStudents" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Placed Students</td>
                <td>
                    <asp:Label ID="PlacedStudents" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Unplaced Students</td>
                <td>
                    <asp:Label ID="UnplacedStudents" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Placement percentage</td>
                <td>
                    <asp:Label ID="PlacementPercentageStudents" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Highest Package</td>
                <td>
                    <asp:Label ID="HighestPkg" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>

        <hr />

        <h3>Placement Details</h3>

        <asp:GridView ID="StudentGrid" runat="server" AutoGenerateColumns="true">
        </asp:GridView>

        <hr />

        <asp:HyperLink runat="server" NavigateUrl="~/Company.aspx" Text="Company Details" />
    </form>
</body>
</html>

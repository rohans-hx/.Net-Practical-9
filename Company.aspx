<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Company.aspx.cs" Inherits="Practical_9.Company" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Company Details</h1>

        <hr />

        <h3>Company Summary</h3>
        <asp:GridView ID="gvCompanySummary" runat="server" />

        <hr />

        <h3>Placed Student Details</h3>
        <asp:GridView ID="gvPlacedStudentDetails" runat="server" />

        <hr />

         <asp:HyperLink runat="server" NavigateUrl="~/default.aspx" Text="Back to Dashboard" />
    </form>
</body>
</html>

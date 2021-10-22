<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployForm.aspx.cs" Inherits="EmploySite.EmployForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
        <asp:GridView ID="gvEmps" runat="server" AutoGenerateSelectButton="true" OnSelectedIndexChanged="gvEmps_SelectedIndexChanged"></asp:GridView><p/>
        ID<asp:TextBox ID="txtID" runat="server"></asp:TextBox><br />
        Name<asp:TextBox ID="txtName" runat="server"></asp:TextBox><br />
        Address<asp:TextBox ID="txtAddress" runat="server"></asp:TextBox><br />
        Salary<asp:TextBox ID="txtSalary" runat="server"></asp:TextBox><br />
        Age<asp:TextBox ID="txtAge" runat="server"></asp:TextBox><br /><p />
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click"  />
        <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClientClick="return confirm('ARE YOU SURE?');" OnClick="btnDelete_Click"  />
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="empID" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" style="z-index: 1; left: 503px; top: 72px; position: absolute; height: 152px; width: 232px">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="empID" HeaderText="empID" InsertVisible="False" ReadOnly="True" SortExpression="empID" />
                    <asp:BoundField DataField="empName" HeaderText="empName" SortExpression="empName" />
                    <asp:BoundField DataField="DateOfJoining" HeaderText="DateOfJoining" SortExpression="DateOfJoining" />
                    <asp:BoundField DataField="DeptID" HeaderText="DeptID" SortExpression="DeptID" />
                    <asp:BoundField DataField="Salary" HeaderText="Salary" SortExpression="Salary" />
                    <asp:BoundField DataField="WorkingPlace" HeaderText="WorkingPlace" SortExpression="WorkingPlace" />
                    <asp:BoundField DataField="ContactDetails" HeaderText="ContactDetails" SortExpression="ContactDetails" />
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:FullStackConnectionString %>" ProviderName="<%$ ConnectionStrings:FullStackConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [FullStackEmpDetails]"></asp:SqlDataSource>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 313px; top: 115px; position: absolute; height: 63px" Text="Hide" />
    </form>
</body>
</html>

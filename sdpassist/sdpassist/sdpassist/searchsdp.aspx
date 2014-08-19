<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="searchsdp.aspx.cs" Inherits="sdpassist.searchsdp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div id="content">
        <form id="form1" runat="server">
            <h3>Search for SDP</h3>
            <asp:Label ID="lblsdpname" runat="server" Text="SDP Name"></asp:Label>
            <asp:TextBox ID="txtsdpname" runat="server"></asp:TextBox>
            <asp:Label ID="lblsdptam" runat="server" Text="TAM Alias"></asp:Label>
            <asp:TextBox ID="txtsdptam" runat="server"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
            <asp:GridView ID="grdsdpsearch" runat="server"
                AutoGenerateColumns="false" PageSize="10" >
                <Columns>
                    <asp:BoundField ItemStyle-Width="150px"
                        DataField="Name" HeaderText="SDP Name" />
                    <asp:BoundField ItemStyle-Width="150px"
                        DataField="Tam" HeaderText="Tam Alias" />
                </Columns>
            </asp:GridView>
        </form>
    </div>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Destination.aspx.cs" Inherits="Destination" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:ListBox ID="ListBox1" runat="server">
                <asp:ListItem Value="NY">NewYork</asp:ListItem>
                <asp:ListItem Value="BOS">Boston</asp:ListItem>
                <asp:ListItem Value="Pitts">Pittsburgh</asp:ListItem>
            </asp:ListBox>

            <br />
            <asp:Button ID="btnViewItin" runat="server" OnClick="btnViewItin_Click" Text="View Itinerary" />

        </div>
    </form>
</body>
</html>

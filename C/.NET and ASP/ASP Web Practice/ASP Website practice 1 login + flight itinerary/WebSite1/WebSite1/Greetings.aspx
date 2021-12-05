<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Greetings.aspx.cs" Inherits="Greetings" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <asp:Label ID="lblHello" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True">
               
            </asp:ListBox>
            <br />
            <br />
            <asp:Button ID="btnSelect" runat="server" OnClick="btnSelect_Click" Text="Select City" />
        </div>
    </form>
</body>
</html>

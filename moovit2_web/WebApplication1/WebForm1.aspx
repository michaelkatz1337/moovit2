<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />
            <asp:Button ID="Add_btn" runat="server" Text="Add Passanger" OnClick="Add_btn_Click" />
            <asp:Button ID="Remove_btn" runat="server" Text="Remove Passanger" OnClick="Remove_btn_Click" />
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ZeroOne._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBoxUser" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBoxPass" runat="server"></asp:TextBox>
            <asp:Button ID="ButtonLogin" runat="server" Text="Login" OnClick="ButtonLogin_Click" />
        </div>
    </form>
</body>
</html>

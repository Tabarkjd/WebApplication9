<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Session.aspx.cs" Inherits="WebApplication9.Session" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            job<br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="set session" />
        </div>
    </form>
</body>
</html>

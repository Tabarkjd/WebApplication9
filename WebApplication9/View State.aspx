<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View State.aspx.cs" Inherits="WebApplication9.View_State" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            First name :<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            last name :<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Height="30px" OnClick="Button1_Click" Text="   sit   " />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="  get  " />
            <br />
        </div>
    </form>
</body>
</html>

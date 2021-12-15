<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="lend.aspx.cs" Inherits="Library_management.lend" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Lend&nbsp; the book:
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" style="margin-left: 77px" Width="175px">
                <asp:ListItem>Lend</asp:ListItem>
                <asp:ListItem>Return</asp:ListItem>
            </asp:RadioButtonList>
            Borrower Name:&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            Book name:&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Submit" />
            <br />
&nbsp;&nbsp;
        </div>
    </form>
</body>
</html>

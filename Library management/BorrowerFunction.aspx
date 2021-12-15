<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BorrowerFunction.aspx.cs" Inherits="Library_management.BorrowerFunction" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Borrower Function<br />
            Function Related to :&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem>Reservation</asp:ListItem>
                <asp:ListItem>Lend</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Next" />
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Loginpage.aspx.cs" Inherits="Library_management.Loginpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            Email:&nbsp;&nbsp; <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="*Enter the valid expression" ValidationExpression=".*@.*\.*"></asp:RegularExpressionValidator>
            <br />
            <br />
            Password: 
  Password: 
            <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox3" ErrorMessage=" * Enter the Password"></asp:RequiredFieldValidator>
            <br />
            <br />
            Branch:
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Librarian</asp:ListItem>
                <asp:ListItem>Borrower</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;
            &nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" PostBackUrl="~/maintanance.aspx" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>

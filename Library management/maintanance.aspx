<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="maintanance.aspx.cs" Inherits="Library_management.maintanance" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            Maintenance:<br />
            Function Related to :&nbsp; 
            
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="To title" OnClick="Button1_Click" PostBackUrl="~/Title.aspx" />
            
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="To Stock" OnClick="Button1_Click" PostBackUrl="~/Item.aspx" />
            
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Text="To Borrower" OnClick="Button1_Click" PostBackUrl="~/Borrower.aspx" />
            
        </div>
    </form>
</body>
</html>

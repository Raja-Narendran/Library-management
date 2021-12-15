<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Library_management._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-4">
            <p>
                &nbsp;</p>
            <p>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Name :
                <asp:TextBox ID="TextBox1" runat="server" Width="121px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage=" *Enter the Name"></asp:RequiredFieldValidator>
            </p>
            <p>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; E-mail :<asp:TextBox ID="TextBox2" runat="server" Width="121px"></asp:TextBox>
&nbsp;
                <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="* Enter the valid Email address"></asp:CustomValidator>
            </p>
            <p>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Password :<asp:TextBox ID="TextBox3" runat="server" Width="121px"></asp:TextBox>
            </p>
            <p>
                &nbsp; Confirm Password :<asp:TextBox ID="TextBox4" runat="server" Width="121px"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox3" ControlToValidate="TextBox4" ErrorMessage="password incorrect"></asp:CompareValidator>
            </p>
        </div>
        <div class="col-md-4">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input id="Button1" type="button" value="Submit" />
        </div>
    </div>

</asp:Content>

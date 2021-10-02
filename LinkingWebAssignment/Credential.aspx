<%@ Page Title="" Language="C#" MasterPageFile="~/Quora.Master" AutoEventWireup="true" CodeBehind="Credential.aspx.cs" Inherits="LinkingWebAssignment.Credential" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style8 {
        width: 69%;
        height: 404px;
    }
    .auto-style9 {
        text-align: center;
    }
    .auto-style10 {
        text-align: center;
        font-size: xx-large;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel3" runat="server" Height="800px">
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;
    <table align="center" class="auto-style8">
        <tr>
            <td class="auto-style10" colspan="2"><strong>YOU ARE&nbsp; NOT AUTHENTICATED .
                <br />
                <br />
                LOGIN OR GET REGISTERED . CLICKING THE DOWN LINK</strong></td>
        </tr>
        <tr>
            <td class="auto-style9">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" BackColor="#AC3A37" Font-Size="XX-Large" ForeColor="White" Height="65px" Text="Login" Width="340px" OnClick="Button1_Click" />
            </td>
            <td class="auto-style9">
                <asp:Button ID="Button2" runat="server" BackColor="#AC3A37" Font-Size="XX-Large" ForeColor="White" Height="65px" Text="Signup" Width="340px" OnClick="Button2_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
        </tr>
    </table>
</asp:Panel>
</asp:Content>

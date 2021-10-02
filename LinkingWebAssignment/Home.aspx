<%@ Page Title="" Language="C#" MasterPageFile="~/Quora.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LinkingWebAssignment.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style9 {
            width: 51%;
            height: 436px;
            border: 2px solid #AC3A37;
            margin-top: 132px;
        }
        .auto-style10 {
            height: 167px;
        }
        .auto-style11 {
            width: 364px;
        }
        .auto-style13 {
            font-size: xx-large;
        }
        .auto-style14 {
            width: 481px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="800px">
        <asp:Panel ID="Panel2" runat="server" Height="800px">
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" CssClass="auto-style13" Text="Welcome to Quora :)" Font-Bold="True"></asp:Label>
            <table align="center" class="auto-style9">
                <tr>
                    <td class="auto-style11">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style13">&nbsp; NAME</span></td>
                    <td class="auto-style14">
                        <asp:TextBox ID="txtUsername" runat="server" Font-Overline="False" Font-Size="X-Large" Height="32px" Width="367px" AutoPostBack="True" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style13">&nbsp;PASSWORD</span></td>
                    <td class="auto-style14">
                        <asp:TextBox ID="txtPassword" runat="server" Font-Size="X-Large" Height="32px" Width="367px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnLogin" runat="server" Font-Size="X-Large" Height="54px"  Text="Login" Width="143px" OnClick="btnLogin_Click" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button1" runat="server" Font-Size="X-Large" Height="54px" Text="Signin" Width="143px" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
    </asp:Panel>
</asp:Content>

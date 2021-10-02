<%@ Page Title="" Language="C#" MasterPageFile="~/Quora.Master" AutoEventWireup="true" CodeBehind="Finish.aspx.cs" Inherits="LinkingWebAssignment.Finish" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style8 {
            width: 69%;
            height: 362px;
        }
        .auto-style9 {
            text-align: center;
        }
        .auto-style10 {
            text-align: center;
            font-size: xx-large;
        }
        .auto-style11 {
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
        <table align="center" class="auto-style8">
            <tr>
                <td class="auto-style10"><strong>RESULT</strong></td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label1" runat="server" CssClass="auto-style11" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>

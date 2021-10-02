<%@ Page Title="" Language="C#" MasterPageFile="~/Quora.Master" AutoEventWireup="true" CodeBehind="adoQuize.aspx.cs" Inherits="LinkingWebAssignment.adoQuize" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style10 {
            width: 64%;
            height: 517px;
            margin-left: 363px;
        }
        .auto-style12 {
            height: 225px;
            text-align: center;
        }
        .auto-style14 {
            height: 160px;
            width: 477px;
            text-align: center;
        }
        .auto-style13 {
            height: 160px;
            text-align: center;
        }
        .auto-style17 {
            height: 167px;
            width: 477px;
            text-align: center;
        }
        .auto-style18 {
            height: 167px;
            text-align: center;
        }
        .auto-style21 {
            height: 23px;
            width: 477px;
            text-align: center;
        }
        .auto-style22 {
            height: 23px;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel3" runat="server" Height="800px">
        <br />
        <br />
        &nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <table align="center" class="auto-style10">
            <tr>
                <td class="auto-style12" colspan="2">
                    <asp:Label ID="h1question" runat="server" Font-Size="XX-Large" Text="Questions"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style14">
                    <asp:CheckBox ID="ans1" runat="server" Text=" " />
                </td>
                <td class="auto-style13">
                    <asp:CheckBox ID="ans2" runat="server" Text=" " />
                </td>
            </tr>
            <tr>
                <td class="auto-style21">
                    <asp:CheckBox ID="ans3" runat="server" Text=" " />
                </td>
                <td class="auto-style22">
                    <asp:CheckBox ID="ans4" runat="server" Text=" " />
                </td>
            </tr>
            <tr>
                <td class="auto-style17">
                    <asp:Button ID="btn_next" runat="server" Text="Next" OnClick="btn_next_Click" />
                </td>
                <td class="auto-style18">
                    <asp:Button ID="btn_check" runat="server" OnClick="btn_check_Click" Text="Check" />
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>

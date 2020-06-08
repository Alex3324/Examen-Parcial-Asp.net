<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReporteWeb.aspx.cs" Inherits="WebApplication1.ReporteWeb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%;">
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="height: 20px">
            <asp:Button ID="Button1" runat="server" Text="Ver Reporte" />
        </td>
        <td style="height: 20px">
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </td>
        <td style="height: 20px"></td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>

<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <p>
        <table style="width:100%;">
            <tr>
                <td style="width: 114px">&nbsp;</td>
                <td class="modal-sm" style="width: 169px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 114px">
                    <asp:DropDownList ID="ddlDepartamento" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
                </td>
                <td class="modal-sm" style="width: 169px">
                    <asp:TextBox ID="txtMilimetros" runat="server"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtMilimetros" ErrorMessage="Debe ingresar una medición"></asp:RequiredFieldValidator>
                    <br />
                </td>
                <td>
                    <asp:Button ID="btnIngresar" runat="server" OnClick="Button1_Click" style="margin-left: 0" Text="Guardar" />
                </td>
            </tr>
            <tr>
                <td style="width: 114px; height: 19px;"></td>
                <td class="modal-sm" style="width: 169px; height: 19px;">&nbsp;</td>
                <td style="height: 19px"></td>
            </tr>
            <tr>
                <td style="width: 114px">&nbsp;</td>
                <td class="modal-sm" style="width: 169px">
                    <asp:Button ID="btnMostrar" runat="server" OnClick="btnMostrar_Click" Text="Mostrar Reporte" />
                </td>
                <td>
                    <asp:GridView ID="grvReporte" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
                        <AlternatingRowStyle BackColor="PaleGoldenrod" />
                        <FooterStyle BackColor="Tan" />
                        <HeaderStyle BackColor="Tan" Font-Bold="True" />
                        <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                        <SortedAscendingCellStyle BackColor="#FAFAE7" />
                        <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                        <SortedDescendingCellStyle BackColor="#E1DB9C" />
                        <SortedDescendingHeaderStyle BackColor="#C2A47B" />
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td style="width: 114px">&nbsp;</td>
                <td class="modal-sm" style="width: 169px">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Promedio de Lluvias" />
                </td>
                <td>
                    <asp:Label ID="lblPromedio" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </p>

</asp:Content>

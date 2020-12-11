<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="RegistrarMatricula.aspx.cs" Inherits="SitioColegioWEB_GUI.Transacciones.RegistrarMatricula" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 80%;
        }
        .auto-style2 {
            height: 22px;
        }
        .auto-style3 {
            width: 186px;
        }
        .auto-style4 {
            height: 22px;
            width: 186px;
        }
        .auto-style5 {
            width: 261px;
        }
        .auto-style6 {
            height: 22px;
            width: 261px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        REGISTRAR MATRICULA</p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">Alumno:</td>
            <td class="auto-style5">
                <asp:DropDownList ID="DropDownList5" runat="server" Height="23px" Width="249px">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Seleccione Periodo:</td>
            <td class="auto-style5">
                <asp:DropDownList ID="DropDownList1" runat="server" Height="17px" Width="225px">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Cantidad de Cursos:</td>
            <td class="auto-style5">
                <asp:DropDownList ID="DropDownList4" runat="server" Height="16px" Width="74px">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Seleccione Grado:</td>
            <td class="auto-style5">
                <asp:DropDownList ID="DropDownList2" runat="server" Height="16px" Width="114px">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Seleccione Cursos:</td>
            <td class="auto-style5">
                <asp:DropDownList ID="DropDownList3" runat="server" Height="16px" Width="140px">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Button ID="Button1" runat="server" Text="Elegir profesor" />
            </td>
            <td class="auto-style5">
                <asp:Button ID="Button2" runat="server" Text="Grabar" />
            </td>
            <td>
                <asp:Button ID="Button3" runat="server" Text="Cancelar" />
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <br />
                <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" Width="742px">
                    <FooterStyle BackColor="White" ForeColor="#333333" />
                    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#487575" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#275353" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:HyperLink ID="HyperLink1" runat="server">Menu</asp:HyperLink>
            </td>
            <td class="auto-style6"></td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>

    <asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>





</asp:Content>

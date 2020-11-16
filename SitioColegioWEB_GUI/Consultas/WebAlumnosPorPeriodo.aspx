<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="WebAlumnosPorPeriodo.aspx.cs" Inherits="SitioColegioWEB_GUI.Consultas.WebAlumnosPorPeriodo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 80%;
        }
        .auto-style2 {
            width: 205px;
        }
        .auto-style4 {
            height: 22px;
        }
        .auto-style6 {
            height: 24px;
        }
        .auto-style7 {
            height: 24px;
            width: 201px;
        }
        .auto-style10 {
            width: 205px;
            height: 22px;
        }
        .auto-style12 {
            width: 201px;
            height: 22px;
        }
        .auto-style13 {
            width: 201px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="labelTitulo">
        CONSULTA DE ALUMNOS POR PERIODO</p>
    <table class="auto-style1">
        <tr>
            <td class="labelContenido">Seleccione el Periodo</td>
            <td class="auto-style7">
                <asp:DropDownList ID="cboPeriodo" runat="server" CssClass="DropDownList" Width="160px">
                </asp:DropDownList>
            </td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td class="labelContenido">&nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style4">
                <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" Text="Consultar" />
            </td>
        </tr>
        <tr>
            <td class="auto-style10">
                <asp:Label ID="lblMensaje" runat="server" CssClass="labelErrores"></asp:Label>
            </td>
            <td class="auto-style12"></td>
            <td class="auto-style4">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:GridView ID="grvAlumnos" runat="server" Width="550px">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style13">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

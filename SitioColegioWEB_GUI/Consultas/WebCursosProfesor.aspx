<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="WebCursosProfesor.aspx.cs" Inherits="SitioColegioWEB_GUI.Consultas.WebCursosProfesor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="labelTitulo">
        CONSULTA DE CURSOS POR PROFESOR</p>
    <table class="auto-style1">
        <tr>
            <td class="labelContenido">Seleccione un profesor</td>
            <td class="auto-style7">
                <asp:DropDownList ID="cboProfesor" runat="server" CssClass="DropDownList" Width="250px">
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
                <asp:GridView ID="grvCursos" runat="server" Width="550px" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="IDCURSO" HeaderText="Id Curso" />
                        <asp:BoundField DataField="NOMBRECURSO" HeaderText="Nombre" />
                        <asp:BoundField DataField="DESCRIPCION" HeaderText="Descripcion" />
                        <asp:BoundField DataField="HORAS_SEMANALES" HeaderText="Horas Semanales" />
                    </Columns>
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

<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="WebNotasAlumnos.aspx.cs" Inherits="SitioColegioWEB_GUI.Consultas.WebNotasAlumnos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 80%;
        }
        .auto-style2 {
            width: 278px;
        }
        .auto-style3 {
            width: 236px;
        }
        .auto-style4 {
            height: 131px;
        }
        .auto-style5 {
            width: 278px;
            height: 26px;
        }
        .auto-style6 {
            width: 236px;
            height: 26px;
        }
        .auto-style7 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        CONSULTA PARA VER NOTAS DE CADA ALUMNO</p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">Seleccione Alumno:</td>
            <td class="auto-style3">
                <asp:DropDownList ID="cboAlumno" runat="server" Width="200px">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Seleccione Periodo:</td>
            <td class="auto-style3">
                <asp:DropDownList ID="cboPeriodo" runat="server" Width="150px">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">Seleccione Curso:</td>
            <td class="auto-style6">
                <asp:DropDownList ID="cboCurso" runat="server" Width="150px">
                </asp:DropDownList>
            </td>
            <td class="auto-style7"></td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>
                <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            </td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4" colspan="3">
                <asp:GridView ID="grvNotas" runat="server" Width="500px" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="IDALUMNO" HeaderText="IdAlumno" />
                        <asp:BoundField DataField="NOMBRECURSO" HeaderText="Curso" />
                        <asp:BoundField DataField="NOTA" HeaderText="Nota" />
                        <asp:BoundField DataField="FECHA" HeaderText="Fecha" />
                    </Columns>
                    <FooterStyle BackColor="#CCCC99" />
                    <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                    <RowStyle BackColor="#F7F7DE" />
                    <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FBFBF2" />
                    <SortedAscendingHeaderStyle BackColor="#848384" />
                    <SortedDescendingCellStyle BackColor="#EAEAD3" />
                    <SortedDescendingHeaderStyle BackColor="#575357" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="WebPromedioNotasSalon.aspx.cs" Inherits="SitioColegioWEB_GUI.Consultas.WebPromedioNotasSalon" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 80%;
        }
        .auto-style2 {
            width: 218px;
        }
        .auto-style3 {
            width: 290px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        CONSULTA DE PROMEDIO DE NOTAS DE CADA SALON</p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">Seleccione Salon:</td>
            <td class="auto-style3">
                <asp:DropDownList ID="cboSalon" runat="server" Width="100px">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
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
            <td colspan="3">
                <asp:GridView ID="grvNotas" runat="server" Width="450px" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="Salon" HeaderText="Salon" />
                        <asp:BoundField DataField="Periodo" HeaderText="Periodo" />
                        <asp:BoundField DataField="ARTE" HeaderText="Arte" />
                        <asp:BoundField DataField="BIOLOGIA" HeaderText="Biologia" />
                        <asp:BoundField DataField="GEOGRAFIA" HeaderText="Geografia" />
                        <asp:BoundField DataField="FISICA" HeaderText="Fisica" />
                        <asp:BoundField DataField="QUIMICA" HeaderText="Quimica" />
                        <asp:BoundField DataField="INGLES" HeaderText="Ingles" />
                        <asp:BoundField DataField="HISTORIA" HeaderText="Historia" />
                        <asp:BoundField DataField="ALGEBRA" HeaderText="Algebra" />
                        <asp:BoundField DataField="GEOMETRIA" HeaderText="Geometria" />
                    </Columns>
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

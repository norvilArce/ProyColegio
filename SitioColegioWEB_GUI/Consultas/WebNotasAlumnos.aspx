﻿<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="WebNotasAlumnos.aspx.cs" Inherits="SitioColegioWEB_GUI.Consultas.WebNotasAlumnos" %>
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
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>
                <asp:Button ID="btnConsultar" runat="server" Text="Consultar" />
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
                <asp:GridView ID="grvNotas" runat="server" Width="500px">
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

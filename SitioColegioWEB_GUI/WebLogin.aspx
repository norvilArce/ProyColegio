﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebLogin.aspx.cs" Inherits="SitioVentasWEB_GUI.WebLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CSS/DemoCSS.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            width: 78%;
        }
        .auto-style2 {
            width: 298px;
        }
        .auto-style3 {
            height: 17px;
        }
        .auto-style4 {
            color: #FF0000;
        }
        .auto-style7 {
            color: #FF0000;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table class="auto-style1" style="background-color: #FFA833">
            <tr>
                <td class="auto-style2" rowspan="8">
                    <asp:Image ID="Image1" runat="server" Height="235px" Width="340px" ImageUrl="~/images/as.jpg" />
                </td>
                <td class="auto-style7" colspan="2">
    <span style="text-align: left; background-color: #FFFFCC;" class="tituloForm">BIENVENIDOS</span></td>
            </tr>
            <tr>
                <td class="auto-style4" colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="labelContenido">Ingrese su Usuario</td>
                <td>
                    <asp:TextBox ID="txtUsuario" runat="server" Height="23px" Width="156px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="labelContenido">Ingrese su Constraseña</td>
                <td>
                    <asp:TextBox ID="txtPass" runat="server" Height="23px" Width="156px" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btnRegistrar" runat="server" Height="24px" Text="Ingresar" Width="166px" CssClass="boton2" OnClick="btnRegistrar_Click" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblMensaje" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="10pt" ForeColor="Red" CssClass="labelErrores"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>

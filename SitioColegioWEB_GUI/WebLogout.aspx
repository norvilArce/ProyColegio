<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebLogout.aspx.cs" Inherits="SitioVentasWEB_GUI.WebLogout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CSS/DemoCSS.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            width: 61%;
        }
        .auto-style2 {
            width: 233px;
        }
        .auto-style7 {
            color: #FF0000;
            text-align: center;
        }
        .auto-style8 {
            text-align: center;
            width: 268435488px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table class="auto-style1" style="background-color: #33FFC7">
            <tr>
                <td class="auto-style2" rowspan="3">
                    <asp:Image ID="Image1" runat="server" Height="235px" Width="310px" ImageUrl="~/images/pa.jpg" />
                </td>
                <td class="auto-style7" colspan="2">
                    HASTA LUEGO,
                    <br />
                    <span style="text-align: left; class="TextBoxDerecha">VUELVA PRONTO</span></td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Button ID="btnFinSesion" runat="server" Height="24px" Text="Cerrar Sesion" Width="166px" CssClass="boton2" OnClick="btnFinSesion_Click" />
                </td>
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
</html>


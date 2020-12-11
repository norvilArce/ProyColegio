<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="Consultas.aspx.cs" Inherits="SitioColegioWEB_GUI.Consultas.Consultas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="tituloForm">
        MANTENIMIENTOS DE TABLAS MAESTRAS 
        <tr>
            <td width ="180px">
                <asp:Image ID="Image1" runat="server" Height="285px" 
                    ImageUrl="~/Images/Mantenimientos.jpg" Width="248px" />
            </td>
            <td>
                 
                <asp:TreeView ID="TreeView1" runat="server" ImageSet="Inbox">
                    <HoverNodeStyle Font-Underline="True" />
                    <Nodes>
                        <asp:TreeNode NavigateUrl="~/Consultas/WebAlumnosPorPeriodo.aspx" Text="Vendedor" Value="Vendedor"></asp:TreeNode>
                        <asp:TreeNode Text="Alumnos Por Periodo" Value="Proveedor" NavigateUrl="~/Consultas/WebAlumnosPorPeriodo.aspx"></asp:TreeNode>
                        <asp:TreeNode Text="Cursos Por Profesor" Value="Cliente" NavigateUrl="~/Consultas/WebCursosProfesor.aspx"></asp:TreeNode>
                        <asp:TreeNode Text="Notas Por Alumno" Value="Producto" NavigateUrl="~/Consultas/WebNotasAlumnos.aspx"></asp:TreeNode>
                        <asp:TreeNode Text="Promedio de Notas Por Salon" Value="Retornar al Menu Principal" NavigateUrl="~/Consultas/WebPromedioNotasSalon.aspx"></asp:TreeNode>
                        <asp:TreeNode NavigateUrl="~/MenuPrincipal.aspx" Text="Retornar al Menu Principal" Value="Retornar al Menu Principal"></asp:TreeNode>
                    </Nodes>
                    <NodeStyle Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                    <ParentNodeStyle Font-Bold="False" />
                    <SelectedNodeStyle Font-Underline="True" HorizontalPadding="0px" VerticalPadding="0px" />
                </asp:TreeView>
                 
            </td>
        </tr>
    </table>

</asp:Content>

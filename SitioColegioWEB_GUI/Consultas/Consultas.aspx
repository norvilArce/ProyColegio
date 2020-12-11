<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="Consultas.aspx.cs" Inherits="SitioColegioWEB_GUI.Consultas.Consultas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="tituloForm" style="background-color: #FFA833">
        CONSULTAS DE TABLAS 
        <tr>
            <td width ="180px">
                <asp:Image ID="Image1" runat="server" Height="285px" 
                    ImageUrl="~/images/asd.jpg" Width="323px" />
            </td>
            <td>
                 
                <asp:TreeView ID="TreeView1" runat="server" ImageSet="BulletedList" ShowExpandCollapse="False">
                    <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
                    <Nodes>
                        <asp:TreeNode Text="Alumnos Por Periodo" Value="Alumnos" NavigateUrl="~/Consultas/WebAlumnosPorPeriodo.aspx"></asp:TreeNode>
                        <asp:TreeNode Text="Cursos Por Profesor" Value="Cursos" NavigateUrl="~/Consultas/WebCursosProfesor.aspx"></asp:TreeNode>
                        <asp:TreeNode Text="Notas Por Alumno" Value="Notas" NavigateUrl="~/Consultas/WebNotasAlumnos.aspx"></asp:TreeNode>
                        <asp:TreeNode Text="Promedio de Notas Por Salon" Value="Salon" NavigateUrl="~/Consultas/WebPromedioNotasSalon.aspx"></asp:TreeNode>
                        <asp:TreeNode NavigateUrl="~/MenuPrincipal.aspx" Text="Retornar al Menu Principal" Value="Retornar al Menu Principal"></asp:TreeNode>
                    </Nodes>
                    <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                    <ParentNodeStyle Font-Bold="False" />
                    <SelectedNodeStyle Font-Underline="True" HorizontalPadding="0px" VerticalPadding="0px" ForeColor="#5555DD" />
                </asp:TreeView>
                 
            </td>
        </tr>
    </table>

</asp:Content>

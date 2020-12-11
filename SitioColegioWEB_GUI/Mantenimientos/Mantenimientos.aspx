<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="Mantenimientos.aspx.cs" Inherits="SitioColegioWEB_GUI.Mantenimientos.Mantenimientos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <table class="tituloForm" style="background-color: #FFA833">
        MANTENIMIENTOS DE TABLAS 
        <tr>
            <td width ="180px">
                <asp:Image ID="Image1" runat="server" Height="285px" 
                    ImageUrl="~/images/man.png" Width="323px" />
            </td>
            <td>
                 
                <asp:TreeView ID="TreeView1" runat="server" ImageSet="BulletedList4" ShowExpandCollapse="False">
                    <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
                    <Nodes>
                        <asp:TreeNode Text="Mantenimiento Alumnos" Value="Proveedor" NavigateUrl="~/Mantenimientos/WebMantAlumno.aspx"></asp:TreeNode>
                    </Nodes>
                    <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                    <ParentNodeStyle Font-Bold="False" />
                    <SelectedNodeStyle Font-Underline="True" HorizontalPadding="0px" VerticalPadding="0px" ForeColor="#5555DD" />
                </asp:TreeView>
                 
            </td>
        </tr>
    </table>

</asp:Content>

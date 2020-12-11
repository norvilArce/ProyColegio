<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="RegistrarMatricula.aspx.cs" Inherits="SitioColegioWEB_GUI.Transacciones.RegistrarMatricula" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 80%;
        }
        .auto-style2 {
            height: 22px;
        }
        .auto-style3 {
            width: 186px;
        }
        .auto-style4 {
            height: 22px;
            width: 186px;
        }
        .auto-style5 {
            width: 261px;
        }
        .auto-style6 {
            height: 22px;
            width: 261px;
        }
        .auto-style7 {
            font-weight: bold;
            font-size: larger;
            color: white;
        }
        .auto-style8 {
            height: 22px;
            width: 215px;
        }
        .auto-style9 {
            width: 260px;
        }
        .auto-style10 {
            width: 215px;
        }
        .auto-style11 {
            margin-left: 0;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">

        <ContentTemplate>


    <p>REGISTRAR MATRICULA</p>
    
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">Alumno:</td>
            <td class="auto-style5">
                <asp:DropDownList ID="cboAlumno" runat="server" Height="23px" Width="550px">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Seleccione Periodo:</td>
            <td class="auto-style5">
                <asp:DropDownList ID="cboPeriodo" runat="server" Height="26px" Width="225px">
                    <asp:ListItem Value="1">2020</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Cantidad de Cursos:</td>
            <td class="auto-style5">
                <asp:DropDownList ID="cboCantCursos" runat="server" Height="26px" Width="74px">
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Seleccione Grado:</td>
            <td class="auto-style5">
                <asp:DropDownList ID="cboGrado" runat="server" Height="26px" Width="114px">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Seleccione Cursos:</td>
            <td class="auto-style5">
                <asp:DropDownList ID="cboCursos" runat="server" Height="26px" Width="550px">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <!--<asp:Button ID="Button1" runat="server" Text="Elegir profesor" />-->
            </td>
            <td class="auto-style5">
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
            </td>
            <td>
                <asp:Button ID="Button3" runat="server" Text="Cancelar" PostBackUrl="~/MenuPrincipal.aspx" Width="116px" />
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <br />
                <asp:GridView ID="grDetalles" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" Width="762px" AutoGenerateColumns="False" OnRowCommand="grDetalles_RowCommand">
                    <Columns>
                        <asp:ButtonField ButtonType="Image" CommandName="Eliminar" ImageUrl="~/Images/Borrar.png" Text="Eliminar" />
                        <asp:BoundField HeaderText="Codigo Curso" DataField="idCursoProfesor" />
                        <asp:BoundField HeaderText="Descripcion" DataField="descripcion" />
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#333333" />
                    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#487575" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#275353" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:HyperLink ID="HyperLink1" runat="server">Menu</asp:HyperLink>
            </td>
            <td class="auto-style6"></td>
            <td class="auto-style2">
                <asp:Button ID="btnMatricular" runat="server" CssClass="auto-style11" OnClick="btnMatricular_Click" Text="Matricular" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>

    <asp:LinkButton ID="btnPopupDetalle" runat="server"/>
    <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server" BackgroundCssClass="FondoAplicacion"  
        TargetControlID="btnPopupDetalle" PopupControlID="PanelDetalle">
    </ajaxToolkit:ModalPopupExtender>
    <asp:Panel ID="PanelDetalle" runat="server" CssClass="auto-style19" align="center" Style="display:table" Width="543px">
          
            <table style="border: Solid 3px #D55500;"
                cellpadding="0" cellspacing="0" >
                <tr style="background-color: darkred">
                    <td colspan="2" style="height: 10%; "
                        align="center" class="auto-style7">
                        Elegir Profesor</td>
                </tr>
                <tr>
                    <td align="right" class="auto-style5">
                        </td>
                      <td align="left" class="auto-style8">
                          </td>
                </tr>
                <tr>
                    <td align="right" class="auto-style17">Seleccione Profesor:</td>
                    <td align="left" class="auto-style10">
                        <asp:DropDownList ID="cboProducto" runat="server"  Width="192px" CssClass="DropDownList">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" class="auto-style9">
                        <asp:Label ID="lblMensajeDetalle" runat="server" CssClass="labelErrores" Width="400px"></asp:Label>
                    </td>
                </tr>
               
                     <tr>
                         <td class="auto-style26">
                             </td>
                         <td class="auto-style10">
                             </td>
                </tr>
              
                <tr>
                    <td class="auto-style22">
                        <asp:Button ID="btnGrabarDetalle" runat="server" Text="Grabar" Width="100px" CssClass="boton2" />
                    </td>
                    <td class="auto-style10">
                        <asp:Button ID="btnCancelarDetalle" runat="server" Text="Cancelar" Width="100px" CssClass="boton-new" />
                    </td>
                </tr>
              
                <tr>
                    <td class="auto-style27"></td>
                    <td class="auto-style10"></td>
                </tr>
              
            </table>
                        
        </asp:Panel>

    <asp:LinkButton ID="lnkMensaje" runat="server"/>
            <ajaxToolkit:ModalPopupExtender ID="mpeMensaje" runat="server" TargetControlID="lnkMensaje" 
                    PopupControlID="pnlMensaje" BackgroundCssClass="FondoAplicacion" OkControlID="btnAceptar" 
                     />
<asp:Panel ID="pnlMensaje" runat="server" CssClass="CajaDialogo" Style="display: normal;" Width="500"> 
                    <table border="0" width="500px" style="margin: 0px; padding: 0px; background-color:darkred ; 
                        color: #FFFFFF;"> 
                        <tr> 
                            <td align="center" class="auto-style11" > 
                                <asp:Label ID="lblTitulo" runat="server" Text="Mensaje" /> 
                            </td> 
                            <td width="12%" class="auto-style11"> 
                                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/Cancelar.png" Style="vertical-align: top;" 
                                    ImageAlign="Right" /> 
                            </td> 
                        </tr> 
                         
                    </table> 
                    <div> 
                        <asp:Label ID="lblMensaje" runat="server" ForeColor ="Black" /> 
                    </div> 
                    <div> 
                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CssClass="boton-new" /> 
                    </div> 
                </asp:Panel> 


                    </ContentTemplate>
    </asp:UpdatePanel>
    
</asp:Content>

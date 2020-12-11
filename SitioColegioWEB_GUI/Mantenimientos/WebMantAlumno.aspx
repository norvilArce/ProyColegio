<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="WebMantAlumno.aspx.cs" Inherits="SitioColegioWEB_GUI.Mantenimientos.WebMantAlumno" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            font-family: Verdana;
            font-size: 10pt;
            color: #993366;
            height: 20px;
        }
        .auto-style2 {
            height: 20px;
        }
        .auto-style3 {
            font-family: Verdana;
            font-size: 10pt;
            color: #993366;
            height: 22px;
        }
        .auto-style4 {
            height: 22px;
        }
        .auto-style5 {
            width: 68%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <%--INDISPENSABLE PARA EL AJAX--%>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate >
       
            <%--Aqui va el diseño del formulario--%>
            <div class="tituloForm">
                  MANTENIMIENTO DE ALUMNOS
            </div>
   
              <%--Boton ( o link button ) para mostrar el modal de insercion PopMant del nuevo registro--%>
            <br />
            <asp:Button ID="btnNuevo" runat="server" Text="Agregar ALumno" OnClick="btnNuevo_Click" />
            &nbsp;
            <br />
            <%--El grid view para el listado de proveedores, con la primera columna de tipo Button, con el CommanName (recomendado) Editar
                   y con un icono asociado a la accion de editar--%>
            <table class="auto-style5">
                <tr>
                    <td class="labelContenido">Ingrese Apellido:</td>
                    <td>
                        <asp:TextBox ID="txtFiltro" runat="server" Width="300px"></asp:TextBox>
                        <asp:ImageButton ID="btnFiltrar" runat="server" ImageUrl="~/images/Buscar.png" 
                            OnClick="btnFiltrar_Click" />
                    </td>
                </tr>
            </table>
            <br />
            <asp:GridView ID="grvAlumnos" runat="server" AutoGenerateColumns="False" 
                BackColor="White" BorderColor="#336666" BorderStyle="Double" 
                BorderWidth="3px" CellPadding="4" GridLines="Horizontal" 
                Width="1068px" OnRowCommand="grvAlumnos_RowCommand" 
                ShowHeaderWhenEmpty="True" AllowPaging="True" 
                HorizontalAlign="Left" 
                OnPageIndexChanging="grvAlumnos_PageIndexChanging" 
                OnRowDataBound="grvAlumnos_RowDataBound" PageSize="50">
                <Columns>
                    <asp:ButtonField ButtonType="Image" ImageUrl="~/images/Editar.png" Text="Botón" CommandName="Editar" />
                    <asp:BoundField DataField="IDALUMNO" HeaderText="Codigo" />
                    <asp:BoundField DataField="ApellNombres" HeaderText="Nombres" />
                    <asp:BoundField DataField="FECHANACI" HeaderText="Fecha de Nacimiento" />
                    <asp:BoundField DataField="TELEFONO" HeaderText="Telefono" />
                    <asp:BoundField DataField="DIRECCION" HeaderText="Direccion" />
                    <asp:BoundField DataField="FECHA_REGISTRO" HeaderText="Fecha de Registro" />
                    <asp:BoundField DataField="ESTADO" HeaderText="Estado" />
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
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <%--Modal Popup PopMant para la insercion del registro--%>
             <%--El modalpoput extender : vease el TargetControl que apunta al linkbutton y el popuconttol ID que apunta al panel--%> 
           <asp:LinkButton Text="" ID = "btnPopup" runat="server" />
            <ajaxToolkit:ModalPopupExtender ID="PopMant" runat="server" BackgroundCssClass="FondoAplicacion"  
         TargetControlID="btnPopup" PopupControlID="Panel1"  >
        </ajaxToolkit:ModalPopupExtender>
    <asp:Panel ID="Panel1" runat="server" CssClass="CajaDialogo" align="center" Style="display:table" Width="700">
          
            <table style="border: Solid 3px #D55500; height: 308px;"
                cellpadding="0" cellspacing="0" >
                <tr style="background-color: darkred">
                    <td colspan="2" style="height: 10%; color: White; font-weight: bold; font-size: larger"
                        align="center">
                        Nuevo Alumno</td>
                </tr>
                <tr>
                    <td align="right" style="width: 45%" class="labelContenido">
                        &nbsp;</td>
                      <td align="left">
                          &nbsp;</td>
                </tr>
                <tr>
                    <td align="right" class="labelContenido">
                        Nombres:
                    </td>
                    <td align="left">
                        <asp:TextBox ID="txtNombres" runat="server" Width="450px" />
                    </td>
                </tr>
                <tr>
                    <td align="right" class="labelContenido">
                        Apellido Parterno:
                    </td>
                    <td align="left">
                        <asp:TextBox ID="txtApePat" runat="server" Width="220px" Height="16px" />
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="right" class="labelContenido">Apellido Materno: </td>
                    <td align="left">
                        <asp:TextBox ID="txtApeMat" runat="server" Height="16px" Width="220px" />
                    </td>
                </tr>
                <tr>
                    <td align="right" class="labelContenido">Email:</td>
                    <td align="left">
                        <asp:TextBox ID="txtEmail" runat="server" Height="16px" Width="220px" />
                    </td>
                </tr>
                <tr>
                    <td align="right" class="labelContenido">Fecha Nacimiento:</td>
                    <td align="left">&nbsp;</td>
                </tr>
                <tr>
                    <td align="right" class="labelContenido">
                        Telefono:
                    </td>
                    <td align="left">
                        <asp:TextBox ID="txtTel" runat="server" Width="100px" />
                    </td>
                </tr>
               
                     <tr>
                         <td align="right" class="labelContenido">DNI:</td>
                         <td align="left">
                             <asp:TextBox ID="txtDNI" runat="server" Width="120px" />
                         </td>
                </tr>
                <tr>
                    <td align="right" class="labelContenido">Padre:</td>
                    <td align="left">
                        <asp:DropDownList ID="cboPadre" runat="server" AutoPostBack="True" 
                            OnSelectedIndexChanged="cboDepartamento_SelectedIndexChanged" 
                            Width="250px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="labelContenido">Direccion:</td>
                    <td align="left">
                        <asp:TextBox ID="txtDir" runat="server" Height="16px" Width="220px" />
                    </td>
                </tr>
                <tr>
                    <td align="right" class="labelContenido">Departamento:</td>
                    <td align="left">
                        <asp:DropDownList ID="cboDepartamento" runat="server" 
                            Width="250px" AutoPostBack="True" 
                            OnSelectedIndexChanged="cboDepartamento_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
               <tr>
                    <td align="right" class="labelContenido">Provincia:</td>
                    <td align="left">
                        <asp:DropDownList ID="cboProvincia" runat="server" Width="250px" AutoPostBack="True" OnSelectedIndexChanged="cboProvincia_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="labelContenido">Distrito:</td>
                    <td align="left">
                        <asp:DropDownList ID="cboDistrito" runat="server" Width="250px">
                        </asp:DropDownList>
                    </td>
                </tr>
                     <tr>
                         <td align="right" class="labelContenido">Estado: </td>
                         <td align="left">
                             <asp:CheckBox ID="chkActivo" runat="server" />
                         </td>
                     </tr>
                     <tr>
                         <td colspan="2">
                             <asp:Label ID="lblMensajeIns" runat="server" CssClass="labelErrores" Width="400px"></asp:Label>
                         </td>
                     </tr>
                     <tr>
                         <td class="auto-style1">
                             &nbsp;</td>
                         <td class="auto-style1">
                             <asp:Button ID="btnGrabar" runat="server" Text="Grabar" Width="100px" OnClick="btnGrabar_Click" />
                             <asp:Button ID="btnCancelar" runat="server"  Text="Cancelar" Width="100px" />
                         </td>
                     </tr>
              
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style1">&nbsp;</td>
                </tr>
              
            </table>
                        
        </asp:Panel>

            <%-- Modal Popup PopMant2 para la edicion del registro (incluye el codigo o PK del registro)--%>
              <%--El modalpoput extender : vease el TargetControl que apunta al linkbutton y el popuconttol ID que apunta al panel--%> 
       <asp:LinkButton Text="" ID = "btnPopup2" runat="server" />
            <ajaxToolkit:ModalPopupExtender ID="PopMant2" runat="server" BackgroundCssClass="FondoAplicacion"  
        TargetControlID="btnPopup2" PopupControlID="Panel2"  >
    </ajaxToolkit:ModalPopupExtender>
    <asp:Panel ID="Panel2" runat="server" CssClass="CajaDialogo" align="center" Style="display:table" Width="700">
          
            <table style="border: Solid 3px #D55500; height: 308px;"
                cellpadding="0" cellspacing="0" >
                <tr style="background-color: darkred">
                    <td colspan="2" style="height: 10%; color: White; font-weight: bold; font-size: larger"
                        align="center">
                        Actualizar Alumno</td>
                </tr>
                <tr>
                    <td align="right" style="width: 45%" class="labelContenido">
                        &nbsp;</td>
                      <td align="left">
                          &nbsp;</td>
                </tr>
                <tr>
                    <td align="right" class="labelContenido" style="width: 45%">Codigo:</td>
                    <td align="left">
                        <asp:TextBox ID="txtCod" runat="server" Width="50px" />
                    </td>
                </tr>
                <tr>
                    <td align="right" class="labelContenido" style="width: 45%">Nombres: </td>
                    <td align="left">
                        <asp:TextBox ID="txtNombres2" runat="server" Width="450px" />
                    </td>
                </tr>
                <tr>
                    <td align="right" class="labelContenido" style="width: 45%">Apellido Parterno: </td>
                    <td align="left">
                        <asp:TextBox ID="txtApePat2" runat="server" Height="16px" Width="220px" />
                    </td>
                </tr>
                <tr>
                    <td align="right" class="labelContenido" style="width: 45%">Apellido Materno: </td>
                    <td align="left">
                        <asp:TextBox ID="txtApeMat2" runat="server" Height="16px" Width="220px" />
                    </td>
                </tr>
                <tr>
                    <td align="right" class="labelContenido" style="width: 45%">Email:</td>
                    <td align="left">
                        <asp:TextBox ID="txtEmail2" runat="server" Height="16px" Width="220px" />
                    </td>
                </tr>
                <tr>
                    <td align="right" class="labelContenido" style="width: 45%">Fecha Nacimiento:</td>
                    <td align="left">&nbsp;</td>
                </tr>
                <tr>
                    <td align="right" class="labelContenido" style="width: 45%">Telefono: </td>
                    <td align="left">
                        <asp:TextBox ID="txtTel2" runat="server" Width="100px" />
                    </td>
                </tr>
                <tr>
                    <td align="right" class="labelContenido">
                        DNI:</td>
                    <td align="left">
                        <asp:TextBox ID="txtDNI2" runat="server" Width="120px" />
                    </td>
                </tr>
                <tr>
                    <td align="right" class="labelContenido">
                        Padre:</td>
                    <td align="left">
                        <asp:DropDownList ID="cboPadre2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cboDepartamento_SelectedIndexChanged" Width="250px">
                        </asp:DropDownList>
                    </td>
                </tr>
               
                     <tr>
                         <td align="right" class="labelContenido">Direccion: </td>
                         <td align="left">
                             <asp:TextBox ID="txtDir2" runat="server" Width="487px" />
                         </td>
                </tr>
                <tr>
                    <td align="right" class="labelContenido">Departamento:</td>
                    <td align="left">
                        <asp:DropDownList ID="cboDepartamento2" runat="server" Width="250px" AutoPostBack="True" OnSelectedIndexChanged="cboDepartamento2_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
               <tr>
                    <td align="right" class="auto-style3">Provincia:</td>
                    <td align="left" class="auto-style4">
                        <asp:DropDownList ID="cboProvincia2" runat="server" Width="250px" AutoPostBack="True" OnSelectedIndexChanged="cboProvincia2_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="labelContenido">Distrito:</td>
                    <td align="left">
                        <asp:DropDownList ID="cboDistrito2" runat="server" Width="250px">
                        </asp:DropDownList>
                    </td>
                </tr>
                     <tr>
                         <td align="right" class="labelContenido">Estado: </td>
                         <td align="left">
                             <asp:CheckBox ID="chkActivo2" runat="server" />
                         </td>
                     </tr>
                     <tr>
                         <td colspan="2">
                             <asp:Label ID="lblMensajeAct" runat="server" CssClass="labelErrores" Width="400px"></asp:Label>
                         </td>
                     </tr>
                     <tr>
                         <td class="auto-style1">
                             &nbsp;</td>
                         <td class="auto-style1">
                             <asp:Button ID="btnGrabar2" runat="server" Text="Grabar" Width="100px" OnClick="btnGrabar2_Click" />
                             &nbsp;<asp:Button ID="btnEliminar" runat="server" Text="Eliminar" Width="100px" />
&nbsp;<asp:Button ID="btnCancelar2" runat="server"  Text="Cancelar" Width="100px" />
                         </td>
                     </tr>
              
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style1">&nbsp;</td>
                </tr>
              
            </table>
                        
        </asp:Panel>

            <%--Este es el panel  que contiene los mensajes de error--%>
              <asp:LinkButton ID="lnkMensaje" runat="server" />
               <ajaxToolkit:ModalPopupExtender ID="mpeMensaje" runat="server" TargetControlID="lnkMensaje" 
                    PopupControlID="pnlMensaje" BackgroundCssClass="FondoAplicacion" OkControlID="btnAceptar" 
                     />
<asp:Panel ID="pnlMensaje" runat="server" CssClass="CajaDialogo" Style="display: normal;" Width="300"> 
                    <table border="0" width="300px" style="margin: 0px; padding: 0px; background-color:darkred ; 
                        color: #FFFFFF;"> 
                        <tr> 
                            <td align="center" class="auto-style2"> 
                                <asp:Label ID="lblTitulo" runat="server" Text="Mensaje" /> 
                            </td> 
                            <td width="12%" class="auto-style2"> 
                                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/Cancelar.png" Style="vertical-align: top;" 
                                    ImageAlign="Right" /> 
                            </td> 
                        </tr> 
                         
                    </table> 
                    <div> 
                        <asp:Label ID="lblMensaje" runat="server" ForeColor ="Black" CssClass="labelContenido" /> 
                    </div> 
                    <div> 
                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" /> 
                    </div> 
    <br />
                </asp:Panel> 
        </ContentTemplate>

    </asp:UpdatePanel>
    <%--El UpdateProgress para el manejo del tiempo de refresco del UpdatePanel1 por la insercion , actualizacion o eliminacion--%>
    <asp:UpdateProgress ID="UpdateProgress1" runat="server" DisplayAfter="0" AssociatedUpdatePanelID="UpdatePanel1">
        <%--<ProgressTemplate >
            <div class="overlay"  />
            <div class ="overlayContent" >
            <h2>  Procesando....</h2> 
                <p>
                    &nbsp;</p>
                <img src ="../Images/indicator.gif" alt ="Loading" border="0"/>
                </div> 
        </ProgressTemplate>--%>
    </asp:UpdateProgress>
</asp:Content>


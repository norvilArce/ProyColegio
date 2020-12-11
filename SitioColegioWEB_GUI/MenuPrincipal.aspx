<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="MenuPrincipal.aspx.cs" Inherits="SitioVentasWEB_GUI.MenuPrincipal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        height: 205px;
    }
        .auto-style2 {
            width: 263px;
        }
        .auto-style3 {
            font-size: x-large;
            color: #FF5050;
        }
        .auto-style4 {
            font-family: Verdana;
            font-size: 10pt;
            color: #993366;
            width: 404px;
            height: 67px;
        }
        .auto-style5 {
            width: 404px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div id="carouselExampleControls" class="carousel slide" data-bs-ride="carousel">
  <div class="carousel-inner">
    <div class="carousel-item active">
      <img src="/images/edu.jpg" class="d-block w-100" alt="...">
    </div>
  </div>
</div>

    		 <!-- WELCOME START -->
        <section class="section" id="problemas">
            <div class="container">
                <div class="row justify-content-center">
                    <div class="col-lg-6">
                        <div class="text-center">
                            <h4 class="title-heading text-uppercase">MENU PRINCIPAL</h4>
                        </div>
                    </div>
                </div>

                <div class="row mt-4">
                    <div class="col-lg-6">
                        <div class="features mt-4">
                            <div class="text-center">
                                <div class="mb-4">
                                    <h5 class="text-custom">
                                        <i class="mdi mdi-book-open-page-variant"></i>
                                    </h5>
                                </div>

                                <h4>
                                    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Transacciones/Transacciones.aspx">MANTENIMIENTOS</asp:HyperLink>
                                </h4>
                                <p class="features-desc text-muted mt-3 pl-2 pr-2">En Mantimientos, podras agregar, modificar e eliminar datos en las tablas de profesores, alumnos y cursos,</p>
                            </div>
                        </div>
                    </div>

                    <div class="col-lg-6">
                        <div class="features mt-4">
                            <div class="text-center">
                                <div class="mb-4">
                                    <h5 class="text-custom">
                                        <i class="mdi mdi-airballoon"></i>
                                    </h5>
                                </div>
                                <h4>
                                   <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Transacciones/Transacciones.aspx">CONSULTAS</asp:HyperLink>
                                </h4>
                                <p class="features-desc text-muted mt-3 pl-2 pr-2">Aqui podras hacer consultas de las matriculas</p>
                            </div>
                        </div>
                    </div> 
                </div>

            </div>
        </section>
        <!-- WELCOME END -->

</asp:Content>

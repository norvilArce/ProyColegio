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
                                    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Mantenimientos/Mantenimientos.aspx">MANTENIMIENTOS</asp:HyperLink>
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
                                   <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Consultas/Consultas.aspx">CONSULTAS</asp:HyperLink>
                                </h4>
                                <p class="features-desc text-muted mt-3 pl-2 pr-2">Aqui podras hacer consultas de las matriculas</p>
                            </div>
                        </div>
                    </div> 
                </div>

            </div>
        </section>
        <!-- WELCOME END -->

     <!-- CONTACT START -->
        <section class="section bg-light" id="contact">
            <div class="container">
                <div class="row justify-content-center">
                    <div class="col-lg-6">
                        <div class="contact-head text-center">
                            <h4 class="title-heading text-uppercase">CONTÁCTANOS</h4>
                            <p class="title-desc text-muted">Vacantes Disponibles</p>
                        </div>
                    </div>
                </div>

                <div class="row mt-4 vertical-content">
                    <div class="col-lg-12">
                        <div class="row mt-5">

                            <div class="col-lg-4">
                                <div class="contact-info">
                                    <div class="mt-3">
                                        <div class="float-left">
                                            <i class="mdi mdi-email h5"></i>
                                        </div>
                                        <div class="ml-5">
                                            <h6 class="text-custom">Dirección de Correo Electrónico</h6>
                                            <p>Example@harrowschool.com</p>
                                        </div>
                                    </div>

                                    <div class="mt-4">
                                        <div class="float-left">
                                            <i class="mdi mdi-phone-in-talk h5"></i>
                                        </div>
                                        <div class="ml-5">
                                            <h6 class="text-custom">Numero Celular</h6>
                                            <p>+1-202-555-0134 , +1-202-555-0194</p>
                                        </div>
                                    </div>

                                    <div class="mt-4">
                                        <div class="float-left">
                                            <i class="mdi mdi-home h5"></i>
                                        </div>
                                        <div class="ml-5">
                                            <h6 class="text-custom">Lugar</h6>
                                            <p>Av. la Fontana 755, La Molina 15024</p>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class="col-lg-8">
                                <div class="custom-form">
                                    <div id="message"></div>
                                    <form method="post" action="php/contact.php" name="contact-form" id="contact-form">
                                        <div class="row">
                                            <div class="col-lg-6">
                                                <div class="form-group">
                                                    <input name="name" id="name" type="text" class="form-control" placeholder="Nombre...">
                                                </div>
                                            </div>
                                            <div class="col-lg-6">
                                                <div class="form-group">
                                                    <input name="email" id="email" type="email" class="form-control" placeholder="Correo...">
                                                </div>
                                            </div>
                                        </div>

                                        <div class="row">
                                            <div class="col-lg-12">
                                                <div class="form-group">
                                                    <input name="text" id="sub" type="text" class="form-control" placeholder="Tema...">
                                                </div>
                                            </div>
                                        </div>

                                        <div class="row">
                                            <div class="col-lg-12">
                                                <div class="form-group">
                                                    <textarea name="comments" id="comments" rows="4" class="form-control" placeholder="Mensaje..."></textarea>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row mt-3">
                                            <div class="col-lg-12">
                                                <input type="submit" id="submit" name="send" class="submitBnt btn btn-custom" value="Enviar Mensaje">
                                                <div id="simple-msg"></div>
                                            </div>
                                        </div>
                                    </form>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- CONTACT END -->

    <!-- FOOTER START -->
        <section class="footer bg-dark">
            <div class="container">
                <div class="row">
                    <div class="col-lg-4">
                        <div class="footer-menu">
                            <h5 class="mb-4 text-uppercase">Harrow School</h5>
                            <p>La Union Hace la Fuerza</p>
                            <div class="text-white">
                                <a href="#facebook"><i class="mdi mdi-facebook facebook footer_mdi"></i></a>
                                <a href="#twitter"><i class="mdi mdi-twitter twitter footer_mdi"></i></a>
                                <a href="#google"><i class="mdi mdi-google google footer_mdi"></i></a>
                                <a href="#apple"><i class="mdi mdi-apple apple footer_mdi"></i></a>
                            </div>
                        </div>
                    </div>

                    <div class="col-lg-2">
                        <div class="footer-menu">
                            <h5 class="mb-4 text-uppercase">Sobre Harrow School</h5>
                            <ul class="text-muted list-unstyled">
                                <li><a href="#">Nosotros</a></li>
                                <li><a href="#">Términos</a></li>
                                <li><a href="#">Privacidad</a></li>
                            </ul>
                        </div>
                    </div>

                    <div class="col-lg-2">
                        <div class="footer-menu">
                            <h5 class="mb-4 text-uppercase">Centro de Ayuda</h5>
                            <ul class="text-muted list-unstyled">
                                <li><a href="#">Preguntas Generales</a></li>
                            </ul>
                        </div>
                    </div>

                    <div class="col-lg-4">
                        <div class="footer-menu">
                            <h5 class="mb-4 text-uppercase">Contáctanos</h5>
                            <span class="footer-support">Support@harrowschool.com</span>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col-lg-12">
                        <div class="text-center mt-5">
                            <p class="mb-0">2020 © Harrow School. Todos los derechos reservados</p>

                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- FOOTER END -->
</asp:Content>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioVentasWEB_GUI
{
    public partial class WebLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {

                // Usuario y password obligatorios
                if (txtUsuario.Text.Trim() == String.Empty)
                {
                    throw new Exception("Debe ingresar el usuario.");
                }

                if (txtPass.Text.Trim() == String.Empty)
                {
                    throw new Exception("Debe ingresar la conjtraseña.");
                }


                // Validamos el usuario y contraseña

                if (txtUsuario.Text.Trim() == "jlino" & txtPass.Text.Trim() == "12345")
                {
                    Response.Redirect("MenuPrincipal.aspx");
                }
                else
                {
                    throw new Exception("Su usuario o contraseña son incorrectos.");
                }

            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }
    }
}
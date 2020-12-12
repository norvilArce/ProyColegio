using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// Los using...
using ProyColegio_BE;
using ProyColegio_BL;
using System.Data;

namespace SitioColegioWEB_GUI.Mantenimientos
{
    public partial class WebMantAlumno : System.Web.UI.Page
    {
        // Declaramos las instancias ...
        ProfesorBL objProfesorBL = new ProfesorBL();
        ProfesorBE objProfesorBE = new ProfesorBE();
        UbigeoBL objUbigeoBL = new UbigeoBL();
        DataView dtv;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsPostBack == false)
                {
                    //Creamos la vista en memoria y cargamos los datos
                    dtv = new DataView(objProfesorBL.ListarProfesor());
                    Session["Vista"] = dtv;
                    CargarDatos("");
                }

            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
                mpeMensaje.Show();
            }
        }

        private void CargarDatos(String strFiltro)
        {
            dtv = (DataView)Session["Vista"];
            dtv.RowFilter = "APELLNOMBRES like '%" + strFiltro + "%'";
            grvAlumnos.DataSource = dtv;
            grvAlumnos.DataBind();

        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        protected void btnFiltrar_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void grvAlumnos_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void grvAlumnos_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void grvAlumnos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {

        }

        protected void btnGrabar2_Click(object sender, EventArgs e)
        {

        }

        protected void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void cboDepartamento2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void cboProvincia2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
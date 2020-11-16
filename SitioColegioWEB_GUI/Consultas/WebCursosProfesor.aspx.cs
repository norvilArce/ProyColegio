using ProyColegio_BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioColegioWEB_GUI.Consultas {

    public partial class WebCursosProfesor : System.Web.UI.Page {

        ProfesorBL objProfesorBL = new ProfesorBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            try {
                if (Page.IsPostBack == false) {
                    cboProfesor.DataSource = objProfesorBL.ListarProfesor();
                    cboProfesor.DataValueField = "IDPROFESOR";
                    cboProfesor.DataTextField = "APELLNOMBRES";
                    cboProfesor.DataBind();
                }
            }
            catch (Exception ex) {
                lblMensaje.Text = ex.Message;
            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e) {
            try {
                grvCursos.DataSource = objProfesorBL.ListarCursosPorProfesor(int.Parse(cboProfesor.SelectedValue));
                grvCursos.DataBind();

                if (grvCursos.Rows.Count == 0) {
                    lblMensaje.Text = "El profesor aún no tiene cursos asignados";
                }
                else {
                    lblMensaje.Text = "Cantidad de cursos: " + grvCursos.Rows.Count.ToString();
                }
            }
            catch (Exception ex) {
                lblMensaje.Text = ex.Message;
            }
        }
    }
}
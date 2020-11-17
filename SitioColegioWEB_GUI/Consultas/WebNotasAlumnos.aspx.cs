using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyColegio_BL;

namespace SitioColegioWEB_GUI.Consultas
{
    public partial class WebNotasAlumnos : System.Web.UI.Page
    {
        AlumnoBL objAlumnoBL = new AlumnoBL();
        PeriodoBL objPeriodoBL = new PeriodoBL();
        CursoBL objCursoBL = new CursoBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    cboAlumno.DataSource = objAlumnoBL.ListarAlumno();
                    cboAlumno.DataValueField = "IDALUMNO";
                    cboAlumno.DataTextField = "ApellNombres";
                    cboAlumno.DataBind();

                    cboPeriodo.DataSource = objPeriodoBL.ListarPeriodos();
                    cboPeriodo.DataValueField = "IDPERIODO";
                    cboPeriodo.DataTextField = "ANUAL";
                    cboPeriodo.DataBind();

                    cboCurso.DataSource = objCursoBL.ListarCurso();
                    cboCurso.DataValueField = "IDCURSO";
                    cboCurso.DataTextField = "NOMBRECURSO";
                    cboCurso.DataBind();
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                grvNotas.DataSource = objAlumnoBL.ListarNotasAlumnoPorCurso(Convert.ToInt16(cboAlumno.SelectedValue),
                    Convert.ToInt16(cboPeriodo.SelectedValue),
                    Convert.ToInt16(cboCurso.SelectedValue));

                grvNotas.DataBind();

                if (grvNotas.Rows.Count == 0)
                {
                    lblMensaje.Text = "Alumno no registra notas";
                }
                else
                {
                    lblMensaje.Text = "Numero de notas: " + grvNotas.Rows.Count.ToString();
                }

            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }
    }
}
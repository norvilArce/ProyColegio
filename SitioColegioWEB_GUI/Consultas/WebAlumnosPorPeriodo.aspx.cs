using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyColegio_BL;

namespace SitioColegioWEB_GUI.Consultas
{
    public partial class WebAlumnosPorPeriodo : System.Web.UI.Page
    {
        AlumnoBL objAlumnoBL = new AlumnoBL();
        PeriodoBL objPeriodoBL = new PeriodoBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsPostBack == false)
                {
                    cboPeriodo.DataSource = cboPeriodo.ListarCliente();
                    cboPeriodo.DataValueField = "";
                    cboPeriodo.DataTextField = "";
                    cboPeriodo.DataBind();
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
                grvAlumnos.DataSource = objAlumnoBL.ListarFacturasClienteFechas(cboPeriodo.SelectedValue.ToString());
                grvAlumnos.DataBind();

                if (grvAlumnos.Rows.Count == 0)
                {
                    lblMensaje.Text = "No se registra alumnos en el periodo seleccionado";
                }
                else
                {
                    lblMensaje.Text = "Cantidad Alumnos" + grvAlumnos.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }
    }
}
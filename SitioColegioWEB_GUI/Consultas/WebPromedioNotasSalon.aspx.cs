using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyColegio_BL;

namespace SitioColegioWEB_GUI.Consultas
{
    public partial class WebPromedioNotasSalon : System.Web.UI.Page
    {
        AlumnoBL objAlumnoBL = new AlumnoBL();
        PeriodoBL objPeriodoBL = new PeriodoBL();
        SalonBL objSalonBL = new SalonBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //solo cuando seala primera vez que se cargue
                if (!Page.IsPostBack)
                {
                    cboSalon.DataSource = objSalonBL.ListarSalon();
                    cboSalon.DataValueField = "IDSALON";
                    cboSalon.DataTextField = "Salon";
                    cboSalon.DataBind();

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
                grvNotas.DataSource = objSalonBL.ListarPromediosSalon(Convert.ToInt16(cboSalon.SelectedValue));

                grvNotas.DataBind();

                if (grvNotas.Rows.Count == 0)
                {
                    lblMensaje.Text = "Salon no tiene notas registradas";
                }
                else
                {
                    lblMensaje.Text = "Cantidad de periodos: " + grvNotas.Rows.Count.ToString();
                }

            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ProyColegio_BL;
using ProyColegio_BE;

namespace SitioColegioWEB_GUI.Transacciones {


    public partial class RegistrarMatricula : System.Web.UI.Page {

        DataTable mitb;
        DataColumn col_IdCursoProf;
        DataColumn col_Desc;

        private void CrearTabla() {
            mitb = new DataTable("TBMatricula");
            DataColumn col_IdCursoProf = new DataColumn("idCursoProfesor");
            col_IdCursoProf.DataType = Type.GetType("System.Int16");
            mitb.Columns.Add(col_IdCursoProf);
            DataColumn col_Desc = new DataColumn("Descripcion");
            col_Desc.DataType = Type.GetType("System.String");
            mitb.Columns.Add(col_Desc);
            mitb.PrimaryKey = new DataColumn[] { mitb.Columns["idCursoProfesor"] };
            grDetalles.DataSource = mitb;
            grDetalles.DataBind();
            Session["Matricula"] = mitb;
        }

        protected void Page_Load(object sender, EventArgs e){
            try {
                if (Page.IsPostBack == false) {

                    //Llenar cursos
                    CursoProfesorBL objCursoProfBL = new CursoProfesorBL();
                    DataTable dt = objCursoProfBL.ListarCursoProfesor();
                    DataRow dr;
                    dr = dt.NewRow();
                    dr["idCursoProfesor"] = -1;
                    dr["Descripcion"] = "(Seleccione)";
                    dt.Rows.InsertAt(dr, 0);
                    cboCursos.DataSource = dt;
                    cboCursos.DataValueField = "idCursoProfesor";
                    cboCursos.DataTextField = "Descripcion";
                    cboCursos.DataBind();
                    CrearTabla();

                    //Llenar alumnos
                    AlumnoBL objAlumnos = new AlumnoBL();
                    DataTable dt2 = objAlumnos.ListarAlumno();
                    DataRow dr2;
                    dr2 = dt2.NewRow();
                    dr2["idAlumno"] = -1;
                    dr2["ApellNombres"] = "(Seleccione)";
                    dt2.Rows.InsertAt(dr2, 0);
                    cboAlumno.DataSource = dt2;
                    cboAlumno.DataValueField = "idAlumno";
                    cboAlumno.DataTextField = "ApellNombres";
                    cboAlumno.DataBind();

                }
            }
            catch (Exception ex) {
                lblMensaje.Text = ex.Message;
                mpeMensaje.Show();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e) {
            try {
                if (cboCursos.SelectedValue == "-1") {
                    throw new Exception("Debe seleccionar un curso");
                }

                mitb = (DataTable)Session["Matricula"];

                if (mitb.Rows.Count >= Int16.Parse(cboCantCursos.SelectedValue)) {
                    throw new Exception("La cantidad de cursos excede a la cantidad máxima.");
                }

                string cursoActual = cboCursos.SelectedItem.ToString().Split(new char[] { '(' })[0].Trim();

                foreach (DataRow row in mitb.Rows) {
                    string curso = row["Descripcion"].ToString().Split(new char[] { '(' })[0].Trim();
                    if (curso == cursoActual) {
                        throw new Exception("Ya se ha registrado este curso.");
                    }
                }

                DataRow dr;
                dr = mitb.NewRow();

                dr["idCursoProfesor"] = Int16.Parse(cboCursos.SelectedValue);
                dr["Descripcion"] = cboCursos.SelectedItem.ToString();
                mitb.Rows.Add(dr);

                grDetalles.DataSource = mitb;
                grDetalles.DataBind();

            }
            catch (Exception ex) {
                lblMensaje.Text = ex.Message;
                mpeMensaje.Show();
            }
        }

        protected void grDetalles_RowCommand(object sender, GridViewCommandEventArgs e) {
            try {
                int indicefila = Convert.ToInt16(e.CommandArgument);

                if (e.CommandName == "Eliminar") {
                    mitb = (DataTable)Session["Matricula"];
                    mitb.Rows.RemoveAt(indicefila);
                    grDetalles.DataSource = mitb;
                    grDetalles.DataBind();
                    Session["Matricula"] = mitb;
                }
            }
            catch (Exception ex) {
                lblMensaje.Text = ex.Message;
                mpeMensaje.Show();
            }
        }

        protected void btnMatricular_Click(object sender, EventArgs e) {
            try {
                mitb = (DataTable)Session["Matricula"];

                if (cboAlumno.SelectedValue == "-1") {
                    throw new Exception("Debe seleccionar un alumno.");
                }
                if (mitb.Rows.Count > Int16.Parse(cboCantCursos.SelectedValue)) {
                    throw new Exception("La cantidad de cursos excede a la cantidad máxima.");
                }

                MatriculaBE matriculaBE = new MatriculaBE();
                MatriculaBL matriculaBL = new MatriculaBL();

                matriculaBE.idPeriodo = Int16.Parse(cboPeriodo.SelectedValue);
                matriculaBE.idAlumno = Int16.Parse(cboAlumno.SelectedValue);
                matriculaBE.grado = Int16.Parse(cboGrado.SelectedValue);
                matriculaBE.UsuRegistro = "dibarra";
                matriculaBE.Estado = 1;

                mitb.Columns.Remove("Descripcion");

                matriculaBE.DetalleMatricula = mitb;

                String output = matriculaBL.RegistrarMatricula(matriculaBE);

                if (output.StartsWith("[ERROR]")) {
                    throw new Exception(output);
                }
                else {
                    lblMensaje.Text = "Se registró la matricula Nro: " + output + " exitosamente.";
                    mpeMensaje.Show();
                    cboAlumno.SelectedIndex = 0;
                    cboPeriodo.SelectedIndex = 0;
                    cboCantCursos.SelectedIndex = 0;
                    cboGrado.SelectedIndex = 0;
                    cboCursos.SelectedIndex = 0;
                    CrearTabla();
                }


            }
            catch (Exception ex) {
                lblMensaje.Text = ex.Message;
                mpeMensaje.Show();
            }
        }
    }
}
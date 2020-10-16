using ProyColegio_BE;
using ProyColegio_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyColegio_GUI {
    public partial class CursoMan03 : Form {

        CursoBE objCursoBE = new CursoBE();
        CursoBL objCursoBL = new CursoBL();

        private int _id;

        public int Id {
            get { return _id; }
            set { _id = value; }
        }

        public CursoMan03() {
            InitializeComponent();
        }

        private void RellenarTipos() {

            Dictionary<string, string> cboSource = new Dictionary<string, string>();
            cboSource.Add("1", "Otro");
            cboSource.Add("2", "Ciencia");
            cboSource.Add("3", "Letras");
            cboSource.Add("4", "Matematica");
            cboSource.Add("5", "Idioma");

            cboTipo.DataSource = new BindingSource(cboSource, null);
            cboTipo.DisplayMember = "Value";
            cboTipo.ValueMember = "Key";

        }

        private void CursoMan03_Load(object sender, EventArgs e) {

            try {
                RellenarTipos();
                cboTipo.SelectedValue = "1";

                objCursoBE = objCursoBL.ConsultarCurso(Id);

                //Llenar formulario
                lblCodigo.Text = objCursoBE.Id.ToString();
                txtNombre.Text = objCursoBE.Nombre;
                txtDescripcion.Text = objCursoBE.Descripcion;
                cboTipo.SelectedValue = objCursoBE.TipoCurso.ToString();
                mskHoras.Text = objCursoBE.HorasSemanales.ToString();
                chkActivo.Checked = Convert.ToBoolean(objCursoBE.Estado);
                
            }
            catch (Exception ex) {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }

        }

        private void btnGrabar_Click(object sender, EventArgs e) {
            try {
                if (txtNombre.Text.Trim() == String.Empty) {
                    throw new Exception("Debe ingresar un nombre del curso.");
                }
                if (mskHoras.MaskFull == false || mskHoras.Text == "0") {
                    throw new Exception("Debe ingresar el numero de horas semanales del curso.");
                }

                string usuario = clsCredenciales.Usuario;

                objCursoBE.Id = Convert.ToInt16(lblCodigo.Text.Trim());
                objCursoBE.Nombre = txtNombre.Text.Trim();
                objCursoBE.Descripcion = txtDescripcion.Text.Trim();
                objCursoBE.HorasSemanales = Convert.ToInt16(mskHoras.Text);
                objCursoBE.TipoCurso = Convert.ToInt16(cboTipo.SelectedValue);
                objCursoBE.UsuUltMod = usuario;
                objCursoBE.FechaUltMod = DateTime.Now;
                objCursoBE.Estado = Convert.ToInt16(chkActivo.Checked);

                if (objCursoBL.ActualizarCurso(objCursoBE) == true) {
                    this.Close();
                }
                else {
                    throw new Exception("No se actualizo el registro. Contacte con IT.");
                }

            }
            catch (Exception ex) {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}

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

    public partial class CursoMan02 : Form {

        CursoBL objCursoBL = new CursoBL();
        CursoBE objCursoBE = new CursoBE();
        
        public CursoMan02() {
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

        private void CursoMan02_Load(object sender, EventArgs e) {
            try {
                RellenarTipos();
                cboTipo.SelectedValue = "1";
            }
            catch (Exception ex) {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e) {
            try {
                if (txtNombre.Text.Trim() == String.Empty) {
                    throw new Exception("Debe ingresar un nombre del curso.");
                }
                if (mskHoras.MaskFull == false || mskHoras.Text == "0") {
                    throw new Exception("Debe ingresar el numero de horas semanales del curso.");
                }

                string usuario = clsCredenciales.Usuario;

                objCursoBE.Nombre = txtNombre.Text.Trim();
                objCursoBE.Descripcion = txtDescripcion.Text.Trim();
                objCursoBE.HorasSemanales = Convert.ToInt16(mskHoras.Text);
                objCursoBE.TipoCurso = Convert.ToInt16(cboTipo.SelectedValue);
                objCursoBE.UsuRegistro = usuario;
                objCursoBE.FechaRegistro = DateTime.Now;
                objCursoBE.UsuUltMod = usuario;
                objCursoBE.FechaUltMod = DateTime.Now;
                objCursoBE.Estado = Convert.ToInt16(chkActivo.Checked);
                
                if (objCursoBL.InsertarCurso(objCursoBE) == true) {
                    this.Close();
                }
                else {
                    throw new Exception("No se inserto el registro. Contacte con IT.");
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

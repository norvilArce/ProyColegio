using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProyColegio_BE;
using ProyColegio_BL;

namespace ProyColegio_GUI
{
    public partial class ProfesorMan03 : Form
    {
        ProfesorBE objProfesorBE = new ProfesorBE();
        ProfesorBL objProfesorBL = new ProfesorBL();

        public ProfesorMan03()
        {
            InitializeComponent();
        }
        private String _Id;
        public String Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private void ProfesorMan03_Load(object sender, EventArgs e)

        {
            try
            {                
                objProfesorBE = objProfesorBL.ConsultarProfesor(this.Id);

                lblId.Text = objProfesorBE.IdProfesor.ToString();
                txtNombre.Text = objProfesorBE.NomProfesor;
                txtApePat.Text = objProfesorBE.ApePatProfesor;
                txtApeMat.Text = objProfesorBE.ApeMatProfesor;
                txtEmail.Text = objProfesorBE.EmailProfesor;
                mskDni.Text = objProfesorBE.DniProfesor;
                dtpFecNac.Value = objProfesorBE.FecNacProfesor;
                txtTel.Text = objProfesorBE.TelProfesor;
                txtCel.Text = objProfesorBE.CelProfesor;
                txtDir.Text = objProfesorBE.DirProfesor;
                chkEstado.Checked = Convert.ToBoolean(objProfesorBE.Est_Prof);

                String idUbigeo = objProfesorBE.Id_Ubigeo;
                CargarUbigeo(idUbigeo.Substring(0, 2), idUbigeo.Substring(2, 2), idUbigeo.Substring(4, 2));
                Int16 IDCURSO = objProfesorBE.IdProfesor;
                CargarCurso(IDCURSO);
                                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

       

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            // agregar validaciones
            if (txtNombre.Text.Length == 0)
            {
                MessageBox.Show ("El Nombre no puede estar vacio.");
            }

            if (txtApePat.Text.Length == 0)
            {
                MessageBox.Show("El Apellido Paterno no puede estar vacio.");
            }
            if (txtApeMat.Text.Length == 0)
            {
                MessageBox.Show("El Apellido Materno no puede estar vacio.");
            }


            // Cargamos los valores ingresados desde el formulario...
            objProfesorBE.IdProfesor = Convert.ToInt16(lblId.Text);
            objProfesorBE.NomProfesor = txtNombre.Text.Trim();
            objProfesorBE.ApePatProfesor = txtApePat.Text.Trim();
            objProfesorBE.ApeMatProfesor = txtApeMat.Text.Trim();
            objProfesorBE.TelProfesor = txtTel.Text.Trim();
            objProfesorBE.CelProfesor = txtCel.Text.Trim();
            objProfesorBE.EmailProfesor = txtEmail.Text.Trim();
            objProfesorBE.Usu_Ult_Mod = clsCredenciales.Usuario;
            objProfesorBE.Est_Prof = Convert.ToInt16(chkEstado.Checked);

           if (objProfesorBL.ActualizarProfesor(objProfesorBE))
            {
                this.Close();
            }
            else
            {
                throw new Exception("Error, no se actualizo el registro. Contactar con IT.");

            }

        }

        private void CargarUbigeo(String IdDepa, String IdProv, String IdDist)
        {
            UbigeoBL objUbigeoBL = new UbigeoBL();
            cboDepartamento.DataSource = objUbigeoBL.Ubigeo_Departamentos();
            cboDepartamento.ValueMember = "IdDepa";
            cboDepartamento.DisplayMember = "Departamento";
            cboDepartamento.SelectedValue = IdDepa;

            cboProvincia.DataSource = objUbigeoBL.Ubigeo_ProvinciasDepartamento(IdDepa);
            cboProvincia.ValueMember = "IdProv";
            cboProvincia.DisplayMember = "Provincia";
            cboProvincia.SelectedValue = IdProv;

            cboDistrito.DataSource = objUbigeoBL.Ubigeo_DistritosProvinciaDepartamento(IdDepa, IdProv);
            cboDistrito.ValueMember = "IdDist";
            cboDistrito.DisplayMember = "Distrito";
            cboDistrito.SelectedValue = IdDist;
        }
        private void CargarCurso(Int16 IDCURSO)
        {
            CursoBL objCursoBL = new CursoBL();
            cboCursos.DataSource = objCursoBL.ListarCurso();
            cboCursos.ValueMember = "IDCURSO";
            cboCursos.DisplayMember = "NOMBRECURSO";
            cboCursos.SelectedValue = IDCURSO;
        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), "01", "01");
        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), cboProvincia.SelectedValue.ToString(), "01");
        }
    }
}

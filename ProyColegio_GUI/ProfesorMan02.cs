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

namespace ProyColegio_GUI
{
    public partial class ProfesorMan02 : Form
    {
        ProfesorBL  objProfesorBL = new ProfesorBL();
        ProfesorBE objProfesorBE = new ProfesorBE();

        public ProfesorMan02()
        {
            InitializeComponent();
        }

        private void ProfesorMan02_Load(object sender, EventArgs e)
        {
            try
            {
                CargarUbigeo("14", "01", "01");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
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

        private void btnGrabar_Click(object sender, EventArgs e)

        {
            try
            {
                objProfesorBE.NomProfesor = txtNombre.Text.Trim();
                objProfesorBE.ApePatProfesor = txtApePat.Text.Trim();
                objProfesorBE.ApeMatProfesor = txtApeMat.Text.Trim();
                objProfesorBE.EmailProfesor = txtEmail.Text.Trim();
                objProfesorBE.FecNacProfesor = dtpFecNac.Value;
                objProfesorBE.TelProfesor = txtTel.Text.Trim();
                objProfesorBE.CelProfesor = txtCel.Text.Trim();
                objProfesorBE.DniProfesor = mskDni.Text;
                objProfesorBE.DirProfesor = txtDir.Text.Trim();
                objProfesorBE.Id_Ubigeo = cboDepartamento.SelectedValue.ToString()
                    + cboProvincia.SelectedValue.ToString()
                    + cboDistrito.SelectedValue.ToString();
                objProfesorBE.Est_Prof = Convert.ToInt16(chkEstado.Checked);

                //agregar validaciones
                if (txtNombre.Text == "")
                {
                    throw new Exception("El campo nombre no puede estar vacio");
                }

                if (txtApePat.Text == "" | txtApeMat.Text == "")
                {
                    throw new Exception("Debe ingresar ambos apellidos");
                }

                if (!mskDni.MaskFull)
                {
                    throw new Exception("El DNI debe tener 8 caracteres");
                }

                if (objProfesorBL.InsertarProfesor(objProfesorBE))
                {
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

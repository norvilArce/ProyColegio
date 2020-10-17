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
    public partial class frmLogin : Form
    {

        Int16 intentos = 0;
        Int16 tiempo = 20;

        UsuarioBE objUsuarioBE = new UsuarioBE();
        UsuarioBL objUsuarioBL = new UsuarioBL();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text.Trim() !="" & txtPassword.Text.Trim() !="")
             {
                objUsuarioBE = objUsuarioBL.ConsultarUsuario(txtLogin.Text);

                if (objUsuarioBE.LogUsu == null)
                {
                    MessageBox.Show("Usuario no existe no no no",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos += 1;
                    ValidaAccesos(intentos);
                }
                
                if (txtLogin.Text == objUsuarioBE.LogUsu & txtPassword.Text == objUsuarioBE.PassUsu )
                {
                    // Si las credenciales son correctas se  registran las mismas en la clase estatica clsCredenciales
                    // y se lanza el MDI Principal
                    this.Hide();
                    timer1.Enabled = false;
                    clsCredenciales.Usuario = objUsuarioBE.LogUsu;
                    clsCredenciales.Password = objUsuarioBE.PassUsu;
                    clsCredenciales.Nivel = objUsuarioBE.NivUsu;
                    MDIPrincipal mdi = new MDIPrincipal();
                    mdi.ShowDialog();
                 }
                else
                { 
                    MessageBox.Show ("Usuario o Password incorrectos", 
                    "Mensaje",MessageBoxButtons .OK ,MessageBoxIcon .Error );
                    intentos +=1;
                    ValidaAccesos(intentos);

                }
            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacios",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
               intentos +=1;
                ValidaAccesos(intentos);
            }
           
        }

        private void ValidaAccesos(Int16 intIntentos)
        {
            if (intentos == 3)
            {
                MessageBox.Show("Lo sentimos,  sobrepaso el numero de intentos",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            tiempo -= 1;
            this.Text = "Ingrese su login y contraseña. Le quedan...." + tiempo;
            if (tiempo == 0)
            {
                MessageBox.Show("Lo sentimos, sobrepaso el tiempo de espera",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
            Application.Exit();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAceptar.PerformClick();
            }
        }
    }
}

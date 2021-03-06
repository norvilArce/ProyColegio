﻿using System;
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
    public partial class MDIPrincipal : Form
    {
        DateTime horaentrada = new DateTime();

        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlumnoMan01 alumnoMan01 = new AlumnoMan01();
            alumnoMan01.MdiParent = this;
            alumnoMan01.Show();
        }
        private void MDIPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Esta a punto de salir de la aplicacion ¿Desea Continuar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfesorMan01 profesorMan01 = new ProfesorMan01();
            profesorMan01.MdiParent = this;
            profesorMan01.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CursoMan01 cursoMan01 = new CursoMan01();
            cursoMan01.MdiParent = this;
            cursoMan01.Show();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = "Menu Principal - Sistema de colegio - " + DateTime.Now.ToString();
            lblHora.Text = "Tiempo de sesion : " + DateTime.Now.Subtract(horaentrada).ToString().Substring(0,8);
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = clsCredenciales.Usuario;
            horaentrada = DateTime.Now;
        }
    }
}
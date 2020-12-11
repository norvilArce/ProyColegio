using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyColegio_BE
{
    public class MatriculaBE
    {
        private Int16 mvarNummatricula;
        private Int16 mvaridperiodo;
        private Int16 mvaridalumno;
        private String mvar_usuRegistro;
        private DateTime mvar_fecRegistro;
        private String mvar_usuUltMod;
        private DateTime mvar_fecUltMod;
        private int mvar_estado;
        private DataTable Detalles;

        public Int16 idMatricula
        {
            get { return mvaridmatricula; }
            set { mvaridmatricula = value; }
        }

        
        public Int16 idPeriodo
        {
            get { return mvaridperiodo; }
            set { mvaridperiodo = value; }
        }

        
        public Int16 idAlumno
        {
            get { return mvaridalumno; }
            set { mvaridalumno = value; }
        }

        public String UsuRegistro
        {
            get { return mvar_usuRegistro; }
            set { mvar_usuRegistro = value; }
        }
        public DateTime FechaRegistro
        {
            get { return mvar_fecRegistro; }
            set { mvar_fecRegistro = value; }
        }
        public String UsuUltMod
        {
            get { return mvar_usuUltMod; }
            set { mvar_usuUltMod = value; }
        }
        public DateTime FechaUltMod
        {
            get { return mvar_fecUltMod; }
            set { mvar_fecUltMod = value; }
        }
        public int Estado
        {
            get { return mvar_estado; }
            set { mvar_estado = value; }
        }

        public DataTable DetalleMatricula
        {
            get { return Detalles; }
            set { Detalles = value; }

        }
    }
}

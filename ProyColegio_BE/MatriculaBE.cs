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
        private Int16 mvaridperiodo;
        private Int16 mvaridalumno;
        private Int16 mvargrado;
        private String mvar_usuRegistro;
        private int mvar_estado;
        private short mvaridmatricula;
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
        public Int16 grado {
            get { return mvargrado; }
            set { mvargrado = value; }
        }

        public String UsuRegistro
        {
            get { return mvar_usuRegistro; }
            set { mvar_usuRegistro = value; }
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

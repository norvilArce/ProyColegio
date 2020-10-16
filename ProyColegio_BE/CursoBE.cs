using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyColegio_BE {

    public class CursoBE {

        private int mvar_id;
        private String mvar_nombre;
        private String mvar_desc;
        private String mvar_usuRegistro;
        private int mvar_horasSemanales;
        private int mvar_tipoCurso;
        private DateTime mvar_fecRegistro;
        private String mvar_usuUltMod;
        private DateTime mvar_fecUltMod;
        private int mvar_estado;


        public int HorasSemanales {
            get { return mvar_horasSemanales; }
            set { mvar_horasSemanales = value; }
        }
        public int TipoCurso {
            get { return mvar_tipoCurso; }
            set { mvar_tipoCurso = value; }
        }
        public int Id {
            get { return mvar_id; }
            set { mvar_id = value; }
        }
        public String Nombre {
            get { return mvar_nombre; }
            set { mvar_nombre = value; }
        }
        public String Descripcion {
            get { return mvar_desc; }
            set { mvar_desc = value; }
        }
        public String UsuRegistro {
            get { return mvar_usuRegistro; }
            set { mvar_usuRegistro = value; }
        }
        public DateTime FechaRegistro {
            get { return mvar_fecRegistro; }
            set { mvar_fecRegistro = value; }
        }
        public String UsuUltMod {
            get { return mvar_usuUltMod; }
            set { mvar_usuUltMod = value; }
        }
        public DateTime FechaUltMod {
            get { return mvar_fecUltMod; }
            set { mvar_fecUltMod = value; }
        }
        public int Estado {
            get { return mvar_estado; }
            set { mvar_estado = value; }
        }
    }
}

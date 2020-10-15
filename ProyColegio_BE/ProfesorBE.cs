using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyColegio_BE
{
    public class AlumnoBE
    {
        private Int16 mvarid_alum;
        public Int16 IdAlumno
        {
            get { return mvarid_alum; }
            set { mvarid_alum = value; }
        }

        private String mvardni_alum;
        public String DniAlumno
        {
            get { return mvardni_alum; }
            set { mvardni_alum = value; }
        }

        private String mvarnom_alum;
        public String NomAlumno
        {
            get { return mvarnom_alum; }
            set { mvarnom_alum = value; }
        }

        private String mvarapepat_alum;
        public String ApePatAlumno
        {
            get { return mvarapepat_alum; }
            set { mvarapepat_alum = value; }
        }

        private String mvarapemat_alum;
        public String ApeMatAlumno
        {
            get { return mvarapemat_alum; }
            set { mvarapemat_alum = value; }
        }

        private String mvaremail_alum;
        public String EmailAlumno
        {
            get { return mvaremail_alum; }
            set { mvaremail_alum = value; }
        }

        private DateTime mvarfecnac_alum;
        public DateTime FecNacAlumno
        {
            get { return mvarfecnac_alum; }
            set { mvarfecnac_alum = value; }
        }

        private String mvartel_alum;
        public String TelAlumno
        {
            get { return mvartel_alum; }
            set { mvartel_alum = value; }
        }

        private Int16 mvarid_padre;
        public Int16 IdPadre
        {
            get { return mvarid_padre; }
            set { mvarid_padre = value; }
        }

        private String mavrdir_alum;
        public String DirAlumno
        {
            get { return mvardni_alum; }
            set { mvardni_alum = value; }
        }

        private String mvarid_ubigeo;
        public String Id_Ubigeo
        {
            get { return mvarid_ubigeo; }
            set { mvarid_ubigeo = value; }
        }

        private String mvarusu_registro;
        public String Usu_Registro
        {
            get { return mvarusu_registro; }
            set { mvarusu_registro = value; }
        }

        private DateTime mvarfec_registro;
        public DateTime Fec_Registro
        {
            get { return mvarfec_registro; }
            set { mvarfec_registro = value; }
        }

        private String mvarusu_ult_mod;
        public String Usu_Ult_Mod
        {
            get { return mvarusu_ult_mod; }
            set { mvarusu_ult_mod = value; }
        }

        private DateTime mvarfec_ult_mod;
        public DateTime Fec_Ult_Mod
        {
            get { return mvarfec_ult_mod; }
            set { mvarfec_ult_mod = value; }
        }

        private Int16 mvarest_alum;
        public Int16 Est_Alum
        {
            get { return mvarest_alum; }
            set { mvarest_alum = value; }
        }

        private Int16 mvarid_periodo;
        public Int16 IdPeriodo
        {
            get { return mvarid_periodo; }
            set { mvarid_periodo = value; }
        }

    }
}
